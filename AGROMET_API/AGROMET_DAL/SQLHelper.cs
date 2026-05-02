using AGROMET_COMMON;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROMET_DAL
{
    public class SQLHelper
    {
        private static String ConnectionString
        {
            //Default admin database connection to further fetch insitutio configuration
            get { return ConfigurationManager.ConnectionStrings["db_connection"].ToString(); }
        }
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static DataTable Execute(string storedProc, SqlParameter[] arrParams)
        {
            _log.Info("starting Execute service in sql helper");
            DataTable dt = new DataTable();


            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["db_connection"].ConnectionString);

            SqlCommand cmd = new SqlCommand(storedProc, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            if (cn.State == ConnectionState.Closed || cn.State == ConnectionState.Broken)
                cn.Open();

            try
            {
                _log.Info("adding parameter value to SP param in Execute service in sql helper ");
                if (arrParams != null)
                {
                    foreach (SqlParameter param in arrParams)
                        cmd.Parameters.Add(param);
                }

                //cmd.Parameters.Add("result", SqlDbType.VarChar,2000);
                // cmd.Parameters["result"].Direction = ParameterDirection.Output;
                _log.Info("exceuting sql adapter in Execute service in sql helper ");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _log.Info("ending Execute service in sql helper");
                return dt;
            }
            catch (Exception ex)
            {
                _log.Error("exception in Execute service in sql helper : "+ ex.Message);
                throw new Exception("Error: " + ex.Message);
            }
            finally
            {
                _log.Info("closing resources in Execute service in sql helper ");
                cmd.Dispose();
                cn.Close();
                //Log.Write(LogLevel.Info, "Completed executing Execute");
            }
        }
        public static TransactionDetails ExecuteOutIDParameter(string storedProc, SqlParameter[] arrParams)
        {// Returns newly created Auto increment ID to the application.
            _log.Info("starting ExecuteOutIDParameter service in sql helper ");

            TransactionDetails response = new TransactionDetails();
            response.IsSuccessful = false;

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["db_connection"].ConnectionString);


            //VAS.Common.Log.writeToFile(cn.ConnectionString);


            SqlCommand cmd = new SqlCommand(storedProc, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            if (cn.State == ConnectionState.Closed || cn.State == ConnectionState.Broken)
                //Log.writeToFile(cn.ConnectionString);
                cn.Open();
            try
            {
                _log.Info("adding parameter value to SP param in ExecuteOutIDParameter service in sql helper ");
                if (arrParams != null)
                {
                    foreach (SqlParameter param in arrParams)
                        cmd.Parameters.Add(param);
                }

                cmd.Parameters.Add("out_status", SqlDbType.Bit);
                cmd.Parameters["out_status"].Direction = ParameterDirection.Output;

                cmd.Parameters.Add("result", SqlDbType.VarChar, 2000);
                cmd.Parameters["result"].Direction = ParameterDirection.Output;
                // Returns new ID from calling parameter
                cmd.Parameters.Add("NewID", SqlDbType.VarChar, 2000);
                cmd.Parameters["NewID"].Direction = ParameterDirection.Output;
                _log.Info("exceuting  ExecuteNonQuery in ExecuteOutIDParameter service in sql helper ");
                cmd.ExecuteNonQuery();
                var OutStatus = Convert.ToBoolean(cmd.Parameters["out_status"].Value);
                var OutMessage = Convert.ToString(cmd.Parameters["result"].Value);

                if (OutStatus == true)
                {
                    response.IsSuccessful = true;
                    response.SuccessMessage = OutMessage;
                    if (cmd.Parameters["NewID"].Value != DBNull.Value)
                    {
                        response.NewID = Convert.ToInt64(cmd.Parameters["NewID"].Value);
                    }
                }
                else
                {
                    response.ErrorMessage = OutMessage;
                }
            }
            catch (SqlException ex)
            {
                _log.Error("exception in ExecuteOutIDParameter service in sql helper : " + ex.Message);
                response.ErrorMessage = ex.Message;
            }
            catch (Exception ex)
            {
                //Log.Write(LogLevel.Error, "Exception in method ExecuteOutParameter", ex);
                _log.Error("exception in ExecuteOutIDParameter service in sql helper : "+ ex.Message);
                throw new Exception("Error: " + ex.Message);
            }
            finally
            {
                _log.Info("closing resources in ExecuteOutIDParameter service in sql helper ");
                cmd.Dispose();
                cn.Close();
                //Log.Write(LogLevel.Info, "Completed executing ExecuteOutParameter");
            }
            _log.Info("ending ExecuteOutIDParameter service in sql helper ");
            return response;
        }
        public static DataSet ExecuteMulti(string storedProc, SqlParameter[] arrParams)
        {
            _log.Info("starting  ExecuteMulti service in sql helper : ");
            //Log.Write(LogLevel.Info, "Started executing Execute");
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["db_connection"].ConnectionString);

            SqlCommand cmd = new SqlCommand(storedProc, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            if (cn.State == ConnectionState.Closed || cn.State == ConnectionState.Broken)
                cn.Open();
            try
            {
                _log.Info("adding sql param in ExecuteMulti service in sql helper " );
                if (arrParams != null)
                {
                    foreach (SqlParameter param in arrParams)
                        cmd.Parameters.Add(param);
                }
                _log.Info("exceuting sql adapter in  ExecuteMulti service in sql helper");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                _log.Info("ending ExecuteMulti service in sql helper");
                return ds;
            }
            catch (Exception ex)
            {
                _log.Error("exception in ExecuteMulti service in sql helper : " + ex.Message);
                throw new Exception("Error: " + ex.Message);
            }
            finally
            {
                _log.Error("closing resources in  ExecuteMulti service in sql helper");
                cmd.Dispose();
                cn.Close();
                //Log.Write(LogLevel.Info, "Completed executing Execute");
            }
        }
    }    
}
