using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityMvc5.Controllers
{
	[Authorize]
    public class CustomersController : Controller
    {
		[Authorize(Users = "elvis,bob")]
        public string SecretName()
		{
			return "This is the secret customer name.";
		}

		[AllowAnonymous]
		public string PublicName()
		{
			return "This is the public customer name.";
		}
	}
}