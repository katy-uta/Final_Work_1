/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []*/

string[] GetFirstArray(int count)
{
    string[] firstarray = new string[count];
    for (int i = 0; i < firstarray.Length; i++)
    {
        Console.WriteLine("Введите элемент массива");
        firstarray[i] = Console.ReadLine();
    }
    return firstarray;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void PrintSecondArray(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {



        string buffer = array[i];
        if (buffer.Length <= 3)
            Console.Write($"{array[i]} ");

    }
}

Console.WriteLine("Введите размерность массива:");
int count = int.Parse(Console.ReadLine());
string[] array = GetFirstArray(count);
PrintArray(array);
Console.WriteLine();
PrintSecondArray(array);
