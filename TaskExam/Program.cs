// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ['1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Ввидите эелементы массива");
        string element = Console.ReadLine();
        array[i] = element;
    }
    return array;
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}
int CountLessThan3Elements(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    return count;
}
string[] ArrayLess3Element(string[] array, int count)
{
    
    string[] counter = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            counter[j] = array[i];
            j++;
        }

    }
    return counter;
}

string[] array = CreateArray(4);
PrintArray(array);
int count = CountLessThan3Elements(array);
string[] counter = ArrayLess3Element(array, count);
PrintArray(counter);
