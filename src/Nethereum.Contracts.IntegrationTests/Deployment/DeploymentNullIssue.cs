﻿using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.RPC.TransactionReceipts;
using Xunit;

namespace Loom.Nethereum.Contracts.IntegrationTests.Deployment
{
    public class DeploymentNullIssue
    {
        [Fact]
        public async void ShouldDeployWithNoConstructorParameters()
        {
            var ABI =
                "[{'constant':false,'inputs':[],'name':'createID','outputs':[{'name':'','type':'address'}],'payable':false,'type':'function'},{'constant':true,'inputs':[],'name':'owner','outputs':[{'name':'','type':'address'}],'payable':false,'type':'function'},{'anonymous':false,'inputs':[{'indexed':true,'name':'_from','type':'address'},{'indexed':false,'name':'_controllerAddress','type':'address'}],'name':'ReturnIDController','type':'event'}]";
            var BYTE_CODE =
                "0x60606040525b33600060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505b5b612891806100576000396000f30060606040526000357c0100000000000000000000000000000000000000000000000000000000900463ffffffff16806348573542146100465780638da5cb5b14610098575bfe5b341561004e57fe5b6100566100ea565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b34156100a057fe5b6100a861019f565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6000600060006100f8610376565b809050604051809103906000f080151561010e57fe5b915061011a82336101c5565b90503373ffffffffffffffffffffffffffffffffffffffff167f94083f4ecce35399252890d68b14d19ad0419a427258864ef16558218d7bb87d82604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390a28092505b505090565b600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b60006000836101d2610386565b808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001915050604051809103906000f080151561021b57fe5b90508373ffffffffffffffffffffffffffffffffffffffff1663a6f9dae1826040518263ffffffff167c0100000000000000000000000000000000000000000000000000000000028152600401808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001915050600060405180830381600087803b15156102b457fe5b60325a03f115156102c157fe5b5050508073ffffffffffffffffffffffffffffffffffffffff1663a6f9dae1846040518263ffffffff167c0100000000000000000000000000000000000000000000000000000000028152600401808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001915050600060405180830381600087803b151561035b57fe5b60325a03f1151561036857fe5b5050508091505b5092915050565b6040516114b08061039783390190565b60405161101f8061184783390190560060606040525b33600060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505b5b611459806100576000396000f300606060405236156100b8576000357c0100000000000000000000000000000000000000000000000000000000900463ffffffff16806302859d60146100ba5780631ab807f814610115578063277c94671461015857806341c0e1b5146101945780634f23eb86146101a65780635f893bfa146102a2578063781dd722146102d85780638da5cb5b1461032d578063a6f9dae11461037f578063b115ce0d146103b5578063e7996f0714610419578063eb43e0331461043d575bfe5b34156100c257fe5b6100fb60048080356000191690602001909190803573ffffffffffffffffffffffffffffffffffffffff169060200190919050506104a1565b604051808215151515815260200191505060405180910390f35b341561011d57fe5b61015660048080356000191690602001909190803573ffffffffffffffffffffffffffffffffffffffff169060200190919050506106b4565b005b341561016057fe5b61017660048080359060200190919050506106cb565b60405180826000191660001916815260200191505060405180910390f35b341561019c57fe5b6101a46106f0565b005b34156101ae57fe5b610260600480803590602001908201803590602001908080601f0160208091040260200160405190810160405280939291908181526020018383808284378201915050505050509190803590602001908201803590602001908080601f0160208091040260200160405190810160405280939291908181526020018383808284378201915050505050509190803573ffffffffffffffffffffffffffffffffffffffff169060200190919050506107dc565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b34156102aa57fe5b6102d6600480803573ffffffffffffffffffffffffffffffffffffffff16906020019091905050610988565b005b34156102e057fe5b61032b600480803573ffffffffffffffffffffffffffffffffffffffff1690602001909190803573ffffffffffffffffffffffffffffffffffffffff169060200190919050506109ff565b005b341561033557fe5b61033d610b67565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b341561038757fe5b6103b3600480803573ffffffffffffffffffffffffffffffffffffffff16906020019091905050610b8d565b005b34156103bd57fe5b6103d7600480803560001916906020019091905050610c2a565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b341561042157fe5b61043b600480803560001916906020019091905050610c5d565b005b341561044557fe5b61045f600480803560001916906020019091905050610cf7565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6000600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614156106ad573073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff16638da5cb5b6000604051602001526040518163ffffffff167c0100000000000000000000000000000000000000000000000000000000028152600401809050602060405180830381600087803b151561057c57fe5b60325a03f1151561058957fe5b5050506040518051905073ffffffffffffffffffffffffffffffffffffffff161415156105b557610000565b8160016000856000191660001916815260200190815260200160002060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550600280548060010182816106239190610d3d565b916000526020600020900160005b85909190915090600019169055508173ffffffffffffffffffffffffffffffffffffffff1660016000856000191660001916815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff161490505b5b5b92915050565b6106c66106c083610cf7565b826109ff565b5b5050565b6002818154811015156106da57fe5b906000526020600020900160005b915090505481565b600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614156107d957600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614156107d757600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16ff5b5b5b5b565b6000600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614156109805783838361083f610d69565b8080602001806020018473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018381038352868181518152602001915080519060200190808383600083146108c1575b8051825260208311156108c15760208201915060208101905060208303925061089d565b505050905090810190601f1680156108ed5780820380516001836020036101000a031916815260200191505b50838103825285818151815260200191508051906020019080838360008314610935575b80518252602083111561093557602082019150602081019050602083039250610911565b505050905090810190601f1680156109615780820380516001836020036101000a031916815260200191505b5095505050505050604051809103906000f080151561097c57fe5b90505b5b5b9392505050565b8073ffffffffffffffffffffffffffffffffffffffff1663b6549f756040518163ffffffff167c0100000000000000000000000000000000000000000000000000000000028152600401809050600060405180830381600087803b15156109eb57fe5b60325a03f115156109f857fe5b5050505b50565b3073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff16638da5cb5b6000604051602001526040518163ffffffff167c0100000000000000000000000000000000000000000000000000000000028152600401809050602060405180830381600087803b1515610a8257fe5b60325a03f11515610a8f57fe5b5050506040518051905073ffffffffffffffffffffffffffffffffffffffff16141515610abb57610000565b8173ffffffffffffffffffffffffffffffffffffffff16637c6ebde9826040518263ffffffff167c0100000000000000000000000000000000000000000000000000000000028152600401808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001915050600060405180830381600087803b1515610b5257fe5b60325a03f11515610b5f57fe5b5050505b5050565b600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161415610c265780600060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505b5b5b50565b60016020528060005260406000206000915054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161415610cf35760016000826000191660001916815260200190815260200160002060006101000a81549073ffffffffffffffffffffffffffffffffffffffff02191690555b5b5b50565b600060016000836000191660001916815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690505b919050565b815481835581811511610d6457818360005260206000209182019101610d639190610d79565b5b505050565b60405161068f80610d9f83390190565b610d9b91905b80821115610d97576000816000905550600101610d7f565b5090565b90560060606040526000600360006101000a81548160ff021916908315150217905550341561002757fe5b60405161068f38038061068f833981016040528080518201919060200180518201919060200180519060200190919050505b5b33600060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505b82600190805190602001906100b2929190610114565b5081600290805190602001906100c9929190610114565b5080600360016101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505b5050506101b9565b828054600181600116156101000203166002900490600052602060002090601f016020900481019282601f1061015557805160ff1916838001178555610183565b82800160010185558215610183579182015b82811115610182578251825591602001919060010190610167565b5b5090506101909190610194565b5090565b6101b691905b808211156101b257600081600090555060010161019a565b5090565b90565b6104c7806101c86000396000f30060606040523615610076576000357c0100000000000000000000000000000000000000000000000000000000900463ffffffff16806309bd5a6014610078578063232533b214610111578063516f279e1461016357806363d256ce146101fc5780638da5cb5b14610226578063b6549f7514610278575bfe5b341561008057fe5b61008861028a565b60405180806020018281038252838181518152602001915080519060200190808383600083146100d7575b8051825260208311156100d7576020820191506020810190506020830392506100b3565b505050905090810190601f1680156101035780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b341561011957fe5b610121610328565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b341561016b57fe5b61017361034e565b60405180806020018281038252838181518152602001915080519060200190808383600083146101c2575b8051825260208311156101c25760208201915060208101905060208303925061019e565b505050905090810190601f1680156101ee5780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b341561020457fe5b61020c6103ec565b604051808215151515815260200191505060405180910390f35b341561022e57fe5b6102366103ff565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b341561028057fe5b610288610425565b005b60028054600181600116156101000203166002900480601f0160208091040260200160405190810160405280929190818152602001828054600181600116156101000203166002900480156103205780601f106102f557610100808354040283529160200191610320565b820191906000526020600020905b81548152906001019060200180831161030357829003601f168201915b505050505081565b600360019054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b60018054600181600116156101000203166002900480601f0160208091040260200160405190810160405280929190818152602001828054600181600116156101000203166002900480156103e45780601f106103b9576101008083540402835291602001916103e4565b820191906000526020600020905b8154815290600101906020018083116103c757829003601f168201915b505050505081565b600360009054906101000a900460ff1681565b600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161415610498576001600360006101000a81548160ff0219169083151502179055505b5b5b5600a165627a7a72305820ca63b024d1e5e546695f10f3a1280cf6d95cd35dcb7c112aa9f86f18298b01ac0029a165627a7a72305820d10ec5dbd904c95211e74b47091a491c696569914f6f925e8024c989053a400c00296060604052341561000c57fe5b60405160208061101f833981016040528080519060200190919050505b5b33600060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505b80600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505b505b610f60806100bf6000396000f300606060405236156100ad576000357c0100000000000000000000000000000000000000000000000000000000900463ffffffff16806302859d60146100af5780631ff8df681461010a5780634f23eb861461015c5780635f893bfa146102585780637ca307b41461028e5780638da5cb5b146102a0578063a54c0810146102f2578063a6f9dae114610328578063ab9dbd071461035e578063e7996f07146103b0578063eb43e033146103d4575bfe5b34156100b757fe5b6100f060048080356000191690602001909190803573ffffffffffffffffffffffffffffffffffffffff16906020019091905050610438565b604051808215151515815260200191505060405180910390f35b341561011257fe5b61011a6105dc565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b341561016457fe5b610216600480803590602001908201803590602001908080601f0160208091040260200160405190810160405280939291908181526020018383808284378201915050505050509190803590602001908201803590602001908080601f0160208091040260200160405190810160405280939291908181526020018383808284378201915050505050509190803573ffffffffffffffffffffffffffffffffffffffff16906020019091905050610607565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b341561026057fe5b61028c600480803573ffffffffffffffffffffffffffffffffffffffff16906020019091905050610892565b005b341561029657fe5b61029e61095f565b005b34156102a857fe5b6102b0610ae1565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b34156102fa57fe5b610326600480803573ffffffffffffffffffffffffffffffffffffffff16906020019091905050610b07565b005b341561033057fe5b61035c600480803573ffffffffffffffffffffffffffffffffffffffff16906020019091905050610bfc565b005b341561036657fe5b61036e610cf1565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b34156103b857fe5b6103d2600480803560001916906020019091905050610d1c565b005b34156103dc57fe5b6103f6600480803560001916906020019091905050610e75565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6000600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614806104e35750600260009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16145b156105d557600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff166302859d6084846000604051602001526040518363ffffffff167c01000000000000000000000000000000000000000000000000000000000281526004018083600019166000191681526020018273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200192505050602060405180830381600087803b15156105ba57fe5b60325a03f115156105c757fe5b5050506040518051905090505b5b5b92915050565b6000600260009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690505b90565b6000600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614806106b25750600260009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16145b1561088a57600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16634f23eb868585856000604051602001526040518463ffffffff167c01000000000000000000000000000000000000000000000000000000000281526004018080602001806020018473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018381038352868181518152602001915080519060200190808383600083146107b1575b8051825260208311156107b15760208201915060208101905060208303925061078d565b505050905090810190601f1680156107dd5780820380516001836020036101000a031916815260200191505b50838103825285818151815260200191508051906020019080838360008314610825575b80518252602083111561082557602082019150602081019050602083039250610801565b505050905090810190601f1680156108515780820380516001836020036101000a031916815260200191505b5095505050505050602060405180830381600087803b151561086f57fe5b60325a03f1151561087c57fe5b5050506040518051905090505b5b5b9392505050565b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16635f893bfa826040518263ffffffff167c0100000000000000000000000000000000000000000000000000000000028152600401808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001915050600060405180830381600087803b151561094b57fe5b60325a03f1151561095857fe5b5050505b50565b600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161480610a085750600260009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16145b15610ade57600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff166341c0e1b56040518163ffffffff167c0100000000000000000000000000000000000000000000000000000000028152600401809050600060405180830381600087803b1515610a9257fe5b60325a03f11515610a9f57fe5b505050600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16ff5b5b5b565b600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161480610bb05750600260009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16145b15610bf85780600260006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505b5b5b50565b600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161480610ca55750600260009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16145b15610ced5780600060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505b5b5b50565b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690505b90565b600060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161480610dc55750600260009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16145b15610e7157600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1663e7996f07826040518263ffffffff167c0100000000000000000000000000000000000000000000000000000000028152600401808260001916600019168152602001915050600060405180830381600087803b1515610e5f57fe5b60325a03f11515610e6c57fe5b5050505b5b5b50565b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1663eb43e033836000604051602001526040518263ffffffff167c0100000000000000000000000000000000000000000000000000000000028152600401808260001916600019168152602001915050602060405180830381600087803b1515610f1557fe5b60325a03f11515610f2257fe5b5050506040518051905090505b9190505600a165627a7a72305820a1b4722dacd2e6d25ba83549efe9c66b18b5799be2a59687cf5738279cf8766e0029a165627a7a72305820c721968970e1abea3089152dfdd4a6ec4647e051088773f1db229f94fc42b0530029";
            var senderAddress = AccountFactory.Address;
            var web3 = Web3Factory.GetWeb3();
            var gas = await web3.Eth.DeployContract.EstimateGasAsync(ABI, BYTE_CODE, senderAddress);
            var transactionReceiptService = new TransactionReceiptPollingService(web3.TransactionManager);
            var receipt = await transactionReceiptService.DeployContractAndWaitForReceiptAsync(
                () =>
                    web3.Eth.DeployContract.SendRequestAsync(ABI, BYTE_CODE, senderAddress,
                        new HexBigInteger(3905820)));
            Assert.NotNull(receipt.ContractAddress);
        }
    }
}