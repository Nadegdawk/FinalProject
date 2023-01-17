// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив
//  из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести
//   с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
//    пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.Write($"Input the size of the array: ");
int n = int.Parse(Console.ReadLine());
string[] userArray = ArrayUser(n);
Console.WriteLine("Old array: ");
PrintArray (userArray);
int m = CheckArrayLengthThreeChars(userArray);
Console.WriteLine("New array: ");
PrintArray (CreateArrayLengthThreeChars(userArray, m));


string ReadInt(string argumentName)            //ввод данных пользователем
{
	Console.Write($"Input {argumentName}: ");
	return Console.ReadLine();
}

string[] ArrayUser(int count)		//заполнение массива пользователем
{
	string[] array = new string[count];
	for (int i = 0; i < count; i++)
	{
		array[i] = ReadInt($"element {i+1}");
	}
	return array;
}

int CheckArrayLengthThreeChars (string[] array)     //проверка элементов массива на длину не более 3 символов
{
    int m = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=3) m++;
    }
    return m;
}

string[] CreateArrayLengthThreeChars (string[] array, int m) //создание массива с длиной эл-в не более 3 символов
{
    string[] newArray = new string[m];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=3)
        {
            newArray[j] = array[i];
            j++;
        }

    }
    return newArray;
}

void PrintArray (string[] array)		//печать массива
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
    Console.WriteLine();
}
