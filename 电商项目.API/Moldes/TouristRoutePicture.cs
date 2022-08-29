using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace 电商项目.API.Moldes
{
    /// <summary>
    /// 旅游路线照片类
    /// </summary>
    public class TouristRoutePicture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]/* ID 自动产生，自动管理 */
        public int Id { get; set; }
        [MaxLength(100)]
        public string Url { get; set; } = String.Empty;
        [ForeignKey("TouristRouteId")]/* 外键关联 */
        public Guid TouristRouteId { get; set; }

        public TouristRoute TouristRoute { get; set; } = new();
    }
}
