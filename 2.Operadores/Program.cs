﻿namespace _2.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES
            //operadores Numéricos
            //Cambio de signo

            int num1 = 5;
            int num2 = -num1;
            int num3 = +num2;
            int num4 = -num3;

            Console.WriteLine($"{num1} // {num2} // {num3} // {num4}");

            //Operadores Aritméticos

            int num5 = 3 + 5; //Suma
            int num6 = 100 - 26; //resta
            int num7 = 4 * 2; //Producto
            //float num8 =(float) 5 / 3; //division
            //float num8 = 5f / 3;
            //float num8 = 5 / 3f;
            float num8 = 5f / 3f;
            double num9 = 5d / 3;
            decimal num10 = 5 / 3m;
            Console.WriteLine($"Suma: {num5}, resta: {num6}, producto: {num7}, division: {num8}, num9: {num9}, num10: {num10}");

            //Operadores incremento(++),  decremento(--)
            num1++;        //num1 = num1 + 1; incremento
            num2--; //num2 = num2 - 1; decremento
            num3 += 5; //num3  = num3 + 5;
            num4 -= 20; //num4 = num4 - 20;
            num5 *= 31;    //num5 = num5 * 31;
            num7 /= num1;  //num7 = num7 / num1;

            //Orden de evaluación operadores asistemáticos
            int num11 = 4 * 3 / 2;// *,/
            int num12 = 4 / 3 * 2;// /,*
            int num13 = (4 * 3) / 2;// (),/
            int num14 = 4 * (3 / 2);// (),*
            int num15 = 4 + 6 * 3;// *,+
            int num16 = 4 + 6 * (2 - 1) / 2;// (),*,/,+
            Console.WriteLine($"num11: {num11}, num12: {num12}, num13: {num13}, num14: {num14}, num15: {num15}, num16: {num16}");

            //Operadores lógicos
            //Conjunción - AND - &&
            Console.WriteLine("Tabla de verdad conjunción");
            Console.WriteLine($"V && V = {true && false}");
            Console.WriteLine($"V && F = {true && false}");
            Console.WriteLine($"F && V = {false && true}");
            Console.WriteLine($"F && F = {false && false}");

            //Disyunción - OR -  ||
            Console.WriteLine("Tabla de verdad conjunción");
            Console.WriteLine($"V || V = {true || false}");
            Console.WriteLine($"V || F = {true || false}");
            Console.WriteLine($"F || V = {false || true}");
            Console.WriteLine($"F || F = {false || false}");
            bool exp1 = true;
            bool exp2 = false;
            bool exp3 = exp1 && exp2;
            bool exp4 = exp2 || exp3;
            bool exp5 = !exp4 || exp2;

            Console.WriteLine($"exp1: {exp1}, exp2: {exp2}, exp3:{exp3}, exp4:{exp4}, exp5:{exp5}");
        }
        
    }
}
