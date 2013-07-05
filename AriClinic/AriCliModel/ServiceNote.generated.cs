#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
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
	public partial class ServiceNote
	{
		private decimal total;
		public virtual decimal Total
		{
			get
			{
				return this.total;
			}
			set
			{
				this.total = value;
			}
		}
		
		private int serviceNoteId;
		public virtual int ServiceNoteId
		{
			get
			{
				return this.serviceNoteId;
			}
			set
			{
				this.serviceNoteId = value;
			}
		}
		
		private DateTime serviceNoteDate;
		public virtual DateTime ServiceNoteDate
		{
			get
			{
				return this.serviceNoteDate;
			}
			set
			{
				this.serviceNoteDate = value;
			}
		}
		
		private int oftAno;
		public virtual int Oft_Ano
		{
			get
			{
				return this.oftAno;
			}
			set
			{
				this.oftAno = value;
			}
		}
		
		private int oftNumNota;
		public virtual int Oft_NumNota
		{
			get
			{
				return this.oftNumNota;
			}
			set
			{
				this.oftNumNota = value;
			}
		}
		
		private decimal paid;
		public virtual decimal Paid
		{
			get
			{
				return this.paid;
			}
			set
			{
				this.paid = value;
			}
		}
		
		private Invoice invoice;
		public virtual Invoice Invoice
		{
			get
			{
				return this.invoice;
			}
			set
			{
				this.invoice = value;
			}
		}
		
		private ProfessionalInvoice professionalInvoice;
		public virtual ProfessionalInvoice ProfessionalInvoice
		{
			get
			{
				return this.professionalInvoice;
			}
			set
			{
				this.professionalInvoice = value;
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
		
		private Professional professional;
		public virtual Professional Professional
		{
			get
			{
				return this.professional;
			}
			set
			{
				this.professional = value;
			}
		}
		
		private Customer customer;
		public virtual Customer Customer
		{
			get
			{
				return this.customer;
			}
			set
			{
				this.customer = value;
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
		
		private IList<GeneralPayment> generalPayments = new List<GeneralPayment>();
		public virtual IList<GeneralPayment> GeneralPayments
		{
			get
			{
				return this.generalPayments;
			}
		}
		
	}
}
#pragma warning restore 1591
