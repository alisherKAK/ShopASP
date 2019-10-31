using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
    public static class HtmlExtension
    {
        public static MvcHtmlString ErrorMessage<TIn, TOut>(this HtmlHelper html, Func<TIn, TOut> func) where TIn : class
        {
            var a = typeof(TIn);
            var attrs = a.GetProperty(typeof(TOut).Name).GetCustomAttributes()
                .ToList()
                .Where(attr => a.BaseType == typeof(ValidationAttribute))
                .Select(at => (ValidationAttribute)at);

            foreach(var attr in attrs)
            {

            }

            var p = new TagBuilder("p");
            p.SetInnerText("Hello");
            p.MergeAttribute("class", "alert alert-primary" );
            return new MvcHtmlString(p.ToString());
        }
    }
}
