namespace La_Bomba
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
            this.Btn_Derecho = new System.Windows.Forms.Button();
            this.Btn_Centro = new System.Windows.Forms.Button();
            this.Btn_Izquierdo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Derecho
            // 
            this.Btn_Derecho.Location = new System.Drawing.Point(51, 196);
            this.Btn_Derecho.Name = "Btn_Derecho";
            this.Btn_Derecho.Size = new System.Drawing.Size(100, 50);
            this.Btn_Derecho.TabIndex = 0;
            this.Btn_Derecho.Text = "DERECHO";
            this.Btn_Derecho.UseVisualStyleBackColor = true;
            // 
            // Btn_Centro
            // 
            this.Btn_Centro.Location = new System.Drawing.Point(256, 195);
            this.Btn_Centro.Name = "Btn_Centro";
            this.Btn_Centro.Size = new System.Drawing.Size(100, 50);
            this.Btn_Centro.TabIndex = 1;
            this.Btn_Centro.Text = "CENTRO";
            this.Btn_Centro.UseVisualStyleBackColor = true;
            // 
            // Btn_Izquierdo
            // 
            this.Btn_Izquierdo.Location = new System.Drawing.Point(448, 195);
            this.Btn_Izquierdo.Name = "Btn_Izquierdo";
            this.Btn_Izquierdo.Size = new System.Drawing.Size(100, 50);
            this.Btn_Izquierdo.TabIndex = 2;
            this.Btn_Izquierdo.Text = "IZQUIERDO";
            this.Btn_Izquierdo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.Btn_Izquierdo);
            this.Controls.Add(this.Btn_Centro);
            this.Controls.Add(this.Btn_Derecho);
            this.Name = "Form1";
            this.Text = "Bomba!!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Derecho;
        private System.Windows.Forms.Button Btn_Centro;
        private System.Windows.Forms.Button Btn_Izquierdo;
    }
}

