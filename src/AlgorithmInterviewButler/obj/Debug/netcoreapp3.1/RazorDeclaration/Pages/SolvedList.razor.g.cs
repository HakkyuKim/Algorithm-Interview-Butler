#pragma checksum "C:\Users\Hakkyu Kim\Desktop\Study\알고리즘-인터뷰-집사\src\AlgorithmInterviewButler\Pages\SolvedList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4433709a2d33efa15967a588cb9ed08779becf0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AlgorithmInterviewButler.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Hakkyu Kim\Desktop\Study\알고리즘-인터뷰-집사\src\AlgorithmInterviewButler\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hakkyu Kim\Desktop\Study\알고리즘-인터뷰-집사\src\AlgorithmInterviewButler\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hakkyu Kim\Desktop\Study\알고리즘-인터뷰-집사\src\AlgorithmInterviewButler\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hakkyu Kim\Desktop\Study\알고리즘-인터뷰-집사\src\AlgorithmInterviewButler\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hakkyu Kim\Desktop\Study\알고리즘-인터뷰-집사\src\AlgorithmInterviewButler\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hakkyu Kim\Desktop\Study\알고리즘-인터뷰-집사\src\AlgorithmInterviewButler\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hakkyu Kim\Desktop\Study\알고리즘-인터뷰-집사\src\AlgorithmInterviewButler\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hakkyu Kim\Desktop\Study\알고리즘-인터뷰-집사\src\AlgorithmInterviewButler\_Imports.razor"
using AlgorithmInterviewButler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hakkyu Kim\Desktop\Study\알고리즘-인터뷰-집사\src\AlgorithmInterviewButler\_Imports.razor"
using AlgorithmInterviewButler.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Hakkyu Kim\Desktop\Study\알고리즘-인터뷰-집사\src\AlgorithmInterviewButler\_Imports.razor"
using AlgorithmInterviewButler.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Hakkyu Kim\Desktop\Study\알고리즘-인터뷰-집사\src\AlgorithmInterviewButler\_Imports.razor"
using AlgorithmInterviewButler.View;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/solved-list")]
    public partial class SolvedList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Hakkyu Kim\Desktop\Study\알고리즘-인터뷰-집사\src\AlgorithmInterviewButler\Pages\SolvedList.razor"
      
  ItemsList solved = new ItemsList();
  
  protected override void OnInitialized(){
    solved.Title = "Solved Problems";
    solved.ListItems = new List<InterviewProblem>{
        InterviewProblem.CreateTestData(),
        InterviewProblem.CreateTestData(),
        InterviewProblem.CreateTestData()
      };
  }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
