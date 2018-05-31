using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;

namespace NethereumTryOut.Models
{
    public class EthereumContractInfo : TableEntity
    {
        public string Abi { get; set; }
        public string Bytecode { get; set; }
        public string TransactionHash { get; set; }
        public string ContractAddress { get; set; }

        public EthereumContractInfo()
        {

        }

        public EthereumContractInfo(string name, string abi, string bytecode, string transactionHash)
        {
            PartitionKey = "contract";
            RowKey = name;
            Abi = abi;
            Bytecode = bytecode;
            TransactionHash = transactionHash;
        }
    }

}