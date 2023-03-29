using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LoginTest
{
    public class DBMySql
    {
        MySqlConnection conn = new MySqlConnection($"server={Config.Server};uid={Config.UserID};"+
            $"pwd={Config.UserPassword};database={Config.Database};pooling=false;allow user variables=true");
        MySqlDataAdapter adpt;
        MySqlCommand cmd;

        public void Connection()
        {
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                //throw;
            }
            conn.Close();
        }
        public DataSet SelectAll(string table)
        {
            try
            {
                DataSet ds = new DataSet();

                string sql = $"SELECT * FROM {table}";
                adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, table);
                if (ds.Tables.Count > 0)
                {
                    return ds;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
        public DataTable Select(string query)
        {
            try
            {
                DataTable ds = new DataTable();

                adpt = new MySqlDataAdapter(query, conn);
                adpt.Fill(ds);

                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }

        public DataSet SelectDetail(string condition, string table, string where = "")
        {
            try
            {
                DataSet ds = new DataSet();

                string sql = $"SELECT {condition} FROM {table} {where}";
                adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, table);
                if (ds.Tables.Count > 0)
                {
                    return ds;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }

        public void Insert(string table, string value)
        {
            try
            {
                conn.Open();
                string sql = $"INSERT {table} VALUES ({value})";
                //INSERT INTO user_info VALUES ('user1', 'j', 'ella', '1993/06/18', 'user1234', 1000000000)
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }

        public void Update(string table, string setvalue, string wherevalue = "")
        {
            try
            {
                conn.Open();
                string sql = $"UPDATE {table} SET {setvalue} {wherevalue}";
                //UPDATE user_info SET firt_name='lee' WHERE user_id='shotslove'
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }

        public void DeleteAll(string table)
        {
            try
            {
                conn.Open();
                string sql = $"DELETE FROM {table}";
                //DELETE FROM user_info WHERE user_id='user1'
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }

        public void DeleteDetail(string table, string wherecol, string wherevalue)
        {
            try
            {
                conn.Open();
                string sql = $"DELETE FROM {table} WHERE {wherecol}='{wherevalue}'";
                //DELETE FROM user_info WHERE user_id='user1'
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }

        public object ExecuteScalar(string query)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                conn.Close();

                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
        public DataTable ExecuteDataTable(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"쿼리 실행 중 오류가 발생하였습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }
    }
}
