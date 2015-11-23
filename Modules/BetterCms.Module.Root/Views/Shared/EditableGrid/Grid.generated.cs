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
    
    #line 1 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/EditableGrid/Grid.cshtml")]
    public partial class _Views_Shared_EditableGrid_Grid_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Shared.EditableGridViewModel>
    {
        public _Views_Shared_EditableGrid_Grid_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
Write(Html.Partial(Model.TopBlockView, Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 5 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
 if (Model.ShowMessages)
{
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
Write(Html.MessagesBox(null, new Dictionary<string, string> { { "data-bind", "attr: { id: messagesDomId() }" } }));

            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                                                                                                                
}

            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
  
    var visibleColumns = Model.Columns.Where(c => c.IsRendered).ToList();
    var visibleColumnsCount = visibleColumns.Count;

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"bcms-tables\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n            <th");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(" style=\"width: 40px; padding: 0;\"");

WriteLiteral(">&nbsp;</th>\r\n");

            
            #line 17 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
            
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
             foreach (var column in visibleColumns)
            {
                
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
           Write(Html.Partial(column.HeaderView, column));

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                                                        
            }

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(">&nbsp;</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <!-- ko foreach: " +
"items -->\r\n        <tr");

WriteLiteral(" data-bind=\"click: onOpen, css: {\'bcms-table-row-active\' : isActive() || isSelect" +
"edForInsert()}, attr: {id: getRowId()}\"");

WriteLiteral(">\r\n            <!-- ko if: saving() || deleting() -->\r\n");

            
            #line 28 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
            
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
             if (Model.CanEditItems)
            {

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(">&nbsp;</td>\r\n");

WriteLiteral("                <!-- ko if: saving() -->\r\n");

WriteLiteral("                <td");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteAttribute("colspan", Tuple.Create(" colspan=\"", 1294), Tuple.Create("\"", 1324)
            
            #line 32 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
, Tuple.Create(Tuple.Create("", 1304), Tuple.Create<System.Object, System.Int32>(visibleColumnsCount
            
            #line default
            #line hidden
, 1304), false)
);

WriteLiteral(">");

            
            #line 32 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                                                                          Write(RootGlobalization.Message_Saving);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("                <!-- /ko -->\r\n");

            
            #line 34 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 35 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
             if (Model.CanEditItems)
            {

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(">&nbsp;</td>\r\n");

WriteLiteral("                <!-- ko if: deleting() -->\r\n");

WriteLiteral("                <td");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteAttribute("colspan", Tuple.Create(" colspan=\"", 1616), Tuple.Create("\"", 1646)
            
            #line 39 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
, Tuple.Create(Tuple.Create("", 1626), Tuple.Create<System.Object, System.Int32>(visibleColumnsCount
            
            #line default
            #line hidden
, 1626), false)
);

WriteLiteral(">");

            
            #line 39 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                                                                          Write(RootGlobalization.Message_Deleting);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("                <!-- /ko -->\r\n");

            
            #line 41 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <!-- /ko -->\r\n            <!-- ko ifnot: saving() || deleting() -->\r\n" +
"");

            
            #line 44 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
            
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
             if (Model.CanEditItems)
            {

            
            #line default
            #line hidden
WriteLiteral("                <td>\r\n                    <!-- ko if: !editingIsDisabled() -->\r\n " +
"                   <div");

WriteLiteral(" class=\"bcms-action-edit\"");

WriteLiteral(" data-bind=\"click: onEdit\"");

WriteLiteral(">");

            
            #line 48 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                                                                       Write(RootGlobalization.Button_Edit);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <!-- /ko -->\r\n                </td>\r\n");

            
            #line 51 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <td>&nbsp;</td>\r\n");

            
            #line 55 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 56 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
             foreach (var column in visibleColumns)
            {
                
            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
           Write(Html.Partial(column.CellView, column));

            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                                                      
            }

            
            #line default
            #line hidden
WriteLiteral("            <td");

WriteLiteral(" data-bind=\"style: { width: isActive() ? \'100px\' : \'40px\', padding: isActive() ? " +
"\'10px\' : \'0\' }\"");

WriteLiteral(">\r\n");

            
            #line 61 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                 if (Model.CanDeleteItems)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"bcms-action-delete\"");

WriteLiteral(" data-bind=\"click: onDelete, visible: !isActive() && !deletingIsDisabled()\"");

WriteLiteral(">");

            
            #line 63 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                                                                                                                          Write(RootGlobalization.Button_Delete);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 64 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 65 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                 if (Model.CanEditItems)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <!-- ko if: isActive() -->\r\n");

WriteLiteral("                    <div");

WriteLiteral(" class=\"bcms-btn-primary\"");

WriteLiteral(" data-bind=\"click: onSave\"");

WriteLiteral(">");

            
            #line 68 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                                                                       Write(Model.SaveButtonTitle);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    <div");

WriteLiteral(" class=\"bcms-btn-cancel\"");

WriteLiteral(" data-bind=\"event : {mousedown: onCancelEdit}\"");

WriteLiteral(">");

            
            #line 69 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                                                                                          Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    <!-- /ko -->\r\n");

            
            #line 71 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 72 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                 if (!Model.CanDeleteItems && !Model.CanEditItems)
                {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral("&nbsp;\r\n");

            
            #line 75 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </td>\r\n            <!-- /ko -->\r\n        </tr>\r\n        <!-- /ko -->\r" +
"\n        <!-- ko if: items().length == 0 -->\r\n        <tr>\r\n            <td");

WriteAttribute("colspan", Tuple.Create(" colspan=\"", 3413), Tuple.Create("\"", 3449)
            
            #line 82 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
, Tuple.Create(Tuple.Create("", 3423), Tuple.Create<System.Object, System.Int32>(visibleColumnsCount + 2
            
            #line default
            #line hidden
, 3423), false)
);

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-table-no-data\"");

WriteLiteral(">");

            
            #line 83 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                                           Write(RootGlobalization.Grid_NoDataAvailable_Message);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </td>\r\n        </tr>\r\n        <!-- /ko -->\r\n    </tbody>\r\n</t" +
"able>\r\n");

            
            #line 89 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
 if (Model.AddHiddenFields)
{

            
            #line default
            #line hidden
WriteLiteral("    <!-- ko foreach: items -->\r\n");

            
            #line 92 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
    foreach (var column in Model.Columns)
    {
        if (!string.IsNullOrWhiteSpace(column.HiddenFieldName))
        {

            
            #line default
            #line hidden
WriteLiteral("            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" data-bind=\"value: ");

            
            #line 96 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                                                                Write(column.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(", attr: {name: hiddenFieldName(\'");

            
            #line 96 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
                                                                                                                   Write(column.HiddenFieldName);

            
            #line default
            #line hidden
WriteLiteral("\', $index()) }\"");

WriteLiteral(">\r\n");

            
            #line 97 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("    <!-- /ko -->\r\n");

            
            #line 100 "..\..\Views\Shared\EditableGrid\Grid.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
