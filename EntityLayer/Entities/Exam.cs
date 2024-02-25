using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class Exam
	{
		[Key]
		public int ExamId { get; set; }

		public string name { get; set; }

		public IList<LessonAndExam> lessonAndExams { get; set; }

		public IList<Session> sessions { get; set; }

		public IList<User> users { get; set; }
	}
}

