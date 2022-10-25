// Программа, которая принимает число и проверяет кратно ли они 7 и 23


bool Multiple(int number)
{
    return number % 7 == 0 && number % 23 == 0; ;
}




Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = Multiple(num);
Console.Write(result?" Да" : "Нет");

// bool Multiple(int first, int second)
// {
//     return first % second == 0;
// }
// Console.WriteLine((Multiple(number,7))&&(Multiple(num,23))?"да":"нет");