from ast import arg
import numpy as np
import matplotlib.pyplot as plt
import math
from sklearn import svm

# Chargement data defaultrail
data = np.loadtxt("defautsrails.dat")
X = data[:,:-1] # tout sauf la dernière colonne
y = data[:,-1] # uniquement la dernière colonne

# Creation des 4 models (un pour chaque valeur de y)
svm1 = svm.LinearSVC(C=math.inf, max_iter=100000)
svm2 = svm.LinearSVC(C=math.inf, max_iter=100000)
svm3 = svm.LinearSVC(C=math.inf, max_iter=100000)
svm4 = svm.LinearSVC(C=math.inf, max_iter=100000)

svmtab = [svm1, svm2, svm3, svm4]

# Creation matrice de lien entre les 4 models
G = np.zeros((140,4))

for i in range(4):
    # Si y = [1, 2, 3 ou 4], on met 1 ou -1
    # CAD y1 = tab de -1 ou 1 si le y de base vaut 1, y2 = tab de -1 ou 1 si le y de base vaut 2 etc
    yi = 2*(y==(i+1))-1

    # On applique le model (enfin les 4)
    svmtab[i].fit(X, yi)
    Ypred = svmtab[i].predict(X)

    # On calcul l'erreur de chacun de nos 4 models
    Err = np.mean(Ypred != yi)*100
    print("Erreur modele classification binaire", i, " :")
    print(Err)

    # On transforme nos 4 models en 1, on les combine :
    G[:,i] = svmtab[i].decision_function(X)

# notre y pred du model global
ypred = []
ypred.append(np.argmax(G, axis=1) + 1)

# Et son erreur
print("Erreur modele combinaison des classifieurs binaire :")
Err = np.mean(ypred != y)*100
print(Err)

print("Modele multiclass par validation croisée (LOO)")

def loo(X,y,svmtab):
    Erreur = 0
    for i in range(140):
        X_i = np.delete(X, i, axis=0)
        y_i = np.delete(y, i)
        
        Gbis = np.zeros(4)
        for j in range(4):
            yi = 2*(y_i==(j+1))-1
            svmtab[j].fit(X_i, yi)
            yPrevision = svmtab[j].predict(X_i)
            Gbis[j] = svmtab[j].decision_function([X[i,:]])
        fx = np.argmax(Gbis) + 1
        Err = fx != y[i]
        Erreur += Err

    monErreur = Erreur/140 * 100
    # print("Erreur de validation croisée :")
    # print(monErreur)
    return monErreur


# LOO :
loo(X,y, svmtab)

# On peut maintenant faire tourner cet algo pour differentes valeurs de C
# Puis on choisi le meilleur C et on refait l'algo sur (X,Y) (on applique notre model)

mistakes = []
mesC = [0.01,0.1,1,5,10,100]
for c in mesC:
    svm1 = svm.LinearSVC(C=c, max_iter=100000)
    svm2 = svm.LinearSVC(C=c, max_iter=100000)
    svm3 = svm.LinearSVC(C=c, max_iter=100000)
    svm4 = svm.LinearSVC(C=c, max_iter=100000)

    svmtabLoo = [svm1, svm2, svm3, svm4]
    # print("pour C =", c)
    mistakes.append(loo(X,y,svmtabLoo))

print("Le meilleur C est : ")
print(mesC[mistakes.index(min(mistakes))])

# Il faut maintenant calculer l'erreur de modele avec le bon C !
# Bon, du coup je ne le fait pas, car on a pas d'autres données... Il faut totalement modifier les boucles (cf photo au 07/10)
