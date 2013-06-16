using System;

namespace DevAge.Configuration
{
	/// <summary>
	/// A dictionary with keys of type String and values of type PersistableItem
	/// </summary>
	public class PersistableItemDictionary: System.Collections.DictionaryBase
	{
		/// <summary>
		/// Initializes a new empty instance of the PersistableItemDictionary class
		/// </summary>
		public PersistableItemDictionary()
		{
			// empty
		}

		/// <summary>
		/// Gets or sets the PersistableItem associated with the given String
		/// </summary>
		/// <param name="key">
		/// The String whose value to get or set.
		/// </param>
		public virtual PersistableItem this[String key]
		{
			get
			{
				return (PersistableItem) this.Dictionary[key];
			}
			set
			{
				this.Dictionary[key] = value;
			}
		}

		/// <summary>
		/// Adds an element with the specified key and value to this PersistableItemDictionary.
		/// </summary>
		/// <param name="key">
		/// The String key of the element to add.
		/// </param>
		/// <param name="value">
		/// The PersistableItem value of the element to add.
		/// </param>
		public virtual void Add(String key, PersistableItem value)
		{
			this.Dictionary.Add(key, value);
		}

		/// <summary>
		/// Determines whether this PersistableItemDictionary contains a specific key.
		/// </summary>
		/// <param name="key">
		/// The String key to locate in this PersistableItemDictionary.
		/// </param>
		/// <returns>
		/// true if this PersistableItemDictionary contains an element with the specified key;
		/// otherwise, false.
		/// </returns>
		public virtual bool Contains(String key)
		{
			return this.Dictionary.Contains(key);
		}

		/// <summary>
		/// Determines whether this PersistableItemDictionary contains a specific key.
		/// </summary>
		/// <param name="key">
		/// The String key to locate in this PersistableItemDictionary.
		/// </param>
		/// <returns>
		/// true if this PersistableItemDictionary contains an element with the specified key;
		/// otherwise, false.
		/// </returns>
		public virtual bool ContainsKey(String key)
		{
			return this.Dictionary.Contains(key);
		}

		/// <summary>
		/// Determines whether this PersistableItemDictionary contains a specific value.
		/// </summary>
		/// <param name="value">
		/// The PersistableItem value to locate in this PersistableItemDictionary.
		/// </param>
		/// <returns>
		/// true if this PersistableItemDictionary contains an element with the specified value;
		/// otherwise, false.
		/// </returns>
		public virtual bool ContainsValue(PersistableItem value)
		{
			foreach (PersistableItem item in this.Dictionary.Values)
			{
				if (item == value)
					return true;
			}
			return false;
		}

		/// <summary>
		/// Removes the element with the specified key from this PersistableItemDictionary.
		/// </summary>
		/// <param name="key">
		/// The String key of the element to remove.
		/// </param>
		public virtual void Remove(String key)
		{
			this.Dictionary.Remove(key);
		}

		/// <summary>
		/// Gets a collection containing the keys in this PersistableItemDictionary.
		/// </summary>
		public virtual System.Collections.ICollection Keys
		{
			get
			{
				return this.Dictionary.Keys;
			}
		}

		/// <summary>
		/// Gets a collection containing the values in this PersistableItemDictionary.
		/// </summary>
		public virtual System.Collections.ICollection Values
		{
			get
			{
				return this.Dictionary.Values;
			}
		}
	}

}
