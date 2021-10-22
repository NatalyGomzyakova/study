using System;
using System.Diagnostics;

namespace study
{
    class Program
    {

        // 2. с ref 

        static int[] Array(ref int[] bst)
        {
            Random rand = new Random();
            for(int i = 0; i < bst.Length; i++)
            {

                bst[i]=rand.Next();

                
            }
            return bst;
        }



        static int[] BubbleSort(ref int[] bst)
        {
            int temp;
            for (int i = 0; i < bst.Length; i++)
            {
                for (int j = i + 1; j < bst.Length; j++)
                {
                    if (bst[i] > bst[j])
                    {
                        temp = bst[i];
                        bst[i] = bst[j];
                        bst[j] = temp;
                    }
                }
            }
            

            return bst;
        }
        static int[] ViborSort(ref int[] bst)
        {

            for (int i = 0; i < bst.Length - 1; i++)
            {
                //поиск минимального числа
                int min = i;
                for (int j = i + 1; j < bst.Length; j++)
                {
                    if (bst[j] < bst[min])
                    {
                        min = j;
                    }
                }
                //обмен элементов
                int temp = bst[min];
                bst[min] = bst[i];
                bst[i] = temp;
            }
            return bst;
        }


        static int[] Vvod(ref int[] bst) {

            for (int i = 0; i < bst.Length; i++)
            {
                Console.Write(bst[i] + " ");
            }

            return bst;
        }
        static int[] InsertionSort( ref int[] bst)
        {
            int newElement, location;

            for (int i = 1; i < bst.Length; i++)
            {
                newElement = bst[i];
                location = i - 1;
                while (location >= 0 && bst[location] > newElement)
                {
                    bst[location + 1] = bst[location];
                    location = location - 1;
                }
                bst[location + 1] = newElement;
            }
            return bst;
        }

        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();




            
            int a1 = 10000;
            int[] ast= new int[a1];
            Array(ref ast);

            // Vvod(ref ast);

           //  BubbleSort(ref ast);
            //  ViborSort(ref ast);

            InsertionSort(ref ast);
            //  Vvod(ref ast);

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine(elapsedTime);

        }
    }
}   