using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filter.Controller
{
    public class NumberValidater : Peanut.FilterAttribute
    {
        public override void Execute(Peanut.FilterContext context)
        {
            Root.Default view = (Root.Default)context.View;
            if (Peanut.WebContext.Current.RequestType == Peanut.RequestType.POST)
            {
                if (view.Number !=0)
                {
                    context.Execute();
                }
                else
                {
                    view.Result = "Error number value!";
                }
            }
            else
            {
                context.Execute();
            }

        }
    }
}