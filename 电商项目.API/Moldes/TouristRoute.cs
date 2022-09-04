using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace 电商项目.API.Moldes
{
    /// <summary>
    /// 旅游路线
    /// </summary>
    public class TouristRoute
    {
        [Key]
        public Guid Id { get; set; }
        [Required]/* 必填字段 */ 
        [MaxLength(100)]
        public string Title { get; set; } = String.Empty;
        [Required]
        [MaxLength(1500)]
        public string? Description { get; set; }
        /// <summary>
        /// 原价
        /// </summary>
        [Column(TypeName = "decimal(18,2)")]
        [JsonIgnore()]
        public decimal OriginaPrice { get; set; }
        /// <summary>
        /// 折扣
        /// </summary>
        [Range(0.0, 1.0)]
        [JsonIgnore()]
        public double? DiscountPresent { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 出发时间
        /// </summary>
        public DateTime DepartureTime { get; set; }
        /// <summary>
        /// 卖点介绍
        /// </summary>
        [MaxLength]
        public string Feature { get; set; } = String.Empty;
        /// <summary>
        /// 费用说明
        /// </summary>
        [MaxLength]
        public string Fees { get; set; } = String.Empty;
        [MaxLength]
        public string Notes { get; set; } = String.Empty;

        public ICollection<TouristRoutePicture> TouristRoutePictures { get; set; } = new List<TouristRoutePicture>();
        /// <summary>
        /// 评分
        /// </summary>
        public double? Rating { get; set; }
        /// <summary>
        /// 旅游天数
        /// </summary>
        public TravelDays? TravelDays { get; set; }

        public TripType? TripType { get; set; }

        public DeparTureCity? DeparTureCity { get; set; }
    }
}
