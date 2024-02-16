using System;
using Foundation;
using ObjCRuntime;

namespace CaptuvoSDK
{
    // @interface SledFirmwareHeader : NSObject
    [BaseType(typeof(NSObject))]
    interface SledFirmwareHeader
    {
        // @property (assign, nonatomic) NSInteger ver;
        [Export("ver")]
        nint Ver { get; set; }

        // @property (assign, nonatomic) NSInteger size;
        [Export("size")]
        nint Size { get; set; }

        // @property (nonatomic, strong) NSString * version;
        [Export("version", ArgumentSemantic.Strong)]
        string Version { get; set; }

        // @property (nonatomic, strong) NSString * type;
        [Export("type", ArgumentSemantic.Strong)]
        string Type { get; set; }

        // @property (nonatomic, strong) NSString * date;
        [Export("date", ArgumentSemantic.Strong)]
        string Date { get; set; }

        // @property (nonatomic, strong) NSString * time;
        [Export("time", ArgumentSemantic.Strong)]
        string Time { get; set; }
    }

    // @interface UPCA : NSObject
    [BaseType(typeof(NSObject))]
    interface UPCA
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) BOOL enableCheckDigit;
        [Export("enableCheckDigit")]
        bool EnableCheckDigit { get; set; }

        // @property (assign, nonatomic) BOOL enableNumberSystem;
        [Export("enableNumberSystem")]
        bool EnableNumberSystem { get; set; }

        // @property (assign, nonatomic) BOOL enable2DigitAddenda;
        [Export("enable2DigitAddenda")]
        bool Enable2DigitAddenda { get; set; }

        // @property (assign, nonatomic) BOOL enable5DigitAddenda;
        [Export("enable5DigitAddenda")]
        bool Enable5DigitAddenda { get; set; }

        // @property (assign, nonatomic) BOOL requireAddenda;
        [Export("requireAddenda")]
        bool RequireAddenda { get; set; }

        // @property (assign, nonatomic) BOOL enableAddendaSeparator;
        [Export("enableAddendaSeparator")]
        bool EnableAddendaSeparator { get; set; }

        // @property UPCA_EAN13_ExtendedCouponCode extendedCouponCode;
        [Export("extendedCouponCode", ArgumentSemantic.Assign)]
        UPCA_EAN13_ExtendedCouponCode ExtendedCouponCode { get; set; }
    }

    // @interface UPCE0 : NSObject
    [BaseType(typeof(NSObject))]
    interface UPCE0
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) BOOL enableExpand;
        [Export("enableExpand")]
        bool EnableExpand { get; set; }

        // @property (assign, nonatomic) BOOL requireAddenda;
        [Export("requireAddenda")]
        bool RequireAddenda { get; set; }

        // @property (assign, nonatomic) BOOL enableAddendaSeparator;
        [Export("enableAddendaSeparator")]
        bool EnableAddendaSeparator { get; set; }

        // @property (assign, nonatomic) BOOL enableCheckDigit;
        [Export("enableCheckDigit")]
        bool EnableCheckDigit { get; set; }

        // @property (assign, nonatomic) BOOL enableNumberSystem;
        [Export("enableNumberSystem")]
        bool EnableNumberSystem { get; set; }

        // @property (assign, nonatomic) BOOL enable2DigitAddenda;
        [Export("enable2DigitAddenda")]
        bool Enable2DigitAddenda { get; set; }

        // @property (assign, nonatomic) BOOL enable5DigitAddenda;
        [Export("enable5DigitAddenda")]
        bool Enable5DigitAddenda { get; set; }

        // @property (assign, nonatomic) BOOL enableUPCE1;
        [Export("enableUPCE1")]
        bool EnableUPCE1 { get; set; }
    }

    // @interface EAN13 : NSObject
    [BaseType(typeof(NSObject))]
    interface EAN13
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) BOOL enableCheckDigit;
        [Export("enableCheckDigit")]
        bool EnableCheckDigit { get; set; }

        // @property (assign, nonatomic) BOOL enable2DigitAddenda;
        [Export("enable2DigitAddenda")]
        bool Enable2DigitAddenda { get; set; }

        // @property (assign, nonatomic) BOOL enable5DigitAddenda;
        [Export("enable5DigitAddenda")]
        bool Enable5DigitAddenda { get; set; }

        // @property (assign, nonatomic) BOOL requireAddenda;
        [Export("requireAddenda")]
        bool RequireAddenda { get; set; }

        // @property (assign, nonatomic) BOOL enableAddendaSeparator;
        [Export("enableAddendaSeparator")]
        bool EnableAddendaSeparator { get; set; }

        // @property (assign, nonatomic) BOOL enableISBNtranslate;
        [Export("enableISBNtranslate")]
        bool EnableISBNtranslate { get; set; }
    }

    // @interface EAN8 : NSObject
    [BaseType(typeof(NSObject))]
    interface EAN8
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) BOOL enableCheckDigit;
        [Export("enableCheckDigit")]
        bool EnableCheckDigit { get; set; }

        // @property (assign, nonatomic) BOOL enable2DigitAddenda;
        [Export("enable2DigitAddenda")]
        bool Enable2DigitAddenda { get; set; }

        // @property (assign, nonatomic) BOOL enable5DigitAddenda;
        [Export("enable5DigitAddenda")]
        bool Enable5DigitAddenda { get; set; }

        // @property (assign, nonatomic) BOOL requireAddenda;
        [Export("requireAddenda")]
        bool RequireAddenda { get; set; }

        // @property (assign, nonatomic) BOOL enableAddendaSeparator;
        [Export("enableAddendaSeparator")]
        bool EnableAddendaSeparator { get; set; }
    }

    // @interface Codabar : NSObject
    [BaseType(typeof(NSObject))]
    interface Codabar
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) BOOL transmitStatStopChar;
        [Export("transmitStatStopChar")]
        bool TransmitStatStopChar { get; set; }

        // @property (assign, nonatomic) CodabarCheckChar checkCharStatus;
        [Export("checkCharStatus", ArgumentSemantic.Assign)]
        CodabarCheckChar CheckCharStatus { get; set; }

        // @property (assign, nonatomic) CodabarConcatenation concatenationStatus;
        [Export("concatenationStatus", ArgumentSemantic.Assign)]
        CodabarConcatenation ConcatenationStatus { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }
    }

    // @interface Code39 : NSObject
    [BaseType(typeof(NSObject))]
    interface Code39
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) BOOL transmitStatStopChar;
        [Export("transmitStatStopChar")]
        bool TransmitStatStopChar { get; set; }

        // @property (assign, nonatomic) Code39CheckChar checkCharStatus;
        [Export("checkCharStatus", ArgumentSemantic.Assign)]
        Code39CheckChar CheckCharStatus { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }

        // @property (assign, nonatomic) BOOL enableAppendMode;
        [Export("enableAppendMode")]
        bool EnableAppendMode { get; set; }

        // @property (assign, nonatomic) BOOL enableCode32Pharmaceutical;
        [Export("enableCode32Pharmaceutical")]
        bool EnableCode32Pharmaceutical { get; set; }

        // @property (assign, nonatomic) BOOL enableFullASCII;
        [Export("enableFullASCII")]
        bool EnableFullASCII { get; set; }
    }

    // @interface Interleaved2of5 : NSObject
    [BaseType(typeof(NSObject))]
    interface Interleaved2of5
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) Interleaved2of5CheckChar checkCharStatus;
        [Export("checkCharStatus", ArgumentSemantic.Assign)]
        Interleaved2of5CheckChar CheckCharStatus { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }
    }

    // @interface NEC2of5 : NSObject
    [BaseType(typeof(NSObject))]
    interface NEC2of5
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) NEC2of5CheckChar checkCharStatus;
        [Export("checkCharStatus", ArgumentSemantic.Assign)]
        NEC2of5CheckChar CheckCharStatus { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }
    }

    // @interface Code93 : NSObject
    [BaseType(typeof(NSObject))]
    interface Code93
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }
    }

    // @interface Straight2of5Industrial : NSObject
    [BaseType(typeof(NSObject))]
    interface Straight2of5Industrial
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }
    }

    // @interface Straight2of5IATA : NSObject
    [BaseType(typeof(NSObject))]
    interface Straight2of5IATA
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }
    }

    // @interface Matrix2of5 : NSObject
    [BaseType(typeof(NSObject))]
    interface Matrix2of5
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }
    }

    // @interface Code11 : NSObject
    [BaseType(typeof(NSObject))]
    interface Code11
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }

        // @property (assign, nonatomic) Code11CheckDigit checkDigit;
        [Export("checkDigit", ArgumentSemantic.Assign)]
        Code11CheckDigit CheckDigit { get; set; }
    }

    // @interface Code128 : NSObject
    [BaseType(typeof(NSObject))]
    interface Code128
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }

        // @property (assign, nonatomic) BOOL enableISBTconcatenation;
        [Export("enableISBTconcatenation")]
        bool EnableISBTconcatenation { get; set; }
    }

    // @interface GS1_128 : NSObject
    [BaseType(typeof(NSObject))]
    interface GS1_128
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }
    }

    // @interface Telepen : NSObject
    [BaseType(typeof(NSObject))]
    interface Telepen
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }

        // @property (assign, nonatomic) TelepenOutput output;
        [Export("output", ArgumentSemantic.Assign)]
        TelepenOutput Output { get; set; }
    }

    // @interface MSI : NSObject
    [BaseType(typeof(NSObject))]
    interface MSI
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }

        // @property (assign, nonatomic) MSICheckChar checkChar;
        [Export("checkChar", ArgumentSemantic.Assign)]
        MSICheckChar CheckChar { get; set; }
    }

    // @interface GS1DataBarOmnidirectional : NSObject
    [BaseType(typeof(NSObject))]
    interface GS1DataBarOmnidirectional
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) BOOL enableGS1CompositeCodes;
        [Export("enableGS1CompositeCodes")]
        bool EnableGS1CompositeCodes { get; set; }

        // @property (assign, nonatomic) BOOL enableUPC_EANversion;
        [Export("enableUPC_EANversion")]
        bool EnableUPC_EANversion { get; set; }

        // @property (assign, nonatomic) int compositeCodeMinMessageLength;
        [Export("compositeCodeMinMessageLength")]
        int CompositeCodeMinMessageLength { get; set; }

        // @property (assign, nonatomic) int compositeCodeMaxMessageLength;
        [Export("compositeCodeMaxMessageLength")]
        int CompositeCodeMaxMessageLength { get; set; }

        // @property (assign, nonatomic) GS1Emulation emulationMode;
        [Export("emulationMode", ArgumentSemantic.Assign)]
        GS1Emulation EmulationMode { get; set; }
    }

    // @interface GS1DataBarLimited : NSObject
    [BaseType(typeof(NSObject))]
    interface GS1DataBarLimited
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) BOOL enableGS1CompositeCodes;
        [Export("enableGS1CompositeCodes")]
        bool EnableGS1CompositeCodes { get; set; }

        // @property (assign, nonatomic) BOOL enableUPC_EANversion;
        [Export("enableUPC_EANversion")]
        bool EnableUPC_EANversion { get; set; }

        // @property (assign, nonatomic) int compositeCodeMinMessageLength;
        [Export("compositeCodeMinMessageLength")]
        int CompositeCodeMinMessageLength { get; set; }

        // @property (assign, nonatomic) int compositeCodeMaxMessageLength;
        [Export("compositeCodeMaxMessageLength")]
        int CompositeCodeMaxMessageLength { get; set; }

        // @property (assign, nonatomic) GS1Emulation emulationMode;
        [Export("emulationMode", ArgumentSemantic.Assign)]
        GS1Emulation EmulationMode { get; set; }
    }

    // @interface GS1DataBarExpanded : NSObject
    [BaseType(typeof(NSObject))]
    interface GS1DataBarExpanded
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }

        // @property (assign, nonatomic) BOOL enableGS1CompositeCodes;
        [Export("enableGS1CompositeCodes")]
        bool EnableGS1CompositeCodes { get; set; }

        // @property (assign, nonatomic) BOOL enableUPC_EANversion;
        [Export("enableUPC_EANversion")]
        bool EnableUPC_EANversion { get; set; }

        // @property (assign, nonatomic) int compositeCodeMinMessageLength;
        [Export("compositeCodeMinMessageLength")]
        int CompositeCodeMinMessageLength { get; set; }

        // @property (assign, nonatomic) int compositeCodeMaxMessageLength;
        [Export("compositeCodeMaxMessageLength")]
        int CompositeCodeMaxMessageLength { get; set; }

        // @property (assign, nonatomic) GS1Emulation emulationMode;
        [Export("emulationMode", ArgumentSemantic.Assign)]
        GS1Emulation EmulationMode { get; set; }
    }

    // @interface CodablockA : NSObject
    [BaseType(typeof(NSObject))]
    interface CodablockA
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }
    }

    // @interface CodablockF : NSObject
    [BaseType(typeof(NSObject))]
    interface CodablockF
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }
    }

    // @interface PDF417 : NSObject
    [BaseType(typeof(NSObject))]
    interface PDF417
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }
    }

    // @interface ChineseSensible : NSObject
    [BaseType(typeof(NSObject))]
    interface ChineseSensible
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }
    }

    // @interface Aztec : NSObject
    [BaseType(typeof(NSObject))]
    interface Aztec
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }
    }

    // @interface MaxiCode : NSObject
    [BaseType(typeof(NSObject))]
    interface MaxiCode
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }
    }

    // @interface DataMatrix : NSObject
    [BaseType(typeof(NSObject))]
    interface DataMatrix
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }
    }

    // @interface MicroPDF417 : NSObject
    [BaseType(typeof(NSObject))]
    interface MicroPDF417
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }
    }

    // @interface TCIFLinkedCode39 : NSObject
    [BaseType(typeof(NSObject))]
    interface TCIFLinkedCode39
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }
    }

    // @interface QRCode : NSObject
    [BaseType(typeof(NSObject))]
    interface QRCode
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) int minMessageLength;
        [Export("minMessageLength")]
        int MinMessageLength { get; set; }

        // @property (assign, nonatomic) int maxMessageLength;
        [Export("maxMessageLength")]
        int MaxMessageLength { get; set; }
    }

    // @interface cupertinoBatteryCharger : NSObject
    [BaseType(typeof(NSObject))]
    interface cupertinoBatteryCharger
    {
        // @property (assign, nonatomic) BOOL enable;
        [Export("enable")]
        bool Enable { get; set; }

        // @property (assign, nonatomic) UInt8 start;
        [Export("start")]
        byte Start { get; set; }

        // @property (assign, nonatomic) UInt8 stop;
        [Export("stop")]
        byte Stop { get; set; }

        // @property (assign, nonatomic) UInt8 sledminLimitPower;
        [Export("sledminLimitPower")]
        byte SledminLimitPower { get; set; }
    }

    // @interface cupertinoBatteryDetailInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface cupertinoBatteryDetailInfo
    {
        // @property (assign, nonatomic) BOOL valid;
        [Export("valid")]
        bool Valid { get; set; }

        // @property (assign, nonatomic) UInt16 percentage;
        [Export("percentage")]
        ushort Percentage { get; set; }

        // @property (assign, nonatomic) UInt16 remainCapacity;
        [Export("remainCapacity")]
        ushort RemainCapacity { get; set; }

        // @property (assign, nonatomic) UInt16 totalCapacity;
        [Export("totalCapacity")]
        ushort TotalCapacity { get; set; }

        // @property (assign, nonatomic) CGFloat temperture;
        [Export("temperture")]
        nfloat Temperture { get; set; }

        // @property (assign, nonatomic) CGFloat voltage;
        [Export("voltage")]
        nfloat Voltage { get; set; }
    }

    // @interface cupertinoBatteryChargingInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface cupertinoBatteryChargingInfo
    {
        // @property (assign, nonatomic) BOOL isExternalPowerPlugin;
        [Export("isExternalPowerPlugin")]
        bool IsExternalPowerPlugin { get; set; }

        // @property (assign, nonatomic) BOOL isChargingforCupertino;
        [Export("isChargingforCupertino")]
        bool IsChargingforCupertino { get; set; }

        // @property (assign, nonatomic) BOOL reserved;
        [Export("reserved")]
        bool Reserved { get; set; }
    }

    // @interface LedSchemeResponse : NSObject
    [BaseType(typeof(NSObject))]
    interface LedSchemeResponse
    {
        // @property (assign, nonatomic) BOOL bConfigSuccess;
        [Export("bConfigSuccess")]
        bool BConfigSuccess { get; set; }

        // @property (assign, nonatomic) LedScheme scheme;
        [Export("scheme", ArgumentSemantic.Assign)]
        LedScheme Scheme { get; set; }
    }

    // @protocol CaptuvoEventsProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CaptuvoEventsProtocol
    {
        // @optional -(void)captuvoConnected;
        [Export("captuvoConnected")]
        void CaptuvoConnected();

        // @optional -(void)captuvoDisconnected;
        [Export("captuvoDisconnected")]
        void CaptuvoDisconnected();

        // @optional -(void)decoderReady;
        [Export("decoderReady")]
        void DecoderReady();

        // @optional -(void)msrReady;
        [Export("msrReady")]
        void MsrReady();

        // @optional -(void)pmReady;
        [Export("pmReady")]
        void PmReady();

        // @optional -(void)decoderDataReceived:(NSString *)data;
        [Export("decoderDataReceived:")]
        void DecoderDataReceived(string data);

        // @optional -(void)decoderRawDataReceived:(NSData *)data;
        [Export("decoderRawDataReceived:")]
        void DecoderRawDataReceived(NSData data);

        // @optional -(void)decoderRevisionReceived:(NSString *)revision;
        [Export("decoderRevisionReceived:")]
        void DecoderRevisionReceived(string revision);

        // @optional -(void)decoderSoftwareRevision:(NSString *)revision;
        [Export("decoderSoftwareRevision:")]
        void DecoderSoftwareRevision(string revision);

        // @optional -(void)decoderDriverRevision:(NSString *)revision;
        [Export("decoderDriverRevision:")]
        void DecoderDriverRevision(string revision);

        // @optional -(void)decoderSerialNumber:(NSString *)seralNumber;
        [Export("decoderSerialNumber:")]
        void DecoderSerialNumber(string seralNumber);

        // @optional -(void)EngineSerialNumber:(NSString *)seralNumber;
        [Export("EngineSerialNumber:")]
        void EngineSerialNumber(string seralNumber);

        // @optional -(void)decoderBeeperForGoodReadStatus:(BOOL)isEnabled;
        [Export("decoderBeeperForGoodReadStatus:")]
        void DecoderBeeperForGoodReadStatus(bool isEnabled);

        // @optional -(void)decoderTriggerClickStatus:(BOOL)isEnabled;
        [Export("decoderTriggerClickStatus:")]
        void DecoderTriggerClickStatus(bool isEnabled);

        // @optional -(void)decoderPowerUpBeepStatus:(BOOL)isEnabled;
        [Export("decoderPowerUpBeepStatus:")]
        void DecoderPowerUpBeepStatus(bool isEnabled);

        // @optional -(void)decoderGoodReadBeeperVolumeStatus:(BeeperVolume)volume;
        [Export("decoderGoodReadBeeperVolumeStatus:")]
        void DecoderGoodReadBeeperVolumeStatus(BeeperVolume volume);

        // @optional -(void)decoderBeeperPitchGoodReadStatus:(BeeperPitch)pitch;
        [Export("decoderBeeperPitchGoodReadStatus:")]
        void DecoderBeeperPitchGoodReadStatus(BeeperPitch pitch);

        // @optional -(void)decoderBeeperPitchErrorStatus:(BeeperErrorPitch)pitch;
        [Export("decoderBeeperPitchErrorStatus:")]
        void DecoderBeeperPitchErrorStatus(BeeperErrorPitch pitch);

        // @optional -(void)decoderBeeperDurationGoodReadStatus:(BeeperDuration)duration;
        [Export("decoderBeeperDurationGoodReadStatus:")]
        void DecoderBeeperDurationGoodReadStatus(BeeperDuration duration);

        // @optional -(void)decoderNumberOfBeepsGoodReadStatus:(int)numberOfBeeps;
        [Export("decoderNumberOfBeepsGoodReadStatus:")]
        void DecoderNumberOfBeepsGoodReadStatus(int numberOfBeeps);

        // @optional -(void)decoderNumberOfBeepsErrorStatus:(int)numberOfBeeps;
        [Export("decoderNumberOfBeepsErrorStatus:")]
        void DecoderNumberOfBeepsErrorStatus(int numberOfBeeps);

        // @optional -(void)decoderGoodReadDelayInMilliSecondsStatus:(int)milliseconds;
        [Export("decoderGoodReadDelayInMilliSecondsStatus:")]
        void DecoderGoodReadDelayInMilliSecondsStatus(int milliseconds);

        // @optional -(void)decoderSerialTriggerTimeoutInMilliSecondsStatus:(int)milliseconds;
        [Export("decoderSerialTriggerTimeoutInMilliSecondsStatus:")]
        void DecoderSerialTriggerTimeoutInMilliSecondsStatus(int milliseconds);

        // @optional -(void)decoderInterlacedAimerModeStatus:(BOOL)isEnabled;
        [Export("decoderInterlacedAimerModeStatus:")]
        void DecoderInterlacedAimerModeStatus(bool isEnabled);

        // @optional -(void)decoderPreferredSymbologyStatus:(BOOL)isEnabled;
        [Export("decoderPreferredSymbologyStatus:")]
        void DecoderPreferredSymbologyStatus(bool isEnabled);

        // @optional -(void)decoderHighPrioritySymbologyStatus:(Symbology)symbology;
        [Export("decoderHighPrioritySymbologyStatus:")]
        void DecoderHighPrioritySymbologyStatus(Symbology symbology);

        // @optional -(void)decoderLowPrioritySymbologyStatus:(Symbology)symbology;
        [Export("decoderLowPrioritySymbologyStatus:")]
        void DecoderLowPrioritySymbologyStatus(Symbology symbology);

        // @optional -(void)decoderPreferredSymbologyTimeoutInMilliSecondsStatus:(int)milliseconds;
        [Export("decoderPreferredSymbologyTimeoutInMilliSecondsStatus:")]
        void DecoderPreferredSymbologyTimeoutInMilliSecondsStatus(int milliseconds);

        // @optional -(void)decoderCenteringStatus:(BOOL)isEnabled;
        [Export("decoderCenteringStatus:")]
        void DecoderCenteringStatus(bool isEnabled);

        // @optional -(void)decoderTopOfCenteringWindowLocation:(int)locationAsPrecent;
        [Export("decoderTopOfCenteringWindowLocation:")]
        void DecoderTopOfCenteringWindowLocation(int locationAsPrecent);

        // @optional -(void)decoderBottomOfCenteringWindowLocation:(int)locationAsPrecent;
        [Export("decoderBottomOfCenteringWindowLocation:")]
        void DecoderBottomOfCenteringWindowLocation(int locationAsPrecent);

        // @optional -(void)decoderLeftOfCenteringWindowLocation:(int)locationAsPrecent;
        [Export("decoderLeftOfCenteringWindowLocation:")]
        void DecoderLeftOfCenteringWindowLocation(int locationAsPrecent);

        // @optional -(void)decoderRightOfCenteringWindowLocation:(int)locationAsPrecent;
        [Export("decoderRightOfCenteringWindowLocation:")]
        void DecoderRightOfCenteringWindowLocation(int locationAsPrecent);

        // @optional -(void)decoderPassThroughReturnData:(NSData *)data;
        [Export("decoderPassThroughReturnData:")]
        void DecoderPassThroughReturnData(NSData data);

        // @optional -(void)DecoderEnhancedManualTriggerMode:(NSData *)data;
        [Export("DecoderEnhancedManualTriggerMode:")]
        void DecoderEnhancedManualTriggerMode(NSData data);

        // @optional -(void)triggerKey:(TriggerKeyStatus)status;
        [Export("triggerKey:")]
        void TriggerKey(TriggerKeyStatus status);

        // @optional -(void)msrStringDataReceived:(NSString *)data validData:(BOOL)status;
        [Export("msrStringDataReceived:validData:")]
        void MsrStringDataReceived(string data, bool status);

        // @optional -(void)msrRawDataReceived:(NSData *)data validData:(BOOL)status;
        [Export("msrRawDataReceived:validData:")]
        void MsrRawDataReceived(NSData data, bool status);

        // @optional -(void)msrFirewareVersion:(NSString *)data validData:(BOOL)status;
        [Export("msrFirewareVersion:validData:")]
        void MsrFirewareVersion(string data, bool status);

        // @optional -(void)msrSerialNumber:(NSString *)data validData:(BOOL)status;
        [Export("msrSerialNumber:validData:")]
        void MsrSerialNumber(string data, bool status);

        // @optional -(void)msrCurrentTrackSelection:(TrackSelection)trackSelection validData:(BOOL)status;
        [Export("msrCurrentTrackSelection:validData:")]
        void MsrCurrentTrackSelection(TrackSelection trackSelection, bool status);

        // @optional -(void)msrCurrentSecurityLevel:(SecurityLevel)securityLevel validData:(BOOL)status;
        [Export("msrCurrentSecurityLevel:validData:")]
        void MsrCurrentSecurityLevel(SecurityLevel securityLevel, bool status);

        // @optional -(void)msrPassThroughReturnData:(NSData *)data;
        [Export("msrPassThroughReturnData:")]
        void MsrPassThroughReturnData(NSData data);

        // @optional -(void)pmChargeStatusChange:(ChargeStatus)newChargeStatus;
        [Export("pmChargeStatusChange:")]
        void PmChargeStatusChange(ChargeStatus newChargeStatus);

        // @optional -(void)pmBatteryStatusChange:(BatteryStatus)newBatteryStatus;
        [Export("pmBatteryStatusChange:")]
        void PmBatteryStatusChange(BatteryStatus newBatteryStatus);

        // @optional -(void)pmLowBatteryWarning;
        [Export("pmLowBatteryWarning")]
        void PmLowBatteryWarning();

        // @optional -(void)pmLowBatteryShutdown;
        [Export("pmLowBatteryShutdown")]
        void PmLowBatteryShutdown();

        // @optional -(void)pmMfgBlockData:(MfgBlockData *)blockData;
        //[Export ("pmMfgBlockData:")]
        //unsafe void PmMfgBlockData (MfgBlockData* blockData);

        // @optional -(void)stateHID:(HIDCurStatus)status;
        [Export("stateHID:")]
        void StateHID(HIDCurStatus status);

        // @optional -(void)responseHIDTimeout:(NSInteger)timeout;
        [Export("responseHIDTimeout:")]
        void ResponseHIDTimeout(nint timeout);

        // @optional -(void)responseHIDChangedDetail:(NSString *)changedInfo;
        [Export("responseHIDChangedDetail:")]
        void ResponseHIDChangedDetail(string changedInfo);

        // @optional -(void)scanKeyAction:(ScanKeyStatus)status;
        [Export("scanKeyAction:")]
        void ScanKeyAction(ScanKeyStatus status);

        // @optional -(void)upgradingFirmwareResult:(UPfirmwareResultCode)ResultCode;
        [Export("upgradingFirmwareResult:")]
        void UpgradingFirmwareResult(UPfirmwareResultCode ResultCode);

        // @optional -(void)upgradePercent:(CGFloat)percent;
        [Export("upgradePercent:")]
        void UpgradePercent(nfloat percent);

        // @optional -(void)upgradeFirmwareCompleted;
        [Export("upgradeFirmwareCompleted")]
        void UpgradeFirmwareCompleted();

        // @optional -(void)responseBatteryDetailInformation:(cupertinoBatteryDetailInfo *)batteryInfo __attribute__((noreturn));
        [Export("responseBatteryDetailInformation:")]
        void ResponseBatteryDetailInformation(cupertinoBatteryDetailInfo batteryInfo);

        // @optional -(void)responseMSRHIDMode:(BOOL)isHID __attribute__((noreturn));
        [Export("responseMSRHIDMode:")]
        void ResponseMSRHIDMode(bool isHID);

        // @optional -(void)responseLedScheme:(LedSchemeResponse *)status __attribute__((noreturn));
        [Export("responseLedScheme:")]
        void ResponseLedScheme(LedSchemeResponse status);
    }

    // @interface Captuvo : NSObject
    [BaseType(typeof(NSObject))]
    interface Captuvo
    {
        // +(Captuvo *)sharedCaptuvoDevice;
        [Static]
        [Export("sharedCaptuvoDevice")]
        //[Verify (MethodToProperty)]
        Captuvo SharedCaptuvoDevice { get; }

        // +(Captuvo *)sharedCaptuvoDeviceDebug;
        [Static]
        [Export("sharedCaptuvoDeviceDebug")]
        //[Verify (MethodToProperty)]
        Captuvo SharedCaptuvoDeviceDebug { get; }

        // -(void)enableCaptuvoDebug:(BOOL)enable;
        [Export("enableCaptuvoDebug:")]
        void EnableCaptuvoDebug(bool enable);

        // -(void)stopbatterymonitor;
        [Export("stopbatterymonitor")]
        void Stopbatterymonitor();

        // -(void)addCaptuvoDelegate:(id<CaptuvoEventsProtocol>)delegate;
        [Export("addCaptuvoDelegate:")]
        void AddCaptuvoDelegate(CaptuvoEventsProtocol @delegate);

        // -(void)removeCaptuvoDelegate:(id<CaptuvoEventsProtocol>)delegate;
        [Export("removeCaptuvoDelegate:")]
        void RemoveCaptuvoDelegate(CaptuvoEventsProtocol @delegate);

        // -(NSString *)getCaptuvoName;
        [Export("getCaptuvoName")]
        //[Verify (MethodToProperty)]
        string CaptuvoName { get; }

        // -(NSString *)getCaptuvoModelNumber;
        [Export("getCaptuvoModelNumber")]
        //[Verify (MethodToProperty)]
        string CaptuvoModelNumber { get; }

        // -(NSString *)getCaptuvoSerialNumber;
        [Export("getCaptuvoSerialNumber")]
        //[Verify (MethodToProperty)]
        string CaptuvoSerialNumber { get; }

        // -(NSString *)getCaptuvoFirmwareRevision;
        [Export("getCaptuvoFirmwareRevision")]
        //[Verify (MethodToProperty)]
        string CaptuvoFirmwareRevision { get; }

        // -(NSString *)getCaptuvoHardwareRevision;
        [Export("getCaptuvoHardwareRevision")]
        //[Verify (MethodToProperty)]
        string CaptuvoHardwareRevision { get; }

        // -(NSString *)getCaptuvoManufacturer;
        [Export("getCaptuvoManufacturer")]
        //[Verify (MethodToProperty)]
        string CaptuvoManufacturer { get; }

        // -(NSString *)getSDKbuildNumber;
        [Export("getSDKbuildNumber")]
        //[Verify (MethodToProperty)]
        string SDKbuildNumber { get; }

        // -(NSString *)getSDKshortVersion;
        [Export("getSDKshortVersion")]
        //[Verify (MethodToProperty)]
        string SDKshortVersion { get; }

        // -(NSString *)getSDKfullVersion;
        [Export("getSDKfullVersion")]
        //[Verify (MethodToProperty)]
        string SDKfullVersion { get; }

        // -(ProtocolConnectionStatus)startDecoderHardware;
        [Export("startDecoderHardware")]
        //[Verify (MethodToProperty)]
        ProtocolConnectionStatus StartDecoderHardware();

        // -(void)startDecoderHardware:(double)timeout;
        [Export("startDecoderHardware:")]
        void StartDecoderHardware(double timeout);

        // -(void)stopDecoderHardware;
        [Export("stopDecoderHardware")]
        void StopDecoderHardware();

        // -(BOOL)isDecoderRunning;
        [Export("isDecoderRunning")]
        //[Verify (MethodToProperty)]
        bool IsDecoderRunning { get; }

        // -(void)startDecoderScanning;
        [Export("startDecoderScanning")]
        void StartDecoderScanning();

        // -(void)stopDecoderScanning;
        [Export("stopDecoderScanning")]
        void StopDecoderScanning();

        // -(void)enableDecoderScanning;
        [Export("enableDecoderScanning")]
        void EnableDecoderScanning();

        // -(void)disableDecoderScanning;
        [Export("disableDecoderScanning")]
        void DisableDecoderScanning();

        // -(void)enableDecoderPowerUpBeep:(BOOL)enabled;
        [Export("enableDecoderPowerUpBeep:")]
        void EnableDecoderPowerUpBeep(bool enabled);

        // -(void)requestDecoderSerialNumber;
        [Export("requestDecoderSerialNumber")]
        void RequestDecoderSerialNumber();

        // -(void)requestDecoderPowerUpBeepStatus;
        [Export("requestDecoderPowerUpBeepStatus")]
        void RequestDecoderPowerUpBeepStatus();

        // -(void)enableDecoderTriggerClick:(BOOL)enabled persistSetting:(BOOL)persist;
        [Export("enableDecoderTriggerClick:persistSetting:")]
        void EnableDecoderTriggerClick(bool enabled, bool persist);

        // -(void)requestDecoderTriggerClickStatus;
        [Export("requestDecoderTriggerClickStatus")]
        void RequestDecoderTriggerClickStatus();

        // -(void)enableDecoderBeeperForGoodRead:(BOOL)enable persistSetting:(BOOL)persist;
        [Export("enableDecoderBeeperForGoodRead:persistSetting:")]
        void EnableDecoderBeeperForGoodRead(bool enable, bool persist);

        // -(void)requestDecoderBeeperForGoodReadStatus;
        [Export("requestDecoderBeeperForGoodReadStatus")]
        void RequestDecoderBeeperForGoodReadStatus();

        // -(void)setDecoderGoodReadBeeperVolume:(BeeperVolume)beeperVolume persistSetting:(BOOL)persist;
        [Export("setDecoderGoodReadBeeperVolume:persistSetting:")]
        void SetDecoderGoodReadBeeperVolume(BeeperVolume beeperVolume, bool persist);

        // -(void)requestDecoderGoodReadBeeperVolumeStatus;
        [Export("requestDecoderGoodReadBeeperVolumeStatus")]
        void RequestDecoderGoodReadBeeperVolumeStatus();

        // -(void)setDecoderBeeperPitchGoodRead:(BeeperPitch)beeperPitch persistSetting:(BOOL)persist;
        [Export("setDecoderBeeperPitchGoodRead:persistSetting:")]
        void SetDecoderBeeperPitchGoodRead(BeeperPitch beeperPitch, bool persist);

        // -(void)requestDecoderBeeperPitchGoodReadStatus;
        [Export("requestDecoderBeeperPitchGoodReadStatus")]
        void RequestDecoderBeeperPitchGoodReadStatus();

        // -(void)setDecoderBeeperPitchError:(BeeperErrorPitch)beeperPitch persistSetting:(BOOL)persist;
        [Export("setDecoderBeeperPitchError:persistSetting:")]
        void SetDecoderBeeperPitchError(BeeperErrorPitch beeperPitch, bool persist);

        // -(void)requestDecoderBeeperPitchErrorStatus;
        [Export("requestDecoderBeeperPitchErrorStatus")]
        void RequestDecoderBeeperPitchErrorStatus();

        // -(void)setDecoderBeeperDurationGoodRead:(BeeperDuration)beeperDuration persistSetting:(BOOL)persist;
        [Export("setDecoderBeeperDurationGoodRead:persistSetting:")]
        void SetDecoderBeeperDurationGoodRead(BeeperDuration beeperDuration, bool persist);

        // -(void)requestDecoderBeeperDurationGoodReadStatus;
        [Export("requestDecoderBeeperDurationGoodReadStatus")]
        void RequestDecoderBeeperDurationGoodReadStatus();

        // -(void)setDecoderNumberOfBeepsGoodRead:(int)numberOfBeeps persistSetting:(BOOL)persist;
        [Export("setDecoderNumberOfBeepsGoodRead:persistSetting:")]
        void SetDecoderNumberOfBeepsGoodRead(int numberOfBeeps, bool persist);

        // -(void)requestDecoderNumberOfBeepsGoodReadStatus;
        [Export("requestDecoderNumberOfBeepsGoodReadStatus")]
        void RequestDecoderNumberOfBeepsGoodReadStatus();

        // -(void)setDecoderNumberOfBeepsError:(int)numberOfBeeps persistSetting:(BOOL)persist;
        [Export("setDecoderNumberOfBeepsError:persistSetting:")]
        void SetDecoderNumberOfBeepsError(int numberOfBeeps, bool persist);

        // -(void)requestDecoderNumberOfBeepsErrorStatus;
        [Export("requestDecoderNumberOfBeepsErrorStatus")]
        void RequestDecoderNumberOfBeepsErrorStatus();

        // -(void)setDecoderGoodReadDelayInMilliSeconds:(int)delay persistSetting:(BOOL)persist;
        [Export("setDecoderGoodReadDelayInMilliSeconds:persistSetting:")]
        void SetDecoderGoodReadDelayInMilliSeconds(int delay, bool persist);

        // -(void)requestDecoderGoodReadDelayInMilliSecondsStatus;
        [Export("requestDecoderGoodReadDelayInMilliSecondsStatus")]
        void RequestDecoderGoodReadDelayInMilliSecondsStatus();

        // -(void)enableDecoderEnhancedManualTriggerMode:(BOOL)enable persistSetting:(BOOL)persist;
        [Export("enableDecoderEnhancedManualTriggerMode:persistSetting:")]
        void EnableDecoderEnhancedManualTriggerMode(bool enable, bool persist);

        // -(void)setDecoderSerialTriggerTimeoutInMilliSeconds:(int)timeout persistSetting:(BOOL)persist;
        [Export("setDecoderSerialTriggerTimeoutInMilliSeconds:persistSetting:")]
        void SetDecoderSerialTriggerTimeoutInMilliSeconds(int timeout, bool persist);

        // -(void)requestDecoderSerialTriggerTimeoutInMilliSecondsStatus;
        [Export("requestDecoderSerialTriggerTimeoutInMilliSecondsStatus")]
        void RequestDecoderSerialTriggerTimeoutInMilliSecondsStatus();

        // -(void)enableDecoderOptimizationsForMobilePhoneReading:(BOOL)enable persistSetting:(BOOL)persist;
        [Export("enableDecoderOptimizationsForMobilePhoneReading:persistSetting:")]
        void EnableDecoderOptimizationsForMobilePhoneReading(bool enable, bool persist);

        // -(void)enableDecoderInterlacedAimerMode:(BOOL)enable persistSetting:(BOOL)persist;
        [Export("enableDecoderInterlacedAimerMode:persistSetting:")]
        void EnableDecoderInterlacedAimerMode(bool enable, bool persist);

        // -(void)requestDecoderInterlacedAimerModeStatus;
        [Export("requestDecoderInterlacedAimerModeStatus")]
        void RequestDecoderInterlacedAimerModeStatus();

        // -(void)enableDecoderPreferredSymbology:(BOOL)enable persistSetting:(BOOL)persist;
        [Export("enableDecoderPreferredSymbology:persistSetting:")]
        void EnableDecoderPreferredSymbology(bool enable, bool persist);

        // -(void)requestDecoderPreferredSymbologyStatus;
        [Export("requestDecoderPreferredSymbologyStatus")]
        void RequestDecoderPreferredSymbologyStatus();

        // -(void)setDecoderPreferredSymbologyToDefaultPersistSetting:(BOOL)persist;
        [Export("setDecoderPreferredSymbologyToDefaultPersistSetting:")]
        void SetDecoderPreferredSymbologyToDefaultPersistSetting(bool persist);

        // -(void)setDecoderPreferredSymbologyTimeoutInMilliSeconds:(int)timeout persistSetting:(BOOL)persist;
        [Export("setDecoderPreferredSymbologyTimeoutInMilliSeconds:persistSetting:")]
        void SetDecoderPreferredSymbologyTimeoutInMilliSeconds(int timeout, bool persist);

        // -(void)requestDecoderPreferredSymbologyTimeoutInMilliSecondsStatus;
        [Export("requestDecoderPreferredSymbologyTimeoutInMilliSecondsStatus")]
        void RequestDecoderPreferredSymbologyTimeoutInMilliSecondsStatus();

        // -(void)setDecoderHighPrioritySymbology:(Symbology)symbology persistSetting:(BOOL)persist;
        [Export("setDecoderHighPrioritySymbology:persistSetting:")]
        void SetDecoderHighPrioritySymbology(Symbology symbology, bool persist);

        // -(void)requestDecoderHighPrioritySymbologyStatus;
        [Export("requestDecoderHighPrioritySymbologyStatus")]
        void RequestDecoderHighPrioritySymbologyStatus();

        // -(void)setDecoderLowPrioritySymbology:(Symbology)symbology persistSetting:(BOOL)persist;
        [Export("setDecoderLowPrioritySymbology:persistSetting:")]
        void SetDecoderLowPrioritySymbology(Symbology symbology, bool persist);

        // -(void)requestDecoderLowPrioritySymbologyStatus;
        [Export("requestDecoderLowPrioritySymbologyStatus")]
        void RequestDecoderLowPrioritySymbologyStatus();

        // -(void)enableDecoderCentering:(BOOL)enable persistSetting:(BOOL)persist;
        [Export("enableDecoderCentering:persistSetting:")]
        void EnableDecoderCentering(bool enable, bool persist);

        // -(void)requestDecoderCenteringStatus;
        [Export("requestDecoderCenteringStatus")]
        void RequestDecoderCenteringStatus();

        // -(void)setDecoderTopOfCenteringWindow:(int)locationAsPercent persistSetting:(BOOL)persist;
        [Export("setDecoderTopOfCenteringWindow:persistSetting:")]
        void SetDecoderTopOfCenteringWindow(int locationAsPercent, bool persist);

        // -(void)requestDecoderTopOfCenteringWindowStatus;
        [Export("requestDecoderTopOfCenteringWindowStatus")]
        void RequestDecoderTopOfCenteringWindowStatus();

        // -(void)setDecoderBottomOfCenteringWindow:(int)locationAsPercent persistSetting:(BOOL)persist;
        [Export("setDecoderBottomOfCenteringWindow:persistSetting:")]
        void SetDecoderBottomOfCenteringWindow(int locationAsPercent, bool persist);

        // -(void)requestDecoderBottomOfCenteringWindowStatus;
        [Export("requestDecoderBottomOfCenteringWindowStatus")]
        void RequestDecoderBottomOfCenteringWindowStatus();

        // -(void)setDecoderLeftOfCenteringWindow:(int)locationAsPercent persistSetting:(BOOL)persist;
        [Export("setDecoderLeftOfCenteringWindow:persistSetting:")]
        void SetDecoderLeftOfCenteringWindow(int locationAsPercent, bool persist);

        // -(void)requestDecoderLeftOfCenteringWindowStatus;
        [Export("requestDecoderLeftOfCenteringWindowStatus")]
        void RequestDecoderLeftOfCenteringWindowStatus();

        // -(void)setDecoderRightOfCenteringWindow:(int)locationAsPercent persistSetting:(BOOL)persist;
        [Export("setDecoderRightOfCenteringWindow:persistSetting:")]
        void SetDecoderRightOfCenteringWindow(int locationAsPercent, bool persist);

        // -(void)requestDecoderRightOfCenteringWindowStatus;
        [Export("requestDecoderRightOfCenteringWindowStatus")]
        void RequestDecoderRightOfCenteringWindowStatus();

        // -(void)requestDecoderRevision;
        [Export("requestDecoderRevision")]
        void RequestDecoderRevision();

        // -(void)requestDecoderDriverRevision;
        [Export("requestDecoderDriverRevision")]
        void RequestDecoderDriverRevision();

        // -(void)enableAllSymbologiesPersistSetting:(BOOL)persist;
        [Export("enableAllSymbologiesPersistSetting:")]
        void EnableAllSymbologiesPersistSetting(bool persist);

        // -(void)enableDecoderAimer:(BOOL)persist;
        [Export("enableDecoderAimer:")]
        void EnableDecoderAimer(bool persist);

        // -(void)disableDecoderAimer:(BOOL)persist;
        [Export("disableDecoderAimer:")]
        void DisableDecoderAimer(bool persist);

        // -(void)enableDecoderIllumination:(BOOL)persist;
        [Export("enableDecoderIllumination:")]
        void EnableDecoderIllumination(bool persist);

        // -(void)disableDecoderIllumination:(BOOL)persist;
        [Export("disableDecoderIllumination:")]
        void DisableDecoderIllumination(bool persist);

        // -(void)disableAllSymbologiesPersistSetting:(BOOL)persist;
        [Export("disableAllSymbologiesPersistSetting:")]
        void DisableAllSymbologiesPersistSetting(bool persist);

        // -(void)setDecoderUPCAConfiguration:(UPCA *)upca persistSetting:(BOOL)persist;
        [Export("setDecoderUPCAConfiguration:persistSetting:")]
        void SetDecoderUPCAConfiguration(UPCA upca, bool persist);

        // -(void)setDecoderEAN13Configuration:(EAN13 *)ean13 persistSetting:(BOOL)persist;
        [Export("setDecoderEAN13Configuration:persistSetting:")]
        void SetDecoderEAN13Configuration(EAN13 ean13, bool persist);

        // -(void)setDecoderUPCE0Configuration:(UPCE0 *)upce0 persistSetting:(BOOL)persist;
        [Export("setDecoderUPCE0Configuration:persistSetting:")]
        void SetDecoderUPCE0Configuration(UPCE0 upce0, bool persist);

        // -(void)setDecoderEAN8Configuration:(EAN8 *)ean8 persistSetting:(BOOL)persist;
        [Export("setDecoderEAN8Configuration:persistSetting:")]
        void SetDecoderEAN8Configuration(EAN8 ean8, bool persist);

        // -(void)setDecoderCodabarConfiguration:(Codabar *)codabar persistSetting:(BOOL)persist;
        [Export("setDecoderCodabarConfiguration:persistSetting:")]
        void SetDecoderCodabarConfiguration(Codabar codabar, bool persist);

        // -(void)setDecoderCode39Configuration:(Code39 *)code39 persistSetting:(BOOL)persist;
        [Export("setDecoderCode39Configuration:persistSetting:")]
        void SetDecoderCode39Configuration(Code39 code39, bool persist);

        // -(void)setDecoderInterleaved2of5Configuration:(Interleaved2of5 *)interleaved2of5 persistSetting:(BOOL)persist;
        [Export("setDecoderInterleaved2of5Configuration:persistSetting:")]
        void SetDecoderInterleaved2of5Configuration(Interleaved2of5 interleaved2of5, bool persist);

        // -(void)setDecoderNEC2of5Configuration:(NEC2of5 *)nec2of5 persistSetting:(BOOL)persist;
        [Export("setDecoderNEC2of5Configuration:persistSetting:")]
        void SetDecoderNEC2of5Configuration(NEC2of5 nec2of5, bool persist);

        // -(void)setDecoderCode93Configuration:(Code93 *)code93 persistSetting:(BOOL)persist;
        [Export("setDecoderCode93Configuration:persistSetting:")]
        void SetDecoderCode93Configuration(Code93 code93, bool persist);

        // -(void)setDecoderStraight2of5IndustrialConfiguration:(Straight2of5Industrial *)straight2of5Industrial persistSetting:(BOOL)persist;
        [Export("setDecoderStraight2of5IndustrialConfiguration:persistSetting:")]
        void SetDecoderStraight2of5IndustrialConfiguration(Straight2of5Industrial straight2of5Industrial, bool persist);

        // -(void)setDecoderStraight2of5IATAConfiguration:(Straight2of5IATA *)straight2of5IATA persistSetting:(BOOL)persist;
        [Export("setDecoderStraight2of5IATAConfiguration:persistSetting:")]
        void SetDecoderStraight2of5IATAConfiguration(Straight2of5IATA straight2of5IATA, bool persist);

        // -(void)setDecoderMatrix2of5Configuration:(Matrix2of5 *)matrix2of5 persistSetting:(BOOL)persist;
        [Export("setDecoderMatrix2of5Configuration:persistSetting:")]
        void SetDecoderMatrix2of5Configuration(Matrix2of5 matrix2of5, bool persist);

        // -(void)setDecoderCode11Configuration:(Code11 *)code11 persistSetting:(BOOL)persist;
        [Export("setDecoderCode11Configuration:persistSetting:")]
        void SetDecoderCode11Configuration(Code11 code11, bool persist);

        // -(void)setDecoderCode128Configuration:(Code128 *)code128 persistSetting:(BOOL)persist;
        [Export("setDecoderCode128Configuration:persistSetting:")]
        void SetDecoderCode128Configuration(Code128 code128, bool persist);

        // -(void)setDecoderGS1_128Configuration:(GS1_128 *)gs1_128 persistSetting:(BOOL)persist;
        [Export("setDecoderGS1_128Configuration:persistSetting:")]
        void SetDecoderGS1_128Configuration(GS1_128 gs1_128, bool persist);

        // -(void)setDecoderTelepenConfiguration:(Telepen *)telepen persistSetting:(BOOL)persist;
        [Export("setDecoderTelepenConfiguration:persistSetting:")]
        void SetDecoderTelepenConfiguration(Telepen telepen, bool persist);

        // -(void)setDecoderMSIConfiguration:(MSI *)msi persistSetting:(BOOL)persist;
        [Export("setDecoderMSIConfiguration:persistSetting:")]
        void SetDecoderMSIConfiguration(MSI msi, bool persist);

        // -(void)setDecoderGS1DataBarOmnidirectionalConfiguration:(GS1DataBarOmnidirectional *)gs1DataBarOmnidirectional persistSetting:(BOOL)persist;
        [Export("setDecoderGS1DataBarOmnidirectionalConfiguration:persistSetting:")]
        void SetDecoderGS1DataBarOmnidirectionalConfiguration(GS1DataBarOmnidirectional gs1DataBarOmnidirectional, bool persist);

        // -(void)setDecoderGS1DataBarLimitedConfiguration:(GS1DataBarLimited *)gs1DataBarLimited persistSetting:(BOOL)persist;
        [Export("setDecoderGS1DataBarLimitedConfiguration:persistSetting:")]
        void SetDecoderGS1DataBarLimitedConfiguration(GS1DataBarLimited gs1DataBarLimited, bool persist);

        // -(void)setDecoderGS1DataBarExpandedConfiguration:(GS1DataBarExpanded *)gs1DataBarExpanded persistSetting:(BOOL)persist;
        [Export("setDecoderGS1DataBarExpandedConfiguration:persistSetting:")]
        void SetDecoderGS1DataBarExpandedConfiguration(GS1DataBarExpanded gs1DataBarExpanded, bool persist);

        // -(void)setDecoderCodablockAConfiguration:(CodablockA *)codablockA persistSetting:(BOOL)persist;
        [Export("setDecoderCodablockAConfiguration:persistSetting:")]
        void SetDecoderCodablockAConfiguration(CodablockA codablockA, bool persist);

        // -(void)setDecoderCodablockFConfiguration:(CodablockF *)codablockF persistSetting:(BOOL)persist;
        [Export("setDecoderCodablockFConfiguration:persistSetting:")]
        void SetDecoderCodablockFConfiguration(CodablockF codablockF, bool persist);

        // -(void)setDecoderPDF417Configuration:(PDF417 *)pdf417 persistSetting:(BOOL)persist;
        [Export("setDecoderPDF417Configuration:persistSetting:")]
        void SetDecoderPDF417Configuration(PDF417 pdf417, bool persist);

        // -(void)setDecoderDataMatrixConfiguration:(DataMatrix *)dataMatrix persistSetting:(BOOL)persist;
        [Export("setDecoderDataMatrixConfiguration:persistSetting:")]
        void SetDecoderDataMatrixConfiguration(DataMatrix dataMatrix, bool persist);

        // -(void)setDecoderMaxiCodeConfiguration:(MaxiCode *)maxiCode persistSetting:(BOOL)persist;
        [Export("setDecoderMaxiCodeConfiguration:persistSetting:")]
        void SetDecoderMaxiCodeConfiguration(MaxiCode maxiCode, bool persist);

        // -(void)setDecoderAztecConfiguration:(Aztec *)aztec persistSetting:(BOOL)persist;
        [Export("setDecoderAztecConfiguration:persistSetting:")]
        void SetDecoderAztecConfiguration(Aztec aztec, bool persist);

        // -(void)setDecoderChineseSensibleConfiguration:(ChineseSensible *)chineseSensible persistSetting:(BOOL)persist;
        [Export("setDecoderChineseSensibleConfiguration:persistSetting:")]
        void SetDecoderChineseSensibleConfiguration(ChineseSensible chineseSensible, bool persist);

        // -(void)setDecoderMicroPDF417Configuration:(MicroPDF417 *)microPDF417 persistSetting:(BOOL)persist;
        [Export("setDecoderMicroPDF417Configuration:persistSetting:")]
        void SetDecoderMicroPDF417Configuration(MicroPDF417 microPDF417, bool persist);

        // -(void)setDecoderTCIFLinkedCode39Configuration:(TCIFLinkedCode39 *)tcifLinkedCode39 persistSetting:(BOOL)persist;
        [Export("setDecoderTCIFLinkedCode39Configuration:persistSetting:")]
        void SetDecoderTCIFLinkedCode39Configuration(TCIFLinkedCode39 tcifLinkedCode39, bool persist);

        // -(void)setDecoderQRCodeConfiguration:(QRCode *)qrCode persistSetting:(BOOL)persist;
        [Export("setDecoderQRCodeConfiguration:persistSetting:")]
        void SetDecoderQRCodeConfiguration(QRCode qrCode, bool persist);

        // -(void)requestDecoderSoftwareRevision;
        [Export("requestDecoderSoftwareRevision")]
        void RequestDecoderSoftwareRevision();

        // -(void)requestEngineSerialNumber;
        [Export("requestEngineSerialNumber")]
        void RequestEngineSerialNumber();

        // -(void)decoderPassThrough:(NSData *)data expectingReturnData:(BOOL)returnData;
        [Export("decoderPassThrough:expectingReturnData:")]
        void DecoderPassThrough(NSData data, bool returnData);

        // -(void)FactoryResetting;
        [Export("FactoryResetting")]
        void FactoryResetting();

        // -(ProtocolConnectionStatus)startMSRHardware;
        [Export("startMSRHardware")]
        //[Verify (MethodToProperty)]
        ProtocolConnectionStatus StartMSRHardware();

        // -(void)startMSRHardware:(double)timeout;
        [Export("startMSRHardware:")]
        void StartMSRHardware(double timeout);

        // -(void)stopMSRHardware;
        [Export("stopMSRHardware")]
        void StopMSRHardware();

        // -(BOOL)isMSRRunning;
        [Export("isMSRRunning")]
        //[Verify (MethodToProperty)]
        bool IsMSRRunning { get; }

        // -(void)enableMSRReader;
        [Export("enableMSRReader")]
        void EnableMSRReader();

        // -(void)disableMSRReader;
        [Export("disableMSRReader")]
        void DisableMSRReader();

        // -(void)requestMSRFirmwareVersion;
        [Export("requestMSRFirmwareVersion")]
        void RequestMSRFirmwareVersion();

        // -(void)requestMSRSerialNumber;
        [Export("requestMSRSerialNumber")]
        void RequestMSRSerialNumber();

        // -(void)setMSRTrackSelection:(TrackSelection)selection;
        [Export("setMSRTrackSelection:")]
        void SetMSRTrackSelection(TrackSelection selection);

        // -(void)requestMSRSecurityLevel;
        [Export("requestMSRSecurityLevel")]
        void RequestMSRSecurityLevel();

        // -(void)requestMSRTrackSettings;
        [Export("requestMSRTrackSettings")]
        void RequestMSRTrackSettings();

        // -(void)msrPassThrough:(NSData *)data expectingReturnData:(BOOL)returnData;
        [Export("msrPassThrough:expectingReturnData:")]
        void MsrPassThrough(NSData data, bool returnData);

        // -(ChargeStatus)getChargeStatus;
        [Export("getChargeStatus")]
        //[Verify (MethodToProperty)]
        ChargeStatus ChargeStatus { get; }

        // -(BatteryStatus)getBatteryStatus __attribute__((deprecated("")));
        [Export("getBatteryStatus")]
        //[Verify (MethodToProperty)]
        BatteryStatus BatteryStatus { get; }

        // -(void)requestBatteryVoltage;
        [Export("requestBatteryVoltage")]
        void RequestBatteryVoltage();

        // -(void)setChargeBatteryThreshold:(int)min mx:(int)max;
        [Export("setChargeBatteryThreshold:mx:")]
        void SetChargeBatteryThreshold(int min, int max);

        // -(void)requestChargeStatus;
        [Export("requestChargeStatus")]
        void RequestChargeStatus();

        // -(void)requestPMMfgBlockData;
        [Export("requestPMMfgBlockData")]
        void RequestPMMfgBlockData();

        // -(ProtocolConnectionStatus)startPMHardware;
        [Export("startPMHardware")]
        //[Verify (MethodToProperty)]
        ProtocolConnectionStatus StartPMHardware();

        // -(void)startPMHardware:(double)timeout;
        [Export("startPMHardware:")]
        void StartPMHardware(double timeout);

        // -(void)stopPMHardware;
        [Export("stopPMHardware")]
        void StopPMHardware();

        // -(void)forceBatteryLowShutdown __attribute__((deprecated("")));
        [Export("forceBatteryLowShutdown")]
        void ForceBatteryLowShutdown();

        // -(BOOL)debug;
        [Export("debug")]
        //[Verify (MethodToProperty)]
        bool Debug { get; }

        // -(void)enableBatteryQuery;
        [Export("enableBatteryQuery")]
        void EnableBatteryQuery();

        // -(void)disableBatteryQuery;
        [Export("disableBatteryQuery")]
        void DisableBatteryQuery();

        // -(void)activateHID;
        [Export("activateHID")]
        void ActivateHID();

        // -(void)deActivateHID;
        [Export("deActivateHID")]
        void DeActivateHID();

        // -(void)unLockHIDMode;
        [Export("unLockHIDMode")]
        void UnLockHIDMode();

        // -(void)lockHIDMode;
        [Export("lockHIDMode")]
        void LockHIDMode();

        // -(void)requestHIDStatus;
        [Export("requestHIDStatus")]
        void RequestHIDStatus();

        // -(void)queryHIDTimeout;
        [Export("queryHIDTimeout")]
        void QueryHIDTimeout();

        // -(void)setHIDTimeout:(int)timeout;
        [Export("setHIDTimeout:")]
        void SetHIDTimeout(int timeout);

        // -(void)enableTriggerKey;
        [Export("enableTriggerKey")]
        void EnableTriggerKey();

        // -(void)disableTriggerKey;
        [Export("disableTriggerKey")]
        void DisableTriggerKey();

        // -(TriggerKeyStatus)requestTriggerKeyStatus;
        [Export("requestTriggerKeyStatus")]
        //[Verify (MethodToProperty)]
        TriggerKeyStatus RequestTriggerKeyStatus { get; }

        // -(void)startUpgradefirmware:(NSString *)filePath;
        [Export("startUpgradefirmware:")]
        void StartUpgradefirmware(string filePath);

        // -(SledFirmwareHeader *)getFirmwareHeader:(NSString *)filePath __attribute__((noreturn));
        [Export("getFirmwareHeader:")]
        SledFirmwareHeader GetFirmwareHeader(string filePath);

        // -(void)queryBatteryDetailInfo __attribute__((noreturn));
        [Export("queryBatteryDetailInfo")]
        void QueryBatteryDetailInfo();

        // -(void)setBatteryChargingForAppleDevice:(cupertinoBatteryCharger *)charger __attribute__((noreturn));
        [Export("setBatteryChargingForAppleDevice:")]
        void SetBatteryChargingForAppleDevice(cupertinoBatteryCharger charger);

        // -(void)setMSRHID:(BOOL)activate;
        [Export("setMSRHID:")]
        void SetMSRHID(bool activate);

        // -(void)queryMSRHIDMode;
        [Export("queryMSRHIDMode")]
        void QueryMSRHIDMode();

        // -(void)setLedScheme:(BOOL)defaultScheme;
        [Export("setLedScheme:")]
        void SetLedScheme(bool defaultScheme);
    }
}
