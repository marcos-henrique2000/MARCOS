using Marcos.entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Marcos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            string path = "";
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            fdb.Description = "Procurar pasta para BD";
            fdb.ShowNewFolderButton = true;

            if(fdb.ShowDialog() == DialogResult.OK)
            {
                path = fdb.SelectedPath;
            }
            else
            {
                MessageBox.Show("Por Favor selecionar a pasta que tem ou/e ficara o BD");
                System.Environment.Exit(0);
            }


            //if (path == null) return;

            Conexao.CriarBancoSQLite(path + "\\acme.sqlite");
            

            DateTime now = DateTime.Now;
            InitializeComponent();

            dtData.Value = DateTime.Now;

            PreencherDataGrid();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            txtCusto.Enabled = true;
            txtDistancia.Enabled = true;
            txtNivelDor.Enabled = true;
            rbNao.Enabled = true;
            rbSim.Enabled = true;
            dtData.Enabled = true;

            txtCusto.Clear();
            txtDistancia.Clear();
            txtNivelDor.Clear();
            rbNao.Checked = false;
            rbSim.Checked = false;
            dtData.Value = DateTime.Now;

            dgvLista.ClearSelection();
        }

        private void PreencherDataGrid()
        {
            List<RegFoguete> list = Conexao.getFogetes();
            List<RegFoguete> listNova = new List<RegFoguete>();

            if (list == null) return;

            foreach (var item in list)
            {
                listNova.Add(new RegFoguete(item.DataVoo, item.Captura, item.NivelDor));
            }

            dgvLista.DataSource = list;

            dgvLista.Columns[0].Visible = false;
            dgvLista.Columns[2].Visible = false;
            dgvLista.Columns[3].Visible = false;

            dgvLista.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(dgvLista.SelectedRows.Count != 0)
            {
                Atualizar();
            }
            else
            {
                Salvar();
            }

            dgvLista.DataSource = "";
            PreencherDataGrid();
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
        }

        public void Salvar()
        {
            DateTimePicker dtDataPicker = dtData;

            dtDataPicker.Format = DateTimePickerFormat.Custom;
            dtDataPicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            string data = dtDataPicker.Text;
            string custo = string.Format("{0:C}", txtCusto.Text);
            string distancia = txtDistancia.Text;
            string opt = "S";
            if (rbSim.Checked != true) opt = "N";
            string nivelDor = txtNivelDor.Text;

            RegFoguete reg = new RegFoguete(data, custo, distancia, opt, nivelDor);
            Conexao.Add(reg);

            dgvLista.DataSource = "";
            PreencherDataGrid();

            txtCusto.Clear();
            txtDistancia.Clear();
            txtNivelDor.Clear();
            rbNao.Checked = false;
            rbSim.Checked = false;
            dtData.Value = DateTime.Now;

            MessageBox.Show("Processo inserido com sucesso!", "Registro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Atualizar()
        {
            DateTimePicker dtDataPicker = dtData;
            string captura;

            dtDataPicker.Format = DateTimePickerFormat.Custom;
            dtDataPicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            string data = dtDataPicker.Text;

            if (rbNao.Checked == true)
            {
                captura = "N";
            }
            else
            {
                captura = "S";
            }

            RegFoguete reg = new RegFoguete(
                int.Parse(dgvLista.CurrentRow.Cells[0].Value.ToString()),
                data,
                txtCusto.Text,
                txtDistancia.Text,captura,
                txtNivelDor.Text
                );
            Conexao.Update(reg);
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtData.Value = DateTime.Parse(dgvLista.CurrentRow.Cells[1].Value.ToString());
            txtCusto.Text = string.Format("{0:C}", dgvLista.CurrentRow.Cells[2].Value.ToString());
            txtDistancia.Text = dgvLista.CurrentRow.Cells[3].Value.ToString();
            txtNivelDor.Text = dgvLista.CurrentRow.Cells[5].Value.ToString();

            if(dgvLista.CurrentRow.Cells[4].Value.ToString() == "N")
            {rbNao.Checked = true;} else{ rbSim.Checked = true; }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id;

            id = int.Parse(dgvLista.CurrentRow.Cells[0].Value.ToString());

            Conexao.Delete(id);

            dgvLista.DataSource = "";
            PreencherDataGrid();
        }

        private void dtData_ValueChanged(object sender, EventArgs e)
        {
            var ed = sender.ToString();
            if (sender.ToString().Contains(DateTime.Now.ToString()))
            {
                Console.WriteLine();
                return;
            }
            if (sender.ToString().Contains(dgvLista.CurrentRow.Cells[1].Value.ToString()))
            {
                Console.WriteLine();
                return;
            }

            Console.WriteLine();
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void txtCusto_TextChanged(object sender, EventArgs e)
        {
            if (dgvLista.DataSource == null)
            {
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                return;
            }

            if(dgvLista.CurrentRow == null)
            {
                return;
            }

            string dadoCel = dgvLista.CurrentRow.Cells[2].Value.ToString();
            string Sender = sender.ToString().Split(':')[1].Replace(" ", "");
            if (dadoCel == Sender)
            {
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                return;
            }

            Console.WriteLine();
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            if (dgvLista.DataSource == null)
            {
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                return;
            }

            string dadoCel = dgvLista.CurrentRow.Cells[3].Value.ToString();
            string Sender = sender.ToString().Split(':')[1].Replace(" ", "");
            if (dadoCel == Sender)
            {
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                return;
            }

            Console.WriteLine();
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void txtNivelDor_TextChanged(object sender, EventArgs e)
        {
            if (dgvLista.DataSource == null)
            {
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                return;
            }

            string dadoCel = dgvLista.CurrentRow.Cells[5].Value.ToString();
            string Sender = sender.ToString().Split(':')[1].Replace(" ", "");
            if (dadoCel == Sender)
            {
                Console.WriteLine();
                return;
            }

            Console.WriteLine();
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void rbNao_Click(object sender, EventArgs e)
        {
            if (dgvLista.DataSource == null)
            {
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                return;
            }

            if (dgvLista.CurrentRow.Cells[4].Value.ToString() == "N")
            {
                Console.WriteLine();
                return;
            }

            Console.WriteLine();
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void rbSim_Click(object sender, EventArgs e)
        {
            if (dgvLista.DataSource == null)
            {
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                return;
            }

            if (dgvLista.CurrentRow.Cells[4].Value.ToString() == "S")
            {
                Console.WriteLine();
                return;
            }

            Console.WriteLine();
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void txtNivelDor_Leave(object sender, EventArgs e)
        {
            if( double.Parse(txtNivelDor.Text) > 10)
            {
                MessageBox.Show("Valor Maximo Permitido é 10", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNivelDor.Text = "";
            }
        }
    }
}
