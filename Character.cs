namespace mmoManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Character
    {
        public int CharacterID { get; set; }

        public int AccountID { get; set; }

        [Required]
        [StringLength(50)]
        public string CharName { get; set; }

        [Required]
        [StringLength(50)]
        public string CharClass { get; set; }

        public int CharLevel { get; set; }

        [Required]
        [StringLength(50)]
        public string CharGuild { get; set; }

        public virtual Account Account { get; set; }
    }
}
