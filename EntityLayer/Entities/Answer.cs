using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class Answer
	{
		[Key]
		public int AnswerId { get; set; }

		public int UserId { get; set; }

		public User user { get; set; }

		public int SessionId { get; set; }

		public Session session { get; set; }

		public int QuestionId { get; set; }

		public Question question { get; set; }

		public int OptionId { get; set; }

		public Option option { get; set; }

		public bool IsCorrect { get; set; }

		public int? Point { get; set; }
	}
}