using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Project_Copy_Master.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Copy_Master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class consultantinfoController : Controller
    {
        private readonly IConfiguration _configuration;
        public consultantinfoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
       
            public JsonResult Get()
            {
                string query = @"
                            select 
                            CompanyName,Conatctno,Email,Address,City,websitelink,companylogo,consultancyservices,service,Detail,mapaddress
                            from
                            dbo.Consultantinfo
                            ";//edit karna

                DataTable table = new DataTable();
                string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader;
                using (SqlConnection myCon = new SqlConnection(sqlDataSource))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query, myCon))
                    {
                        myReader = myCommand.ExecuteReader();
                        table.Load(myReader);
                        myReader.Close();
                        myCon.Close();
                    }
                }

                return new JsonResult(table);
            }
        [Route("[action]/{email}")]
        [HttpGet]
        public JsonResult GetbyEmail(string email)
        {

            string query = @"
                            select CompanyName,Email,Conatctno,Phoneno,Personname,City,Address,websitelink,consultancyservices,services,Detail,mapaddress,statuscheck,companylogo
                            from
                            dbo.Consultantinfo where Email=@Email
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Email", email);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }


        [HttpPost]
            public JsonResult Post(consultantinfo cons)
            {
                string query = @"
                           insert into dbo.Consultantinfo
                           (CompanyName,Email,Conatctno,Password)
                            values (@CompanyName,@Email,@Conatctno,@Password)
                            ";

                DataTable table = new DataTable();
                string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader;
                using (SqlConnection myCon = new SqlConnection(sqlDataSource))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query, myCon))
                    {
                        myCommand.Parameters.AddWithValue("@CompanyName", cons.CompanyName);
                        myCommand.Parameters.AddWithValue("@Email", cons.Email);
                        myCommand.Parameters.AddWithValue("@Conatctno", cons.Conatctno);
                        myCommand.Parameters.AddWithValue("@password", cons.password);
                        myReader = myCommand.ExecuteReader();
                        table.Load(myReader);
                        myReader.Close();
                        myCon.Close();
                    }
                }
           
            return new JsonResult("Added Successfully");
            }


            [HttpPut]
            public JsonResult Put(consultantinfo cons)
            {
                string query = @"
                           update dbo.Consultantinfo
                           set CompanyName=@CompanyName,
                            Conatctno=@Conatctno,
                            Email=@Email,
                            Address=@Address,
                            email=@email,
                            City=@City,
                            websitelink=@websitelink,
                            companylogo=@companylogo,
                            consultancyservices=@consultancyservices,
                            service=@service,
                            Detail=@Detail,
                            mapaddress=@mapaddress,
                  
                            
                            where EmployeeId=@EmployeeId
                            ";

                DataTable table = new DataTable();
                string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader;
                using (SqlConnection myCon = new SqlConnection(sqlDataSource))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query, myCon))
                    {
                    myCommand.Parameters.AddWithValue("@CompanyName", cons.CompanyName);
                    myCommand.Parameters.AddWithValue("@Conatctno", cons.Conatctno);
                    myCommand.Parameters.AddWithValue("@Email", cons.Email);
                    myCommand.Parameters.AddWithValue("@Address", cons.Address);
                    myCommand.Parameters.AddWithValue("@City", cons.City);
                    myCommand.Parameters.AddWithValue("@websitelink", cons.websitelink);
                    myCommand.Parameters.AddWithValue("@companylogo", cons.companylogo);
                    myCommand.Parameters.AddWithValue("@consultancyservices", cons.consultancyservices);
                    myCommand.Parameters.AddWithValue("@service", cons.service);
                    myCommand.Parameters.AddWithValue("@Detail", cons.Detail);
                    myCommand.Parameters.AddWithValue("@mapaddress", cons.mapaddress);
                    myReader = myCommand.ExecuteReader();
                        table.Load(myReader);
                        myReader.Close();
                        myCon.Close();
                    }
                }

                return new JsonResult("Updated Successfully");
            }

            [HttpDelete("{id}")]
            public JsonResult Delete(int id)//query edit
            {
                string query = @"
                           delete from dbo.Consultantinfo
                            where EmployeeId=@EmployeeId
                            ";

                DataTable table = new DataTable();
                string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
                SqlDataReader myReader;
                using (SqlConnection myCon = new SqlConnection(sqlDataSource))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query, myCon))
                    {
                        myCommand.Parameters.AddWithValue("@EmployeeId", id);

                        myReader = myCommand.ExecuteReader();
                        table.Load(myReader);
                        myReader.Close();
                        myCon.Close();
                    }
                }

                return new JsonResult("Deleted Successfully");
            }


           
        }
}
