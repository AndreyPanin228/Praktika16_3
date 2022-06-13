using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR16_3
{
    public class Exam
    {
        public static void Third(double[] mass)
        {
            Queue< doubleList > myQueue = new Queue< doubleList >();
            int[] mass2 = new int[mass.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                int count = (from x in mass where x == mass[i] select x).Count();
                mass2[i] = count;

            }
            int j = 0;
            double[] mass3 = new double[mass.Length];
            while (j != mass.Length)
            {
                if (!mass3.Contains(mass[j]))
                {
                    doubleList num = new doubleList();
                    num.Number = mass[j];
                    num.Ch = mass2[j];
                    myQueue.Enqueue(num);
                    mass3[j] = mass[j];
                }
                j++;
            }
            Console.WriteLine("-------------------");
            foreach (doubleList bam in myQueue)
            {
                Console.WriteLine($"{bam.Number} - {bam.Ch}");
            }
            Console.WriteLine("-------------------");
            foreach (doubleList bam in myQueue)
            {
                Console.WriteLine($"{bam.Number*bam.Ch} - {bam.Ch}");
            }
        }
    }
    public class doubleList
    {
        private double number;
        private int ch;

        public int Ch
        {
            get { return ch; }
            set { ch = value; }
        }


        public double Number
        {
            get { return number; }
            set { number = value; }
        }


    }

}
