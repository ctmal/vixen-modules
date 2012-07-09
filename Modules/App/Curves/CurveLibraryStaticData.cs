﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vixen.Module;
using Vixen.Module.App;
using System.Runtime.Serialization;

namespace VixenModules.App.Curves
{
	[DataContract]
	class CurveLibraryStaticData : ModuleDataModelBase
	{
		public CurveLibraryStaticData()
		{
			Library = new Dictionary<string, Curve>();
		}

		[DataMember]
		private Dictionary<string, Curve> _library;
		public Dictionary<string, Curve> Library
		{
			get
			{
				if (_library == null)
					_library = new Dictionary<string, Curve>();

				return _library;
			}
			set
			{
				_library = value;
			}
		}

		public override IModuleDataModel Clone()
		{
			CurveLibraryStaticData result = new CurveLibraryStaticData();
			// TODO: this is only a shallow copy. Don't think it'll matter, this module is a singleton...
			result.Library = new Dictionary<string, Curve>(Library);
			return result;
		}

	}
}