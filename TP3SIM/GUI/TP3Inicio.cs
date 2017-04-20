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
        int intervalos;

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
            //generar valores carga el array numeros con la distribucion elegida en el combo box
            generarValores();
            
            if (cbo_distrib.SelectedIndex == 0)
            {
                generar_tabla_distribucion_Uniforme();

            }
            else
            {
                generar_tablas();
            }
        }

       

        public void generar_tabla_distribucion_Uniforme()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mín");
            dt.Columns.Add("Máx");
            dt.Columns.Add("Marca Clase");
            dt.Columns.Add("Fo");
            dt.Columns.Add("P()");
            dt.Columns.Add("Fe");
            dt.Columns.Add("Po");
            dt.Columns.Add("Pe");
            dt.Columns.Add("PoAc");
            dt.Columns.Add("PeAc");
            dt.Columns.Add("PoAc-PeAc");

            if (rb_5.Checked)
            {
                intervalos = 5;
                rb_10.Enabled = false;
                rb_20.Enabled = false;
            }
            else if (rb_10.Checked)
            {
                intervalos = 10;
                rb_20.Enabled = false;
                rb_5.Enabled = false;
            }
            else
            {
                intervalos = 20;
                rb_10.Enabled = false;
                rb_5.Enabled = false;
            }
                
            double min = numeros[0];
            double max = numeros[0];
            double intSig = 0;
            double frec = 0;
            double marcaClase = 0;
            double j = 0;

            int fe = 0;
            double po = 0;
            double pe = 0;
            double poAc = 0;
            double peAc = 0;
            double abs = 0;

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
                }
            
                fe = n / intervalos;
                //frec = (frec - fe) / fe;
                po = (double) frec / (double) n;
                pe = fe / n;
                poAc = poAc + po;
                peAc = peAc + pe;
                abs = poAc - peAc;
                Math.Abs(abs);


                chrt_histograma.Series["Series1"].Points.AddXY((j + (cteIntervalo / 2)), fe);
                  
                // agus
                DataRow dr = dt.NewRow();
                dr["Mín"] = j;
                dr["Máx"] = intSig;
                dr["Marca Clase"] = marcaClase;
                dr["Fe"] = fe;
                dr["Fo"] = frec;
                dr["Po"] = po;
                dr["Pe"] = pe;
                dr["PoAc"] = poAc;
                dr["PeAc"] = peAc;
                dr["PoAc-PeAc"] = abs;



                dt.Rows.Add(dr);

                frec = 0;
            }           

            dgv_frec.DataSource = dt;
        }

        

        public void generar_tablas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mín");
            dt.Columns.Add("Máx");
            dt.Columns.Add("Marca Clase");
            dt.Columns.Add("Fo");
            dt.Columns.Add("P()");
            dt.Columns.Add("Fe");
            dt.Columns.Add("Po");
            dt.Columns.Add("Pe");
            dt.Columns.Add("PoAc");
            dt.Columns.Add("PeAc");
            dt.Columns.Add("PoAc-PeAc");

            if (rb_5.Checked)
            {
                intervalos = 5;
                rb_10.Enabled = false;
                rb_20.Enabled = false;
            }
            else if (rb_10.Checked)
            {
                intervalos = 10;
                rb_20.Enabled = false;
                rb_5.Enabled = false;
            }
            else
            {
                intervalos = 20;
                rb_10.Enabled = false;
                rb_5.Enabled = false;
            }
                
            double min = numeros[0];
            double max = numeros[0];
            double intSig = 0;
            double frec = 0;
            double marcaClase = 0;
            double j = 0;

            double prob;
            double fe = 0;
            double po = 0;
            double pe = 0;
            double poAc = 0;
            double peAc = 0;
            double abs = 0;

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
                }

                //prob = (1 / (1 * Math.Sqrt((2 * (Math.PI))))) * Math.Exp(-0.5 * (marcaClase * marcaClase));
                prob = 0;
                
                fe = prob * (double)n;
                po = (double) frec / (double) n;
                pe = fe / n;
                poAc = poAc + po;
                peAc = peAc + pe;
                abs = poAc - peAc;
                Math.Abs(abs);

                //chart1.Titles.Add("Frecuencia Observada");

                chrt_histograma.Series["Series1"].Points.AddXY((j + (cteIntervalo / 2)), frec);
                  
                // agus
                DataRow dr = dt.NewRow();
                dr["Mín"] = j;
                dr["Máx"] = intSig;
                dr["Marca Clase"] = marcaClase;
                dr["Fe"] = fe;
                dr["P()"] = prob;
                dr["Fo"] = frec;
                dr["Po"] = po;
                dr["Pe"] = pe;
                dr["PoAc"] = poAc;
                dr["PeAc"] = peAc;
                dr["PoAc-PeAc"] = abs;



                dt.Rows.Add(dr);

                frec = 0;
                prob = 0;
            }           

            dgv_frec.DataSource = dt;
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
                        lst_distrib.Items.Add(numeros[i].ToString("N4"));
                    }                            
                    break;
                case (int) tipo_distribucion.Exponencial:
                    media = Convert.ToDouble(txt_media.Text);
                    for (int i = 0; i < n; i++)
                    {
                        numeros[i] = Distribucion.generarExponencial(media);
                        lst_distrib.Items.Add(numeros[i].ToString("N4"));
                    }                        
                    break;
                case (int) tipo_distribucion.Poisson:
                    media = Convert.ToDouble(txt_media.Text);
                    for (int i = 0; i < n; i++)
                    {
                        numeros[i] = Distribucion.generarPoisson(media);
                        lst_distrib.Items.Add(numeros[i].ToString("N4"));
                    }                        
                    break;
                case (int) tipo_distribucion.Normal:
                    media = Convert.ToDouble(txt_media.Text);
                    desv = Convert.ToDouble(txt_desv.Text);
                    for (int i = 0; i < n; i++)         //for (int i = 0; i < n/2; i++)----> por que divido 2 
                    {
                        numeros = Distribucion.generarNormal(n, media, desv);
                        lst_distrib.Items.Add(numeros[i].ToString("N4"));
                    }
                    break;
            }                            

           
            return numeros;
        }
        
        private void txt_numeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_media_TextChanged(object sender, EventArgs e)
        {
            
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


        private void txt_intervalos_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
