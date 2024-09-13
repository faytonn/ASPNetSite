namespace ASPNETSite.DataAccessLayer.Entities
{
    public class Teacher : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<TeacherGroup>? TeacherGroups { get; set; } = new List<TeacherGroup>();


    }
}
