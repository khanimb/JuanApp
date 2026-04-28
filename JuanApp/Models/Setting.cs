using System.ComponentModel.DataAnnotations;
using JuanApp.Models.Common;

namespace JuanApp.Models
{
    public class Setting: BaseEntity
    {
        [Key]
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
