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
  if (number[0]==number[4] && number[1]==number[3])
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

/*
//Напишите программу, которая на вход принимает радиус круга и находит его площадь 
//округленную до целого числа, 
//необходимо вывести максимальную цифру в полученном округлённом значении площади круга
Console.Clear();
Console.Write("Введите радиус: ");
int r = Convert.ToInt32(Console.ReadLine());
double S = Math.Round(Math.PI * (r * r));
Console.WriteLine ($"Площадь круга: {S}");
string S2 = Convert.ToString(S);
Console.WriteLine($"Максимальная цифра: {S2.Max()}");
*/

/*
Console.Clear();
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine(GetSum(A));

int GetSum(int a){
    int sum = 0;
    for(int i = 0; i <= a; i++){
        sum += i;
    }
    return sum;
}
*/

/*
//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5
Console.Clear();
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());

string a = Convert.ToString(A);
Console.WriteLine(a.Length);
*/

/*
//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

int Fact(int N){
    int res = 1;
    if (N > 0){
        for (int i = 1; i <= N; i++){
            res *= i;
        }
    }
    else{
        for (int i = 1; i >= N; i--){
            res *= i;
        }
    }
    return res;
}
Console.Clear();
int N = 0;
while (true){
    Console.WriteLine("Введите число");
    if (!int.TryParse(Console.ReadLine(), out N)){
        Console.WriteLine("Некорректный ввод");
    }
    else break;
}
Console.WriteLine(Fact(N));
*/

/*
//Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

Console.Clear();
Console.WriteLine("Укажите длину массива: ");
int [] rand = new int[int.Parse(Console.ReadLine())];
for (int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(0, 2);
    Console.Write(rand[i]+" ");
}
Console.WriteLine();
*/

//ДЗ

/*
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());

int a = 1;
for (int i = 1; i <= B; i++){
    a = a * A;
}
Console.WriteLine(a);
*/

/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
Console.WriteLine("Введите число:");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0){
    int num = i % 10;
    i = i / 10;
    sum = sum + num;
}
Console.WriteLine("Сумма всех цифр в числе равна: " + sum);
*/

/*
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Укажите длину массива: ");
int [] rand = new int[int.Parse(Console.ReadLine())];
Console.Write("Укажите диапазон значений в массиве: 0 - ");
int A = int.Parse(Console.ReadLine());
for (int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(0, A+1);
    Console.Write(rand[i]+" ");
}
Console.WriteLine();
*/

//Напишите программу, которая задаёт массив из 10 элементов, 
//которые необходимо заполнить случайными значениями в диапазоне 
//от -10 до 10 и найти максимальное значение среди них

/*
Console.Clear();
Console.Write("Массив: ");
int [] rand = new int[10];
for (int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(-10, 11);
    Console.Write(rand[i]+" ");
}
Console.WriteLine();
Console.Write("Максимальное значение массива: ");
int maxValue = rand.Max();
Console.WriteLine(maxValue);
*/


/*
//Демонстрация решения (от преподавателя)
//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.

Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int [] array = GetArray(size,-9,9);

Console.WriteLine(String.Join(" ", array));

int sumPositive = 0;
int sumNegative = 0;
//[3, 1, -2, -4]
foreach(int element in array){
    sumPositive += element > 0 ? element : 0;
    sumNegative += element < 0 ? element : 0;
}

Console.WriteLine($"sum positive: {sumPositive} sum negative {sumNegative}");

int [] GetArray(int size, int min, int max){
    int[] result = new int[size];

    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(min, max + 1);
    }
return result;
}
*/

/*
//Мой вариант
Console.Clear();
Console.Write("Массив: ");
int [] rand = new int[12];
int sumPositive = 0;
int sumNegative = 0;
for (int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(-9, 10);
    Console.Write(rand[i]+" ");
    if (rand[i] > 0)
        sumPositive += rand[i];
    if (rand[i] < 0)
        sumNegative += rand[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных: {sumPositive}");
Console.WriteLine($"Сумма отрицательных: {sumNegative}");
*/

/*
//Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();
Console.WriteLine("Укажите длину массива: ");
int size = int.Parse(Console.ReadLine());
int [] rand = new int[size];
int [] rand2 = new int[size];
for (int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(-99, 100);
    Console.Write(rand[i]+" ");
}
Console.WriteLine();
for (int i = 0; i < rand.Length; i++){
    rand2[i] = rand[i] * -1;
    Console.Write(rand2[i]+" ");
}
Console.WriteLine();
*/


/*
//Задача 33: Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, -3] -> да

Console.Clear();
Console.WriteLine("Укажите длину массива: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите искомое число: ");
int num = int.Parse(Console.ReadLine());
int [] rand = new int[size];
bool A = false;

for (int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(0, 11);
    Console.Write(rand[i]+" ");
    if (rand[i] == num)
        A = true;
}
Console.WriteLine();
if (A == true)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");
*/
/*
//решение от преподавателя
Console.Clear();

Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int [] array = GetArray(size,-9,9);

Console.WriteLine(String.Join(" ", array));

Console.WriteLine("Введите значение");
int findNumber = int.Parse(Console.ReadLine());

Console.WriteLine(array.FirstOrDefault(p=>p == findNumber) != 0 ? "Да" : "Нет");


int [] GetArray(int size, int min, int max){
    int[] result = new int[size];

    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(min, max + 1);
        
    }
return result;
}
*/

/*
//Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

Console.Clear();
int [] array = GetArray(123,-99,199);
int j = 0;
int [] GetArray(int size, int min, int max){
    int[] result = new int[size];

    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(min, max + 1);
    }
return result;
}
int FindNumber(int [] array){
    for (int i = 0; i < array.Length; i++){
        if (array[i] >= 10 && array[i] <= 99)
            j++;
    }
return j;
}
Console.WriteLine (String.Join(" ", array));
Console.WriteLine (FindNumber(array));
*/



/*
//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

Console.Clear();

int [] array = new int[5];

for (int i = 0; i < 5; i++) {
    array[i] = new Random().Next(0, 10);
}

Console.WriteLine(String.Join(" ", array));

int z = array.Length - 1;
for (int i = 0; i < z; i++)
{
    int pr = array[i] * array[z];
    z--;
    Console.Write(pr + " ");
}

if (array.Length % 2 != 0) {Console.Write (array[array.Length/2]); }
*/

/*
//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/

/*
//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/

/*
//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/


/*
//Задача 39: Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1,2,3] -> [3,2,1]
Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int [] array = FillArray(size, 1, 10);

int [] FillArray(int size, int min, int max){
    int [] result = new int[size];
    for(int i = 0; i < size;i++){
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

Console.WriteLine("Входной массив: ");
Console.WriteLine(String.Join(" ", array));

Console.WriteLine("Полученный массив (1 способ): ");
Console.WriteLine(String.Join(" ", array.Reverse()));

Console.WriteLine("Полученный массив (2 способ): ");
Console.WriteLine(String.Join(" ", ReverseArray(array))); 

int [] ReverseArray(int [] array){
    int [] result = new int[array.Length];
    for(int i = 0; i < array.Length;i++){
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}
*/

/*
//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
Console.Clear();
int A, B, C;
Console.Write("Введите длины сторон треугольника: ");
while (!int.TryParse(Console.ReadLine(), out A) || A < 0) {
Console.Write("Ошибка! Введите положительное число: ");
}
Console.Write("Введите длины сторон треугольника: ");
while (!int.TryParse(Console.ReadLine(), out B) || B < 0) {
Console.Write("Ошибка! Введите положительное число: ");
}
Console.Write("Введите длины сторон треугольника: ");
while (!int.TryParse(Console.ReadLine(), out C) || C < 0) {
Console.Write("Ошибка! Введите положительное число: ");
}

if (A < B + C & B < A + C & C < A + B) 
    Console.Write("Может!");
else 
    Console.Write("Не может!");
Console.WriteLine( );
*/





//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10
/*
Console.Clear();
Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine());
string BinaryCode = Convert.ToString(value, 2);
Console.WriteLine("Число в двоичной системе: ");
Console.WriteLine(BinaryCode);
*/


/*
Console.Clear();
Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine());

string i = " ";

while (value > 0)
{
    if (value % 2 != 0){
        i += "1";
    }
    else{
        i += "0";
    }
    value = value / 2;
}
Console.WriteLine($"в двоичной системе:");
Console.WriteLine(String.Join(" ", i.Reverse()));
*/


/*
// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine ("Введите числа через запятую:");
string numbers = Console.ReadLine();
// нам нужно перебрать каждый элемент строки, если это не запятая или пробел, кладм его в массив, если запятая или пробле. делаем ++
string [] newNumbers = new string [numbers.Length];
int k = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
  if (numbers[i] == ',')
  {
    k++;
  }
  else
  {
    newNumbers[k] = newNumbers[k]+$"{numbers[i]}";
  }
}
k++;
int [] resultNumbers = new int[k];
PrintArray (resultNumbers, newNumbers);
int sum = 0;
for (int i = 0; i < k; i++)
{
  if (resultNumbers[i]>0)
  {
    sum++;
  }
}
Console.WriteLine ("Количество чисел больше 0: "+sum);

void PrintArray (int [] array, string [] string1)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(string1[i]);
  Console.Write (array[i]+"  ");
  }
Console.WriteLine();
}
*/

/*
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
*/


/*
//Дополнительная задача (задача со звёздочкой): Напишите программу, которая задаёт массив из n элементов, 
//которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.
//[8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
//[8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо

Console.Clear();
Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
Console.WriteLine("Сдвигаем влево: ");
PrintArray(LeftArray(numbers));
Console.WriteLine("Сдвигаем вправо: ");
PrintArray(RightArray(numbers));


int[] LeftArray(int [] numbers)
{
    int[] leftNumbers = new int[numbers.Length];
    int last = numbers[0];
    for (int i = 1; i <= numbers.Length - 1; i++)
    {
        leftNumbers[i - 1] = numbers[i];
    }
 
    leftNumbers[leftNumbers.Length - 1] = last;
    return leftNumbers;
}
int[] RightArray(int [] numbers)
{
    int[] rightNumbers = new int[numbers.Length];
    int last = numbers[numbers.Length - 1];
    for (int i = numbers.Length - 2; i >= 0; i--)
    {
        rightNumbers[i + 1] = numbers[i];
    }
 
    rightNumbers[0] = last;
    return rightNumbers;
}
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(0,10);
        }
}
void PrintArray(int[] Numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < Numbers.Length; i++)
        {
            Console.Write(Numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/


/*
//Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.

Console.Clear();

Console.Write("Количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int [,] array = FillArray(rows, columns, 1 , 10);

PrintArray(array);

int [,] FillArray(int rows, int columns, int min, int max){
    int[,] array = new int[rows,columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j< columns; j++){
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int [,] filledArray){
    for(int i = 0; i<filledArray.GetLength(0);i++){
        for(int j = 0; j < filledArray.GetLength(1);j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/


/*
//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве 
//находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
//m = 3, n = 4.
Console.Clear();

Console.Write("Количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int [,] array = FillArray(rows, columns);
PrintArray(array);


int [,] FillArray(int rows, int columns){
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j< columns; j++){
            array[i,j] = i + j;
        }
    }
    return array;
}

void PrintArray(int [,] filledArray){
    for(int i = 0; i<filledArray.GetLength(0);i++){
        for(int j = 0; j < filledArray.GetLength(1);j++){
            if (filledArray[i,j] / 10 == 0)
            Console.Write($"{filledArray[i,j]}  ");
            else Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/


/*
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
Console.Clear();

Console.Write("Количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int [,] array = FillArray(rows, columns, 1 , 10);

PrintArray(array);
Console.WriteLine();
PrintArray(FillArrayCheck(array));

int [,] FillArrayCheck(int [,] array){
    for(int i = 1; i < rows; i++){
        for(int j = 1; j< columns; j++){
            if (i % 2 == 1 && j % 2 == 1){
                array[i,j] *= array[i,j];
            }
        }
    }
    return array;
}

int [,] FillArray(int rows, int columns, int min, int max){
    int[,] array = new int[rows,columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j< columns; j++){
            array[i,j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintArray(int [,] filledArray){
    for(int i = 0; i<filledArray.GetLength(0);i++){
        for(int j = 0; j < filledArray.GetLength(1);j++){
            if (filledArray[i,j] / 10 == 0)
            Console.Write($"{filledArray[i,j]}  ");
            else Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/


/*
// Задача 51: Найти сумму по главной диагонали.
Console.Clear();

Console.Write("Количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int [,] array = FillArray(rows, columns, -9 , 10);

PrintArray(array);
Console.WriteLine();
DiagonalArray(array);

void DiagonalArray(int [,] array){
    int[] Sum = new int[Math.Min(rows,columns)];
    int sum = 0;
    for(int i = 0; i < Math.Min(rows,columns); i++){
        sum += array[i, i];
        Sum[i] = array[i, i];
                
        }
Console.WriteLine($"Сумма элементов диагонали:");
Console.Write($"({String.Join(") + (", Sum)})");
Console.WriteLine($" = {sum}");
}

int [,] FillArray(int rows, int columns, int min, int max){
    int[,] array = new int[rows,columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j< columns; j++){
            array[i,j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintArray(int [,] filledArray){
    for(int i = 0; i<filledArray.GetLength(0);i++){
        for(int j = 0; j < filledArray.GetLength(1);j++){
            if (filledArray[i,j] >= 0)
            Console.Write($"{filledArray[i,j]}   ");
            else
            Console.Write($"{filledArray[i,j]}  ");
        }
        Console.WriteLine();
    }
}
*/



// //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// //m = 3, n = 4.
// //0,5 7 -2 -0,2
// //1 -3,3 8 -9,9
// //8 7,8 -7,1 9

// Console.Clear();
// Console.WriteLine("Введите количество строк:");
// int linesVol = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int columnsVol = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[linesVol, columnsVol];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// void FillArrayRandomNumbers(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j] >= 0)
//             Console.Write($"{array[i,j]}   ");
//             else
//             Console.Write($"{array[i,j]}  ");
//         }
//         Console.WriteLine("");
//     }
// }




// //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// //и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.Clear();
// Console.WriteLine("Введите номер строки:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца:");
// int m = Convert.ToInt32(Console.ReadLine());
// int [,] numbers = new int [10,10];
// FillArrayRandomNumbers(numbers);

// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
//     Console.WriteLine("такого элемента нет");
// else
//     Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");

// PrintArray(numbers);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//                 array [i,j] = new Random().Next(-100, 100)/10;
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j] >= 0)
//             Console.Write($"{array[i,j]}   ");
//             else
//             Console.Write($"{array[i,j]}  ");
//         }   
//         Console.Write("]");
//         Console.WriteLine(""); 
//     }
// }



// //Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Console.Clear();
// Console.WriteLine("Введите количество строк:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] numbers = new int[n, m];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine();
// PrintArray(numbers);

// for (int j = 0; j < numbers.GetLength(1); j++)
// {
//     double avarage = 0;
//     for (int i = 0; i < numbers.GetLength(0); i++)
//         avarage = (avarage + numbers[i, j]);
//     avarage = avarage / n;
//     Console.Write(avarage + "; ");
// }

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);
//     }
// }

// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j] >= 0)
//             Console.Write($"{array[i,j]}   ");
//             else
//             Console.Write($"{array[i,j]}  ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }


//Дополнительная задача (задача со звёздочкой): Задайте двумерный массив из целых чисел. 
//Определите, есть столбец в массиве, сумма которого, больше суммы элементов расположенных 
//в четырех "углах" двумерного массива.

// Console.Clear();

// Console.Write("Количество строк в массиве: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Количество столбцов в массиве: ");
// int columns = int.Parse(Console.ReadLine());

// int [,] array = FillArray(rows, columns, 1 , 10);
// int sumCorner = 0;
// PrintArray(array);
// SumCorner(array);
// SumColumn(array);


// void SumColumn(int [,] filledArray){
//     bool x = false;
//     for (int j = 0; j < array.GetLength(1); j++){
//     double avarage = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//             avarage = (avarage + array[i, j]);
//     if (avarage > sumCorner) x = true;
//     }
//     if (x == true)Console.WriteLine("Да, есть столбец с большей суммой значений");
//     else Console.WriteLine("Нет столбца с большей суммой значений");
// }
// int SumCorner(int [,] filledArray){
//     sumCorner = filledArray[0,0] + filledArray[rows-1, 0] + filledArray[0, columns-1] + filledArray[rows-1, columns-1];
//     Console.WriteLine($"Сумма 'угловых' элементов массива: {sumCorner}");
//     return sumCorner;
// }

// int [,] FillArray(int rows, int columns, int min, int max){
//     int[,] array = new int[rows,columns];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j< columns; j++){
//             array[i,j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// void PrintArray(int [,] filledArray){
//     for(int i = 0; i<filledArray.GetLength(0);i++){
//         for(int j = 0; j < filledArray.GetLength(1);j++){
//             Console.Write($"{filledArray[i,j]}  ");
//         }
//         Console.WriteLine();
//     }
// }



//Задача 53: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.
// Console.Clear();

// Console.Write("Количество строк в массиве: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Количество столбцов в массиве: ");
// int columns = int.Parse(Console.ReadLine());

// int [,] array = FillArray(rows, columns, 1 , 10);

// PrintArray(array);
// Console.WriteLine("Новый массив:");
// PrintArray(TransformationArray(array));


// int [,] TransformationArray(int [,] filledArray){
//     int[,] transformationArray = new int[rows,columns];
//     for(int i = 0; i < 1; i++){
//         for(int j = 0; j< columns; j++){
//             transformationArray[i,j] = filledArray[rows-1,j];
//         }
//     }
//     for(int i = 1; i < rows-1; i++){
//         for(int j = 0; j< columns; j++){
//             transformationArray[i,j] = filledArray[i,j];
//         }
//     }
//     for(int i = rows -1; i < rows; i++){
//         for(int j = 0; j< columns; j++){
//             transformationArray[i,j] = filledArray[0,j];
//         }
//     }
//     return transformationArray;
// }

// int [,] FillArray(int rows, int columns, int min, int max){
//     int[,] array = new int[rows,columns];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j< columns; j++){
//             array[i,j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// void PrintArray(int [,] filledArray){
//     for(int i = 0; i<filledArray.GetLength(0);i++){
//         for(int j = 0; j < filledArray.GetLength(1);j++){
//             Console.Write($"{filledArray[i,j]}  ");
//         }
//         Console.WriteLine();
//     }
// }





//Задача 55: Задайте двумерный массив. Напишите программу, 
//которая заменяет строки на столбцы. В случае, если это невозможно, 
//программа должна вывести сообщение для пользователя.

// Console.Clear();

// Console.Write("Количество строк в массиве: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Количество столбцов в массиве: ");
// int columns = int.Parse(Console.ReadLine());

// int [,] array = FillArray(rows, columns, 1 , 10);

// PrintArray(array);
// Console.WriteLine("Новый массив:");
// PrintArray(TransformationArray(array));


// int [,] TransformationArray(int [,] filledArray){
//     int[,] transformationArray = new int[rows,columns];
//     if (rows == columns){
//             for(int i = 0; i < rows; i++){
//                 for(int j = 0; j< columns; j++){
//                     transformationArray[i,j] = filledArray[j,i];
//                 }
//             }
//     }
//     else {
//     Console.WriteLine("Это невозможно");
//     return new int[0, 0];
//     }
//     return transformationArray;
// }

// int [,] FillArray(int rows, int columns, int min, int max){
//     int[,] array = new int[rows,columns];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j< columns; j++){
//             array[i,j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// void PrintArray(int [,] filledArray){
//     for(int i = 0; i<filledArray.GetLength(0);i++){
//         for(int j = 0; j < filledArray.GetLength(1);j++){
//             Console.Write($"{filledArray[i,j]}  ");
//         }
//         Console.WriteLine();
//     }
// }


//Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// число 0 встречается - 5 раз
// число 1 встречается - 2 раз
// Console.Clear();

// Console.Write("Количество строк в массиве: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Количество столбцов в массиве: ");
// int columns = int.Parse(Console.ReadLine());

// int [,] array = FillArray(rows, columns, 0 , 10);

// PrintArray(array);
// Console.WriteLine(String.Join (" ", FrequencyDictionary(array)));

// int [] SortArray = FrequencyDictionary(array);
// Array.Sort(SortArray);
// PrintData(SortArray);

// void PrintData(int[] inArray){
//     int el=inArray[0];
//     int count = 1;
//     for (int i = 1; i < inArray.Length; i++){
//         if(inArray[i]!=el){
//             Console.WriteLine($"{el} встречается {count}");
//             el=inArray[i];
//             count=1;
//         }
//         else
//             count++;
//     }
//     Console.WriteLine($"{el} встречается {count}");
// }

// int [] FrequencyDictionary(int [,] filledArray){
//     int [] frequencyDictionary = new int[filledArray.GetLength(0)*filledArray.GetLength(1)];
//     int count = 0;
//     for(int i = 0; i<filledArray.GetLength(0);i++){
//         for(int j = 0; j < filledArray.GetLength(1);j++){
//             frequencyDictionary[count] = filledArray[i,j];
//             count++;
//         }
//     } 
//     return frequencyDictionary;
// }

// int [,] FillArray(int rows, int columns, int min, int max){
//     int[,] array = new int[rows,columns];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j< columns; j++){
//             array[i,j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// void PrintArray(int [,] filledArray){
//     for(int i = 0; i<filledArray.GetLength(0);i++){
//         for(int j = 0; j < filledArray.GetLength(1);j++){
//             Console.Write($"{filledArray[i,j]}  ");
//         }
//         Console.WriteLine();
//     }
// }




/*
//Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
//которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
using static System.Console;
//2

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
WriteLine($"Минимальный элемент находится -> {String.Join(" ",GetIndexMinEl(array))}" );
WriteLine();
PrintArray(GetResultArray(array, GetIndexMinEl(array)));

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

int[] GetIndexMinEl(int[,] inArray)
{
    int[] result = new int[]{0,0};
    int min=inArray[0,0];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if(min>inArray[i,j])
            {
                min=inArray[i,j];
                result[0]=i;
                result[1]=j;
            }
        }
    }
    return result;
}

int[,] GetResultArray(int[,] inArray, int[] indexes)
{
    int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i == indexes[0]) continue;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j == indexes[1]) continue;
            result[row, column] = inArray[i, j];
            column++;
        }
        column = 0;
        row++;
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}
*/




/*
//Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
using static System.Console;
//3

Clear();

Write("Введите нужное количество строк треугольника Паскаля: ");
int rows = int.Parse(ReadLine());
PrintTriangle(rows);


void PrintTriangle(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int c = 0; c <= (n - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
        {
            Write("  ");
        }
        for (int c = 0; c <= i; c++)
        {
            Write("   "); // создаём пробелы между элементами треугольника
            Write(factorial(i) / (factorial(c) * factorial(i - c))); //формула вычисления элементов треугольника
        }
        WriteLine(); // после каждой строки с числами отступаем две пустые строчки
    }
}
float factorial(int n)
{
    float x = 1;
    for (int i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}
*/





// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// // по убыванию элементы каждой строки двумерного массива.

// using static System.Console;

// Clear();
// WriteLine("Введите количество строк:");
// int linesVol = Convert.ToInt32(ReadLine());
// WriteLine("Введите количество столбцов:");
// int columnsVol = Convert.ToInt32(ReadLine());

// int[,] numbers = new int[linesVol, columnsVol];
// FillArrayRandomNumbers(numbers);
// WriteLine();
// WriteLine("Массив до изменения:");
// PrintArray(numbers);
// WriteLine();
// WriteLine("Массив с упорядоченными значениями:");
// PrintArray(SortingArray(numbers));



// int [,] SortingArray(int [,] filledArray){
//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         for (int j = 0; j < numbers.GetLength(1) - 1; j++)
//         {
//             for (int z = 0; z < numbers.GetLength(1) - 1; z++)
//             {
//                 if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
//                 {
//                     int temp = 0;
//                     temp = numbers[i, z];
//                     numbers[i, z] = numbers[i, z + 1];
//                     numbers[i, z + 1] = temp;
//                 }
//             }
//         }
//     }
//     return numbers;
// }

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Write(array[i, j] + " ");
//         }
//         Write("]");
//         WriteLine("");
//     }
// }




// //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// //которая будет находить строку с наименьшей суммой элементов.

// using static System.Console;

// Clear();
// WriteLine("Введите размер квадратного массива: ");
// int massVol = Convert.ToInt32(ReadLine());
// int[,] numbers = new int[massVol, massVol];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// int minsum = Int32.MaxValue;
// int indexLine = 0;

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         sum = sum + numbers[i, j];        
//     }
//     if (sum < minsum)
//     {
//         minsum = sum;
//         indexLine++;
//     }
// }

// WriteLine("Строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Write(array[i, j] + " ");
//         }
//         Write("]");
//         WriteLine("");
//     }
// }
// */



// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// using static System.Console;

// Clear();
// int size = InputInt("Размерность матриц: ");
// int[,] matrixA = new int[size, size];
// int[,] matrixB = new int[size, size];
// FillArrayRandomNumbers(matrixA);
// FillArrayRandomNumbers(matrixB);
// int[,] matrixC = new int[size, size];

// for (int i = 0; i < size; i++)
// {
//     for (int j = 0; j < size; j++)
//     {
//         for (int k = 0; k < size; k++)
//         {
//             matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
//         }
//     }
// }
// WriteLine("Матрица - А");
// PrintArray(matrixA);
// WriteLine();
// WriteLine("Матрица - В");
// PrintArray(matrixB);
// WriteLine();
// WriteLine("Произведение матриц А * В");
// PrintArray(matrixC);

// int InputInt(string output)
// {
//     Write(output);
//     return int.Parse(ReadLine());
// }

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 5); //Для увеличения размера чисел в матрицах поменять число 5 на большее
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Write(array[i, j] + " ");
//         }
//         Write("]");
//         WriteLine("");
//     }
// }




// // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// // Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

// using static System.Console;

// Clear();
// int deep1 = InputInt("Введите размерность 1: ");
// int deep2 = InputInt("Введите размерность 2: ");
// int deep3 = InputInt("Введите размерность 3: ");
// int countNums = 89;

// if (deep1 * deep2 * deep3 > countNums)
// {
//     Write("Массив слишком большой");
//     return;
// }

// int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);

// for (int i = 0; i < resultNums.GetLength(0); i++)
// {
//     for (int j = 0; j < resultNums.GetLength(1); j++)
//     {
//         for (int k = 0; k < resultNums.GetLength(2); k++)
//         {
//             WriteLine($"[{i},{j},{k}] - {resultNums[i, j, k]}");
//         }
//         WriteLine();
//     }
//     WriteLine();
// }

// int[,,] Create3DMassive(int size1, int size2, int size3)
// {
//     int[,,] array = new int[size1, size2, size3];
//     int[] values = new int[countNums];
//     int num
//      = 10;
//     for (int i = 0; i < values.Length; i++)
//         values[i] = num
//         ++;

//     for (int i = 0; i < values.Length; i++)
//     {
//         int randomInd = new Random().Next(0, values.Length);
//         int temp = values[i];
//         values[i] = values[randomInd];
//         values[randomInd] = temp;
//     }

//     int valueIndex = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = values[valueIndex++];
//             }
//         }
//     }
//     return array;
// }

// int InputInt(string output)
// {
//     Write(output);
//     return int.Parse(ReadLine());
// }



// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

// using static System.Console;

// Clear();
// WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(ReadLine());

// int[,] nums = new int[size, size];

// int num = 1;
// int i = 0;
// int j = 0;

// while (num <= size * size)
// {
//     nums[i, j] = num;
//     if (i <= j + 1 && i + j < size - 1)
//         ++j;
//     else if (i < j && i + j >= size - 1)
//         ++i;
//     else if (i >= j && i + j > size - 1)
//         --j;
//     else
//         --i;
//     ++num;
// }

// PrintArray(nums);

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10) Write(array[i, j] + "  ");
//             else Write(array[i, j] + " ");
//         }
//         Write("]");
//         WriteLine("");
//     }
// }