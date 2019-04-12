namespace Etec.ProjetoVVVendas.UI.UI
{
    partial class RelatorioUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnConsultaEntrada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAttEntr = new System.Windows.Forms.Button();
            this.dgvEntrada = new System.Windows.Forms.DataGridView();
            this.btnConsultaVenda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAttSai = new System.Windows.Forms.Button();
            this.dgvSaida = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtt = new System.Windows.Forms.Button();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.mkdidEstoque = new System.Windows.Forms.MaskedTextBox();
            this.mkdEntrada = new System.Windows.Forms.MaskedTextBox();
            this.mkdVenda = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaida)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(20, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(745, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mkdEntrada);
            this.tabPage2.Controls.Add(this.btnConsultaEntrada);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnAttEntr);
            this.tabPage2.Controls.Add(this.dgvEntrada);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(737, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Entradas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.mkdVenda);
            this.tabPage3.Controls.Add(this.btnConsultaVenda);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btnAttSai);
            this.tabPage3.Controls.Add(this.dgvSaida);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(737, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vendas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnConsultaEntrada
            // 
            this.btnConsultaEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(129)))), ((int)(((byte)(207)))));
            this.btnConsultaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaEntrada.ForeColor = System.Drawing.Color.White;
            this.btnConsultaEntrada.Location = new System.Drawing.Point(174, 8);
            this.btnConsultaEntrada.Name = "btnConsultaEntrada";
            this.btnConsultaEntrada.Size = new System.Drawing.Size(40, 28);
            this.btnConsultaEntrada.TabIndex = 36;
            this.btnConsultaEntrada.Text = "Ir";
            this.btnConsultaEntrada.UseVisualStyleBackColor = false;
            this.btnConsultaEntrada.Click += new System.EventHandler(this.btnConsultaEntrada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID para busca:";
            // 
            // btnAttEntr
            // 
            this.btnAttEntr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(129)))), ((int)(((byte)(207)))));
            this.btnAttEntr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttEntr.ForeColor = System.Drawing.Color.White;
            this.btnAttEntr.Location = new System.Drawing.Point(612, 55);
            this.btnAttEntr.Name = "btnAttEntr";
            this.btnAttEntr.Size = new System.Drawing.Size(113, 38);
            this.btnAttEntr.TabIndex = 33;
            this.btnAttEntr.Text = "Atualizar";
            this.btnAttEntr.UseVisualStyleBackColor = false;
            this.btnAttEntr.Click += new System.EventHandler(this.btnAttEntr_Click);
            // 
            // dgvEntrada
            // 
            this.dgvEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrada.Location = new System.Drawing.Point(12, 55);
            this.dgvEntrada.Name = "dgvEntrada";
            this.dgvEntrada.Size = new System.Drawing.Size(585, 344);
            this.dgvEntrada.TabIndex = 32;
            // 
            // btnConsultaVenda
            // 
            this.btnConsultaVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(129)))), ((int)(((byte)(207)))));
            this.btnConsultaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaVenda.ForeColor = System.Drawing.Color.White;
            this.btnConsultaVenda.Location = new System.Drawing.Point(174, 8);
            this.btnConsultaVenda.Name = "btnConsultaVenda";
            this.btnConsultaVenda.Size = new System.Drawing.Size(40, 28);
            this.btnConsultaVenda.TabIndex = 36;
            this.btnConsultaVenda.Text = "Ir";
            this.btnConsultaVenda.UseVisualStyleBackColor = false;
            this.btnConsultaVenda.Click += new System.EventHandler(this.btnConsultaVenda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "ID para busca:";
            // 
            // btnAttSai
            // 
            this.btnAttSai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(129)))), ((int)(((byte)(207)))));
            this.btnAttSai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttSai.ForeColor = System.Drawing.Color.White;
            this.btnAttSai.Location = new System.Drawing.Point(612, 55);
            this.btnAttSai.Name = "btnAttSai";
            this.btnAttSai.Size = new System.Drawing.Size(113, 38);
            this.btnAttSai.TabIndex = 33;
            this.btnAttSai.Text = "Atualizar";
            this.btnAttSai.UseVisualStyleBackColor = false;
            this.btnAttSai.Click += new System.EventHandler(this.btnAttSai_Click);
            // 
            // dgvSaida
            // 
            this.dgvSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaida.Location = new System.Drawing.Point(12, 55);
            this.dgvSaida.Name = "dgvSaida";
            this.dgvSaida.Size = new System.Drawing.Size(585, 344);
            this.dgvSaida.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mkdidEstoque);
            this.tabPage1.Controls.Add(this.btnConsulta);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnAtt);
            this.tabPage1.Controls.Add(this.dgvEstoque);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(737, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Estoque";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(129)))), ((int)(((byte)(207)))));
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(174, 8);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(40, 28);
            this.btnConsulta.TabIndex = 36;
            this.btnConsulta.Text = "Ir";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID para busca:";
            // 
            // btnAtt
            // 
            this.btnAtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(129)))), ((int)(((byte)(207)))));
            this.btnAtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtt.ForeColor = System.Drawing.Color.White;
            this.btnAtt.Location = new System.Drawing.Point(612, 55);
            this.btnAtt.Name = "btnAtt";
            this.btnAtt.Size = new System.Drawing.Size(113, 38);
            this.btnAtt.TabIndex = 33;
            this.btnAtt.Text = "Atualizar";
            this.btnAtt.UseVisualStyleBackColor = false;
            this.btnAtt.Click += new System.EventHandler(this.btnAtt_Click);
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(12, 55);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.Size = new System.Drawing.Size(585, 344);
            this.dgvEstoque.TabIndex = 32;
            // 
            // mkdidEstoque
            // 
            this.mkdidEstoque.Location = new System.Drawing.Point(129, 8);
            this.mkdidEstoque.Mask = "999";
            this.mkdidEstoque.Name = "mkdidEstoque";
            this.mkdidEstoque.Size = new System.Drawing.Size(36, 27);
            this.mkdidEstoque.TabIndex = 37;
            // 
            // mkdEntrada
            // 
            this.mkdEntrada.Location = new System.Drawing.Point(129, 8);
            this.mkdEntrada.Mask = "999";
            this.mkdEntrada.Name = "mkdEntrada";
            this.mkdEntrada.Size = new System.Drawing.Size(36, 27);
            this.mkdEntrada.TabIndex = 38;
            // 
            // mkdVenda
            // 
            this.mkdVenda.Location = new System.Drawing.Point(129, 8);
            this.mkdVenda.Mask = "999";
            this.mkdVenda.Name = "mkdVenda";
            this.mkdVenda.Size = new System.Drawing.Size(36, 27);
            this.mkdVenda.TabIndex = 38;
            // 
            // RelatorioUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Roboto", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RelatorioUI";
            this.Size = new System.Drawing.Size(781, 478);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaida)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MaskedTextBox mkdidEstoque;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtt;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.MaskedTextBox mkdEntrada;
        private System.Windows.Forms.Button btnConsultaEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAttEntr;
        private System.Windows.Forms.DataGridView dgvEntrada;
        private System.Windows.Forms.MaskedTextBox mkdVenda;
        private System.Windows.Forms.Button btnConsultaVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAttSai;
        private System.Windows.Forms.DataGridView dgvSaida;
    }
}
