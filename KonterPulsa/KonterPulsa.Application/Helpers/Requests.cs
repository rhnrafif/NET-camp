using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KonterPulsa.Application.Helpers
{
	public class Requests
	{
		public static IActionResult Response(ControllerBase controller, int statusCode, object dataValue, string msg)
		{
			if(statusCode != 200)
			{
				statusCode = 500;
			}			
			HttpStatusCode parsedCode = (HttpStatusCode)statusCode;
			string desc = parsedCode.ToString();


			var e = new
			{
				status = statusCode,
				error = true,
				data = dataValue,
				msg = msg,
				detail = desc
			};

			if (statusCode != 200)
			{
				e = new
				{
					status = statusCode,
					error = false,
					data = dataValue,
					msg = msg,
					detail = desc
				};
			}
			else
			{
				e = new
				{
					status = statusCode,
					error = false,
					data = dataValue,
					msg = msg,
					detail = desc
				};
			}		
			return controller.StatusCode(statusCode, e);
		}
	}
}
