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
	public partial class UnitType
	{
		private int unitTypeId;
		public virtual int UnitTypeId
		{
			get
			{
				return this.unitTypeId;
			}
			set
			{
				this.unitTypeId = value;
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
		
		private IList<LabTest> labTests = new List<LabTest>();
		public virtual IList<LabTest> LabTests
		{
			get
			{
				return this.labTests;
			}
		}
		
	}
}
#pragma warning restore 1591
