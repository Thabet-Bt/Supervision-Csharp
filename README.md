# Supervision-Csharp

                                        Présentation de l’application réalisée

  Le logiciel de supervision et contrôle d’un four électrique est basée sur la plateforme .NET sous le
système d’exploitation Windows, il est développé avec le langage oriente objet C#(C Sharp) qui
permet la flexibilité et la structuration de coude source, ainsi que la rapidité d’exécution.

Ce logiciel a pour but de contrôler et superviser le four électrique du laboratoire.

Pour La supervision, le software contient plusieurs fenêtres (interface graphique) chacune
pour assure une tache spécifique tel que : la gestion des alarmes, archivage, synoptique
…etc.

Enfin, l’acquisition des données est une tâche principale dans notre software, il permet
d’acquérir les valeurs de la température du four et assurer l’envoi de signal de commande



                                                    Acquisition des donnes :

Le principe d’un système d’acquisition des données est la mesure d’une grandeur physique ou un signal électrique.
L’acquisition des donnes  sur PC  est présentée par l’interface  d’une carte électronique  et un logiciel sur l’ordinateur, cette relation est assurée par un protocole de communication qui permet l’envoi des donnes réel entre les deux.
En résume, un système d’acquisition des données assurée les taches suivants :
•	Recueillir des informations et les mesures de capteur.
•	Enregistrer la température du four.
•	Créer un lien entre le four électrique et l’interface graphique de l’ordinateur.
•	Définir un canal de sortie analogique ou numérique en temps réel
Les constituants d’un système d’acquisition des donnes sont :
•	Acquisition des donnes (Capteurs, conditionneurs)
•	Transformations des donnes (CAN/CNA)
•	Traitement des données (calculateur numérique)


                                                    Supervision :
                                                    
La Partie de software dans notre système de supervision est assure par une interface graphique développé à l’aide de langage C#, Cette interface permettant d’exécuter des algorithmes de contrôle et aussi la visualisation de l’évolution des paramètres du processus.
Notre application est compose de parties suivants :
•	Synoptique.
•	Courbes.
•	Alarmes.
•	Historisation de procédé.
•	Gestion des paramètres de control.
•	Gestion de base de données.

        	        Synoptique :
C’est la fonction essentielle de notre software, elle fournit une représentation synthétique, dynamique et instantanée de l'ensemble des paramètres de procédé.
Permet à l'opérateur d'interagir avec le processus et de visualiser la température de four en temps réel.

La synoptique comporte les parties suivants :
•	Etat de procédé (1): Démarrer ou arrêté le procédé.
•	Etat d’alarme(2) : affichage de statuts d’alarme.
•	La température désirée (5) : Edition et l’affichage de la consigne.
•	Courbes (11): visualisation en temps réel des variables entrées/sortie (commande/réponse du four).
•	Communication port série (8): configuration de port série, ouvrir et ferme une connexion.
•	Choix de régulateur (10): choix de régulateur utilise.
•	Configuration du seuil d’alarme (9): préciser le seuil minimal et maximal d’alarme.
•	Boucle de régulation (6): représente le schéma fonctionnel de procédé.
•	Affichage des paramètres de procédé (3) (4): affichage de la valeur moyen de température du four, ainsi que les paramètres des régulateurs et la valeur de l’écart entre la consigne et valeur réelle.
•	Barre d’outils (7): permet l’accès à différentes fenêtres du logiciel.

                    Courbes :
C’est la partie responsable de la présentation graphique en temps réel de signal de commande et de la valeur de température réelle du four. Elle Donne des outils utilisés pour la modification sur les propriétés des courbes.


                    Alarme :

Cette partie est responsable de fonctions suivantes :
•	surveillance en temps réel sur le fonctionnement de processus.
•	Configuration des seuils de déclenchement d’alarme.
•	Affiche l'ensemble des alarmes selon des règles de priorité.
•	Filtrer l’ensemble des alarmes selon des conditions sélectionné.
•	Assure l'enregistrement de toutes les étapes de traitement de l'alarme


                    Historisation du procédé :
La fenêtre « historique » est permet de :
•	la sauvegarde périodique de la valeur de température.
•	la sauvegarde d'événements horodatés (archivage sélectif).
•	Fournit les outils de recherche dans les données archivées.
•	sauvegarder une série de donnes(les valeurs de température ou la commande) dans un fichier sélectionné.
•	tracer une courbe pour une série de donnes archivées.

                    Gestion des paramètres de Contrôle :
                    
C’est la partie responsable de fonctions suivantes :
•	permet de configurer les paramètres de régulateur.
•	modification de la consigne.
•	sélectionner le mode de fonctionnement Auto/Manuel.
•	configuration des paramètres de connexion de la base de donnes SQL SERVER.
•	permet de sauvegarder un backup de la base de donnes.
                    Gestion de base des données :
                    
Dans les systèmes de supervision industrielle, la base de donnes est la partie indispensable qui relie  toutes ces éléments, elle permet de :
•	sauvegarder la valeur moyenne de température dans un tableau à la base de donnes SQL server.
•	l’enregistrement de toutes les taches et configuration manipules durant le fonctionnement du système.



Pour plus d'informations :  bourouis.thabet@gmail.com
