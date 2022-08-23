//16. Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.
//Console.Clear();

//Console.WriteLine("Введите первое число:");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число:");
//int num2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(num1 % num2 == 0 || num2 % num1 == 0 ? "Да" : "Нет");

//Задача 10: Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.
//Console.Clear();

//Console.WriteLine("Введите число:");
//int num = Convert.ToInt32(Console.ReadLine());

//int a = 0;
//int b = 0;
//Console.WriteLine(((num % 100) - (num % 10))/10);

//Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.
//Console.Clear();

//Console.Write("Введите число: ");
//int anyNumber = Convert.ToInt32(Console.ReadLine());
//string anyNumberText = Convert.ToString(anyNumber);

//if (anyNumberText.Length > 2){
//  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
//}
//else {
//  Console.WriteLine("-> третьей цифры нет");
//}

//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//Console.Clear();
//Console.Write("Введи цифру, обозначающую день недели: ");
//int dayNumber = Convert.ToInt32(Console.ReadLine());

//if (dayNumber >= 1 && dayNumber <= 7)
//{
//    Console.WriteLine(dayNumber == 6 || dayNumber == 7 ? "Да, это выходной" : "Нет, это не выходной");
//}
//else
//{
//    Console.WriteLine("В недели 7 дней!");
//}

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