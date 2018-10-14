using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace week1.Homework7
{
    public class AsyncTesting
    {
        public async Task<string> OpeningCrawlAsync()
        {
            string line0 = "                                      Episode IV, A NEW HOPE";
            string line1 = " ";
            string line2 = "It is a period of civil war.  ";
            string line3 = "Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire.";
            string line4 = "During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR,";
            string line5 = "an armored space station with enough power to destroy an entire planet.";
            string line6 = " ";
            string line7 = "Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship,";
            string line8 = "custodian of the stolen plans that can save her people and restore freedom to the galaxy...";

            ArrayList OpeningCrawl = new ArrayList();
            OpeningCrawl.Add(line0);
            OpeningCrawl.Add(line1);
            OpeningCrawl.Add(line2);
            OpeningCrawl.Add(line3);
            OpeningCrawl.Add(line4);
            OpeningCrawl.Add(line5);
            OpeningCrawl.Add(line6);
            OpeningCrawl.Add(line7);
            OpeningCrawl.Add(line8);

            int lineNum = 0;
            string result = "";

            Console.WriteLine(OpeningCrawl[0]);

            while (lineNum < 9)
            {
                lineNum++;
                if (lineNum > 8)
                {
                    result = await Task.FromResult<string>("..............I've got a bad feeling about this");
                }
                else
                {
                    Console.WriteLine(OpeningCrawl[lineNum]);
                }
            }
            return result;
        }

        public async Task<int> AccessTheWebAsync()
        {
            // You need to add a reference to System.Net.Http to declare client.  
            HttpClient client = new HttpClient();

            // GetStringAsync returns a Task<string>. That means that when you await the  
            // task you'll get a string (urlContents).  
            Task<string> getStringTask = client.GetStringAsync("http://www.theforce.net/");

            // You can do work here that doesn't rely on the string from GetStringAsync.  
            DoIndependentWork();

            // The await operator suspends AccessTheWebAsync.  
            //  - AccessTheWebAsync can't continue until getStringTask is complete.  
            //  - Meanwhile, control returns to the caller of AccessTheWebAsync.  
            //  - Control resumes here when getStringTask is complete.   
            //  - The await operator then retrieves the string result from getStringTask.  
            string urlContents = await getStringTask;

            // The return statement specifies an integer result.  
            // Any methods that are awaiting AccessTheWebAsync retrieve the length value.  
            return urlContents.Length;
        }
        void DoIndependentWork()
        {
            Console.WriteLine("Working . . . . . . .\r\n");
        }
    }
}
