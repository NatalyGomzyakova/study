using System;
using System.Diagnostics;

namespace study
{
    class Program
    {

        // 2. с ref 

       


        static int[] BubbleSort(ref int[] bst)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
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

            StopTime(stopWatch);
            return bst;
        }



        static int[] ViborSort(ref int[] bst, ref int[] b1)
        {
            b1 = bst;
            
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
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
            StopTime(stopWatch);
            return bst;
        }


      
        static int[] InsertionSort(ref int[] bst )
        {


            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
        

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
          
            StopTime(stopWatch);
            return bst;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите число элементов в массиве");
         int a1=int.Parse(Console.ReadLine());
            int[] ast = new int[a1];
            Array(ref ast);
            int[] b1 = ast;
           
            Console.WriteLine("Пузырь");
          // BubbleSort(ref ast ,ref b1);
            // Vvod(ref ast);
            Console.WriteLine("Вставка");
            InsertionSort(ref ast,ref b1);

            Console.WriteLine("Выборка");
            ViborSort(ref ast, ref b1);

            
            //  Vvod(ref ast);



        }


        static int[] Array(ref int[] bst)
        {
            Random rand = new Random();
            for (int i = 0; i < bst.Length; i++)
            {

                bst[i] = rand.Next();


            }
            return bst;
        }
        static int[] Vvod(ref int[] bst)
        {

            for (int i = 0; i < bst.Length; i++)
            {
                Console.Write(bst[i] + " ");
            }

            return bst;
        }

        static void StopTime(Stopwatch stopWatch) {
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds /10);

            Console.WriteLine(elapsedTime);



        }

    }
}   
