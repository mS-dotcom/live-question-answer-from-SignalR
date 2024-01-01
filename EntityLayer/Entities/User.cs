using System;
using System.ComponentModel.DataAnnotations;

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
		public int ExamId { get; set; }
		public string? Token { get; set; }

		public bool IsAvaible { get; set; }

		public DateTime IsAvaibleTime { get; set; }

	}
}

