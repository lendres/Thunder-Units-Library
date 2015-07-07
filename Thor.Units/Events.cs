/*
 * Thunder Unit conversion library
 * (C)Copyright 2005/2006 Robert Harwood <robharwood@runbox.com>
 * 
 * Please see included license.txt file for information on redistribution and usage.
 */
using System;

namespace Thor.Units
{
	#region Events
	/// <summary>
	/// The method form for the unit conversion classes event handling.
	/// </summary>
	public delegate void UnitEventHandler(object sender, UnitEventArgs e);

	/// <summary>
	/// Represents a set of parameters sent with events generated
	/// by the unit conversion class.
	/// </summary>
	public class UnitEventArgs
	{
		private string m_Message;
		private string m_DetailMessage;

		/// <summary>
		/// Gets a small message associated with the event.
		/// </summary>
		public string Message
		{
			get{ return m_Message; }
		}

		/// <summary>
		/// Gets a more detailed message associated with the event.
		/// </summary>
		public string DetailMessage
		{
			get{ return m_DetailMessage; }
		}

		/// <summary>
		/// Creates an instance of unit event arguments.
		/// </summary>
		/// <param name="message">Message to send with the event.</param>
		/// <param name="detailmessage">More detail to send with the event.</param>
		public UnitEventArgs(string message, string detailmessage)
		{
			m_Message = message;
			m_DetailMessage = detailmessage;
		}

		/// <summary>
		/// Creates an instance of unit event arguments.
		/// </summary>
		/// <param name="message">Message to send with the event.</param>
		public UnitEventArgs(string message)
		{
			m_Message = message;
			m_DetailMessage = "";
		}
	}
	#endregion

	#region Exceptions
	/// <summary>
	/// Represents an exception generated when reading the unit file.
	/// </summary>
	public class UnitFileException : System.Exception
	{
		private string m_Detail;

		/// <summary>
		/// Gets additional details about the exception.
		/// </summary>
		public string Detail
		{
			get{ return m_Detail; }
		}

		/// <summary>
		/// Creates an instance of the unit file exception.
		/// </summary>
		/// <param name="message">Message to send with the exception.</param>
		/// <param name="detail">Additional details about the exception.</param>
		public UnitFileException(string message, string detail) : base(message)
		{
			m_Detail = detail;
		}

		/// <summary>
		/// Creates an instance of the unit file exception.
		/// </summary>
		/// <param name="message">Message to send with the exception.</param>
		public UnitFileException(string message) : base(message)
		{
			;
		}
	}
	#endregion
}

