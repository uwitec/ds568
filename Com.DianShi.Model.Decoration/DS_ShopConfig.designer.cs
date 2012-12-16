﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="hds0230549_db")]
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DS_ShopConfig")]
	public partial class DS_ShopConfig : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _MemberID;
		
		private System.Nullable<byte> _SignType;
		
		private string _SignImg;
		
		private string _SignBgColor;
		
		private string _ComNameCss;
		
		private System.Nullable<bool> _ComNameShow;
		
		private string _MenuBg;
		
		private string _SelectedMenu;
		
		private string _NormalMenu;
		
		private string _NmColor;
		
		private string _SelmColor;
		
		private string _RollImg1;
		
		private string _RollImg2;
		
		private string _RollImg3;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMemberIDChanging(int value);
    partial void OnMemberIDChanged();
    partial void OnSignTypeChanging(System.Nullable<byte> value);
    partial void OnSignTypeChanged();
    partial void OnSignImgChanging(string value);
    partial void OnSignImgChanged();
    partial void OnSignBgColorChanging(string value);
    partial void OnSignBgColorChanged();
    partial void OnComNameCssChanging(string value);
    partial void OnComNameCssChanged();
    partial void OnComNameShowChanging(System.Nullable<bool> value);
    partial void OnComNameShowChanged();
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
    #endregion
		
		public DS_ShopConfig()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemberID", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.WhenChanged)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SignType", DbType="TinyInt", UpdateCheck=UpdateCheck.WhenChanged)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SignImg", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.WhenChanged)]
		public string SignImg
		{
			get
			{
				return this._SignImg;
			}
			set
			{
				if ((this._SignImg != value))
				{
					this.OnSignImgChanging(value);
					this.SendPropertyChanging();
					this._SignImg = value;
					this.SendPropertyChanged("SignImg");
					this.OnSignImgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SignBgColor", DbType="NChar(10)", UpdateCheck=UpdateCheck.WhenChanged)]
		public string SignBgColor
		{
			get
			{
				return this._SignBgColor;
			}
			set
			{
				if ((this._SignBgColor != value))
				{
					this.OnSignBgColorChanging(value);
					this.SendPropertyChanging();
					this._SignBgColor = value;
					this.SendPropertyChanged("SignBgColor");
					this.OnSignBgColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ComNameCss", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.WhenChanged)]
		public string ComNameCss
		{
			get
			{
				return this._ComNameCss;
			}
			set
			{
				if ((this._ComNameCss != value))
				{
					this.OnComNameCssChanging(value);
					this.SendPropertyChanging();
					this._ComNameCss = value;
					this.SendPropertyChanged("ComNameCss");
					this.OnComNameCssChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ComNameShow", DbType="Bit", UpdateCheck=UpdateCheck.WhenChanged)]
		public System.Nullable<bool> ComNameShow
		{
			get
			{
				return this._ComNameShow;
			}
			set
			{
				if ((this._ComNameShow != value))
				{
					this.OnComNameShowChanging(value);
					this.SendPropertyChanging();
					this._ComNameShow = value;
					this.SendPropertyChanged("ComNameShow");
					this.OnComNameShowChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuBg", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.WhenChanged)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SelectedMenu", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.WhenChanged)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NormalMenu", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.WhenChanged)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NmColor", DbType="NVarChar(50)", UpdateCheck=UpdateCheck.WhenChanged)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SelmColor", DbType="NVarChar(50)", UpdateCheck=UpdateCheck.WhenChanged)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RollImg1", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.WhenChanged)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RollImg2", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.WhenChanged)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RollImg3", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.WhenChanged)]
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
