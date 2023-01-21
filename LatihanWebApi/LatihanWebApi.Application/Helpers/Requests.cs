using LatihanWebApi.Application.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanWebApi.Application.Helpers
{
    public class Requests
    {
        public static IActionResult Response(ControllerBase controller, ApiStatus apiStatus, object dataValue, string message)
        {
            var e = new ApiStatus(500);

            var _ = new
            {
                status = e.StatusCode,
                error = true,
                detail = "",
                message = e.StatusDescription,
                data = dataValue
            };

            if(apiStatus.StatusCode != 200)
            {
                _ = new
                {
                    status = apiStatus.StatusCode,
                    error = true,
                    detail = "",
                    message = apiStatus.StatusDescription,
                    data = dataValue
                };
            }
            else
            {
                _ = new
                {
                    status = apiStatus.StatusCode,
                    error = true,
                    detail = "",
                    message = apiStatus.StatusDescription,
                    data = dataValue
                };
            }

            return controller.StatusCode(apiStatus.StatusCode, _ );
        }
    }
}
