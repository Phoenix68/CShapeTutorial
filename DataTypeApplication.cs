using System;

namespace DataTypeApplication{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Size of bool, {0}",sizeof(bool));
            Console.WriteLine("Size of byte, {0}",sizeof(byte));
            Console.WriteLine("Size of char, {0}",sizeof(char));
            Console.WriteLine("Size of decimal, {0}",sizeof(decimal));
            Console.WriteLine("Size of double, {0}",sizeof(double));
            Console.WriteLine("Size of float, {0}",sizeof(float));
            Console.WriteLine("Size of int, {0}",sizeof(int));
            Console.WriteLine("Size of long, {0}",sizeof(long));
            Console.WriteLine("Size of sbyte, {0}",sizeof(sbyte));
            Console.WriteLine("Size of short, {0}",sizeof(short));
            Console.WriteLine("Size of uint, {0}",sizeof(uint));
            Console.WriteLine("Size of ulong, {0}",sizeof(ulong));
            Console.WriteLine("Size of ushort, {0}",sizeof(ushort));
            Console.ReadLine();

            object obj;
            obj = 100; //boxing
            dynamic d = 20;
            String str = "tutoials Point";
            // Console.WriteLine("Size of object, {0}",sizeof(object));
            // Console.WriteLine("Size of dynamic, {0}",sizeof(dynamic));
            // Console.WriteLine("Size of String, {0}",sizeof(String));
            // @"tutoials Point";

            // char* cptr;
            // int* iptr;



        }
    }
}

