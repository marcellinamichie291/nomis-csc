﻿using System.Text.Json.Serialization;

namespace Nomis.CscExplorer.Interfaces.Models
{
    /// <summary>
    /// CSC Explorer account tokens data item token info.
    /// </summary>
    public class CscExplorerTokensDataItemTokenInfo
    {
        /// <summary>
        /// Contract.
        /// </summary>
        [JsonPropertyName("contract")]
        public string? Contract { get; set; }

        /// <summary>
        /// Logo.
        /// </summary>
        [JsonPropertyName("logo")]
        public string? Logo { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Symbol.
        /// </summary>
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }

        /// <summary>
        /// Type.
        /// </summary>
        [JsonPropertyName("type")]
        public int Type { get; set; }
    }
}