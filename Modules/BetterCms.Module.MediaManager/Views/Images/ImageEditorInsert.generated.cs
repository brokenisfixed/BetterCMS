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
    
    #line 4 "..\..\Views\Images\ImageEditorInsert.cshtml"
    using BetterCms.Module.MediaManager.Content.Resources;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Images\ImageEditorInsert.cshtml"
    using BetterCms.Module.MediaManager.Controllers;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\Images\ImageEditorInsert.cshtml"
    using BetterCms.Module.MediaManager.Models;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Images\ImageEditorInsert.cshtml"
    using BetterCms.Module.MediaManager.ViewModels.Images;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Images\ImageEditorInsert.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Images\ImageEditorInsert.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Images/ImageEditorInsert.cshtml")]
    public partial class _Views_Images_ImageEditorInsert_cshtml : System.Web.Mvc.WebViewPage<ImageViewModel>
    {
        public _Views_Images_ImageEditorInsert_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"bcms-scroll-window\"");

WriteLiteral(" style=\"height: 942px;\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 11 "..\..\Views\Images\ImageEditorInsert.cshtml"
Write(Html.TabbedContentMessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"bcms-file-manager-inner bcms-clearfix\"");

WriteLiteral(">\r\n");

            
            #line 13 "..\..\Views\Images\ImageEditorInsert.cshtml"
        
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Images\ImageEditorInsert.cshtml"
         using (Html.BeginForm<ImagesController>(f => f.ImageEditor((ImageViewModel)null), FormMethod.Post, new { @class = "bcms-ajax-form", @enctype = "multipart/form-data" }))
        {
            
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Images\ImageEditorInsert.cshtml"
       Write(Html.HiddenFor(model => model.Id));

            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                              
            
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Images\ImageEditorInsert.cshtml"
       Write(Html.HiddenFor(model => model.Version, new { @id = "image-version-field" }));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                                                                        


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                            Write(MediaGlobalization.ImageEditor_Dialog_SubTitle);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n");

            
            #line 21 "..\..\Views\Images\ImageEditorInsert.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-croped-block\"");

WriteLiteral(">\r\n                <img");

WriteLiteral(" class=\"bcms-crop-image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 1060), Tuple.Create("\"", 1076)
            
            #line 23 "..\..\Views\Images\ImageEditorInsert.cshtml"
, Tuple.Create(Tuple.Create("", 1066), Tuple.Create<System.Object, System.Int32>(Model.Url
            
            #line default
            #line hidden
, 1066), false)
);

WriteLiteral(" data-id=\"");

            
            #line 23 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                                                  Write(Model.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-version=\"");

            
            #line 23 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                                                                           Write(Model.Version);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" />\r\n            </div>\r\n");

            
            #line 25 "..\..\Views\Images\ImageEditorInsert.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-edit-file-info\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-file-info-text\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 28 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                                Write(MediaGlobalization.ImageEditor_Dialog_PublicUrl);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-edit-file-info\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" class=\"bcms-editor-field-box bcms-editor-selectable-field-box\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1521), Tuple.Create("\"", 1539)
            
            #line 30 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                 , Tuple.Create(Tuple.Create("", 1529), Tuple.Create<System.Object, System.Int32>(Model.Url
            
            #line default
            #line hidden
, 1529), false)
);

WriteLiteral(" readonly=\"readonly\"");

WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 35 "..\..\Views\Images\ImageEditorInsert.cshtml"
               Write(Html.Tooltip(MediaGlobalization.ImageEditor_Dialog_Caption_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 36 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                                Write(MediaGlobalization.ImageEditor_Dialog_Caption);

            
            #line default
            #line hidden
WriteLiteral(":</div>\r\n");

WriteLiteral("                    ");

            
            #line 37 "..\..\Views\Images\ImageEditorInsert.cshtml"
               Write(Html.TextBoxFor(f => f.Caption, new { @class = "bcms-editor-field-box", @id = "Caption" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-file-info-text\"");

WriteLiteral("><b>");

            
            #line 40 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                               Write(MediaGlobalization.ImageEditor_Dialog_FileName);

            
            #line default
            #line hidden
WriteLiteral(":</b> <span");

WriteLiteral(" id=\"image-file-name\"");

WriteLiteral(">");

            
            #line 40 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                                                                                                               Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</span></div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-file-info-text\"");

WriteLiteral("><b>");

            
            #line 42 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                               Write(MediaGlobalization.ImageEditor_Dialog_FileSize);

            
            #line default
            #line hidden
WriteLiteral(":</b> <span");

WriteLiteral(" id=\"image-file-size\"");

WriteLiteral(">");

            
            #line 42 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                                                                                                               Write(Model.FileSize);

            
            #line default
            #line hidden
WriteLiteral("</span></div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-file-info-text\"");

WriteLiteral(">\r\n");

            
            #line 45 "..\..\Views\Images\ImageEditorInsert.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Images\ImageEditorInsert.cshtml"
                     if (Model.CroppedWidth != Model.OriginalImageWidth || Model.CroppedHeight != Model.OriginalImageHeight)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <b>");

            
            #line 47 "..\..\Views\Images\ImageEditorInsert.cshtml"
                      Write(MediaGlobalization.ImageEditor_Dialog_CroppedDimensions);

            
            #line default
            #line hidden
WriteLiteral(":</b>\r\n");

            
            #line 48 "..\..\Views\Images\ImageEditorInsert.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <b>");

            
            #line 51 "..\..\Views\Images\ImageEditorInsert.cshtml"
                      Write(MediaGlobalization.ImageEditor_Dialog_Dimensions);

            
            #line default
            #line hidden
WriteLiteral(":</b>\r\n");

            
            #line 52 "..\..\Views\Images\ImageEditorInsert.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <span");

WriteLiteral(" id=\"image-dimensions\"");

WriteLiteral(">");

            
            #line 53 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                           Write(Model.CroppedWidth);

            
            #line default
            #line hidden
WriteLiteral(" x ");

            
            #line 53 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                                                 Write(Model.CroppedHeight);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n");

            
            #line 56 "..\..\Views\Images\ImageEditorInsert.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-file-alignment\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 58 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                            Write(MediaGlobalization.ImageEditor_Dialog_AligmentTitle);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-alignment-controls\"");

WriteLiteral(">\r\n                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 3195), Tuple.Create("\"", 3292)
, Tuple.Create(Tuple.Create("", 3203), Tuple.Create("bcms-align-center", 3203), true)
            
            #line 60 "..\..\Views\Images\ImageEditorInsert.cshtml"
, Tuple.Create(Tuple.Create("", 3220), Tuple.Create<System.Object, System.Int32>(Model.ImageAlign == MediaImageAlign.Center ? "-active" : string.Empty
            
            #line default
            #line hidden
, 3220), false)
);

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" id=\"aligncenter\"");

WriteLiteral(" name=\"ImageAlign\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3374), Tuple.Create("\"", 3412)
            
            #line 61 "..\..\Views\Images\ImageEditorInsert.cshtml"
       , Tuple.Create(Tuple.Create("", 3382), Tuple.Create<System.Object, System.Int32>((int)MediaImageAlign.Center
            
            #line default
            #line hidden
, 3382), false)
);

WriteLiteral(" ");

            
            #line 61 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                                                                                                  Write(Model.ImageAlign == MediaImageAlign.Center ? "checked" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral(">\r\n                    </div>\r\n                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 3541), Tuple.Create("\"", 3634)
, Tuple.Create(Tuple.Create("", 3549), Tuple.Create("bcms-align-left", 3549), true)
            
            #line 63 "..\..\Views\Images\ImageEditorInsert.cshtml"
, Tuple.Create(Tuple.Create("", 3564), Tuple.Create<System.Object, System.Int32>(Model.ImageAlign == MediaImageAlign.Left ? "-active" : string.Empty
            
            #line default
            #line hidden
, 3564), false)
);

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" id=\"alignleft\"");

WriteLiteral(" name=\"ImageAlign\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3714), Tuple.Create("\"", 3750)
            
            #line 64 "..\..\Views\Images\ImageEditorInsert.cshtml"
     , Tuple.Create(Tuple.Create("", 3722), Tuple.Create<System.Object, System.Int32>((int)MediaImageAlign.Left
            
            #line default
            #line hidden
, 3722), false)
);

WriteLiteral(" ");

            
            #line 64 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                                                                                              Write(Model.ImageAlign == MediaImageAlign.Left ? "checked" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral(">\r\n                    </div>\r\n                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 3877), Tuple.Create("\"", 3972)
, Tuple.Create(Tuple.Create("", 3885), Tuple.Create("bcms-align-right", 3885), true)
            
            #line 66 "..\..\Views\Images\ImageEditorInsert.cshtml"
, Tuple.Create(Tuple.Create("", 3901), Tuple.Create<System.Object, System.Int32>(Model.ImageAlign == MediaImageAlign.Right ? "-active" : string.Empty
            
            #line default
            #line hidden
, 3901), false)
);

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" id=\"alignright\"");

WriteLiteral(" name=\"ImageAlign\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4053), Tuple.Create("\"", 4090)
            
            #line 67 "..\..\Views\Images\ImageEditorInsert.cshtml"
      , Tuple.Create(Tuple.Create("", 4061), Tuple.Create<System.Object, System.Int32>((int)MediaImageAlign.Right
            
            #line default
            #line hidden
, 4061), false)
);

WriteLiteral(" ");

            
            #line 67 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                                                                                                Write(Model.ImageAlign == MediaImageAlign.Right ? "checked" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 72 "..\..\Views\Images\ImageEditorInsert.cshtml"
               Write(Html.Tooltip(MediaGlobalization.ImageEditor_Dialog_Description_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 73 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                                Write(MediaGlobalization.ImageEditor_Dialog_Description);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-textarea-box\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 75 "..\..\Views\Images\ImageEditorInsert.cshtml"
                   Write(Html.TextAreaFor(f => f.Description, new
                                                                  {
                                                                      @class = "bcms-editor-field-area",
                                                                      @id = "Description",
                                                                      @style = "width: 380px;",
                                                                      @readonly = "readonly"
                                                                  }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");

            
            #line 85 "..\..\Views\Images\ImageEditorInsert.cshtml"

            if (Model.Tags != null && Model.Tags.Count > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-media-tags-box-holder bcms-clearfix\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 89 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                                Write(MediaGlobalization.ImageEditor_Dialog_Tags_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-single-tag-holder\"");

WriteLiteral(">\r\n");

            
            #line 91 "..\..\Views\Images\ImageEditorInsert.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 91 "..\..\Views\Images\ImageEditorInsert.cshtml"
                         foreach (var tag in Model.Tags)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"bcms-single-tag\"");

WriteLiteral(">");

            
            #line 93 "..\..\Views\Images\ImageEditorInsert.cshtml"
                                                    Write(tag);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 94 "..\..\Views\Images\ImageEditorInsert.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n                </div>\r\n");

            
            #line 97 "..\..\Views\Images\ImageEditorInsert.cshtml"
            }
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n\r\n</div>");

        }
    }
}
#pragma warning restore 1591
