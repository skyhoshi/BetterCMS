﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using BetterCms.Core;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using BetterCms.Core.DataContracts.Enums;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using BetterCms.Module.Pages.ViewModels.SiteSettings;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.Extensions;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.TableRenderers;
    
    #line default
    #line hidden
    
    #line 10 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 11 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    using MvcContrib.UI.Grid;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Page/Partial/SiteSettingsPagesList.cshtml")]
    public partial class _Views_Page_Partial_SiteSettingsPagesList_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Filter.PagesGridViewModel<SiteSettingPageViewModel>>
    {
        public _Views_Page_Partial_SiteSettingsPagesList_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("    ");

            
            #line 13 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
     if (Model == null)
    {
        return;
    }

            
            #line default
            #line hidden
WriteLiteral("    \r\n");

WriteLiteral("    ");

            
            #line 18 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
Write(Html.HiddenGridOptions(Model.GridOptions));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 19 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
      
        Action<ColumnBuilder<SiteSettingPageViewModel>> columns = column =>
        {
            if ((ViewContext.Controller as CmsControllerBase).SecurityService.IsAuthorized(RootModuleConstants.UserRoles.MultipleRoles(RootModuleConstants.UserRoles.EditContent, RootModuleConstants.UserRoles.PublishContent)))
            {
                column.EditButtonColumn();
            }
            else
            {
                column.EmptyColumn();
            }

            column.For(m => string.Format("<a class=\"bcms-tables-link bcms-page-title\" data-id=\"{0}\" data-url=\"{2}\"{3}>{1}</a>",
                m.Id, System.Web.Security.AntiXss.AntiXssEncoder.HtmlEncode(m.Title ?? "", true), m.Url,
                (CmsContext.Config.EnableMultilanguage ? string.Format("data-language-id=\"{0}\"", m.LanguageId) : "")))
                .Named(PagesGlobalization.SiteSettings_Pages_TitleColumn)
                .SortColumnName("Title")
                .Attributes()
                .Encode(false);

            column.For(m => m.CreatedOn.ToFormattedDateString())
               .Named(PagesGlobalization.SiteSettings_Pages_CreatedColumn)
               .SortColumnName("CreatedOn")
               .HeaderAttributes(@style => "width: 100px;")
               .Attributes(@class => "bcms-page-created");

            column.For(m => m.ModifiedOn.ToFormattedDateString())
               .Named(PagesGlobalization.SiteSettings_Pages_ModifiedColumn)
               .SortColumnName("ModifiedOn")
               .HeaderAttributes(@style => "width: 100px;")
               .Attributes(@class => "bcms-page-modified");

            column.For(m => Html.EditorFor(e => m.HasSEO, "SEOStatus"))
               .Named(PagesGlobalization.SiteSettings_Pages_HasSeoColumn)
               .SortColumnName("HasSEO")
               .HeaderAttributes(@style => "width: 65px; text-align: center")
               .Attributes(@class => "bcms-page-hasseo");

            column.For(m => Html.EditorFor(e => m.PageStatus, "PageStatus"))
               .Named(PagesGlobalization.SiteSettings_Pages_PageStatusColumn)
               .SortColumnName("PageStatus")
               .HeaderAttributes(@style => "width: 85px; text-align: center")
               .Attributes(@class => "bcms-page-ispublished");

            if ((ViewContext.Controller as CmsControllerBase).SecurityService.IsAuthorized(RootModuleConstants.UserRoles.DeleteContent))
            {
                column.DeleteButtonColumn();
            }
        };
    
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("    ");

            
            #line 70 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
Write(Html.MessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-window-settings\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-top-block-holder\"");

WriteLiteral(">\r\n");

            
            #line 74 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 74 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
             if ((ViewContext.Controller as CmsControllerBase).SecurityService.IsAuthorized(RootModuleConstants.UserRoles.EditContent))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-btn-main\"");

WriteLiteral(" id=\"bcms-create-page-button\"");

WriteLiteral(">");

            
            #line 76 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
                                                                   Write(PagesGlobalization.SiteSettings_Pages_AddNew);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 77 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"bcms-top-block-inner\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-btn-search\"");

WriteLiteral(" id=\"bcms-pages-search-btn\"");

WriteLiteral(">");

            
            #line 80 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
                                                                   Write(PagesGlobalization.SiteSettings_Pages_Search);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-search-block\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 82 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
               Write(Html.TextBoxFor(m => m.SearchQuery, new { @class = "bcms-search-field-box bcms-search-query", @placeholder = RootGlobalization.WaterMark_Search }));

            
            #line default
            #line hidden
WriteLiteral("                      \r\n                </div>\r\n            </div>\r\n\r\n           " +
" <div");

WriteLiteral(" class=\"bcms-top-block-pager\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 87 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
           Write(Html.RenderPaging(Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-top-block-filters\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 92 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
       Write(Html.Partial("~/Areas/bcms-pages/Views/Filter/PagesFilterTemplate.cshtml", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n");

WriteLiteral("        ");

            
            #line 95 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
   Write(Html.Grid(Model.Items).Sort(Model.GridOptions).Columns(columns).Attributes(@class => "bcms-tables").RenderUsing(new EditableHtmlTableGridRenderer<SiteSettingPageViewModel>()));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-pages-list-row-template\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 99 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
   Write(Html.Grid(new List<SiteSettingPageViewModel> { new SiteSettingPageViewModel() }).Columns(columns).Attributes(@class => "bcms-tables").RenderUsing(new HtmlTableGridSingleRowRenderer<SiteSettingPageViewModel>()));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </script>\r\n\r\n    <script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-boolean-true-template\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 103 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
   Write(Html.Partial("EditorTemplates/SEOStatus", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </script>\r\n\r\n    <script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-boolean-false-template\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 107 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
   Write(Html.Partial("EditorTemplates/SEOStatus", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </script>\r\n\r\n    <script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-pagestatus-published-template\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 111 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
   Write(Html.Partial("EditorTemplates/PageStatus", PageStatus.Published));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </script>\r\n\r\n    <script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-pagestatus-unpublished-template\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 115 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
   Write(Html.Partial("EditorTemplates/PageStatus", PageStatus.Unpublished));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </script>\r\n\r\n    <script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-pagestatus-draft-template\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 119 "..\..\Views\Page\Partial\SiteSettingsPagesList.cshtml"
   Write(Html.Partial("EditorTemplates/PageStatus", PageStatus.Draft));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </script>\r\n");

        }
    }
}
#pragma warning restore 1591
