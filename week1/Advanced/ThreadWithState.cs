using System;
using System.Collections.Generic;
using System.Text;

namespace week1.Advanced
{

    public delegate void ExampleCallback(int linecount);

    public class ThreadWithState
    {
        // State information used in the task.
        private string boilerplate;
        private int value;

        // Delegate used to execute the callback method when the
        // task is complete.
        private ExampleCallback callback;

        // The constructor obtains the state information and the
        // callback delegate.
        public ThreadWithState(string text, int number,
            ExampleCallback callbackDelegate)
        {
            boilerplate = text;
            value = number;
            callback = callbackDelegate;
        }

        /*
         The thread procedure performs the task, such as
         formatting and printing a document, and then invokes
         the callback delegate with the number of lines printed.
        */
        public void ThreadProc()
        {
            Console.WriteLine(boilerplate, value);
            if (callback != null)
                callback(1);
        }
    }
}