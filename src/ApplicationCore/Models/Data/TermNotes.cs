using Infrastructure.Entities;

namespace ApplicationCore.Models.Data
{
    public class TermNotes : BaseDocument
    {
        public int SubjectId { get; set; }

        public int TermId { get; set; }
    }
}
