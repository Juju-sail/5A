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
    print(Err)

    # On transforme nos 4 models en 1, on les combine :
    G[:,i] = svmtab[i].decision_function(X)

# notre y pred du model global
ypred = []
ypred.append(np.argmax(G, axis=1) + 1)

# Et son erreur
Err = np.mean(ypred != y)*100
print(Err)

# LOO :
Gbis = np.zeros((139,4))
for i in range(140):
    X_i = np.delete(X, i, axis=0)
    y_i = np.delete(y, i)

    for j in range(4):
        yi = 2*(y_i==(j+1))-1
        svmtab[j].fit(X_i, yi)
        yPrevision = svmtab[j].predict(X_i)
        Gbis[:,j] = svmtab[j].decision_function([X[i,:]])
        Err = np.mean(yPrevision != yi)*100
Erreur = np.mean(Err)
print(Erreur)   
# A modif des que possible