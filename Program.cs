//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

void StepenFinder(int a, int b)
{
    for(int count = 0; count >= b; count++)
    {
        b = a * a;
    }
    Console.WriteLine($"Number {a} -> {b}");

}

/*
  if(numberN > 0)   //НАПОМИНАЛКА ДЛЯ СЕБЯ КАК ИСПОЛЬЗОВАТЬ Math.Pow
    {
        int current_i = 1;
        while(current_i <= numberN)
        {
            int res = current_i * current_i;
            //double res = Math.Pow(current_i, 2);
            //возведение в 2 степень переменной карентИ
            Console.Write($"{res:f0}, ");
            current_i ++;

            */

Console.WriteLine("Enter your first number: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your second number: ");
int second_num = Convert.ToInt32(Console.ReadLine());


if(first_num > 0 && second_num > 0)
{
    StepenFinder(first_num, second_num);
}
else
{
    Console.WriteLine("Impossible value!");
}



//Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
void DigitsSum (int n)
{
    int sum = 0;
    for (int i = 0; i <= n; i++)
    {
        int firstDigit = n / 10000;
        int secondDigit = n / 1000 % 10;
        int thirdDigit = n / 100 % 10;
        int forthDigit = n / 10 % 10;
        int fifthDigit = n % 10;
        sum = firstDigit + secondDigit + thirdDigit + forthDigit + fifthDigit;
    }
    Console.WriteLine($"Sum of elements is {sum}");
}
Console.WriteLine("Enter your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

if(user_num < 0 || user_num >= 99999)
{
    Console.WriteLine("Impossible value!");
}
else
{
    DigitsSum(user_num); 
}
*/


//Задача 29: Напишите программу, которая задаёт массив из 8 
//элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
/*
int [] CreateArray (int size, int min, int max)
{
     int [] array = new int [size];
      
     for(int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int [] array1)
{
    for(int i = 0; i < array1.Length; i++) 
        Console.Write(array1[i] + " ");
    Console.WriteLine();
}

int count_of_elem = 8;
int minVal = 1;
int maxVal = 99;

int [] createdArray = CreateArray(count_of_elem, minVal, maxVal);
ShowArray(createdArray);
*/

