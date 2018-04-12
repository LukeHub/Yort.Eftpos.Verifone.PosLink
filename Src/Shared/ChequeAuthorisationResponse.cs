using System;
using System.Collections.Generic;
using System.Text;

namespace Yort.Eftpos.Verifone.PosLink
{
	/// <summary>
	/// Represents a response to a request to authorise a cheque.
	/// </summary>
	/// <seealso cref="PosLinkResponseBase"/>
	/// <seealso cref="ChequeAuthorisationRequest"/>
	public class ChequeAuthorisationResponse : TransactionResponseBase
	{
		/// <summary>
		/// Constructs a new message instance from the list of pre-decoded string values received from the pinpad.
		/// </summary>
		/// <param name="fieldValues">The list of values returned from the pinpad in the order specified by the protocol and message type.</param>
		/// <see cref="ChequeAuthorisationRequest"/>
		public ChequeAuthorisationResponse(IList<string> fieldValues) : base(fieldValues) { }

		/// <summary>
		/// Returns "CHQ".
		/// </summary>
		public override string MessageType { get { return ProtocolConstants.MessageType_ChequeAuthorisation; } }

	}
}