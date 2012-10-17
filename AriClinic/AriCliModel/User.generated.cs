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
	public partial class User
	{
		private int userId;
		public virtual int UserId 
		{ 
		    get
		    {
		        return this.userId;
		    }
		    set
		    {
		        this.userId = value;
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
		
		private string login;
		public virtual string Login 
		{ 
		    get
		    {
		        return this.login;
		    }
		    set
		    {
		        this.login = value;
		    }
		}
		
		private string password;
		public virtual string Password 
		{ 
		    get
		    {
		        return this.password;
		    }
		    set
		    {
		        this.password = value;
		    }
		}
		
		private int profile;
		public virtual int Profile 
		{ 
		    get
		    {
		        return this.profile;
		    }
		    set
		    {
		        this.profile = value;
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
		
		private IList<InvoiceLine> invoiceLines = new List<InvoiceLine>();
		public virtual IList<InvoiceLine> InvoiceLines 
		{ 
		    get
		    {
		        return this.invoiceLines;
		    }
		}
		
		private IList<Payment> payments = new List<Payment>();
		public virtual IList<Payment> Payments 
		{ 
		    get
		    {
		        return this.payments;
		    }
		}
		
		private IList<Professional> professionals = new List<Professional>();
		public virtual IList<Professional> Professionals 
		{ 
		    get
		    {
		        return this.professionals;
		    }
		}
		
		private IList<AppointmentInfo> appointments = new List<AppointmentInfo>();
		public virtual IList<AppointmentInfo> Appointments 
		{ 
		    get
		    {
		        return this.appointments;
		    }
		}
		
		private IList<Log> logs1 = new List<Log>();
		public virtual IList<Log> Logs 
		{ 
		    get
		    {
		        return this.logs1;
		    }
		}
		
		private IList<AnestheticServiceNote> anestheticServiceNotes = new List<AnestheticServiceNote>();
		public virtual IList<AnestheticServiceNote> AnestheticServiceNotes 
		{ 
		    get
		    {
		        return this.anestheticServiceNotes;
		    }
		}
		
		private IList<Ticket> tickets1 = new List<Ticket>();
		public virtual IList<Ticket> Tickets 
		{ 
		    get
		    {
		        return this.tickets1;
		    }
		}
		
		private IList<ServiceNote> serviceNotes = new List<ServiceNote>();
		public virtual IList<ServiceNote> ServiceNotes 
		{ 
		    get
		    {
		        return this.serviceNotes;
		    }
		}
		
	}
}
