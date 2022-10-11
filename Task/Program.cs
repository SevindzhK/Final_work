// Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам. 
// Первоначальный массив задается на старте выполнения алгоритма

string[] rivers = { "Amazonka", "Tiger", "Nil", "Volga", "Amur", "Ob", "Sena", "Oka", "Don", "Kongo" };

string[] newArray = CreateNewArray(rivers);


if (newArray.Length == 0)
{
    Console.WriteLine("The array doesn't contain strings less than 3 characters");
}
else
{
    PrintArray(newArray);
}



string[] CreateNewArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    Array.Resize(ref newArray, j);
    return newArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} \t");
    }
}


