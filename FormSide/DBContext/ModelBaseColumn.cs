using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSide.DBContext
{

    [NotMapped]
    public class ModelBaseColumn
    {
        [Column("createdBy")]
        public long CreatedBy { get; set; }

        [Column("createdDate")]
        public DateTime CreatedDate { get; set; }

        [Column("editedBy")]
        public long EditedBy { get; set; }

        [Column("EditedDate")]
        public DateTime EditedDate { get; set; }

        [Column("deleteBy")]
        public long DeleteBy { get; set; }

        [Column("deleteDate")]
        public DateTime DeleteDate { get; set; }
    }
}
