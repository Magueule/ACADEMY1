## On Mac:

Run command: `dotnet run`

## Fonctionnement

En lançant l'application, vous commencez avec un solde de 0.

Vous avez le choix entre trois actions sur le prompt:

- Faire un crédit (Tapez 1)
- Faire un débit (Tapez 2)
- Quitter l'application (Tapez 3)

## Explication

Program.cs: l'entrée de l'application.

Transcation.cs: Classe d'une Transaction.

Credit.cs et Debit.cs: dérive d'une class Transaction en modifiant le Type.

TransactionService.cs: gére ce qui est lié au solde.

Parcours.cs: gestion des différents flux (demande de crédit, demande de débit).

Rules.cs: gestion des régles.

Text.cs: gestion des prompts.
