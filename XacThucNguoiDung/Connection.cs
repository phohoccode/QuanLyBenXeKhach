﻿using System;
using System.Data;
using System.Data.SqlClient;


public class Connection
{
    private string strConn = "Server=localhost;Database=QUANLYBENXEKHACH;Trusted_Connection=True;";

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
  

    public int executeUpdate(string sql)
    {
        cmd = new SqlCommand(sql, conn);
        return cmd.ExecuteNonQuery();
    }
}
