using System;
using System.Collections.Generic;
using System.Text;

namespace Yort.Eftpos.Verifone.PosLink
{
	/// <summary>
	/// Represents a message to be displayed to the operator.
	/// </summary>
	public class DisplayMessage
	{
		/// <summary>
		/// Full constructor.
		/// </summary>
		/// <param name="messageText">The text of the message to be displayed.</param>
		/// <param name="source">A value indicating whether this message was generated by the library code, or came from the pin pad device.</param>
		public DisplayMessage(string messageText, DisplayMessageSource source)
		{
			this.MessageText = messageText;
			this.Source = source;
		}
		
		/// <summary>
		/// The text of the message to be displayed.
		/// </summary>
		public string MessageText {get; private set;}
		/// <summary>
		/// A value indicating whether this message was generated by the library code, or came from the pin pad device.
		/// </summary>
		public DisplayMessageSource Source { get; private set; }

	}
}