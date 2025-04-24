namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyServiceSchema

	/// <exclude/>
	public class UsrRealtyServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyServiceSchema(UsrRealtyServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("94d0cabc-3898-4a2f-8f16-7f75063b4b25");
			Name = "UsrRealtyService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c1bdffac-d8d2-4b8d-9db9-1f6e012fbead");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,40,206,207,77,85,112,86,86,72,206,79,73,85,200,72,45,74,213,3,2,0,59,114,59,214,22,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("94d0cabc-3898-4a2f-8f16-7f75063b4b25"));
		}

		#endregion

	}

	#endregion

}

