namespace mmoManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Guild
    {
        public int GuildID { get; set; }

        [Required]
        [StringLength(20)]
        public string GuildName { get; set; }

        public int ServerID { get; set; }

        public virtual Serve Serve { get; set; }
    }
}
