using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Module03Week01.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }
		public string Details { get; set; }

		public virtual List<Product> Products { get; set; }
	}
}