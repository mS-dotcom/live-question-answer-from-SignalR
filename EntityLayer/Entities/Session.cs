using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
	public class Session
	{
		[Key]
		public int SessionId { get; set; }

		public int SessionType { get; set; }

		[ForeignKey("Exam")]
		public int ExamId { get; set; }

		public Exam exam { get; set; }

		public DateTime startedDate { get; set; }

		public DateTime endDate { get; set; }

		[ForeignKey("User")]
		public int FirstUserId { get; set; }

		public User userOne { get; set; }

		public int FirstPoint { get; set; }

		public int SecondUserId { get; set; }

        [ForeignKey("User")]

        public User userTwo { get; set; }

		public int SecondPoint { get; set; }

		public bool IsEnd { get; set; }


		[ForeignKey("User")]
		public int WinnerId { get; set; }

		public User userWinner { get; set; }

		public IList<Answer> answers { get; set; }

		public IList<SessionQuestion> sessionQuestions { get; set; }
	}

	
}

