using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            float myFloatValue = 10;
            int myIntValue = (int) myFloatValue;
            Console.WriteLine("myIntValue is " + myIntValue);
            int myInt = 10;

            byte myByte = (byte)myInt;

            double myDouble = (double)myByte;

            //bool myBool = (bool)myDouble;

            string myString = "false";

            //myBool = (bool)myString;

            //myString = (string)myInt;

            myString = myInt.ToString();

            //myBool = (bool)myByte;

            //myByte = (byte)myBool;

            short myShort = (short)myInt;

            char myChar = 'x';

            //myString = (string)myChar;

            long myLong = (long)myInt;

            decimal myDecimal = (decimal)myLong;
            myString = myString + myInt + myByte + myDouble + myChar;

            long number = 139401930;
            string text = "Player score: " + number;
            // text = number; text can not be converted to int
           //  text = (int)number; Ni aunque castee la declaracion el texto se puede convertir a numero, es obvio: Las letras son letras los numeros son numeros. 
        }
    }
}
