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
            return Math.Round(RND.NextDouble() * (max - min) + min, 4);
        }

        // genera un valor aleatorio aplicando la distribucion exponencial
        public static double[] generarExponencial(double media, int n)
        {
            double[] v;
            v = new double[n];

            for (int i = 0; i < v.Length; i++)
            {

                v[i] = Math.Round(-media * Math.Log(1 - RND.NextDouble()), 4);

            }

            return v;

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



        public static double[] generarPoisson(double media, int n)
        {
            double[] v;
            v = new double[n];

            double p = 1;
            double x = 0;
            double u = 0;

            double a = Math.Exp(-media);

            for (int i = 0; i < v.Length; i++)
            {
                p = 1;
                x = 0;
                do
                {
                    u = RND.NextDouble();
                    p = p * u;

                    x++;
                } while (p >= a);

                v[i] = x;


            }
            return v;
        }







    }
}