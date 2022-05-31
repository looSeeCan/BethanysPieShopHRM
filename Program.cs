// See https://aka.ms/new-console-template for more information


//Console.WriteLine("Welcome to Bethany's Pie Shop HRM");
//Console.WriteLine("Please enter your first name");
//string firstName = Console.ReadLine();
//Console.WriteLine("Please entrer your last name");
//string lastName = Console.ReadLine();

//Console.WriteLine($"Hello {firstName} {lastName}");

int monthlyWage = 1234;
int months = 12, bonus = 1000;
bool isActive = true;
double rating = 99.25;//floating point values
byte numberOfEmployees = 255;//can accept nums from 0 to 255

int hoursWorked;//create a variable
hoursWorked = 40;//assign it a value later
hoursWorked = 60;//change it again later

//hoursworked = true;//can not change type. once a variable is declared, it can never change its type.

////Using a const value

const double interRate = .07;
//interRate = .08;//error can not chane a const variable

////Strings

string firstName1 = "Bethany";
string lastname1 = "Smith";

//string emptyString = "";
//Console.WriteLine("Please enter your name");
//string name = Console.ReadLine();

////Operators

double ratePerHour = 23.50;
int totalHoursMonthly = 160;

double currentMonthWage = ratePerHour * totalHoursMonthly + bonus;
Console.WriteLine(currentMonthWage);

ratePerHour += 1.50;//compound operator
Console.WriteLine(ratePerHour);

if (currentMonthWage > 2000)
{
    Console.WriteLine("Top paid employee");
}

int numOfEmployees = 15;
//someone leaves work
numOfEmployees--; Console.WriteLine(numOfEmployees);

bool a;//if variable is not assigned a value. default values will be set. false
int b;//0
//Console.WriteLine($"{a}");

////Members On Primitive Types

int intMaxValue = int.MaxValue; Console.WriteLine($"intMaxValue: {intMaxValue}");
int intMinValue = int.MinValue; Console.WriteLine($"intMinValue: {intMinValue}");
double dblMaxValue = double.MaxValue; Console.WriteLine($"dblMaxValue: {dblMaxValue}");
double dblMinValue = double.MinValue; Console.WriteLine($"dblMinValue: {dblMinValue}");

char myChar = '!';//char. used to store single unicode characters. I tried to use "" for this. but I think that char only allows ''.
bool isWhiteSpace = char.IsWhiteSpace(myChar); Console.WriteLine(isWhiteSpace);
bool isDigit = char.IsDigit(myChar); Console.WriteLine(isDigit);
bool isPunctuation = char.IsPunctuation(myChar); Console.WriteLine(isPunctuation);

////Working with dates

DateTime today = DateTime.Today; Console.WriteLine(today);
DateTime employeeStartDate = new DateTime(2025, 03, 28); Console.WriteLine(employeeStartDate);
DateTime twoDaysLater = today.AddDays(2); Console.WriteLine(twoDaysLater);
//DateTime day = today.DayOfWeek;
bool isDST = today.IsDaylightSavingTime();

DateTime hireDate = new DateTime(2022, 3, 28, 14, 30, 0); Console.WriteLine(hireDate);//year, month, day, 2(millitary), 30, 0
DateTime currentDate = DateTime.Now; Console.WriteLine($"currentDate {currentDate}");

DateTime startHour = DateTime.Now; Console.WriteLine($"startHour: {startHour}");
//DateTime startHour = new DateTime(2022, 5, 31, 11, 00, 0); Console.WriteLine($"startHour: {startHour}");
TimeSpan workTime = new TimeSpan(8, 0, 0); Console.WriteLine($"workTime: {workTime}");//finding out when the employee will get off work
DateTime endHour = startHour.Add(workTime);//adds the start time to the workTime(8hr shift)

Console.WriteLine($"WorkShift: {startHour}\n\t  {endHour}");//startHour and end hour

Console.WriteLine(startHour.ToLongDateString());
Console.WriteLine(endHour.ToShortTimeString());

////Converting Between Types

//from int to long
Console.WriteLine($"int: {totalHoursMonthly}");//is an int
long veryLongMonth = totalHoursMonthly; Console.WriteLine($"long: {veryLongMonth}");//we can convert from int to long, because the long type can hold larger numbers than int types
//its the same as just assigning the value of the int to a long type variable

/*
//above we converted an int to a long. does it work vice verse
long ranLong = 225; Console.WriteLine($"ranLong: {ranLong}");
int ranInt = ranLong;//no can not do it this way
*/

//performing an explicit cast
double dblNum = 100.2; Console.WriteLine($"dblNum: {dblNum}");
int intToDbl = (int) dblNum; Console.WriteLine($"intToDbl: {intToDbl}");//some data was lost. (int)

////Var

//We can use var if we want C# to decide what variable it is. I am not sure yet what this means.






//Console.WriteLine();//place breakpoint here, f5 and hover over to see varables or look n locals