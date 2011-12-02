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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="DianShi")]
	public partial class DS_ProductsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDS_Products(DS_Products instance);
    partial void UpdateDS_Products(DS_Products instance);
    partial void DeleteDS_Products(DS_Products instance);
    #endregion
		
		public DS_ProductsDataContext() : 
				base(global::Com.DianShi.Model.Product.Properties.Settings.Default.DianShiConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ProductsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ProductsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ProductsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ProductsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DS_Products> DS_Products
		{
			get
			{
				return this.GetTable<DS_Products>();
			}
		}
	}
	
	[Table(Name="dbo.DS_Products")]
	public partial class DS_Products : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _SysCatID;
		
		private int _ShopCatID;
		
		private string _Title;
		
		private string _Img1;
		
		private string _Img2;
		
		private string _Img3;
		
		private string _Detail;
		
		private string _Unit;
		
		private System.Nullable<int> _MaxNumber;
		
		private string _Property1;
		
		private string _Property2;
		
		private string _Property3;
		
		private string _Property4;
		
		private string _Property5;
		
		private string _Property6;
		
		private string _Property7;
		
		private string _Property8;
		
		private string _Property9;
		
		private string _Property10;
		
		private string _Property11;
		
		private string _Property12;
		
		private string _Property13;
		
		private string _Property14;
		
		private string _Property15;
		
		private string _Property16;
		
		private string _Property17;
		
		private string _Property18;
		
		private string _Property19;
		
		private string _Property20;
		
		private string _Property21;
		
		private string _Property22;
		
		private string _Property23;
		
		private string _Property24;
		
		private System.DateTime _CreateDate;
		
		private System.DateTime _ExpiredDate;
		
		private string _PriceRang;
		
		private int _MemberID;
		
		private byte _State;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnSysCatIDChanging(int value);
    partial void OnSysCatIDChanged();
    partial void OnShopCatIDChanging(int value);
    partial void OnShopCatIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnImg1Changing(string value);
    partial void OnImg1Changed();
    partial void OnImg2Changing(string value);
    partial void OnImg2Changed();
    partial void OnImg3Changing(string value);
    partial void OnImg3Changed();
    partial void OnDetailChanging(string value);
    partial void OnDetailChanged();
    partial void OnUnitChanging(string value);
    partial void OnUnitChanged();
    partial void OnMaxNumberChanging(System.Nullable<int> value);
    partial void OnMaxNumberChanged();
    partial void OnProperty1Changing(string value);
    partial void OnProperty1Changed();
    partial void OnProperty2Changing(string value);
    partial void OnProperty2Changed();
    partial void OnProperty3Changing(string value);
    partial void OnProperty3Changed();
    partial void OnProperty4Changing(string value);
    partial void OnProperty4Changed();
    partial void OnProperty5Changing(string value);
    partial void OnProperty5Changed();
    partial void OnProperty6Changing(string value);
    partial void OnProperty6Changed();
    partial void OnProperty7Changing(string value);
    partial void OnProperty7Changed();
    partial void OnProperty8Changing(string value);
    partial void OnProperty8Changed();
    partial void OnProperty9Changing(string value);
    partial void OnProperty9Changed();
    partial void OnProperty10Changing(string value);
    partial void OnProperty10Changed();
    partial void OnProperty11Changing(string value);
    partial void OnProperty11Changed();
    partial void OnProperty12Changing(string value);
    partial void OnProperty12Changed();
    partial void OnProperty13Changing(string value);
    partial void OnProperty13Changed();
    partial void OnProperty14Changing(string value);
    partial void OnProperty14Changed();
    partial void OnProperty15Changing(string value);
    partial void OnProperty15Changed();
    partial void OnProperty16Changing(string value);
    partial void OnProperty16Changed();
    partial void OnProperty17Changing(string value);
    partial void OnProperty17Changed();
    partial void OnProperty18Changing(string value);
    partial void OnProperty18Changed();
    partial void OnProperty19Changing(string value);
    partial void OnProperty19Changed();
    partial void OnProperty20Changing(string value);
    partial void OnProperty20Changed();
    partial void OnProperty21Changing(string value);
    partial void OnProperty21Changed();
    partial void OnProperty22Changing(string value);
    partial void OnProperty22Changed();
    partial void OnProperty23Changing(string value);
    partial void OnProperty23Changed();
    partial void OnProperty24Changing(string value);
    partial void OnProperty24Changed();
    partial void OnCreateDateChanging(System.DateTime value);
    partial void OnCreateDateChanged();
    partial void OnExpiredDateChanging(System.DateTime value);
    partial void OnExpiredDateChanged();
    partial void OnPriceRangChanging(string value);
    partial void OnPriceRangChanged();
    partial void OnMemberIDChanging(int value);
    partial void OnMemberIDChanged();
    partial void OnStateChanging(byte value);
    partial void OnStateChanged();
    #endregion
		
		public DS_Products()
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
		
		[Column(Storage="_SysCatID", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
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
		
		[Column(Storage="_ShopCatID", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
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
		
		[Column(Storage="_Title", DbType="NVarChar(60) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
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
		
		[Column(Storage="_Img1", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
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
		
		[Column(Storage="_Img2", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Img2
		{
			get
			{
				return this._Img2;
			}
			set
			{
				if ((this._Img2 != value))
				{
					this.OnImg2Changing(value);
					this.SendPropertyChanging();
					this._Img2 = value;
					this.SendPropertyChanged("Img2");
					this.OnImg2Changed();
				}
			}
		}
		
		[Column(Storage="_Img3", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Img3
		{
			get
			{
				return this._Img3;
			}
			set
			{
				if ((this._Img3 != value))
				{
					this.OnImg3Changing(value);
					this.SendPropertyChanging();
					this._Img3 = value;
					this.SendPropertyChanged("Img3");
					this.OnImg3Changed();
				}
			}
		}
		
		[Column(Storage="_Detail", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Detail
		{
			get
			{
				return this._Detail;
			}
			set
			{
				if ((this._Detail != value))
				{
					this.OnDetailChanging(value);
					this.SendPropertyChanging();
					this._Detail = value;
					this.SendPropertyChanged("Detail");
					this.OnDetailChanged();
				}
			}
		}
		
		[Column(Storage="_Unit", DbType="NVarChar(20) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Unit
		{
			get
			{
				return this._Unit;
			}
			set
			{
				if ((this._Unit != value))
				{
					this.OnUnitChanging(value);
					this.SendPropertyChanging();
					this._Unit = value;
					this.SendPropertyChanged("Unit");
					this.OnUnitChanged();
				}
			}
		}
		
		[Column(Storage="_MaxNumber", DbType="Int", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<int> MaxNumber
		{
			get
			{
				return this._MaxNumber;
			}
			set
			{
				if ((this._MaxNumber != value))
				{
					this.OnMaxNumberChanging(value);
					this.SendPropertyChanging();
					this._MaxNumber = value;
					this.SendPropertyChanged("MaxNumber");
					this.OnMaxNumberChanged();
				}
			}
		}
		
		[Column(Storage="_Property1", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property1
		{
			get
			{
				return this._Property1;
			}
			set
			{
				if ((this._Property1 != value))
				{
					this.OnProperty1Changing(value);
					this.SendPropertyChanging();
					this._Property1 = value;
					this.SendPropertyChanged("Property1");
					this.OnProperty1Changed();
				}
			}
		}
		
		[Column(Storage="_Property2", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property2
		{
			get
			{
				return this._Property2;
			}
			set
			{
				if ((this._Property2 != value))
				{
					this.OnProperty2Changing(value);
					this.SendPropertyChanging();
					this._Property2 = value;
					this.SendPropertyChanged("Property2");
					this.OnProperty2Changed();
				}
			}
		}
		
		[Column(Storage="_Property3", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property3
		{
			get
			{
				return this._Property3;
			}
			set
			{
				if ((this._Property3 != value))
				{
					this.OnProperty3Changing(value);
					this.SendPropertyChanging();
					this._Property3 = value;
					this.SendPropertyChanged("Property3");
					this.OnProperty3Changed();
				}
			}
		}
		
		[Column(Storage="_Property4", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property4
		{
			get
			{
				return this._Property4;
			}
			set
			{
				if ((this._Property4 != value))
				{
					this.OnProperty4Changing(value);
					this.SendPropertyChanging();
					this._Property4 = value;
					this.SendPropertyChanged("Property4");
					this.OnProperty4Changed();
				}
			}
		}
		
		[Column(Storage="_Property5", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property5
		{
			get
			{
				return this._Property5;
			}
			set
			{
				if ((this._Property5 != value))
				{
					this.OnProperty5Changing(value);
					this.SendPropertyChanging();
					this._Property5 = value;
					this.SendPropertyChanged("Property5");
					this.OnProperty5Changed();
				}
			}
		}
		
		[Column(Storage="_Property6", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property6
		{
			get
			{
				return this._Property6;
			}
			set
			{
				if ((this._Property6 != value))
				{
					this.OnProperty6Changing(value);
					this.SendPropertyChanging();
					this._Property6 = value;
					this.SendPropertyChanged("Property6");
					this.OnProperty6Changed();
				}
			}
		}
		
		[Column(Storage="_Property7", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property7
		{
			get
			{
				return this._Property7;
			}
			set
			{
				if ((this._Property7 != value))
				{
					this.OnProperty7Changing(value);
					this.SendPropertyChanging();
					this._Property7 = value;
					this.SendPropertyChanged("Property7");
					this.OnProperty7Changed();
				}
			}
		}
		
		[Column(Storage="_Property8", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property8
		{
			get
			{
				return this._Property8;
			}
			set
			{
				if ((this._Property8 != value))
				{
					this.OnProperty8Changing(value);
					this.SendPropertyChanging();
					this._Property8 = value;
					this.SendPropertyChanged("Property8");
					this.OnProperty8Changed();
				}
			}
		}
		
		[Column(Storage="_Property9", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property9
		{
			get
			{
				return this._Property9;
			}
			set
			{
				if ((this._Property9 != value))
				{
					this.OnProperty9Changing(value);
					this.SendPropertyChanging();
					this._Property9 = value;
					this.SendPropertyChanged("Property9");
					this.OnProperty9Changed();
				}
			}
		}
		
		[Column(Storage="_Property10", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property10
		{
			get
			{
				return this._Property10;
			}
			set
			{
				if ((this._Property10 != value))
				{
					this.OnProperty10Changing(value);
					this.SendPropertyChanging();
					this._Property10 = value;
					this.SendPropertyChanged("Property10");
					this.OnProperty10Changed();
				}
			}
		}
		
		[Column(Storage="_Property11", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property11
		{
			get
			{
				return this._Property11;
			}
			set
			{
				if ((this._Property11 != value))
				{
					this.OnProperty11Changing(value);
					this.SendPropertyChanging();
					this._Property11 = value;
					this.SendPropertyChanged("Property11");
					this.OnProperty11Changed();
				}
			}
		}
		
		[Column(Storage="_Property12", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property12
		{
			get
			{
				return this._Property12;
			}
			set
			{
				if ((this._Property12 != value))
				{
					this.OnProperty12Changing(value);
					this.SendPropertyChanging();
					this._Property12 = value;
					this.SendPropertyChanged("Property12");
					this.OnProperty12Changed();
				}
			}
		}
		
		[Column(Storage="_Property13", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property13
		{
			get
			{
				return this._Property13;
			}
			set
			{
				if ((this._Property13 != value))
				{
					this.OnProperty13Changing(value);
					this.SendPropertyChanging();
					this._Property13 = value;
					this.SendPropertyChanged("Property13");
					this.OnProperty13Changed();
				}
			}
		}
		
		[Column(Storage="_Property14", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property14
		{
			get
			{
				return this._Property14;
			}
			set
			{
				if ((this._Property14 != value))
				{
					this.OnProperty14Changing(value);
					this.SendPropertyChanging();
					this._Property14 = value;
					this.SendPropertyChanged("Property14");
					this.OnProperty14Changed();
				}
			}
		}
		
		[Column(Storage="_Property15", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property15
		{
			get
			{
				return this._Property15;
			}
			set
			{
				if ((this._Property15 != value))
				{
					this.OnProperty15Changing(value);
					this.SendPropertyChanging();
					this._Property15 = value;
					this.SendPropertyChanged("Property15");
					this.OnProperty15Changed();
				}
			}
		}
		
		[Column(Storage="_Property16", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property16
		{
			get
			{
				return this._Property16;
			}
			set
			{
				if ((this._Property16 != value))
				{
					this.OnProperty16Changing(value);
					this.SendPropertyChanging();
					this._Property16 = value;
					this.SendPropertyChanged("Property16");
					this.OnProperty16Changed();
				}
			}
		}
		
		[Column(Storage="_Property17", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property17
		{
			get
			{
				return this._Property17;
			}
			set
			{
				if ((this._Property17 != value))
				{
					this.OnProperty17Changing(value);
					this.SendPropertyChanging();
					this._Property17 = value;
					this.SendPropertyChanged("Property17");
					this.OnProperty17Changed();
				}
			}
		}
		
		[Column(Storage="_Property18", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property18
		{
			get
			{
				return this._Property18;
			}
			set
			{
				if ((this._Property18 != value))
				{
					this.OnProperty18Changing(value);
					this.SendPropertyChanging();
					this._Property18 = value;
					this.SendPropertyChanged("Property18");
					this.OnProperty18Changed();
				}
			}
		}
		
		[Column(Storage="_Property19", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property19
		{
			get
			{
				return this._Property19;
			}
			set
			{
				if ((this._Property19 != value))
				{
					this.OnProperty19Changing(value);
					this.SendPropertyChanging();
					this._Property19 = value;
					this.SendPropertyChanged("Property19");
					this.OnProperty19Changed();
				}
			}
		}
		
		[Column(Storage="_Property20", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property20
		{
			get
			{
				return this._Property20;
			}
			set
			{
				if ((this._Property20 != value))
				{
					this.OnProperty20Changing(value);
					this.SendPropertyChanging();
					this._Property20 = value;
					this.SendPropertyChanged("Property20");
					this.OnProperty20Changed();
				}
			}
		}
		
		[Column(Storage="_Property21", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property21
		{
			get
			{
				return this._Property21;
			}
			set
			{
				if ((this._Property21 != value))
				{
					this.OnProperty21Changing(value);
					this.SendPropertyChanging();
					this._Property21 = value;
					this.SendPropertyChanged("Property21");
					this.OnProperty21Changed();
				}
			}
		}
		
		[Column(Storage="_Property22", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property22
		{
			get
			{
				return this._Property22;
			}
			set
			{
				if ((this._Property22 != value))
				{
					this.OnProperty22Changing(value);
					this.SendPropertyChanging();
					this._Property22 = value;
					this.SendPropertyChanged("Property22");
					this.OnProperty22Changed();
				}
			}
		}
		
		[Column(Storage="_Property23", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property23
		{
			get
			{
				return this._Property23;
			}
			set
			{
				if ((this._Property23 != value))
				{
					this.OnProperty23Changing(value);
					this.SendPropertyChanging();
					this._Property23 = value;
					this.SendPropertyChanged("Property23");
					this.OnProperty23Changed();
				}
			}
		}
		
		[Column(Storage="_Property24", DbType="NVarChar(250)", UpdateCheck=UpdateCheck.Never)]
		public string Property24
		{
			get
			{
				return this._Property24;
			}
			set
			{
				if ((this._Property24 != value))
				{
					this.OnProperty24Changing(value);
					this.SendPropertyChanging();
					this._Property24 = value;
					this.SendPropertyChanged("Property24");
					this.OnProperty24Changed();
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
		
		[Column(Storage="_ExpiredDate", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
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
		
		[Column(Storage="_PriceRang", DbType="NVarChar(150) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string PriceRang
		{
			get
			{
				return this._PriceRang;
			}
			set
			{
				if ((this._PriceRang != value))
				{
					this.OnPriceRangChanging(value);
					this.SendPropertyChanging();
					this._PriceRang = value;
					this.SendPropertyChanged("PriceRang");
					this.OnPriceRangChanged();
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
		
		[Column(Storage="_State", DbType="TinyInt NOT NULL", UpdateCheck=UpdateCheck.Never)]
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
