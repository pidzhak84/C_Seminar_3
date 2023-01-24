﻿/*
Прогоамму, которая по заданному номеру четверти показывает диапазон возможных координат в этой четверти (x и y)
*/

Console.Clear();

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
string getRageFromQuatre(int quarter)
{
    string result = $"Диапазон значений в {quarter} четверти";
    switch (quarter)
    {
        case 1:
            {
                result += " x>0 и y>0 ";
                break;
            }
        case 2:
            {
                result += " x<0 и y>0 ";
                break;
            }
        case 3:
            {
                result += " x<0 и y<0 ";
                break;
            }
        case 4:
            {
                result += " x>0 и y<0 ";
                break;
            }
        default:
            {
                result = $"Четверти {quarter} не существует";
                break;
            }
    }
    return result;
}

int quarter = getUserValue("Введите номер четверти ");
string rangeDescription=getRageFromQuatre(quarter);
Console.WriteLine(rangeDescription);