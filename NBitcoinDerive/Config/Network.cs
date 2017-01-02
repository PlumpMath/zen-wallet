﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NBitcoinDerive
{
	public class Network
	{
		public List<String> Seeds { get; set; }
		public int DefaultPort { get; set; }
		public uint Magic { get; }
		public int PeersToFind;
		public int MaximumNodeConnection;

		public Network() {
			Seeds = new List<string> ();
		}

		public override string ToString ()
		{
			String msg = $"[ \tSeeds={Seeds}, \tDefaultPort={DefaultPort}, \tMagic={Magic}, \tPeersToFind={PeersToFind}, \tMaximumNodeConnection={MaximumNodeConnection} ]";

			return msg.Replace(" ", "\n");
		}
	}
}
