using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSide.DBContext
{
    [Table("usergroups")]
    public class UserGroups 
    {
        public UserGroups() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdUserGroup { get; set; }

        [Column("groupname", TypeName = "nvarchar")]
        [MaxLength(500)]
        [Required]
        public string GroupName { get; set; }

        [Column("note", TypeName = "nvarchar")]
        public string Note { get; set; }

        public ICollection<User> Users { get; set; }

        [Column("createdBy")]
        public long? CreatedBy { get; set; } = 0;

        [Column("createdDate")]
        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        [Column("editedBy")]
        public long? EditedBy { get; set; }

        [Column("EditedDate")]
        public DateTime? EditedDate { get; set; }

        [Column("deleteBy")]
        public long? DeleteBy { get; set; }

        [Column("deleteDate")]
        public DateTime? DeleteDate { get; set; }

    }
}
