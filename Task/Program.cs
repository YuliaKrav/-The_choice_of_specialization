// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте исполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"]->["2", ":-)"]
// ["1234", "1567", "-2", "computer science"]->["-2"]
// ["Russia", "Denmark", "Kazan"]->[]


string[] arrayString = { "hello", "2", "world", ":-)", ":-(" };
// string[] arrayString = {"1234", "1567", "-2", "computer science"}; 
// string[] arrayString = {"Russia", "Denmark", "Kazan"}; 
int lessLength = 3;


int countWordsLengthLessGivenIntLen(string[] arrStr, int intLen)
{
    int count = 0;
    for (int i = 0; i < arrStr.Length; i++)
    {
        if (arrStr[i].Length <= intLen) count++;
    }
    return count;
}

string[] fillArraytWordsLengthLessGivenIntLen(string[] arrStr, int intLen)
{
    int index = 0;
    string[] resultArray = new string[countWordsLengthLessGivenIntLen(arrStr, intLen)];

    for (int i = 0; i < arrStr.Length; i++)
    {
        if (arrStr[i].Length <= intLen)
        {
            resultArray[index] = arrStr[i];
            index++;
        }
    }

    return resultArray;
}

void printArray(string[] arrStr)
{
    for (int i = 0; i < arrStr.Length; i++)
        Console.Write(arrStr[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("In the array:");
printArray(arrayString);
Console.WriteLine(countWordsLengthLessGivenIntLen(arrayString, lessLength) + " word(s), which length less or equal " + lessLength);
printArray(fillArraytWordsLengthLessGivenIntLen(arrayString, lessLength));
