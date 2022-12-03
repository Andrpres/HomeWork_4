/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


int GetNumber(string message)
{
    int result = 0;
    bool inCorrect = false;

    while(!inCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            inCorrect = true;
        }
        else
        {
            Console.WriteLine("Введите именно число");
        }
    }

    return result;
}

int number1 = GetNumber("Введите число 1");
int number2 = GetNumber("Введите число 2");
int numberResult = number1;

for (int i = 1; i < number2; i++)
{
    numberResult = numberResult * number1; 
}

Console.WriteLine($"{numberResult}");