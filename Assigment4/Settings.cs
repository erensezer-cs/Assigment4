using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment4
{
    class Settings
    {
        static public void GameTable(
            string f1,string f2,string f3,string f4,string f5,string f6,string f7,string f8,string f9)
        {
            Console.WriteLine($" {f1} | {f2} | {f3}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {f4} | {f5} | {f6}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {f7} | {f8} | {f9}");
        }
            
            

        static public void GameMenu()
        {
            Console.Clear();
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. About the author");
            Console.WriteLine("3. Exit");
        }
        
        
    }
}
