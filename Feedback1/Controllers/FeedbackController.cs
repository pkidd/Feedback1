using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Feedback1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Feedback1.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult List()
        {
	        var model = new FeedbackListViewModel()
	        {
		        YourTeamFeedbackRequests = new List<FeedbackRequest>()
		        {
			        new FeedbackRequest(){FromTeam = "Your team", ToTeam = "Strategy Planning", Title = "Request 1", RequestedDateTime = DateTime.Today, Description = "desc 1 hsagdhag jsahd gadsjh asdh ", Status = "Started"},
			        new FeedbackRequest(){FromTeam = "Your team", ToTeam = "IT Software Development", Title = "Request 2", RequestedDateTime = DateTime.Today, Description = "desc 2 hsagdhag jsahd gadsjh asdh ", Status = "Posted"},
			        new FeedbackRequest(){FromTeam = "Your team", ToTeam = "Finance", Title = "Request 1", RequestedDateTime = DateTime.Today, Description = "desc 3 hsagdhag jsahd gadsjh asdh " , Status = "Feedback Available"},
	       
										},

		        OtherTeamFeedbackRequests = new List<FeedbackRequest>()
										{ 
		        new FeedbackRequest() { FromTeam = "Human Resources", ToTeam = "Your team", Title = "Request 1", RequestedDateTime = DateTime.Today, Description = "desc 1 hsagdhag jsahd gadsjh asdh ", Status = "1 week old"},
	        new FeedbackRequest() { FromTeam = "IT Software Development", ToTeam = "Your team", Title = "Request 2", RequestedDateTime = DateTime.Today, Description = "desc 2 hsagdhag jsahd gadsjh asdh ",Status = "2 days old" },
	        new FeedbackRequest() { FromTeam = "IT Infrastructure", ToTeam = "Your team", Title = "Request 1", RequestedDateTime = DateTime.Today, Description = "desc 3 hsagdhag jsahd gadsjh asdh " ,Status = "new"},
										}
									};

	     



			return View(model);
        }

	    public IActionResult Item()
	    {
		    var model = new FeedbackRequest()
		    {
			    FromTeam = "Communications",
			    ToTeam = "Your team",
			    Title = "Request 1"
		    };


						return View(model);
	    }


	    public IActionResult RequestFeedback()
	    {
		    var model = new FeedbackRequest()
		    {
			    FromTeam = "Your team",
			    
		    };


		    return View(model);
	    }

	    public IActionResult GiveFeedback()
	    {
		    var model = new FeedbackRequest()
		    {
			    FromTeam = "Communications",
			    ToTeam = "Your team",
			    Title = "Request 1"
		    };


			return View(model);
	    }

	    public IActionResult ProvidedFeedback()
	    {
		    var model = new FeedbackRequest()
		    {
			    FromTeam = "Communications",
			    ToTeam = "Your team",
			    Title = "Request 1"
		    };


		    return View(model);
	    }


	    public IActionResult TeamNetwork()
	    {
		    var model = new FeedbackRequest()
		    {
			    FromTeam = "Communications",
			    ToTeam = "Your team",
			    Title = "Request 1"
		    };
				return View(model);
				}


	    public IActionResult AllNetwork()
	    {
		    var model = new FeedbackRequest()
		    {
			    FromTeam = "All Teams",
			    ToTeam = "All Teams",
			    Title = "Requests"
		    };
		    return View(model);
	    }


  public IActionResult TipsFeedback()
	    {
		    var model = new FeedbackRequest()
		    {
			    FromTeam = "All Teams",
			    ToTeam = "All Teams",
			    Title = "Requests"
		    };
		    return View(model);
	    }

  public IActionResult TopFeedback()
	    {
		    var model = new FeedbackRequest()
		    {
			    FromTeam = "All Teams",
			    ToTeam = "All Teams",
			    Title = "Requests"
		    };
		    return View(model);
	    }

  public IActionResult LatestCompleted()
	    {
		    var model = new FeedbackRequest()
		    {
			    FromTeam = "All Teams",
			    ToTeam = "All Teams",
			    Title = "Requests"
		    };
		    return View(model);
	    }

	}
}