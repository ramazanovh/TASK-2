using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task;
public class MyClass<T>
{
    private T[] arr;

    public MyClass()
    {
        arr = new T[0];
    }

    public void Add(T obj)
    {
        Array.Resize(ref arr, arr.Length + 1);
        arr[arr.Length - 1] = obj;
    }
    public void ShowAll()
    {
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
    public int FirstIndex(T obj)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Equals(obj))
            {
                return i;
            }
        }
        Console.WriteLine("The array does not have such object");
        return -1;
    }

    //Muellim deyesen sinifde yazdigimizda bug var, hansi ki 1 + defe dalbadal silinmeli deyer verende sadece 1 ni silir.
    // Bu asagidakini men ozum yazmisdim, burda bug yoxdur.
    public void Remove(T obj)
    {
        T[] array = new T[arr.Length];
        int count = 0;
        int index = 0;
        array = arr;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Equals(obj))
            {
                count++;
            }
            else
            {
                Array.Resize(ref arr, index + 1);
                arr[index] = array[i];
                index++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("The array does not have such object");
        }
                //Task2

        //    public void Remove(T obj) 
        //    {
        //        for (int i = 0; i <= arr.Length - 1; i++)
        //        {
        //            if (Equals(arr[i], obj))
        //            {
        //                arr[i] = default;
        //                for (int j = i; j < arr.Length - 1; j++)
        //                {
        //                    arr[j] = arr[j + 1];
        //                }
        //                Array.Resize(ref arr, arr.Length - 1);
        //            }
        //        }
        //    }
    }
}