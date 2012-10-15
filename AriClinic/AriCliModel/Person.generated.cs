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
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using AriCliModel;


namespace AriCliModel	
{
	public partial class Person
	{
		private int personId;
		public virtual int PersonId 
		{ 
		    get
		    {
		        return this.personId;
		    }
		    set
		    {
		        this.personId = value;
		    }
		}
		
		private string fullName;
		public virtual string FullName 
		{ 
		    get
		    {
		        return this.fullName;
		    }
		    set
		    {
		        this.fullName = value;
		    }
		}
		
		private Source source;
		public virtual Source Source 
		{ 
		    get
		    {
		        return this.source;
		    }
		    set
		    {
		        this.source = value;
		    }
		}
		
		private IList<Address> addresses = new List<Address>();
		public virtual IList<Address> Addresses 
		{ 
		    get
		    {
		        return this.addresses;
		    }
		}
		
		private IList<Telephone> telephones = new List<Telephone>();
		public virtual IList<Telephone> Telephones 
		{ 
		    get
		    {
		        return this.telephones;
		    }
		}
		
		private IList<Email> emails = new List<Email>();
		public virtual IList<Email> Emails 
		{ 
		    get
		    {
		        return this.emails;
		    }
		}
		
	}
}
