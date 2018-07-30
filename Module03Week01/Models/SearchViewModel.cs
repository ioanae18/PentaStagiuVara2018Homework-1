using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Module03Week01.Models
{
	public class SearchViewModel
	{
		[DisplayName("search query *")]
		[Required]
		public string Query { get; set; }
	}
}