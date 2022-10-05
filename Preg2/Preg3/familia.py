# -*- coding: utf-8 -*-
"""
Created on Wed Oct  4 00:12:19 2022

@author: cdani
"""

from pyswip import Prolog
prolog = Prolog()
prolog.assertz("male(daniel)")
prolog.assertz("female(luna)")
prolog.assertz("male(carlos)")
prolog.assertz("female(nancy)")
prolog.assertz("male(antonio)")
prolog.assertz("female(linda)")
prolog.assertz("male(luis)")
prolog.assertz("female(matilde)")
prolog.assertz("female(gloria)")
prolog.assertz("male(juan)")
prolog.assertz("male(jose)")
prolog.assertz("male(demetrio)")
prolog.assertz("male(raul)")
prolog.assertz("female(giovana)")
prolog.assertz("female(julia)")
prolog.assertz("male(ivan)")
prolog.assertz("male(fernando)")
prolog.assertz("female(angie)")
prolog.assertz("female(andrea)")
prolog.assertz("male(eduardo)")
prolog.assertz("female(cusi)")
prolog.assertz("female(maria)")
prolog.assertz("padre(X,Y):-male(X),parent(X,Y)")
prolog.assertz("madre(X,Y):-female(X),parent(X,Y)")
prolog.assertz("parent(carlos,daniel)")
prolog.assertz("parent(carlos,luna)")
prolog.assertz("parent(nancy,daniel)")
prolog.assertz("parent(nancy,luna)")
prolog.assertz("married(carlos,nancy)")
prolog.assertz("parent(antonio,carlos)")
prolog.assertz("parent(linda,carlos)")
prolog.assertz("married(antonio,linda)")
prolog.assertz("parent(luis,nancy)")
prolog.assertz("parent(matilde,nancy)")
prolog.assertz("married(luis,matilde)")
prolog.assertz("parent(matilde,gloria)")
prolog.assertz("parent(matilde,juan)")
prolog.assertz("parent(matilde,jose)")
prolog.assertz("parent(matilde,demetrio)")
prolog.assertz("parent(matilde,raul)")
prolog.assertz("parent(luis,gloria)")
prolog.assertz("parent(luis,juan)")
prolog.assertz("parent(luis,jose)")
prolog.assertz("parent(luis,demetrio)")
prolog.assertz("parent(luis,raul)")
prolog.assertz("parent(linda,giovana)")
prolog.assertz("parent(linda,julia)")
prolog.assertz("parent(linda,ivan)")
prolog.assertz("parent(antonio,giovana)")
prolog.assertz("parent(antonio,julia)")
prolog.assertz("parent(antonio,ivan)")
prolog.assertz("parent(demetrio,fernando)")
prolog.assertz("parent(jose,angie)")
prolog.assertz("parent(raul,andrea)")
prolog.assertz("parent(raul,eduardo)")
prolog.assertz("parent(julia,cusi)")
prolog.assertz("parent(ivan,maria)")
prolog.assertz("grandparent(X,Y):-parent(X,Z),parent(Z,Y)")
prolog.assertz("grandchild(X,Y):-grandparent(Y,X)")
prolog.assertz("abuelo(X,Y):-male(X),grandparent(X,Y)")
prolog.assertz("abuela(X,Y):-female(X),grandparent(X,Y)")
prolog.assertz("nieto(X,Y):-male(X),grandchild(X,Y)")
prolog.assertz("nieta(X,Y):-female(X),grandchild(X,Y)")
prolog.assertz("sibling(X,Y):-parent(Z,X),parent(Z,Y),X \= Y")
prolog.assertz("cousin(X,Y):-parent(Z,X),parent(W,Y),sibling(Z,W),not(sibling(X,Y)),X \== Y,Z \== W")
prolog.assertz("primo(X,Y):-male(X),cousin(X,Y)")
prolog.assertz("prima(X,Y):-female(X),cousin(X,Y)")
resultados = list(prolog.query("abuelo(X,Y)"))
for row in resultados:
        print(row["X"]," es abuelo de ",row["Y"])
resultados = list(prolog.query("nieto(X,Y)"))
for row in resultados:
        print(row["X"]," es nieto de ",row["Y"])
resultados = list(prolog.query("setof(Z,primo(X,Y),Set)"))
for row in resultados:
        print(row["X"]," es primo de ",row["Y"])