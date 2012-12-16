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

namespace Com.DianShi.Model.Product
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
	public partial class View_ProductsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertView_Products(View_Products instance);
    partial void UpdateView_Products(View_Products instance);
    partial void DeleteView_Products(View_Products instance);
    #endregion
		
		public View_ProductsDataContext() : 
				base(global::Com.DianShi.Model.Product.Properties.Settings.Default.hds0230549_dbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public View_ProductsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public View_ProductsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public View_ProductsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public View_ProductsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<View_Products> View_Products
		{
			get
			{
				return this.GetTable<View_Products>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.View_Products")]
	public partial class View_Products : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Img1;
		
		private string _Title;
		
		private int _SysCatID;
		
		private int _ShopCatID;
		
		private byte _State;
		
		private System.DateTime _ExpiredDate;
		
		private string _CategoryName;
		
		private int _MemberID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnImg1Changing(string value);
    partial void OnImg1Changed();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnSysCatIDChanging(int value);
    partial void OnSysCatIDChanged();
    partial void OnShopCatIDChanging(int value);
    partial void OnShopCatIDChanged();
    partial void OnStateChanging(byte value);
    partial void OnStateChanged();
    partial void OnExpiredDateChanging(System.DateTime value);
    partial void OnExpiredDateChanged();
    partial void OnCategoryNameChanging(string value);
    partial void OnCategoryNameChanged();
    partial void OnMemberIDChanging(int value);
    partial void OnMemberIDChanged();
    #endregion
		
		public View_Products()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true, IsDbGenerated=true, IsVersion=true, UpdateCheck=UpdateCheck.Never)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Img1", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Img1
		{
			get
			{
				return this._Img1;
			}
			set
			{
				if ((this._Img1 != value))
				{
					this.OnImg1Changing(value);
					this.SendPropertyChanging();
					this._Img1 = value;
					this.SendPropertyChanged("Img1");
					this.OnImg1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(60) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SysCatID", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int SysCatID
		{
			get
			{
				return this._SysCatID;
			}
			set
			{
				if ((this._SysCatID != value))
				{
					this.OnSysCatIDChanging(value);
					this.SendPropertyChanging();
					this._SysCatID = value;
					this.SendPropertyChanged("SysCatID");
					this.OnSysCatIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShopCatID", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int ShopCatID
		{
			get
			{
				return this._ShopCatID;
			}
			set
			{
				if ((this._ShopCatID != value))
				{
					this.OnShopCatIDChanging(value);
					this.SendPropertyChanging();
					this._ShopCatID = value;
					this.SendPropertyChanged("ShopCatID");
					this.OnShopCatIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="TinyInt NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public byte State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpiredDate", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.DateTime ExpiredDate
		{
			get
			{
				return this._ExpiredDate;
			}
			set
			{
				if ((this._ExpiredDate != value))
				{
					this.OnExpiredDateChanging(value);
					this.SendPropertyChanging();
					this._ExpiredDate = value;
					this.SendPropertyChanged("ExpiredDate");
					this.OnExpiredDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryName", DbType="NVarChar(20) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string CategoryName
		{
			get
			{
				return this._CategoryName;
			}
			set
			{
				if ((this._CategoryName != value))
				{
					this.OnCategoryNameChanging(value);
					this.SendPropertyChanging();
					this._CategoryName = value;
					this.SendPropertyChanged("CategoryName");
					this.OnCategoryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemberID", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
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
