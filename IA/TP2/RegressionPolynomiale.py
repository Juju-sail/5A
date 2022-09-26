import numpy as np
import matplotlib.pyplot as plt

def polyreg(X, Y, degre):
	""" Fonction d'apprentissage sur la base (X,Y)
	w = polyreg(X, Y, degre)
	w 	: paramètres du modèle polynomial f 
	degre : degre du polynome f
	X 	= [x1; x2; x3; ... ; xm]
	Y 	= [y1; y2; y3; ... ; ym]
	"""
	
	m = len(Y)
	n = degre + 1
	Phi = np.zeros((m, n))

	for i in range(n):
		# Creation matrice Phi(x) = [x^0, x^1, ..] avec x = [x1, x2, ...] :
		Phi[:,i] = X[:]**i

	# Calcul de w par les moindres carrés :
	res = np.linalg.lstsq(Phi,Y) 
	w = res[0]
	
	#print(w)

	return w

def polypred(X, w):
	"""
	Fonction de prédiction Y = polypred(X, w)
	
	w 	: paramètres du modèle polynomial f issus de polyreg
	X 	: vecteur de taille N contenant les N valeurs de x où évaluer le polynome f(x)
	Y 	: valeurs de polynome f(X) 
	"""
	m = len(X)
	n = len(w)
	Phi = np.zeros((m, n))
	for i in range(n):
		Phi[:,i] = X**i
	
	Y = Phi.dot(w)
	
	return Y


########### programme principal ########


## 1) générer une base de données de 1000 points X,Y

m = 1000
X = 6 * np.random.rand(m) - 3
Y = np.sinc(X) + 0.2 * np.random.randn(m)


# 2) Créer un base d'apprentissage (Xapp, Yapp) de 30 points parmi ceux de (X,Y) et une base de test(Xtest,Ytest) avec le reste des données

indexes = np.random.permutation(m)  # permutation aléatoire des 1000 indices entre 0 et 1000 
indexes_app = indexes[:30]  # 30 premiers indices
indexes_test = indexes[30:] # le reste

Xapp = X[indexes_app]
Yapp = Y[indexes_app]

Xtest = X[indexes_test]
Ytest = Y[indexes_test]

# ordronner les Xtest pour faciliter le tracé des courbes
idx = np.argsort(Xtest)
Xtest = Xtest[idx]
Ytest = Ytest[idx]

# tracer la figure

# plt.plot(Xtest,Ytest,'.r')
plt.figure(0)
plt.plot(Xtest,Ytest,'.r')
plt.plot(Xapp,Yapp,'*b')
plt.plot(Xtest,np.sinc(Xtest) , 'g')

## 3) implémenter les fonctions polyreg et polypred pour la régression polynomiale unidimensionelle
w = polyreg(Xapp,Yapp,5)
Ypred = polypred(Xtest,w)

plt.plot(Xtest,Ypred)

# 4) Réaliser l'apprentissage d'un modèle de degré 5 et calculer les erreurs d'apprentissage et de test
ErreurTest5 = np.mean((Ytest - Ypred)**2)
print(ErreurTest5)

plt.figure(1)

# 5) Choix degré optimal : on boucle pour tout montrer : les courbe et les erreurs
plt.plot(Xapp,Yapp,'*b')
plt.plot(Xtest,np.sinc(Xtest) , 'g')
plt.legend(['base app', 'f_reg(x)'])
plt.axis([-3, 3, -0.8, 1.5])
ListErreur = []
for i in range(15):
	w = polyreg(Xapp, Yapp, i)
	Ypred = polypred(Xtest, w)
	plt.plot(Xtest, Ypred)

	ErreurTest = np.mean((Ytest - Ypred)**2)
	ListErreur.append(ErreurTest)

plt.figure(2)

plt.plot(ListErreur)


# Affichage des graphiques : 
# (à ne faire qu'en fin de programme)
plt.show() # affiche les plots et attend la fermeture de la fenêtre

