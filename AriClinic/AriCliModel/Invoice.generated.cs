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
	public partial class Invoice
	{
		private int invoiceId;
		public virtual int InvoiceId
		{
			get
			{
				return this.invoiceId;
			}
			set
			{
				this.invoiceId = value;
			}
		}
		
		private DateTime invoiceDate;
		public virtual DateTime InvoiceDate
		{
			get
			{
				return this.invoiceDate;
			}
			set
			{
				this.invoiceDate = value;
			}
		}
		
		private string serial;
		public virtual string Serial
		{
			get
			{
				return this.serial;
			}
			set
			{
				this.serial = value;
			}
		}
		
		private int year;
		public virtual int Year
		{
			get
			{
				return this.year;
			}
			set
			{
				this.year = value;
			}
		}
		
		private int invoiceNumber;
		public virtual int InvoiceNumber
		{
			get
			{
				return this.invoiceNumber;
			}
			set
			{
				this.invoiceNumber = value;
			}
		}
		
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
		
		private string invoiceKey;
		public virtual string InvoiceKey
		{
			get
			{
				return this.invoiceKey;
			}
			set
			{
				this.invoiceKey = value;
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
		
		private IList<InvoiceLine> invoiceLines = new List<InvoiceLine>();
		public virtual IList<InvoiceLine> InvoiceLines
		{
			get
			{
				return this.invoiceLines;
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
		
		private IList<AnestheticServiceNote> anestheticServiceNotes = new List<AnestheticServiceNote>();
		public virtual IList<AnestheticServiceNote> AnestheticServiceNotes
		{
			get
			{
				return this.anestheticServiceNotes;
			}
		}
		
	}
}
#pragma warning restore 1591
