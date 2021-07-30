using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOActivity_3DAL
{
    public class StudentDetails
    {

        SqlConnection sqlConObj1;
        SqlCommand sqlCmdObj;

        public string ConnectTomyDatabase()

        {
            try

            { 
                sqlConObj1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyWork"].ToString());

                //string conStr = ConfigurationManager.ConnectionStrings["mywork"].ToString(); 

                sqlConObj1.Open();

                return sqlConObj1.State.ToString();

            }

            catch (Exception)
            {
                return sqlConObj1.State.ToString();
            }
            finally

            {
                sqlConObj1.Close();
            }

        }


        // StudentInfo table 

        public List<string> StudentInfoDetails()

        {
            List<string> lstProduct = new List<string>();
            try

            { 
                sqlConObj1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyWork"].ToString());

                 //sqlCmdObj= new SqlCommand(@"SELECT RollNo,Name,CompanyName,Location FROM [myDatabase].[dbo].[StudentInfo]", sqlConObj1);
                // sqlCmdObj = new SqlCommand(@"UPDATE [myDatabase].[dbo].[StudentInfo] SET Name='Piyush' where RollNo='1'", sqlConObj1);
                //sqlCmdObj = new SqlCommand(@"Insert into [myDatabase].[dbo].[StudentInfo](RollNo,Name,CompanyName,Location) values(4,'Arti','Capgemini','Mumbai')", sqlConObj1);
                sqlCmdObj = new SqlCommand(@"Delete from [myDatabase].[dbo].[StudentInfo] where RollNo='4'", sqlConObj1);
                sqlCmdObj = new SqlCommand(@"SELECT RollNo,Name,CompanyName,Location FROM [myDatabase].[dbo].[StudentInfo]", sqlConObj1);

                sqlConObj1.Open();

                SqlDataReader drProduct = sqlCmdObj.ExecuteReader();

                while (drProduct.Read())
                {
                    lstProduct.Add(String.Concat(drProduct["RollNo"], drProduct["Name"], drProduct["CompanyName"], drProduct["Location"]));
                }
                return lstProduct;
            }
            catch (Exception)
             {
                lstProduct.Add("Something went wrong");

                return lstProduct;
            }

             finally

            {
                sqlConObj1.Close();
            }
        }


        }
}
