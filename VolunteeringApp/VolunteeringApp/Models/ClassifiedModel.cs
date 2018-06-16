namespace VolunteeringApp.Models
{
    public class ClassifiedModel
    {
        public int Id { get; set; }

        public int OrganizationId { get; set; }

        public int ClassifiedDetailsId { get; set; }

        public string Subtitle { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }
    }
}