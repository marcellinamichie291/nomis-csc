﻿using System.ComponentModel;

using Nomis.Blockchain.Abstractions;

namespace Nomis.CscExplorer.Interfaces.Models
{
    /// <summary>
    /// Csc wallet stats.
    /// </summary>
    public class CscWalletStats 
        : IWalletStats
    {
        /// <summary>
        /// No data.
        /// </summary>
        public bool NoData { get; init; }

        /// <summary>
        /// Amount of deployed smart-contracts (number).
        /// </summary>
        [Description("Amount of deployed smart-contracts (number)")]
        public int DeployedContracts { get; init; }

        /// <inheritdoc/>
        [Description("Wallet balance (CET)")]
        public decimal Balance { get; set; }

        /// <inheritdoc/>
        [Description("Wallet age (months)")]
        public int WalletAge { get; set; }

        /// <inheritdoc/>
        [Description("Total transactions on wallet (number)")]
        public int TotalTransactions { get; set; }

        /// <inheritdoc/>
        [Description("Average time interval between transactions (hours)")]
        public double AverageTransactionTime { get; set; }

        /// <inheritdoc/>
        [Description("Maximum time interval between transactions (hours)")]
        public double MaxTransactionTime { get; set; }

        /// <inheritdoc/>
        [Description("Minimal time interval between transactions (hours)")]
        public double MinTransactionTime { get; set; }

        /// <inheritdoc/>
        [Description("The movement of funds on the wallet (CET)")]
        public decimal WalletTurnover { get; set; }

        /// <inheritdoc/>
        [Description("Total NFTs on wallet (number)")]
        public int NftHolding { get; set; }

        /// <inheritdoc/>
        [Description("Time since last transaction (months)")]
        public int TimeFromLastTransaction { get; set; }

        /// <inheritdoc/>
        [Description("NFT trading activity (CET)")]
        public decimal NftTrading { get; set; }

        /// <inheritdoc/>
        [Description("NFT worth on wallet (CET)")]
        public decimal NftWorth { get; set; }

        /// <inheritdoc/>
        [Description("Last month transactions (number)")]
        public int LastMonthTransactions { get; set; }

        /// <inheritdoc/>
        [Description("Average transaction per months (number)")]
        public double TransactionsPerMonth => WalletAge != 0 ? (double)TotalTransactions / WalletAge : 0;

        /// <inheritdoc/>
        [Description("Value of all holding tokens (number)")]
        public int TokensHolding { get; set; }
    }
}