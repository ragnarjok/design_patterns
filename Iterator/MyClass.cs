using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
	public class MyClass
	{
		public MyClass ()
		{
		}
	}

	class Item
	{
		private string _name;

		public Item(string name)
		{
			_name = name;
		}

		public string Name
		{
			get { return _name; }
		}
	}

	interface IAbstractIterator
	{
		Item First();
		Item Next();
		bool IsDone { get; }
		Item CurrentItem { get; }
	}


	class Iterator : IAbstractIterator
	{
		private Collection<Item> _collection;
		private int _current = 0;
		private int _step = 1;

		public Iterator(Collection<Item> collection)
		{
			this._collection = collection;
		}

		public Item First()
		{
			_current = 0;
			return _collection[_current] as Item;
		}

		public Item Next()
		{
			_current += _step;
			if (!IsDone)
				return _collection[_current] as Item;
			else
				return null;
		}

		public int Step
		{
			get { return _step; }
			set { _step = value; }
		}

		public Item CurrentItem
		{
			get { return _collection[_current] as Item; }
		}

		public bool IsDone
		{
			get { return _current >= _collection.Count; }
		}
	}

	interface IAbstractCollection
	{
		Iterator CreateIterator();
	}

	class Collection<T> : IAbstractCollection
	{
		private List<T> _items = new List<T>();

		public Iterator CreateIterator()
		{
			return new Iterator(this as Collection<Item>);
		}

		public int Count
		{
			get { return _items.Count; }
		}

		public T this[int index]
		{
			get { return _items[index]; }
			set { _items.Add(value); }
		}
	}


}

