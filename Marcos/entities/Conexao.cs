using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Marcos.entities
{
    class Conexao
    {
        private static string Path { get; set; } = @"C:\Users\User\Desktop\dados\acme.sqlite";

        private static SQLiteConnection connection;

        private static SQLiteConnection dbConnection()
        {
            connection = new SQLiteConnection("Data Source=" + Path +"; Version=3");
            connection.Open();
            return connection;
        }

        public static void CriarBancoSQLite(string path)
        {
            Path = path;
            try
            {
                if (!System.IO.File.Exists(Path)) 
                {
                    SQLiteConnection.CreateFile(path);
                    CriarTabelaSQlite();
                }
            }
            catch(Exception e) 
            {
                System.Windows.Forms.MessageBox.Show("Acesso não permitidoa esta pasta", "Acesso Negado", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }
        }

        public static void CriarTabelaSQlite()
        {
            try
            {
                using(var cmd = dbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS TB_VOO(" +
                                        "ID_VOO INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                        "DATA_VOO datetime, " +
                                        "CUSTO numeric(10,2), " +
                                        "DISTANCIA itn, " +
                                        "CAPTURA char(1), " +
                                        "NIVEL_DOR int" +
                                        ")";
                    cmd.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void Add(RegFoguete reg)
        {
            try
            {
                using (var cmd = dbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO TB_VOO(" +
                        "DATA_VOO, " +
                        "CUSTO, " +
                        "DISTANCIA, " +
                        "CAPTURA, " +
                        "NIVEL_DOR" +
                        ") VALUES (@data, @custo, @distancia, @captura, @nivelDor)";
                    cmd.Parameters.AddWithValue("@data", reg.DataVoo);
                    cmd.Parameters.AddWithValue("@custo", reg.Custo);
                    cmd.Parameters.AddWithValue("@distancia", reg.Distancia);
                    cmd.Parameters.AddWithValue("@captura", reg.Captura.ToString());
                    cmd.Parameters.AddWithValue("@nivelDor", reg.NivelDor);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<RegFoguete> getFogetes()
        {
            List<RegFoguete> list = new List<RegFoguete>();
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            SQLiteDataReader dr;
            try
            {
                using (var cmd = dbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM TB_VOO;";
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        int idReg = dr.GetInt32(0);
                        string dataVoo = dr.GetDateTime(1).ToString();
                        string custo = dr.GetValue(2).ToString();
                        string distancia = dr.GetInt32(3).ToString();
                        string captura = char.Parse(dr[4].ToString()).ToString();
                        string nivelDor = dr.GetInt32(5).ToString();

                        list.Add(new RegFoguete(idReg, dataVoo, custo, distancia, captura, nivelDor));
                    }

                    if(list.Count != 0) return list;
                    return null;
                }
            }catch(Exception e)
            {
                throw e;
            }
        }

        public static void Update(RegFoguete reg)
        {
            try
            {
                using(var cmd = new SQLiteCommand(dbConnection()))
                {
                    if(reg.idReg != null)
                    {
                        cmd.CommandText = "UPDATE TB_VOO SET " +
                            "DATA_VOO=@dataVoo, " +
                            "CUSTO=@custo, " +
                            "DISTANCIA=@distancia, " +
                            "CAPTURA=@captura, " +
                            "NIVEL_DOR=@nivelDor " +
                            "WHERE ID_VOO = @id;";

                        cmd.Parameters.AddWithValue("@dataVoo", reg.DataVoo);
                        cmd.Parameters.AddWithValue("@custo", reg.Custo);
                        cmd.Parameters.AddWithValue("@distancia", reg.Distancia);
                        cmd.Parameters.AddWithValue("@captura", reg.Captura);
                        cmd.Parameters.AddWithValue("@nivelDor", reg.NivelDor);
                        cmd.Parameters.AddWithValue("@id", reg.idReg);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Delete(int id)
        {
            try
            {
                using(SQLiteCommand cmd = new SQLiteCommand(dbConnection())){
                    cmd.CommandText = "DELETE FROM TB_VOO WHERE ID_VOO = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
