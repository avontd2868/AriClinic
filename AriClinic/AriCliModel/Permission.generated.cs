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
	public partial class Permission
	{
		private int permissionId;
		public virtual int PermissionId 
		{ 
		    get
		    {
		        return this.permissionId;
		    }
		    set
		    {
		        this.permissionId = value;
		    }
		}
		
		private bool view;
		public virtual bool View 
		{ 
		    get
		    {
		        return this.view;
		    }
		    set
		    {
		        this.view = value;
		    }
		}
		
		private bool modify;
		public virtual bool Modify 
		{ 
		    get
		    {
		        return this.modify;
		    }
		    set
		    {
		        this.modify = value;
		    }
		}
		
		private bool create;
		public virtual bool Create 
		{ 
		    get
		    {
		        return this.create;
		    }
		    set
		    {
		        this.create = value;
		    }
		}
		
		private bool execute;
		public virtual bool Execute 
		{ 
		    get
		    {
		        return this.execute;
		    }
		    set
		    {
		        this.execute = value;
		    }
		}
		
		private UserGroup userGroup;
		public virtual UserGroup UserGroup 
		{ 
		    get
		    {
		        return this.userGroup;
		    }
		    set
		    {
		        this.userGroup = value;
		    }
		}
		
		private Process process;
		public virtual Process Process 
		{ 
		    get
		    {
		        return this.process;
		    }
		    set
		    {
		        this.process = value;
		    }
		}
		
	}
}
