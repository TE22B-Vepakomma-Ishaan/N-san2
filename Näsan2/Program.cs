string[] toys = ["car", "doll", "8-ball", "cards", "lego"];

// for (int i = 0; i < toys.Count(); i++)
// {
//     System.Console.WriteLine(toys[i]);
// }

string[] classmates = ["bill", "clara", "amy", "steven", "darian"];
int[] num = [3, 7, 4, 5, 9];

for (int i = 0; i < 5; i++)
{
    System.Console.WriteLine($"{classmates[i]} gives the toy '{toys[i]}' a {num[i]}");
}


List<string> cities = new();

string input = "0";

while(input != "exit")
{
    System.Console.WriteLine("write a city name and add it to the database:");
    System.Console.WriteLine("(type 'exit' to leave.)");

    input = Console.ReadLine();
    if (input != "exit")
    {
        cities.Add(input);
    }

}

for (int i = 0; i < cities.Count(); i++)
{
    System.Console.WriteLine(cities[i]);
}

Console.ReadKey();