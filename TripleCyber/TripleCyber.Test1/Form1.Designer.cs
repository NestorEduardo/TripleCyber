namespace TripleCyber.Test1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRandomValues = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCoincidences = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRandomValues
            // 
            this.btnRandomValues.Location = new System.Drawing.Point(12, 24);
            this.btnRandomValues.Name = "btnRandomValues";
            this.btnRandomValues.Size = new System.Drawing.Size(124, 40);
            this.btnRandomValues.TabIndex = 0;
            this.btnRandomValues.Text = "Valores Aleatorios";
            this.btnRandomValues.UseVisualStyleBackColor = true;
            this.btnRandomValues.Click += new System.EventHandler(this.btnRandomValues_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Números primos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Emulador de Cajero automático";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCoincidences
            // 
            this.btnCoincidences.Location = new System.Drawing.Point(515, 24);
            this.btnCoincidences.Name = "btnCoincidences";
            this.btnCoincidences.Size = new System.Drawing.Size(124, 40);
            this.btnCoincidences.TabIndex = 3;
            this.btnCoincidences.Text = "Coincidencias";
            this.btnCoincidences.UseVisualStyleBackColor = true;
            this.btnCoincidences.Click += new System.EventHandler(this.btnCoincidences_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 200);
            this.Controls.Add(this.btnCoincidences);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRandomValues);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRandomValues;
        private Button button2;
        private Button button3;
        private Button btnCoincidences;
    }
}