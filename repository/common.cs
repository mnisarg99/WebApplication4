using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using WebApplication4.Models;

namespace WebApplication4.Repository
{

    namespace WebApplication4.repository
    {
        public class common
        {
            private SqlConnection con;



            private void Connection()
            {
                string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
                con = new SqlConnection(_conString);

            }

            public List<AppRefDataNisarg> GetAppRefData(int parentId)
            {
                List<AppRefDataNisarg> appRefDataList = new List<AppRefDataNisarg>();
                Connection();
                SqlCommand cmd = new SqlCommand("GetAppRefData_Training_Nisarg", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@parentId", SqlDbType.Int);
                cmd.Parameters["@parentId"].Value = parentId;
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    appRefDataList.Add(
                        new AppRefDataNisarg { KeyId = Convert.ToInt32(reader["KeyId"]), KeyName = reader["KeyName"].ToString() }
                        );
                }

                reader.Close();
                con.Close();

                return appRefDataList;
            }

            public List<Emplist> GetWorkingCompany()
                {
                    List<Emplist> appRefDataList = new List<Emplist>();
                    Connection();
                    SqlCommand cmd = new SqlCommand("Get_WorkingCompany_Nisarg", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        appRefDataList.Add(
                            new Emplist { Id = Convert.ToInt32(reader["CompanyMaster_Id"]), Name = reader["CompanyName"].ToString() }
                            );
                    }

                reader.Close();
                con.Close();

                return appRefDataList;
            }

            public List<Emplist> GetEmplists()
            {
                List<Emplist> appRefDataList = new List<Emplist>();
                Connection();
                SqlCommand cmd = new SqlCommand("Get_WorkLocation_Nisarg", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    appRefDataList.Add(
                        new Emplist { Id = Convert.ToInt32(reader["WorkingLocation_Id"]), Name = reader["Location_Name"].ToString() }
                        );
                }

                reader.Close();
                con.Close();

                return appRefDataList;
            }

            public List<Emplist> GetDepartment()
            {
                List<Emplist> appRefDataList = new List<Emplist>();
                Connection();
                SqlCommand cmd = new SqlCommand("Get_Dep_Nisarg", con);
                cmd.CommandType = CommandType.StoredProcedure;


                con.Open();


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    appRefDataList.Add(new Emplist { Id = Convert.ToInt32(reader["Dept_Code"]), Name = reader["Dept_Name"].ToString()}
                    );
                }

            reader.Close();
                con.Close();


                return appRefDataList; 
            }
            

            public List<Emplist> GetAppRefId()
            { 
                List<Emplist> appRefDataList = new List<Emplist>();
                Connection();
                SqlCommand cmd = new SqlCommand("Get_BatchId_Nisarg", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    appRefDataList.Add(
                       new Emplist { Id = Convert.ToInt32(reader["KeyId"]), Name = reader["Description"].ToString() }
                        );
                }

                reader.Close();
                con.Close();

                return appRefDataList;
            }

            public List<Emplist> GetHr()
            {
                List<Emplist> appRefDataList = new List<Emplist>();
                Connection();
                SqlCommand cmd = new SqlCommand("Get_HrRepresentative_Nisarg", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    appRefDataList.Add(
                       new Emplist { Id = Convert.ToInt32(reader["EmployeeDetails_Id"]), Name = reader["FullName"].ToString() }
                        );
                }

                reader.Close();
                con.Close();

                return appRefDataList;
            }

            public List<Emplist> GetRecr()
            {
                List<Emplist> appRefDataList = new List<Emplist>();
                Connection();
                SqlCommand cmd = new SqlCommand("Get_ActRec_Nisarg", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    appRefDataList.Add(
                        new Emplist { Id = Convert.ToInt32(reader["EmployeeDetails_Id"]), Name = reader["Full_Name"].ToString() }
                        );
                }

                reader.Close();
                con.Close();

                return appRefDataList;
            }


        }
    }
}







