using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Addressar.Models
{
	public class Addressari
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[Display (Name= "Name")]
		public string Name { get; set; }
		[Required]
		[Display(Name = "Surname")]
		public string Surname { get; set; }
		[Required]
		[Display(Name = "Street Address")]
		public string StreetAddress { get; set; }
		[Required]
		[Display(Name = "City")]
		public string City { get; set; }
		[Required]
		[Display(Name = "Zip Code")]
		public string ZipCode { get; set; }
		[Display(Name = "Home Phone")]
		public string HomePhone { get; set; }
		[Display(Name = "Cell Phone")]
		public string CellPhone { get; set; }
		[Display(Name = "Work Phone")]
		public string WorkPhone { get; set; }
		[Display(Name = "E-mail")]
		public string Email { get; set; }
	}
}