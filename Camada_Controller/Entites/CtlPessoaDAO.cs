﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using Camada_Model.Entites;
using Camada_Controller;

namespace Camada_Controller.Entites
{
    public class CtlPessoaDAO
    {
        public OleDbConnection obterConexao()
        {
            OleDbConnection Conn = null;
            string ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Andre\Downloads\Documents\Cursos_Da_Faculdade_Sem_4_Bim_2\PIM VIII\db\dbPIMVIII.accdb";
            Conn = new OleDbConnection(ConnectionString);
            if (Conn.State == System.Data.ConnectionState.Closed)
            {
                Conn.Open();
            }
            return Conn;

        }
        public void fecharConexao(OleDbConnection Conn)
        {
            if (Conn.State == System.Data.ConnectionState.Open)
            {
                Conn.Close();
            }
            Conn.Close();
        }
        OleDbDataReader reader = null;
        OleDbConnection conn = null;

        public bool Insira(MdlPessoa pessoa)
        {


            string QueryPessoa = "INSERT INTO Pessoa(Nome, Cpf, Endereço) VALUES ('" + pessoa.Nome + "' , '" + pessoa.Cpf + "', '"
                + pessoa.MdlEndereco + "')";
           
            try
            {
                conn = obterConexao();
               
                OleDbCommand cmd = new OleDbCommand(QueryPessoa, conn);
                
                reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    return true;
                }
                fecharConexao(conn);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            string Querytel = null;
            foreach (MdlTelefone tel in pessoa.mdlTelefones)
            {
                Querytel = "INSERT INTO Telefone(Numero, Ddd, Tipo) VALUES ('" + tel.Numero + "', '"
                    + tel.Ddd + "','" + tel.MdltipoTelefone + "')";

                try
                {
                    conn = obterConexao();
                    
                    OleDbCommand cmd = new OleDbCommand(Querytel, conn);
                   
                    reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        return true;
                    }
                    fecharConexao(conn);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                finally
                {
                    
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
            return true;
        }
        public MdlPessoa Consulta(long Cpf)
        {
            string QueryConsult = "SELECT * FROM Pessoa WHERE Cpf = '" + Cpf + "'";
            MdlPessoa ConsulCpf = new MdlPessoa();

           
            try
            {
                conn = obterConexao();
                DataSet Ds = new DataSet();
                //
                OleDbDataAdapter adapter = new OleDbDataAdapter(QueryConsult, conn);
                adapter.Fill(Ds, "Pessoa");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
            return ConsulCpf;
        }

        public bool Excluir(MdlPessoa pessoa)
        {
            string QueryExcluir = "DELETE * FROM Pessoa WHERE Cpf' = " + pessoa.Cpf + "'";

            try
            {
                conn = obterConexao();
                
                OleDbCommand cmd = new OleDbCommand(QueryExcluir, conn);
               
                reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    return true;
                }
                fecharConexao(conn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return true;
        }
        public bool Alterar(MdlPessoa pessoa, MdlTelefone telefone)
        {
            string QueryAltPessoa;
            QueryAltPessoa = "UPDATE Pessoa SET Cpf ='" + pessoa.Cpf + "',";
            QueryAltPessoa += "UPDATE Pessoa SET Nome ='" + pessoa.Nome + "',";
            QueryAltPessoa += "UPDATE Pessoa SET  Endereço ='" + pessoa.MdlEndereco + "',";
            QueryAltPessoa += "WHERE Cpf = " + pessoa.Cpf;
            try
            {
                conn = obterConexao();
                
                OleDbCommand cmd = new OleDbCommand(QueryAltPessoa, conn);
                
                reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    return true;
                }
                fecharConexao(conn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            foreach (MdlTelefone tel in pessoa.mdlTelefones)
            {
                string QueryAltTelefone;
                QueryAltTelefone = "UPDATE Telefone SET Cpf ='" + telefone.Numero + "',";
                QueryAltTelefone += "UPDATE Pessoa SET Nome ='" + telefone.Ddd + "',";
                QueryAltTelefone += "UPDATE Pessoa SET  Endereço ='" + telefone.MdltipoTelefone + "',";
                QueryAltTelefone += "WHERE Cpf = " + pessoa.Cpf;
                try
                {
                    conn = obterConexao();
                    
                    OleDbCommand cmd = new OleDbCommand(QueryAltTelefone, conn);
                   
                    reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        return true;
                    }
                    fecharConexao(conn);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
                return true;
            }

        

    }
}
