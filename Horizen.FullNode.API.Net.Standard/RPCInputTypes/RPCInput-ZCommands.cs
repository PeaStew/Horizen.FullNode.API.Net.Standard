using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace Horizen.FullNode.API.Net.Standard.RPCInputTypes
{
    public enum ZImportKeyRescanType
    {
        [EnumMember(Value = "Yes")]
        [Description("Yes")]
        Yes,
        [EnumMember(Value = "No")]
        [Description("NO")]
        No,
        [EnumMember(Value = "whenkeyisnew")]
        [Description("WHENKEYISNEW")]
        WhenKeyIsNew
    }

    public enum ZListOperationIdsStatusType
    {
        [EnumMember(Value = "Success")]
        [Description("SUCCESS")]
        Success,
        [EnumMember(Value = "Executing")]
        [Description("EXECUTING")]
        Executing,
        [EnumMember(Value = "Failed")]
        [Description("FAILED")]
        Failed,
        [EnumMember(Value = "All")]
        [Description("All")]
        All

    }

    public class ZSendManyAmountsInput
    {
        public string address { get; set; }
        public double amount { get; set; }
        public string memo { get; set; }
    }

    public enum ZCBenchmarkType
    {
        [EnumMember(Value = "sleep")]
        [Description("sleep")]
        Sleep,
        [EnumMember(Value = "parameterloading")]
        [Description("parameterloading")]
        ParameterLoading,
        [EnumMember(Value = "createjoinsplit")]
        [Description("createjoinsplit")]
        CreateJoinsplit,
        [EnumMember(Value = "verifyjoinsplit")]
        [Description("verifyjoinsplit")]
        VerifyJoinsplit,
        [EnumMember(Value = "solveequihash")]
        [Description("solveequihash")]
        SolveEquihash,
        [EnumMember(Value = "verifyequihash")]
        [Description("verifyequihash")]
        VerifyEquihash,
        [EnumMember(Value = "validatelargetx")]
        [Description("validatelargetx")]
        ValidateLargeTx,
        [EnumMember(Value = "trydecryptnotes")]
        [Description("trydecryptnotes")]
        TryDecryptNotes,
        [EnumMember(Value = "incnotewitness")]
        [Description("incnotewitness")]
        IncNoteWitness,
        [EnumMember(Value = "connectblockslow")]
        [Description("connectblockslow")]
        ConnectBlockSlow,
        [EnumMember(Value = "sendtoaddress")]
        [Description("sendtoaddress")]
        SendToAddress,
        [EnumMember(Value = "loadwallet")]
        [Description("loadwallet")]
        LoadWallet,
        [EnumMember(Value = "listunspent")]
        [Description("listunspent")]
        ListUnspent
    }
}
