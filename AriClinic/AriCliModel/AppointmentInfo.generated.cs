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
	public partial class AppointmentInfo
	{
		private int appointmentId;
		public virtual int AppointmentId
		{
			get
			{
				return this.appointmentId;
			}
			set
			{
				this.appointmentId = value;
			}
		}
		
		private DateTime beginDateTime;
		public virtual DateTime BeginDateTime
		{
			get
			{
				return this.beginDateTime;
			}
			set
			{
				this.beginDateTime = value;
			}
		}
		
		private DateTime endDateTime;
		public virtual DateTime EndDateTime
		{
			get
			{
				return this.endDateTime;
			}
			set
			{
				this.endDateTime = value;
			}
		}
		
		private DateTime arrival;
		public virtual DateTime Arrival
		{
			get
			{
				return this.arrival;
			}
			set
			{
				this.arrival = value;
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
		
		private string recurrence;
		public virtual string Recurrence
		{
			get
			{
				return this.recurrence;
			}
			set
			{
				this.recurrence = value;
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
		
		private int duration;
		public virtual int Duration
		{
			get
			{
				return this.duration;
			}
			set
			{
				this.duration = value;
			}
		}
		
		private string subject;
		public virtual string Subject
		{
			get
			{
				return this.subject;
			}
			set
			{
				this.subject = value;
			}
		}
		
		private AppointmentType appointmentType;
		public virtual AppointmentType AppointmentType
		{
			get
			{
				return this.appointmentType;
			}
			set
			{
				this.appointmentType = value;
			}
		}
		
		private Diary diary;
		public virtual Diary Diary
		{
			get
			{
				return this.diary;
			}
			set
			{
				this.diary = value;
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
		
		private AppointmentInfo fatherAppointment;
		public virtual AppointmentInfo FatherAppointment
		{
			get
			{
				return this.fatherAppointment;
			}
			set
			{
				this.fatherAppointment = value;
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
		
		private IList<AppointmentInfo> childrenAppointments = new List<AppointmentInfo>();
		public virtual IList<AppointmentInfo> ChildrenAppointments
		{
			get
			{
				return this.childrenAppointments;
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
		
	}
}
#pragma warning restore 1591
