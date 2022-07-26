using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CV.DAL.Infraestructure;

namespace CV.DAL.Entities
{
    public class EmployeeProjectEntity : HasId
    {
        public int EmployeeId { get; set; }

        public int ProjectId { get; set; }

#nullable disable
        public List<EmployeeEntity> EmployeeList { get; set; }

        public ProjectEntity Project { get; set; }
#nullable enable
    }
}
