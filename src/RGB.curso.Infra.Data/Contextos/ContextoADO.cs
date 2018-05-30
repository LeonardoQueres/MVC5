using System;
using System.Data;
using System.Data.SqlClient;

namespace Rgb.Curso.Infra.Data.Repository.Contextos
{
    public class ContextoADO
    {
        public SqlConnection conexao;

        public void ExecutaComando(String sql, SqlParameter[] p)
        {
            AbrirConexao();
            var cmd = new SqlCommand
            {
                CommandText = sql,
                CommandType = CommandType.Text,
                Connection = conexao,
                CommandTimeout = 999999
            };
            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(p);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            FecharConexao();
        }

        public void ExecutaComando(String sql)
        {
            AbrirConexao();
            var cmd = new SqlCommand
            {
                CommandText = sql,
                CommandType = CommandType.Text,
                Connection = conexao,
                CommandTimeout = 999999,
            };
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            FecharConexao();
        }

        public SqlDataReader ExecutaComandoComRetorno(String sql, SqlParameter[] p)
        {
            AbrirConexao();
            SqlDataReader ret;
            var cmd = new SqlCommand
            {
                CommandText = sql,
                CommandType = CommandType.Text,
                Connection = conexao,
                CommandTimeout = 999999,
            };

            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(p);
            ret = cmd.ExecuteReader();
            cmd.Dispose();
            FecharConexao();
            return ret;
        }

        public SqlDataReader ExecutaComandoComRetorno(String sql)
        {
            AbrirConexao();
            SqlDataReader ret;
            var cmd = new SqlCommand
            {
                CommandText = sql,
                CommandType = CommandType.Text,
                Connection = conexao,
                CommandTimeout = 999999
            };
            ret = cmd.ExecuteReader();
            cmd.Dispose();
            FecharConexao();
            return ret;
        }

        private void AbrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }


        private void FecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }


        public void Dispose()
        {
            conexao.Close();
            conexao.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}