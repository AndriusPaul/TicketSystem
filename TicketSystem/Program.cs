using System.Runtime.CompilerServices;
int bilietai10, bilietai20, bilietai30;
int bilietuKiekis10 = 0, bilietuKiekis20 = 0, bilietuKiekis30 = 0;
int visoBilietu10 = 0, visoBilietu20 = 0, visoBilietu30 = 0;
int nepanaudotiBilietai10 = 0, nepanaudotiBilietai20 = 0, nepanaudotiBilietai30 = 0;
int sukurtaBilietu10 , sukurtaBilietu20, sukurtaBilietu30;
Init();

void Init()
{
    while (true)
    {
        int firstSelect = GetFirstInputFromConsole();
        CreateMenu(firstSelect);
        Console.WriteLine("Jeigu norite pradeti is naujo, paspauskite 'Enter'");
        Console.ReadLine();
        Console.Clear();

    }
}

void CreateMenu(int userInput)
{
    switch (userInput)
    {
        case 1:
            int secondSelect = GetSecondInputFromConsole();
            ParduotiBilietus(secondSelect);
            break;
        case 2:
            int thirdSelect = GetThirdInputFromConsole();
            KurtiBilietus(thirdSelect);
            break;
        case 3:
            BilietuPardavimoAtaskaita();
            break;
        case 4:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Pasirinkite skaiciu is meniu");
            break;
    }
}
int ParduotiBilietus(int userInput)
{
    int result = 0;
    switch (userInput)
    {
        case 1:
            BuyBilietai10();
            break;
        case 2:
            BuyBilietai20();
            break;
        case 3:
            BuyBilietai30();
            break;
        default:
            Console.WriteLine("Pasirinkite bilietus is duoto saraso");
            result = 0;
            break;
    }

    Console.WriteLine();
    return result;
}
int KurtiBilietus(int userInput)
{
    int result = 0;
    switch (userInput)
    {
        case 1:
            CreateBilietai10();
            break;
        case 2:
            CreateBilietai20();
            break;
        case 3:
            CreateBilietai30();
            break;
        default:
            result = 0;
            break;
    }
    return result;
}

int GetFirstInputFromConsole()
{
    bool isCorrectNumber = false;
    int argumentValue = 0;

    while (!isCorrectNumber)
    {
        Console.WriteLine("Meniu: [1] Pirkti bilietus, [2] Kurti bilietus, [3] Ataskaita, [4] Iseiti is programos");
        string userInputValue = Console.ReadLine();
        //TODO: exit method
        if (int.TryParse(userInputValue, out argumentValue))
        {
            isCorrectNumber = true;
        }
        else
        {
            Console.WriteLine("Please, select number from meniu");
        }
    }
    return argumentValue;
}
int GetSecondInputFromConsole()
{
    bool isCorrectNumber = false;
    int argumentValue = 0;

    while (!isCorrectNumber)
    {
        Console.WriteLine("Pasirinkite bil. Tipa: [1] Po 10Eur, [2] Po 20Eur, [3] Po 30Eur");
        string userInputValue = Console.ReadLine();
        //TODO: exit method
        if (int.TryParse(userInputValue, out argumentValue))
        {
            isCorrectNumber = true;
        }
        else
        {
            Console.WriteLine("Please, select number from meniu");
        }
    }
    return argumentValue;
}
int GetThirdInputFromConsole()
{
    bool isCorrectNumber = false;
    int argumentValue = 0;

    while (!isCorrectNumber)
    {
        Console.WriteLine("Sukurti bilietus:");
        Console.WriteLine("Pasirinkite bil. Tipa: [1] Po 10Eur, [2] Po 20Eur, [3] Po 30Eur");
        string userInputValue = Console.ReadLine();
        //TODO: exit method
        if (int.TryParse(userInputValue, out argumentValue))
        {
            isCorrectNumber = true;
        }
        else
        {
            Console.WriteLine("Please, select number from meniu");
        }
    }
    return argumentValue;
}
int GetValueFromConsole()
{
    bool isCurrentNumber = false;
    int argumentValue = 0;
    while (!isCurrentNumber)
    {
        Console.WriteLine("Iveskite kieki:");
        string userInputValue = Console.ReadLine();
        if (int.TryParse(userInputValue, out argumentValue))
        {
            isCurrentNumber = true;
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
    }
    return argumentValue;
}
void BilietuPardavimoAtaskaita()
{
    Console.WriteLine("Parduota bilietu:");
    Console.WriteLine($"Uz 10eur: {visoBilietu10}");
    Console.WriteLine($"Uz 20eur: {visoBilietu20}");
    Console.WriteLine($"Uz 30eur: {visoBilietu30}");
    Console.WriteLine("**************************");
    Console.WriteLine("Sukurta bilietu:");
    Console.WriteLine($"Sukurta uz 10eur: {bilietuKiekis10}");
    Console.WriteLine($"Sukurta uz 20eur: {bilietuKiekis20}");
    Console.WriteLine($"Sukurta uz 30eur: {bilietuKiekis30}");
    Console.WriteLine("**************************");
    Console.WriteLine("Nepanaudota bilietu:");
    Console.WriteLine($"Uz 10eur: {nepanaudotiBilietai10}");
    Console.WriteLine($"Uz 20eur: {nepanaudotiBilietai20}");
    Console.WriteLine($"Uz 30eur: {nepanaudotiBilietai30}");
    Console.WriteLine("**************************");
}

int BuyBilietai10()
{
    int result = 0;
    Console.WriteLine("Pirkti bilietus uz 10Eur:");
    bilietai10 = GetValueFromConsole();
    if (bilietai10 <= nepanaudotiBilietai10)
    {
        result = 10 * bilietai10;
        visoBilietu10 += bilietai10;
        nepanaudotiBilietai10 -= bilietai10;
        Console.WriteLine($"Bilietams isleista: {result}Eur");
    }
    else
    {
        Console.WriteLine($"Tiek bilietu nera, bilietu likutis yra {nepanaudotiBilietai10}");
    }
    
    return result;
}
int BuyBilietai20()
{
    int result = 0;
    Console.WriteLine("Pirkti bilietus uz 20Eur:");
    bilietai20 = GetValueFromConsole();
    if (bilietai20 <= nepanaudotiBilietai20)
    {
        
        result = 20 * bilietai20;
        visoBilietu20 += bilietai20;
        nepanaudotiBilietai20 -= bilietai20;
        Console.WriteLine($"Bilietams isleista: {result}Eur");
    }
    else
    {
        Console.WriteLine($"Tiek bilietu nera, bilietu likutis yra {nepanaudotiBilietai10}");
    }
    
    return result;
}
int BuyBilietai30()
{
    int result = 0;
    Console.WriteLine("Pirkti bilietus uz 30Eur:");
    bilietai30 = GetValueFromConsole();
    if (bilietai30 <= nepanaudotiBilietai30)
    {
        
        result = 30 * bilietai30;
        visoBilietu30 += bilietai30;
        nepanaudotiBilietai30 -= bilietai30;
        Console.WriteLine($"Bilietams isleista: {result}Eur");

    }
    else
    {
        Console.WriteLine($"Tiek bilietu nera, bilietu likutis yra {nepanaudotiBilietai10}"); ;
    }
    
    return result;
}

void CreateBilietai10()
{
    
    Console.WriteLine("Kurti bilietus uz 10Eur");
    sukurtaBilietu10 = GetValueFromConsole();
    bilietuKiekis10 += sukurtaBilietu10;
    nepanaudotiBilietai10 = bilietuKiekis10;
    Console.WriteLine($"Siuo metu bilietu uz 10Eur sukurta {sukurtaBilietu10}, is viso yra: {bilietuKiekis10}");
   
}
void CreateBilietai20()
{
    Console.WriteLine("Kurti bilietus uz 20Eur");
    sukurtaBilietu20 = GetValueFromConsole();
    bilietuKiekis20 += sukurtaBilietu20;
    nepanaudotiBilietai20 = bilietuKiekis20;
    Console.WriteLine($"Siuo metu bilietu uz 10Eur sukurta {sukurtaBilietu20}, is viso yra: {bilietuKiekis20}");
}
void CreateBilietai30()
{
    Console.WriteLine("Kurti bilietus uz 30Eur");
    sukurtaBilietu30 = GetValueFromConsole();
    bilietuKiekis30 += sukurtaBilietu30;
    nepanaudotiBilietai30 = bilietuKiekis30;
    Console.WriteLine($"Siuo metu bilietu uz 10Eur sukurta {sukurtaBilietu30}, is viso yra: {bilietuKiekis30}");
}




