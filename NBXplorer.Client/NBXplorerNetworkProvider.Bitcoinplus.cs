using NBitcoin;
using System;
using System.Collections.Generic;
using System.Text;

namespace NBXplorer
{
    public partial class NBXplorerNetworkProvider
    {
		private void InitFeathercoin(NetworkType networkType)
		{
			Add(new NBXplorerNetwork(NBitcoin.Altcoins.Bitcoinplus.Instance, networkType)
			{
				MinRPCVersion = 160000
			});
		}

		public NBXplorerNetwork GetXBC()
		{
			return GetFromCryptoCode(NBitcoin.Altcoins.Bitcoinplus.Instance.CryptoCode);
		}
	}
}
