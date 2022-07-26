using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CV.DAL.Infraestructure;

namespace CV.DAL.Entities
{
    public class EmployeeProjectEntity 
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public List<EmployeeEntity> Employee { get; set; }

        public int ProjectId { get; set; }

        public List<ProjectEntity> Project { get; set; }

        public string? Position { get; set; }
    }
}
