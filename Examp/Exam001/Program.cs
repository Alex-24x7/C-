/*
//16. Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.
Console.Clear();

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num1 % num2 == 0 || num2 % num1 == 0 ? "Да" : "Нет");
*/

/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int a = 0;
int b = 0;
Console.WriteLine(((num % 100) - (num % 10))/10);
*/

/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);

if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
*/

/*
//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber >= 1 && dayNumber <= 7)
    Console.WriteLine(dayNumber == 6 || dayNumber == 7 ? "Да, это выходной" : "Нет, это не выходной");
else
    Console.WriteLine("В недели 7 дней!");
*/

/*
Console.Clear();
Console.Write("Введите первое трёхзначное: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе трёхзначное: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье трёхзначное: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int srAr = (num1 + num2 + num3) / 3;
int min1 = Math.Min(num1, num2);
int min = Math.Min(min1, num3);
if (srAr % 10 > min /100){
    Console.WriteLine("Да");}
else if (srAr % 10 == min /100){
    Console.WriteLine("Цифры равны");}
else{
    Console.WriteLine("Нет");}
*/


/*
Console.Clear();
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
    Console.WriteLine("1");
else if (x < 0 && y > 0)
    Console.WriteLine("2");
else if (x < 0 && y < 0)
    Console.WriteLine("3");
else if (x > 0 && y < 0)
    Console.WriteLine("4");
*/

/*
Console.Clear();
Console.Write("Введите четверть: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x == 1)
    Console.WriteLine($"Диапазон значений в {x} четверти: x > 0 и y > 0");
else if (x == 2)
    Console.WriteLine($"Диапазон значений в {x} четверти: x < 0 и y > 0");
else if (x == 3)
    Console.WriteLine($"Диапазон значений в {x} четверти: x < 0 и y < 0");
else if (x == 4)
    Console.WriteLine($"Диапазон значений в {x} четверти: x > 0 и y < 0");
else
    Console.WriteLine("Введите значение в диапазоне 1-4");
*/

/*
//Задача 19.
//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3])
    Console.WriteLine($"Число: {number} - палиндром.");
  else Console.WriteLine($"Число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
  CheckingNumber(number);
else Console.WriteLine($"Введи правильное число");
*/

/*
//Задача 21.
//Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка:  {segmentLength}");
*/

/*
//Задача 23. 
//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 1;
while (n > 0 && count <= n)
{
    Console.Write($"{Math.Pow(count, 3)}  ");
    count ++;
}
Console.WriteLine();

while (n < 0 && count >= n)
{
    Console.Write($"{Math.Pow(count, 3)}  ");
    count --;
}
Console.WriteLine();
*/

