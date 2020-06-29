using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Addressar.Models
{
	public class AddressarContext:DbContext
	{
		public  DbSet<Addressari> Addressars { get; set; }
		public AddressarContext() : base("Default Connection") { }

		public static AddressarContext Create()
		{
			return new AddressarContext();
		}
	}
}