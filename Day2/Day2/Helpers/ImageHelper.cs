using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2.Helpers {
    public static class ImageHelper {

        public static MvcHtmlString Image(this HtmlHelper helper, string id, string url) {
            var builder = new TagBuilder("img");

            builder.GenerateId(id);


            builder.MergeAttribute("src", url);

            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));

        }

    }
}

















