using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class Question
	{
		[Key]
		public int QuestionId { get; set; }

		public string questionText { get; set; }

		public int questionPoint { get; set; }

	}
}

