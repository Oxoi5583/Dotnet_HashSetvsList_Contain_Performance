using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;


namespace TEST{
    class TESTObj{
        public static void Main(){
            
            int test_times = 100000;

            Stopwatch sw = new Stopwatch();
            HashSet<string> test_hs = new HashSet<string>();
            List<string> test_ls = new List<string>();

            for(int i = 0; i < test_times; i++){
                string i_str = i.ToString();
                test_hs.Add(i_str);
                test_ls.Add(i_str);
            }

            sw.Start();
            for(int i = 0; i < test_times; i++){
                string i_str = i.ToString();
                bool is_exists = test_ls.Contains(i_str);
                Console.WriteLine(i +" "+ is_exists);
            }
            sw.Stop();
            double ls_ms = sw.ElapsedMilliseconds;


            sw.Reset();
            sw.Start();
            for(int i = 0; i < test_times; i++){
                string i_str = i.ToString();
                bool is_exists = test_hs.Contains(i_str);
                Console.WriteLine(i +" "+ is_exists);
            }
            sw.Stop();
            double hs_ms = sw.ElapsedMilliseconds;

            string ResultText = "";
            ResultText += "Result : ";
            ResultText += "     ls = "+ls_ms;
            ResultText += "     hs = "+hs_ms;
            Console.WriteLine(ResultText);
            /*
            SortedList<int,int> sl = new System.Collections.Generic.SortedList<int,int>();
            sl.Add(1,5);
            sl.Add(5,10);
            sl.Add(2,3);
            foreach(int i in sl.Keys){
                Console.WriteLine(i);
            }*/
        }
    }
}