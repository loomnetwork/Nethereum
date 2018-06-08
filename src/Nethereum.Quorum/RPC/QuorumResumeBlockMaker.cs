﻿using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Infrastructure;

namespace Loom.Nethereum.Quorum.RPC
{
    public class QuorumResumeBlockMaker : GenericRpcRequestResponseHandlerNoParam<object>
    {
        public QuorumResumeBlockMaker(IClient client) : base(client, ApiMethods.quorum_resumeBlockMaker.ToString())
        {
        }
    }
}