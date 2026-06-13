namespace WindowsFormsApp1
{
    partial class BootLoader
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
            this.btnLRW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBLC = new System.Windows.Forms.Button();
            this.btnProductionStatsViewer = new System.Windows.Forms.Button();
            this.btnCosting = new System.Windows.Forms.Button();
            this.btnKPI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLRW
            // 
            this.btnLRW.Location = new System.Drawing.Point(12, 73);
            this.btnLRW.Name = "btnLRW";
            this.btnLRW.Size = new System.Drawing.Size(136, 34);
            this.btnLRW.TabIndex = 0;
            this.btnLRW.Text = "Reporting Services";
            this.btnLRW.UseVisualStyleBackColor = true;
            this.btnLRW.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Business Process and Insights";
            // 
            // btnBLC
            // 
            this.btnBLC.Location = new System.Drawing.Point(166, 73);
            this.btnBLC.Name = "btnBLC";
            this.btnBLC.Size = new System.Drawing.Size(136, 34);
            this.btnBLC.TabIndex = 2;
            this.btnBLC.Text = "Cleanup Labels Queue";
            this.btnBLC.UseVisualStyleBackColor = true;
            this.btnBLC.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnProductionStatsViewer
            // 
            this.btnProductionStatsViewer.Location = new System.Drawing.Point(12, 113);
            this.btnProductionStatsViewer.Name = "btnProductionStatsViewer";
            this.btnProductionStatsViewer.Size = new System.Drawing.Size(136, 36);
            this.btnProductionStatsViewer.TabIndex = 3;
            this.btnProductionStatsViewer.Text = "Production Statistics";
            this.btnProductionStatsViewer.UseVisualStyleBackColor = true;
            this.btnProductionStatsViewer.Click += new System.EventHandler(this.btnProductionStatsViewer_Click);
            // 
            // btnCosting
            // 
            this.btnCosting.Location = new System.Drawing.Point(12, 155);
            this.btnCosting.Name = "btnCosting";
            this.btnCosting.Size = new System.Drawing.Size(135, 32);
            this.btnCosting.TabIndex = 4;
            this.btnCosting.Text = " Job Costing";
            this.btnCosting.UseVisualStyleBackColor = true;
            this.btnCosting.Click += new System.EventHandler(this.btnCosting_Click);
            // 
            // btnKPI
            // 
            this.btnKPI.Location = new System.Drawing.Point(14, 194);
            this.btnKPI.Name = "btnKPI";
            this.btnKPI.Size = new System.Drawing.Size(132, 36);
            this.btnKPI.TabIndex = 5;
            this.btnKPI.Text = "Sales and Revenue KPIs";
            this.btnKPI.UseVisualStyleBackColor = true;
            this.btnKPI.Click += new System.EventHandler(this.btnKPI_Click);
            // 
            // BootLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKPI);
            this.Controls.Add(this.btnCosting);
            this.Controls.Add(this.btnProductionStatsViewer);
            this.Controls.Add(this.btnBLC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLRW);
            this.Name = "BootLoader";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLRW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBLC;
        private System.Windows.Forms.Button btnProductionStatsViewer;
        private System.Windows.Forms.Button btnCosting;
        private System.Windows.Forms.Button btnKPI;
    }
}