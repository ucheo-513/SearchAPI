using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PartSearchAPI.Database_Model
{
    public class Part
    {
        /// <summary>
        /// Part Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Part name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// additive manufacturing part number
        /// </summary>
        public string PartNumber { get; set; }

        /// <summary>
        /// Part's image URL
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Part's Status 
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Part's Status Id 
        /// </summary>
        public int StatusId { get; set; }
    }
}
