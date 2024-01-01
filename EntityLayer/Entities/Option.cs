using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class Option
	{
		[Key]
		public int OptionId { get; set; }

		public int QuestionId { get; set; }

		public bool IsCorrect { get; set; }
	}
}

