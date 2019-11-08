using System;

namespace SharedLibrary.Models
{
    public class EntityModelBase
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
