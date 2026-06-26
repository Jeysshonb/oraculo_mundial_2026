using CsvHelper.Configuration.Attributes;

namespace OracuMundial2026.Web.Models.CsvModels
{
    public class FixtureScheduleCsvRow
    {
        [Name("HomeTeam")]
        public string HomeTeam { get; set; } = "";
        [Name("AwayTeam")]
        public string AwayTeam { get; set; } = "";
        [Name("Kickoff")]
        public string Kickoff { get; set; } = "";
    }
}
