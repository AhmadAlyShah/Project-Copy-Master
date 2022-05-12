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
    public class StudentinfoController : Controller
    {
        private readonly IConfiguration _configuration;
        public StudentinfoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {


            //RENAME COLMUN NAME !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!    Inerestedcountry



            string query = @"
                            select Fullname, Phoneno,Email,Qualification,wanttostudy,Location,Interestedcountry,imageurl
                            from
                            dbo.Studentinfo
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



        //*****************************************************************************************


        // TESTING PROCESS
        [Route("[action]/{email}")]
        [HttpGet]
        public JsonResult GetbyEmail(string email)
        {
            
            string query = @"
                            select Fullname,Phoneno,Qualification,wanttostudy,Location,Interestedcountry,imageurl
                            from
                            dbo.Studentinfo where Email=@Email
                            ";//edit karna

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






        [Route("[action]/{Name}")]
        [HttpGet]
        public JsonResult GetbyName(string Name)
        {

            string query = @"
                            select Phoneno,Qualification,wanttostudy,Location,Interestedcountry,imageurl
                            from
                            dbo.Studentinfo where Fullname=@Fullname
                            ";//edit karna

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Fullname", Name);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }










        //*****************************************************************************************8


       //[HttpGet("{username}/{password}")]

        [HttpPost]
        public JsonResult Post(Studentinfo stu)
        {
            string query = @"
                           insert into dbo.Studentinfo
                           (Fullname, Email,Phoneno,Password)
                    values (@Fullname,@Email, @Phoneno,@Password)
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Fullname", stu.fullname);
                    myCommand.Parameters.AddWithValue("@Phoneno", stu.phone);
                    myCommand.Parameters.AddWithValue("@Email", stu.email);
                    myCommand.Parameters.AddWithValue("@Password", stu.Password);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            
            return new JsonResult("Added Successfully");
        }


        [HttpPut]
        public JsonResult Put(Studentinfo stu)
        {
            string query = @"
                           update dbo.Studentinfo
                           set fullname= @fullname,
                            Phoneno=@Phoneno,
                            Email=@Email,
                            Qualification=@Qualification,
                            wanttostudy=@wanttostudy,
                            Location=@Location,
                            Interestedcountry=@Interestedcountry,
                            imageurl=@imageurl
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
                    myCommand.Parameters.AddWithValue("@fullname", stu.fullname);
                    myCommand.Parameters.AddWithValue("@Phoneno", stu.phone);
                    myCommand.Parameters.AddWithValue("@Email", stu.email);
                   
                    myCommand.Parameters.AddWithValue("@Qualification", stu.qual);
                    myCommand.Parameters.AddWithValue("@wanttostudy", stu.wanttostudy);
                    myCommand.Parameters.AddWithValue("@Location", stu.location);
                    myCommand.Parameters.AddWithValue("@Interestedcountry", stu.interestedcountry);
                    myCommand.Parameters.AddWithValue("@imageurl", stu.imageurl);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Updated Successfully");
        }

        [HttpDelete("{Email}")]
        public JsonResult Delete(String Email)
        {
            string query = @"
                           delete from dbo.Studentinfo
                            where Email=@Email
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Email", Email);

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
