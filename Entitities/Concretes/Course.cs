namespace Entitities.Concretes
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
    }
}
