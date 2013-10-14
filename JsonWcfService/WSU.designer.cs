﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JsonWcfService
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WSU")]
	public partial class WSUDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDealer(Dealer instance);
    partial void UpdateDealer(Dealer instance);
    partial void DeleteDealer(Dealer instance);
    partial void InsertKPI(KPI instance);
    partial void UpdateKPI(KPI instance);
    partial void DeleteKPI(KPI instance);
    partial void InsertDealerKPIValue(DealerKPIValue instance);
    partial void UpdateDealerKPIValue(DealerKPIValue instance);
    partial void DeleteDealerKPIValue(DealerKPIValue instance);
    #endregion
		
		public WSUDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WSUConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WSUDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WSUDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WSUDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WSUDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Dealer> Dealers
		{
			get
			{
				return this.GetTable<Dealer>();
			}
		}
		
		public System.Data.Linq.Table<KPI> KPIs
		{
			get
			{
				return this.GetTable<KPI>();
			}
		}
		
		public System.Data.Linq.Table<DealerKPIValue> DealerKPIValues
		{
			get
			{
				return this.GetTable<DealerKPIValue>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Profile> Profiles
		{
			get
			{
				return this.GetTable<Profile>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetKPIValues")]
		public ISingleResult<GetKPIValuesResult> GetKPIValues([global::System.Data.Linq.Mapping.ParameterAttribute(Name="DealerId", DbType="Int")] System.Nullable<int> dealerId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="KpiId", DbType="Int")] System.Nullable<int> kpiId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), dealerId, kpiId);
			return ((ISingleResult<GetKPIValuesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetKPIName")]
		public ISingleResult<GetKPINameResult> GetKPIName([global::System.Data.Linq.Mapping.ParameterAttribute(Name="KpiId", DbType="Int")] System.Nullable<int> kpiId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), kpiId);
			return ((ISingleResult<GetKPINameResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetDealershipKPIs")]
		public ISingleResult<GetDealershipKPIsResult> GetDealershipKPIs([global::System.Data.Linq.Mapping.ParameterAttribute(Name="DealerId", DbType="Int")] System.Nullable<int> dealerId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), dealerId);
			return ((ISingleResult<GetDealershipKPIsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetUserDealerships")]
		public ISingleResult<GetUserDealershipsResult> GetUserDealerships([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserID", DbType="Int")] System.Nullable<int> userID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userID);
			return ((ISingleResult<GetUserDealershipsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ValidateUser")]
		public ISingleResult<ValidateUserResult> ValidateUser([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Username", DbType="NChar(10)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NChar(10)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password);
			return ((ISingleResult<ValidateUserResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddActionPlanKPI")]
		public int AddActionPlanKPI([global::System.Data.Linq.Mapping.ParameterAttribute(Name="APID", DbType="Int")] System.Nullable<int> aPID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="KPID", DbType="Int")] System.Nullable<int> kPID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), aPID, kPID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ModifyActionPlan")]
		public int ModifyActionPlan([global::System.Data.Linq.Mapping.ParameterAttribute(Name="APID", DbType="Int")] System.Nullable<int> aPID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Comment", DbType="NChar(512)")] string comment, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Reaction", DbType="Int")] System.Nullable<int> reaction)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), aPID, comment, reaction);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ModifyActionPlanKPI")]
		public int ModifyActionPlanKPI([global::System.Data.Linq.Mapping.ParameterAttribute(Name="APID", DbType="Int")] System.Nullable<int> aPID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="KPID", DbType="Int")] System.Nullable<int> kPID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Suggest", DbType="NChar(512)")] string suggest, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Action", DbType="NChar(512)")] string action, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Result", DbType="NChar(512)")] string result, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Comment", DbType="NChar(512)")] string comment, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Reaction", DbType="Int")] System.Nullable<int> reaction)
		{
			IExecuteResult result1 = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), aPID, kPID, suggest, action, result, comment, reaction);
			return ((int)(result1.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetMostRecentKPIValues")]
		public ISingleResult<GetMostRecentKPIValuesResult> GetMostRecentKPIValues([global::System.Data.Linq.Mapping.ParameterAttribute(Name="DealerId", DbType="Int")] System.Nullable<int> dealerId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="KpiId", DbType="Int")] System.Nullable<int> kpiId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), dealerId, kpiId);
			return ((ISingleResult<GetMostRecentKPIValuesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetActionPlanKPIs")]
		public ISingleResult<GetActionPlanKPIsResult> GetActionPlanKPIs([global::System.Data.Linq.Mapping.ParameterAttribute(Name="APID", DbType="Int")] System.Nullable<int> aPID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), aPID);
			return ((ISingleResult<GetActionPlanKPIsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetActionPlans")]
		public ISingleResult<GetActionPlansResult> GetActionPlans([global::System.Data.Linq.Mapping.ParameterAttribute(Name="DealerID", DbType="Int")] System.Nullable<int> dealerID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), dealerID);
			return ((ISingleResult<GetActionPlansResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddActionPlan")]
		public ISingleResult<AddActionPlanResult> AddActionPlan([global::System.Data.Linq.Mapping.ParameterAttribute(Name="DealerID", DbType="Int")] System.Nullable<int> dealerID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), dealerID);
			return ((ISingleResult<AddActionPlanResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Dealer")]
	public partial class Dealer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DealerID;
		
		private string _Lat;
		
		private string _Long;
		
		private System.Nullable<int> _AreaID;
		
		private EntitySet<DealerKPIValue> _DealerKPIValues;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDealerIDChanging(int value);
    partial void OnDealerIDChanged();
    partial void OnLatChanging(string value);
    partial void OnLatChanged();
    partial void OnLongChanging(string value);
    partial void OnLongChanged();
    partial void OnAreaIDChanging(System.Nullable<int> value);
    partial void OnAreaIDChanged();
    #endregion
		
		public Dealer()
		{
			this._DealerKPIValues = new EntitySet<DealerKPIValue>(new Action<DealerKPIValue>(this.attach_DealerKPIValues), new Action<DealerKPIValue>(this.detach_DealerKPIValues));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DealerID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DealerID
		{
			get
			{
				return this._DealerID;
			}
			set
			{
				if ((this._DealerID != value))
				{
					this.OnDealerIDChanging(value);
					this.SendPropertyChanging();
					this._DealerID = value;
					this.SendPropertyChanged("DealerID");
					this.OnDealerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lat", DbType="NChar(10)")]
		public string Lat
		{
			get
			{
				return this._Lat;
			}
			set
			{
				if ((this._Lat != value))
				{
					this.OnLatChanging(value);
					this.SendPropertyChanging();
					this._Lat = value;
					this.SendPropertyChanged("Lat");
					this.OnLatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Long", DbType="NChar(10)")]
		public string Long
		{
			get
			{
				return this._Long;
			}
			set
			{
				if ((this._Long != value))
				{
					this.OnLongChanging(value);
					this.SendPropertyChanging();
					this._Long = value;
					this.SendPropertyChanged("Long");
					this.OnLongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AreaID", DbType="Int")]
		public System.Nullable<int> AreaID
		{
			get
			{
				return this._AreaID;
			}
			set
			{
				if ((this._AreaID != value))
				{
					this.OnAreaIDChanging(value);
					this.SendPropertyChanging();
					this._AreaID = value;
					this.SendPropertyChanged("AreaID");
					this.OnAreaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dealer_DealerKPIValue", Storage="_DealerKPIValues", ThisKey="DealerID", OtherKey="DealerID")]
		public EntitySet<DealerKPIValue> DealerKPIValues
		{
			get
			{
				return this._DealerKPIValues;
			}
			set
			{
				this._DealerKPIValues.Assign(value);
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
		
		private void attach_DealerKPIValues(DealerKPIValue entity)
		{
			this.SendPropertyChanging();
			entity.Dealer = this;
		}
		
		private void detach_DealerKPIValues(DealerKPIValue entity)
		{
			this.SendPropertyChanging();
			entity.Dealer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KPI")]
	public partial class KPI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _KPIID;
		
		private string _Description;
		
		private string _Name;
		
		private EntitySet<DealerKPIValue> _DealerKPIValues;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnKPIIDChanging(int value);
    partial void OnKPIIDChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public KPI()
		{
			this._DealerKPIValues = new EntitySet<DealerKPIValue>(new Action<DealerKPIValue>(this.attach_DealerKPIValues), new Action<DealerKPIValue>(this.detach_DealerKPIValues));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KPIID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int KPIID
		{
			get
			{
				return this._KPIID;
			}
			set
			{
				if ((this._KPIID != value))
				{
					this.OnKPIIDChanging(value);
					this.SendPropertyChanging();
					this._KPIID = value;
					this.SendPropertyChanged("KPIID");
					this.OnKPIIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KPI_DealerKPIValue", Storage="_DealerKPIValues", ThisKey="KPIID", OtherKey="KPIID")]
		public EntitySet<DealerKPIValue> DealerKPIValues
		{
			get
			{
				return this._DealerKPIValues;
			}
			set
			{
				this._DealerKPIValues.Assign(value);
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
		
		private void attach_DealerKPIValues(DealerKPIValue entity)
		{
			this.SendPropertyChanging();
			entity.KPI = this;
		}
		
		private void detach_DealerKPIValues(DealerKPIValue entity)
		{
			this.SendPropertyChanging();
			entity.KPI = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DealerKPIValue")]
	public partial class DealerKPIValue : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DealerID;
		
		private int _Month;
		
		private int _Year;
		
		private int _KPIID;
		
		private System.Nullable<double> _MonthAmount;
		
		private System.Nullable<double> _YtdAmount;
		
		private System.Nullable<System.DateTime> _Date;
		
		private EntityRef<Dealer> _Dealer;
		
		private EntityRef<KPI> _KPI;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDealerIDChanging(int value);
    partial void OnDealerIDChanged();
    partial void OnMonthChanging(int value);
    partial void OnMonthChanged();
    partial void OnYearChanging(int value);
    partial void OnYearChanged();
    partial void OnKPIIDChanging(int value);
    partial void OnKPIIDChanged();
    partial void OnMonthAmountChanging(System.Nullable<double> value);
    partial void OnMonthAmountChanged();
    partial void OnYtdAmountChanging(System.Nullable<double> value);
    partial void OnYtdAmountChanged();
    partial void OnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDateChanged();
    #endregion
		
		public DealerKPIValue()
		{
			this._Dealer = default(EntityRef<Dealer>);
			this._KPI = default(EntityRef<KPI>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DealerID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DealerID
		{
			get
			{
				return this._DealerID;
			}
			set
			{
				if ((this._DealerID != value))
				{
					if (this._Dealer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDealerIDChanging(value);
					this.SendPropertyChanging();
					this._DealerID = value;
					this.SendPropertyChanged("DealerID");
					this.OnDealerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Month", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Month
		{
			get
			{
				return this._Month;
			}
			set
			{
				if ((this._Month != value))
				{
					this.OnMonthChanging(value);
					this.SendPropertyChanging();
					this._Month = value;
					this.SendPropertyChanged("Month");
					this.OnMonthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KPIID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int KPIID
		{
			get
			{
				return this._KPIID;
			}
			set
			{
				if ((this._KPIID != value))
				{
					if (this._KPI.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnKPIIDChanging(value);
					this.SendPropertyChanging();
					this._KPIID = value;
					this.SendPropertyChanged("KPIID");
					this.OnKPIIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MonthAmount", DbType="Float")]
		public System.Nullable<double> MonthAmount
		{
			get
			{
				return this._MonthAmount;
			}
			set
			{
				if ((this._MonthAmount != value))
				{
					this.OnMonthAmountChanging(value);
					this.SendPropertyChanging();
					this._MonthAmount = value;
					this.SendPropertyChanged("MonthAmount");
					this.OnMonthAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YtdAmount", DbType="Float")]
		public System.Nullable<double> YtdAmount
		{
			get
			{
				return this._YtdAmount;
			}
			set
			{
				if ((this._YtdAmount != value))
				{
					this.OnYtdAmountChanging(value);
					this.SendPropertyChanging();
					this._YtdAmount = value;
					this.SendPropertyChanged("YtdAmount");
					this.OnYtdAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime")]
		public System.Nullable<System.DateTime> Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dealer_DealerKPIValue", Storage="_Dealer", ThisKey="DealerID", OtherKey="DealerID", IsForeignKey=true)]
		public Dealer Dealer
		{
			get
			{
				return this._Dealer.Entity;
			}
			set
			{
				Dealer previousValue = this._Dealer.Entity;
				if (((previousValue != value) 
							|| (this._Dealer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Dealer.Entity = null;
						previousValue.DealerKPIValues.Remove(this);
					}
					this._Dealer.Entity = value;
					if ((value != null))
					{
						value.DealerKPIValues.Add(this);
						this._DealerID = value.DealerID;
					}
					else
					{
						this._DealerID = default(int);
					}
					this.SendPropertyChanged("Dealer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KPI_DealerKPIValue", Storage="_KPI", ThisKey="KPIID", OtherKey="KPIID", IsForeignKey=true)]
		public KPI KPI
		{
			get
			{
				return this._KPI.Entity;
			}
			set
			{
				KPI previousValue = this._KPI.Entity;
				if (((previousValue != value) 
							|| (this._KPI.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KPI.Entity = null;
						previousValue.DealerKPIValues.Remove(this);
					}
					this._KPI.Entity = value;
					if ((value != null))
					{
						value.DealerKPIValues.Add(this);
						this._KPIID = value.KPIID;
					}
					else
					{
						this._KPIID = default(int);
					}
					this.SendPropertyChanged("KPI");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User
	{
		
		private System.Nullable<int> _UserID;
		
		private System.Nullable<int> _DealerID;
		
		public User()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
		public System.Nullable<int> UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DealerID", DbType="Int")]
		public System.Nullable<int> DealerID
		{
			get
			{
				return this._DealerID;
			}
			set
			{
				if ((this._DealerID != value))
				{
					this._DealerID = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Profiles")]
	public partial class Profile
	{
		
		private string _Username;
		
		private string _Password;
		
		private System.Nullable<int> _UserID;
		
		public Profile()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NChar(10)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this._Username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NChar(10)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this._Password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
		public System.Nullable<int> UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
	}
	
	public partial class GetKPIValuesResult
	{
		
		private int _Month;
		
		private int _Year;
		
		private System.Nullable<double> _AmtDealer;
		
		private System.Nullable<double> _AmtArea;
		
		private System.Nullable<double> _AmtTotal;
		
		public GetKPIValuesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Month", DbType="Int NOT NULL")]
		public int Month
		{
			get
			{
				return this._Month;
			}
			set
			{
				if ((this._Month != value))
				{
					this._Month = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int NOT NULL")]
		public int Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this._Year = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AmtDealer", DbType="Float")]
		public System.Nullable<double> AmtDealer
		{
			get
			{
				return this._AmtDealer;
			}
			set
			{
				if ((this._AmtDealer != value))
				{
					this._AmtDealer = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AmtArea", DbType="Float")]
		public System.Nullable<double> AmtArea
		{
			get
			{
				return this._AmtArea;
			}
			set
			{
				if ((this._AmtArea != value))
				{
					this._AmtArea = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AmtTotal", DbType="Float")]
		public System.Nullable<double> AmtTotal
		{
			get
			{
				return this._AmtTotal;
			}
			set
			{
				if ((this._AmtTotal != value))
				{
					this._AmtTotal = value;
				}
			}
		}
	}
	
	public partial class GetKPINameResult
	{
		
		private string _Description;
		
		private string _Name;
		
		public GetKPINameResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
					this._Name = value;
				}
			}
		}
	}
	
	public partial class GetDealershipKPIsResult
	{
		
		private int _KPIID;
		
		public GetDealershipKPIsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KPIID", DbType="Int NOT NULL")]
		public int KPIID
		{
			get
			{
				return this._KPIID;
			}
			set
			{
				if ((this._KPIID != value))
				{
					this._KPIID = value;
				}
			}
		}
	}
	
	public partial class GetUserDealershipsResult
	{
		
		private System.Nullable<int> _DealerID;
		
		public GetUserDealershipsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DealerID", DbType="Int")]
		public System.Nullable<int> DealerID
		{
			get
			{
				return this._DealerID;
			}
			set
			{
				if ((this._DealerID != value))
				{
					this._DealerID = value;
				}
			}
		}
	}
	
	public partial class ValidateUserResult
	{
		
		private System.Nullable<int> _UserID;
		
		public ValidateUserResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
		public System.Nullable<int> UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
	}
	
	public partial class GetMostRecentKPIValuesResult
	{
		
		private int _Month;
		
		private int _Year;
		
		private System.Nullable<double> _AmtDealer;
		
		private System.Nullable<double> _AmtArea;
		
		private System.Nullable<double> _AmtTotal;
		
		public GetMostRecentKPIValuesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Month", DbType="Int NOT NULL")]
		public int Month
		{
			get
			{
				return this._Month;
			}
			set
			{
				if ((this._Month != value))
				{
					this._Month = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int NOT NULL")]
		public int Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this._Year = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AmtDealer", DbType="Float")]
		public System.Nullable<double> AmtDealer
		{
			get
			{
				return this._AmtDealer;
			}
			set
			{
				if ((this._AmtDealer != value))
				{
					this._AmtDealer = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AmtArea", DbType="Float")]
		public System.Nullable<double> AmtArea
		{
			get
			{
				return this._AmtArea;
			}
			set
			{
				if ((this._AmtArea != value))
				{
					this._AmtArea = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AmtTotal", DbType="Float")]
		public System.Nullable<double> AmtTotal
		{
			get
			{
				return this._AmtTotal;
			}
			set
			{
				if ((this._AmtTotal != value))
				{
					this._AmtTotal = value;
				}
			}
		}
	}
	
	public partial class GetActionPlanKPIsResult
	{
		
		private System.Nullable<int> _KPIID;
		
		public GetActionPlanKPIsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KPIID", DbType="Int")]
		public System.Nullable<int> KPIID
		{
			get
			{
				return this._KPIID;
			}
			set
			{
				if ((this._KPIID != value))
				{
					this._KPIID = value;
				}
			}
		}
	}
	
	public partial class GetActionPlansResult
	{
		
		private int _UAPID;
		
		public GetActionPlansResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UAPID", DbType="Int NOT NULL")]
		public int UAPID
		{
			get
			{
				return this._UAPID;
			}
			set
			{
				if ((this._UAPID != value))
				{
					this._UAPID = value;
				}
			}
		}
	}
	
	public partial class AddActionPlanResult
	{
		
		private int _UAPID;
		
		public AddActionPlanResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UAPID", DbType="Int NOT NULL")]
		public int UAPID
		{
			get
			{
				return this._UAPID;
			}
			set
			{
				if ((this._UAPID != value))
				{
					this._UAPID = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
