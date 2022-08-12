using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientSample
{
    internal class PasswdResponse
    {
        public string? Pwd { get; set; } 
        public string? Feedback { get; set; }

        public void PrintToConsole()
        {
            Console.WriteLine(
                $"Pwd: {Pwd} \n" +
                $"Feedback: {Feedback}");
        }
    }
}
