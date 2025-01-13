using System.ComponentModel.DataAnnotations;

namespace org_view.Client.Entities
{
    public class OrgEntities
    {
        [Required]
        [StringLength(10)]
        public string Id { get; set; }
        public string Name { get; set; }
        public int NumberOfEmployee { get; set; }
    }
}