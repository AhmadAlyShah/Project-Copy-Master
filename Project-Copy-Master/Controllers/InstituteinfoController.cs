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
    public class InstituteinfoController : Controller
    {
        private readonly IConfiguration _configuration;
        public InstituteinfoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public JsonResult Get()
        {
            string query = @"
                            select institutename,email,websitelink,country,details
                            from
                            dbo.Instituteinfo
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


        [HttpPost]
        public JsonResult Post(Instituteinfo inst)
        {

            //Contactno
            string query = @"
                           insert into dbo.Instituteinfo
                           (institutename,email,Contactno,password)
                    values (@institutename,@email,@Contactno,@password)
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@institutename", inst.institutename);
                    myCommand.Parameters.AddWithValue("@email", inst.email);
                    myCommand.Parameters.AddWithValue("@password", inst.password);
                    myCommand.Parameters.AddWithValue("@Contactno", inst.password);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            
            return new JsonResult("Added Successfully");
        }


        [HttpPut]
        public JsonResult Put(Instituteinfo inst)
        {
            string query = @"
                           update dbo.Instituteinfo
                           set institutename=@institutename,
                            email=@email,
                            websitelink=@websitelink,
                            country=@country,
                            details=@details,
                            
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
                    myCommand.Parameters.AddWithValue("@institutename", inst.institutename);
                    myCommand.Parameters.AddWithValue("@email", inst.email);
                    myCommand.Parameters.AddWithValue("@websitelink", inst.websitelink);
                    myCommand.Parameters.AddWithValue("@country", inst.country);
                    myCommand.Parameters.AddWithValue("@details", inst.details);

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
                           delete from dbo.Instituteinfo
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
