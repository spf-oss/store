namespace 电商项目.API.Moldes
{
    /// <summary>
    /// 旅游路线
    /// </summary>
    public class TouristRoute
    {
        public Guid Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }
        /// <summary>
        /// 原价
        /// </summary>
        public decimal OriginaPrice { get; set; }
        /// <summary>
        /// 折扣
        /// </summary>
        public double DiscountPresent { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 出发时间
        /// </summary>
        public DateTime DepartureTime { get; set; }
        /// <summary>
        /// 卖点介绍
        /// </summary>
        public string? Feature { get; set; }
        /// <summary>
        /// 费用说明
        /// </summary>
        public string? Fees { get; set; }

        public string? Notes { get; set; }

        public ICollection<TouristRoutePicture>? TouristRoutePictures { get; set; }
    }
}
