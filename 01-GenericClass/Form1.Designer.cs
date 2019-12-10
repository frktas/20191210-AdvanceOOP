namespace _01_GenericClass
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
            this.btnStringData = new System.Windows.Forms.Button();
            this.btnDecimalData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStringData
            // 
            this.btnStringData.Location = new System.Drawing.Point(299, 89);
            this.btnStringData.Name = "btnStringData";
            this.btnStringData.Size = new System.Drawing.Size(179, 81);
            this.btnStringData.TabIndex = 0;
            this.btnStringData.Text = "String Data Al";
            this.btnStringData.UseVisualStyleBackColor = true;
            this.btnStringData.Click += new System.EventHandler(this.btnStringData_Click);
            // 
            // btnDecimalData
            // 
            this.btnDecimalData.Location = new System.Drawing.Point(299, 213);
            this.btnDecimalData.Name = "btnDecimalData";
            this.btnDecimalData.Size = new System.Drawing.Size(179, 81);
            this.btnDecimalData.TabIndex = 1;
            this.btnDecimalData.Text = "Decimal Data Al";
            this.btnDecimalData.UseVisualStyleBackColor = true;
            this.btnDecimalData.Click += new System.EventHandler(this.btnDecimalData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDecimalData);
            this.Controls.Add(this.btnStringData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStringData;
        private System.Windows.Forms.Button btnDecimalData;
    }
}

