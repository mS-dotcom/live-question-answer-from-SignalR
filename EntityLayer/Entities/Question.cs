using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
	public class Question
	{
		[Key]
		public int QuestionId { get; set; }

		public string? QuestionImage { get; set; }

		public string questionText { get; set; }

		public int questionPoint { get; set; }

		[ForeignKey("Lesson")]
		public int LessonId { get; set; }

		public Lesson Lesson { get; set; }

		public IList<Answer> answers { get; set; }

		public IList<Option> options { get; set; }

		public IList<SessionQuestion> sessionQuestions { get; set; }

	}
}

