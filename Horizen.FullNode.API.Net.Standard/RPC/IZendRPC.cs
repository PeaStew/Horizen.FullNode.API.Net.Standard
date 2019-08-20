using System;
using System.Collections.Generic;
using System.Xml.Linq;


namespace Horizen.FullNode.API.Net.Standard.RPC
{
    public interface IZendRPC: IZendRPCBlockchain, IZendRPCControl, IZendRPCDisclosure, IZendRPCGenerating, IZendRPCMining, IZendRPCNetwork, IZendRPCRawTransaction, IZendRPCUtil, IZendRPCWallet, IZendRPCZCommands
    {
        T GetRPCTypedResult<T>(RPCConnection rpc, string method, object[] _params);
    }
}
//        /* Commands
//         * == Blockchain ==
//getbestblockhash
//getblock "hash|height" ( verbose )
//getblockchaininfo
//getblockcount
//getblockhash index
//getblockheader "hash" ( verbose )
//getchaintips
//getdifficulty
//getmempoolinfo
//getrawmempool ( verbose )
//gettxout "txid" n ( includemempool )
//gettxoutproof ["txid",...] ( blockhash )
//gettxoutsetinfo
//verifychain ( checklevel numblocks )
//verifytxoutproof "proof"

//== Control ==
//getinfo
//help ( "command" )
//stop

//== Disclosure ==
//z_getpaymentdisclosure "txid" "js_index" "output_index" ("message")
//z_validatepaymentdisclosure "paymentdisclosure"

//== Generating ==
//generate numblocks
//getgenerate
//setgenerate generate ( genproclimit )

//== Mining ==
//getblocksubsidy height
//getblocktemplate ( "jsonrequestobject" )
//getlocalsolps
//getmininginfo
//getnetworkhashps ( blocks height )
//getnetworksolps ( blocks height )
//prioritisetransaction <txid> <priority delta> <fee delta>
//submitblock "hexdata" ( "jsonparametersobject" )

//== Network ==
//addnode "node" "add|remove|onetry"
//clearbanned
//disconnectnode "node"
//getaddednodeinfo dns ( "node" )
//getconnectioncount
//getnettotals
//getnetworkinfo
//getpeerinfo
//listbanned
//ping
//setban "ip(/netmask)" "add|remove" (bantime) (absolute)

//== Rawtransactions ==
//createrawtransaction [{"txid":"id","vout":n},...] {"address":amount,...}
//decoderawtransaction "hexstring"
//decodescript "hex"
//fundrawtransaction "hexstring"
//getrawtransaction "txid" ( verbose )
//sendrawtransaction "hexstring" ( allowhighfees )
//signrawtransaction "hexstring" ( [{"txid":"id","vout":n,"scriptPubKey":"hex","redeemScript":"hex"},...] ["privatekey1",...] sighashtype )

//== Util ==
//createmultisig nrequired ["key",...]
//estimatefee nblocks
//estimatepriority nblocks
//validateaddress "zcashaddress"
//verifymessage "zcashaddress" "signature" "message"
//z_validateaddress "zaddr"

//== Wallet ==
//addmultisigaddress nrequired ["key",...] ( "account" )
//backupwallet "destination"
//dumpprivkey "horizenaddress"
//dumpwallet "filename"
//encryptwallet "passphrase"
//getaccount "horizenaddress"
//getaccountaddress "account"
//getaddressesbyaccount "account"
//getbalance ( "account" minconf includeWatchonly )
//getnewaddress ( "account" )
//getrawchangeaddress
//getreceivedbyaccount "account" ( minconf )
//getreceivedbyaddress "horizenaddress" ( minconf )
//gettransaction "txid" ( includeWatchonly )
//getunconfirmedbalance
//getwalletinfo
//importaddress "address" ( "label" rescan )
//importprivkey "horizenprivkey" ( "label" rescan )
//importwallet "filename"
//keypoolrefill ( newsize )
//listaccounts ( minconf includeWatchonly)
//listaddresses
//listaddressgroupings
//listlockunspent
//listreceivedbyaccount ( minconf includeempty includeWatchonly)
//listreceivedbyaddress ( minconf includeempty includeWatchonly)
//listsinceblock ( "blockhash" target-confirmations includeWatchonly)
//listtransactions ( "account" count from includeWatchonly)
//listunspent ( minconf maxconf  ["address",...] )
//lockunspent unlock [{"txid":"txid","vout":n},...]
//move "fromaccount" "toaccount" amount ( minconf "comment" )
//sendfrom "fromaccount" "tohorizenaddress" amount ( minconf "comment" "comment-to" )
//sendmany "fromaccount" {"address":amount,...} ( minconf "comment" ["address",...] )
//sendtoaddress "horizenaddress" amount ( "comment" "comment-to" subtractfeefromamount )
//setaccount "horizenaddress" "account"
//settxfee amount
//signmessage "horizenaddress" "message"
//z_exportkey "zaddr"
//z_exportviewingkey "zaddr"
//z_exportwallet "filename"
//z_getbalance "address" ( minconf )
//z_getnewaddress
//z_getoperationresult (["operationid", ... ])
//z_getoperationstatus (["operationid", ... ])
//z_gettotalbalance ( minconf includeWatchonly )
//z_importkey "zkey" ( rescan startHeight )
//z_importviewingkey "vkey" ( rescan startHeight )
//z_importwallet "filename"
//z_listaddresses ( includeWatchonly )
//z_listoperationids
//z_listreceivedbyaddress "address" ( minconf )
//z_sendmany "fromaddress" [{"address":... ,"amount":...},...] ( minconf ) ( fee )
//z_shieldcoinbase "fromaddress" "tozaddress" ( fee ) ( limit )
//zcbenchmark benchmarktype samplecount
//zcrawjoinsplit rawtx inputs outputs vpub_old vpub_new
//zcrawkeygen
//zcrawreceive zcsecretkey encryptednote
//zcsamplejoinsplit