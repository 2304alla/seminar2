// Программа принимает 2 числа и вявляет, я является ли первое число кротное второму.
//Если не кртиное 1 число 2, то выводится остаток от деления

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// bool Multiple(int number1, int number2)
// {
//     return number1 % number2 == 0;
// }

// Console.WriteLine(CratNum(num));

int Multiple(int number1, int number2)
{
    return number1 % number2;
}

 int rest = Multiple( num1,  num2);   
 Console.WriteLine(rest == 0?"Кратно":$"Не кратно, остаток {rest}");
