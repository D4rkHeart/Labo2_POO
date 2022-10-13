// See https://aka.ms/new-console-template for more information
Bank UBS = new Bank();
BankAccount JohnDoe = UBS.CreateAccount("John","Doe");
BankAccount JohnDoe2 = UBS.CreateAccount("John","Doe");
//Ajout de 200 sur le compte de John Doe
JohnDoe.Credit(200);
//Ajout de 100 sur le compte de John Doe
JohnDoe2.Credit(100);
//Retrait de 50 sur le compte de John Doe
JohnDoe.Debit(50);
//Creation du compte de Suezze Proust
BankAccount SuzetteProust = UBS.CreateAccount("Suzette","Proust");
//Ajout de 100 sur le compte de Suzette Proust
SuzetteProust.Credit(100);
//Affichage d'un message d'erreur pour cause de solde insuffisant à hauteur de -200
SuzetteProust.Debit(200);
//Retrait de 50 sur le compte de John Doe 
//Ajout de 50 sur le compte de  Suzette Proust
//Affichage de la réussite du transfert de 50 du compte de John Doe au compte de Suzette Proust 
JohnDoe.Transfer(SuzetteProust, 50);
//Affichage d'un message d'erreur pour cause de solde insuffisant à hauteur de -200
SuzetteProust.Transfer(JohnDoe,200);
//Affiche le solde de chaque compte et la fortune totale du client
Customer GillesSurchat = new Customer("Gilles","Surchat");
UBS.GetCustomerSummary(JohnDoe.Owner);
UBS.GetCustomerSummary(SuzetteProust.Owner);
UBS.GetCustomerSummary(GillesSurchat);