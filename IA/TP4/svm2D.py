import numpy as np
import matplotlib.pyplot as plt
import math
from sklearn import svm



#### programme principal à implémenter dans cette fonction ####
def monprogramme(Xapp, Yapp, C):
	"""
		Programme pour les SVM linéaires (lancé avec ESPACE)
		
		Xapp, Yapp : base d'apprentissage générée avec la souris
		C	: paramètre réglé par +/-
	"""
	print("Apprentissage lancé avec " + str(len(Xapp)) + " points et C = ", C)

	# à compléter pour apprendre le modèle SVM...
	svm2d = svm.LinearSVC(C=math.inf)
	svm2d.fit(Xapp, Yapp)


	# création d'une grille de points de test
	r1 = np.arange(-5,5,0.2)
	Xtest = np.zeros((len(r1)*len(r1),2))
	i = 0
	for x1 in r1:
		for x2 in r1:
			Xtest[i,:] = [x1, x2]
			i += 1
	
	# Prédire la catégorie pour tous les points de test...
	Ypred = svm2d.predict(Xtest)
		
	# ... et tracer le résultat
	XtestAbRouge = Xtest[Ypred == 2, 0]
	XtestOrdRouge = Xtest[Ypred == 2, 1]
	plt.plot(XtestAbRouge, XtestOrdRouge, 'or', alpha = 0.2)

	XtestAbBleu = Xtest[Ypred == 1, 0]
	XtestOrdBleu = Xtest[Ypred == 1, 1]
	plt.plot(XtestAbBleu, XtestOrdBleu, 'ob', alpha = 0.2)
	
	# tracer la droite séparation et les marges... 
	w = svm2d.coef_[0]
	b = svm2d.intercept_
	
	ford = (-b - w[0] * r1)/w[1] # Detail calcul en image dans le dossier

	plt.plot(r1,ford, 'k')

	# calculer et afficher la marge Delta...
	
	delta1 = (1 - b - w[0] * r1)/w[1]
	delta2 = (-1 - b - w[0] * r1)/w[1]
	plt.plot(r1,delta1, '--k')
	plt.plot(r1,delta2, '--k')
	
	# pour réellement mettre à jour le graphique: (à garder en fin de fonction)
	fig.canvas.draw()


def monprogrammeNL(Xapp, Yapp, C, sigma):
	"""
		Programme pour les SVM non linéaires (lancé avec N)
		
		Xapp, Yapp : base d'apprentissage générée avec la souris
		C	: paramètre réglé par +/-
		sigma : paramètre réglé par CTRL +/-
	"""
	print("Apprentissage lancé avec " + str(len(Xapp)) + " points, C = ", C, " et sigma = ", sigma )

	# à compléter pour apprendre le modèle SVM non linéaire...
	
	svm2d = svm.SVC(C = C, kernel= 'rbf', gamma=1/(2*sigma**2))
	svm2d.fit(Xapp, Yapp)
	
	# création d'une grille de points de test
	r1 = np.arange(-5,5,0.2)
	Xtest = np.zeros((len(r1)*len(r1),2))
	i = 0
	for x1 in r1:
		for x2 in r1:
			Xtest[i,:] = [x1, x2]
			i += 1
	
	# Prédire la catégorie pour tous les points de test...
	Ypred = svm2d.predict(Xtest)
	
	# ... et tracer le résultat 
	g = svm2d.decision_function(Xtest)
	plt.scatter(Xtest[:, 0], Xtest[:, 1], c=g, cmap="seismic", alpha=0.2)

	XtestAbRouge = Xtest[Ypred == 2, 0]
	XtestOrdRouge = Xtest[Ypred == 2, 1]
	plt.plot(XtestAbRouge, XtestOrdRouge, 'or', alpha = 0.2)

	XtestAbBleu = Xtest[Ypred == 1, 0]
	XtestOrdBleu = Xtest[Ypred == 1, 1]
	plt.plot(XtestAbBleu, XtestOrdBleu, 'ob', alpha = 0.2)

	# afficher le nombre de vecteurs support...	
	
	
	
	# pour réellement mettre à jour le graphique: 
	fig.canvas.draw()
	



##### Gestion de l'interface graphique ########


Xplot = np.zeros((0,2))
Yplot = np.zeros(0)
plotvariance = 0

C = 1
sigma = 1

def onclick(event):
	global Xplot
	global Yplot
	
	
	if plotvariance == 0:
		newX = np.array([[event.xdata,event.ydata]])
	else:
		newX = math.sqrt(plotvariance) * np.random.randn(10, 2) + np.ones((10,1)).dot(np.array([[event.xdata,event.ydata]]))

	print("Ajout de " + str(len(newX)) + " points en (" + str(event.xdata) + ", " + str(event.ydata) + ")")

	Xplot = np.concatenate((Xplot,newX))
	if event.button == 1 and event.key == None:
		plt.plot(newX[:,0], newX[:,1],'.b')
		newY = np.ones(len(newX)) * 1
	elif event.button == 3 and event.key == None:
		plt.plot(newX[:,0], newX[:,1],'.r')
		newY = np.ones(len(newX)) * 2
	Yplot = np.concatenate((Yplot,newY))
	
	fig.canvas.draw()


def onscroll(event):
	global plotvariance
	if event.button == "up":
		plotvariance = round(plotvariance + 0.2, 1)
	elif event.button == "down" and plotvariance > 0.1:
		plotvariance = round(plotvariance - 0.2, 1)
	print("Variance = ", plotvariance)

def onkeypress(event):
	global C
	global sigma
	if event.key == " ":
		monprogramme(Xplot, Yplot, C)
	elif event.key == "n":
		monprogrammeNL(Xplot, Yplot, C, sigma)
	elif event.key == "+":
		C *= 2
		print("C = " , C)
	elif event.key == "-":
		C /= 2
		print("C = " , C)
	elif event.key == "alt++":
		sigma *= 2
		print("sigma = " , sigma)
	elif event.key == "alt+-":
		sigma /= 2
		print("sigma = " , sigma)
				
	
fig = plt.figure()

plt.axis([-5, 5, -5, 5])

cid = fig.canvas.mpl_connect("button_press_event", onclick)
cid2 = fig.canvas.mpl_connect("scroll_event", onscroll)
cid3 = fig.canvas.mpl_connect("key_press_event", onkeypress)

print("Utilisez la souris pour ajouter des points à la base d'apprentissage :")
print(" clic gauche : points bleus")
print(" clic droit : points bleus")
print("\nMolette : +/- variance ")
print("   si variance = 0  => ajout d'un point")
print("   si variance > 0  => ajout de points selon une loi gaussienne")
print("\n ESPACE pour lancer la fonction monprogramme(Xapp,Yapp,C)")
print("    avec la valeur de C modifiée par +/-") 
print("\n N pour lancer la fonction monprogrammeNL(Xapp,Yapp,C,sigma)")
print("    avec la valeur de C modifiée par +/-")
print("    et celle de sigma modifiée par ALT +/-\n\n") 

plt.show()
