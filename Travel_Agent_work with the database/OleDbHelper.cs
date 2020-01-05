using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentDLL
{
    public class OleDbHelper
    {
        public static string ConnectionString
        {
            get
            {
                return @"provider=microsoft.jet.oledb.4.0; Data source=C:\Users\User\Desktop\Projects\TurAgent\TurAgentDLL\TurAgentDLL\App_Data\TurAgent111.mdb";
            }

            
        }
        //DisConnected
        public static DataSet GetDataSet(string strSql)
        {
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            OleDbCommand command = new OleDbCommand(strSql, connection);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            return ds;
        }

        //full
        public static object ExecuteScalar(string strSql)
        {
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            OleDbCommand command = new OleDbCommand(strSql, connection);
            connection.Open();
            object obj = command.ExecuteScalar();
            connection.Close();
            return obj;
        }

        //full
        static public int ExecuteNonQuery(string strSql)
        {
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            OleDbCommand command = new OleDbCommand(strSql, connection);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }

        //DisConnected
        static public DataSet fill(string com, string name)
        {
            OleDbConnection cn = new OleDbConnection(ConnectionString);
            OleDbCommand command = new OleDbCommand();
            command.Connection = cn;
            command.CommandText = com;
            DataSet ds = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            try
            {
                adapter.Fill(ds, name);
            }
            catch
            {

            }
            finally
            {

            }
            return ds;

        }

        //DisConnected
        //פעולה המעדכנת את הדטהבייס בהתאם לדטהסט
        public static void update(DataSet ds, string com, string name)
        {
            OleDbConnection cn = new OleDbConnection(ConnectionString);
            OleDbCommand command = new OleDbCommand();
            command.Connection = cn;
            command.CommandText = com;

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            try
            {
                cn.Open();
                adapter.Update(ds, name);
            }
            catch
            {
            }
            finally
            {
                cn.Close();
            }


        }



    }
}
