// MIS 3013 005
// Exam 2
// March 27, 2024
// Aditi Mahangade
// 113607539
// DIYX


Console.WriteLine("Exam 2");
Console.WriteLine("Aditi Mahangade");
Console.WriteLine("[Exam 2 code]"); // You are going to get the exam 2 code during the exam.

string GetMenu()
{
    string menuStr;
    menuStr = @"
    ********************
    Sales System Menu
    1. Add a new order
    2. Show summary information
    Press other keys to exit
    *********************

    return menuStr;
}

double CalSubtotal(double appleW, double banW)
{
    double r;
    r = 1.89 * appleW + 0.49 * banW;
    return r;
}

int CalSubtotalLevel(double subtotal)
{
    int r;
    
    if(subtotal <= 20)
    {
        subtotal = "1";
    }
    
    else if(subtotal > 20 && subtotal <= 60)
    {
        subtotal = "2";
    }
    
    else
    {
        subtotal = "3";
    }

    return r;
}

void PrintReceipt(double appW, double banaW, double sta, int l)
{
    Console.WriteLine("RECEIPT");
    Console.WriteLine($"Apple Weight: {appW:F2}");
    Console.WriteLine($"Banana Weight: {banaW:F2}");
    Console.WriteLine($"Subtotal: {sta:C2}");
    Console.WriteLine($"Subtotal Level: {l}");
}

string mesStr;
int N = 0;
int NOne = 0;
int NTwo = 0;
int NThree = 0;
double totalApple = 0;
double totalBanana = 0;
double totalFruit = 0;

while(true)
{
    string menuStr;
    menuStr = GetMenu();
    Console.WriteLine(menuStr);

    Console.Write("Enter option: ");
    string userChoiceStr;
    userChoiceStr = Console.ReadLine();

    if(userChoiceStr == "1")
    {
        N = N + 1;
        mesStr = $"Weight of Apples (lbs): ";
        int appleInt;
        appleInt = Console.ReadLine();
        double appleDbl;
        appleDbl = Convert.ToDouble(appleInt);
        
        totalApple = totalApple + appleDbl;

        mesStr = $"Weight of Bananas (lbs)";
        int bananaInt;
        bananaInt = Console.ReadLine();
        double bananaDbl;
        bananaDbl = Convert.ToDouble(bananaInt);

        totalBanana = totalBanana + bananaDbl;

        totalFruit = totalApple + totalBanana

        double subtotal;
        subtotal = CalSubtotal(totalFruit);

        int level;
        level = CalSubtotalLevel(double finalLevel);
        if(finalLevel <= 20)
        {
            NOne = NOne + 1;
        }
        else if(finalLevel > 20 && finalLevel <= 60)
        {
            NTwo = NTwo + 1;
        }
        else
        {
            NThree = NThree + 1;
        }

        return level;

        mesStr = PrintReceipt()
        {
            Console.WriteLine(RECEIPT);
            Console.Write($"Apple Weight: " {totalApple:F2} "lbs");
            Console.Write($"Banana Weight: " {totalBanana:F2} "lbs");
            Console.Write($"Subtotal: " {subtotal:C2});
            Console.Write($"Subtotal Level: " {finalLevel});

            Console.WriteLine(mesStr);
        }
    }
    
    else if(userChoiceStr == "2")
    {
        Console.Write("Summary Information: ");

        Console.Write($"Total number of orders: {N}");
        Console.Write($"Sum subtotal of all orders: {subtotal:C2}");
        Console.Write($"Average subtotal of all orders: {subtotal / N:C2}");

        Console.Write($"Total weight of apples sold (lbs): {totalApple:F2}");
        Console.Write($"Sum subtotal of apples sold: {appleW + totalFruit:C2}");
        
        Console.Write($"Total weight of bananas sold (lbs): {totalBanana:F2}");
        Console.Write($"Sum subtotal of bananas sold: {banW + totalFruit:C2}");
        
        Console.Write($"Subtotal level 1: ({NOne:P2})");
        Console.Write($"Subtotal level 2: ({NTwo:P2})");
        Console.Write($"Subtotal level 3: ({NThree:P2})");

        Console.Write("Sum subtotal of level 1: {subtotal:C2} ({NOne:P2})");
        Console.Write("Sum subtotal of level 2: {subtotal:C2} ({NTwo:P2})");
        Console.Write("Sum subtotal of level 3: {subtotal:C2} ({NThree:P2})");
    }
    
    else
    {
        Console.Write("Thank you and goodbye!");
        break;
    }
}

