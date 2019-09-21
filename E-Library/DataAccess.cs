using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DoAn1
{
    class DataAccess
    {
        SqlConnection Connect = null;
        private Exception erro = null;
        public Exception Erro
        {
            get
            {
                return erro;
            }

        }

        public DataAccess()
        {
            SqlConnectionStringBuilder ConnectBuilder = new SqlConnectionStringBuilder();

            ConnectBuilder.DataSource = ConfigurationSettings.AppSettings["Server"];
            ConnectBuilder.InitialCatalog = ConfigurationSettings.AppSettings["Database"];
            ConnectBuilder.UserID = ConfigurationSettings.AppSettings["UserID"];
            ConnectBuilder.Password = ConfigurationSettings.AppSettings["Password"];
            ConnectBuilder.IntegratedSecurity = ConfigurationSettings.AppSettings["IntergratedSecurity"] == "true" ? true : false;

            Connect = new SqlConnection(ConnectBuilder.ConnectionString);

        }

        public DataTable GetData(string commandText, params SqlParameter[] parameter)
        {
            DataTable resultTB = new DataTable();
            erro = null;
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, Connect);
                dataAdapter.SelectCommand.Parameters.AddRange(parameter);
                Connect.Open();
                dataAdapter.Fill(resultTB);
            }
            catch (Exception ex)
            {
                erro = ex;
            }
            finally
            {
                if (Connect != null && Connect.State != ConnectionState.Closed)
                    Connect.Close();
            }
            return resultTB;
        }

        public int AddData(string commandText, params SqlParameter[] parameter)
        {
            erro = null;
            int result = 0;
            try
            {
                SqlCommand command = new SqlCommand(commandText, Connect);

                command.Parameters.AddRange(parameter);

                Connect.Open();

                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                erro = ex;
            }
            finally
            {
                if (Connect != null && Connect.State != ConnectionState.Closed)
                    Connect.Close();
            }
            return result;
        }

    }
}
