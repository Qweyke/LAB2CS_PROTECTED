﻿
using System;

namespace LAB2CS_red
{
    internal class Test
    {
        static void Main(string[] args)
        {

            BaseList abstr = new ArrList();
            BaseList chain = new ChainList();           

            Random rnd = new();

            int iter = 200;

            for (int i = 0; i < iter; i++)
            {
                int ops = rnd.Next(5);
                int value = rnd.Next(100);
                int pos = rnd.Next(200);

                switch (ops)
                {
                    case 0:

                        abstr.Add(value);
                        chain.Add(value);
                        break;

                    case 1:

                        abstr.Delete(pos);
                        chain.Delete(pos);
                        break;

                    case 2:

                        abstr.Insert(value, pos);
                        chain.Insert(value, pos);

                        break;

                    /*case 3:
                        //Console.WriteLine("clr");
                        abstr.Clear();
                        chain.Clear();
                        break;*/

                    case 4:

                        abstr[pos] = value;
                        chain[pos] = value;
                        break;
                }
            }

            //abstr.Sort();           
            //chain.Sort();
            abstr.Sort2();
            abstr.Show();
            Console.WriteLine("\n\n");
            chain.Sort2();
            abstr.Show();

            if (abstr.IsEqual(chain)) Console.WriteLine("Успешно для 1 теста");
            else Console.WriteLine("Шляпа для 1 теста");

            for (int i = 0; i < iter; i++)
            {
                int ops2 = rnd.Next(6);

                switch (ops2)
                {
                    case 0:
                        chain = abstr.Clone();                        
                        break;

                    case 1:
                        abstr = chain.Clone();                       
                        break;

                    case 2:
                        abstr.Assign(chain);
                        break;

                    case 3:
                        chain.Assign(abstr);
                        break;
                    
                    case 4:
                        chain.AssignTo(abstr);
                        break;

                    case 5:
                        abstr.AssignTo(chain);
                        break;
                }
            }

            if (abstr.IsEqual(chain)) Console.WriteLine("Успешно для 2 теста");
            else Console.WriteLine("Шляпа");

            //abstr.Show();
            Console.WriteLine("\n\n");
            //chain.Show();
            Console.WriteLine("\n\n");

            Console.WriteLine($"Arr count = {abstr.Count}, Chain count = {chain.Count}\n");

            Console.WriteLine("\n\nНажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
