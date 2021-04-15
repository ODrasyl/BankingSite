﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSite.Models
{
	public class Transaction
	{
		public int Id { get; set; }
		public int AccountId{ get; set; }
		public DateTime Date { get; set; }
		public float Amount { get; set; }

		public Account Account { get; set; }
	}
}
