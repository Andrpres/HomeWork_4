/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
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

int number = GetNumber("Введите число");

int numberSumm = 0;//Итоговая сумма всех чисел
while (number > 0)
{
    numberSumm = numberSumm + (number % 10);
    number = number / 10;
}

Console.WriteLine(numberSumm);