using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class GeneralPoint
	{
		[Key]
		public int PointId { get; set; }

		public int PointTypeId { get; set; }

		public int Point { get; set; }

		public int UserId { get; set; }

		public User user { get; set; }

		public DateTime dateTime { get; set; }
	}
}