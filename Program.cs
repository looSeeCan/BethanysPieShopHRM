////MODULE 4

int age = 23;

bool a = age == 23;

Console.WriteLine($"Age is 23: {a}");

bool b = age >= 23;
Console.WriteLine($"Age is greater than or equal to 23: {b}");

bool c = (age >= 18) && (age <= 65);
Console.WriteLine($"Age is between 18 and 65: {c}");

int age1 = 16;
int age2 = 64;
bool d = (age1 >= 18) && (age2 <= 65);
Console.WriteLine($"Age1 is greater than 18 AND age2 is less than 65: {d}");

bool e = (age1 >= 18) || (age2 <= 65);
Console.WriteLine($"Age1 is greater than 18 OR age2 is less than 65: {e}");

////Making Decisions with the If Statement

//if the person applying for the job is under 18, we can't hire them. If the person is older than 65, we cant hire them.

//Console.WriteLine("Enter the age of the new candidate:");
//int age3 = int.Parse(Console.ReadLine());

//if (age3 < 18 || age3 > 65)
//    Console.WriteLine("You do not meet our age qualifications");
//else
//    Console.WriteLine("Age qualifications have been met");

//else if
//if (age3 < 18)
//        Console.WriteLine("Too young to apply");
//    else if (age3 > 65)
//        Console.WriteLine("Too old to apply");
//    else
//        Console.WriteLine("else if: Age qualifications have been met");

//switch
//switch (age3)
//{
//    case < 18:
//    case > 65:
//        Console.WriteLine("Age qualifications have not been met");
//        break;
//    case 23:
//        Console.WriteLine("Wow exactly what we are looking for");
//        break;
//    default:
//        Console.WriteLine($"Age qualifications have been met");
//        break;
//}

DateTime today = DateTime.Now; Console.WriteLine(today);
bool endOfMonthPaymentStarted = false;

if (today.Date.Day == 20)
{
    Console.WriteLine("Please start end-of-month employee payments");
}
else if (today.Date.Day >= 25 && !endOfMonthPaymentStarted)
{
    Console.WriteLine("Payments wil be late!");
}

////Adding iterations

//int i = 0;
//while (i < 10)
//{
//    Console.WriteLine(i);
//    i++;
//}

//Console.WriteLine("Enter a value:");
//int max = int.Parse(Console.ReadLine());
//Console.WriteLine("\n");

//int i = 0;
//while (i < max)
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//}
//Console.WriteLine("\nLoop completed");

//int j = 10;
//while (j >= max)
//{
//    Console.WriteLine($"j = {j}");
//    j--;
//}
//Console.WriteLine("\nLoop completed");


//////////////////

//Console.WriteLine("\n1. Add employee");
//Console.WriteLine("2. Update employee");
//Console.WriteLine("3. Delete employee");
//Console.WriteLine("99. Exit application");
//string selectedAction = Console.ReadLine();

//while (selectedAction != "99")
//{
//    switch (selectedAction)
//    {
//        case "1":
//            Console.WriteLine("Adding new employee... ");
//            break;
//        case "2":
//            Console.WriteLine("Updating employee...");
//            break;
//        case "3":
//            Console.WriteLine("Deleting employee... ");
//            break;
//        default:
//            Console.WriteLine("Invalid Input");
//            break;
//    }
//    Console.WriteLine("Choose the action you want to do: ");
//    Console.WriteLine("\n1. Add employee");
//    Console.WriteLine("2. Update employee");
//    Console.WriteLine("3. Delete employee");
//    Console.WriteLine("99. Exit application");
//    selectedAction = Console.ReadLine();//I forgot this line. the result was an infinite loop
//}

/////////////////////////

//compare this one to the one ^. this one is more efficient
//string selectedAction = "";//I have to declare this out here for the while() to be able to use it
//do
//{
//    Console.WriteLine("Choose the action you want to do: ");
//    Console.WriteLine("\n1. Add employee");
//    Console.WriteLine("2. Update employee");
//    Console.WriteLine("3. Delete employee");
//    Console.WriteLine("99. Exit application");
//    selectedAction = Console.ReadLine();//I forgot this line. the result was an infinite loop

//    switch (selectedAction)
//    {
//        case "1":
//            Console.WriteLine("Adding new employee... ");
//            break;
//        case "2":
//            Console.WriteLine("Updating employee...");
//            break;
//        case "3":
//            Console.WriteLine("Deleting employee... ");
//            break;
//        default:
//            Console.WriteLine("Invalid Input");
//            break;
//    }

//} while (selectedAction != "99");
//Console.WriteLine("Closing application");

////Continue and break

Console.WriteLine("Enter a value: ");
int max = int.Parse(Console.ReadLine());
for (int i = 0; i < max; i++)
{
    if (i == 5)
    {
        Console.WriteLine($"Bingo! {i} was found");
        //continue;
        break;//I get break, but, I don't get continue.
    }
    Console.WriteLine(i);
}
