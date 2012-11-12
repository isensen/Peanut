using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;

namespace Peanut
{
    /// <summary>
    /// Copyright © henryfan 2012		 
    /// Email:	henryfan@msn.com	
    /// HomePage:	http://www.ikende.com		
    /// CreateTime:	2012/11/11 22:41:33
    /// </summary>
    public class OutputObject:IResult
    {
        public OutputObject(object data, OutputContractAttribute handler)
        {
            mData = data;
            mHandler = handler;
            mContext = WebContext.Current;
        }

        private WebContext mContext;

        public string this[string name]
        {
            get
            {
                return mContext.Response.Headers[name];
            }
            set
            {
                mContext.Response.Headers[name] = value;
            }
        }

        private object mData;

        private OutputContractAttribute mHandler;

        public void Execute()
        {
            if (mHandler != null)
            {

                mHandler.Execute(mContext.Response.OutputStream, mData);
                mContext.Response.Flush();
                mContext.Response.End();
            }
        }
    }
}
