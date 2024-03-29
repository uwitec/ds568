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

namespace Com.DianShi.Model.News
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
	public partial class DS_ComNewsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDS_ComNews(DS_ComNews instance);
    partial void UpdateDS_ComNews(DS_ComNews instance);
    partial void DeleteDS_ComNews(DS_ComNews instance);
    #endregion
		
		public DS_ComNewsDataContext() : 
				base(global::Com.DianShi.Model.News.Properties.Settings.Default.DianShiConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ComNewsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ComNewsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ComNewsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ComNewsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DS_ComNews> DS_ComNews
		{
			get
			{
				return this.GetTable<DS_ComNews>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DS_ComNews")]
	public partial class DS_ComNews : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Title;
		
		private string _Content;
		
		private int _MemberID;
		
		private int _ParentID;
		
		private System.DateTime _CreateDate;
		
		private System.DateTime _UpdateDate;
		
		private int _Hits;
		
		private int _Coment;
		
		private string _Ip;
		
		private int _Px;
		
		private string _Reply;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnContentChanging(string value);
    partial void OnContentChanged();
    partial void OnMemberIDChanging(int value);
    partial void OnMemberIDChanged();
    partial void OnParentIDChanging(int value);
    partial void OnParentIDChanged();
    partial void OnCreateDateChanging(System.DateTime value);
    partial void OnCreateDateChanged();
    partial void OnUpdateDateChanging(System.DateTime value);
    partial void OnUpdateDateChanged();
    partial void OnHitsChanging(int value);
    partial void OnHitsChanged();
    partial void OnComentChanging(int value);
    partial void OnComentChanged();
    partial void OnIpChanging(string value);
    partial void OnIpChanged();
    partial void OnPxChanging(int value);
    partial void OnPxChanged();
    partial void OnReplyChanging(string value);
    partial void OnReplyChanged();
    #endregion
		
		public DS_ComNews()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(150) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Content", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				if ((this._Content != value))
				{
					this.OnContentChanging(value);
					this.SendPropertyChanging();
					this._Content = value;
					this.SendPropertyChanged("Content");
					this.OnContentChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentID", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int ParentID
		{
			get
			{
				return this._ParentID;
			}
			set
			{
				if ((this._ParentID != value))
				{
					this.OnParentIDChanging(value);
					this.SendPropertyChanging();
					this._ParentID = value;
					this.SendPropertyChanged("ParentID");
					this.OnParentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdateDate", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.DateTime UpdateDate
		{
			get
			{
				return this._UpdateDate;
			}
			set
			{
				if ((this._UpdateDate != value))
				{
					this.OnUpdateDateChanging(value);
					this.SendPropertyChanging();
					this._UpdateDate = value;
					this.SendPropertyChanged("UpdateDate");
					this.OnUpdateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hits", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int Hits
		{
			get
			{
				return this._Hits;
			}
			set
			{
				if ((this._Hits != value))
				{
					this.OnHitsChanging(value);
					this.SendPropertyChanging();
					this._Hits = value;
					this.SendPropertyChanged("Hits");
					this.OnHitsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Coment", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int Coment
		{
			get
			{
				return this._Coment;
			}
			set
			{
				if ((this._Coment != value))
				{
					this.OnComentChanging(value);
					this.SendPropertyChanging();
					this._Coment = value;
					this.SendPropertyChanged("Coment");
					this.OnComentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ip", DbType="NVarChar(50)", UpdateCheck=UpdateCheck.Never)]
		public string Ip
		{
			get
			{
				return this._Ip;
			}
			set
			{
				if ((this._Ip != value))
				{
					this.OnIpChanging(value);
					this.SendPropertyChanging();
					this._Ip = value;
					this.SendPropertyChanged("Ip");
					this.OnIpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Px", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int Px
		{
			get
			{
				return this._Px;
			}
			set
			{
				if ((this._Px != value))
				{
					this.OnPxChanging(value);
					this.SendPropertyChanging();
					this._Px = value;
					this.SendPropertyChanged("Px");
					this.OnPxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Reply", DbType="NVarChar(500)", UpdateCheck=UpdateCheck.Never)]
		public string Reply
		{
			get
			{
				return this._Reply;
			}
			set
			{
				if ((this._Reply != value))
				{
					this.OnReplyChanging(value);
					this.SendPropertyChanging();
					this._Reply = value;
					this.SendPropertyChanged("Reply");
					this.OnReplyChanged();
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
