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

               // Console.WriteLine(Environment.NewLine);
                Console.WriteLine(counter.ToString() + timeLabel);
                Console.WriteLine(drawtLine(counter));
                System.Threading.Thread.Sleep(1000);
            }
        }
        static string drawtLine(int ctr)
        {
            string response = "";
            if (ctr == 1)
            {
                response = "*";
            }
            else
            {
                for (int l = 1; l <= ctr; l++)
                {
                    int leadingSpaces = ctr;
                    int trailingSpaces = 9 - ctr;
                    string theLine = "*";
                    // string theLine = "";
                   // if (l < ctr)
                  //  {
                        for (int ls = 1; ls <= leadingSpaces; ls++)
                        {
                            theLine += " ";
                        }
                   // }
                    theLine += "*";
                    response += theLine;
                    response += Environment.NewLine;
                }

            }
            return response;
        }


    }
}
