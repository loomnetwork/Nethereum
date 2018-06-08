﻿using System;

namespace Loom.Nethereum.JsonRpc.Client
{
    public class RpcResponseException : Exception
    {
        public RpcResponseException(RpcError rpcError) : base(rpcError.Message)
        {
            RpcError = rpcError;
        }

        public RpcError RpcError { get; }
    }
}