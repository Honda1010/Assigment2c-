using System.ComponentModel.DataAnnotations;

namespace Demo.PL.ViewModels
{
	public class ResetPasswordViewModel
	{
		[Required(ErrorMessage ="Check Password")]
		[DataType(DataType.Password)]
		public string password { get; set; }
		[Required(ErrorMessage = "Check Confirm Password")]
		[DataType(DataType.Password)]
		[Compare("password", ErrorMessage ="Not Match")]
		public string confirmPassword { get; set; }
	}
}
