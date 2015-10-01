namespace mmoManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account
    {
        public Account()
        {
            Characters = new HashSet<Character>();
        }

        public int AccountID { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountName { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountEmail { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountPW { get; set; }

        public bool AccountStatus { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
    }
}
