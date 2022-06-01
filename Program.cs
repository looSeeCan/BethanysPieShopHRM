////MODULE 5. Used the extension to "Open in VSCode" from Visual Studio. Had to use Git Desktop to add this repository. Ran into some pull issues

using BethanysPieShopHRM;

int amount = 1234;
int months = 12;
int bonus = 1000;
int test = 2000;
//I had an issue with the debugger. Remember to shift f5 to come out of debugger and first dotnet run in terminal first. I think that builds it or saves it properly, so the debug will debug it propperly.
double yearlyWage = Utillities.CalculateYearlyWage(amount, months, bonus, test);//I have to declare "Using Utillities", because this method is in another file. It's like components in JS.
Console.WriteLine(yearlyWage);
Console.ReadLine();//hmmm. if I do not declare this here, it seems like it will do an infinite loop.

