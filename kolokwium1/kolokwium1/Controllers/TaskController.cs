using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using kolokwium1.Models;
using kolokwium1.DTOs;

namespace kolokwium1.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class TaskController : ControllerBase
    {


        [HttpGet("{id}")]
        public IActionResult GetTask()
        {
            var list = new List<Project>();
            using (var client = new SqlConnection("Data Source=db-mssql;Initial Catalog=s18780;Integrated Security=True"))
            using (var com = new SqlCommand())
            {
                try
                {
                    com.Connection = client;
                    com.CommandText = "Select project.idProject,project.name,project.deadline,tasktype.name from project inner join task ON project.idproject=task.idproject inner join tasktype on task.idtasktype=tasktype.idtasktype where project.idProject=@id order by deadline DESC;";
                    client.Open();
                    var dr = com.ExecuteReader();
                    // String project = "";
                    while (dr.Read())
                    {
                        Project pr = new Project();
                        pr.idProject = dr["idProject"].ToString();
                        pr.name = dr["name"].ToString();
                        pr.deadline = dr["deadline"].ToString();
                        pr.Taskname = dr["Taskname"].ToString();
                        list.Add(pr);

                        // project = project + project.ToString() + "\n";

                    }
                    return Ok(list);
                }
                catch (SqlException sql)
                {
                    return BadRequest("Nie prawidłowe id");
                }
            }
        }
        [HttpPost]
        public IActionResult addTask(TaskRequest request)
        {

            try
            {
                using (SqlConnection client = new SqlConnection("Data Source = db-mssql; Initial Catalog=s18780; Integrated Security=True"))
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = client;
                    client.Open();
                    com.CommandText = "Insert Into Project (idProject, name, deadline) Values (Max(idProject)+1, @name, @deadline)";


                    com.Parameters.AddWithValue("name", request.name);
                    com.Parameters.AddWithValue("deadline", request.deadline);
                  
                   
                  com.ExecuteNonQuery();
                    return Ok();
                }
            }
            catch (SqlException ex)
            {
                return BadRequest("Bledne dane");
            }
        }
}