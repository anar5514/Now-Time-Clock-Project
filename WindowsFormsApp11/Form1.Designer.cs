namespace WindowsFormsApp11
{
    partial class Form1
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
            this.timerlabel = new System.Windows.Forms.Label();
            this.btnbaku = new System.Windows.Forms.Button();
            this.btnlondon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerlabel
            // 
            this.timerlabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.timerlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerlabel.Location = new System.Drawing.Point(158, 33);
            this.timerlabel.Name = "timerlabel";
            this.timerlabel.Size = new System.Drawing.Size(510, 97);
            this.timerlabel.TabIndex = 0;
            this.timerlabel.Text = "TImer";
            this.timerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnbaku
            // 
            this.btnbaku.AutoEllipsis = true;
            this.btnbaku.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnbaku.Location = new System.Drawing.Point(158, 133);
            this.btnbaku.Name = "btnbaku";
            this.btnbaku.Size = new System.Drawing.Size(255, 45);
            this.btnbaku.TabIndex = 1;
            this.btnbaku.TabStop = false;
            this.btnbaku.Text = "Baku";
            this.btnbaku.UseVisualStyleBackColor = true;
            this.btnbaku.Click += new System.EventHandler(this.btnbaku_Click);
            // 
            // btnlondon
            // 
            this.btnlondon.Location = new System.Drawing.Point(417, 133);
            this.btnlondon.Name = "btnlondon";
            this.btnlondon.Size = new System.Drawing.Size(255, 45);
            this.btnlondon.TabIndex = 2;
            this.btnlondon.TabStop = false;
            this.btnlondon.Text = "London";
            this.btnlondon.UseVisualStyleBackColor = true;
            this.btnlondon.Click += new System.EventHandler(this.btnlondon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlondon);
            this.Controls.Add(this.btnbaku);
            this.Controls.Add(this.timerlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timerlabel;
        private System.Windows.Forms.Button btnbaku;
        private System.Windows.Forms.Button btnlondon;
    }
}

