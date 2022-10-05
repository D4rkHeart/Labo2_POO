// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Bank UBS = new Bank();
BankAccount account = UBS.CreateAccount("John","Doe");
account.Credit(200);
//Ajout de 200 sur le compte de John Doe
//Ajout de 100 sur le compte de John Doe
//Retrait de 50 sur le compte de John Doe
//Ajout de 100 sur le compte de Suzette Proust
//Affichage d'un message d'erreur pour cause de solde insuffisant à hauteur de -200
//Retrait de 50 sur le compte de John Doe 
//Ajout de 50 sur le compte de  Suzette Proust
//Affichage de lsa réussite du transfert de 50 du compte de John Doe au compte de Suzette Proust 
//Affichage 