using System;

public class Program
{
    static void Main(string[] args)
    {
        int[] valores = { 85, 96, 65, 70, 55, 45, 62, 95, 74, 100, 74, 83, 93 };

        Console.Write("Posiciones de los numeros primos: ");
        for (int i = 0; i < valores.Length; i++)
        {
            if (EsPrimo(valores[i]))
            {
                Console.Write(i + " ");
            }
        }

        Console.Write("\nPosiciones de los numeros múltiplos de 5: ");
        for (int i = 0; i < valores.Length; i++)
        {
            if (valores[i] % 5 == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine("\nEl menor valor del arreglo es: " + ObtenerMenorValor(valores));

        int[] rangos = new int[4];
        for (int i = 0; i < valores.Length; i++)
        {
            int rango = valores[i] / 5;
            if (rango < 0)
            {
                rango = 0;
            }
            else if (rango > 3)
            {
                rango = 3;
            }
            rangos[rango]++;
        }

        Console.WriteLine("\nCantidad de numeros en cada rango:");
        Console.WriteLine("0-5: " + rangos[0]);
        Console.WriteLine("6-10: " + rangos[1]);
        Console.WriteLine("11-15: " + rangos[2]);
        Console.WriteLine("16-20: " + rangos[3]);

        double[] notasEvaluacion1 = {8, 7, 6, 9, 8, 7, 6, 9, 8, 7, 6, 9, 8, 7, 6, 9, 8, 7, 6, 9,
                                     8, 7, 6, 9, 8, 7, 6, 9, 8, 7, 6, 9, 8, 7, 6, 9, 8, 7, 6, 9};
        double[] notasEvaluacion2 = {7, 6, 5, 8, 7, 6, 5, 8, 7, 6, 5, 8, 7, 6, 5, 8, 7, 6, 5, 8,
                                     7, 6, 5, 8, 7, 6, 5, 8, 7, 6, 5, 8, 7, 6, 5, 8, 7, 6, 5, 8};
        double[] notasEvaluacion3 = {9, 8, 7, 10, 9, 8, 7, 10, 9, 8, 7, 10, 9, 8, 7, 10, 9, 8, 7, 10,
                                     9, 8, 7, 10, 9, 8, 7, 10, 9, 8, 7, 10, 9, 8, 7, 10, 9, 8, 7, 10};

        double[] notasFinales = ObtenerNotasFinales(notasEvaluacion1, notasEvaluacion2, notasEvaluacion3);

        Console.WriteLine("Notas finales:");
        for (int i = 0; i < notasFinales.Length; i++)
        {
            Console.WriteLine("Estudiante " + (i + 1) + ": " + notasFinales[i]);
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2)
        {
            return false;
        }
        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static int ObtenerMenorValor(int[] arreglo)
    {
        int menorValor = arreglo[0];
        for (int i = 1; i < arreglo.Length; i++)
        {
            if (arreglo[i] < menorValor)
            {
                menorValor = arreglo[i];
            }
        }
        return menorValor;
    }

    static double[] ObtenerNotasFinales(double[] notasEvaluacion1, double[] notasEvaluacion2, double[] notasEvaluacion3)
    {
        double[] notasFinales = new double[40];

        for (int i = 0; i < 40; i++)
        {
            double notaFinal = (notasEvaluacion1[i] * 0.3) + (notasEvaluacion2[i] * 0.3) + (notasEvaluacion3[i] * 0.4);
            notasFinales[i] = notaFinal;
        }

        return notasFinales;
    }
}