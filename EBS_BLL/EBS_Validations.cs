using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBS_DAL;
using EBS_Entities;
using EBS_Exception;
namespace EBS_BLL
{   /// <summary>
    /// Author: Group3
    /// This class implements all the validations
    /// </summary>
    public class EBS_Validations
    {
        EBS_Operations dal = null;

        public EBS_Validations()
        {
            dal = new EBS_Operations();
        }
        //This class represents GetALLTravel methods
        public List<Employee> GetAll()
        {
            List<Employee> emp = null;
            try
            {
                emp = dal.SelectAll();
            }
            catch (EBSException ex1)
            {
                throw ex1;
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            return emp;
        }

        //This class represents GetALLTravel methods
        public List<Travel> GetAllTravel()
        {
            List<Travel> tra = null;
            try
            {
                tra = dal.SelectAllTravel();
            }
            catch (EBSException ex1)
            {
                throw ex1;
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            return tra;
        }

        //This class represents Add Employee methods
        public int Add(Employee emp)
        {
            int no = 0;
            try
            {
                //if (Validate(emp))
                no = dal.Insert(emp);
            }
            catch (EBSException ex1)
            {
                throw ex1;
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            return no;
        }

        //This class represents Add Travel methods
        public int Add(Travel tra)
        {
            int no = 0;
            try
            {
                //if (Validate(tra))
                no = dal.Insert(tra);
            }
            catch (EBSException ex1)
            {
                throw ex1;
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            return no;
        }


        //This class represents Remove Travel Id
        public List<Travel> Remove(int id)
        {
            List<Travel> tra = new List<Travel>();

            try
            {
                tra = dal.Delete(id);
            }
            catch (EBSException ex1)
            {
                throw ex1;
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            return tra;

        }

        public int Add(Login log)
        {
            int no = 0;
            try
            {
                //if (Validate(tra))
                no = dal.Insert(log);
            }
            catch (EBSException ex1)
            {
                throw ex1;
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            return no;
        }

        //It Handles Login Validation
        public bool LoginValidate(int EmployeeID, string EmployeePassword)
        {
            bool Loginvalid = true;

            try
            {
                //Loginvalid = ValidateLogin(emp1);
                if (Loginvalid == true)
                {
                    Loginvalid = dal.CheckLogin(EmployeeID, EmployeePassword);
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
            return Loginvalid;
        }
    }
}
