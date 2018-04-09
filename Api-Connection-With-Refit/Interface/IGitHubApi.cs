﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Refit;
using Api_Connection_With_Refit.Model;
using System.Threading.Tasks;

namespace Api_Connection_With_Refit.Interface
{
    [Headers("User-Agent: :request:")]
    interface IGitHubApi
    {
        [Get("/search/users?q=location:lagos")]
        Task<ApiResponse> GetUser();
    }
}