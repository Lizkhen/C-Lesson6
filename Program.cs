/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
Вводим сразу все числа в одну линию, не через бесконечное кол-во ReadLine.

Задача 43: Напишите программу, которая найдёт точку пересечения двух 
прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения
b1, k1, b2 и k2 задаются пользователем.
Точки для уравнений пользователь вводит с клавиатуры, можно через 
несколько ReadLine
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Выполнение обеих задач с использованием созданных вами функций. */
Console.WriteLine ("Выберите номер задачи:");
Console.WriteLine ("Задача 41. Считаем количество положительных чисел");
Console.WriteLine ("Задача 43. Находим точку пересечения 2х прямых");
int n = Convert.ToInt32(Console.ReadLine ());
switch (n)
{
    case 41:
        Task41();
        break;
    case 43:
        Task43();
        break;
    default:
        break;
}
void Task41()
{  
    Console.WriteLine("Введите элементы вашего массива через запятую");
    string [] num = Console.ReadLine().Split(',');
    Console.WriteLine("Количество положительных элементов: " + COUNT(num));
    int COUNT (string [] num)
    {
        int []array = new int [num.Length];
        int count = 0;
        for ( int i = 0; i < num.Length; i++)
            {  
                array[i] = Convert.ToInt32 (num[i]); 
                if (array[i] > 0)
                    count++;
            }
        return count;
    }
}

void Task43()
{
    Console.WriteLine("Найдём точку пересечения двух прямых");
    Console.WriteLine("Введите значение b1");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k1");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение b2");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k2");
    double k2 = Convert.ToInt32(Console.ReadLine());
    IntersectionPoint (b1,k1,b2,k2);
}
    void IntersectionPoint (double b1, double k1,double b2, double k2)
    {
        double x = 0;
        double y = 0;
        if (k1==k2 && b1==b2)
            Console.WriteLine ("Данные прямые совпадают");
        else
            if (k1==k2)
                Console.WriteLine ("Прямые параллельны");
            else
            {
                 x = (b2-b1)/(k1-k2);
                 y = k1*x + b1;
                 Console.WriteLine ($"Точки пересечения прямых: ({x}; {y})");
            }
    }

    



   