namespace ASPNETSite.DataAccessLayer.Entities
{
    public class TeacherGroup : BaseEntity
    {
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public int GroupId { get; set; }
        public Group? Group { get; set; }
    }
}
