using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class Lesson
	{
		[Key]
		public int LessonId { get; set; }
		public string LessonName { get; set; }
	}
}

