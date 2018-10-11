using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace week1.Advanced
{
    public class AsyncUtility
    {
        public async Task<string> BottlesOfBeerSongAsync()   //instead of void, there is a task that takes a string generic
        {
            int beerNum = 99;
            string word = "bottles";
            string result = "";
            while (beerNum > 0)
            {
                if(beerNum == 1)
                {
                    word = "bottle"; //singular instead of plural
                }

                Console.WriteLine(beerNum + " " + word + " of beer on the wall");
                Console.WriteLine(beerNum + " " + word + " of beer");
                Console.WriteLine("Take one down");
                Console.WriteLine("Pass it around");

                beerNum--;
                if (beerNum > 0)
                {
                    Console.WriteLine(beerNum + " " + word + " of beer on the wall");
                }
                else
                {
                    result = await Task.FromResult<string>("No more bottles of beer on the wall");
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
            Task<string> getStringTask = client.GetStringAsync("http://msdn.microsoft.com");

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
