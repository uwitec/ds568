﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3634
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Com.DianShi.Model.ShopConfig
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
	public partial class DS_ShopConfigDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDS_ShopConfig(DS_ShopConfig instance);
    partial void UpdateDS_ShopConfig(DS_ShopConfig instance);
    partial void DeleteDS_ShopConfig(DS_ShopConfig instance);
    #endregion
		
		public DS_ShopConfigDataContext() : 
				base(global::Com.DianShi.Model.ShopConfig.Properties.Settings.Default.hds0230549_dbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ShopConfigDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ShopConfigDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ShopConfigDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ShopConfigDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DS_ShopConfig> DS_ShopConfig
		{
			get
			{
				return this.GetTable<DS_ShopConfig>();
			}
		}
	}
	
	[Table(Name="dbo.DS_ShopConfig")]
	public partial class DS_ShopConfig : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _MemberID;
		
		private string _Sign;
		
		private string _MenuBg;
		
		private string _SelectedMenu;
		
		private string _NormalMenu;
		
		private string _NmColor;
		
		private string _SelmColor;
		
		private string _RollImg1;
		
		private string _RollImg2;
		
		private string _RollImg3;
		
		private System.Nullable<byte> _SignType;
		
		private string _ComNameStyle;
		
		private System.Nullable<bool> _ComNameDisplay;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMemberIDChanging(int value);
    partial void OnMemberIDChanged();
    partial void OnSignChanging(string value);
    partial void OnSignChanged();
    partial void OnMenuBgChanging(string value);
    partial void OnMenuBgChanged();
    partial void OnSelectedMenuChanging(string value);
    partial void OnSelectedMenuChanged();
    partial void OnNormalMenuChanging(string value);
    partial void OnNormalMenuChanged();
    partial void OnNmColorChanging(string value);
    partial void OnNmColorChanged();
    partial void OnSelmColorChanging(string value);
    partial void OnSelmColorChanged();
    partial void OnRollImg1Changing(string value);
    partial void OnRollImg1Changed();
    partial void OnRollImg2Changing(string value);
    partial void OnRollImg2Changed();
    partial void OnRollImg3Changing(string value);
    partial void OnRollImg3Changed();
    partial void OnSignTypeChanging(System.Nullable<byte> value);
    partial void OnSignTypeChanged();
    partial void OnComNameStyleChanging(string value);
    partial void OnComNameStyleChanged();
    partial void OnComNameDisplayChanging(System.Nullable<bool> value);
    partial void OnComNameDisplayChanged();
    #endregion
		
		public DS_ShopConfig()
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
		
		[Column(Storage="_Sign", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string Sign
		{
			get
			{
				return this._Sign;
			}
			set
			{
				if ((this._Sign != value))
				{
					this.OnSignChanging(value);
					this.SendPropertyChanging();
					this._Sign = value;
					this.SendPropertyChanged("Sign");
					this.OnSignChanged();
				}
			}
		}
		
		[Column(Storage="_MenuBg", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string MenuBg
		{
			get
			{
				return this._MenuBg;
			}
			set
			{
				if ((this._MenuBg != value))
				{
					this.OnMenuBgChanging(value);
					this.SendPropertyChanging();
					this._MenuBg = value;
					this.SendPropertyChanged("MenuBg");
					this.OnMenuBgChanged();
				}
			}
		}
		
		[Column(Storage="_SelectedMenu", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string SelectedMenu
		{
			get
			{
				return this._SelectedMenu;
			}
			set
			{
				if ((this._SelectedMenu != value))
				{
					this.OnSelectedMenuChanging(value);
					this.SendPropertyChanging();
					this._SelectedMenu = value;
					this.SendPropertyChanged("SelectedMenu");
					this.OnSelectedMenuChanged();
				}
			}
		}
		
		[Column(Storage="_NormalMenu", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string NormalMenu
		{
			get
			{
				return this._NormalMenu;
			}
			set
			{
				if ((this._NormalMenu != value))
				{
					this.OnNormalMenuChanging(value);
					this.SendPropertyChanging();
					this._NormalMenu = value;
					this.SendPropertyChanged("NormalMenu");
					this.OnNormalMenuChanged();
				}
			}
		}
		
		[Column(Storage="_NmColor", DbType="NVarChar(50)", UpdateCheck=UpdateCheck.Never)]
		public string NmColor
		{
			get
			{
				return this._NmColor;
			}
			set
			{
				if ((this._NmColor != value))
				{
					this.OnNmColorChanging(value);
					this.SendPropertyChanging();
					this._NmColor = value;
					this.SendPropertyChanged("NmColor");
					this.OnNmColorChanged();
				}
			}
		}
		
		[Column(Storage="_SelmColor", DbType="NVarChar(50)", UpdateCheck=UpdateCheck.Never)]
		public string SelmColor
		{
			get
			{
				return this._SelmColor;
			}
			set
			{
				if ((this._SelmColor != value))
				{
					this.OnSelmColorChanging(value);
					this.SendPropertyChanging();
					this._SelmColor = value;
					this.SendPropertyChanged("SelmColor");
					this.OnSelmColorChanged();
				}
			}
		}
		
		[Column(Storage="_RollImg1", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string RollImg1
		{
			get
			{
				return this._RollImg1;
			}
			set
			{
				if ((this._RollImg1 != value))
				{
					this.OnRollImg1Changing(value);
					this.SendPropertyChanging();
					this._RollImg1 = value;
					this.SendPropertyChanged("RollImg1");
					this.OnRollImg1Changed();
				}
			}
		}
		
		[Column(Storage="_RollImg2", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string RollImg2
		{
			get
			{
				return this._RollImg2;
			}
			set
			{
				if ((this._RollImg2 != value))
				{
					this.OnRollImg2Changing(value);
					this.SendPropertyChanging();
					this._RollImg2 = value;
					this.SendPropertyChanged("RollImg2");
					this.OnRollImg2Changed();
				}
			}
		}
		
		[Column(Storage="_RollImg3", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string RollImg3
		{
			get
			{
				return this._RollImg3;
			}
			set
			{
				if ((this._RollImg3 != value))
				{
					this.OnRollImg3Changing(value);
					this.SendPropertyChanging();
					this._RollImg3 = value;
					this.SendPropertyChanged("RollImg3");
					this.OnRollImg3Changed();
				}
			}
		}
		
		[Column(Storage="_SignType", DbType="TinyInt", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<byte> SignType
		{
			get
			{
				return this._SignType;
			}
			set
			{
				if ((this._SignType != value))
				{
					this.OnSignTypeChanging(value);
					this.SendPropertyChanging();
					this._SignType = value;
					this.SendPropertyChanged("SignType");
					this.OnSignTypeChanged();
				}
			}
		}
		
		[Column(Storage="_ComNameStyle", DbType="NVarChar(50)", UpdateCheck=UpdateCheck.Never)]
		public string ComNameStyle
		{
			get
			{
				return this._ComNameStyle;
			}
			set
			{
				if ((this._ComNameStyle != value))
				{
					this.OnComNameStyleChanging(value);
					this.SendPropertyChanging();
					this._ComNameStyle = value;
					this.SendPropertyChanged("ComNameStyle");
					this.OnComNameStyleChanged();
				}
			}
		}
		
		[Column(Storage="_ComNameDisplay", DbType="Bit", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<bool> ComNameDisplay
		{
			get
			{
				return this._ComNameDisplay;
			}
			set
			{
				if ((this._ComNameDisplay != value))
				{
					this.OnComNameDisplayChanging(value);
					this.SendPropertyChanging();
					this._ComNameDisplay = value;
					this.SendPropertyChanged("ComNameDisplay");
					this.OnComNameDisplayChanged();
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