namespace WindowsFormsApplication1
{
    partial class TP3
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TP3));
            this.btn_generar = new System.Windows.Forms.Button();
            this.lbl_media = new System.Windows.Forms.Label();
            this.txt_media = new System.Windows.Forms.TextBox();
            this.lbl_lambda = new System.Windows.Forms.Label();
            this.txt_desv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lbl_Aleatorio = new System.Windows.Forms.Label();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.cbo_distrib = new System.Windows.Forms.ComboBox();
            this.lst_distrib = new System.Windows.Forms.ListView();
            this.valoresGenerados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgv_frec = new System.Windows.Forms.DataGridView();
            this.lbl_resultadoPrueba = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chrt_histograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_20 = new System.Windows.Forms.RadioButton();
            this.rb_10 = new System.Windows.Forms.RadioButton();
            this.rb_5 = new System.Windows.Forms.RadioButton();
            this.txt_confianza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_lambda = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_frec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_histograma)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_generar
            // 
            this.btn_generar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Location = new System.Drawing.Point(15, 257);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(451, 30);
            this.btn_generar.TabIndex = 4;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_media.Location = new System.Drawing.Point(13, 84);
            this.lbl_media.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(58, 17);
            this.lbl_media.TabIndex = 6;
            this.lbl_media.Text = "Media =";
            // 
            // txt_media
            // 
            this.txt_media.Enabled = false;
            this.txt_media.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_media.Location = new System.Drawing.Point(93, 83);
            this.txt_media.Margin = new System.Windows.Forms.Padding(4);
            this.txt_media.Name = "txt_media";
            this.txt_media.Size = new System.Drawing.Size(129, 25);
            this.txt_media.TabIndex = 2;
            this.txt_media.TextChanged += new System.EventHandler(this.txt_media_TextChanged);
            // 
            // lbl_lambda
            // 
            this.lbl_lambda.AutoSize = true;
            this.lbl_lambda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lambda.Location = new System.Drawing.Point(7, 123);
            this.lbl_lambda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lambda.Name = "lbl_lambda";
            this.lbl_lambda.Size = new System.Drawing.Size(83, 17);
            this.lbl_lambda.TabIndex = 7;
            this.lbl_lambda.Text = "Desviación =";
            // 
            // txt_desv
            // 
            this.txt_desv.Enabled = false;
            this.txt_desv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desv.Location = new System.Drawing.Point(93, 116);
            this.txt_desv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_desv.Name = "txt_desv";
            this.txt_desv.Size = new System.Drawing.Size(129, 25);
            this.txt_desv.TabIndex = 3;
            this.txt_desv.TextChanged += new System.EventHandler(this.txt_lambda_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_lambda);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_min);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_max);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_media);
            this.groupBox1.Controls.Add(this.lbl_media);
            this.groupBox1.Controls.Add(this.txt_desv);
            this.groupBox1.Controls.Add(this.lbl_lambda);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // txt_min
            // 
            this.txt_min.Enabled = false;
            this.txt_min.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_min.Location = new System.Drawing.Point(93, 18);
            this.txt_min.Margin = new System.Windows.Forms.Padding(4);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(129, 25);
            this.txt_min.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mínimo =";
            // 
            // txt_max
            // 
            this.txt_max.Enabled = false;
            this.txt_max.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_max.Location = new System.Drawing.Point(93, 50);
            this.txt_max.Margin = new System.Windows.Forms.Padding(4);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(129, 25);
            this.txt_max.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Máximo =";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(122, 12);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(128, 17);
            this.lblInicio.TabIndex = 9;
            this.lblInicio.Text = "Tipo de distribución:";
            // 
            // lbl_Aleatorio
            // 
            this.lbl_Aleatorio.AutoSize = true;
            this.lbl_Aleatorio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aleatorio.Location = new System.Drawing.Point(61, 40);
            this.lbl_Aleatorio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Aleatorio.Name = "lbl_Aleatorio";
            this.lbl_Aleatorio.Size = new System.Drawing.Size(189, 17);
            this.lbl_Aleatorio.TabIndex = 10;
            this.lbl_Aleatorio.Text = "Cantidad de valores a generar:";
            // 
            // txt_n
            // 
            this.txt_n.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n.Location = new System.Drawing.Point(253, 37);
            this.txt_n.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(126, 25);
            this.txt_n.TabIndex = 1;
            this.txt_n.TextChanged += new System.EventHandler(this.txt_numeros_TextChanged);
            // 
            // cbo_distrib
            // 
            this.cbo_distrib.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_distrib.FormattingEnabled = true;
            this.cbo_distrib.Items.AddRange(new object[] {
            "Uniforme",
            "Normal",
            "Exponencial",
            "Poisson"});
            this.cbo_distrib.Location = new System.Drawing.Point(253, 9);
            this.cbo_distrib.Name = "cbo_distrib";
            this.cbo_distrib.Size = new System.Drawing.Size(126, 25);
            this.cbo_distrib.TabIndex = 0;
            this.cbo_distrib.Text = "(ninguna)";
            this.cbo_distrib.SelectedIndexChanged += new System.EventHandler(this.cbo_distrib_SelectedIndexChanged);
            // 
            // lst_distrib
            // 
            this.lst_distrib.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.valoresGenerados});
            this.lst_distrib.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_distrib.Location = new System.Drawing.Point(478, 9);
            this.lst_distrib.Name = "lst_distrib";
            this.lst_distrib.Size = new System.Drawing.Size(199, 278);
            this.lst_distrib.TabIndex = 5;
            this.lst_distrib.UseCompatibleStateImageBehavior = false;
            this.lst_distrib.View = System.Windows.Forms.View.Details;
            // 
            // valoresGenerados
            // 
            this.valoresGenerados.Tag = "";
            this.valoresGenerados.Text = "Valores Generados";
            this.valoresGenerados.Width = 165;
            // 
            // dgv_frec
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_frec.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_frec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_frec.Location = new System.Drawing.Point(15, 292);
            this.dgv_frec.Name = "dgv_frec";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_frec.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_frec.Size = new System.Drawing.Size(1220, 298);
            this.dgv_frec.TabIndex = 7;
            // 
            // lbl_resultadoPrueba
            // 
            this.lbl_resultadoPrueba.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultadoPrueba.ForeColor = System.Drawing.Color.LightCoral;
            this.lbl_resultadoPrueba.Location = new System.Drawing.Point(15, 605);
            this.lbl_resultadoPrueba.Name = "lbl_resultadoPrueba";
            this.lbl_resultadoPrueba.Size = new System.Drawing.Size(1220, 21);
            this.lbl_resultadoPrueba.TabIndex = 8;
            this.lbl_resultadoPrueba.Text = "lbl_resultadoPrueba";
            this.lbl_resultadoPrueba.Click += new System.EventHandler(this.lbl_resultadoPrueba_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nro. intervalos:";
            // 
            // chrt_histograma
            // 
            chartArea1.Name = "ChartArea1";
            this.chrt_histograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrt_histograma.Legends.Add(legend1);
            this.chrt_histograma.Location = new System.Drawing.Point(683, 12);
            this.chrt_histograma.Name = "chrt_histograma";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Frecuencia";
            this.chrt_histograma.Series.Add(series1);
            this.chrt_histograma.Size = new System.Drawing.Size(552, 277);
            this.chrt_histograma.TabIndex = 6;
            this.chrt_histograma.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_20);
            this.groupBox2.Controls.Add(this.rb_10);
            this.groupBox2.Controls.Add(this.rb_5);
            this.groupBox2.Controls.Add(this.txt_confianza);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(259, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 185);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gráfico y Prueba de K-S";
            // 
            // rb_20
            // 
            this.rb_20.AutoSize = true;
            this.rb_20.Location = new System.Drawing.Point(98, 123);
            this.rb_20.Name = "rb_20";
            this.rb_20.Size = new System.Drawing.Size(40, 21);
            this.rb_20.TabIndex = 6;
            this.rb_20.TabStop = true;
            this.rb_20.Text = "20";
            this.rb_20.UseVisualStyleBackColor = true;
            // 
            // rb_10
            // 
            this.rb_10.AutoSize = true;
            this.rb_10.Location = new System.Drawing.Point(98, 96);
            this.rb_10.Name = "rb_10";
            this.rb_10.Size = new System.Drawing.Size(40, 21);
            this.rb_10.TabIndex = 5;
            this.rb_10.TabStop = true;
            this.rb_10.Text = "10";
            this.rb_10.UseVisualStyleBackColor = true;
            // 
            // rb_5
            // 
            this.rb_5.AutoSize = true;
            this.rb_5.Location = new System.Drawing.Point(98, 69);
            this.rb_5.Name = "rb_5";
            this.rb_5.Size = new System.Drawing.Size(33, 21);
            this.rb_5.TabIndex = 4;
            this.rb_5.TabStop = true;
            this.rb_5.Text = "5";
            this.rb_5.UseVisualStyleBackColor = true;
            // 
            // txt_confianza
            // 
            this.txt_confianza.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confianza.Location = new System.Drawing.Point(137, 151);
            this.txt_confianza.Name = "txt_confianza";
            this.txt_confianza.Size = new System.Drawing.Size(63, 25);
            this.txt_confianza.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel de confianza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lambda =";
            // 
            // txt_lambda
            // 
            this.txt_lambda.Enabled = false;
            this.txt_lambda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lambda.Location = new System.Drawing.Point(98, 156);
            this.txt_lambda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lambda.Name = "txt_lambda";
            this.txt_lambda.Size = new System.Drawing.Size(129, 25);
            this.txt_lambda.TabIndex = 9;
            // 
            // TP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1274, 641);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chrt_histograma);
            this.Controls.Add(this.lbl_resultadoPrueba);
            this.Controls.Add(this.dgv_frec);
            this.Controls.Add(this.lst_distrib);
            this.Controls.Add(this.cbo_distrib);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.lbl_Aleatorio);
            this.Controls.Add(this.lblInicio);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TP3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generación de números aleatorios";
            this.Load += new System.EventHandler(this.TP3Inicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_frec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_histograma)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.TextBox txt_media;
        private System.Windows.Forms.Label lbl_lambda;
        private System.Windows.Forms.TextBox txt_desv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lbl_Aleatorio;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.ComboBox cbo_distrib;
        private System.Windows.Forms.ListView lst_distrib;
        private System.Windows.Forms.DataGridView dgv_frec;
        private System.Windows.Forms.Label lbl_resultadoPrueba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_histograma;
        private System.Windows.Forms.ColumnHeader valoresGenerados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_confianza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_20;
        private System.Windows.Forms.RadioButton rb_10;
        private System.Windows.Forms.RadioButton rb_5;
        private System.Windows.Forms.TextBox txt_lambda;
        private System.Windows.Forms.Label label5;
    }
}

