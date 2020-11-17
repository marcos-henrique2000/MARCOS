namespace Marcos
{
    partial class frmPrincipal
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
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gbInformacoes = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNivelDor = new System.Windows.Forms.TextBox();
            this.lblNivelDor = new System.Windows.Forms.Label();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.lblCaptura = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.lblCusto = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.gbInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(456, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(537, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // gbInformacoes
            // 
            this.gbInformacoes.Controls.Add(this.dtData);
            this.gbInformacoes.Controls.Add(this.btnCancelar);
            this.gbInformacoes.Controls.Add(this.btnSalvar);
            this.gbInformacoes.Controls.Add(this.txtNivelDor);
            this.gbInformacoes.Controls.Add(this.lblNivelDor);
            this.gbInformacoes.Controls.Add(this.rbSim);
            this.gbInformacoes.Controls.Add(this.rbNao);
            this.gbInformacoes.Controls.Add(this.lblCaptura);
            this.gbInformacoes.Controls.Add(this.txtDistancia);
            this.gbInformacoes.Controls.Add(this.lblDistancia);
            this.gbInformacoes.Controls.Add(this.txtCusto);
            this.gbInformacoes.Controls.Add(this.lblCusto);
            this.gbInformacoes.Controls.Add(this.lblData);
            this.gbInformacoes.Location = new System.Drawing.Point(456, 42);
            this.gbInformacoes.Name = "gbInformacoes";
            this.gbInformacoes.Size = new System.Drawing.Size(332, 326);
            this.gbInformacoes.TabIndex = 3;
            this.gbInformacoes.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(251, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(170, 289);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNivelDor
            // 
            this.txtNivelDor.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtNivelDor.Location = new System.Drawing.Point(81, 192);
            this.txtNivelDor.MaxLength = 2;
            this.txtNivelDor.Name = "txtNivelDor";
            this.txtNivelDor.Size = new System.Drawing.Size(245, 26);
            this.txtNivelDor.TabIndex = 10;
            this.txtNivelDor.TextChanged += new System.EventHandler(this.txtNivelDor_TextChanged);
            this.txtNivelDor.Leave += new System.EventHandler(this.txtNivelDor_Leave);
            // 
            // lblNivelDor
            // 
            this.lblNivelDor.AutoSize = true;
            this.lblNivelDor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelDor.Location = new System.Drawing.Point(7, 195);
            this.lblNivelDor.Name = "lblNivelDor";
            this.lblNivelDor.Size = new System.Drawing.Size(63, 20);
            this.lblNivelDor.TabIndex = 9;
            this.lblNivelDor.Text = "Nivel dor";
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.rbSim.Location = new System.Drawing.Point(208, 151);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(50, 24);
            this.rbSim.TabIndex = 8;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            this.rbSim.Click += new System.EventHandler(this.rbSim_Click);
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.rbNao.Location = new System.Drawing.Point(101, 151);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(51, 24);
            this.rbNao.TabIndex = 7;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            this.rbNao.Click += new System.EventHandler(this.rbNao_Click);
            // 
            // lblCaptura
            // 
            this.lblCaptura.AutoSize = true;
            this.lblCaptura.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptura.Location = new System.Drawing.Point(7, 153);
            this.lblCaptura.Name = "lblCaptura";
            this.lblCaptura.Size = new System.Drawing.Size(54, 20);
            this.lblCaptura.TabIndex = 6;
            this.lblCaptura.Text = "Captura";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtDistancia.Location = new System.Drawing.Point(81, 105);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(245, 26);
            this.txtDistancia.TabIndex = 5;
            this.txtDistancia.TextChanged += new System.EventHandler(this.txtDistancia_TextChanged);
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(7, 109);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(62, 20);
            this.lblDistancia.TabIndex = 4;
            this.lblDistancia.Text = "Distância";
            // 
            // txtCusto
            // 
            this.txtCusto.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtCusto.Location = new System.Drawing.Point(81, 63);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(245, 26);
            this.txtCusto.TabIndex = 3;
            this.txtCusto.TextChanged += new System.EventHandler(this.txtCusto_TextChanged);
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto.Location = new System.Drawing.Point(7, 67);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(43, 20);
            this.lblCusto.TabIndex = 2;
            this.lblCusto.Text = "Custo";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(6, 25);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 20);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(12, 12);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(438, 356);
            this.dgvLista.TabIndex = 4;
            this.dgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellClick);
            // 
            // dtData
            // 
            this.dtData.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtData.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtData.Location = new System.Drawing.Point(81, 19);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(245, 26);
            this.dtData.TabIndex = 11;
            this.dtData.Value = new System.DateTime(2020, 11, 11, 0, 0, 0, 0);
            this.dtData.ValueChanged += new System.EventHandler(this.dtData_ValueChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.gbInformacoes);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.Text = "ACME FLIGHT MANAGER";
            this.gbInformacoes.ResumeLayout(false);
            this.gbInformacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gbInformacoes;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNivelDor;
        private System.Windows.Forms.Label lblNivelDor;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.Label lblCaptura;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DateTimePicker dtData;
    }
}

