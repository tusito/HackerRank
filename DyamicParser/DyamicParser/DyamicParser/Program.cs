﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyamicParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = @"   UserName: admin;
                            Password: super password;

                            TimeToLive: 4;
                            IsEnabled: true;   
                        ";


            var parser = new Parser();
            var r = parser.Parse(s);

            Console.WriteLine(r.UserName);
            Console.WriteLine(r.Password);
            Console.WriteLine(r.TimeToLive);
            Console.WriteLine(r.IsEnabled);
            Console.ReadKey();
        }
    }
}
