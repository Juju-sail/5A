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

# à compléter... 







