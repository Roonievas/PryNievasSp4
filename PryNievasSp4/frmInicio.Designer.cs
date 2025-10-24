namespace PryNievasSp4
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartInfo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStripConexion = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConex = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnKmCamion = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTipoDeGrafico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo)).BeginInit();
            this.statusStripConexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartInfo
            // 
            chartArea2.Name = "ChartArea1";
            this.chartInfo.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartInfo.Legends.Add(legend2);
            this.chartInfo.Location = new System.Drawing.Point(306, 67);
            this.chartInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartInfo.Name = "chartInfo";
            this.chartInfo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartInfo.Series.Add(series2);
            this.chartInfo.Size = new System.Drawing.Size(349, 245);
            this.chartInfo.TabIndex = 0;
            this.chartInfo.Text = "chart1";
            // 
            // statusStripConexion
            // 
            this.statusStripConexion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripConexion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConex});
            this.statusStripConexion.Location = new System.Drawing.Point(0, 396);
            this.statusStripConexion.Name = "statusStripConexion";
            this.statusStripConexion.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStripConexion.Size = new System.Drawing.Size(675, 22);
            this.statusStripConexion.TabIndex = 1;
            this.statusStripConexion.Text = "statusStripConexion";
            // 
            // toolStripStatusLabelConex
            // 
            this.toolStripStatusLabelConex.Name = "toolStripStatusLabelConex";
            this.toolStripStatusLabelConex.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelConex.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabelConex.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // btnKmCamion
            // 
            this.btnKmCamion.Location = new System.Drawing.Point(31, 111);
            this.btnKmCamion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKmCamion.Name = "btnKmCamion";
            this.btnKmCamion.Size = new System.Drawing.Size(98, 34);
            this.btnKmCamion.TabIndex = 2;
            this.btnKmCamion.Text = "Kilometros";
            this.btnKmCamion.UseVisualStyleBackColor = true;
            this.btnKmCamion.Click += new System.EventHandler(this.btnKmCamion_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // lblTipoDeGrafico
            // 
            this.lblTipoDeGrafico.AutoSize = true;
            this.lblTipoDeGrafico.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeGrafico.Location = new System.Drawing.Point(34, 22);
            this.lblTipoDeGrafico.Name = "lblTipoDeGrafico";
            this.lblTipoDeGrafico.Size = new System.Drawing.Size(110, 18);
            this.lblTipoDeGrafico.TabIndex = 4;
            this.lblTipoDeGrafico.Text = "Tipo de gráfico:";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 418);
            this.Controls.Add(this.lblTipoDeGrafico);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnKmCamion);
            this.Controls.Add(this.statusStripConexion);
            this.Controls.Add(this.chartInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo)).EndInit();
            this.statusStripConexion.ResumeLayout(false);
            this.statusStripConexion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartInfo;
        private System.Windows.Forms.StatusStrip statusStripConexion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConex;
        private System.Windows.Forms.Button btnKmCamion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTipoDeGrafico;
    }
}