﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Sample.Web.Pages;

public class IndexModel : SamplePageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
