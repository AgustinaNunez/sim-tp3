using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Distribucion
    {
        private static int n;
        private static double[] vRND, vGen;
        private static Random RND = new Random();
        private static Random rnd, r1, r2;
        private static double pi, variable, z;

        // genera un valor aleatorio aplicando la distribucion uniforme
        public static double generarUniforme(double min, double max)
        {
            return RND.NextDouble() * (max - min) + min;
        }

        // genera un valor aleatorio aplicando la distribucion exponencial
        public static double generarExponencial(double media)
        {
            return - media * Math.Log(1 - RND.NextDouble());
        }

        // genera dos valores aleatorios aplicando la distribucion normal
        public static double[] generarNormal(int n, double media, double desviacion)
        {
            pi = Math.PI;
            r1 = new Random();
            r2 = new Random();


            double[] v;
            v = new double[n];


            for (int i = 0; i < v.Length; i++)
            {


                double aux1 = r1.NextDouble() * 1;
                double aux2 = r2.NextDouble() * 1;



                z = Math.Sqrt(-2 * Math.Log(aux1)) * (Math.Sin(2 * pi * aux2));

                variable = media + desviacion * (z);






                v[i] = Math.Round(variable, 4);





            }

            return v;
        }

        // genera un valor aleatorio aplicando la distribucion Poisson
        public static double generarPoisson(double media)
        {
            double p = 1;
            double x = -1;
            do
            {
                p = p * RND.NextDouble();
                x++;
            } while (p >= Math.Exp(media));
            return x;
        }
     
    }
}
