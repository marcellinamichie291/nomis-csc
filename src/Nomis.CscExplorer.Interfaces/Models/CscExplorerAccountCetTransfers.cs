﻿using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Nomis.CscExplorer.Interfaces.Models
{
    /// <summary>
    /// CSC Explorer CET transfers.
    /// </summary>
    public class CscExplorerAccountCetTransfers :
        ICscExplorerTransferList<CscExplorerAccountCetTransferData, CscExplorerAccountCetTransferRecord>
    {
        /// <summary>
        /// Code.
        /// </summary>
        [JsonPropertyName("code")]
        public int Code { get; set; }

        /// <summary>
        /// Message.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Transactions data.
        /// </summary>
        [JsonPropertyName("data")]
        [DataMember(EmitDefaultValue = true)]
        public CscExplorerAccountCetTransferData? Data { get; set; }
    }
}