using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.Parity.RPC.BlockAuthoring;
using Xunit;

namespace Loom.Nethereum.Parity.IntegrationTests.Tests.BlockAuthoring
{
    public class ParityExtraDataTester : RPCRequestTester<string>, IRPCRequestTester
    {
        public override async Task<string> ExecuteAsync(IClient client)
        {
            var parityExtraData = new ParityExtraData(client);
            return await parityExtraData.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(ParityExtraData);
        }

        [Fact]
        public async void ShouldGetExtraData()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }
    }
}