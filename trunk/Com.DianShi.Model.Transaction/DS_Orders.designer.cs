﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3625
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Com.DianShi.Model.Transaction
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="hds0230549_db")]
	public partial class DS_OrdersDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDS_Orders(DS_Orders instance);
    partial void UpdateDS_Orders(DS_Orders instance);
    partial void DeleteDS_Orders(DS_Orders instance);
    #endregion
		
		public DS_OrdersDataContext() : 
				base(global::Com.DianShi.Model.Transaction.Properties.Settings.Default.hds0230549_dbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DS_OrdersDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_OrdersDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_OrdersDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_OrdersDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DS_Orders> DS_Orders
		{
			get
			{
				return this.GetTable<DS_Orders>();
			}
		}
	}
	
	[Table(Name="dbo.DS_Orders")]
	public partial class DS_Orders : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _MemberID;
		
		private string _CompanyName;
		
		private int _PurchaseID;
		
		private int _ProNum;
		
		private double _Amount;
		
		private string _OrderNum;
		
		private System.DateTime _CreateDate;
		
		private string _QQ;
		
		private string _ClientArea;
		
		private string _ClientZipCode;
		
		private string _ClientStreet;
		
		private string _ClientName;
		
		private string _ClientPhone;
		
		private string _ClientMobile;
		
		private string _ClientRemark;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMemberIDChanging(int value);
    partial void OnMemberIDChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    partial void OnPurchaseIDChanging(int value);
    partial void OnPurchaseIDChanged();
    partial void OnProNumChanging(int value);
    partial void OnProNumChanged();
    partial void OnAmountChanging(double value);
    partial void OnAmountChanged();
    partial void OnOrderNumChanging(string value);
    partial void OnOrderNumChanged();
    partial void OnCreateDateChanging(System.DateTime value);
    partial void OnCreateDateChanged();
    partial void OnQQChanging(string value);
    partial void OnQQChanged();
    partial void OnClientAreaChanging(string value);
    partial void OnClientAreaChanged();
    partial void OnClientZipCodeChanging(string value);
    partial void OnClientZipCodeChanged();
    partial void OnClientStreetChanging(string value);
    partial void OnClientStreetChanged();
    partial void OnClientNameChanging(string value);
    partial void OnClientNameChanged();
    partial void OnClientPhoneChanging(string value);
    partial void OnClientPhoneChanged();
    partial void OnClientMobileChanging(string value);
    partial void OnClientMobileChanged();
    partial void OnClientRemarkChanging(string value);
    partial void OnClientRemarkChanged();
    #endregion
		
		public DS_Orders()
		{
			OnCreated();
		}
		
		[Column(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, IsVersion=true)]
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
		
		[Column(Storage="_MemberID", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int MemberID
		{
			get
			{
				return this._MemberID;
			}
			set
			{
				if ((this._MemberID != value))
				{
					this.OnMemberIDChanging(value);
					this.SendPropertyChanging();
					this._MemberID = value;
					this.SendPropertyChanged("MemberID");
					this.OnMemberIDChanged();
				}
			}
		}
		
		[Column(Storage="_CompanyName", DbType="NVarChar(150) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
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
		
		[Column(Storage="_PurchaseID", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int PurchaseID
		{
			get
			{
				return this._PurchaseID;
			}
			set
			{
				if ((this._PurchaseID != value))
				{
					this.OnPurchaseIDChanging(value);
					this.SendPropertyChanging();
					this._PurchaseID = value;
					this.SendPropertyChanged("PurchaseID");
					this.OnPurchaseIDChanged();
				}
			}
		}
		
		[Column(Storage="_ProNum", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int ProNum
		{
			get
			{
				return this._ProNum;
			}
			set
			{
				if ((this._ProNum != value))
				{
					this.OnProNumChanging(value);
					this.SendPropertyChanging();
					this._ProNum = value;
					this.SendPropertyChanged("ProNum");
					this.OnProNumChanged();
				}
			}
		}
		
		[Column(Storage="_Amount", DbType="Float NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public double Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[Column(Storage="_OrderNum", DbType="NVarChar(15) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string OrderNum
		{
			get
			{
				return this._OrderNum;
			}
			set
			{
				if ((this._OrderNum != value))
				{
					this.OnOrderNumChanging(value);
					this.SendPropertyChanging();
					this._OrderNum = value;
					this.SendPropertyChanged("OrderNum");
					this.OnOrderNumChanged();
				}
			}
		}
		
		[Column(Storage="_CreateDate", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.DateTime CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		[Column(Storage="_QQ", DbType="NVarChar(15)", UpdateCheck=UpdateCheck.Never)]
		public string QQ
		{
			get
			{
				return this._QQ;
			}
			set
			{
				if ((this._QQ != value))
				{
					this.OnQQChanging(value);
					this.SendPropertyChanging();
					this._QQ = value;
					this.SendPropertyChanged("QQ");
					this.OnQQChanged();
				}
			}
		}
		
		[Column(Storage="_ClientArea", DbType="NVarChar(50) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string ClientArea
		{
			get
			{
				return this._ClientArea;
			}
			set
			{
				if ((this._ClientArea != value))
				{
					this.OnClientAreaChanging(value);
					this.SendPropertyChanging();
					this._ClientArea = value;
					this.SendPropertyChanged("ClientArea");
					this.OnClientAreaChanged();
				}
			}
		}
		
		[Column(Storage="_ClientZipCode", DbType="NVarChar(6) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string ClientZipCode
		{
			get
			{
				return this._ClientZipCode;
			}
			set
			{
				if ((this._ClientZipCode != value))
				{
					this.OnClientZipCodeChanging(value);
					this.SendPropertyChanging();
					this._ClientZipCode = value;
					this.SendPropertyChanged("ClientZipCode");
					this.OnClientZipCodeChanged();
				}
			}
		}
		
		[Column(Storage="_ClientStreet", DbType="NVarChar(100) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string ClientStreet
		{
			get
			{
				return this._ClientStreet;
			}
			set
			{
				if ((this._ClientStreet != value))
				{
					this.OnClientStreetChanging(value);
					this.SendPropertyChanging();
					this._ClientStreet = value;
					this.SendPropertyChanged("ClientStreet");
					this.OnClientStreetChanged();
				}
			}
		}
		
		[Column(Storage="_ClientName", DbType="NVarChar(10) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string ClientName
		{
			get
			{
				return this._ClientName;
			}
			set
			{
				if ((this._ClientName != value))
				{
					this.OnClientNameChanging(value);
					this.SendPropertyChanging();
					this._ClientName = value;
					this.SendPropertyChanged("ClientName");
					this.OnClientNameChanged();
				}
			}
		}
		
		[Column(Storage="_ClientPhone", DbType="NVarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string ClientPhone
		{
			get
			{
				return this._ClientPhone;
			}
			set
			{
				if ((this._ClientPhone != value))
				{
					this.OnClientPhoneChanging(value);
					this.SendPropertyChanging();
					this._ClientPhone = value;
					this.SendPropertyChanged("ClientPhone");
					this.OnClientPhoneChanged();
				}
			}
		}
		
		[Column(Storage="_ClientMobile", DbType="NVarChar(11)", UpdateCheck=UpdateCheck.Never)]
		public string ClientMobile
		{
			get
			{
				return this._ClientMobile;
			}
			set
			{
				if ((this._ClientMobile != value))
				{
					this.OnClientMobileChanging(value);
					this.SendPropertyChanging();
					this._ClientMobile = value;
					this.SendPropertyChanged("ClientMobile");
					this.OnClientMobileChanged();
				}
			}
		}
		
		[Column(Storage="_ClientRemark", DbType="NVarChar(500)", UpdateCheck=UpdateCheck.Never)]
		public string ClientRemark
		{
			get
			{
				return this._ClientRemark;
			}
			set
			{
				if ((this._ClientRemark != value))
				{
					this.OnClientRemarkChanging(value);
					this.SendPropertyChanging();
					this._ClientRemark = value;
					this.SendPropertyChanged("ClientRemark");
					this.OnClientRemarkChanged();
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
