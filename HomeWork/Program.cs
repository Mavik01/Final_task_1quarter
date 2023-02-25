// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
// либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Пример:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


// Метод преобразования строки в массив строк
string[] StringToArr(string input)
{
    string[] arr = new string[input.Length];
    int index = 0;
    
    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input[i] != ' ')
        {
            if (i != input.Length - 1)
            {
                temp += input[i].ToString();
                i++;
            }
            else
            {
                temp += input[i].ToString();
                break;
            }
        }
        arr[index] = temp;
        index++;
    }
    return arr;
}

// Метод определения числа непустых значений в массиве строк
int GetLengthArr(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != null) count++;
    }
    return count;
}
// Метод заполнения одномерного массива строк
string[] Gen1DArr(int len, string[] arr)
{
    string[] arr2 = new string[len];
    for (int i = 0; i < len; i++)
    {
        arr2[i] = arr[i];
    }
    return arr2;
}

// Метод печати одномерного массива строк
void Print1DArr(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
