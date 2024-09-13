namespace ASPNETSite.DataAccessLayer.Entities
{
    public class Group : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Student>? Students { get; set; } = new List<Student>();
        public ICollection<TeacherGroup>? Teachers { get; set; } = new List<TeacherGroup>();
    }
}
