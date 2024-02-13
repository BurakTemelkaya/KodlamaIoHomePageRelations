using Entitities.Abstracts;

namespace Entitities.Concretes
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
