using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Thor.Units
{
	/// <summary>
	/// 
	/// </summary>
	public class Table : DictionaryBase
	{
		#region Enumerations

		#endregion

		#region Delegates

		#endregion

		#region Events

		#endregion

		#region Members

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Table()
		{
			Clear();
		}

		#endregion

		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// Get a list of all the names of the UnitEntrys in this UnitTable.
		/// </summary>
		/// <returns></returns>
		public string[] GetAllUnitNamesInGroup()
		{
			string[] names = new string[this.Count];

			int i = 0;
			foreach (UnitEntry unitEntry in this.Dictionary)
			{
				names[i++] = unitEntry.Name;
			}

			return names;
		}

		#endregion

		#region XML

		#endregion

	} // End class.
} // End namespace.