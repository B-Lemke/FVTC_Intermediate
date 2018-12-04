using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace BJL.ComputerWorld.PL
{
    public class Database
    {
        string connstr = string.Empty;

        SqlConnection conn;

        //constructor
        public Database(string connectionString)
        {
            connstr = connectionString;
        }

        //Open a connection to the database
        public ConnectionState Open()
        {
            try
            {
                //Instantiate connection
                conn = new SqlConnection();

                //Set the connection string equal to our modular variable
                conn.ConnectionString = connstr;

                //Try to open the connection
                conn.Open();

                //Return the connection state
                return conn.State;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //Close the connection
        public void Close()
        {
            try
            {
                conn.Close();
                conn = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //ExecuteSQL method that returns the number of rows effects
        private int ExecuteSQL(SqlCommand cmd)
        {
            try
            {
                //Try to open the DB
                if(ConnectionState.Open == Open())
                {
                    //set the connection
                    cmd.Connection = conn;

                    //execute query
                    int iRowsAffected = cmd.ExecuteNonQuery();

                    Close();

                    //return rows effected
                    return iRowsAffected;
                }
                else
                {
                    //DB connection not opened, return 0 rows effected
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Insert(SqlCommand cmd)
        {
            try
            {
                return ExecuteSQL(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Update(SqlCommand cmd)
        {
            try
            {
                return ExecuteSQL(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Delete(SqlCommand cmd)
        {
            try
            {
                return ExecuteSQL(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Select(SqlCommand cmd)
        {
            try
            {
                if(ConnectionState.Open == Open())
                {
                    //Set connection string
                    cmd.Connection = conn;

                    //Create a new sqlDataAdapter with a command in the custom constructor
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    //make a place to put the data
                    DataTable dt = new DataTable();

                    //Use the data adapter to fill the data table;
                    da.Fill(dt);

                    //return the data table
                    return dt;
                }
                else
                {
                    //Did not open connection, throw exception
                    throw new Exception("Cannot open database");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
