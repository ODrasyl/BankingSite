﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingSite.Models
{
	public class Account
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Number { get; set; }
        public float Balance { get; set; }

        public UserAccount UserAccount { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
    }
}
