import numpy as np
import matplotlib.pyplot as plt

# Q1 Création du jeu de données
X = 10 * np.random.rand(1000, 5) - 5 # Création d'une matrice 1000x5 de nombres entre -5 et 5.

# Q6 Modification d'une des colones de X
X[:,4] = 2*X[:,3]

# Q2 Generation du vecteur des etiquettes correspondantes
w_star = np.array([1.2, -1.3, 0.5, 0.8, -2.3])

v = np.random.randn(1000) # Vecteur normal (1000,) de moyenne 0 et de variance 1.

y = X.dot(w_star) + v # Fonction linéaire de X par w bruité par v.

print(y.shape) # Affiche la dimmension de y (vecteur issus de regression linéaire)

# Q3 Calcul coeficient directeur de la droite d'estimation (en commentaire pour la Q6)
# w_chap = np.linalg.inv(X.T@X)@X.T@y
# print("w^ = ", w_chap)

# Q4 Idem mais sans inversion de matrice
res = np.linalg.lstsq(X,y)
w_c = res[0]
print("w^ = ", w_c)

# Q5 test avec differentes valeurs de m (observation ameliroation de l'estimation)
liste = []
m_val = [10, 100, 1000, 10000, 100000, 1000000]
for m in m_val:
    # Pour faire propre il aurait fallut faire une fonction car là c'est très moche - mais ça fonctionne !
    X = 10 * np.random.rand(m, 5) - 5
    v = np.random.randn(m)
    y = X.dot(w_star) + v
    res = np.linalg.lstsq(X,y)
    w_c = res[0]
    liste.append(np.linalg.norm(w_c - w_star))

plt.plot(m_val, liste)
plt.show()