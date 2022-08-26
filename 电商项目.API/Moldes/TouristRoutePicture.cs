namespace 电商项目.API
{
    /// <summary>
    /// 旅游路线照片类
    /// </summary>
    public class TouristRoutePicture
    {
        public int Id { get; set; }

        public string? Url { get; set; }

        public Guid TouristRouteId { get; set; }

        public TouristRoute? TouristRoute { get; set; }
    }
}
