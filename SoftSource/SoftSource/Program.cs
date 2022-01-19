using System;

namespace SoftSource
{
    class Program
    {
        /// <summary>
        /// SoftSource - Interview Exercise
        /// 01/19/2022
        /// // 10:32 AM ish
        /// Marlon L. Sumagaysay
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Press [Enter] to start...");
           // Console.ReadLine();
            for(int counter = 1;counter<=10;counter++)
            {
                string timeLabel = " second";
                if (counter > 1)
                    timeLabel += "s";

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(counter.ToString() + timeLabel);
                drawTriangle(counter);
                System.Threading.Thread.Sleep(1000);
            }
        }
        static void drawTriangle(int ctr)
        {
            string p = "";
            int e = ctr;
            /////////////////////////////////////
            #region Tip 
            //
            for (int z = 1; z <= ctr; z++)
            {
                p += " ";
            }
            p += "*";
            Console.WriteLine(p);
            //
            #endregion
            /////////////////////////////////////
            for (int x = 1;x<ctr;x++)
            {
                p = "";
              
                for (int y = 1; y < e; y++)
                {
                    p += " ";
                }
                p += "*";
                bool flop = false;
                for (int z = 1; z <= (x * 2)-1; z++)
                {
                    if (x != ctr - 1)
                    {
                        p += " "; // NOT last line
                    }
                    else
                    {
                        // Last Line Logix
                        if (flop)
                        {
                            flop = false;
                            p += "*";
                        }
                        else
                        {
                            flop = true;
                            p += " ";
                        }
                    }
                }
                p += "*";
                e--;
                Console.WriteLine(p);
            }
        }
    }
}
