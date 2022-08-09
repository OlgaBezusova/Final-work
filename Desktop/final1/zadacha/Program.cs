/* Написать программу, которая из имеющегося массива строк
формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись массивами.
примеры:
["hello", "2", "world", "^-)"] -> ["2", "^-)"] */

void Print(string [] Array)
{
    Console.Write("[");
    for (int i=0; i<Array.Length; i++)
    {
        Console.Write(Array[i]);
        if (i < Array.Length -1 )
        {
             Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

void methodArray (string [] array)
{
    string[] newArray = new string[array.Length];
    for (int i=0; i<array.Length; i++)
    {
        
        if(array[i].Length<=3)
        {
            newArray[i]=array[i];
            Console.Write(newArray[i]);
            if (i < newArray.Length -1 )
        {
             Console.Write(", ");
        } 
        }
    }
        Console.WriteLine(); 
}



string [] array = {"hello", "2", "world", "^-)"};


Print(array);
methodArray(array);
