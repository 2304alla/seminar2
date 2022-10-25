// Программа, которая выводит случайное 3х значное чило и удаляет вторую цифру этого числа

int FirstLastDigit(int number)
{
    int number1 = number / 100;
    int number2 = number % 10;
    // int result = firstDigit * 10 + thirdDigit;
    return number1 * 10 + number2;
}

int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапазона 100-1000 -> {num}");

//int firstDigit = num / 100;
//int thirdDigit = num % 10;
//int secondDigit = num /100 % 10;

//Console.Write($"{firstDigit}, {thirdDigit}, {secondDigit}");


 int firstLastDigit = FirstLastDigit(num);

Console.WriteLine(FirstLastDigit(num));


