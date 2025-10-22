using System.Net.Mail;

namespace Demo.PL.Utility
{
	public static class EmailSettings
	{
		public static bool SendEmail(Email email) {
			try
			{
				var client = new SmtpClient("smtp.gmail.com", 587)
				{
					Credentials = new System.Net.NetworkCredential("mohanedmohamed267@gmail.com", "wttz igcn qvcp pnlk"),
					EnableSsl = true
				};
				client.Send("mohanedmohamed267@gmail.com",email.To,email.Subject,email.Body);
				return true;
			}
			catch (Exception)
			{

				return false;
			}
		}
	}
}
