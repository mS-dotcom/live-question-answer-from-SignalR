using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class Exam
	{
		[Key]
		public int ExamId { get; set; }

		public string name { get; set; }



	}
}

