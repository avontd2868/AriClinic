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
	public partial class Payment
	{
		private int paymentId;
		public virtual int PaymentId 
		{ 
		    get
		    {
		        return this.paymentId;
		    }
		    set
		    {
		        this.paymentId = value;
		    }
		}
		
		private DateTime paymentDate;
		public virtual DateTime PaymentDate 
		{ 
		    get
		    {
		        return this.paymentDate;
		    }
		    set
		    {
		        this.paymentDate = value;
		    }
		}
		
		private decimal amount;
		public virtual decimal Amount 
		{ 
		    get
		    {
		        return this.amount;
		    }
		    set
		    {
		        this.amount = value;
		    }
		}
		
		private int oftId;
		public virtual int OftId 
		{ 
		    get
		    {
		        return this.oftId;
		    }
		    set
		    {
		        this.oftId = value;
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
		
		private PaymentMethod paymentMethod;
		public virtual PaymentMethod PaymentMethod 
		{ 
		    get
		    {
		        return this.paymentMethod;
		    }
		    set
		    {
		        this.paymentMethod = value;
		    }
		}
		
		private Ticket ticket;
		public virtual Ticket Ticket 
		{ 
		    get
		    {
		        return this.ticket;
		    }
		    set
		    {
		        this.ticket = value;
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
		
		private Clinic clinic;
		public virtual Clinic Clinic 
		{ 
		    get
		    {
		        return this.clinic;
		    }
		    set
		    {
		        this.clinic = value;
		    }
		}
		
	}
}
