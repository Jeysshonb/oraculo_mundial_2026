using CsvHelper.Configuration.Attributes;

namespace OracuMundial2026.Web.Models.CsvModels
{
    public class GroupCsvRow
    {
        [Name("group")]
        public string Group { get; set; } = "";
        [Name("team")]
        public string Team { get; set; } = "";
    }
}
