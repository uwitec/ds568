﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Com.DianShi.Model.Member
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DianShi")]
	public partial class DS_CompanyInfoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDS_CompanyInfo(DS_CompanyInfo instance);
    partial void UpdateDS_CompanyInfo(DS_CompanyInfo instance);
    partial void DeleteDS_CompanyInfo(DS_CompanyInfo instance);
    #endregion
		
		public DS_CompanyInfoDataContext() : 
				base(global::Com.DianShi.Model.Member.Properties.Settings.Default.DianShiConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DS_CompanyInfoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_CompanyInfoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_CompanyInfoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_CompanyInfoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DS_CompanyInfo> DS_CompanyInfo
		{
			get
			{
				return this.GetTable<DS_CompanyInfo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DS_CompanyInfo")]
	public partial class DS_CompanyInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _MenberID;
		
		private string _CompanyName;
		
		private System.Nullable<byte> _BusinessType;
		
		private string _BusinessModel;
		
		private string _CapitalType;
		
		private System.Nullable<double> _RegisteredCapital;
		
		private short _YearEstablished;
		
		private string _RegistrationArea;
		
		private string _Province;
		
		private string _City;
		
		private string _County;
		
		private string _BusinessAddress;
		
		private string _MapNid;
		
		private string _ZipCode;
		
		private byte _MemberType;
		
		private string _OfferService;
		
		private string _BuyService;
		
		private string _MainIndustry;
		
		private string _Profile;
		
		private string _LegalRepresentative;
		
		private string _Bank;
		
		private string _Account;
		
		private string _StorageArea;
		
		private System.Nullable<byte> _Employees;
		
		private System.Nullable<byte> _StudyEmployees;
		
		private string _BrandName;
		
		private System.Nullable<int> _Monthly;
		
		private string _MonthlyUnit;
		
		private System.Nullable<byte> _AnnualTurnover;
		
		private System.Nullable<byte> _AnnualExport;
		
		private System.Nullable<byte> _AnnualImports;
		
		private string _MSCer;
		
		private string _QualityControl;
		
		private string _MainMarket;
		
		private string _MajorCustomers;
		
		private System.Nullable<bool> _OEM;
		
		private string _ComImg;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMenberIDChanging(int value);
    partial void OnMenberIDChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    partial void OnBusinessTypeChanging(System.Nullable<byte> value);
    partial void OnBusinessTypeChanged();
    partial void OnBusinessModelChanging(string value);
    partial void OnBusinessModelChanged();
    partial void OnCapitalTypeChanging(string value);
    partial void OnCapitalTypeChanged();
    partial void OnRegisteredCapitalChanging(System.Nullable<double> value);
    partial void OnRegisteredCapitalChanged();
    partial void OnYearEstablishedChanging(short value);
    partial void OnYearEstablishedChanged();
    partial void OnRegistrationAreaChanging(string value);
    partial void OnRegistrationAreaChanged();
    partial void OnProvinceChanging(string value);
    partial void OnProvinceChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnCountyChanging(string value);
    partial void OnCountyChanged();
    partial void OnBusinessAddressChanging(string value);
    partial void OnBusinessAddressChanged();
    partial void OnMapNidChanging(string value);
    partial void OnMapNidChanged();
    partial void OnZipCodeChanging(string value);
    partial void OnZipCodeChanged();
    partial void OnMemberTypeChanging(byte value);
    partial void OnMemberTypeChanged();
    partial void OnOfferServiceChanging(string value);
    partial void OnOfferServiceChanged();
    partial void OnBuyServiceChanging(string value);
    partial void OnBuyServiceChanged();
    partial void OnMainIndustryChanging(string value);
    partial void OnMainIndustryChanged();
    partial void OnProfileChanging(string value);
    partial void OnProfileChanged();
    partial void OnLegalRepresentativeChanging(string value);
    partial void OnLegalRepresentativeChanged();
    partial void OnBankChanging(string value);
    partial void OnBankChanged();
    partial void OnAccountChanging(string value);
    partial void OnAccountChanged();
    partial void OnStorageAreaChanging(string value);
    partial void OnStorageAreaChanged();
    partial void OnEmployeesChanging(System.Nullable<byte> value);
    partial void OnEmployeesChanged();
    partial void OnStudyEmployeesChanging(System.Nullable<byte> value);
    partial void OnStudyEmployeesChanged();
    partial void OnBrandNameChanging(string value);
    partial void OnBrandNameChanged();
    partial void OnMonthlyChanging(System.Nullable<int> value);
    partial void OnMonthlyChanged();
    partial void OnMonthlyUnitChanging(string value);
    partial void OnMonthlyUnitChanged();
    partial void OnAnnualTurnoverChanging(System.Nullable<byte> value);
    partial void OnAnnualTurnoverChanged();
    partial void OnAnnualExportChanging(System.Nullable<byte> value);
    partial void OnAnnualExportChanged();
    partial void OnAnnualImportsChanging(System.Nullable<byte> value);
    partial void OnAnnualImportsChanged();
    partial void OnMSCerChanging(string value);
    partial void OnMSCerChanged();
    partial void OnQualityControlChanging(string value);
    partial void OnQualityControlChanged();
    partial void OnMainMarketChanging(string value);
    partial void OnMainMarketChanged();
    partial void OnMajorCustomersChanging(string value);
    partial void OnMajorCustomersChanged();
    partial void OnOEMChanging(System.Nullable<bool> value);
    partial void OnOEMChanged();
    partial void OnComImgChanging(string value);
    partial void OnComImgChanged();
    #endregion
		
		public DS_CompanyInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, IsVersion=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenberID", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int MenberID
		{
			get
			{
				return this._MenberID;
			}
			set
			{
				if ((this._MenberID != value))
				{
					this.OnMenberIDChanging(value);
					this.SendPropertyChanging();
					this._MenberID = value;
					this.SendPropertyChanged("MenberID");
					this.OnMenberIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="NVarChar(100) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this.OnCompanyNameChanging(value);
					this.SendPropertyChanging();
					this._CompanyName = value;
					this.SendPropertyChanged("CompanyName");
					this.OnCompanyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BusinessType", DbType="TinyInt", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<byte> BusinessType
		{
			get
			{
				return this._BusinessType;
			}
			set
			{
				if ((this._BusinessType != value))
				{
					this.OnBusinessTypeChanging(value);
					this.SendPropertyChanging();
					this._BusinessType = value;
					this.SendPropertyChanged("BusinessType");
					this.OnBusinessTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BusinessModel", DbType="NVarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string BusinessModel
		{
			get
			{
				return this._BusinessModel;
			}
			set
			{
				if ((this._BusinessModel != value))
				{
					this.OnBusinessModelChanging(value);
					this.SendPropertyChanging();
					this._BusinessModel = value;
					this.SendPropertyChanged("BusinessModel");
					this.OnBusinessModelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CapitalType", DbType="NVarChar(10)", UpdateCheck=UpdateCheck.Never)]
		public string CapitalType
		{
			get
			{
				return this._CapitalType;
			}
			set
			{
				if ((this._CapitalType != value))
				{
					this.OnCapitalTypeChanging(value);
					this.SendPropertyChanging();
					this._CapitalType = value;
					this.SendPropertyChanged("CapitalType");
					this.OnCapitalTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegisteredCapital", DbType="Float", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<double> RegisteredCapital
		{
			get
			{
				return this._RegisteredCapital;
			}
			set
			{
				if ((this._RegisteredCapital != value))
				{
					this.OnRegisteredCapitalChanging(value);
					this.SendPropertyChanging();
					this._RegisteredCapital = value;
					this.SendPropertyChanged("RegisteredCapital");
					this.OnRegisteredCapitalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YearEstablished", DbType="SmallInt NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public short YearEstablished
		{
			get
			{
				return this._YearEstablished;
			}
			set
			{
				if ((this._YearEstablished != value))
				{
					this.OnYearEstablishedChanging(value);
					this.SendPropertyChanging();
					this._YearEstablished = value;
					this.SendPropertyChanged("YearEstablished");
					this.OnYearEstablishedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegistrationArea", DbType="NVarChar(100)", UpdateCheck=UpdateCheck.Never)]
		public string RegistrationArea
		{
			get
			{
				return this._RegistrationArea;
			}
			set
			{
				if ((this._RegistrationArea != value))
				{
					this.OnRegistrationAreaChanging(value);
					this.SendPropertyChanging();
					this._RegistrationArea = value;
					this.SendPropertyChanged("RegistrationArea");
					this.OnRegistrationAreaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Province", DbType="NVarChar(50) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Province
		{
			get
			{
				return this._Province;
			}
			set
			{
				if ((this._Province != value))
				{
					this.OnProvinceChanging(value);
					this.SendPropertyChanging();
					this._Province = value;
					this.SendPropertyChanged("Province");
					this.OnProvinceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_County", DbType="NVarChar(50) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string County
		{
			get
			{
				return this._County;
			}
			set
			{
				if ((this._County != value))
				{
					this.OnCountyChanging(value);
					this.SendPropertyChanging();
					this._County = value;
					this.SendPropertyChanged("County");
					this.OnCountyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BusinessAddress", DbType="NVarChar(100)", UpdateCheck=UpdateCheck.Never)]
		public string BusinessAddress
		{
			get
			{
				return this._BusinessAddress;
			}
			set
			{
				if ((this._BusinessAddress != value))
				{
					this.OnBusinessAddressChanging(value);
					this.SendPropertyChanging();
					this._BusinessAddress = value;
					this.SendPropertyChanged("BusinessAddress");
					this.OnBusinessAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MapNid", DbType="NVarChar(30)", UpdateCheck=UpdateCheck.Never)]
		public string MapNid
		{
			get
			{
				return this._MapNid;
			}
			set
			{
				if ((this._MapNid != value))
				{
					this.OnMapNidChanging(value);
					this.SendPropertyChanging();
					this._MapNid = value;
					this.SendPropertyChanged("MapNid");
					this.OnMapNidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="NVarChar(6)", UpdateCheck=UpdateCheck.Never)]
		public string ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this.OnZipCodeChanging(value);
					this.SendPropertyChanging();
					this._ZipCode = value;
					this.SendPropertyChanged("ZipCode");
					this.OnZipCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemberType", DbType="TinyInt NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public byte MemberType
		{
			get
			{
				return this._MemberType;
			}
			set
			{
				if ((this._MemberType != value))
				{
					this.OnMemberTypeChanging(value);
					this.SendPropertyChanging();
					this._MemberType = value;
					this.SendPropertyChanged("MemberType");
					this.OnMemberTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OfferService", DbType="NVarChar(100) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string OfferService
		{
			get
			{
				return this._OfferService;
			}
			set
			{
				if ((this._OfferService != value))
				{
					this.OnOfferServiceChanging(value);
					this.SendPropertyChanging();
					this._OfferService = value;
					this.SendPropertyChanged("OfferService");
					this.OnOfferServiceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BuyService", DbType="NVarChar(100) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string BuyService
		{
			get
			{
				return this._BuyService;
			}
			set
			{
				if ((this._BuyService != value))
				{
					this.OnBuyServiceChanging(value);
					this.SendPropertyChanging();
					this._BuyService = value;
					this.SendPropertyChanged("BuyService");
					this.OnBuyServiceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MainIndustry", DbType="NVarChar(100) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string MainIndustry
		{
			get
			{
				return this._MainIndustry;
			}
			set
			{
				if ((this._MainIndustry != value))
				{
					this.OnMainIndustryChanging(value);
					this.SendPropertyChanging();
					this._MainIndustry = value;
					this.SendPropertyChanged("MainIndustry");
					this.OnMainIndustryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Profile", DbType="NVarChar(1800)", UpdateCheck=UpdateCheck.Never)]
		public string Profile
		{
			get
			{
				return this._Profile;
			}
			set
			{
				if ((this._Profile != value))
				{
					this.OnProfileChanging(value);
					this.SendPropertyChanging();
					this._Profile = value;
					this.SendPropertyChanged("Profile");
					this.OnProfileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LegalRepresentative", DbType="NVarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string LegalRepresentative
		{
			get
			{
				return this._LegalRepresentative;
			}
			set
			{
				if ((this._LegalRepresentative != value))
				{
					this.OnLegalRepresentativeChanging(value);
					this.SendPropertyChanging();
					this._LegalRepresentative = value;
					this.SendPropertyChanged("LegalRepresentative");
					this.OnLegalRepresentativeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bank", DbType="NVarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string Bank
		{
			get
			{
				return this._Bank;
			}
			set
			{
				if ((this._Bank != value))
				{
					this.OnBankChanging(value);
					this.SendPropertyChanging();
					this._Bank = value;
					this.SendPropertyChanged("Bank");
					this.OnBankChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Account", DbType="NVarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string Account
		{
			get
			{
				return this._Account;
			}
			set
			{
				if ((this._Account != value))
				{
					this.OnAccountChanging(value);
					this.SendPropertyChanging();
					this._Account = value;
					this.SendPropertyChanged("Account");
					this.OnAccountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StorageArea", DbType="NVarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string StorageArea
		{
			get
			{
				return this._StorageArea;
			}
			set
			{
				if ((this._StorageArea != value))
				{
					this.OnStorageAreaChanging(value);
					this.SendPropertyChanging();
					this._StorageArea = value;
					this.SendPropertyChanged("StorageArea");
					this.OnStorageAreaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employees", DbType="TinyInt", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<byte> Employees
		{
			get
			{
				return this._Employees;
			}
			set
			{
				if ((this._Employees != value))
				{
					this.OnEmployeesChanging(value);
					this.SendPropertyChanging();
					this._Employees = value;
					this.SendPropertyChanged("Employees");
					this.OnEmployeesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudyEmployees", DbType="TinyInt", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<byte> StudyEmployees
		{
			get
			{
				return this._StudyEmployees;
			}
			set
			{
				if ((this._StudyEmployees != value))
				{
					this.OnStudyEmployeesChanging(value);
					this.SendPropertyChanging();
					this._StudyEmployees = value;
					this.SendPropertyChanged("StudyEmployees");
					this.OnStudyEmployeesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BrandName", DbType="NVarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string BrandName
		{
			get
			{
				return this._BrandName;
			}
			set
			{
				if ((this._BrandName != value))
				{
					this.OnBrandNameChanging(value);
					this.SendPropertyChanging();
					this._BrandName = value;
					this.SendPropertyChanged("BrandName");
					this.OnBrandNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Monthly", DbType="Int", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<int> Monthly
		{
			get
			{
				return this._Monthly;
			}
			set
			{
				if ((this._Monthly != value))
				{
					this.OnMonthlyChanging(value);
					this.SendPropertyChanging();
					this._Monthly = value;
					this.SendPropertyChanged("Monthly");
					this.OnMonthlyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MonthlyUnit", DbType="NVarChar(10)", UpdateCheck=UpdateCheck.Never)]
		public string MonthlyUnit
		{
			get
			{
				return this._MonthlyUnit;
			}
			set
			{
				if ((this._MonthlyUnit != value))
				{
					this.OnMonthlyUnitChanging(value);
					this.SendPropertyChanging();
					this._MonthlyUnit = value;
					this.SendPropertyChanged("MonthlyUnit");
					this.OnMonthlyUnitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnnualTurnover", DbType="TinyInt", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<byte> AnnualTurnover
		{
			get
			{
				return this._AnnualTurnover;
			}
			set
			{
				if ((this._AnnualTurnover != value))
				{
					this.OnAnnualTurnoverChanging(value);
					this.SendPropertyChanging();
					this._AnnualTurnover = value;
					this.SendPropertyChanged("AnnualTurnover");
					this.OnAnnualTurnoverChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnnualExport", DbType="TinyInt", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<byte> AnnualExport
		{
			get
			{
				return this._AnnualExport;
			}
			set
			{
				if ((this._AnnualExport != value))
				{
					this.OnAnnualExportChanging(value);
					this.SendPropertyChanging();
					this._AnnualExport = value;
					this.SendPropertyChanged("AnnualExport");
					this.OnAnnualExportChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnnualImports", DbType="TinyInt", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<byte> AnnualImports
		{
			get
			{
				return this._AnnualImports;
			}
			set
			{
				if ((this._AnnualImports != value))
				{
					this.OnAnnualImportsChanging(value);
					this.SendPropertyChanging();
					this._AnnualImports = value;
					this.SendPropertyChanged("AnnualImports");
					this.OnAnnualImportsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MSCer", DbType="NVarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string MSCer
		{
			get
			{
				return this._MSCer;
			}
			set
			{
				if ((this._MSCer != value))
				{
					this.OnMSCerChanging(value);
					this.SendPropertyChanging();
					this._MSCer = value;
					this.SendPropertyChanged("MSCer");
					this.OnMSCerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QualityControl", DbType="NVarChar(50)", UpdateCheck=UpdateCheck.Never)]
		public string QualityControl
		{
			get
			{
				return this._QualityControl;
			}
			set
			{
				if ((this._QualityControl != value))
				{
					this.OnQualityControlChanging(value);
					this.SendPropertyChanging();
					this._QualityControl = value;
					this.SendPropertyChanged("QualityControl");
					this.OnQualityControlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MainMarket", DbType="NVarChar(100)", UpdateCheck=UpdateCheck.Never)]
		public string MainMarket
		{
			get
			{
				return this._MainMarket;
			}
			set
			{
				if ((this._MainMarket != value))
				{
					this.OnMainMarketChanging(value);
					this.SendPropertyChanging();
					this._MainMarket = value;
					this.SendPropertyChanged("MainMarket");
					this.OnMainMarketChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MajorCustomers", DbType="NVarChar(100)", UpdateCheck=UpdateCheck.Never)]
		public string MajorCustomers
		{
			get
			{
				return this._MajorCustomers;
			}
			set
			{
				if ((this._MajorCustomers != value))
				{
					this.OnMajorCustomersChanging(value);
					this.SendPropertyChanging();
					this._MajorCustomers = value;
					this.SendPropertyChanged("MajorCustomers");
					this.OnMajorCustomersChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OEM", DbType="Bit", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<bool> OEM
		{
			get
			{
				return this._OEM;
			}
			set
			{
				if ((this._OEM != value))
				{
					this.OnOEMChanging(value);
					this.SendPropertyChanging();
					this._OEM = value;
					this.SendPropertyChanged("OEM");
					this.OnOEMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ComImg", DbType="NVarChar(250) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string ComImg
		{
			get
			{
				return this._ComImg;
			}
			set
			{
				if ((this._ComImg != value))
				{
					this.OnComImgChanging(value);
					this.SendPropertyChanging();
					this._ComImg = value;
					this.SendPropertyChanged("ComImg");
					this.OnComImgChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
