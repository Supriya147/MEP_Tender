using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MEPTender.Models
{
    public class DAL
    {
        string connectionString = "Data Source=SUPRIYAG-ESG\\SQL;Initial Catalog=MEP_Tender;Integrated Security=True";

        public IEnumerable<Employee> GetRegistratinData()
        {
            List<Employee> lstemployee = new List<Employee>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetRegistration", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Employee employee = new Employee();

                    employee.ProjectDetails = rdr["ProjectDetails"].ToString();
                    employee.Client = rdr["Client"].ToString();
                    employee.Consultant = rdr["Consultant"].ToString();
                    employee.Contractor = rdr["Contractor"].ToString();

                    lstemployee.Add(employee);
                }
                con.Close();
            }
            return lstemployee;
        }

        public void AddEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AddRegistration", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProjectDetails", employee.ProjectDetails);
                cmd.Parameters.AddWithValue("@Client", employee.Client);
                cmd.Parameters.AddWithValue("@Consultant", employee.Consultant);
                cmd.Parameters.AddWithValue("@Contractor", employee.Contractor);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }

     
    
}
