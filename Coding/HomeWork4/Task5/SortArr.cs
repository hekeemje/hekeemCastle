﻿namespace Task5
{
    public static class SortArr
    {
        public static int[] Sort(this int[] arr)
        {
            //сравнивает два элемента в массиве, если n элемент массива меньше чем его предыдущий, 
            //тогда на место n элемент записывается предыдущий элемент в массиве, 
            //затем мы переходим на элемент назад и сравниваем так же само и если предыдущий больше чем теперешний тогда предыдущий записываем на место теперешнего , 
            //и так делаем пока предыдущий элемент не будет меньше чем проверяемый , 
            //когда происходит выходит из цикла тогда элемент изначально над которым мы проводили проверке был записан в значение key записывается в последнее проверяемый элемент
            for (int i = 1; i < arr.Length; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            return arr;
        }
    }
}
