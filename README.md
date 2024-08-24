# Two-Dice Pig

## Description
Two-Dice Pig est un jeu de dés simple et amusant où les joueurs s'affrontent pour atteindre un score prédéfini. Le jeu est développé en C# avec Windows Forms pour l'interface utilisateur.

## Installation
1. Clonez le dépôt :
    ```sh
    git clone https://github.com/votre-utilisateur/two-dice-pig.git
    ```
2. Ouvrez le fichier `Two-Dice Pig.sln` avec Visual Studio.
3. Restaurez les packages NuGet si nécessaire.
4. Compilez et exécutez le projet.

## Utilisation
1. Lancez l'application.
2. Entrez les noms des joueurs.
3. Cliquez sur "Commencer" pour commencer une nouvelle partie.
4. Utilisez les boutons pour lancer les dés et accumuler des points.
5. Le premier joueur à atteindre le score prédéfini gagne la partie.

## Fonctionnalités
- Interface utilisateur intuitive avec Windows Forms.
- Support pour jusqu'à 4 joueurs.
- Gestion des scores et des tours de jeu.
- Messages d'erreur et validation des entrées utilisateur.

## Règles du jeu "Two-Dice Pig"

### Objectif
Être le premier joueur à atteindre un score prédéfini (généralement 100 points).

### Déroulement du jeu
1. **Tour de jeu**: Chaque joueur lance deux dés autant de fois qu'il le souhaite pour accumuler des points dans un score temporaire.
2. **Fin du tour**: Le joueur peut "garder" ses points à tout moment, ajoutant le score temporaire à son score total, puis c'est au tour du joueur suivant.
3. **Règles spéciales**:
    - **Un des dés montre un 1**: Le joueur perd tous les points du tour et passe son tour.
    - **Les deux dés montrent un 1**: Le joueur perd tous les points du tour et son score total est réduit à zéro.

### Fin de la partie
La partie se termine lorsqu'un joueur atteint ou dépasse le score prédéfini. Ce joueur est déclaré vainqueur.
