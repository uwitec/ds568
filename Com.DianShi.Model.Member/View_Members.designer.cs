﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1891
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="DianShi")]
	public partial class View_MembersDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertView_Members(View_Members instance);
    partial void UpdateView_Members(View_Members instance);
    partial void DeleteView_Members(View_Members instance);
    #endregion
		
		public View_MembersDataContext() : 
				base(global::Com.DianShi.Model.Member.Properties.Settings.Default.DianShiConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public View_MembersDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public View_MembersDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public View_MembersDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public View_MembersDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<View_Members> View_Members
		{
			get
			{
				return this.GetTable<View_Members>();
			}
		}
	}
	
	[Table(Name="dbo.View_Members")]
	public partial class View_Members : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _UserID;
		
		private string _Password;
		
		private string _Email;
		
		private string _TrueName;
		
		private string _Department;
		
		private string _Position;
		
		private string _Gender;
		
		private string _Phone;
		
		private string _Fax;
		
		private string _Mobile;
		
		private string _HomePage;
		
		private bool _EmailValidate;
		
		private bool _MobileValidate;
		
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
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnTrueNameChanging(string value);
    partial void OnTrueNameChanged();
    partial void OnDepartmentChanging(string value);
    partial void OnDepartmentChanged();
    partial void OnPositionChanging(string value);
    partial void OnPositionChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnFaxChanging(string value);
    partial void OnFaxChanged();
    partial void OnMobileChanging(string value);
    partial void OnMobileChanged();
    partial void OnHomePageChanging(string value);
    partial void OnHomePageChanged();
    partial void OnEmailValidateChanging(bool value);
    partial void OnEmailValidateChanged();
    partial void OnMobileValidateChanging(bool value);
    partial void OnMobileValidateChanged();
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
		
		public View_Members()
		{
			OnCreated();
		}
		
		[Column(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[Column(Storage="_UserID", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[Column(Storage="_Password", DbType="NVarChar(120) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[Column(Storage="_Email", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[Column(Storage="_TrueName", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string TrueName
		{
			get
			{
				return this._TrueName;
			}
			set
			{
				if ((this._TrueName != value))
				{
					this.OnTrueNameChanging(value);
					this.SendPropertyChanging();
					this._TrueName = value;
					this.SendPropertyChanged("TrueName");
					this.OnTrueNameChanged();
				}
			}
		}
		
		[Column(Storage="_Department", DbType="NVarChar(20)")]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
				}
			}
		}
		
		[Column(Storage="_Position", DbType="NVarChar(20)")]
		public string Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				if ((this._Position != value))
				{
					this.OnPositionChanging(value);
					this.SendPropertyChanging();
					this._Position = value;
					this.SendPropertyChanged("Position");
					this.OnPositionChanged();
				}
			}
		}
		
		[Column(Storage="_Gender", DbType="NVarChar(2) NOT NULL", CanBeNull=false)]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[Column(Storage="_Phone", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[Column(Storage="_Fax", DbType="NVarChar(20)")]
		public string Fax
		{
			get
			{
				return this._Fax;
			}
			set
			{
				if ((this._Fax != value))
				{
					this.OnFaxChanging(value);
					this.SendPropertyChanging();
					this._Fax = value;
					this.SendPropertyChanged("Fax");
					this.OnFaxChanged();
				}
			}
		}
		
		[Column(Storage="_Mobile", DbType="NVarChar(11)")]
		public string Mobile
		{
			get
			{
				return this._Mobile;
			}
			set
			{
				if ((this._Mobile != value))
				{
					this.OnMobileChanging(value);
					this.SendPropertyChanging();
					this._Mobile = value;
					this.SendPropertyChanged("Mobile");
					this.OnMobileChanged();
				}
			}
		}
		
		[Column(Storage="_HomePage", DbType="NVarChar(100)")]
		public string HomePage
		{
			get
			{
				return this._HomePage;
			}
			set
			{
				if ((this._HomePage != value))
				{
					this.OnHomePageChanging(value);
					this.SendPropertyChanging();
					this._HomePage = value;
					this.SendPropertyChanged("HomePage");
					this.OnHomePageChanged();
				}
			}
		}
		
		[Column(Storage="_EmailValidate", DbType="Bit NOT NULL")]
		public bool EmailValidate
		{
			get
			{
				return this._EmailValidate;
			}
			set
			{
				if ((this._EmailValidate != value))
				{
					this.OnEmailValidateChanging(value);
					this.SendPropertyChanging();
					this._EmailValidate = value;
					this.SendPropertyChanged("EmailValidate");
					this.OnEmailValidateChanged();
				}
			}
		}
		
		[Column(Storage="_MobileValidate", DbType="Bit NOT NULL")]
		public bool MobileValidate
		{
			get
			{
				return this._MobileValidate;
			}
			set
			{
				if ((this._MobileValidate != value))
				{
					this.OnMobileValidateChanging(value);
					this.SendPropertyChanging();
					this._MobileValidate = value;
					this.SendPropertyChanged("MobileValidate");
					this.OnMobileValidateChanged();
				}
			}
		}
		
		[Column(Storage="_CompanyName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[Column(Storage="_BusinessType", DbType="TinyInt")]
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
		
		[Column(Storage="_BusinessModel", DbType="NVarChar(20)")]
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
		
		[Column(Storage="_CapitalType", DbType="NVarChar(10)")]
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
		
		[Column(Storage="_RegisteredCapital", DbType="Float")]
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
		
		[Column(Storage="_YearEstablished", DbType="SmallInt NOT NULL")]
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
		
		[Column(Storage="_RegistrationArea", DbType="NVarChar(100)")]
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
		
		[Column(Storage="_Province", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[Column(Storage="_City", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[Column(Storage="_County", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[Column(Storage="_BusinessAddress", DbType="NVarChar(100)")]
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
		
		[Column(Storage="_ZipCode", DbType="NVarChar(6)")]
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
		
		[Column(Storage="_MemberType", DbType="TinyInt NOT NULL")]
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
		
		[Column(Storage="_OfferService", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[Column(Storage="_BuyService", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[Column(Storage="_MainIndustry", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[Column(Storage="_Profile", DbType="NVarChar(1800)")]
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
		
		[Column(Storage="_LegalRepresentative", DbType="NVarChar(20)")]
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
		
		[Column(Storage="_Bank", DbType="NVarChar(20)")]
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
		
		[Column(Storage="_Account", DbType="NVarChar(20)")]
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
		
		[Column(Storage="_StorageArea", DbType="NVarChar(20)")]
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
		
		[Column(Storage="_Employees", DbType="TinyInt")]
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
		
		[Column(Storage="_StudyEmployees", DbType="TinyInt")]
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
		
		[Column(Storage="_BrandName", DbType="NVarChar(20)")]
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
		
		[Column(Storage="_Monthly", DbType="Int")]
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
		
		[Column(Storage="_MonthlyUnit", DbType="NVarChar(10)")]
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
		
		[Column(Storage="_AnnualTurnover", DbType="TinyInt")]
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
		
		[Column(Storage="_AnnualExport", DbType="TinyInt")]
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
		
		[Column(Storage="_AnnualImports", DbType="TinyInt")]
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
		
		[Column(Storage="_MSCer", DbType="NVarChar(20)")]
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
		
		[Column(Storage="_QualityControl", DbType="NVarChar(50)")]
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
		
		[Column(Storage="_MainMarket", DbType="NVarChar(100)")]
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
		
		[Column(Storage="_MajorCustomers", DbType="NVarChar(100)")]
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
		
		[Column(Storage="_OEM", DbType="Bit")]
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
		
		[Column(Storage="_ComImg", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
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
