
using System.Text;

Console.WriteLine("Enter symbols");

var UserInput = Console.ReadLine();

StringBuilder Array = new StringBuilder(UserInput);

for (int i = 0; i < Array.Length; i++)
{
    char Simbol = Array[i];

    int Counter = 1;

    for (int j = i + 1; j < Array.Length; j++)
    {
        if (Simbol == Array[j])
        {
            Counter++;

            Array.Remove(j, 1);

            j--;
        }
    }
    Console.WriteLine($" {Simbol} - {Counter} ");
}


