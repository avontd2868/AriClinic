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
	public partial class AntSegment
	{
		private int id;
		public virtual int Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}
		
		private string conjunctiva;
		public virtual string Conjunctiva
		{
			get
			{
				return this.conjunctiva;
			}
			set
			{
				this.conjunctiva = value;
			}
		}
		
		private string cornea;
		public virtual string Cornea
		{
			get
			{
				return this.cornea;
			}
			set
			{
				this.cornea = value;
			}
		}
		
		private string chamber;
		public virtual string Chamber
		{
			get
			{
				return this.chamber;
			}
			set
			{
				this.chamber = value;
			}
		}
		
		private string tyndall;
		public virtual string Tyndall
		{
			get
			{
				return this.tyndall;
			}
			set
			{
				this.tyndall = value;
			}
		}
		
		private string iris;
		public virtual string Iris
		{
			get
			{
				return this.iris;
			}
			set
			{
				this.iris = value;
			}
		}
		
		private string pupil;
		public virtual string Pupil
		{
			get
			{
				return this.pupil;
			}
			set
			{
				this.pupil = value;
			}
		}
		
		private string crystalline;
		public virtual string Crystalline
		{
			get
			{
				return this.crystalline;
			}
			set
			{
				this.crystalline = value;
			}
		}
		
		private decimal eyestrainRE;
		public virtual decimal EyestrainRE
		{
			get
			{
				return this.eyestrainRE;
			}
			set
			{
				this.eyestrainRE = value;
			}
		}
		
		private decimal eyestrainLE;
		public virtual decimal EyestrainLE
		{
			get
			{
				return this.eyestrainLE;
			}
			set
			{
				this.eyestrainLE = value;
			}
		}
		
		private string eyebrowsComments;
		public virtual string EyebrowsComments
		{
			get
			{
				return this.eyebrowsComments;
			}
			set
			{
				this.eyebrowsComments = value;
			}
		}
		
		private OphthalmologicVisit ophthalmologicVisit;
		public virtual OphthalmologicVisit OphthalmologicVisit
		{
			get
			{
				return this.ophthalmologicVisit;
			}
			set
			{
				this.ophthalmologicVisit = value;
			}
		}
		
	}
}
#pragma warning restore 1591
