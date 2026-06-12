using System.Net.NetworkInformation;

namespace OracuMundial2026.Web.Models.ApiFootballModels
{
    public class ApiFixture
    {
        public long Id { get; set; }
        public DateTimeOffset? Date { get; set; }
        public ApiVenue? Venue { get; set; }
        public ApiStatus? Status { get; set; }
    }
}
