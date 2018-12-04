using System;
using System.Collections.Generic;



   public class Pet
    {
        public string statsUp(string startValue, int hp)
        {
        int value = Int32.Parse(startValue) + hp;
            return  value >= 100 ? "100" : value.ToString(); 
        }

        public string statsDown(string startValue, int lowerValue, int hp)
        {
        int value = Int32.Parse(startValue) - hp * lowerValue;
        return value <= 0 ? "0" : value.ToString();
        }

    }

