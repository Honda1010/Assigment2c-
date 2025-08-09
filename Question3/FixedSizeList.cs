using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdv2.Question3
{
	internal class FixedSizeList<T>
	{
		private List<T> items;
		private int maxCapacity;
		public FixedSizeList(int Capacity)
		{
			maxCapacity = Capacity;
			items = new List<T>(maxCapacity);
		}
		public void Add(T item)
		{
			if (items.Count >= maxCapacity)
			{
				throw new InvalidOperationException("List is full. Cannot add more items.");
			}
			items.Add(item);
		}
		public T Get(int index)
		{
			if (index < 0 || index >= items.Count)
			{
				throw new ArgumentOutOfRangeException("Index is out of range.");
			}
			return items[index];
		}
	}
}
