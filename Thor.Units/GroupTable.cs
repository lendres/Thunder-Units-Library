/*
 * Thunder Unit conversion library
 * (C)Copyright 2005/2006 Robert Harwood <robharwood@runbox.com>
 * 
 * Please see included license.txt file for information on redistribution and usage.
 */
using System;
using System.Collections;
using System.Diagnostics;

namespace Thor.Units
{
	/// <summary>
	/// Contains a table of unit groups.
	/// </summary>
	public class GroupTable : DictionaryBase
	{
		/// <summary>
		/// Constructor, clears the table and readies it for use.
		/// </summary>
		public GroupTable()
		{
			this.Clear( );
		}

		/// <summary>
		/// Given a unit name as the key, returns the associated unit entry.
		/// </summary>
		public UnitGroup this[string groupName]
		{
			get
			{
				groupName = groupName.ToLower( );

				//If we contain a group matching the key then return it.
				if(this.Dictionary.Contains(groupName))
					return (UnitGroup)this.Dictionary[groupName];
				else
					//Symbol doesn't exist.
					return null;
			}
			
			set
			{
				groupName = groupName.ToLower( );

				//Already added? Warn developer (this is probably not a good thing)
				Debug.Assert( (!this.Dictionary.Contains(groupName)),
					"Group table warning",
					String.Format("The unit group with name '{0}' has been overwritten.", groupName) );

				//Link the group to its name
				this.Dictionary[groupName] = value;
			} 
		}

		/// <summary>
		/// Gets an array of all the groups in the group table.
		/// </summary>
		/// <returns>Array of UnitGroup objects representing all of the groups in the group table.</returns>
		public UnitGroup[] GetAllGroups( )
		{
			UnitGroup[] retval;

			//Lock the table (so only we can use it)
			lock(this.Dictionary.SyncRoot)
			{
				retval = new UnitGroup[this.Count];
				int i = 0;

                //Build an array of all the groups in the table
				foreach(UnitGroup grp in this.Dictionary.Values)
				{
					retval[i] = grp;
					i++;
				}
			}
            
			//Return our findings.
			return retval;
		}

	}
}
