// See https://aka.ms/new-console-template for more information

//Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.
/*Console.WriteLine("Inserisci due numeri, selezionerò il maggiore!");
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
Console.WriteLine("Inserisci 10 numeri, ti restituirò la somma totale");

int sum = 0;

for (int i = 0; i < 10; i++)
{

  
    sum = sum + int.Parse(Console.ReadLine());


}

Console.WriteLine(sum);


//Snack 4: Calcola la somma e la media dei numeri da 2 a 10.

Console.WriteLine("Sommiamo i numeri da 2 a 10");
int sumNumber = 0;
int startNumber = 2;
int endNumber = 10;
for(int i = 2; i < 11; i++)
{
    sumNumber = sumNumber + i;
}
Console.WriteLine(sumNumber);
Console.WriteLine($"La media dei numeri è {sumNumber / (endNumber - (startNumber - 1))}");

//Snack 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
Console.WriteLine("Scegli un numero ");
int userNumber = int.Parse(Console.ReadLine());
if (userNumber % 2 == 0)
{
    Console.WriteLine($"il tuo numero è pari ed è {userNumber}");
}
else
{
    Console.WriteLine($"il tuo numero era dispari, quindi ho aggiunto 1, ora è{userNumber+1}");
}
//Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
string[] invited = { "luca", "giulia", "piero", "carlo", "andrea" };
Console.WriteLine("Inserisci il tuo nome");
string name = Console.ReadLine();
bool containName = invited.Contains(name);
if ( containName == true)
{
    Console.WriteLine("benvenuto alla festa, sei un invitato...mi dispiace per te");
}
else
{
    Console.WriteLine($"{name} sei fortunato, non sei invitato, e ti invidio");
}

//Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.


Console.WriteLine("Inserisci 6 numeri, se i numeri sono dispari li inserirò nella lista");
int[] evenNumbers = new int[6];

for(int i = 0; i < 6; i++)
{
   int number = int.Parse(Console.ReadLine());
    if(number % 2 != 0)
    {
        evenNumbers[i] = number;
    }
    
}
for (int i = 0; i < 6; i++)
{
    Console.WriteLine(evenNumbers[i]);
}


//Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
int [] numbers = { 9, 8, 7, 90, 87, 65 };
int sumOddNumbers = 0;
for(int i = 0; i < numbers.Length; i++)
{
   if (numbers[i] % 2 !=0)
    {
      sumOddNumbers = sumOddNumbers + numbers[i];
    }
}
Console.WriteLine(sumOddNumbers);
//Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
int[] arrayNumbers = new int[20];
int tot = 0;

    for (int i = 0; i < arrayNumbers.Length; i++) 
    {
      
    if (tot < 50) {
      Console.WriteLine("Inserisci un numero");
        int num = int.Parse(Console.ReadLine());
        tot += num;
    }    else
    {
    Console.WriteLine("esaerato!");
        break;
    }
    }*/



//Snack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.

Console.Write("Inserisci un numero");
int N = int.Parse(Console.ReadLine());
Random rnd = new Random();

for (int i = 0; i < N; i++)
{
    int[] array = new int[10];

    for (int j = 0; j < 10; j++)
    {
        array[j] = rnd.Next(1, 101); 
    }

    Console.WriteLine("Array " + (i + 1) + ":");
    for (int x = 0; x < 10; x++)
    {
        Console.WriteLine(array[x]);
    }
}
    





