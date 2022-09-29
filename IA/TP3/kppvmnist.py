from operator import add
from statistics import mean
import numpy as np
import matplotlib.pyplot as plt
from sklearn.model_selection import train_test_split
from sklearn.utils import check_random_state
from sklearn import neighbors




#### Fonctions de chargement et affichage de la base mnist ####

def load_mnist(m,mtest):

	X = np.load("mnistX.npy")
	y = np.load("mnisty.npy",allow_pickle=True)

	random_state = check_random_state(0)
	permutation = random_state.permutation(X.shape[0])
	X = X[permutation]
	y = y[permutation]
	X = X.reshape((X.shape[0], -1))

	return train_test_split(X, y, train_size=m, test_size=mtest)


def showimage(x):
	plt.imshow( 255 - np.reshape(x, (28, 28) ), cmap="gray")
	plt.show()
	

#############################
#### Programme principal ####

# chargement de la base mnist:
Xtrain, Xtest, ytrain, ytest = load_mnist(10000, 1000)

print("Taille de la base d'apprentissage : ", Xtrain.shape)

# 2/ Utilisez le modèle pour prédire les étiquettes des 1000 exemples de test et estimez le risque du classifieur
K = 2
kppv = neighbors.KNeighborsClassifier(K)
kppv.fit(Xtrain,ytrain)

ypred = kppv.predict(Xtest)
ErreurTest = ypred == ytest

ErreurPourcent = np.mean(ErreurTest)*100

print("Pour K = ", K, ", le pourcentage d'erreur de l'algorithme est de ", ErreurPourcent, "%")

# 4/ Testez avec différentes valeurs de K et déterminez la meilleure valeur entre 1 et 10 pour cet hyperparamètre

bestPourcent = 0
index = 100
# On dispose de deux bases : une de test et une géante d'apprentissage
# Division base géante en une base d'apprentissage et une base de validation 
Xapp = Xtrain[0:9000, :]
Xval = Xtrain[9000:10000, :]
yapp = ytrain[0:9000]
yval = ytrain[9000:10000]

for i in range(1,15):
	# On applique le model pour K (qui varie de 1 à 15) sur la base d'apprentissage
	kppv = neighbors.KNeighborsClassifier(i)
	kppv.fit(Xapp,yapp)

	# On fait tourner notre algo sur la base de validation
	ypred = kppv.predict(Xval)
	# Et on voit à quel point l'algo s'est trompé
	ErreurTest = ypred == yval
	# On met cette erreur en pourcentage
	ErreurPourcent = np.mean(ErreurTest)*100

	print("Pour K = ", i, ", le pourcentage d'erreur de l'algorithme est de ", ErreurPourcent, "%")

	# On choisi le meilleur K
	if(ErreurPourcent > bestPourcent):
		index = i
		bestPourcent = ErreurPourcent

# On calcul les performances de l'algo pour le meilleur K (à partir de la base de test)
kppv = neighbors.KNeighborsClassifier(index)
kppv.fit(Xapp,yapp)
ypredFinal = kppv.predict(Xtest)
performance = ypredFinal == ytest

perfPourcent = np.mean(performance)*100

print("le meilleur K est ", index, "sa performance est de ", perfPourcent, "%")

