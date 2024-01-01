using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class Session
	{
		[Key]
		public int SessionId { get; set; }

		public int ExamId { get; set; }

		public DateTime dateTime { get; set; }

		public int FirstUserId { get; set; }

		public int SecondUserId { get; set; }
	}
}

