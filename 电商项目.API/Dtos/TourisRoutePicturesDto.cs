namespace 电商项目.API.Dtos
{
    public class TourisRoutePicturesDto
    {
        public int Id { get; set; }

        public string Url { get; set; } = String.Empty;

        public Guid TouristRouteId { get; set; }
    }
}
