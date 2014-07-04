namespace QUIZ1_IGNACIO
{
    partial class frm2
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnminus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(126, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(12, 12);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(156, 20);
            this.txtnum.TabIndex = 1;
            this.txtnum.Click += new System.EventHandler(this.txtnum_Click);
            this.txtnum.TextChanged += new System.EventHandler(this.txtnum_TextChanged);
            this.txtnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum_KeyPress);
            this.txtnum.MouseLeave += new System.EventHandler(this.txtnum_MouseLeave);
            this.txtnum.Validated += new System.EventHandler(this.txtnum_Validated);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(12, 74);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(13, 13);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "0";
            this.lbResult.Visible = false;
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(78, 38);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(42, 23);
            this.btnminus.TabIndex = 3;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 66);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtnum;
        public System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnminus;
    }
}