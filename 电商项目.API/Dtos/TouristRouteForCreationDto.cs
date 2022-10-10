namespace 电商项目.API.Dtos
{
    public class TouristRouteForCreationDto
    {
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        // 计算方式：原价 * 折扣
        public decimal Price { get; set; }
        //public decimal OriginalPrice { get; set; }
        //public double? DiscountPresent { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? DepartureTime { get; set; }
        public string Features { get; set; } = String.Empty;
        public string Fees { get; set; } = String.Empty;
        public string Notes { get; set; } = String.Empty;
        public double? Rating { get; set; } 
        public string TravelDays { get; set; } = String.Empty;
        public string TripType { get; set; } = String.Empty;
        public string DepartureCity { get; set; } = String.Empty;
    }
}
