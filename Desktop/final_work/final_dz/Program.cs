/* Задача: Написать программу, которая из
 имеющегося массива строк формирует массив из строк, длина 
 которых меньше либо равна 3 символа. Первоначальный массив можно ввести
 с клавиатуры, либо задать на старте выполнения алгоритма. 
 */

 void methodArray (string [] array)
 {
    string[] newarr = new string[array.Length];
     for (int i=0; i<array.Length; i++)
    {
        if(array[i].Length<=3)
        {
            newarr[i]=array[i];;
            Console.WriteLine(newarr[i]); 
        }
    }
        Console.WriteLine(); 
}

void Print(string [] Array)
{
    for (int i=0; i<Array.Length; i++)
    {
        Console.WriteLine(Array[i]);
    }
    Console.WriteLine();
}

string [] array = {"hello", "2", "world", ":-)"};

methodArray(array);
Print(array);