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


namespace AriCliModel	
{
	public partial class BackGinecology
	{
		private int backGinecologyId;
		public virtual int BackGinecologyId 
		{ 
		    get
		    {
		        return this.backGinecologyId;
		    }
		    set
		    {
		        this.backGinecologyId = value;
		    }
		}
		
		private string menstrualFormula;
		public virtual string MenstrualFormula 
		{ 
		    get
		    {
		        return this.menstrualFormula;
		    }
		    set
		    {
		        this.menstrualFormula = value;
		    }
		}
		
		private string menarche;
		public virtual string Menarche 
		{ 
		    get
		    {
		        return this.menarche;
		    }
		    set
		    {
		        this.menarche = value;
		    }
		}
		
		private string menopause;
		public virtual string Menopause 
		{ 
		    get
		    {
		        return this.menopause;
		    }
		    set
		    {
		        this.menopause = value;
		    }
		}
		
		private int abortions;
		public virtual int Abortions 
		{ 
		    get
		    {
		        return this.abortions;
		    }
		    set
		    {
		        this.abortions = value;
		    }
		}
		
		private int cesareanDeliveries;
		public virtual int CesareanDeliveries 
		{ 
		    get
		    {
		        return this.cesareanDeliveries;
		    }
		    set
		    {
		        this.cesareanDeliveries = value;
		    }
		}
		
		private int vaginalDeliveries;
		public virtual int VaginalDeliveries 
		{ 
		    get
		    {
		        return this.vaginalDeliveries;
		    }
		    set
		    {
		        this.vaginalDeliveries = value;
		    }
		}
		
		private string content;
		public virtual string Content 
		{ 
		    get
		    {
		        return this.content;
		    }
		    set
		    {
		        this.content = value;
		    }
		}
		
		private DateTime dateOfLastMestrual;
		public virtual DateTime DateOfLastMestrual 
		{ 
		    get
		    {
		        return this.dateOfLastMestrual;
		    }
		    set
		    {
		        this.dateOfLastMestrual = value;
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
		
	}
}