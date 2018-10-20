﻿using NBitcoin;
using NBXplorer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBXplorer.Events
{
    public class NewTransactionMatchEvent
    {
		public NewTransactionMatchEvent(string cryptoCode, uint256 blockId, TransactionMatch match, Repository.SavedTransaction savedTransaction)
		{
			Match = match;
			BlockId = blockId;
			SavedTransaction = savedTransaction;
			CryptoCode = cryptoCode;
		}

		public string CryptoCode
		{
			get; set;
		}

		public uint256 BlockId
		{
			get; set;
		}

		public TransactionMatch Match
		{
			get; set;
		}

		public Repository.SavedTransaction SavedTransaction
		{
			get; set;
		}

		public override string ToString()
		{
			var conf = (BlockId == null ? "unconfirmed" : "confirmed");

			string strategy = Match.TrackedSource.ToPrettyString();
			var txId = Match.Transaction.GetHash().ToString();
			txId = txId.Substring(0, 6) + "..." + txId.Substring(txId.Length - 6);
			return $"{CryptoCode}: {strategy} matching {conf} transaction {txId} ({Match.Inputs.Count} inputs, {Match.Outputs.Count} outputs)";
		}
	}
}
