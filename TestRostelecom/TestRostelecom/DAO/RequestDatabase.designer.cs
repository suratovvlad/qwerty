﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestRostelecom.DAO
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Test")]
	public partial class RequestDatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertRequest(Request instance);
    partial void UpdateRequest(Request instance);
    partial void DeleteRequest(Request instance);
    partial void InsertOperator(Operator instance);
    partial void UpdateOperator(Operator instance);
    partial void DeleteOperator(Operator instance);
    partial void InsertClient(Client instance);
    partial void UpdateClient(Client instance);
    partial void DeleteClient(Client instance);
    #endregion
		
		public RequestDatabaseDataContext() : 
				base(global::TestRostelecom.Properties.Settings.Default.TestConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public RequestDatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RequestDatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RequestDatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RequestDatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Request> Request
		{
			get
			{
				return this.GetTable<Request>();
			}
		}
		
		public System.Data.Linq.Table<Operator> Operator
		{
			get
			{
				return this.GetTable<Operator>();
			}
		}
		
		public System.Data.Linq.Table<Client> Client
		{
			get
			{
				return this.GetTable<Client>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RequestTable")]
	public partial class Request : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.DateTime _RequestDate;
		
		private string _Address;
		
		private string _Comment;
		
		private System.Nullable<System.DateTime> _CloseDate;
		
		private System.Nullable<System.DateTime> _DateOfDeparture;
		
		private int _ClientId;
		
		private int _OperatorId;
		
		private EntityRef<Operator> _OperatorTable;
		
		private EntityRef<Client> _ClientTable;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnRequestDateChanging(System.DateTime value);
    partial void OnRequestDateChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCommentChanging(string value);
    partial void OnCommentChanged();
    partial void OnCloseDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCloseDateChanged();
    partial void OnDateOfDepartureChanging(System.Nullable<System.DateTime> value);
    partial void OnDateOfDepartureChanged();
    partial void OnClientIdChanging(int value);
    partial void OnClientIdChanged();
    partial void OnOperatorIdChanging(int value);
    partial void OnOperatorIdChanged();
    #endregion
		
		public Request()
		{
			this._OperatorTable = default(EntityRef<Operator>);
			this._ClientTable = default(EntityRef<Client>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RequestDate", DbType="DateTime NOT NULL")]
		public System.DateTime RequestDate
		{
			get
			{
				return this._RequestDate;
			}
			set
			{
				if ((this._RequestDate != value))
				{
					this.OnRequestDateChanging(value);
					this.SendPropertyChanging();
					this._RequestDate = value;
					this.SendPropertyChanged("RequestDate");
					this.OnRequestDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comment", DbType="NVarChar(MAX)")]
		public string Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				if ((this._Comment != value))
				{
					this.OnCommentChanging(value);
					this.SendPropertyChanging();
					this._Comment = value;
					this.SendPropertyChanged("Comment");
					this.OnCommentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CloseDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> CloseDate
		{
			get
			{
				return this._CloseDate;
			}
			set
			{
				if ((this._CloseDate != value))
				{
					this.OnCloseDateChanging(value);
					this.SendPropertyChanging();
					this._CloseDate = value;
					this.SendPropertyChanged("CloseDate");
					this.OnCloseDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfDeparture", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateOfDeparture
		{
			get
			{
				return this._DateOfDeparture;
			}
			set
			{
				if ((this._DateOfDeparture != value))
				{
					this.OnDateOfDepartureChanging(value);
					this.SendPropertyChanging();
					this._DateOfDeparture = value;
					this.SendPropertyChanged("DateOfDeparture");
					this.OnDateOfDepartureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientId", DbType="Int NOT NULL")]
		public int ClientId
		{
			get
			{
				return this._ClientId;
			}
			set
			{
				if ((this._ClientId != value))
				{
					if (this._ClientTable.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnClientIdChanging(value);
					this.SendPropertyChanging();
					this._ClientId = value;
					this.SendPropertyChanged("ClientId");
					this.OnClientIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OperatorId", DbType="Int NOT NULL")]
		public int OperatorId
		{
			get
			{
				return this._OperatorId;
			}
			set
			{
				if ((this._OperatorId != value))
				{
					if (this._OperatorTable.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOperatorIdChanging(value);
					this.SendPropertyChanging();
					this._OperatorId = value;
					this.SendPropertyChanged("OperatorId");
					this.OnOperatorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OperatorTable_RequestTable", Storage="_OperatorTable", ThisKey="OperatorId", OtherKey="Id", IsForeignKey=true)]
		public Operator Operator
		{
			get
			{
				return this._OperatorTable.Entity;
			}
			set
			{
				Operator previousValue = this._OperatorTable.Entity;
				if (((previousValue != value) 
							|| (this._OperatorTable.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._OperatorTable.Entity = null;
						previousValue.Request.Remove(this);
					}
					this._OperatorTable.Entity = value;
					if ((value != null))
					{
						value.Request.Add(this);
						this._OperatorId = value.Id;
					}
					else
					{
						this._OperatorId = default(int);
					}
					this.SendPropertyChanged("Operator");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ClientTable_RequestTable", Storage="_ClientTable", ThisKey="ClientId", OtherKey="Id", IsForeignKey=true)]
		public Client Client
		{
			get
			{
				return this._ClientTable.Entity;
			}
			set
			{
				Client previousValue = this._ClientTable.Entity;
				if (((previousValue != value) 
							|| (this._ClientTable.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ClientTable.Entity = null;
						previousValue.Request.Remove(this);
					}
					this._ClientTable.Entity = value;
					if ((value != null))
					{
						value.Request.Add(this);
						this._ClientId = value.Id;
					}
					else
					{
						this._ClientId = default(int);
					}
					this.SendPropertyChanged("Client");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OperatorTable")]
	public partial class Operator : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FullName;
		
		private EntitySet<Request> _RequestTable;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    #endregion
		
		public Operator()
		{
			this._RequestTable = new EntitySet<Request>(new Action<Request>(this.attach_RequestTable), new Action<Request>(this.detach_RequestTable));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="NVarChar(MAX)")]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this.OnFullNameChanging(value);
					this.SendPropertyChanging();
					this._FullName = value;
					this.SendPropertyChanged("FullName");
					this.OnFullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OperatorTable_RequestTable", Storage="_RequestTable", ThisKey="Id", OtherKey="OperatorId")]
		public EntitySet<Request> Request
		{
			get
			{
				return this._RequestTable;
			}
			set
			{
				this._RequestTable.Assign(value);
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
		
		private void attach_RequestTable(Request entity)
		{
			this.SendPropertyChanging();
			entity.Operator = this;
		}
		
		private void detach_RequestTable(Request entity)
		{
			this.SendPropertyChanging();
			entity.Operator = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ClientTable")]
	public partial class Client : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FullName;
		
		private EntitySet<Request> _RequestTable;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    #endregion
		
		public Client()
		{
			this._RequestTable = new EntitySet<Request>(new Action<Request>(this.attach_RequestTable), new Action<Request>(this.detach_RequestTable));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this.OnFullNameChanging(value);
					this.SendPropertyChanging();
					this._FullName = value;
					this.SendPropertyChanged("FullName");
					this.OnFullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ClientTable_RequestTable", Storage="_RequestTable", ThisKey="Id", OtherKey="ClientId")]
		public EntitySet<Request> Request
		{
			get
			{
				return this._RequestTable;
			}
			set
			{
				this._RequestTable.Assign(value);
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
		
		private void attach_RequestTable(Request entity)
		{
			this.SendPropertyChanging();
			entity.Client = this;
		}
		
		private void detach_RequestTable(Request entity)
		{
			this.SendPropertyChanging();
			entity.Client = null;
		}
	}
}
#pragma warning restore 1591