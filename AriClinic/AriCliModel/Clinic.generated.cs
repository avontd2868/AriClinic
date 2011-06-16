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
	public partial class Clinic
	{
		private int clinicId;
		public virtual int ClinicId 
		{ 
		    get
		    {
		        return this.clinicId;
		    }
		    set
		    {
		        this.clinicId = value;
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
		
		private string remoteIp;
		public virtual string RemoteIp 
		{ 
		    get
		    {
		        return this.remoteIp;
		    }
		    set
		    {
		        this.remoteIp = value;
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
		
		private IList<Ticket> tickets = new List<Ticket>();
		public virtual IList<Ticket> Tickets 
		{ 
		    get
		    {
		        return this.tickets;
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
		
		private IList<AnestheticServiceNote> anestheticServiceNotes = new List<AnestheticServiceNote>();
		public virtual IList<AnestheticServiceNote> AnestheticServiceNotes 
		{ 
		    get
		    {
		        return this.anestheticServiceNotes;
		    }
		}
		
		private IList<ServiceNote> serviceNotes = new List<ServiceNote>();
		public virtual IList<ServiceNote> Service_notes 
		{ 
		    get
		    {
		        return this.serviceNotes;
		    }
		}
		
	}
}
