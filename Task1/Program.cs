// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да



Console.WriteLine("Введите пятизначное число:");
string input = Console.ReadLine();
if (input.Length == 5 && validateNumber(input))
{
    isPalindrom (input);
}
else
{
    Console.WriteLine("Ввели не пятизначное число");
}

bool validateNumber(string input)
{
    int result;
    return int.TryParse(input, out result);
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



