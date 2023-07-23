using System;
using Result;

namespace SampleNamespace
{
    class Program
    {
        public static void Main()
        {
            char i = 'a';
            int num = 1000;
            long num2 = 10203;
            float num3 = 10.52f;
            double num4 = 12.2012020;

            Console.WriteLine(i + " - " + num + " - " + num2 + " - " + num3 + " - " + num4);

            Console.WriteLine(Retorno.RetornoSomar(Soma.Somar(num)));

            SampleClass sampleObject = new SampleClass();
            sampleObject.SampleMethod();

            string nameValue = sampleObject.GetName();
            Console.WriteLine("Valor de name: " + nameValue);
        }
    }


    class Soma{
        public static int Somar(int num){
            return  num;
        }
    }

    class Retorno
    {
        public static int RetornoSomar(int num)
        {
            int num1 = 1000;
            return Soma.Somar(num + num1);
        }
    }

}
