using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback1.Models
{
	public class FeedbackListViewModel
	{
		/* list of requests from your team */
		public IList<FeedbackRequest> YourTeamFeedbackRequests { get; set; }

		/* list of requests for feedback from other teams */
		public IList<FeedbackRequest> OtherTeamFeedbackRequests { get; set; }


	}




	public class FeedbackRequest
	{
		public int FeedbackRequestId { get; set; }

		public string FromTeam { get; set; }

		public string ToTeam { get; set; }

		public string Title { get; set; }
		public string Description { get; set; }

		public DateTime RequestedDateTime { get; set; }

		public DateTime RepliedDateTime { get; set; }

		public DateTime ReviewedDateTime { get; set; }

		public int? RateExperience { get; set; }

		public string RateWentWell { get; set; }

		public string RateWentWellNot { get; set; }

		public string RateOneImprovement { get; set; }

		public string Status { get; set; }

		public string Direction  { get; set; }
	}
}
