using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
	public interface Repository
	{
		string DefaultPath { get; }
		string Save(Persistable entity);
		IEnumerable<EntityType> Get<EntityType>(Func<EntityType, bool> filter = null) where EntityType : Persistable, new();
		void Delete(Persistable entity);
	}
}
