﻿using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace Setup
{
    public class BD
    {
        public static string UsuarioLogado;
        public static int TentativaLogin;
        public static string UsuarioAdmin;

        //Aula 26
        public static bool AcessoLiberado()
        {
            //if (UsuarioAdmin == "N")
            //{
                Formularios.FrmLiberaPermissao frm = new Formularios.FrmLiberaPermissao();
                frm.ShowDialog();

                if (UsuarioAdmin == "N")
                    return false;
                else
                {
                    UsuarioAdmin = "N";
                    return true;
                }
            //}
            //else
            
                //return true;
        }

        private static FbConnection Conectar()
        {
            ConfigurationManager.RefreshSection("appSettings");

            string Caminho = ConfigurationManager.AppSettings["Banco"].ToString();
            string Servidor = ConfigurationManager.AppSettings["Servidor"].ToString();
            string Porta = ConfigurationManager.AppSettings["Porta"].ToString();
            string Usuario = "SYSDBA";
            string Senha = "masterkey";

            return new FbConnection("User="+Usuario+";Password="+Senha+";Database="+Caminho+";DataSource="+Servidor+";Port="+Porta);
        }

        public static void TestarConexao()
        {
            using (FbConnection ConexaoFB = Conectar())
            {
                try
                {
                    ConexaoFB.Open();
                }
                catch (FbException ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    ConexaoFB.Dispose();
                }
            }
        }

        public static int ExecutarSQL(string SQL)
        {
            using (FbConnection ConexaoFB = Conectar())
            {
                try
                {
                    ConexaoFB.Open();
                    FbCommand cmd = new FbCommand(SQL, ConexaoFB);
                    return cmd.ExecuteNonQuery();
                }
                catch (FbException ex)
                {

                    throw new Exception(ex.ToString());
                }
                finally
                {
                    ConexaoFB.Dispose();
                }
            }
        }

        public static string CvData(string data)
        {
            if(data == "")
            {
                return "null";
            }
            else
            {
                data = data.Replace("/", ".");
                return data;
            }
        }

        public static string CvNum(string num)
        {
            if(num == "")
            {
                return "0";
            }
            else
            {
                num = num.Replace("R$", "");
                num = num.Trim();
                num = num.Replace(".", "");
                num = num.Replace(",", ".");
                return num;
            }
        }

        private static string Insert(string Tabela, string[] Campos, string[] Valores)
        {
            string sql = "insert into " + Tabela + "(";

            foreach (string item in Campos)
            {
                sql += item + ", ";
            }
            sql += ")";
            sql = sql.Replace(", )", ")");

            sql += " values(";

            foreach (string item in Valores)
            {
                if(item == "null")
                {
                    sql += "null, ";
                }
                else
                {
                    sql += "'" + item + "', ";
                }
    
            }

            sql += ")";
            sql = sql.Replace(", )", ")");

            return sql;
        }

        private static string Update(string Tabela, string[] Campos, string[] Valores, string Id)
        {
            string sql = "update " + Tabela + " SET ";

            int total = Campos.Length;

            for (int i = 0; i < total; i++)
            {
                if (Valores[i] == "null")
                {
                    sql += Campos[i] + " = null, ";
                }
                else
                {
                    sql += Campos[i] + " = '" + Valores[i] + "',";
                }

             }

            sql += " WHERE ";
            sql = sql.Replace(", WHERE ", " WHERE ");

            sql += Tabela + "_id = " + Id; 

            return sql;
        }

        public static void Salvar(string Tabela, string[] Campos, string[] Valores, string Id = "")
        {
            if (Id == "")
            {
                ExecutarSQL(Insert(Tabela, Campos, Valores));
            }
            else
            {
                ExecutarSQL(Update(Tabela, Campos, Valores, Id));
            }
        }

        public static void Excluir(string Tabela, string Id)
        {
            Geral.Pergunta("Deseja realmente exclur o registro?");

            if (!Geral.Resposta)
                return;

            string sql = "delete from " + Tabela + " where " + Tabela + "_id = " + Id;
            ExecutarSQL(sql);
        }

        public static void Ativar(string Tabela, string Id, string Status)
        {
            Geral.Pergunta("Deseja realmente alterar o status do registro?");

            if (!Geral.Resposta)
                return;

            string sql = "update " + Tabela + " SET ativo = '" + Status + "' where " + Tabela + "_id = " + Id;
            ExecutarSQL(sql);
        }

        public static DataTable Buscar(string sql)
        {
            using(FbConnection Conexao = Conectar())
            {
                try
                {
                    DataTable dt = new DataTable();
                    Conexao.Open();
                    FbCommand cmd = new FbCommand(sql, Conexao);
                    FbDataAdapter da = new FbDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch (FbException ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    Conexao.Dispose();
                }
            }
        }
        //aula 09 - Mod 2
        public static string Criptografar(string senha)
        {
            MD5 md5Hash = MD5.Create();

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}