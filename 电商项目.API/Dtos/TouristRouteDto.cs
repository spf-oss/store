using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using 电商项目.API.Moldes;
using Newtonsoft.Json;

namespace 电商项目.API.Dtos
{
    public class TouristRouteDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string? Description { get; set; }
        
        public decimal Price { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 出发时间
        /// </summary>
        public DateTime DepartureTime { get; set; }
        /// <summary>
        /// 卖点介绍
        /// </summary>
        public string Feature { get; set; } = String.Empty;
        /// <summary>
        /// 费用说明
        /// </summary>
        public string Fees { get; set; } = String.Empty;
        [MaxLength]
        public string Notes { get; set; } = String.Empty;
         
        /// <summary>
        /// 评分
        /// </summary>
        public double? Rating { get; set; }
        /// <summary>
        /// 旅游天数
        /// </summary>
        public string? TravelDays { get; set; }

        public string? TripType { get; set; }

        public string? DeparTureCity { get; set; }
    }
}
