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
    public class eventsinfoController : Controller
    {
        
        private readonly IConfiguration _configuration;
        public eventsinfoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public JsonResult Get()
        {
            string query = @"
                            select 
                            title,ShortDescription,Countries,detail,imageurl
                            from
                            dbo.newsandeventsinfo
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
        public JsonResult Post(eventsinfo enet)
        {
            string query = @"
                           insert into dbo.newsandeventsinfo
                           (title,ShortDescription,Countries,detail,imageurl)
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
                    myCommand.Parameters.AddWithValue("@title", enet.title);
                    myCommand.Parameters.AddWithValue("@ShortDescription", enet.ShortDescription);
                    myCommand.Parameters.AddWithValue("@Countries", enet.Countries);
                    myCommand.Parameters.AddWithValue("@detail", enet.detail);
                    myCommand.Parameters.AddWithValue("@imageurl", enet.imageurl);



                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }


        [HttpPut]
        public JsonResult Put(eventsinfo enet)
        {
            string query = @"
                           update dbo.newsandeventsinfo
                           set title=@title,
                            ShortDescription=@ShortDescription,
                            Countries=@Countries,
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
                    myCommand.Parameters.AddWithValue("@title", enet.title);
                    myCommand.Parameters.AddWithValue("@ShortDescription", enet.ShortDescription);
                    myCommand.Parameters.AddWithValue("@Countries", enet.Countries);
                    myCommand.Parameters.AddWithValue("@detail", enet.detail);
                    myCommand.Parameters.AddWithValue("@imageurl", enet.imageurl);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
            
            //query edit
        {
            string query = @"
                           delete from dbo.newsandeventsinfo
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
