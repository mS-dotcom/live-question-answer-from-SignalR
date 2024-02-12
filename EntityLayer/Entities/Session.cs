using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class Session
	{
		[Key]
		public int SessionId { get; set; }

		public int SessionType { get; set; }

		public int ExamId { get; set; }

		public DateTime startedDate { get; set; }

		public DateTime endDate { get; set; }

		public int FirstUserId { get; set; }

		public int FirstPoint { get; set; }

		public int SecondUserId { get; set; }

		public int SecondPoint { get; set; }

		public bool IsEnd { get; set; }

		public int WinnerId { get; set; }
	}

	
}

