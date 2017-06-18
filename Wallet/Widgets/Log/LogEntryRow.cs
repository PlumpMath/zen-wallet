﻿using System;
using Wallet.Domain;

namespace Wallet
{
	public class LogEntryRow : ILogEntryRow
	{
        public byte[] Key { get; private set; }
		public Object[] Values { get; private set; } 
		public int Offset { get { return 0; }}

        public LogEntryRow (byte[] key, LogEntryItem logEntryItem) {
            Key = key;
            var zenAmount = new Zen(logEntryItem.Amount).ToString();
			Values = new System.Object[] {
				logEntryItem.Date.TimeAgo(), 
				logEntryItem.Id, 
				logEntryItem.Direction == DirectionEnum.Sent ? zenAmount : "",
				logEntryItem.Direction == DirectionEnum.Recieved ? zenAmount : "",
				logEntryItem.Balance
			};
		}
	}
}

