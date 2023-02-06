// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

// int GetNumber(string message)
// {
// int result = 0;
// while(true)
// {
// Console.WriteLine(message);
// if(int.TryParse(Console.ReadLine(), out result) && result <= 10000 && result <100000)
// {
// break;
// }
// else
// {
// Console.WriteLine("Ввели не пятизначное число");
// }
// }
// return result;
// }


Console.WriteLine("Введите пятизначное число:");
string input = Console.ReadLine();
if (input.Length == 5)
{
    validateNumber(input);
    isPalindrom (input);
}
else
{
    Console.WriteLine("Ввели не пятизначное число");
}

void validateNumber(string input)
{
    Convert.ToInt32(input);
}


void isPalindrom (string input)
{
int count = input.Length;
for (int i = 0; i < count/2; i++)
{
    if (input[i] != input[count-1-i])
    {
        Console.WriteLine("Не полиндром");
        return;
    }
    
}
Console.WriteLine("Полиндром");
}



