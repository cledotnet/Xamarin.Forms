using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
	public interface Cloneable<EntityType>
		where EntityType : class, Entity
	{
		EntityType Clone();
	}
}
