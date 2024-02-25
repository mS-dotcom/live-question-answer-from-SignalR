using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
	public class User
	{
		[Key]
		public int UserId { get; set; }

		public string username { get; set; }

		public string password { get; set; }


		public string Name { get; set; }

		public int Gender { get; set; }


		public string? userPP { get; set; }

		[ForeignKey("Exam")]
		public int ExamId { get; set; }

		public Exam exam { get; set; }

		public string? Token { get; set; }

		public bool IsAvaible { get; set; }

		public DateTime IsAvaibleTime { get; set; }

		public IList<Answer> answers { get; set; }

		public IList<GeneralPoint> generalPoints { get; set; }

		public IList<Session> sessions { get; set; }
	}
}

