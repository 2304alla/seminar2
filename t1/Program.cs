// Программа. котороае выводит слкчайное число оз отрезка[10,00]; и показывает натбольшую цифру числа



//int firstDigit = num / 10; // целочнсленное деление на 10, 78/10 = 7.8
//int secondDigit = num % 10; // остаток от целочисленного деления

//if(firstDigit > secondDigit)  Console.WriteLine($"Наибольшая цифра {firstDigit}");
//else Console.WriteLine($"Наибольшая цифра {secondDigit}");

//int result = firstDigit > secondDigit ? firstDigit : secondDigit;
//Console.WriteLine($"Наибольшая цифра числа {num} = {result}");

//int max = Math.Max(firstDigit,secondDigit);
//Console.WriteLine($"Наибольшая цифра числа {num} = {max}");

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    //int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10-99 -> {num}");
 
int maxDigit = MaxDigit(num);

Console.WriteLine($"Наибольшая цифра числа {num} = {maxDigit}");