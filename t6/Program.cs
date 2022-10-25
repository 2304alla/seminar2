// Принимает 2 числа и проверяет, является ли одно квардратом ворого

bool Sguare(int number1, int number2)
{
    return number1==number2 * number2 || number2==number1 * number1;
}
 
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = Sguare(num1,num2);
Console.Write(result?"Является":"Не является");