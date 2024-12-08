namespace TP_FINAL_PREGUNTDOS
{
    partial class FormNickname
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
            this.components = new System.ComponentModel.Container();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblElegirNickname = new System.Windows.Forms.Label();
            this.btnNickname = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNickname
            // 
            this.txtNickname.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtNickname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNickname.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.txtNickname.ForeColor = System.Drawing.Color.Indigo;
            this.txtNickname.Location = new System.Drawing.Point(44, 112);
            this.txtNickname.Multiline = true;
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(214, 45);
            this.txtNickname.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblElegirNickname
            // 
            this.lblElegirNickname.AutoSize = true;
            this.lblElegirNickname.BackColor = System.Drawing.Color.PaleGreen;
            this.lblElegirNickname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblElegirNickname.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblElegirNickname.ForeColor = System.Drawing.Color.Indigo;
            this.lblElegirNickname.Location = new System.Drawing.Point(30, 40);
            this.lblElegirNickname.Name = "lblElegirNickname";
            this.lblElegirNickname.Size = new System.Drawing.Size(361, 39);
            this.lblElegirNickname.TabIndex = 2;
            this.lblElegirNickname.Text = "¡Elije un nombre de usuario!";
            // 
            // btnNickname
            // 
            this.btnNickname.BackColor = System.Drawing.Color.Indigo;
            this.btnNickname.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnNickname.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnNickname.Location = new System.Drawing.Point(255, 112);
            this.btnNickname.Name = "btnNickname";
            this.btnNickname.Size = new System.Drawing.Size(119, 45);
            this.btnNickname.TabIndex = 3;
            this.btnNickname.Text = "Seleccionar";
            this.btnNickname.UseVisualStyleBackColor = false;
            this.btnNickname.Click += new System.EventHandler(this.btnNickname_Click);
            // 
            // FormNickname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(436, 199);
            this.Controls.Add(this.btnNickname);
            this.Controls.Add(this.lblElegirNickname);
            this.Controls.Add(this.txtNickname);
            this.Name = "FormNickname";
            this.Text = "FormNickname";
            this.Load += new System.EventHandler(this.FormNickname_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblElegirNickname;
        private System.Windows.Forms.Button btnNickname;
    }
}