using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
	public class Answer
	{
		[Key]
		public int AnswerId { get; set; }

		[ForeignKey("User")]
		public int UserId { get; set; }

		public User user { get; set; }

		[ForeignKey("Session")]
		public int SessionId { get; set; }

		public Session session { get; set; }

		[ForeignKey("Question")]
		public int QuestionId { get; set; }

		public Question question { get; set; }

		[ForeignKey("Option")]
		public int OptionId { get; set; }

		public Option option { get; set; }


		[ForeignKey("SessionQuestion")]
		public int SessionQuestionId { get; set; }

		public SessionQuestion SessionQuestion { get; set; }

		public bool IsCorrect { get; set; }

		public int? Point { get; set; }
	}
}