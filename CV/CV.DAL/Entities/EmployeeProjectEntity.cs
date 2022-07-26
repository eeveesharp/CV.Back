namespace CV.DAL.Entities
{
    public class EmployeeProjectEntity
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }
#nullable disable
        public List<EmployeeEntity> Employee { get; set; }
#nullable enable
        public int ProjectId { get; set; }
#nullable disable
        public List<ProjectEntity> Project { get; set; }

        public string Position { get; set; }
#nullable enable
    }
}
