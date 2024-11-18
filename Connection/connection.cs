namespace ConnectionToSql
{
    public class Connection
    {
        string strConn = "Server=localhost;Database=QUANLYBENXE;Integrated Security=True;";

        public SqlConnection conn { get; set; }
        public SqlCommand cmd { get; set; }
        public SqlDataReader drd { get; set; }

        public SqlDataAdapter da { get; set; }

        public Connection()
        {
            conn = new SqlConnection(strConn);
            cmd = null;
            drd = null;
            da = null;
        }

        public bool openConn()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool closeConn()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public SqlDataReader executeSQL(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            drd = cmd.ExecuteReader();
            return drd;
        }

        ///Cập nhật dữ liệu theo mô hình kết nối
        public int executeUpdate(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteNonQuery();
        }
    }

}
