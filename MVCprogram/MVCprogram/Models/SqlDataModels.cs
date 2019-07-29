using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace MVCprogram.Models
{
    public class SqlDataModels
    {
        private string ConnectionString;
        private SqlTransaction sqlTrans;
        private SqlConnection sqlConn;

        private string m_UserId = "";

        public SqlDataModels()
        {
            this.ConnectionString = (string)ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

    }

    


}