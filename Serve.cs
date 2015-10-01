namespace mmoManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Serve
    {
        public Serve()
        {
            Guilds = new HashSet<Guild>();
        }

        [Key]
        public int ServerID { get; set; }

        [Required]
        [StringLength(8)]
        public string ServerName { get; set; }

        [Required]
        [StringLength(20)]
        public string ServerRegion { get; set; }

        public bool ServerStatus { get; set; }

        public virtual ICollection<Guild> Guilds { get; set; }
    }
}
