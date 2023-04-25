namespace graficosPedidos
{
    partial class formPedidos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartPedidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chartQueso = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartQueso)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPedidos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPedidos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPedidos.Legends.Add(legend1);
            this.chartPedidos.Location = new System.Drawing.Point(29, 41);
            this.chartPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.chartPedidos.Name = "chartPedidos";
            this.chartPedidos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Unidades Producto";
            dataPoint1.AxisLabel = "Unidades";
            series1.Points.Add(dataPoint1);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Precio Producto";
            this.chartPedidos.Series.Add(series1);
            this.chartPedidos.Series.Add(series2);
            this.chartPedidos.Size = new System.Drawing.Size(892, 286);
            this.chartPedidos.TabIndex = 0;
            this.chartPedidos.Text = "graficoP";
            this.chartPedidos.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "GRÁFICO DE PEDIDOS DE CLIENTE";
            // 
            // chartQueso
            // 
            chartArea2.Name = "ChartArea1";
            this.chartQueso.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartQueso.Legends.Add(legend2);
            this.chartQueso.Location = new System.Drawing.Point(94, 363);
            this.chartQueso.Name = "chartQueso";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "producto";
            this.chartQueso.Series.Add(series3);
            this.chartQueso.Size = new System.Drawing.Size(804, 267);
            this.chartQueso.TabIndex = 2;
            this.chartQueso.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Cantidad de productos por pedido";
            this.chartQueso.Titles.Add(title1);
            // 
            // formPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1089, 677);
            this.Controls.Add(this.chartQueso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartPedidos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formPedidos";
            this.Text = "Grafico Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.chartPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartQueso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQueso;
    }
}

