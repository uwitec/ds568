﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3643
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
	public partial class DS_ShopThemeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDS_ShopTheme(DS_ShopTheme instance);
    partial void UpdateDS_ShopTheme(DS_ShopTheme instance);
    partial void DeleteDS_ShopTheme(DS_ShopTheme instance);
    #endregion
		
		public DS_ShopThemeDataContext() : 
				base(global::Com.DianShi.Model.ShopConfig.Properties.Settings.Default.hds0230549_dbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ShopThemeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ShopThemeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ShopThemeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ShopThemeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DS_ShopTheme> DS_ShopTheme
		{
			get
			{
				return this.GetTable<DS_ShopTheme>();
			}
		}
	}
	
	[Table(Name="dbo.DS_ShopTheme")]
	public partial class DS_ShopTheme : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _ThemeName;
		
		private System.Nullable<byte> _SignType;
		
		private string _SignImg;
		
		private string _SignBgColor;
		
		private System.Nullable<bool> _ComNameShow;
		
		private string _ComNameCss;
		
		private string _Thume;
		
		private string _AdSigleImg;
		
		private string _AdSigleTxt;
		
		private string _AdMutiImg1;
		
		private string _AdMutiImg2;
		
		private string _AdMutiImg3;
		
		private string _AdMutiImg4;
		
		private string _AdMutiTxt1;
		
		private string _AdMutiTxt2;
		
		private string _AdMutiTxt3;
		
		private string _AdMutiTxt4;
		
		private string _InnerBg;
		
		private string _OuterBg;
		
		private string _NavBg;
		
		private string _NavBgNormal;
		
		private string _NavNormalCss;
		
		private string _NavBgSel;
		
		private string _NavSelCss;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnThemeNameChanging(string value);
    partial void OnThemeNameChanged();
    partial void OnSignTypeChanging(System.Nullable<byte> value);
    partial void OnSignTypeChanged();
    partial void OnSignImgChanging(string value);
    partial void OnSignImgChanged();
    partial void OnSignBgColorChanging(string value);
    partial void OnSignBgColorChanged();
    partial void OnComNameShowChanging(System.Nullable<bool> value);
    partial void OnComNameShowChanged();
    partial void OnComNameCssChanging(string value);
    partial void OnComNameCssChanged();
    partial void OnThumeChanging(string value);
    partial void OnThumeChanged();
    partial void OnAdSigleImgChanging(string value);
    partial void OnAdSigleImgChanged();
    partial void OnAdSigleTxtChanging(string value);
    partial void OnAdSigleTxtChanged();
    partial void OnAdMutiImg1Changing(string value);
    partial void OnAdMutiImg1Changed();
    partial void OnAdMutiImg2Changing(string value);
    partial void OnAdMutiImg2Changed();
    partial void OnAdMutiImg3Changing(string value);
    partial void OnAdMutiImg3Changed();
    partial void OnAdMutiImg4Changing(string value);
    partial void OnAdMutiImg4Changed();
    partial void OnAdMutiTxt1Changing(string value);
    partial void OnAdMutiTxt1Changed();
    partial void OnAdMutiTxt2Changing(string value);
    partial void OnAdMutiTxt2Changed();
    partial void OnAdMutiTxt3Changing(string value);
    partial void OnAdMutiTxt3Changed();
    partial void OnAdMutiTxt4Changing(string value);
    partial void OnAdMutiTxt4Changed();
    partial void OnInnerBgChanging(string value);
    partial void OnInnerBgChanged();
    partial void OnOuterBgChanging(string value);
    partial void OnOuterBgChanged();
    partial void OnNavBgChanging(string value);
    partial void OnNavBgChanged();
    partial void OnNavBgNormalChanging(string value);
    partial void OnNavBgNormalChanged();
    partial void OnNavNormalCssChanging(string value);
    partial void OnNavNormalCssChanged();
    partial void OnNavBgSelChanging(string value);
    partial void OnNavBgSelChanged();
    partial void OnNavSelCssChanging(string value);
    partial void OnNavSelCssChanged();
    #endregion
		
		public DS_ShopTheme()
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
		
		[Column(Storage="_ThemeName", DbType="NVarChar(50) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string ThemeName
		{
			get
			{
				return this._ThemeName;
			}
			set
			{
				if ((this._ThemeName != value))
				{
					this.OnThemeNameChanging(value);
					this.SendPropertyChanging();
					this._ThemeName = value;
					this.SendPropertyChanged("ThemeName");
					this.OnThemeNameChanged();
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
		
		[Column(Storage="_SignImg", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
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
		
		[Column(Storage="_SignBgColor", DbType="NVarChar(20)", UpdateCheck=UpdateCheck.Never)]
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
		
		[Column(Storage="_ComNameShow", DbType="Bit", UpdateCheck=UpdateCheck.Never)]
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
		
		[Column(Storage="_ComNameCss", DbType="NVarChar(100)", UpdateCheck=UpdateCheck.Never)]
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
		
		[Column(Storage="_Thume", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string Thume
		{
			get
			{
				return this._Thume;
			}
			set
			{
				if ((this._Thume != value))
				{
					this.OnThumeChanging(value);
					this.SendPropertyChanging();
					this._Thume = value;
					this.SendPropertyChanged("Thume");
					this.OnThumeChanged();
				}
			}
		}
		
		[Column(Storage="_AdSigleImg", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string AdSigleImg
		{
			get
			{
				return this._AdSigleImg;
			}
			set
			{
				if ((this._AdSigleImg != value))
				{
					this.OnAdSigleImgChanging(value);
					this.SendPropertyChanging();
					this._AdSigleImg = value;
					this.SendPropertyChanged("AdSigleImg");
					this.OnAdSigleImgChanged();
				}
			}
		}
		
		[Column(Storage="_AdSigleTxt", DbType="NVarChar(500)", UpdateCheck=UpdateCheck.Never)]
		public string AdSigleTxt
		{
			get
			{
				return this._AdSigleTxt;
			}
			set
			{
				if ((this._AdSigleTxt != value))
				{
					this.OnAdSigleTxtChanging(value);
					this.SendPropertyChanging();
					this._AdSigleTxt = value;
					this.SendPropertyChanged("AdSigleTxt");
					this.OnAdSigleTxtChanged();
				}
			}
		}
		
		[Column(Storage="_AdMutiImg1", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string AdMutiImg1
		{
			get
			{
				return this._AdMutiImg1;
			}
			set
			{
				if ((this._AdMutiImg1 != value))
				{
					this.OnAdMutiImg1Changing(value);
					this.SendPropertyChanging();
					this._AdMutiImg1 = value;
					this.SendPropertyChanged("AdMutiImg1");
					this.OnAdMutiImg1Changed();
				}
			}
		}
		
		[Column(Storage="_AdMutiImg2", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string AdMutiImg2
		{
			get
			{
				return this._AdMutiImg2;
			}
			set
			{
				if ((this._AdMutiImg2 != value))
				{
					this.OnAdMutiImg2Changing(value);
					this.SendPropertyChanging();
					this._AdMutiImg2 = value;
					this.SendPropertyChanged("AdMutiImg2");
					this.OnAdMutiImg2Changed();
				}
			}
		}
		
		[Column(Storage="_AdMutiImg3", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string AdMutiImg3
		{
			get
			{
				return this._AdMutiImg3;
			}
			set
			{
				if ((this._AdMutiImg3 != value))
				{
					this.OnAdMutiImg3Changing(value);
					this.SendPropertyChanging();
					this._AdMutiImg3 = value;
					this.SendPropertyChanged("AdMutiImg3");
					this.OnAdMutiImg3Changed();
				}
			}
		}
		
		[Column(Storage="_AdMutiImg4", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string AdMutiImg4
		{
			get
			{
				return this._AdMutiImg4;
			}
			set
			{
				if ((this._AdMutiImg4 != value))
				{
					this.OnAdMutiImg4Changing(value);
					this.SendPropertyChanging();
					this._AdMutiImg4 = value;
					this.SendPropertyChanged("AdMutiImg4");
					this.OnAdMutiImg4Changed();
				}
			}
		}
		
		[Column(Storage="_AdMutiTxt1", DbType="NVarChar(500)", UpdateCheck=UpdateCheck.Never)]
		public string AdMutiTxt1
		{
			get
			{
				return this._AdMutiTxt1;
			}
			set
			{
				if ((this._AdMutiTxt1 != value))
				{
					this.OnAdMutiTxt1Changing(value);
					this.SendPropertyChanging();
					this._AdMutiTxt1 = value;
					this.SendPropertyChanged("AdMutiTxt1");
					this.OnAdMutiTxt1Changed();
				}
			}
		}
		
		[Column(Storage="_AdMutiTxt2", DbType="NVarChar(500)", UpdateCheck=UpdateCheck.Never)]
		public string AdMutiTxt2
		{
			get
			{
				return this._AdMutiTxt2;
			}
			set
			{
				if ((this._AdMutiTxt2 != value))
				{
					this.OnAdMutiTxt2Changing(value);
					this.SendPropertyChanging();
					this._AdMutiTxt2 = value;
					this.SendPropertyChanged("AdMutiTxt2");
					this.OnAdMutiTxt2Changed();
				}
			}
		}
		
		[Column(Storage="_AdMutiTxt3", DbType="NVarChar(500)", UpdateCheck=UpdateCheck.Never)]
		public string AdMutiTxt3
		{
			get
			{
				return this._AdMutiTxt3;
			}
			set
			{
				if ((this._AdMutiTxt3 != value))
				{
					this.OnAdMutiTxt3Changing(value);
					this.SendPropertyChanging();
					this._AdMutiTxt3 = value;
					this.SendPropertyChanged("AdMutiTxt3");
					this.OnAdMutiTxt3Changed();
				}
			}
		}
		
		[Column(Storage="_AdMutiTxt4", DbType="NVarChar(500)", UpdateCheck=UpdateCheck.Never)]
		public string AdMutiTxt4
		{
			get
			{
				return this._AdMutiTxt4;
			}
			set
			{
				if ((this._AdMutiTxt4 != value))
				{
					this.OnAdMutiTxt4Changing(value);
					this.SendPropertyChanging();
					this._AdMutiTxt4 = value;
					this.SendPropertyChanged("AdMutiTxt4");
					this.OnAdMutiTxt4Changed();
				}
			}
		}
		
		[Column(Storage="_InnerBg", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string InnerBg
		{
			get
			{
				return this._InnerBg;
			}
			set
			{
				if ((this._InnerBg != value))
				{
					this.OnInnerBgChanging(value);
					this.SendPropertyChanging();
					this._InnerBg = value;
					this.SendPropertyChanged("InnerBg");
					this.OnInnerBgChanged();
				}
			}
		}
		
		[Column(Storage="_OuterBg", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string OuterBg
		{
			get
			{
				return this._OuterBg;
			}
			set
			{
				if ((this._OuterBg != value))
				{
					this.OnOuterBgChanging(value);
					this.SendPropertyChanging();
					this._OuterBg = value;
					this.SendPropertyChanged("OuterBg");
					this.OnOuterBgChanged();
				}
			}
		}
		
		[Column(Storage="_NavBg", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string NavBg
		{
			get
			{
				return this._NavBg;
			}
			set
			{
				if ((this._NavBg != value))
				{
					this.OnNavBgChanging(value);
					this.SendPropertyChanging();
					this._NavBg = value;
					this.SendPropertyChanged("NavBg");
					this.OnNavBgChanged();
				}
			}
		}
		
		[Column(Storage="_NavBgNormal", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string NavBgNormal
		{
			get
			{
				return this._NavBgNormal;
			}
			set
			{
				if ((this._NavBgNormal != value))
				{
					this.OnNavBgNormalChanging(value);
					this.SendPropertyChanging();
					this._NavBgNormal = value;
					this.SendPropertyChanged("NavBgNormal");
					this.OnNavBgNormalChanged();
				}
			}
		}
		
		[Column(Storage="_NavNormalCss", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string NavNormalCss
		{
			get
			{
				return this._NavNormalCss;
			}
			set
			{
				if ((this._NavNormalCss != value))
				{
					this.OnNavNormalCssChanging(value);
					this.SendPropertyChanging();
					this._NavNormalCss = value;
					this.SendPropertyChanged("NavNormalCss");
					this.OnNavNormalCssChanged();
				}
			}
		}
		
		[Column(Storage="_NavBgSel", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string NavBgSel
		{
			get
			{
				return this._NavBgSel;
			}
			set
			{
				if ((this._NavBgSel != value))
				{
					this.OnNavBgSelChanging(value);
					this.SendPropertyChanging();
					this._NavBgSel = value;
					this.SendPropertyChanged("NavBgSel");
					this.OnNavBgSelChanged();
				}
			}
		}
		
		[Column(Storage="_NavSelCss", DbType="NVarChar(150)", UpdateCheck=UpdateCheck.Never)]
		public string NavSelCss
		{
			get
			{
				return this._NavSelCss;
			}
			set
			{
				if ((this._NavSelCss != value))
				{
					this.OnNavSelCssChanging(value);
					this.SendPropertyChanging();
					this._NavSelCss = value;
					this.SendPropertyChanged("NavSelCss");
					this.OnNavSelCssChanged();
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
