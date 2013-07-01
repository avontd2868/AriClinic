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
	public partial class Request
	{
		private int requestId;
		public virtual int RequestId 
		{ 
		    get
		    {
		        return this.requestId;
		    }
		    set
		    {
		        this.requestId = value;
		    }
		}
		
		private DateTime requestDateTime;
		public virtual DateTime RequestDateTime 
		{ 
		    get
		    {
		        return this.requestDateTime;
		    }
		    set
		    {
		        this.requestDateTime = value;
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
		
		private string surname1;
		public virtual string Surname1 
		{ 
		    get
		    {
		        return this.surname1;
		    }
		    set
		    {
		        this.surname1 = value;
		    }
		}
		
		private string surname2;
		public virtual string Surname2 
		{ 
		    get
		    {
		        return this.surname2;
		    }
		    set
		    {
		        this.surname2 = value;
		    }
		}
		
		private string dni;
		public virtual string Dni 
		{ 
		    get
		    {
		        return this.dni;
		    }
		    set
		    {
		        this.dni = value;
		    }
		}
		
		private string email;
		public virtual string Email 
		{ 
		    get
		    {
		        return this.email;
		    }
		    set
		    {
		        this.email = value;
		    }
		}
		
		private string telephone;
		public virtual string Telephone 
		{ 
		    get
		    {
		        return this.telephone;
		    }
		    set
		    {
		        this.telephone = value;
		    }
		}
		
		private DateTime bornDate;
		public virtual DateTime BornDate 
		{ 
		    get
		    {
		        return this.bornDate;
		    }
		    set
		    {
		        this.bornDate = value;
		    }
		}
		
		private string sex;
		public virtual string Sex 
		{ 
		    get
		    {
		        return this.sex;
		    }
		    set
		    {
		        this.sex = value;
		    }
		}
		
		private string postalCode;
		public virtual string PostalCode 
		{ 
		    get
		    {
		        return this.postalCode;
		    }
		    set
		    {
		        this.postalCode = value;
		    }
		}
		
		private string comments;
		public virtual string Comments 
		{ 
		    get
		    {
		        return this.comments;
		    }
		    set
		    {
		        this.comments = value;
		    }
		}
		
		private string status;
		public virtual string Status 
		{ 
		    get
		    {
		        return this.status;
		    }
		    set
		    {
		        this.status = value;
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
		
		private Patient patient;
		public virtual Patient Patient 
		{ 
		    get
		    {
		        return this.patient;
		    }
		    set
		    {
		        this.patient = value;
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
		
		private Service service;
		public virtual Service Service 
		{ 
		    get
		    {
		        return this.service;
		    }
		    set
		    {
		        this.service = value;
		    }
		}
		
		private Campaign campaign;
		public virtual Campaign Campaign 
		{ 
		    get
		    {
		        return this.campaign;
		    }
		    set
		    {
		        this.campaign = value;
		    }
		}
		
		private Channel channel;
		public virtual Channel Channel 
		{ 
		    get
		    {
		        return this.channel;
		    }
		    set
		    {
		        this.channel = value;
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
		
		private IList<Replay> replays = new List<Replay>();
		public virtual IList<Replay> Replays 
		{ 
		    get
		    {
		        return this.replays;
		    }
		}
		
		private IList<Estimate> estimates = new List<Estimate>();
		public virtual IList<Estimate> Estimates 
		{ 
		    get
		    {
		        return this.estimates;
		    }
		}
		
	}
}