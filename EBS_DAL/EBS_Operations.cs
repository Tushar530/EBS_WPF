using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBS_Entities;
using EBS_Exception;
using System.Configuration;

namespace EBS_DAL
{
    /// <summary>
    /// Author: Group3
    /// This class implements all the operations
    /// </summary>
    public class EBS_Operations
    {

        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        public EBS_Operations()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn1"].ConnectionString);
        }

       //Insert Login 
        public int Insert(Login log)
        {
            int no = 0;
            try
            {
                //cmd = new SqlCommand("insert into Student_132419(StudName,Gender,DOB,FeesPaid,MobileNO,Email) values('" + stud.StudName + "', '" + stud.Gender + "', '" + stud.DOB + "', " + stud.FeesPaid + ", '" + stud.MobileNO + "', '" + stud.Email + "')", cn);
                cmd = new SqlCommand("Group3.USP_Insert_Login", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeId", log.EmplpoyeeId);
                cmd.Parameters.AddWithValue("@EmployeePassword", log.EmployeePassword);
               
                cn.Open();
                no = cmd.ExecuteNonQuery();
            }
            catch (EBSException ex1)
            {
                throw ex1;
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            finally
            {
                cn.Close();
            }
            return no;
        }

        //Inserting  a Employee
        public int Insert(Employee emp)
        {
            int no = 0;
            try
            {
               
                cmd = new SqlCommand("Group3.USP_Insert_Employee", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeName", emp.EmployeeName);
                cmd.Parameters.AddWithValue("@EmployeeDesignation", emp.EmployeeDesignation);

                cn.Open();
                no = cmd.ExecuteNonQuery();
            }
            catch (EBSException ex1)
            {
                throw ex1;
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            finally
            {
                cn.Close();
            }
            return no;
        }

        //Inserting a Travel 
        public int Insert(Travel tra)
        {
            int no = 0;
            try
            {

                cmd = new SqlCommand("Group3.USP_Insert_Travel", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
               // cmd.Parameters.AddWithValue("@TravelId", tra.TravelId);
                cmd.Parameters.AddWithValue("@SourceName", tra.SourceName);
                cmd.Parameters.AddWithValue("@DestinationName", tra.DestinationName);
                cmd.Parameters.AddWithValue("@FromDate", tra.FromDate);
                cmd.Parameters.AddWithValue("@ToDate", tra.ToDate);
                cn.Open();
                no = cmd.ExecuteNonQuery();
            }
            catch (EBSException ex1)
            {
                throw ex1;
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            finally
            {
                cn.Close();
            }
            return no;
        }

        //Deleting a Travel 
        public List<Travel> Delete(int id)
        {
            List<Travel> tra = new List<Travel>();
            int no = 0;
            try
            {
                cmd = new SqlCommand("Group3.USP_TravelDel", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TravelId",id);
                cn.Open();
                no = cmd.ExecuteNonQuery();
            }
            catch (EBSException ex1)
            {
                throw ex1;
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            finally
            {
                cn.Close();
            }
            return tra;
        }

        //SelectAll Employee
        public List<Employee> SelectAll()
        {
            List<Employee> emp = new List<Employee>();
            try
            {
              
                cmd = new SqlCommand("Group3.USP_SelectAll_Employee", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Employee e = new Employee();
                    e.EmployeeName = dr[1].ToString();
                    e.EmployeeDesignation = dr[2].ToString();
                    emp.Add(e);
                   
                }
            }
            catch (EBSException ex1)
            {
                throw ex1;
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            finally
            {
                dr.Close();
                cn.Close();
            }
            return emp;
        }

        //Select All Travel
        public List<Travel> SelectAllTravel()
        {
            List< Travel> tra = new List<Travel>();
            try
            {

                cmd = new SqlCommand("Group3.USP_SelectAll_Travel", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Travel t = new Travel();
                    t.TravelId = Convert.ToInt32(dr[0]);
                    t.SourceName = dr[1].ToString();
                    t.DestinationName = dr[2].ToString();
                    t.FromDate = Convert.ToDateTime(dr[3]);
                    t.ToDate = Convert.ToDateTime(dr[4]);
                    tra.Add(t);

                }
            }
            catch (EBSException ex1)
            {
                throw ex1;
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            finally
            {
                dr.Close();
                cn.Close();
            }
            return tra;
        }


        //validate Login
        public bool CheckLogin(int EmployeeID, string EmployeePassword)

        {
            bool isCheck = false;
            SqlCommand cmd = new SqlCommand("[Group3].[USP_LoginValidation]", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeId", EmployeeID);
            cmd.Parameters.AddWithValue("@EmployeePassword", EmployeePassword);
            cn.Open();
            dr = cmd.ExecuteReader();
            try
            {
               
                if (dr.HasRows)
                {
                    dr.Read();
                    string id = dr[0].ToString();
                    isCheck = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                cn.Close();
            }

            return isCheck;

        }

    }
}
