﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
       //Needs to make these properties Year, Make, Model, EngineNoise, HonkNoise, IsDriveable--DONE HERE


        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set;}
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()--DONE
        //The methods should take one string parameter: the respective noise property--DONE

        public void MakeEngineNoise()
        {
            Console.WriteLine (EngineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }

    }
}
