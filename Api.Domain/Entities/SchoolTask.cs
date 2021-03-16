using System;

namespace Api.Domain.Entities
{
    public class SchoolTask : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Students { get; set; }
        public string Subject { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
