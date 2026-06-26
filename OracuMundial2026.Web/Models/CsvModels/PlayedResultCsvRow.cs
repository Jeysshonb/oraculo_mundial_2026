using CsvHelper.Configuration.Attributes;

namespace OracuMundial2026.Web.Models.CsvModels
{
    public class PlayedResultCsvRow
    {
        [Name("HomeTeam")]
        public string HomeTeam { get; set; } = "";
        [Name("AwayTeam")]
        public string AwayTeam { get; set; } = "";
        [Name("HomeGoals")]
        public string HomeGoals { get; set; } = "";
        [Name("AwayGoals")]
        public string AwayGoals { get; set; } = "";
    }
}
