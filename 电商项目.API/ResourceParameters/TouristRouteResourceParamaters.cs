using System.Text.RegularExpressions;

namespace 电商项目.API.ResourceParameters
{
    public class TouristRouteResourceParamaters
    {
        public string Keyword { get; set; } = String.Empty;
        public string RatingOperator { get; set; } = String.Empty;
        public int? RatingValue { get; set; }
        private string _rating = String.Empty;
        public string Rating
        {
            get { return _rating; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    var regex = new Regex(@"([A-Za-z\-]+)(\d+)");
                    var match = regex.Match(value);
                    if (match.Success)
                    {
                        this.RatingOperator = match.Groups[1].Value;
                        this.RatingValue = Int32.Parse(match.Groups[2].Value);
                    }
                }
                _rating = value;
            }
        }
    }
}
