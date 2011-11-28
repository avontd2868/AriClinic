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
	public partial class Patient : Person
	{
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
		
		private IList<AppointmentInfo> appointments = new List<AppointmentInfo>();
		public virtual IList<AppointmentInfo> Appointments 
		{ 
		    get
		    {
		        return this.appointments;
		    }
		}
		
		private IList<DiagnosticAssigned> diagnosticAssigneds = new List<DiagnosticAssigned>();
		public virtual IList<DiagnosticAssigned> DiagnosticAssigneds 
		{ 
		    get
		    {
		        return this.diagnosticAssigneds;
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
		
		private IList<ExaminationAssigned> examinationAssigneds = new List<ExaminationAssigned>();
		public virtual IList<ExaminationAssigned> ExaminationAssigneds 
		{ 
		    get
		    {
		        return this.examinationAssigneds;
		    }
		}
		
		private IList<LabTestAssigned> labTestAssigneds1 = new List<LabTestAssigned>();
		public virtual IList<LabTestAssigned> LabTestAssigneds 
		{ 
		    get
		    {
		        return this.labTestAssigneds1;
		    }
		}
		
		private IList<ProcedureAssigned> procedureAssigneds = new List<ProcedureAssigned>();
		public virtual IList<ProcedureAssigned> ProcedureAssigneds 
		{ 
		    get
		    {
		        return this.procedureAssigneds;
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
