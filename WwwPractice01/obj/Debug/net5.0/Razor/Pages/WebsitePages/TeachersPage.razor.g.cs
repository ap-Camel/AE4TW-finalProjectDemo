#pragma checksum "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\WebsitePages\TeachersPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5655fb0cc9f9dd51ef3c8f6cb188a74b915c82da"
// <auto-generated/>
#pragma warning disable 1591
namespace WwwPractice01.Pages.WebsitePages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using WwwPractice01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\_Imports.razor"
using WwwPractice01.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\WebsitePages\TeachersPage.razor"
using WwwPracticeDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\WebsitePages\TeachersPage.razor"
using WwwPracticeDb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\WebsitePages\TeachersPage.razor"
using WwwPractice01.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/TeachersPage")]
    public partial class TeachersPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Teachers Page</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h4>insert new teacher</h4>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\WebsitePages\TeachersPage.razor"
                  newTeacher

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\WebsitePages\TeachersPage.razor"
                                              InsertTeachers

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "id", "firstName");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\WebsitePages\TeachersPage.razor"
                                           newTeacher.firstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTeacher.firstName = __value, newTeacher.firstName))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newTeacher.firstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "id", "lastName");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\WebsitePages\TeachersPage.razor"
                                          newTeacher.lastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTeacher.lastName = __value, newTeacher.lastName))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newTeacher.lastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n\r\n    ");
                __builder2.AddMarkupContent(22, "<button type=\"submit\" class=\"btn btn-primary\">submit</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n\r\n");
            __builder.AddMarkupContent(24, "<h4> current teachers</h4>");
#nullable restore
#line 24 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\WebsitePages\TeachersPage.razor"
 if (teachers is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "<p><em>loading ...</em></p>");
#nullable restore
#line 27 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\WebsitePages\TeachersPage.razor"
} else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "table");
            __builder.AddAttribute(27, "class", "table table-striped");
            __builder.AddMarkupContent(28, "<thead><tr><th>id</th>\r\n                <th>first name</th>\r\n                <th>last name</th></tr></thead>\r\n        ");
            __builder.OpenElement(29, "tbody");
#nullable restore
#line 38 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\WebsitePages\TeachersPage.razor"
             foreach (var t in teachers)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "tr");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 41 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\WebsitePages\TeachersPage.razor"
                     t.PersonID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 42 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\WebsitePages\TeachersPage.razor"
                     t.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 43 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\WebsitePages\TeachersPage.razor"
                     t.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\WebsitePages\TeachersPage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\WebsitePages\TeachersPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\Ayman\source\repos\WwwPractice01\WwwPractice01\Pages\WebsitePages\TeachersPage.razor"
       
    private List<TeachersModel> teachers;
    private DisplayTeachersPagesModel newTeacher = new DisplayTeachersPagesModel();

    protected override async Task OnInitializedAsync()
    {
        teachers = await _db.GetTeachers();
    }

    private async Task InsertTeachers()
    {
        TeachersModel t = new TeachersModel
        {
            PersonID = 9,
            firstName = newTeacher.firstName,
            lastName = newTeacher.lastName
        };

        await _db.InsertTeacher(t);

        teachers.Add(t);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITeacherData _db { get; set; }
    }
}
#pragma warning restore 1591
