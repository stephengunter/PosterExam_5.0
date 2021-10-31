using Infrastructure.Entities;

namespace ApplicationCore.Models.Data
{
    public class TermNotes : BaseDocument
    {
        public int SubjectId { get; set; }

        public int TermId { get; set; }

        public string RQIds { get; set; } //歷屆試題

        public string QIds { get; set; } //普通試題
    }
}
