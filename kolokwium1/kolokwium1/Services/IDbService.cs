using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kolokwium1.Models;

namespace kolokwium1.Services
{
    interface IDbService
    {
        public Project GetTask(string Index);
        public List<Project> GetStudents();
    }
}
