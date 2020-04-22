using System;

namespace App
{
    public class ConsoleOutput : IOutput
    {
        public void Send(string message) => Console.WriteLine(message);
    }    
}