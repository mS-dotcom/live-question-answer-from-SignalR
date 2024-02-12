using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
	public class LessonAndExam
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("Lesson")]
		public int LessonId { get; set; }

		public Lesson lesson { get; set; }

		public int ExamId { get; set; }

		public Exam exam { get; set; }
	}
}