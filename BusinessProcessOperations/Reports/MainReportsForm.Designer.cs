namespace WindowsFormsApp1.Reports
{
    partial class MainReportsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.llTrailerScrap = new System.Windows.Forms.LinkLabel();
            this.llProbyCust = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manufacturing Operations and Business Intelligence";
            // 
            // llTrailerScrap
            // 
            this.llTrailerScrap.AutoSize = true;
            this.llTrailerScrap.Location = new System.Drawing.Point(12, 30);
            this.llTrailerScrap.Name = "llTrailerScrap";
            this.llTrailerScrap.Size = new System.Drawing.Size(67, 13);
            this.llTrailerScrap.TabIndex = 3;
            this.llTrailerScrap.TabStop = true;
            this.llTrailerScrap.Text = "Trailer Scrap";
            this.llTrailerScrap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llTrailerScrap_LinkClicked);
            // 
            // llProbyCust
            // 
            this.llProbyCust.AutoSize = true;
            this.llProbyCust.Location = new System.Drawing.Point(12, 52);
            this.llProbyCust.Name = "llProbyCust";
            this.llProbyCust.Size = new System.Drawing.Size(140, 13);
            this.llProbyCust.TabIndex = 4;
            this.llProbyCust.TabStop = true;
            this.llProbyCust.Text = "Profitability By Customer Tier";
            this.llProbyCust.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llProbyCust_LinkClicked);
            // 
            // MainReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llProbyCust);
            this.Controls.Add(this.llTrailerScrap);
            this.Controls.Add(this.label1);
            this.Name = "MainReportsForm";
            this.Text = "MainReportsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llTrailerScrap;
        private System.Windows.Forms.LinkLabel llProbyCust;
    }
}