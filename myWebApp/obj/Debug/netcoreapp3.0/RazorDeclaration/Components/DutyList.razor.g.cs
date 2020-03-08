#pragma checksum "C:\myWebApp\Components\DutyList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9df928f54557292c436a433a7ca30594c4e11aab"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace myWebApp.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\myWebApp\Components\DutyList.razor"
using myWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\myWebApp\Components\DutyList.razor"
using myWebApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\myWebApp\Components\DutyList.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\myWebApp\Components\DutyList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class DutyList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\myWebApp\Components\DutyList.razor"
 
    Duty selectedDuty;
    string selectedDutyId;

    void SelectDuty(string dutyId)
    {
      selectedDutyId = dutyId;
      selectedDuty = DutyService.GetDuties().First(x => x.Id == dutyId);
      GetCurrentRating();
    }

    int currentRating = 0;
    int voteCount = 0;
    string voteLabel;

    void GetCurrentRating()
    {
      if(selectedDuty.Ratings == null)
      {
        currentRating = 0;
        voteCount = 0;
      }
      else
      {
        voteCount = selectedDuty.Ratings.Count();
        voteLabel = voteCount > 1 ? "Votes" : "Vote";
        currentRating = selectedDuty.Ratings.Sum() / voteCount;
      }

      System.Console.WriteLine($"Current rating for {selectedDuty.Id}: {currentRating}");
    }

    void SubmitRating(int rating)
    {
      System.Console.WriteLine($"Rating received for {selectedDuty.Id}: {rating}");
      DutyService.AddRating(selectedDutyId, rating);
      SelectDuty(selectedDutyId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileDutyService DutyService { get; set; }
    }
}
#pragma warning restore 1591