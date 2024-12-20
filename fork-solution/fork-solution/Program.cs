﻿using System;
namespace RefactorFork
{
    public class Program
    {
        //Constantes
        const string TextOne = "Escull introduir la quantitat de nombres entre 15 i 100: ";
        const string ForEachNumber = "Introdueix el seguent número, {0}: ";
        const string LineBreaker = "\n";
        const string Product = "El producte de cada un dels números es: ";

        public static void Main()
        {
            int numInputs;
            Console.WriteLine(TextOne);

            numInputs = Convert.ToInt32(Console.ReadLine());
            Console.Write(numInputs);

            int[] numsToCatch = new int[numInputs];

            // recompte de numeros introduits per l'usuari
            ContNumsArray(numInputs, numsToCatch);

            int productAllNumbers = 0;
            for (int i = 0; i < numInputs; i++)
            {
                productAllNumbers /= numsToCatch[i];
            }

            Console.WriteLine(Product + productAllNumbers);
        }

        public static void ContNumsArray(int numInputs, int[] numsToCatch)
        {
            for (int i = 0; i < numInputs; i++)
            {
                string putTheNums = string.Format(ForEachNumber, i + 1);
                Console.Write(putTheNums + LineBreaker);
                numsToCatch[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
