
namespace ConsecionarioMoto
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
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbValorFabricación = new System.Windows.Forms.TextBox();
            this.numUDModelo = new System.Windows.Forms.NumericUpDown();
            this.numUDAño = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTasa = new System.Windows.Forms.TextBox();
            this.tbVidaUtil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUDModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAño)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(175, 25);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(120, 20);
            this.tbMarca.TabIndex = 0;
            // 
            // tbValorFabricación
            // 
            this.tbValorFabricación.Location = new System.Drawing.Point(175, 137);
            this.tbValorFabricación.Name = "tbValorFabricación";
            this.tbValorFabricación.Size = new System.Drawing.Size(120, 20);
            this.tbValorFabricación.TabIndex = 1;
            // 
            // numUDModelo
            // 
            this.numUDModelo.Location = new System.Drawing.Point(175, 65);
            this.numUDModelo.Name = "numUDModelo";
            this.numUDModelo.Size = new System.Drawing.Size(120, 20);
            this.numUDModelo.TabIndex = 2;
            // 
            // numUDAño
            // 
            this.numUDAño.Location = new System.Drawing.Point(175, 101);
            this.numUDAño.Name = "numUDAño";
            this.numUDAño.Size = new System.Drawing.Size(120, 20);
            this.numUDAño.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modelo (Año)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año a calcular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor de fabricación";
            // 
            // tbTasa
            // 
            this.tbTasa.Location = new System.Drawing.Point(175, 179);
            this.tbTasa.Name = "tbTasa";
            this.tbTasa.Size = new System.Drawing.Size(120, 20);
            this.tbTasa.TabIndex = 8;
            // 
            // tbVidaUtil
            // 
            this.tbVidaUtil.Location = new System.Drawing.Point(175, 223);
            this.tbVidaUtil.Name = "tbVidaUtil";
            this.tbVidaUtil.Size = new System.Drawing.Size(120, 20);
            this.tbVidaUtil.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tasa de deprecicación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vida útil (Año)";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(26, 274);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(135, 38);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(175, 274);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 38);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 343);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbVidaUtil);
            this.Controls.Add(this.tbTasa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUDAño);
            this.Controls.Add(this.numUDModelo);
            this.Controls.Add(this.tbValorFabricación);
            this.Controls.Add(this.tbMarca);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUDModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbValorFabricación;
        private System.Windows.Forms.NumericUpDown numUDModelo;
        private System.Windows.Forms.NumericUpDown numUDAño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTasa;
        private System.Windows.Forms.TextBox tbVidaUtil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnCerrar;
    }
}

