namespace QUIZ1_IGNACIO
{
    partial class frm1
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
            this.btnnull = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnnull
            // 
            this.btnnull.AllowDrop = true;
            this.btnnull.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnull.Location = new System.Drawing.Point(12, 12);
            this.btnnull.Name = "btnnull";
            this.btnnull.Size = new System.Drawing.Size(212, 94);
            this.btnnull.TabIndex = 0;
            this.btnnull.Text = "NULL";
            this.btnnull.UseCompatibleTextRendering = true;
            this.btnnull.UseVisualStyleBackColor = true;
            this.btnnull.UseWaitCursor = true;
            this.btnnull.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 118);
            this.Controls.Add(this.btnnull);
            this.Name = "frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Navy;
            this.Load += new System.EventHandler(this.frm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnull;


    }
}

