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
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertRequests(Requests instance);
    partial void UpdateRequests(Requests instance);
    partial void DeleteRequests(Requests instance);
    partial void InsertServices(Services instance);
    partial void UpdateServices(Services instance);
    partial void DeleteServices(Services instance);
    partial void InsertOperators(Operators instance);
    partial void UpdateOperators(Operators instance);
    partial void DeleteOperators(Operators instance);
    partial void InsertMasters(Masters instance);
    partial void UpdateMasters(Masters instance);
    partial void DeleteMasters(Masters instance);
    partial void InsertClients(Clients instance);
    partial void UpdateClients(Clients instance);
    partial void DeleteClients(Clients instance);
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
		
		public System.Data.Linq.Table<Requests> Requests
		{
			get
			{
				return this.GetTable<Requests>();
			}
		}
		
		public System.Data.Linq.Table<Services> Services
		{
			get
			{
				return this.GetTable<Services>();
			}
		}
		
		public System.Data.Linq.Table<Operators> Operators
		{
			get
			{
				return this.GetTable<Operators>();
			}
		}
		
		public System.Data.Linq.Table<Masters> Masters
		{
			get
			{
				return this.GetTable<Masters>();
			}
		}
		
		public System.Data.Linq.Table<Clients> Clients
		{
			get
			{
				return this.GetTable<Clients>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RequestTable")]
	public partial class Requests : INotifyPropertyChanging, INotifyPropertyChanged
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
		
		private int _MasterId;
		
		private int _ServiceId;
		
		private EntityRef<Services> _Services;
		
		private EntityRef<Operators> _Operators;
		
		private EntityRef<Masters> _Masters;
		
		private EntityRef<Clients> _Clients;
		
    #region Extensibility Method Definitions
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
    partial void OnMasterIdChanging(int value);
    partial void OnMasterIdChanged();
    partial void OnServiceIdChanging(int value);
    partial void OnServiceIdChanged();
    #endregion
		
		public Requests()
		{
			this._Services = default(EntityRef<Services>);
			this._Operators = default(EntityRef<Operators>);
			this._Masters = default(EntityRef<Masters>);
			this._Clients = default(EntityRef<Clients>);
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
					if (this._Clients.HasLoadedOrAssignedValue)
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
					if (this._Operators.HasLoadedOrAssignedValue)
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MasterId", DbType="Int NOT NULL")]
		public int MasterId
		{
			get
			{
				return this._MasterId;
			}
			set
			{
				if ((this._MasterId != value))
				{
					if (this._Masters.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMasterIdChanging(value);
					this.SendPropertyChanging();
					this._MasterId = value;
					this.SendPropertyChanged("MasterId");
					this.OnMasterIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceId", DbType="Int NOT NULL")]
		public int ServiceId
		{
			get
			{
				return this._ServiceId;
			}
			set
			{
				if ((this._ServiceId != value))
				{
					if (this._Services.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnServiceIdChanging(value);
					this.SendPropertyChanging();
					this._ServiceId = value;
					this.SendPropertyChanged("ServiceId");
					this.OnServiceIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ServiceTable_RequestTable", Storage="_Services", ThisKey="ServiceId", OtherKey="Id", IsForeignKey=true)]
		public Services Services
		{
			get
			{
				return this._Services.Entity;
			}
			set
			{
				Services previousValue = this._Services.Entity;
				if (((previousValue != value) 
							|| (this._Services.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Services.Entity = null;
						previousValue.Requests.Remove(this);
					}
					this._Services.Entity = value;
					if ((value != null))
					{
						value.Requests.Add(this);
						this._ServiceId = value.Id;
					}
					else
					{
						this._ServiceId = default(int);
					}
					this.SendPropertyChanged("Services");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OperatorTable_RequestTable", Storage="_Operators", ThisKey="OperatorId", OtherKey="Id", IsForeignKey=true)]
		public Operators Operators
		{
			get
			{
				return this._Operators.Entity;
			}
			set
			{
				Operators previousValue = this._Operators.Entity;
				if (((previousValue != value) 
							|| (this._Operators.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Operators.Entity = null;
						previousValue.Requests.Remove(this);
					}
					this._Operators.Entity = value;
					if ((value != null))
					{
						value.Requests.Add(this);
						this._OperatorId = value.Id;
					}
					else
					{
						this._OperatorId = default(int);
					}
					this.SendPropertyChanged("Operators");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MasterTable_RequestTable", Storage="_Masters", ThisKey="MasterId", OtherKey="Id", IsForeignKey=true)]
		public Masters Masters
		{
			get
			{
				return this._Masters.Entity;
			}
			set
			{
				Masters previousValue = this._Masters.Entity;
				if (((previousValue != value) 
							|| (this._Masters.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Masters.Entity = null;
						previousValue.Requests.Remove(this);
					}
					this._Masters.Entity = value;
					if ((value != null))
					{
						value.Requests.Add(this);
						this._MasterId = value.Id;
					}
					else
					{
						this._MasterId = default(int);
					}
					this.SendPropertyChanged("Masters");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ClientTable_RequestTable", Storage="_Clients", ThisKey="ClientId", OtherKey="Id", IsForeignKey=true)]
		public Clients Clients
		{
			get
			{
				return this._Clients.Entity;
			}
			set
			{
				Clients previousValue = this._Clients.Entity;
				if (((previousValue != value) 
							|| (this._Clients.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Clients.Entity = null;
						previousValue.Requests.Remove(this);
					}
					this._Clients.Entity = value;
					if ((value != null))
					{
						value.Requests.Add(this);
						this._ClientId = value.Id;
					}
					else
					{
						this._ClientId = default(int);
					}
					this.SendPropertyChanged("Clients");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ServiceTable")]
	public partial class Services : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Requests> _Requests;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Services()
		{
			this._Requests = new EntitySet<Requests>(new Action<Requests>(this.attach_Requests), new Action<Requests>(this.detach_Requests));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ServiceTable_RequestTable", Storage="_Requests", ThisKey="Id", OtherKey="ServiceId")]
		public EntitySet<Requests> Requests
		{
			get
			{
				return this._Requests;
			}
			set
			{
				this._Requests.Assign(value);
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
		
		private void attach_Requests(Requests entity)
		{
			this.SendPropertyChanging();
			entity.Services = this;
		}
		
		private void detach_Requests(Requests entity)
		{
			this.SendPropertyChanging();
			entity.Services = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OperatorTable")]
	public partial class Operators : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FullName;
		
		private EntitySet<Requests> _Requests;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    #endregion
		
		public Operators()
		{
			this._Requests = new EntitySet<Requests>(new Action<Requests>(this.attach_Requests), new Action<Requests>(this.detach_Requests));
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OperatorTable_RequestTable", Storage="_Requests", ThisKey="Id", OtherKey="OperatorId")]
		public EntitySet<Requests> Requests
		{
			get
			{
				return this._Requests;
			}
			set
			{
				this._Requests.Assign(value);
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
		
		private void attach_Requests(Requests entity)
		{
			this.SendPropertyChanging();
			entity.Operators = this;
		}
		
		private void detach_Requests(Requests entity)
		{
			this.SendPropertyChanging();
			entity.Operators = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MasterTable")]
	public partial class Masters : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FullName;
		
		private EntitySet<Requests> _Requests;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    #endregion
		
		public Masters()
		{
			this._Requests = new EntitySet<Requests>(new Action<Requests>(this.attach_Requests), new Action<Requests>(this.detach_Requests));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MasterTable_RequestTable", Storage="_Requests", ThisKey="Id", OtherKey="MasterId")]
		public EntitySet<Requests> Requests
		{
			get
			{
				return this._Requests;
			}
			set
			{
				this._Requests.Assign(value);
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
		
		private void attach_Requests(Requests entity)
		{
			this.SendPropertyChanging();
			entity.Masters = this;
		}
		
		private void detach_Requests(Requests entity)
		{
			this.SendPropertyChanging();
			entity.Masters = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ClientTable")]
	public partial class Clients : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FullName;
		
		private EntitySet<Requests> _Requests;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    #endregion
		
		public Clients()
		{
			this._Requests = new EntitySet<Requests>(new Action<Requests>(this.attach_Requests), new Action<Requests>(this.detach_Requests));
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ClientTable_RequestTable", Storage="_Requests", ThisKey="Id", OtherKey="ClientId")]
		public EntitySet<Requests> Requests
		{
			get
			{
				return this._Requests;
			}
			set
			{
				this._Requests.Assign(value);
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
		
		private void attach_Requests(Requests entity)
		{
			this.SendPropertyChanging();
			entity.Clients = this;
		}
		
		private void detach_Requests(Requests entity)
		{
			this.SendPropertyChanging();
			entity.Clients = null;
		}
	}
}
#pragma warning restore 1591
