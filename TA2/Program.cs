// using Internal;
using System;
using System.Collections;
using MyLibrary;
using CSV_dataBase_Encryprted;
using System.Globalization;

namespace Program
{
    class Program
    {
        
        public static void Main()
        {
            var cl = new SampleClass();
        }
    }

    class SampleClass
    {
        private string info = "No where is ever here"; 
        public string Info{
            get{
                return info;
            }
            set{
                info = "You dare fucking change it?";
            }
        }
    }
}
