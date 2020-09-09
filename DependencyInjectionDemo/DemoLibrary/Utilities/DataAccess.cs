using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Utilities
{
    public class DataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading data");
        }

        public void SaveData(string message)
        {
            Console.WriteLine($"Saving {message}");
        }
    }
}
