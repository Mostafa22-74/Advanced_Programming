using System;

namespace Week01_IO_Validation
{
    class Program
    {
        // A simple structure to represent an I/O tag from a Distributed Control System
        struct IOTag
        {
            public string TagName;
            public string SignalType; // e.g., DigitalInput, AnalogOutput
            public bool IsActive;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--- Industrial I/O Validation System ---");
            
            IOTag pumpStatus = new IOTag 
            { 
                TagName = "PMP_001_RUN", 
                SignalType = "DigitalInput", 
                IsActive = true 
            };

            Console.WriteLine($"Tag: {pumpStatus.TagName}");
            Console.WriteLine($"Type: {pumpStatus.SignalType}");
            Console.WriteLine($"Status: {(pumpStatus.IsActive ? "ONLINE" : "OFFLINE")}");
        }
    }
}