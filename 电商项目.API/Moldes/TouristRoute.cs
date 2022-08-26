namespace 电商项目.API
{
    /// <summary>
    /// 旅游路线
    /// </summary>
    public class TouristRoute
    {
        public Guid Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }
        //原价
        public decimal OriginaPrice { get; set; }
        //折扣
        public double DiscountPresent { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
        //出发时间
        public DateTime DepartureTime { get; set; }
        //卖点介绍
        public string? Feature { get; set; }
        //费用说明
        public string? Fees { get; set; }

        public string? Notes { get; set; }

        public ICollection<TouristRoutePicture>? TouristRoutePictures { get; set; }
    }
}
