using OracuMundial2026.Web.Probability;

namespace OracuMundial2026.Web.Models
{
    public class TournamentProjection
    {
        public DateTimeOffset GeneratedAt { get; set; } = DateTimeOffset.UtcNow;
        public int Simulations { get; set; }
        public string ModelName { get; set; }
        public string InputSummaryHash { get; set; }
        public IReadOnlyList<TeamTournamentProbability> Teams { get; init; } = Array.Empty<TeamTournamentProbability>();
    }
}
