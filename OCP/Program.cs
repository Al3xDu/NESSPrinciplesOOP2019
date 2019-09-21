using System;

namespace OCP
{
	using System.Linq;

	internal class Program
	{
		private static void Main(string[] args)
		{
			var sender = new MailSender();

			sender.SendMail(new MailMessage("hello"));
		}
	}

	internal class MailSender
	{
		public void SendMail(MailMessage mailMessage)
		{
			var currentDay = DateTime.Now.DayOfWeek;

			switch (currentDay)
			{
				case DayOfWeek.Monday:
					WithSmtp(mailMessage);
					break;
				case DayOfWeek.Tuesday:
					WithPigeons(mailMessage);
					break;
				case DayOfWeek.Wednesday:
					WithFlyingCarpets(mailMessage);
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		private void WithFlyingCarpets(MailMessage mailMessage)
		{
			throw new NotImplementedException();
		}

		private void WithPigeons(MailMessage mailMessage)
		{
			throw new NotImplementedException();
		}

		private void WithSmtp(MailMessage mailMessage)
		{
			throw new NotImplementedException();
		}
	}

	internal class MailMessage
	{
		public MailMessage(string message) => Message = message;

		public string Message { get; }
	}
}