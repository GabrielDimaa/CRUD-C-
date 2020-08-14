using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Cervantes
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conexao = new NpgsqlConnection();
        string exeConexao;
        private DataTable table;
        int validation = -1;

        public Form1()
        {
            InitializeComponent();
            exeConexao = "Server = 127.0.0.1; Port = 5432; Database = teste-cervantes;";
            exeConexao += "User Id = postgres;";
            exeConexao += "; Password = postgresql123";
            conexao.ConnectionString = exeConexao;

            try 
            {
                conexao.Open();
            } 
            catch 
            {
                MessageBox.Show("Dados de usuário incorretos!");
                conexao.Close();
            }
            
            if (conexao.State.ToString() == "Open") 
            {
                MessageBox.Show("Conexão realizada com sucesso!");
            }
        }

        private void Reset()
        {
            Select();
            text_codigo.Text = "";
            text_email.Text = "";
            text_idade.Text = "";
            text_nome.Text = "";
            text_telefone.Text = "";
            validation = -1;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Select();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void text_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Select()
        {
            try
            {
                string sql = @"select * from public.users";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                table = new DataTable();
                table.Load(cmd.ExecuteReader());
                tableUsers.DataSource = null;
                tableUsers.DataSource = table;
            } catch (Exception ex)
            {
                MessageBox.Show("Falha ao carregar. Erro: " + ex.Message);
            }
        }

        private Boolean HasCodigo(int codigo)
        {
            string sql = @"select * from public.users WHERE codigo = " + codigo;
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
            NpgsqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                conexao.Close();
                conexao.Open();
                return true;
            } else
            {
                conexao.Close();
                conexao.Open();
                return false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (text_codigo.Text == string.Empty || text_nome.Text == string.Empty ||
                        text_email.Text == string.Empty || text_idade.Text == string.Empty ||
                        text_telefone.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            try
            {
                var verifica = Convert.ToInt32(text_codigo.Text);
                Convert.ToInt32(text_idade.Text);
                if (verifica <= 0)
                {
                    MessageBox.Show("Código deve ser maior que zero!");
                    return;
                }
            } catch
            {
                MessageBox.Show("Código e idade devem conter apenas números!");
                return;
            }

            if (validation < 0) // insert
            {
                try
                {
                    int idade = Convert.ToInt32(text_idade.Text);
                    int codigo = Convert.ToInt32(text_codigo.Text);
                    string sql;
                    sql = "INSERT INTO public.users(nome,email,idade,telefone,codigo) ";
                    sql += "VALUES (@nome,@email,@idade,@telefone,@codigo);";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@nome", NpgsqlDbType.Varchar, 50).Value = text_nome.Text;
                    cmd.Parameters.AddWithValue("@email", NpgsqlDbType.Varchar, 45).Value = text_email.Text;
                    cmd.Parameters.AddWithValue("@idade", NpgsqlDbType.Integer).Value = idade;
                    cmd.Parameters.AddWithValue("@telefone", NpgsqlDbType.Varchar, 14).Value = text_telefone.Text;
                    cmd.Parameters.AddWithValue("@codigo", NpgsqlDbType.Integer).Value = codigo;

                    int res = cmd.ExecuteNonQuery();

                    if (res > 0)
                    {
                        MessageBox.Show("Inserido com sucesso!");
                        Reset();
                    }
                    
                }
                catch (Exception ex)
                {
                    if (text_telefone.Text.Length > 14)
                    {
                        MessageBox.Show("Número de telefone inválido!");
                    }
                    else
                    {
                        Boolean res = HasCodigo(Convert.ToInt32(text_codigo.Text));
                        if (res)
                        {
                            MessageBox.Show("Código já utilizado!");
                        } else
                        {
                            MessageBox.Show("Falha ao inserir. Erro: " + ex.Message);
                        }
                    }
                }
            } else // update
            {
                try
                {
                    int idade = Convert.ToInt32(text_idade.Text);
                    int codigo = Convert.ToInt32(text_codigo.Text);

                    int id = int.Parse(tableUsers.Rows[validation].Cells["id"].Value.ToString());
                    string sql;
                    sql = @"UPDATE public.users SET ";
                    sql += "nome = @nome, email = @email, idade = @idade, telefone = @telefone, codigo = @codigo ";
                    sql += "WHERE id = @id::integer";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", text_nome.Text);
                    cmd.Parameters.AddWithValue("@email", text_email.Text);
                    cmd.Parameters.AddWithValue("@idade", idade);
                    cmd.Parameters.AddWithValue("@telefone", text_telefone.Text);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    int res = cmd.ExecuteNonQuery();

                    if (res > 0)
                    {
                        MessageBox.Show("Alterado com Sucesso!");
                        Reset();
                    }

                }
                catch (Exception ex)
                {
                    if (text_telefone.Text.Length > 14)
                    {
                        MessageBox.Show("Número de telefone inválido!");
                    }
                    else
                    {
                        Boolean res = HasCodigo(Convert.ToInt32(text_codigo.Text));
                        if (res)
                        {
                            MessageBox.Show("Código já utilizado!");
                        } else
                        {
                            MessageBox.Show("Falha ao inserir. Erro: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void tableUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                validation = e.RowIndex;
                text_nome.Text = tableUsers.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                text_email.Text = tableUsers.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                text_idade.Text = tableUsers.Rows[e.RowIndex].Cells["Idade"].Value.ToString();
                text_telefone.Text = tableUsers.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
                text_codigo.Text = tableUsers.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (validation < 0)
            {
                MessageBox.Show("Selecione algum usuário!");
                return;
            }

            try
            {
                int id = int.Parse(tableUsers.Rows[validation].Cells["id"].Value.ToString());
                string sql;
                sql = @"DELETE FROM public.users WHERE id = @id::integer";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                int res = cmd.ExecuteNonQuery();

                if (res > 0)
                {
                    MessageBox.Show("Removido com Sucesso!");
                    Reset();
                }
                
            } catch (Exception ex)
            {
                MessageBox.Show("Falha ao remover! Erro: " + ex.Message);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
