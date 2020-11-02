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
            this.lvLista = new System.Windows.Forms.ListView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gbInformacoes = new System.Windows.Forms.GroupBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.lblCusto = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblCaptura = new System.Windows.Forms.Label();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.lblNivelDor = new System.Windows.Forms.Label();
            this.txtNivelDor = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvLista
            // 
            this.lvLista.HideSelection = false;
            this.lvLista.Location = new System.Drawing.Point(12, 12);
            this.lvLista.Name = "lvLista";
            this.lvLista.Size = new System.Drawing.Size(438, 356);
            this.lvLista.TabIndex = 0;
            this.lvLista.UseCompatibleStateImageBehavior = false;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(456, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(537, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // gbInformacoes
            // 
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
            this.gbInformacoes.Controls.Add(this.txtData);
            this.gbInformacoes.Controls.Add(this.lblData);
            this.gbInformacoes.Location = new System.Drawing.Point(456, 42);
            this.gbInformacoes.Name = "gbInformacoes";
            this.gbInformacoes.Size = new System.Drawing.Size(332, 326);
            this.gbInformacoes.TabIndex = 3;
            this.gbInformacoes.TabStop = false;
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
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtData.Location = new System.Drawing.Point(81, 23);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(245, 26);
            this.txtData.TabIndex = 1;
            // 
            // txtCusto
            // 
            this.txtCusto.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtCusto.Location = new System.Drawing.Point(81, 63);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(245, 26);
            this.txtCusto.TabIndex = 3;
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
            // txtDistancia
            // 
            this.txtDistancia.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtDistancia.Location = new System.Drawing.Point(81, 105);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(245, 26);
            this.txtDistancia.TabIndex = 5;
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
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.rbNao.Location = new System.Drawing.Point(101, 151);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(51, 24);
            this.rbNao.TabIndex = 7;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.rbSim.Location = new System.Drawing.Point(208, 151);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(50, 24);
            this.rbSim.TabIndex = 8;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
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
            // txtNivelDor
            // 
            this.txtNivelDor.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtNivelDor.Location = new System.Drawing.Point(81, 192);
            this.txtNivelDor.Name = "txtNivelDor";
            this.txtNivelDor.Size = new System.Drawing.Size(245, 26);
            this.txtNivelDor.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(251, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(170, 289);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.gbInformacoes);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.lvLista);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.Text = "ACME FLIGHT MANAGER";
            this.gbInformacoes.ResumeLayout(false);
            this.gbInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvLista;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gbInformacoes;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNivelDor;
        private System.Windows.Forms.Label lblNivelDor;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.Label lblCaptura;
    }
}

