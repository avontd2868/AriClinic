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
	public partial class Biometry : ExaminationAssigned
	{
		private string formula;
		public virtual string Formula 
		{ 
		    get
		    {
		        return this.formula;
		    }
		    set
		    {
		        this.formula = value;
		    }
		}
		
		private decimal lioLeftEye;
		public virtual decimal LioLeftEye 
		{ 
		    get
		    {
		        return this.lioLeftEye;
		    }
		    set
		    {
		        this.lioLeftEye = value;
		    }
		}
		
		private decimal lioRightEye;
		public virtual decimal LioRightEye 
		{ 
		    get
		    {
		        return this.lioRightEye;
		    }
		    set
		    {
		        this.lioRightEye = value;
		    }
		}
		
		private decimal alxLeftEye;
		public virtual decimal AlxLeftEye 
		{ 
		    get
		    {
		        return this.alxLeftEye;
		    }
		    set
		    {
		        this.alxLeftEye = value;
		    }
		}
		
		private decimal alxRightEye;
		public virtual decimal AlxRightEye 
		{ 
		    get
		    {
		        return this.alxRightEye;
		    }
		    set
		    {
		        this.alxRightEye = value;
		    }
		}
		
	}
}
