﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var play = new Player();
            var plan = new Enumerations.Planets();
            var me = new Menu();
            var inv = new Inventory();
            var ha = new HashCity();
            var ty = new Typotopia();
            var bb = new BugBay();
            var hc = new HeapStreet();
            var bi = new Binopoly();
            double balance = 20;

            me.Start();

            //while (balance < 1000)
            //{
            bi.Planet();
            
           Enumerations.Navigation navigation =  me.Options();


            //THIS IS CHANGE 




            //i'm going through changes








            //}

        }
    }

}