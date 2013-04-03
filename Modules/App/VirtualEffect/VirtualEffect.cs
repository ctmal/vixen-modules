﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace VixenModules.App.VirtualEffect
{
	[DataContract]
	[KnownType(typeof(System.Drawing.Color))]
	[KnownType(typeof(Common.ValueTypes.Percentage))]
	public class VirtualEffect
	{
		[DataMember]		
		public Guid EffectGuid { get; set; }
		[DataMember]
		public String Name { get; set; }
		[DataMember]
		private object[] _virtualParams;
		[DataMember]
		public TimeSpan EffectTimeSpan { get; set; }

		public object[] VirtualParams
		{
			get { return _virtualParams; }
			set
			{
				List<object> objList = new List<object>();
				foreach (object o in value)
				{
					objList.Add(o);
				}
				_virtualParams = objList.ToArray();
			}
		}		

		public VirtualEffect(String name, Guid effectGuid, object[] virtualParams,TimeSpan timeSpan)
		{
			this.Name = name;
			this.EffectGuid = effectGuid;
			this.VirtualParams = virtualParams;
			this.EffectTimeSpan = timeSpan;
		}
	}
}
