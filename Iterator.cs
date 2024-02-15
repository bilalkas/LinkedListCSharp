using System;
namespace List
{
	public interface Iterator<T>
	{

		public abstract bool HasNext();
		public abstract T Next();

	}
}

