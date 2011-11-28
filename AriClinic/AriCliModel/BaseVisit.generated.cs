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
	public partial class BaseVisit
	{
		private int visitId;
		public virtual int VisitId 
		{ 
		    get
		    {
		        return this.visitId;
		    }
		    set
		    {
		        this.visitId = value;
		    }
		}
		
		private DateTime visitDate;
		public virtual DateTime VisitDate 
		{ 
		    get
		    {
		        return this.visitDate;
		    }
		    set
		    {
		        this.visitDate = value;
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
		
		private string vType;
		public virtual string VType 
		{ 
		    get
		    {
		        return this.vType;
		    }
		    set
		    {
		        this.vType = value;
		    }
		}
		
		private VisitReason visitReason;
		public virtual VisitReason VisitReason 
		{ 
		    get
		    {
		        return this.visitReason;
		    }
		    set
		    {
		        this.visitReason = value;
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
		
		private IList<ExaminationAssigned> examinationAssigneds = new List<ExaminationAssigned>();
		public virtual IList<ExaminationAssigned> ExaminationAssigneds 
		{ 
		    get
		    {
		        return this.examinationAssigneds;
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
		
		private IList<ProcedureAssigned> procedureAssigneds = new List<ProcedureAssigned>();
		public virtual IList<ProcedureAssigned> ProcedureAssigneds 
		{ 
		    get
		    {
		        return this.procedureAssigneds;
		    }
		}
		
		private IList<LabTestAssigned> labTestAssigneds = new List<LabTestAssigned>();
		public virtual IList<LabTestAssigned> LabTestAssigneds 
		{ 
		    get
		    {
		        return this.labTestAssigneds;
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
		
	}
}
