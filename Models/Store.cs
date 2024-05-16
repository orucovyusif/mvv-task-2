using System.ComponentModel.DataAnnotations.Schema;

namespace Mamba_mvc.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Imgurl { get; set; }
        [NotMapped]
        public IFormFile ImgFile { get; set; }
    }
}
