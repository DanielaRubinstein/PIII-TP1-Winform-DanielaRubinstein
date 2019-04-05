namespace PIII_TP1_Winform_Rubinstein
{
    partial class frmHome
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
            this.btnPersonas = new System.Windows.Forms.Button();
            this.btnObjetos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonas
            // 
            this.btnPersonas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPersonas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonas.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonas.Location = new System.Drawing.Point(254, 221);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(412, 317);
            this.btnPersonas.TabIndex = 0;
            this.btnPersonas.Text = "LISTADO DE PERSONAS";
            this.btnPersonas.UseVisualStyleBackColor = false;
            this.btnPersonas.Click += new System.EventHandler(this.BtnPersonas_Click);
            // 
            // btnObjetos
            // 
            this.btnObjetos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObjetos.AutoSize = true;
            this.btnObjetos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnObjetos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObjetos.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObjetos.Location = new System.Drawing.Point(809, 221);
            this.btnObjetos.Name = "btnObjetos";
            this.btnObjetos.Size = new System.Drawing.Size(412, 317);
            this.btnObjetos.TabIndex = 1;
            this.btnObjetos.Text = "LISTADO DE OBJETOS";
            this.btnObjetos.UseVisualStyleBackColor = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 779);
            this.Controls.Add(this.btnObjetos);
            this.Controls.Add(this.btnPersonas);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1500, 850);
            this.Name = "frmHome";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonas;
        private System.Windows.Forms.Button btnObjetos;
    }
}

