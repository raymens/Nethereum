using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;


namespace Nethereum.Mud.Contracts.World.Systems.BalanceTransferSystem.ContractDefinition
{


    public partial class BalanceTransferSystemDeployment : BalanceTransferSystemDeploymentBase
    {
        public BalanceTransferSystemDeployment() : base(BYTECODE) { }
        public BalanceTransferSystemDeployment(string byteCode) : base(byteCode) { }
    }

    public class BalanceTransferSystemDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x60a06040523060805234801561001457600080fd5b5060805161175f61003060003960006103b3015261175f6000f3fe608060405234801561001057600080fd5b50600436106100725760003560e01c806345ec93541161005057806345ec9354146100e1578063c9c85a60146100f4578063e1af802c1461010757600080fd5b806301ffc9a714610077578063119df25f1461009f57806345afd199146100cc575b600080fd5b61008a610085366004611352565b61010f565b60405190151581526020015b60405180910390f35b6100a76101a8565b60405173ffffffffffffffffffffffffffffffffffffffff9091168152602001610096565b6100df6100da366004611394565b6101b7565b005b604051601f193601358152602001610096565b6100df6101023660046113e5565b6102b4565b6100a7610360565b60007fffffffff0000000000000000000000000000000000000000000000000000000082167fb5dee1270000000000000000000000000000000000000000000000000000000014806101a257507fffffffff0000000000000000000000000000000000000000000000000000000082167f01ffc9a700000000000000000000000000000000000000000000000000000000145b92915050565b60006101b261036a565b905090565b6101bf61039c565b6101d0836101cb6101a8565b61040d565b60006101db8461045d565b905080821115610226576040517f0e0e2d4d00000000000000000000000000000000000000000000000000000000815260048101829052602481018390526044015b60405180910390fd5b610239846102348484611440565b6104f6565b6000808473ffffffffffffffffffffffffffffffffffffffff168460405160006040518083038185875af1925050503d8060008114610294576040519150601f19603f3d011682016040523d82523d6000602084013e610299565b606091505b5091509150816102ac576102ac816105af565b505050505050565b6102bc61039c565b6102c5836105b7565b6102ce826105b7565b6102d782610663565b6102e3836101cb6101a8565b60006102ee8461045d565b905080821115610334576040517f0e0e2d4d000000000000000000000000000000000000000000000000000000008152600481018290526024810183905260440161021d565b610342846102348484611440565b61035a83836103508661045d565b6102349190611453565b50505050565b60006101b26106ae565b7fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffcc36013560601c806103995750335b90565b73ffffffffffffffffffffffffffffffffffffffff7f000000000000000000000000000000000000000000000000000000000000000016300361040b576040517f9f03a02600000000000000000000000000000000000000000000000000000000815260040160405180910390fd5b565b61041782826106b8565b610459576104248261071d565b816040517fd787b73700000000000000000000000000000000000000000000000000000000815260040161021d9291906114b6565b5050565b604080516001808252818301909252600091829190602080830190803683370190505090508281600081518110610496576104966114ee565b602090810291909101015260006104ee7f7462776f726c6400000000000000000042616c616e636573000000000000000083837e2001002000000000000000000000000000000000000000000000000000000061085a565b949350505050565b60408051600180825281830190925260009160208083019080368337019050509050828160008151811061052c5761052c6114ee565b6020026020010181815250506105aa7f7462776f726c6400000000000000000042616c616e636573000000000000000060001b8260008560405160200161057591815260200190565b60408051601f198184030181529190527e20010020000000000000000000000000000000000000000000000000000000610890565b505050565b805160208201fd5b7f6e730000000000000000000000000000000000000000000000000000000000007dffffffffffffffffffffffffffff000000000000000000000000000000008216178114610660577f6e730000000000000000000000000000000000000000000000000000000000008161062b8361071d565b6040517f5c30fb6f00000000000000000000000000000000000000000000000000000000815260040161021d9392919061151d565b50565b61066c816108ac565b610660578061067a8261071d565b6040517ffbf10ce600000000000000000000000000000000000000000000000000000000815260040161021d92919061155e565b60006101b2610949565b60006107067f6e730000000000000000000000000000000000000000000000000000000000007dffffffffffffffffffffffffffff0000000000000000000000000000000085161783610995565b8061071657506107168383610995565b9392505050565b606081601081901b600061073083610a6b565b9050827fffffffffffffffffffffffffffff00000000000000000000000000000000000083161561078b576107867fffffffffffffffffffffffffffff0000000000000000000000000000000000008416610a82565b6107c2565b6040518060400160405280600681526020017f3c726f6f743e00000000000000000000000000000000000000000000000000008152505b7fffffffffffffffffffffffffffffffff000000000000000000000000000000008316156107f8576107f383610a82565b61082f565b6040518060400160405280600681526020017f3c726f6f743e00000000000000000000000000000000000000000000000000008152505b60405160200161084193929190611577565b6040516020818303038152906040529350505050919050565b60006108876108698686610b26565b60ff858116601b0360080285901c166108828587610b7c565b610bb5565b95945050505050565b6108a5858561089f8487610b7c565b85610c06565b5050505050565b6040805160018082528183019092526000918291906020808301908036833701905050905082816000815181106108e5576108e56114ee565b6020908102919091010152600061093d7f746273746f72650000000000000000005265736f75726365496473000000000083837e0101000100000000000000000000000000000000000000000000000000000061085a565b90506104ee8160f81c90565b7f629a4c26e296b22a8e0856e9f6ecb2d1008d7e00081111962cd175fa7488e1755460009073ffffffffffffffffffffffffffffffffffffffff1680610990573391505090565b919050565b6040805160028082526060820183526000928392919060208301908036833701905050905083816000815181106109ce576109ce6114ee565b6020026020010181815250508273ffffffffffffffffffffffffffffffffffffffff1660001b81600181518110610a0757610a076114ee565b60209081029190910101526000610a5f7f7462776f726c640000000000000000005265736f75726365416363657373000083837e0101000100000000000000000000000000000000000000000000000000000061085a565b90506108878160f81c90565b6000610a7960706010611453565b9190911b919050565b606060005b6010811015610ae7577fffffffffffffffffffffffffffffffff000000000000000000000000000000008316600882021b7fff000000000000000000000000000000000000000000000000000000000000001615610ae757600101610a87565b604080517fffffffffffffffffffffffffffffffff000000000000000000000000000000008516602082015281516030909101909152818152806104ee565b60008282604051602001610b3b929190611605565b60408051601f1981840301815291905280516020909101207f86425bff6b57326c7859e89024fe4f238ca327a1ae4a230180dd2f0e88aaa7d9189392505050565b600080805b8360ff16811015610bad57610ba360ff601b83900360080287901c1683611453565b9150600101610b81565b509392505050565b600060208210610bdb57602082048401935060208281610bd757610bd7611641565b0691505b508254600882021b602082900380841115610bad576001850154600882021c82179150509392505050565b7f6f74000000000000000000000000000000000000000000000000000000000000847fffff0000000000000000000000000000000000000000000000000000000000001603610c9057837f8c0b5119d4cec7b284c6b1b39252a03d1e2f2d7451a5895562524c113bb952be848484604051610c83939291906116ac565b60405180910390a261035a565b6000610c9c8585610b26565b90506000610ca986610eaa565b905060005b8151811015610d7e576000828281518110610ccb57610ccb6114ee565b60200260200101519050610cf76004826affffffffffffffffffffff1916610f3390919063ffffffff16565b15610d75576040517f964f667d000000000000000000000000000000000000000000000000000000008152606082901c9063964f667d90610d42908b908b908b908b906004016116e9565b600060405180830381600087803b158015610d5c57600080fd5b505af1158015610d70573d6000803e3d6000fd5b505050505b50600101610cae565b50857f8c0b5119d4cec7b284c6b1b39252a03d1e2f2d7451a5895562524c113bb952be868686604051610db3939291906116ac565b60405180910390a2610dce828565ffffffffffff1685610f51565b60005b8151811015610ea1576000828281518110610dee57610dee6114ee565b60200260200101519050610e1a6008826affffffffffffffffffffff1916610f3390919063ffffffff16565b15610e98576040517fa8ba8721000000000000000000000000000000000000000000000000000000008152606082901c9063a8ba872190610e65908b908b908b908b906004016116e9565b600060405180830381600087803b158015610e7f57600080fd5b505af1158015610e93573d6000803e3d6000fd5b505050505b50600101610dd1565b50505050505050565b60408051600180825281830190925260609160009190602080830190803683370190505090508281600081518110610ee457610ee46114ee565b60209081029190910101526000610f1c7f746273746f726500000000000000000053746f7265486f6f6b730000000000008383610f67565b90506104ee610f2e8260008451610fa1565b61102f565b60008160ff1682610f448560581c90565b1660ff1614905092915050565b6105aa83838351610f628560200190565b611040565b60606104ee610f778585856110ff565b6000610f9c85610f87898961117f565b9060ff166028026038011c64ffffffffff1690565b611192565b600081831180610fb15750835182115b15610fee578383836040517f23230fa300000000000000000000000000000000000000000000000000000000815260040161021d9392919061172d565b60208401610ffc8482611453565b9050600061100a8585611440565b6fffffffffffffffffffffffffffffffff1660809290921b9190911795945050505050565b6060600061071683601560006111b5565b82156110ba576020831061106a5760208304840193506020838161106657611066611641565b0692505b82156110ba5760208390036000600019600885021c1990506008850281811c91508351811c90508119875416828216178755508184116110ab57505061035a565b50600194909401939182900391015b5b602082106110dc5780518455600190930192601f19909101906020016110bb565b811561035a576000600019600884021c8554835182191691161785555050505050565b60008383604051602001611114929190611605565b604051602081830303815290604052805190602001208260f81b7effffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff19167f3b4102da22e32d82fc925482184f16c09fd4281692720b87d124aef6da48a0f1181860001c90509392505050565b600061071661118e8484611230565b5490565b60405160208101601f19603f8484010116604052828252610bad85858584611286565b606060006111c38560801c90565b90506fffffffffffffffffffffffffffffffff851660008582816111e9576111e9611641565b04905060405193506020840160208202810160405281855260005b82811015611224578451871c825293870193602090910190600101611204565b50505050509392505050565b60008282604051602001611245929190611605565b60408051601f1981840301815291905280516020909101207f14e2fcc58e58e68ec7edc30c8d50dccc3ce2714a623ec81f46b6a63922d76569189392505050565b821561130d57602083106112b0576020830484019350602083816112ac576112ac611641565b0692505b821561130d5760208390036000818410156112d35750600019600884021c6112dd565b50600019600882021c5b8554600886021b8184511682198216178452508184116112fe57505061035a565b50600194909401939182900391015b5b6020821061132f5783548152600190930192601f199091019060200161130e565b811561035a576000600019600884021c8251865482191691161782525050505050565b60006020828403121561136457600080fd5b81357fffffffff000000000000000000000000000000000000000000000000000000008116811461071657600080fd5b6000806000606084860312156113a957600080fd5b83359250602084013573ffffffffffffffffffffffffffffffffffffffff811681146113d457600080fd5b929592945050506040919091013590565b6000806000606084860312156113fa57600080fd5b505081359360208301359350604090920135919050565b7f4e487b7100000000000000000000000000000000000000000000000000000000600052601160045260246000fd5b818103818111156101a2576101a2611411565b808201808211156101a2576101a2611411565b60005b83811015611481578181015183820152602001611469565b50506000910152565b600081518084526114a2816020860160208601611466565b601f01601f19169290920160200192915050565b6040815260006114c9604083018561148a565b905073ffffffffffffffffffffffffffffffffffffffff831660208301529392505050565b7f4e487b7100000000000000000000000000000000000000000000000000000000600052603260045260246000fd5b7fffff00000000000000000000000000000000000000000000000000000000000084168152826020820152606060408201526000610887606083018461148a565b8281526040602082015260006104ee604083018461148a565b7fffff0000000000000000000000000000000000000000000000000000000000008416815260007f3a0000000000000000000000000000000000000000000000000000000000000080600284015284516115d8816003860160208901611466565b8084019050816003820152845191506115f8826004830160208801611466565b0160040195945050505050565b8281526000602080830184516020860160005b8281101561163457815184529284019290840190600101611618565b5091979650505050505050565b7f4e487b7100000000000000000000000000000000000000000000000000000000600052601260045260246000fd5b60008151808452602080850194506020840160005b838110156116a157815187529582019590820190600101611685565b509495945050505050565b6060815260006116bf6060830186611670565b65ffffffffffff8516602084015282810360408401526116df818561148a565b9695505050505050565b8481526080602082015260006117026080830186611670565b65ffffffffffff851660408401528281036060840152611722818561148a565b979650505050505050565b606081526000611740606083018661148a565b6020830194909452506040015291905056fea164736f6c6343000818000a";
        public BalanceTransferSystemDeploymentBase() : base(BYTECODE) { }
        public BalanceTransferSystemDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class MsgSenderFunction : MsgSenderFunctionBase { }

    [Function("_msgSender", "address")]
    public class MsgSenderFunctionBase : FunctionMessage
    {

    }

    public partial class MsgValueFunction : MsgValueFunctionBase { }

    [Function("_msgValue", "uint256")]
    public class MsgValueFunctionBase : FunctionMessage
    {

    }

    public partial class WorldFunction : WorldFunctionBase { }

    [Function("_world", "address")]
    public class WorldFunctionBase : FunctionMessage
    {

    }

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class TransferBalanceToAddressFunction : TransferBalanceToAddressFunctionBase { }

    [Function("transferBalanceToAddress")]
    public class TransferBalanceToAddressFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "fromNamespaceId", 1)]
        public virtual byte[] FromNamespaceId { get; set; }
        [Parameter("address", "toAddress", 2)]
        public virtual string ToAddress { get; set; }
        [Parameter("uint256", "amount", 3)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class TransferBalanceToNamespaceFunction : TransferBalanceToNamespaceFunctionBase { }

    [Function("transferBalanceToNamespace")]
    public class TransferBalanceToNamespaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "fromNamespaceId", 1)]
        public virtual byte[] FromNamespaceId { get; set; }
        [Parameter("bytes32", "toNamespaceId", 2)]
        public virtual byte[] ToNamespaceId { get; set; }
        [Parameter("uint256", "amount", 3)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class StoreSplicestaticdataEventDTO : StoreSplicestaticdataEventDTOBase { }

    [Event("Store_SpliceStaticData")]
    public class StoreSplicestaticdataEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "tableId", 1, true)]
        public virtual byte[] TableId { get; set; }
        [Parameter("bytes32[]", "keyTuple", 2, false)]
        public virtual List<byte[]> KeyTuple { get; set; }
        [Parameter("uint48", "start", 3, false)]
        public virtual ulong Start { get; set; }
        [Parameter("bytes", "data", 4, false)]
        public virtual byte[] Data { get; set; }
    }

    public partial class SliceOutofboundsError : SliceOutofboundsErrorBase { }

    [Error("Slice_OutOfBounds")]
    public class SliceOutofboundsErrorBase : IErrorDTO
    {
        [Parameter("bytes", "data", 1)]
        public virtual byte[] Data { get; set; }
        [Parameter("uint256", "start", 2)]
        public virtual BigInteger Start { get; set; }
        [Parameter("uint256", "end", 3)]
        public virtual BigInteger End { get; set; }
    }

    public partial class UnauthorizedCallContextError : UnauthorizedCallContextErrorBase { }
    [Error("UnauthorizedCallContext")]
    public class UnauthorizedCallContextErrorBase : IErrorDTO
    {
    }

    public partial class WorldAccessdeniedError : WorldAccessdeniedErrorBase { }

    [Error("World_AccessDenied")]
    public class WorldAccessdeniedErrorBase : IErrorDTO
    {
        [Parameter("string", "resource", 1)]
        public virtual string Resource { get; set; }
        [Parameter("address", "caller", 2)]
        public virtual string Caller { get; set; }
    }

    public partial class WorldAlreadyinitializedError : WorldAlreadyinitializedErrorBase { }
    [Error("World_AlreadyInitialized")]
    public class WorldAlreadyinitializedErrorBase : IErrorDTO
    {
    }

    public partial class WorldCallbacknotallowedError : WorldCallbacknotallowedErrorBase { }

    [Error("World_CallbackNotAllowed")]
    public class WorldCallbacknotallowedErrorBase : IErrorDTO
    {
        [Parameter("bytes4", "functionSelector", 1)]
        public virtual byte[] FunctionSelector { get; set; }
    }

    public partial class WorldDelegationnotfoundError : WorldDelegationnotfoundErrorBase { }

    [Error("World_DelegationNotFound")]
    public class WorldDelegationnotfoundErrorBase : IErrorDTO
    {
        [Parameter("address", "delegator", 1)]
        public virtual string Delegator { get; set; }
        [Parameter("address", "delegatee", 2)]
        public virtual string Delegatee { get; set; }
    }

    public partial class WorldFunctionselectoralreadyexistsError : WorldFunctionselectoralreadyexistsErrorBase { }

    [Error("World_FunctionSelectorAlreadyExists")]
    public class WorldFunctionselectoralreadyexistsErrorBase : IErrorDTO
    {
        [Parameter("bytes4", "functionSelector", 1)]
        public virtual byte[] FunctionSelector { get; set; }
    }

    public partial class WorldFunctionselectornotfoundError : WorldFunctionselectornotfoundErrorBase { }

    [Error("World_FunctionSelectorNotFound")]
    public class WorldFunctionselectornotfoundErrorBase : IErrorDTO
    {
        [Parameter("bytes4", "functionSelector", 1)]
        public virtual byte[] FunctionSelector { get; set; }
    }

    public partial class WorldInsufficientbalanceError : WorldInsufficientbalanceErrorBase { }

    [Error("World_InsufficientBalance")]
    public class WorldInsufficientbalanceErrorBase : IErrorDTO
    {
        [Parameter("uint256", "balance", 1)]
        public virtual BigInteger Balance { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class WorldInterfacenotsupportedError : WorldInterfacenotsupportedErrorBase { }

    [Error("World_InterfaceNotSupported")]
    public class WorldInterfacenotsupportedErrorBase : IErrorDTO
    {
        [Parameter("address", "contractAddress", 1)]
        public virtual string ContractAddress { get; set; }
        [Parameter("bytes4", "interfaceId", 2)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class WorldInvalidnamespaceError : WorldInvalidnamespaceErrorBase { }

    [Error("World_InvalidNamespace")]
    public class WorldInvalidnamespaceErrorBase : IErrorDTO
    {
        [Parameter("bytes14", "namespace", 1)]
        public virtual byte[] Namespace { get; set; }
    }

    public partial class WorldInvalidresourceidError : WorldInvalidresourceidErrorBase { }

    [Error("World_InvalidResourceId")]
    public class WorldInvalidresourceidErrorBase : IErrorDTO
    {
        [Parameter("bytes32", "resourceId", 1)]
        public virtual byte[] ResourceId { get; set; }
        [Parameter("string", "resourceIdString", 2)]
        public virtual string ResourceIdString { get; set; }
    }

    public partial class WorldInvalidresourcetypeError : WorldInvalidresourcetypeErrorBase { }

    [Error("World_InvalidResourceType")]
    public class WorldInvalidresourcetypeErrorBase : IErrorDTO
    {
        [Parameter("bytes2", "expected", 1)]
        public virtual byte[] Expected { get; set; }
        [Parameter("bytes32", "resourceId", 2)]
        public virtual byte[] ResourceId { get; set; }
        [Parameter("string", "resourceIdString", 3)]
        public virtual string ResourceIdString { get; set; }
    }

    public partial class WorldResourcealreadyexistsError : WorldResourcealreadyexistsErrorBase { }

    [Error("World_ResourceAlreadyExists")]
    public class WorldResourcealreadyexistsErrorBase : IErrorDTO
    {
        [Parameter("bytes32", "resourceId", 1)]
        public virtual byte[] ResourceId { get; set; }
        [Parameter("string", "resourceIdString", 2)]
        public virtual string ResourceIdString { get; set; }
    }

    public partial class WorldResourcenotfoundError : WorldResourcenotfoundErrorBase { }

    [Error("World_ResourceNotFound")]
    public class WorldResourcenotfoundErrorBase : IErrorDTO
    {
        [Parameter("bytes32", "resourceId", 1)]
        public virtual byte[] ResourceId { get; set; }
        [Parameter("string", "resourceIdString", 2)]
        public virtual string ResourceIdString { get; set; }
    }

    public partial class WorldSystemalreadyexistsError : WorldSystemalreadyexistsErrorBase { }

    [Error("World_SystemAlreadyExists")]
    public class WorldSystemalreadyexistsErrorBase : IErrorDTO
    {
        [Parameter("address", "system", 1)]
        public virtual string System { get; set; }
    }

    public partial class WorldUnlimiteddelegationnotallowedError : WorldUnlimiteddelegationnotallowedErrorBase { }
    [Error("World_UnlimitedDelegationNotAllowed")]
    public class WorldUnlimiteddelegationnotallowedErrorBase : IErrorDTO
    {
    }

    public partial class MsgSenderOutputDTO : MsgSenderOutputDTOBase { }

    [FunctionOutput]
    public class MsgSenderOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "sender", 1)]
        public virtual string Sender { get; set; }
    }

    public partial class MsgValueOutputDTO : MsgValueOutputDTOBase { }

    [FunctionOutput]
    public class MsgValueOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "value", 1)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class WorldOutputDTO : WorldOutputDTOBase { }

    [FunctionOutput]
    public class WorldOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }




}