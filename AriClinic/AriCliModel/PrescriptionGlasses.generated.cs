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
	public partial class PrescriptionGlasses : OpticalTest
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
		
		private Decimal? farSphericityRightEye;
		public virtual Decimal? FarSphericityRightEye 
		{ 
		    get
		    {
		        return this.farSphericityRightEye;
		    }
		    set
		    {
		        this.farSphericityRightEye = value;
		    }
		}
		
		private Decimal? farCylinderRightEye;
		public virtual Decimal? FarCylinderRightEye 
		{ 
		    get
		    {
		        return this.farCylinderRightEye;
		    }
		    set
		    {
		        this.farCylinderRightEye = value;
		    }
		}
		
		private Decimal? farAxisRightEye;
		public virtual Decimal? FarAxisRightEye 
		{ 
		    get
		    {
		        return this.farAxisRightEye;
		    }
		    set
		    {
		        this.farAxisRightEye = value;
		    }
		}
		
		private Decimal? farPrimsRightEye;
		public virtual Decimal? FarPrimsRightEye 
		{ 
		    get
		    {
		        return this.farPrimsRightEye;
		    }
		    set
		    {
		        this.farPrimsRightEye = value;
		    }
		}
		
		private Decimal? farVisualAcuityRightEye;
		public virtual Decimal? FarVisualAcuityRightEye 
		{ 
		    get
		    {
		        return this.farVisualAcuityRightEye;
		    }
		    set
		    {
		        this.farVisualAcuityRightEye = value;
		    }
		}
		
		private Decimal? farSphericityLeftEye;
		public virtual Decimal? FarSphericityLeftEye 
		{ 
		    get
		    {
		        return this.farSphericityLeftEye;
		    }
		    set
		    {
		        this.farSphericityLeftEye = value;
		    }
		}
		
		private Decimal? farCylinderLeftEye;
		public virtual Decimal? FarCylinderLeftEye 
		{ 
		    get
		    {
		        return this.farCylinderLeftEye;
		    }
		    set
		    {
		        this.farCylinderLeftEye = value;
		    }
		}
		
		private Decimal? farAxisLeftEye;
		public virtual Decimal? FarAxisLeftEye 
		{ 
		    get
		    {
		        return this.farAxisLeftEye;
		    }
		    set
		    {
		        this.farAxisLeftEye = value;
		    }
		}
		
		private Decimal? farPrismLeftEye;
		public virtual Decimal? FarPrismLeftEye 
		{ 
		    get
		    {
		        return this.farPrismLeftEye;
		    }
		    set
		    {
		        this.farPrismLeftEye = value;
		    }
		}
		
		private Decimal? farVisualAcuityLeftEye;
		public virtual Decimal? FarVisualAcuityLeftEye 
		{ 
		    get
		    {
		        return this.farVisualAcuityLeftEye;
		    }
		    set
		    {
		        this.farVisualAcuityLeftEye = value;
		    }
		}
		
		private Decimal? closeSphericityRightEye;
		public virtual Decimal? CloseSphericityRightEye 
		{ 
		    get
		    {
		        return this.closeSphericityRightEye;
		    }
		    set
		    {
		        this.closeSphericityRightEye = value;
		    }
		}
		
		private Decimal? closeSphericityLeftEye;
		public virtual Decimal? CloseSphericityLeftEye 
		{ 
		    get
		    {
		        return this.closeSphericityLeftEye;
		    }
		    set
		    {
		        this.closeSphericityLeftEye = value;
		    }
		}
		
		private string closeSphericityCenters;
		public virtual string CloseSphericityCenters 
		{ 
		    get
		    {
		        return this.closeSphericityCenters;
		    }
		    set
		    {
		        this.closeSphericityCenters = value;
		    }
		}
		
		private Decimal? closeCylinderRightEye;
		public virtual Decimal? CloseCylinderRightEye 
		{ 
		    get
		    {
		        return this.closeCylinderRightEye;
		    }
		    set
		    {
		        this.closeCylinderRightEye = value;
		    }
		}
		
		private Decimal? closeCylinderLeftEye;
		public virtual Decimal? CloseCylinderLeftEye 
		{ 
		    get
		    {
		        return this.closeCylinderLeftEye;
		    }
		    set
		    {
		        this.closeCylinderLeftEye = value;
		    }
		}
		
		private Decimal? closeAxisRightEye;
		public virtual Decimal? CloseAxisRightEye 
		{ 
		    get
		    {
		        return this.closeAxisRightEye;
		    }
		    set
		    {
		        this.closeAxisRightEye = value;
		    }
		}
		
		private Decimal? closeAxisLeftEye;
		public virtual Decimal? CloseAxisLeftEye 
		{ 
		    get
		    {
		        return this.closeAxisLeftEye;
		    }
		    set
		    {
		        this.closeAxisLeftEye = value;
		    }
		}
		
		private Decimal? closePrismRightEye;
		public virtual Decimal? ClosePrismRightEye 
		{ 
		    get
		    {
		        return this.closePrismRightEye;
		    }
		    set
		    {
		        this.closePrismRightEye = value;
		    }
		}
		
		private Decimal? closePrismLeftEye;
		public virtual Decimal? ClosePrismLeftEye 
		{ 
		    get
		    {
		        return this.closePrismLeftEye;
		    }
		    set
		    {
		        this.closePrismLeftEye = value;
		    }
		}
		
		private Decimal? closeAcuityRightEye;
		public virtual Decimal? CloseAcuityRightEye 
		{ 
		    get
		    {
		        return this.closeAcuityRightEye;
		    }
		    set
		    {
		        this.closeAcuityRightEye = value;
		    }
		}
		
		private Decimal? closeAcuityLeftEye;
		public virtual Decimal? CloseAcuityLeftEye 
		{ 
		    get
		    {
		        return this.closeAcuityLeftEye;
		    }
		    set
		    {
		        this.closeAcuityLeftEye = value;
		    }
		}
		
		private Decimal? bothSphericityRightEye;
		public virtual Decimal? BothSphericityRightEye 
		{ 
		    get
		    {
		        return this.bothSphericityRightEye;
		    }
		    set
		    {
		        this.bothSphericityRightEye = value;
		    }
		}
		
		private Decimal? bothSphericityLeftEye;
		public virtual Decimal? BothSphericityLeftEye 
		{ 
		    get
		    {
		        return this.bothSphericityLeftEye;
		    }
		    set
		    {
		        this.bothSphericityLeftEye = value;
		    }
		}
		
		private Decimal? bothCylinderRightEye;
		public virtual Decimal? BothCylinderRightEye 
		{ 
		    get
		    {
		        return this.bothCylinderRightEye;
		    }
		    set
		    {
		        this.bothCylinderRightEye = value;
		    }
		}
		
		private Decimal? bothCylinderLeftEye;
		public virtual Decimal? BothCylinderLeftEye 
		{ 
		    get
		    {
		        return this.bothCylinderLeftEye;
		    }
		    set
		    {
		        this.bothCylinderLeftEye = value;
		    }
		}
		
		private Decimal? bothAxisRightEye;
		public virtual Decimal? BothAxisRightEye 
		{ 
		    get
		    {
		        return this.bothAxisRightEye;
		    }
		    set
		    {
		        this.bothAxisRightEye = value;
		    }
		}
		
		private Decimal? bothAxisLeftEye;
		public virtual Decimal? BothAxisLeftEye 
		{ 
		    get
		    {
		        return this.bothAxisLeftEye;
		    }
		    set
		    {
		        this.bothAxisLeftEye = value;
		    }
		}
		
		private Decimal? bothPrismRightEye;
		public virtual Decimal? BothPrismRightEye 
		{ 
		    get
		    {
		        return this.bothPrismRightEye;
		    }
		    set
		    {
		        this.bothPrismRightEye = value;
		    }
		}
		
		private Decimal? bothPrismLeftEye;
		public virtual Decimal? BothPrismLeftEye 
		{ 
		    get
		    {
		        return this.bothPrismLeftEye;
		    }
		    set
		    {
		        this.bothPrismLeftEye = value;
		    }
		}
		
		private Decimal? bothAcuityRightEye;
		public virtual Decimal? BothAcuityRightEye 
		{ 
		    get
		    {
		        return this.bothAcuityRightEye;
		    }
		    set
		    {
		        this.bothAcuityRightEye = value;
		    }
		}
		
		private Decimal? bothAcuityLeftEye;
		public virtual Decimal? BothAcuityLeftEye 
		{ 
		    get
		    {
		        return this.bothAcuityLeftEye;
		    }
		    set
		    {
		        this.bothAcuityLeftEye = value;
		    }
		}
		
		private Decimal? farCenters;
		public virtual Decimal? FarCenters 
		{ 
		    get
		    {
		        return this.farCenters;
		    }
		    set
		    {
		        this.farCenters = value;
		    }
		}
		
		private Decimal? closeCenters;
		public virtual Decimal? CloseCenters 
		{ 
		    get
		    {
		        return this.closeCenters;
		    }
		    set
		    {
		        this.closeCenters = value;
		    }
		}
		
		private Decimal? bothCenters;
		public virtual Decimal? BothCenters 
		{ 
		    get
		    {
		        return this.bothCenters;
		    }
		    set
		    {
		        this.bothCenters = value;
		    }
		}
		
		private Decimal? farAcuity;
		public virtual Decimal? FarAcuity 
		{ 
		    get
		    {
		        return this.farAcuity;
		    }
		    set
		    {
		        this.farAcuity = value;
		    }
		}
		
		private Decimal? closeAcuity;
		public virtual Decimal? CloseAcuity 
		{ 
		    get
		    {
		        return this.closeAcuity;
		    }
		    set
		    {
		        this.closeAcuity = value;
		    }
		}
		
		private Decimal? bothAcuity;
		public virtual Decimal? BothAcuity 
		{ 
		    get
		    {
		        return this.bothAcuity;
		    }
		    set
		    {
		        this.bothAcuity = value;
		    }
		}
		
		private Refractometry refractometry;
		public virtual Refractometry Refractometry 
		{ 
		    get
		    {
		        return this.refractometry;
		    }
		    set
		    {
		        this.refractometry = value;
		    }
		}
		
	}
}
