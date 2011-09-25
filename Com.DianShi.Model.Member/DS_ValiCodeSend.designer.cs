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
	public partial class DS_ValiCodeSendDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDS_ValiCodeSend(DS_ValiCodeSend instance);
    partial void UpdateDS_ValiCodeSend(DS_ValiCodeSend instance);
    partial void DeleteDS_ValiCodeSend(DS_ValiCodeSend instance);
    #endregion
		
		public DS_ValiCodeSendDataContext() : 
				base(global::Com.DianShi.Model.Member.Properties.Settings.Default.DianShiConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ValiCodeSendDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ValiCodeSendDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ValiCodeSendDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DS_ValiCodeSendDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DS_ValiCodeSend> DS_ValiCodeSend
		{
			get
			{
				return this.GetTable<DS_ValiCodeSend>();
			}
		}
	}
	
	[Table(Name="dbo.DS_ValiCodeSend")]
	public partial class DS_ValiCodeSend : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _MemberID;
		
		private byte _Frequency;
		
		private System.DateTime _LastTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMemberIDChanging(int value);
    partial void OnMemberIDChanged();
    partial void OnFrequencyChanging(byte value);
    partial void OnFrequencyChanged();
    partial void OnLastTimeChanging(System.DateTime value);
    partial void OnLastTimeChanged();
    #endregion
		
		public DS_ValiCodeSend()
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
		
		[Column(Storage="_Frequency", DbType="TinyInt NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public byte Frequency
		{
			get
			{
				return this._Frequency;
			}
			set
			{
				if ((this._Frequency != value))
				{
					this.OnFrequencyChanging(value);
					this.SendPropertyChanging();
					this._Frequency = value;
					this.SendPropertyChanged("Frequency");
					this.OnFrequencyChanged();
				}
			}
		}
		
		[Column(Storage="_LastTime", DbType="SmallDateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.DateTime LastTime
		{
			get
			{
				return this._LastTime;
			}
			set
			{
				if ((this._LastTime != value))
				{
					this.OnLastTimeChanging(value);
					this.SendPropertyChanging();
					this._LastTime = value;
					this.SendPropertyChanged("LastTime");
					this.OnLastTimeChanged();
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
