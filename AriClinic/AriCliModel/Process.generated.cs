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


namespace AriCliModel	
{
	public partial class Process
	{
		private int processId;
		public virtual int ProcessId 
		{ 
		    get
		    {
		        return this.processId;
		    }
		    set
		    {
		        this.processId = value;
		    }
		}
		
		private string name;
		public virtual string Name 
		{ 
		    get
		    {
		        return this.name;
		    }
		    set
		    {
		        this.name = value;
		    }
		}
		
		private string description;
		public virtual string Description 
		{ 
		    get
		    {
		        return this.description;
		    }
		    set
		    {
		        this.description = value;
		    }
		}
		
		private string code;
		public virtual string Code 
		{ 
		    get
		    {
		        return this.code;
		    }
		    set
		    {
		        this.code = value;
		    }
		}
		
		private Process parentProcess;
		public virtual Process ParentProcess 
		{ 
		    get
		    {
		        return this.parentProcess;
		    }
		    set
		    {
		        this.parentProcess = value;
		    }
		}
		
		private IList<Permission> permissions = new List<Permission>();
		public virtual IList<Permission> Permissions 
		{ 
		    get
		    {
		        return this.permissions;
		    }
		}
		
		private IList<Process> processes = new List<Process>();
		public virtual IList<Process> Processes 
		{ 
		    get
		    {
		        return this.processes;
		    }
		}
		
	}
}
