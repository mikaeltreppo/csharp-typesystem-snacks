﻿// See https://aka.ms/new-console-template for more information

//Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.
Console.WriteLine("Inserisci due numeri, selezionerò il maggiore!");
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

if(firstNumber > secondNumber)
{
    Console.WriteLine($"Il numero maggiore è {firstNumber}");
}
else if (firstNumber < secondNumber) 
{
    Console.WriteLine($"Il numero maggiore è {secondNumber}"); 
}
else
{
    Console.WriteLine("I numeri sono uguali");
}
//Snack 2 : L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.
Console.WriteLine("Inserisci due parole, selezionerò la Parola più lunga");
string firstWord = Console.ReadLine();
string secondWord =Console.ReadLine();

if (firstWord.Length > secondWord.Length)
{
    Console.WriteLine($"La parola più lunga è {firstWord}");
}
else if (firstWord.Length < secondWord.Length)
{
    Console.WriteLine($"La parola più lunga è {secondWord}");
}
else
{
    Console.WriteLine("Le parole sono uguali");
}
//Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.
//Snack 4: Calcola la somma e la media dei numeri da 2 a 10.
//Snack 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
//Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
//Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
//Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
//Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
//Snack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.