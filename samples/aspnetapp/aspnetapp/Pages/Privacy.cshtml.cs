using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace aspnetapp.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            long j = 99999, k;
            for (int  i = 0; i < 99999999; i++) {
                 k = ((j*j+1)/(j+1) + (j*j+7)/(j+3) + (j*j+5)/(j+17) + (j*j+23)/(j+19) + (j*j+1)/(j+1) + (j*j+7)/(j+3) + (j*j+5)/(j+17) + (j*j+23)/(j+19))/((j*j+1)/(j+1) + (j*j+7)/(j+3) + (j*j+5)/(j+17) + (j*j+23)/(j+19)+1);
            }
            _logger.LogInformation("### Process complete");
        }
    }
}
