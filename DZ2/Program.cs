﻿void function(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] massive()
{   
    int size = 8;

    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 1000);        
    }    
    return arr;
}

int[] arr_1 = massive();
function(arr_1);
int[] arr_2 = massive();
function(arr_2);