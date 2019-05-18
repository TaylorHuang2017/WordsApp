using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordapp
{
    class AccessHelper //实现了增删改查的Helper类
    {
        public OleDbConnection dbConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Administrator\Desktop\memorizingwords\wordapp\wordapp\bin\wordsdb2002.mdb");
        public AccessHelper()
        {
            try
            {
                dbConnection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        /// <summary>
        /// 增
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool Add(string sql)
        {
            OleDbCommand oleDbCommand = new OleDbCommand(sql, dbConnection);
            int i = oleDbCommand.ExecuteNonQuery();
            return i > 0;
        }
        /// <summary>
        /// 删
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool Del(string sql)
        {
            OleDbCommand oleDbCommand = new OleDbCommand(sql, dbConnection);
            int i = oleDbCommand.ExecuteNonQuery();
            return i > 0;
        }
        /// <summary>
        /// 改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool Change(string sql)
        {
            OleDbCommand oleDbCommand = new OleDbCommand(sql, dbConnection);
            int i = oleDbCommand.ExecuteNonQuery();
            return i > 0;
        }
        /// <summary>
        /// GET 查
        /// </summary>
        /// <param name="sql"></param>
        public DataTable Get(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, dbConnection);
                dbDataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
