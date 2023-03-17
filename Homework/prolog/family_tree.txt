:- use_module(library(clpb)).

male(a2).
male(a4).
male(b2).
male(c2).
male(c3).
male(c5).
male(d1).
male(d4).
male(d6).
male(e2).
male(e4).

female(a1).
female(a3).
female(b1).
female(c1).
female(c4).
female(d2).
female(d3).
female(d5).
female(d7).
female(e1).
female(e3).

parent(a1,b1).
parent(a2,b1).
parent(a3,b2).
parent(a4,b2).
parent(b1,c2).
parent(b1,c3).
parent(b1,c4).
parent(b2,c2).
parent(b2,c3).
parent(b2,c4).
parent(c1,d1).
parent(c1,d2).
parent(c1,d3).
parent(c2,d1).
parent(c2,d2).
parent(c2,d3).
parent(c4,d6).
parent(c4,d7).
parent(c5,d6).
parent(c5,d7).
parent(d3,e1).
parent(d3,e2).
parent(d4,e1).
parent(d4,e2).
parent(d5,e3).
parent(d5,e4).
parent(d6,e3).
parent(d6,e4).

/* 
    Learned about the setof() predicate from this video: https://www.youtube.com/watch?v=e9uQMf9NyKA

    Learned about the list member() predicated from here: https://www.swi-prolog.org/pldoc/man?predicate=member/2
*/ 
hasSon(X) :- parent(X,Z), male(Z).
couple(X,Y) :- parent(X,Z), parent(Y,Z), X\==Y.
auncleBlood(Auncle) :- setof(Auncle,(Sib,Child)^(sibling(Auncle,Sib),parent(Sib,Child)),Results), member((Auncle), Results).
auncleMarriage(Auncle) :- setof(Auncle, (Partner)^(couple(Auncle,Partner), auncleBlood(Partner)), Results), member((Auncle), Results).
am(X,Y) :- couple(X,Y), auncleBlood1(Y,X).


nephew(X) :- setof(X, (Z,Y)^(parent(Z,X), sibling(Z,Y), male(X)), Results), member((X), Results).
son(X) :- setof(X, Y^(parent(Y,X), male(X)), Results), member((X), Results).
daughter(X) :- setof(X, Y^(parent(Y,X), female(X)), Results), member((X), Results).
grandparent(X) :- setof(X, Y^(parent(X,Z), parent(Z,Y)), Results), member((X), Results).
parent(X) :- setof(X, Y^(parent(X,Y)), Results), member((X), Results).
greatGrandparent(X) :- setof(X, Z^(parent(X,Z), grandparent(Z)), Results), member((X), Results).
auncle(X) :- auncleBlood(X) ; auncleMarriage(X).
sibling(X,Y) :- setof((X,Y), Z^(parent(Z,X),parent(Z,Y), X\==Y), Results), member((X,Y), Results).

