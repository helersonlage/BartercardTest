﻿namespace BartercardTest.Sort
{
    public class frequency : Ifrequency
    {
        public frequency(int _num, int _freq)
        {
            num = _num;
            freq = _freq;
        }

         public int num { get; }
         public int freq { get; }
    }
}