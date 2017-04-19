using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TP3 : Form
    {
        enum tipo_distribucion { Uniforme, Poisson, Normal, Exponencial };
        double confianza = 0.95;
        int distribucion_seleccionada = 0;
        int n;
        double[] numeros;

        public TP3()
        {
            InitializeComponent();
        }

        private void TP3Inicio_Load(object sender, EventArgs e)
        {
            lbl_resultadoPrueba.Visible = false;
            txt_confianza.Text = confianza.ToString();
            txt_confianza.Enabled = false;
        }
                
        public void btn_generar_Click(object sender, EventArgs e)
        {
            generarValores();
            generar_tablas();
            graficarHistograma();
        }

        public void graficarHistograma()
        {

        }

        public void generar_tablas()
        {
            DataTable dt_frec = new DataTable();
            dt_frec.Columns.Add("Mín");
            dt_frec.Columns.Add("Máx");
            dt_frec.Columns.Add("Marca Clase");
            dt_frec.Columns.Add("Fo");
            dt_frec.Columns.Add("Po");
            dt_frec.Columns.Add("Fe");
            dt_frec.Columns.Add("Pe");
            dt_frec.Columns.Add("PeAc");
            dt_frec.Columns.Add("PoAc");
            dt_frec.Columns.Add("PeAc-PoAc");

            int intervalos = Convert.ToInt32(txt_intervalos.Text);
            double min = numeros[0];
            double max = numeros[0];
            double intSig = 0;
            int frec = 0;
            double marcaClase = 0;
            double j = 0;
            double prob;
            double fe = 0;

            // armar intervalos
            for (int i = 0; i < n; i++)
            {
                if(numeros[i] > max)
                {
                    max = numeros[i];
                }
                if(numeros[i] < min)
                {
                    min = numeros[i];
                }
            }

            double cteIntervalo = (max - min) / intervalos;
            for (j = min; j < max; j = j + cteIntervalo)
            {
                intSig = j + cteIntervalo;
                marcaClase = (intSig + j) / 2;
                for (int i = 0; i < n; i++)
                {
                    frec = frec + 1;
                    //frec++;
                }

                prob = (1 / (1 * Math.Sqrt((2 * (Math.PI))))) * Math.Exp(-0.5 * (marcaClase * marcaClase));
                fe = prob * n;

                DataRow dr = dt_frec.NewRow();
                dr["Mín"] = j;
                dr["Máx"] = intSig;
                dr["Marca Clase"] = marcaClase;
                dr["Fo"] = frec;
                dr["Po"] = prob;
                dr["Fe"] = fe;

                dt_frec.Rows.Add(dr);

                frec = 0;
                prob = 0;
            }           

            dgv_frec.DataSource = dt_frec;
        }

        public double[] generarValores()
        {
            //Creo el objeto de la clase Random 
            Random RND = new Random();
            n = Convert.ToInt32(txt_n.Text);

            //Creamos un array que va a contener cantidad aleatoria de numeros que ingresamos por el texbox
            numeros = new double[n];

            //Recorremos el array y vamos asignando a cada posición un número aleatorio
            double min, max, media, desv;
            switch (distribucion_seleccionada)
            {
                case (int) tipo_distribucion.Uniforme:
                    min = Convert.ToDouble(txt_min.Text);
                    max = Convert.ToDouble(txt_max.Text);
                    for (int i = 0; i < n; i++)
                    {
                        numeros[i] = Distribucion.generarUniforme(min, max);
                        lst_distrib.Items.Add(numeros[i].ToString());
                    }                            
                    break;
                case (int) tipo_distribucion.Exponencial:
                    media = Convert.ToDouble(txt_media.Text);
                    for (int i = 0; i < n; i++)
                    {
                        numeros[i] = Distribucion.generarExponencial(media);
                        lst_distrib.Items.Add(numeros[i].ToString());
                    }                        
                    break;
                case (int) tipo_distribucion.Poisson:
                    media = Convert.ToDouble(txt_media.Text);
                    for (int i = 0; i < n; i++)
                    {
                        numeros[i] = Distribucion.generarPoisson(media);
                        lst_distrib.Items.Add(numeros[i].ToString());
                    }                        
                    break;
                case (int) tipo_distribucion.Normal:
                    media = Convert.ToDouble(txt_media.Text);
                    desv = Convert.ToDouble(txt_desv.Text);
                    for (int i = 0; i < n/2; i++)
                    {
                        //numeros[i] = Distribucion.generarNormal(media, desv);
                        //lst_distrib.Items.Add(numeros[i].ToString());
                    }
                    break;
            }                            

            ////Mostramos el arreglo con los numeros en pantalla
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    DataRow dr = dt.NewRow();
            //    dt.Rows.Add(numeros[i]);

            //    lst_distrib.Items.Add(numeros[i].ToString());
            //}
            //dgv_numeros.DataSource = dt;
            return numeros;
        }
        
        private void txt_numeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_media_TextChanged(object sender, EventArgs e)
        {
            //double media = calcularMedia();
            //string mensaje = Convert.ToString(media);
            ////enseguida se muestra en el textbox esta variable
            //txt_media.Text = mensaje;
        }

        public double calcularMedia()
        {
            double[] numerosGenerados = generarValores();
            int n;
            n = Convert.ToInt32(txt_n.Text);
            n = int.Parse(txt_n.Text);
            double media = 0;
            for (int i = 0; i < numerosGenerados.Length; i++)
            {
                double contar = i++;
                media = contar / n;
            }
            return media;
        }

        public double calcularLambda()
        {
            double media = calcularMedia();
            double lambda = 1 / media;
            return lambda;
        }

        private void txt_lambda_TextChanged(object sender, EventArgs e)
        {
            //double lambda = calcularLambda();
            //string mensaje = Convert.ToString(lambda);

            ////enseguida se muestra en el textbox esta variable
            //txt_media.Text = mensaje;
        }

        private void cbo_distrib_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo_distrib.SelectedIndex)
            {
                case 0:
                    distribucion_seleccionada = (int) tipo_distribucion.Uniforme;
                    txt_min.Enabled = true;
                    txt_max.Enabled = true;
                    txt_media.Enabled = false;
                    txt_desv.Enabled = false;
                    break;
                case 1:
                    distribucion_seleccionada = (int) tipo_distribucion.Normal;
                    txt_min.Enabled = false;
                    txt_max.Enabled = false;
                    txt_media.Enabled = true;
                    txt_desv.Enabled = true;
                    break;
                case 2:
                    distribucion_seleccionada = (int) tipo_distribucion.Exponencial;
                    txt_min.Enabled = false;
                    txt_max.Enabled = false;
                    txt_media.Enabled = true;
                    txt_desv.Enabled = false;
                    break;
                case 3:
                    distribucion_seleccionada = (int) tipo_distribucion.Poisson;
                    txt_min.Enabled = false;
                    txt_max.Enabled = false;
                    txt_media.Enabled = true;
                    txt_desv.Enabled = false;
                    break;
            }
            txt_min.Text = "";
            txt_max.Text = "";
            txt_media.Text = "";
            txt_desv.Text = "";
        }
        
    }
}
