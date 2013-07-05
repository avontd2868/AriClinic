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
	public partial class Professional : Person
	{
		private string vATIN;
		public virtual string VATIN
		{
			get
			{
				return this.vATIN;
			}
			set
			{
				this.vATIN = value;
			}
		}
		
		private string type;
		public virtual string Type
		{
			get
			{
				return this.type;
			}
			set
			{
				this.type = value;
			}
		}
		
		private string invoiceSerial;
		public virtual string InvoiceSerial
		{
			get
			{
				return this.invoiceSerial;
			}
			set
			{
				this.invoiceSerial = value;
			}
		}
		
		private decimal commission;
		public virtual decimal Commission
		{
			get
			{
				return this.commission;
			}
			set
			{
				this.commission = value;
			}
		}
		
		private string comercialName;
		public virtual string ComercialName
		{
			get
			{
				return this.comercialName;
			}
			set
			{
				this.comercialName = value;
			}
		}
		
		private string license;
		public virtual string License
		{
			get
			{
				return this.license;
			}
			set
			{
				this.license = value;
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
		
		private bool inactive;
		public virtual bool Inactive
		{
			get
			{
				return this.inactive;
			}
			set
			{
				this.inactive = value;
			}
		}
		
		private TaxWithholdingType taxWithholdingType;
		public virtual TaxWithholdingType TaxWithholdingType
		{
			get
			{
				return this.taxWithholdingType;
			}
			set
			{
				this.taxWithholdingType = value;
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
		
		private IList<AnestheticTicket> anestheticTickets = new List<AnestheticTicket>();
		public virtual IList<AnestheticTicket> AnestheticTickets
		{
			get
			{
				return this.anestheticTickets;
			}
		}
		
		private IList<ProfessionalInvoice> professionalInvoices = new List<ProfessionalInvoice>();
		public virtual IList<ProfessionalInvoice> ProfessionalInvoices
		{
			get
			{
				return this.professionalInvoices;
			}
		}
		
		private IList<AnestheticServiceNote> anestheticServiceNotes2 = new List<AnestheticServiceNote>();
		public virtual IList<AnestheticServiceNote> AnestheticServiceNotes
		{
			get
			{
				return this.anestheticServiceNotes2;
			}
		}
		
		private IList<AnestheticServiceNote> anestheticServiceNotes11 = new List<AnestheticServiceNote>();
		public virtual IList<AnestheticServiceNote> AnestheticServiceNotes1
		{
			get
			{
				return this.anestheticServiceNotes11;
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
		
		private IList<BaseVisit> baseVisits = new List<BaseVisit>();
		public virtual IList<BaseVisit> BaseVisits
		{
			get
			{
				return this.baseVisits;
			}
		}
		
		private IList<Treatment> treatments = new List<Treatment>();
		public virtual IList<Treatment> Treatments
		{
			get
			{
				return this.treatments;
			}
		}
		
		private IList<AppointmentInfo> appointmentInfos = new List<AppointmentInfo>();
		public virtual IList<AppointmentInfo> AppointmentInfos
		{
			get
			{
				return this.appointmentInfos;
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
#pragma warning restore 1591
