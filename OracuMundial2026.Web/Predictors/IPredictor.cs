using OracuMundial2026.Web.Models;

namespace OracuMundial2026.Web.Predictors
{
    public interface IPredictor
    {
        string Name { get; }
        int Priority { get; }
        MatchPrediction Predict(MatchContext context);
    }
}
