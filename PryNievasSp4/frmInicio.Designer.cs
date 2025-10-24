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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartInfo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStripConexion = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConex = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnKmCamion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo)).BeginInit();
            this.statusStripConexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartInfo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartInfo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartInfo.Legends.Add(legend1);
            this.chartInfo.Location = new System.Drawing.Point(266, 70);
            this.chartInfo.Name = "chartInfo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartInfo.Series.Add(series1);
            this.chartInfo.Size = new System.Drawing.Size(465, 302);
            this.chartInfo.TabIndex = 0;
            this.chartInfo.Text = "chart1";
            // 
            // statusStripConexion
            // 
            this.statusStripConexion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripConexion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConex});
            this.statusStripConexion.Location = new System.Drawing.Point(0, 424);
            this.statusStripConexion.Name = "statusStripConexion";
            this.statusStripConexion.Size = new System.Drawing.Size(800, 26);
            this.statusStripConexion.TabIndex = 1;
            this.statusStripConexion.Text = "statusStripConexion";
            // 
            // toolStripStatusLabelConex
            // 
            this.toolStripStatusLabelConex.Name = "toolStripStatusLabelConex";
            this.toolStripStatusLabelConex.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabelConex.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabelConex.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // btnKmCamion
            // 
            this.btnKmCamion.Location = new System.Drawing.Point(37, 96);
            this.btnKmCamion.Name = "btnKmCamion";
            this.btnKmCamion.Size = new System.Drawing.Size(85, 36);
            this.btnKmCamion.TabIndex = 2;
            this.btnKmCamion.Text = "button1";
            this.btnKmCamion.UseVisualStyleBackColor = true;
            this.btnKmCamion.Click += new System.EventHandler(this.btnKmCamion_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKmCamion);
            this.Controls.Add(this.statusStripConexion);
            this.Controls.Add(this.chartInfo);
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
    }
}