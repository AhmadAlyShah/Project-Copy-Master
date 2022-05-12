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
    public class addsinfoController : Controller
    {
        private readonly IConfiguration _configuration;
        public addsinfoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public JsonResult Get()
        {
            string query = @"
                            select 
                            title,Countries,Educationlevel,detail,imageurl
                            from
                            dbo.addsinfo
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
        public JsonResult Post(addsinfo adds)
        {
            string query = @"
                           insert into dbo.addsinfo
                           (title,Countries,Educationlevel,detail,imageurl)
                    values (@title,@ShortDescription,@Countries,@detail,@imageurl)
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@title", adds.title);
                    myCommand.Parameters.AddWithValue("@Countries", adds.Countries);
                    myCommand.Parameters.AddWithValue("@Educationlevel", adds.Educationallevel);
                    myCommand.Parameters.AddWithValue("@detail", adds.detail);
                    myCommand.Parameters.AddWithValue("@imageurl", adds.imageurl);



                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }


        [HttpPut]
        public JsonResult Put(addsinfo adds)
        {
            string query = @"
                           update dbo.addsinfo
                           set title=@title,
                            Countries=@Countries,
                            Educationlevel=@Educationlevel,
                            
                            detail=@detail,
                            imageurl=@imageurl,
                            
                  
                            
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
                    myCommand.Parameters.AddWithValue("@title", adds.title);
                    myCommand.Parameters.AddWithValue("@Countries", adds.Countries);
                    myCommand.Parameters.AddWithValue("@Educationlevel", adds.Educationallevel);
                    myCommand.Parameters.AddWithValue("@detail", adds.detail);
                    myCommand.Parameters.AddWithValue("@imageurl", adds.imageurl);

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
                           delete from dbo.addsinfo
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
