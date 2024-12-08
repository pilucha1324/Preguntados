namespace TP_FINAL_PREGUNTDOS
{
    partial class FormCategorias
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
            this.btnArte = new System.Windows.Forms.Button();
            this.btnCiencia = new System.Windows.Forms.Button();
            this.btnCine = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArte
            // 
            this.btnArte.BackColor = System.Drawing.Color.Coral;
            this.btnArte.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.btnArte.ForeColor = System.Drawing.Color.DarkRed;
            this.btnArte.Location = new System.Drawing.Point(11, 153);
            this.btnArte.Name = "btnArte";
            this.btnArte.Size = new System.Drawing.Size(259, 69);
            this.btnArte.TabIndex = 0;
            this.btnArte.Text = "ARTE";
            this.btnArte.UseVisualStyleBackColor = false;
            this.btnArte.Click += new System.EventHandler(this.btnArte_Click);
            // 
            // btnCiencia
            // 
            this.btnCiencia.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCiencia.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCiencia.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCiencia.Location = new System.Drawing.Point(305, 153);
            this.btnCiencia.Name = "btnCiencia";
            this.btnCiencia.Size = new System.Drawing.Size(259, 69);
            this.btnCiencia.TabIndex = 1;
            this.btnCiencia.Text = "CIENCIA";
            this.btnCiencia.UseVisualStyleBackColor = false;
            this.btnCiencia.Click += new System.EventHandler(this.btnCiencia_Click);
            // 
            // btnCine
            // 
            this.btnCine.BackColor = System.Drawing.Color.LightPink;
            this.btnCine.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCine.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.btnCine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnCine.Location = new System.Drawing.Point(602, 153);
            this.btnCine.Name = "btnCine";
            this.btnCine.Size = new System.Drawing.Size(259, 69);
            this.btnCine.TabIndex = 2;
            this.btnCine.Text = "CINE";
            this.btnCine.UseVisualStyleBackColor = false;
            this.btnCine.Click += new System.EventHandler(this.btnCine_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.LightGray;
            this.btnRandom.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.btnRandom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRandom.Location = new System.Drawing.Point(145, 289);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(557, 84);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "RANDOM";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(731, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 43);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.BackColor = System.Drawing.Color.Indigo;
            this.btnVolverInicio.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnVolverInicio.Location = new System.Drawing.Point(12, 12);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(78, 43);
            this.btnVolverInicio.TabIndex = 5;
            this.btnVolverInicio.Text = "Volver al Inicio";
            this.btnVolverInicio.UseVisualStyleBackColor = false;
            this.btnVolverInicio.Click += new System.EventHandler(this.btnProvisorio_Click);
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnCine);
            this.Controls.Add(this.btnCiencia);
            this.Controls.Add(this.btnArte);
            this.Name = "FormCategorias";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArte;
        private System.Windows.Forms.Button btnCiencia;
        private System.Windows.Forms.Button btnCine;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnVolverInicio;
    }
}

