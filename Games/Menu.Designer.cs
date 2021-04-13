
namespace Games
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cha1 = new System.Windows.Forms.Button();
            this.btn_cha2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cha1
            // 
            this.btn_cha1.Location = new System.Drawing.Point(33, 34);
            this.btn_cha1.Name = "btn_cha1";
            this.btn_cha1.Size = new System.Drawing.Size(75, 23);
            this.btn_cha1.TabIndex = 0;
            this.btn_cha1.Text = "Challenge 1";
            this.btn_cha1.UseVisualStyleBackColor = true;
            this.btn_cha1.Click += new System.EventHandler(this.btn_cha1_Click);
            // 
            // btn_cha2
            // 
            this.btn_cha2.Location = new System.Drawing.Point(149, 34);
            this.btn_cha2.Name = "btn_cha2";
            this.btn_cha2.Size = new System.Drawing.Size(75, 23);
            this.btn_cha2.TabIndex = 1;
            this.btn_cha2.Text = "Challenge 2";
            this.btn_cha2.UseVisualStyleBackColor = true;
            this.btn_cha2.Click += new System.EventHandler(this.btn_cha2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 117);
            this.Controls.Add(this.btn_cha2);
            this.Controls.Add(this.btn_cha1);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cha1;
        private System.Windows.Forms.Button btn_cha2;
    }
}

