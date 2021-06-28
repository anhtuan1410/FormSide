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
    [Table("users")]
    public class User 
    {
        public User() { }

        [Column(Order = 0)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdUser { get; set; }

        [Column("username", Order = 1, TypeName = "nvarchar")]
        [MaxLength(200)]
        [Required]
        public string UserName { get; set; }

        [Column("password", Order = 2, TypeName = "nvarchar")]
        [Required]
        public string Password { get; set; }

        [Column("firstname", Order = 3, TypeName = "nvarchar")]
        [MaxLength(500)]
        [Required]
        public string FirstName { get; set; }

        [Column("lastname", Order = 4, TypeName = "nvarchar")]
        [MaxLength(500)]
        [Required]
        public string LastName { get; set; }

        [Column("email", Order = 5, TypeName = "nvarchar")]
        [MaxLength(500)]
        [Required]
        public string Email { get; set; }

        [ForeignKey("UserGroups")]
        public long IdUserGroup { get; set; }

        public virtual UserGroups UserGroups { get; set; }

        [Column("note", TypeName = "nvarchar")]
        [MaxLength(500)]
        public string Note { get; set; }

        [Column("createdBy")]
        public long? CreatedBy { get; set; }

        [Column("createdDate")]       
        [DefaultValue("getdate()")]
        public DateTime? CreatedDate { get; set; }

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
