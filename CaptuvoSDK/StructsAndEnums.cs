using System.Runtime.InteropServices;

namespace CaptuvoSDK
{
	public enum ProtocolConnectionStatus : uint
	{
		StatusConnected,
		StatusAlreadyConnected,
		StatusBatteryDepleted,
		StatusUnableToConnectIncompatibleSledFirmware,
		StatusUnableToConnect,
		UnableToConnectNOAccessary,
		UnableToConnectNOProtocal
	}

	public enum HIDCurStatus : uint
	{
		ActiveLock,
		ActiveUnlock,
		UnactiveLock,
		UnactiveUnlock
	}

	public enum ScanKeyStatus : uint
	{
		Pressing,
		Released
	}

	public enum BeeperVolume : uint
	{
		Low,
		Medium,
		High,
		Off
	}

	public enum BeeperPitch : uint
	{
		Low,
		Medium,
		High
	}

	public enum BeeperErrorPitch : uint
	{
		Razz,
		Medium,
		High
	}

	public enum BeeperDuration : uint
	{
		Short,
		Normal
	}

	public enum TrackSelection : uint
	{
		AnyTrack,
		Require1,
		Require2,
		Require1and2,
		Require3,
		Require1and3,
		Require2and3,
		RequireAllTracks,
		AnyTrack1or2,
		AnyTrack2or3,
		Undefined
	}

	public enum SecurityLevel : uint
	{
		SecurityLevel0,
		SecurityLevel1,
		SecurityLevel2,
		SecurityLevel3,
		SecurityLevel4,
		Undefined
	}

	public enum KeyManagementType : uint
	{
		Fixkeymanagement,
		DUKPTkeymanagement
	}

	public enum EncryptionSetting : uint
	{
		cryptionDisabled,
		ableTDESEncryption,
		ableAESEncryption
	}

	public enum Symbology : uint
	{
		All,
		AustralianPost,
		AztecCode,
		BritishPost,
		CanadianPost,
		ChinaPost,
		ChineseSensibleCode,
		Codabar,
		CodablockA,
		CodablockF,
		Code11,
		Code128,
		Gs1128,
		Code32Pharmaceutical,
		Code39,
		Code49,
		Code93And93i,
		DataMatrix,
		Ean13,
		EAN13WithAddOn,
		EAN13WithExtendedCouponCode,
		Ean8,
		EAN8WithAddOn,
		GS1Composite,
		GS1DataBar,
		InfoMail,
		IntelligentMailBarcode,
		Interleaved2Of5,
		JapanesePost,
		KIXPost,
		KoreaPost,
		Matrix2Of5,
		MaxiCode,
		MicroPDF417,
		Msi,
		NEC2Of5,
		Ocrmicr,
		OCRSEMIFont,
		Ocra,
		Ocrb,
		Pdf417,
		PlanetCode,
		Postal4i,
		Postnet,
		QRCodeAndMicroQRCode,
		Straight2Of5IATA,
		Straight2Of5Industrial,
		TCIFLinkedCode39,
		Telepen,
		Upca,
		UPCAWithAddOn,
		UPCAWithExtendedCouponCode,
		Upce,
		UPCEWithAddOn,
		Upce1,
		Undefined
	}

	public enum ChargeStatus : uint
	{
		NotCharging,
		Charging,
		ChargeComplete,
		Undefined
	}

	public enum BatteryStatus : uint
	{
		PowerSourceConnected,
		BatteryStatus4Of4Bars,
		BatteryStatus3Of4Bars,
		BatteryStatus2Of4Bars,
		BatteryStatus1Of4Bars,
		BatteryStatus0Of4Bars,
		Undefined
	}

	public enum TriggerKeyStatus : uint
	{
		Enabled,
		Disabled,
		ChangeSuccessful,
		ChangeFailed,
		ToggleFeatureUnsupported
	}

	public enum UPfirmwareResultCode : uint
	{
		StartSuccessfully = 0,
		SledReadyUpgrade,
		FilePathError,
		FileReadError,
		SecurityError,
		FWPacketError,
		FWUpgradeError,
		SLEDBatteryTooLowToUpgrade
	}

	public enum UPCA_EAN13_ExtendedCouponCode : uint
	{
		Off,
		AllowConcatenation,
		RequireConcatenation
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct MfgBlockData
	{
		public byte[] mfgSignature;

		public byte[] partNumber;

		public byte[] configurationNumber;

		public byte[] serialNumber;

		public byte[] finalAssemblyDate;

		public byte[] odmTrackingNumber;
	}

	public enum CodabarCheckChar : uint
	{
		NoCheckChar,
		ValidateNotTransmitted,
		ValidateAndTransmit
	}

	public enum CodabarConcatenation : uint
	{
		On,
		Off,
		Required
	}

	public enum Code39CheckChar : uint
	{
		NoCheckChar,
		ValidateNotTransmitted,
		ValidateAndTransmit
	}

	public enum Interleaved2of5CheckChar : uint
	{
		NoCheckChar,
		ValidateNotTransmitted,
		ValidateAndTransmit
	}

	public enum NEC2of5CheckChar : uint
	{
		NoCheckChar,
		ValidateNotTransmitted,
		ValidateAndTransmit
	}

	public enum Code11CheckDigit : uint
	{
		Code11CheckDigit1,
		Code11CheckDigit2
	}

	public enum TelepenOutput : uint
	{
		Aim,
		Original
	}

	public enum MSICheckChar : uint
	{
		ValidateType10NotTransmitted,
		ValidateType10AndTransmit,
		Validate2Type10NotTransmitted,
		Validate2Type10AndTransmit,
		ValidateType10And11NotTransmitted,
		ValidateType10And11AndTransmit,
		DisableCeckChar
	}

	public enum GS1Emulation : uint
	{
		GS1Emulation128,
		dDatabar,
		dExpansionCodeOff,
		dEAN8toEAN13Conversion,
		dOff
	}

	public enum LedScheme : uint
	{
		DefaultLedScheme,
		AlternateLedScheme
	}
}
