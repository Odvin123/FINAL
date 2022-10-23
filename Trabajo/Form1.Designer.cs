namespace Trabajo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.rbLR = new System.Windows.Forms.RadioButton();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblValorActivo = new System.Windows.Forms.Label();
            this.lblValorDesecho = new System.Windows.Forms.Label();
            this.lblVidaUtil = new System.Windows.Forms.Label();
            this.txtValorActivo = new System.Windows.Forms.TextBox();
            this.txtValorDesecho = new System.Windows.Forms.TextBox();
            this.txtVidaUtil = new System.Windows.Forms.TextBox();
            this.DtDepre = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depreciación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepreciaciónAcumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtDepre)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSuma);
            this.groupBox1.Controls.Add(this.rbLR);
            this.groupBox1.Location = new System.Drawing.Point(40, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Depreciacion";
            // 
            // rbSuma
            // 
            this.rbSuma.AutoSize = true;
            this.rbSuma.Location = new System.Drawing.Point(16, 61);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(152, 19);
            this.rbSuma.TabIndex = 1;
            this.rbSuma.TabStop = true;
            this.rbSuma.Text = "Suma de Digitos de Año";
            this.rbSuma.UseVisualStyleBackColor = true;
            // 
            // rbLR
            // 
            this.rbLR.AutoSize = true;
            this.rbLR.Location = new System.Drawing.Point(12, 26);
            this.rbLR.Name = "rbLR";
            this.rbLR.Size = new System.Drawing.Size(82, 19);
            this.rbLR.TabIndex = 0;
            this.rbLR.TabStop = true;
            this.rbLR.Text = "LineaRecta";
            this.rbLR.UseVisualStyleBackColor = true;
            this.rbLR.CheckedChanged += new System.EventHandler(this.rbLR_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(103, 389);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 34);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblValorActivo
            // 
            this.lblValorActivo.AutoSize = true;
            this.lblValorActivo.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorActivo.Location = new System.Drawing.Point(40, 34);
            this.lblValorActivo.Name = "lblValorActivo";
            this.lblValorActivo.Size = new System.Drawing.Size(88, 20);
            this.lblValorActivo.TabIndex = 2;
            this.lblValorActivo.Text = "Valor Activo";
            // 
            // lblValorDesecho
            // 
            this.lblValorDesecho.AutoSize = true;
            this.lblValorDesecho.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorDesecho.Location = new System.Drawing.Point(12, 67);
            this.lblValorDesecho.Name = "lblValorDesecho";
            this.lblValorDesecho.Size = new System.Drawing.Size(121, 20);
            this.lblValorDesecho.TabIndex = 3;
            this.lblValorDesecho.Text = "Valor de Desecho:";
            // 
            // lblVidaUtil
            // 
            this.lblVidaUtil.AutoSize = true;
            this.lblVidaUtil.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVidaUtil.Location = new System.Drawing.Point(18, 99);
            this.lblVidaUtil.Name = "lblVidaUtil";
            this.lblVidaUtil.Size = new System.Drawing.Size(113, 20);
            this.lblVidaUtil.TabIndex = 4;
            this.lblVidaUtil.Text = "Vida Util(Años):";
            // 
            // txtValorActivo
            // 
            this.txtValorActivo.Location = new System.Drawing.Point(139, 33);
            this.txtValorActivo.Name = "txtValorActivo";
            this.txtValorActivo.Size = new System.Drawing.Size(100, 23);
            this.txtValorActivo.TabIndex = 5;
            this.txtValorActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorActivo_KeyPress);
            // 
            // txtValorDesecho
            // 
            this.txtValorDesecho.Location = new System.Drawing.Point(139, 67);
            this.txtValorDesecho.Name = "txtValorDesecho";
            this.txtValorDesecho.Size = new System.Drawing.Size(100, 23);
            this.txtValorDesecho.TabIndex = 6;
            this.txtValorDesecho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDesecho_KeyPress);
            // 
            // txtVidaUtil
            // 
            this.txtVidaUtil.Location = new System.Drawing.Point(139, 96);
            this.txtVidaUtil.Name = "txtVidaUtil";
            this.txtVidaUtil.Size = new System.Drawing.Size(100, 23);
            this.txtVidaUtil.TabIndex = 7;
            this.txtVidaUtil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVidaUtil_KeyPress);
            // 
            // DtDepre
            // 
            this.DtDepre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtDepre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Depreciación,
            this.DepreciaciónAcumulada,
            this.ValorNeto});
            this.DtDepre.Location = new System.Drawing.Point(374, 73);
            this.DtDepre.Name = "DtDepre";
            this.DtDepre.RowTemplate.Height = 25;
            this.DtDepre.Size = new System.Drawing.Size(437, 150);
            this.DtDepre.TabIndex = 8;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Depreciación
            // 
            this.Depreciación.HeaderText = "Depreciación";
            this.Depreciación.Name = "Depreciación";
            // 
            // DepreciaciónAcumulada
            // 
            this.DepreciaciónAcumulada.HeaderText = "DepreciaciónAcumulada";
            this.DepreciaciónAcumulada.Name = "DepreciaciónAcumulada";
            // 
            // ValorNeto
            // 
            this.ValorNeto.HeaderText = "ValorNeto";
            this.ValorNeto.Name = "ValorNeto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.DtDepre);
            this.Controls.Add(this.txtVidaUtil);
            this.Controls.Add(this.txtValorDesecho);
            this.Controls.Add(this.txtValorActivo);
            this.Controls.Add(this.lblVidaUtil);
            this.Controls.Add(this.lblValorDesecho);
            this.Controls.Add(this.lblValorActivo);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Depreciacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtDepre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbSuma;
        private RadioButton rbLR;
        private Button btnImprimir;
        private Label lblValorActivo;
        private Label lblValorDesecho;
        private Label lblVidaUtil;
        private TextBox txtValorActivo;
        private TextBox txtValorDesecho;
        private TextBox txtVidaUtil;
        private DataGridView DtDepre;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Depreciación;
        private DataGridViewTextBoxColumn DepreciaciónAcumulada;
        private DataGridViewTextBoxColumn ValorNeto;
    }
}