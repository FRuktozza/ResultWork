string[] initArray()
{
    Console.WriteLine("Введите размер массива");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n < 1) 
    {
        return null;
    }

    string[] array = new string[n];

    Console.WriteLine($"Вводите элементы массива с новой строки ({n} раз(-a)))");
    for (int i = 0; i < n; i++)
    {
        array[i] = Console.ReadLine();
    }

    return array;
}

void printElements(string[] array)
{
    int i;
    int n = 0;
    string[] result;

    for (i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            n++;
        }
    }

    if (n > 0)
    {
        result = new string[n];
    }
    else
    {
        Console.WriteLine("Таких элементов нет");
        return;
    }

    int currIndex = 0;
    Console.WriteLine("Элементы с длиной меньше или равной 3:");
    for (i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.WriteLine(array[i]);
            result[currIndex] = array[i];
            currIndex++;
        }
    }
}

string[] array = initArray();

if (array == null)
{
    Console.WriteLine("Неверная длинна массива");
}
else
{
    printElements(array);
}