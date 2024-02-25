using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
	public class SessionQuestion
	{
		public int SessionQuestionId { get; set; }

		[ForeignKey("Session")]
		public int SessionId { get; set; }

		public Session session { get; set; }

		[ForeignKey("Question")]
		public int QuestionId { get; set; }
		public Question Question { get; set; }

		public int QuestionNumber { get; set; }

		public IList<Answer> answers { get; set; }
	}
}