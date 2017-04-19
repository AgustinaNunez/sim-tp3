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
        public static double[] generarNormal(double media, double desviacion)
        {
            double[] valores = new double[2];
            Random rnd1 = new Random();
            double RND1 = rnd1.NextDouble();
            Random rnd2 = new Random();
            double RND2 = rnd2.NextDouble();
            valores[0] = (Math.Sqrt(-2 * Math.Log(RND1)) * Math.Cos(2 * Math.PI * RND2)) * desviacion + media;
            valores[1] = (Math.Sqrt(-2 * Math.Log(RND1)) * Math.Sin(2 * Math.PI * RND2)) * desviacion + media;

            return valores;
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
