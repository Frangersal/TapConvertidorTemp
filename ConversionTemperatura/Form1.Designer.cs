namespace ConversionTemperatura
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btAceptar = new System.Windows.Forms.Button();
            this.etGradosC = new System.Windows.Forms.Label();
            this.etGradosF = new System.Windows.Forms.Label();
            this.ctGradosF = new System.Windows.Forms.TextBox();
            this.ctGradosC = new System.Windows.Forms.TextBox();
            this.etConversionTemp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProveedorDeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorDeError)).BeginInit();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.DarkBlue;
            this.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.ForeColor = System.Drawing.Color.White;
            this.btAceptar.Location = new System.Drawing.Point(165, 170);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(207, 28);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "Convertir";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // etGradosC
            // 
            this.etGradosC.AutoSize = true;
            this.etGradosC.BackColor = System.Drawing.Color.AliceBlue;
            this.etGradosC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etGradosC.ForeColor = System.Drawing.Color.DarkBlue;
            this.etGradosC.Location = new System.Drawing.Point(7, 91);
            this.etGradosC.Name = "etGradosC";
            this.etGradosC.Size = new System.Drawing.Size(152, 20);
            this.etGradosC.TabIndex = 3;
            this.etGradosC.Text = "Grados Centígrados";
            // 
            // etGradosF
            // 
            this.etGradosF.AutoSize = true;
            this.etGradosF.BackColor = System.Drawing.Color.AliceBlue;
            this.etGradosF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etGradosF.ForeColor = System.Drawing.Color.DarkBlue;
            this.etGradosF.Location = new System.Drawing.Point(7, 132);
            this.etGradosF.Name = "etGradosF";
            this.etGradosF.Size = new System.Drawing.Size(143, 20);
            this.etGradosF.TabIndex = 4;
            this.etGradosF.Text = "Grados Fahrenheit";
            // 
            // ctGradosF
            // 
            this.ctGradosF.Location = new System.Drawing.Point(165, 134);
            this.ctGradosF.Name = "ctGradosF";
            this.ctGradosF.Size = new System.Drawing.Size(207, 20);
            this.ctGradosF.TabIndex = 1;
            this.ctGradosF.Text = "32.00";
            this.ctGradosF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctGradosF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctGradosF_KeyPress);
            // 
            // ctGradosC
            // 
            this.ctGradosC.Location = new System.Drawing.Point(165, 91);
            this.ctGradosC.Name = "ctGradosC";
            this.ctGradosC.Size = new System.Drawing.Size(207, 20);
            this.ctGradosC.TabIndex = 0;
            this.ctGradosC.Text = "0.00";
            this.ctGradosC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctGradosC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctGradosC_KeyPress);
            // 
            // etConversionTemp
            // 
            this.etConversionTemp.BackColor = System.Drawing.Color.DarkBlue;
            this.etConversionTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etConversionTemp.ForeColor = System.Drawing.Color.White;
            this.etConversionTemp.Location = new System.Drawing.Point(58, 0);
            this.etConversionTemp.Name = "etConversionTemp";
            this.etConversionTemp.Size = new System.Drawing.Size(330, 60);
            this.etConversionTemp.TabIndex = 5;
            this.etConversionTemp.Text = "Conversión de temperatura";
            this.etConversionTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.etConversionTemp.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Aplicacion #1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 60);
            this.label2.TabIndex = 8;
            this.label2.Text = "ITA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProveedorDeError
            // 
            this.ProveedorDeError.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(384, 241);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.etConversionTemp);
            this.Controls.Add(this.ctGradosC);
            this.Controls.Add(this.ctGradosF);
            this.Controls.Add(this.etGradosF);
            this.Controls.Add(this.etGradosC);
            this.Controls.Add(this.btAceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Conversión de temperatura";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorDeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label etGradosC;
        private System.Windows.Forms.Label etGradosF;
        private System.Windows.Forms.TextBox ctGradosF;
        private System.Windows.Forms.TextBox ctGradosC;
        private System.Windows.Forms.Label etConversionTemp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider ProveedorDeError;
    }
}

