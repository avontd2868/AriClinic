#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;


namespace AriCliModel	
{
	public partial class Log
	{
		private int logId;
		public virtual int LogId 
		{ 
		    get
		    {
		        return this.logId;
		    }
		    set
		    {
		        this.logId = value;
		    }
		}
		
		private DateTime stamp;
		public virtual DateTime Stamp 
		{ 
		    get
		    {
		        return this.stamp;
		    }
		    set
		    {
		        this.stamp = value;
		    }
		}
		
		private string remoteAddress;
		public virtual string RemoteAddress 
		{ 
		    get
		    {
		        return this.remoteAddress;
		    }
		    set
		    {
		        this.remoteAddress = value;
		    }
		}
		
		private string page;
		public virtual string Page 
		{ 
		    get
		    {
		        return this.page;
		    }
		    set
		    {
		        this.page = value;
		    }
		}
		
		private string action;
		public virtual string Action 
		{ 
		    get
		    {
		        return this.action;
		    }
		    set
		    {
		        this.action = value;
		    }
		}
		
		private User user;
		public virtual User User 
		{ 
		    get
		    {
		        return this.user;
		    }
		    set
		    {
		        this.user = value;
		    }
		}
		
	}
}
