using System;
using System.Text.RegularExpressions;

namespace Zenon
{
    public static class Constants
    {
        // Global constants
        public const string ZnnSdkVersion = "0.0.4";
        public const string ZnnRootDirectory = "znn";

        public const int NetId = 1; // Alphanet

        public static string ZnnDefaultDirectory = ZnnPaths.Default.Main;
        public static string ZnnDefaultWalletDirectory = ZnnPaths.Default.Wallet;
        public static string ZnnDefaultCacheDirectory = ZnnPaths.Default.Cache;

        // Client constants
        public const int DefaultHttpPort = 35997;
        public const int DefaultWsPort = 35998;
        public const int NumRetries = 10;
        public const int RpcMaxPageSize = 1024;
        public const int MemoryPoolPageSize = 50;

        // NoM constants
        public const int ZnnDecimals = 8;
        public const int QsrDecimals = 8;
        public const long OneZnn = 1 * 100000000;
        public const long OneQsr = 1 * 100000000;
        public static readonly TimeSpan IntervalBetweenMomentums = TimeSpan.FromSeconds(10);

        // Embedded constants
        public const long GenesisTimestamp = 1637755200;

        // Plasma
        public const long FuseMinQsrAmount = 10 * OneQsr;
        public const int MinPlasmaAmount = 21000;

        // Pillar
        public const long PillarRegisterZnnAmount = 15000 * OneZnn;
        public const long PillarRegisterQsrAmount = 150000 * OneQsr;
        public const long PillarNameMaxLength = 40;
        public static readonly Regex PillarNameRegExp = new Regex("^([a-zA-Z0-9]+[-._]?)*[a-zA-Z0-9]$");

        // Sentinel
        public const long SentinelRegisterZnnAmount = 5000 * OneZnn;
        public const long SentinelRegisterQsrAmount = 50000 * OneQsr;

        // Staking
        public const long StakeMinZnnAmount = OneZnn;
        public const long StakeTimeUnitSec = 30 * 24 * 60 * 60;
        public const long StakeTimeMaxSec = 12 * StakeTimeUnitSec;
        public const string StakeUnitDurationName = "month";

        // Token
        public const long TokenZtsIssueFeeInZnn = OneZnn;
        public const long TokenNameMaxLength = 40;
        public const long TokenSymbolMaxLength = 10;
        public static readonly string[] TokenSymbolExceptions = new string[] { "ZNN", "QSR" };

        public static readonly Regex TokenNameRegExp = new Regex("^([a-zA-Z0-9]+[-._]?)*[a-zA-Z0-9]$");
        public static readonly Regex TokenSymbolRegExp = new Regex("^[A-Z0-9]+$");
        public static readonly Regex TokenDomainRegExp = new Regex("^([A-Za-z0-9][A-Za-z0-9-]{0,61}[A-Za-z0-9].)+[A-Za-z]{2,}$");

        // Accelerator
        public const int ProjectDescriptionMaxLength = 240;
        public const int ProjectNameMaxLength = 30;
        public const int ProjectCreationFeeInZnn = 1;
        public const int ProjectVotingStatus = 0;
        public const int ProjectActiveStatus = 1;
        public const int ProjectPaidStatus = 2;
        public const int ProjectClosedStatus = 3;
        public static readonly Regex ProjectUrlRegExp = new Regex("^[a-zA-Z0-9]{2,60}.[a-zA-Z]{1,6}([a-zA-Z0-9()@:%_\\+.~#?&/=-]{0,100})$");

        // Swap
        public const int SwapAssetDecayTimestampStart = 1645531200;
        public const int SwapAssetDecayEpochsOffset = 30 * 3;
        public const int SwapAssetDecayTickEpochs = 30;
        public const int SwapAssetDecayTickValuePercentage = 10;
    }
}