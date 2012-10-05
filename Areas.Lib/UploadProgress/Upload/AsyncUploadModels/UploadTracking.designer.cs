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

namespace Areas.Lib.UploadProgress.Upload.AsyncUploadModels
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="mycasting")]
	public partial class UploadTrackingDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUploadTracking(UploadTracking instance);
    partial void UpdateUploadTracking(UploadTracking instance);
    partial void DeleteUploadTracking(UploadTracking instance);
    partial void InsertUploadTrackingLog(UploadTrackingLog instance);
    partial void UpdateUploadTrackingLog(UploadTrackingLog instance);
    partial void DeleteUploadTrackingLog(UploadTrackingLog instance);
    #endregion
		
		public UploadTrackingDataContext() : 
				base(global::Areas.Lib.Properties.Settings.Default.mycastingConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public UploadTrackingDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UploadTrackingDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UploadTrackingDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UploadTrackingDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<UploadTracking> UploadTrackings
		{
			get
			{
				return this.GetTable<UploadTracking>();
			}
		}
		
		public System.Data.Linq.Table<UploadTrackingLog> UploadTrackingLogs
		{
			get
			{
				return this.GetTable<UploadTrackingLog>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UploadTrackings")]
	public partial class UploadTracking : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _TaskId;
		
		private string _ClientId;
		
		private System.DateTime _StartTime;
		
		private System.Nullable<System.DateTime> _UpdateTime;
		
		private string _SerializedData;
		
		private System.Nullable<bool> _InProgress;
		
		private System.Nullable<bool> _ProgressCounters;
		
		private string _CurrentOperationText;
		
		private string _PrimaryTotal;
		
		private string _PrimaryValue;
		
		private string _Speed;
		
		private System.Nullable<decimal> _TimeElapsed;
		
		private System.Nullable<decimal> _TimeEstimated;
		
		private System.Nullable<bool> _OperationComplete;
		
		private System.Nullable<decimal> _Total;
		
		private System.Nullable<decimal> _Done;
		
		private System.Nullable<System.DateTime> _StartedProgressingAt;
		
		private System.Nullable<System.DateTime> _StoppedProgressingAt;
		
		private System.Nullable<bool> _Completed;
		
		private string _FileFullPath;
		
		private string _ErrorText;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTaskIdChanging(long value);
    partial void OnTaskIdChanged();
    partial void OnClientIdChanging(string value);
    partial void OnClientIdChanged();
    partial void OnStartTimeChanging(System.DateTime value);
    partial void OnStartTimeChanged();
    partial void OnUpdateTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdateTimeChanged();
    partial void OnSerializedDataChanging(string value);
    partial void OnSerializedDataChanged();
    partial void OnInProgressChanging(System.Nullable<bool> value);
    partial void OnInProgressChanged();
    partial void OnProgressCountersChanging(System.Nullable<bool> value);
    partial void OnProgressCountersChanged();
    partial void OnCurrentOperationTextChanging(string value);
    partial void OnCurrentOperationTextChanged();
    partial void OnPrimaryTotalChanging(string value);
    partial void OnPrimaryTotalChanged();
    partial void OnPrimaryValueChanging(string value);
    partial void OnPrimaryValueChanged();
    partial void OnSpeedChanging(string value);
    partial void OnSpeedChanged();
    partial void OnTimeElapsedChanging(System.Nullable<decimal> value);
    partial void OnTimeElapsedChanged();
    partial void OnTimeEstimatedChanging(System.Nullable<decimal> value);
    partial void OnTimeEstimatedChanged();
    partial void OnOperationCompleteChanging(System.Nullable<bool> value);
    partial void OnOperationCompleteChanged();
    partial void OnTotalChanging(System.Nullable<decimal> value);
    partial void OnTotalChanged();
    partial void OnDoneChanging(System.Nullable<decimal> value);
    partial void OnDoneChanged();
    partial void OnStartedProgressingAtChanging(System.Nullable<System.DateTime> value);
    partial void OnStartedProgressingAtChanged();
    partial void OnStoppedProgressingAtChanging(System.Nullable<System.DateTime> value);
    partial void OnStoppedProgressingAtChanged();
    partial void OnCompletedChanging(System.Nullable<bool> value);
    partial void OnCompletedChanged();
    partial void OnFileFullPathChanging(string value);
    partial void OnFileFullPathChanged();
    partial void OnErrorTextChanging(string value);
    partial void OnErrorTextChanged();
    #endregion
		
		public UploadTracking()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskId", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long TaskId
		{
			get
			{
				return this._TaskId;
			}
			set
			{
				if ((this._TaskId != value))
				{
					this.OnTaskIdChanging(value);
					this.SendPropertyChanging();
					this._TaskId = value;
					this.SendPropertyChanged("TaskId");
					this.OnTaskIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientId", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ClientId
		{
			get
			{
				return this._ClientId;
			}
			set
			{
				if ((this._ClientId != value))
				{
					this.OnClientIdChanging(value);
					this.SendPropertyChanging();
					this._ClientId = value;
					this.SendPropertyChanged("ClientId");
					this.OnClientIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartTime", DbType="DateTime NOT NULL")]
		public System.DateTime StartTime
		{
			get
			{
				return this._StartTime;
			}
			set
			{
				if ((this._StartTime != value))
				{
					this.OnStartTimeChanging(value);
					this.SendPropertyChanging();
					this._StartTime = value;
					this.SendPropertyChanged("StartTime");
					this.OnStartTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdateTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> UpdateTime
		{
			get
			{
				return this._UpdateTime;
			}
			set
			{
				if ((this._UpdateTime != value))
				{
					this.OnUpdateTimeChanging(value);
					this.SendPropertyChanging();
					this._UpdateTime = value;
					this.SendPropertyChanged("UpdateTime");
					this.OnUpdateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SerializedData", DbType="NVarChar(1000)")]
		public string SerializedData
		{
			get
			{
				return this._SerializedData;
			}
			set
			{
				if ((this._SerializedData != value))
				{
					this.OnSerializedDataChanging(value);
					this.SendPropertyChanging();
					this._SerializedData = value;
					this.SendPropertyChanged("SerializedData");
					this.OnSerializedDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InProgress", DbType="Bit")]
		public System.Nullable<bool> InProgress
		{
			get
			{
				return this._InProgress;
			}
			set
			{
				if ((this._InProgress != value))
				{
					this.OnInProgressChanging(value);
					this.SendPropertyChanging();
					this._InProgress = value;
					this.SendPropertyChanged("InProgress");
					this.OnInProgressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProgressCounters", DbType="Bit")]
		public System.Nullable<bool> ProgressCounters
		{
			get
			{
				return this._ProgressCounters;
			}
			set
			{
				if ((this._ProgressCounters != value))
				{
					this.OnProgressCountersChanging(value);
					this.SendPropertyChanging();
					this._ProgressCounters = value;
					this.SendPropertyChanged("ProgressCounters");
					this.OnProgressCountersChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrentOperationText", DbType="NVarChar(50)")]
		public string CurrentOperationText
		{
			get
			{
				return this._CurrentOperationText;
			}
			set
			{
				if ((this._CurrentOperationText != value))
				{
					this.OnCurrentOperationTextChanging(value);
					this.SendPropertyChanging();
					this._CurrentOperationText = value;
					this.SendPropertyChanged("CurrentOperationText");
					this.OnCurrentOperationTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrimaryTotal", DbType="NVarChar(50)")]
		public string PrimaryTotal
		{
			get
			{
				return this._PrimaryTotal;
			}
			set
			{
				if ((this._PrimaryTotal != value))
				{
					this.OnPrimaryTotalChanging(value);
					this.SendPropertyChanging();
					this._PrimaryTotal = value;
					this.SendPropertyChanged("PrimaryTotal");
					this.OnPrimaryTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrimaryValue", DbType="NVarChar(50)")]
		public string PrimaryValue
		{
			get
			{
				return this._PrimaryValue;
			}
			set
			{
				if ((this._PrimaryValue != value))
				{
					this.OnPrimaryValueChanging(value);
					this.SendPropertyChanging();
					this._PrimaryValue = value;
					this.SendPropertyChanged("PrimaryValue");
					this.OnPrimaryValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Speed", DbType="NVarChar(50)")]
		public string Speed
		{
			get
			{
				return this._Speed;
			}
			set
			{
				if ((this._Speed != value))
				{
					this.OnSpeedChanging(value);
					this.SendPropertyChanging();
					this._Speed = value;
					this.SendPropertyChanged("Speed");
					this.OnSpeedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeElapsed", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> TimeElapsed
		{
			get
			{
				return this._TimeElapsed;
			}
			set
			{
				if ((this._TimeElapsed != value))
				{
					this.OnTimeElapsedChanging(value);
					this.SendPropertyChanging();
					this._TimeElapsed = value;
					this.SendPropertyChanged("TimeElapsed");
					this.OnTimeElapsedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeEstimated", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> TimeEstimated
		{
			get
			{
				return this._TimeEstimated;
			}
			set
			{
				if ((this._TimeEstimated != value))
				{
					this.OnTimeEstimatedChanging(value);
					this.SendPropertyChanging();
					this._TimeEstimated = value;
					this.SendPropertyChanged("TimeEstimated");
					this.OnTimeEstimatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OperationComplete", DbType="Bit")]
		public System.Nullable<bool> OperationComplete
		{
			get
			{
				return this._OperationComplete;
			}
			set
			{
				if ((this._OperationComplete != value))
				{
					this.OnOperationCompleteChanging(value);
					this.SendPropertyChanging();
					this._OperationComplete = value;
					this.SendPropertyChanged("OperationComplete");
					this.OnOperationCompleteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Total
		{
			get
			{
				return this._Total;
			}
			set
			{
				if ((this._Total != value))
				{
					this.OnTotalChanging(value);
					this.SendPropertyChanging();
					this._Total = value;
					this.SendPropertyChanged("Total");
					this.OnTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Done", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Done
		{
			get
			{
				return this._Done;
			}
			set
			{
				if ((this._Done != value))
				{
					this.OnDoneChanging(value);
					this.SendPropertyChanging();
					this._Done = value;
					this.SendPropertyChanged("Done");
					this.OnDoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartedProgressingAt", DbType="DateTime")]
		public System.Nullable<System.DateTime> StartedProgressingAt
		{
			get
			{
				return this._StartedProgressingAt;
			}
			set
			{
				if ((this._StartedProgressingAt != value))
				{
					this.OnStartedProgressingAtChanging(value);
					this.SendPropertyChanging();
					this._StartedProgressingAt = value;
					this.SendPropertyChanged("StartedProgressingAt");
					this.OnStartedProgressingAtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StoppedProgressingAt", DbType="DateTime")]
		public System.Nullable<System.DateTime> StoppedProgressingAt
		{
			get
			{
				return this._StoppedProgressingAt;
			}
			set
			{
				if ((this._StoppedProgressingAt != value))
				{
					this.OnStoppedProgressingAtChanging(value);
					this.SendPropertyChanging();
					this._StoppedProgressingAt = value;
					this.SendPropertyChanged("StoppedProgressingAt");
					this.OnStoppedProgressingAtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Completed", DbType="Bit")]
		public System.Nullable<bool> Completed
		{
			get
			{
				return this._Completed;
			}
			set
			{
				if ((this._Completed != value))
				{
					this.OnCompletedChanging(value);
					this.SendPropertyChanging();
					this._Completed = value;
					this.SendPropertyChanged("Completed");
					this.OnCompletedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileFullPath", DbType="NVarChar(300)")]
		public string FileFullPath
		{
			get
			{
				return this._FileFullPath;
			}
			set
			{
				if ((this._FileFullPath != value))
				{
					this.OnFileFullPathChanging(value);
					this.SendPropertyChanging();
					this._FileFullPath = value;
					this.SendPropertyChanged("FileFullPath");
					this.OnFileFullPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorText", DbType="NVarChar(50)")]
		public string ErrorText
		{
			get
			{
				return this._ErrorText;
			}
			set
			{
				if ((this._ErrorText != value))
				{
					this.OnErrorTextChanging(value);
					this.SendPropertyChanging();
					this._ErrorText = value;
					this.SendPropertyChanged("ErrorText");
					this.OnErrorTextChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UploadTrackingLogs")]
	public partial class UploadTrackingLog : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _LogId;
		
		private System.DateTime _LogDate;
		
		private string _ClientId;
		
		private string _MainFunction;
		
		private string _Title;
		
		private string _DataDump;
		
		private string _Extra1;
		
		private string _Extra2;
		
		private string _Extra3;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLogIdChanging(long value);
    partial void OnLogIdChanged();
    partial void OnLogDateChanging(System.DateTime value);
    partial void OnLogDateChanged();
    partial void OnClientIdChanging(string value);
    partial void OnClientIdChanged();
    partial void OnMainFunctionChanging(string value);
    partial void OnMainFunctionChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDataDumpChanging(string value);
    partial void OnDataDumpChanged();
    partial void OnExtra1Changing(string value);
    partial void OnExtra1Changed();
    partial void OnExtra2Changing(string value);
    partial void OnExtra2Changed();
    partial void OnExtra3Changing(string value);
    partial void OnExtra3Changed();
    #endregion
		
		public UploadTrackingLog()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LogId", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long LogId
		{
			get
			{
				return this._LogId;
			}
			set
			{
				if ((this._LogId != value))
				{
					this.OnLogIdChanging(value);
					this.SendPropertyChanging();
					this._LogId = value;
					this.SendPropertyChanged("LogId");
					this.OnLogIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LogDate", DbType="DateTime NOT NULL")]
		public System.DateTime LogDate
		{
			get
			{
				return this._LogDate;
			}
			set
			{
				if ((this._LogDate != value))
				{
					this.OnLogDateChanging(value);
					this.SendPropertyChanging();
					this._LogDate = value;
					this.SendPropertyChanged("LogDate");
					this.OnLogDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientId", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ClientId
		{
			get
			{
				return this._ClientId;
			}
			set
			{
				if ((this._ClientId != value))
				{
					this.OnClientIdChanging(value);
					this.SendPropertyChanging();
					this._ClientId = value;
					this.SendPropertyChanged("ClientId");
					this.OnClientIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MainFunction", DbType="NVarChar(50)")]
		public string MainFunction
		{
			get
			{
				return this._MainFunction;
			}
			set
			{
				if ((this._MainFunction != value))
				{
					this.OnMainFunctionChanging(value);
					this.SendPropertyChanging();
					this._MainFunction = value;
					this.SendPropertyChanged("MainFunction");
					this.OnMainFunctionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataDump", DbType="NVarChar(MAX)")]
		public string DataDump
		{
			get
			{
				return this._DataDump;
			}
			set
			{
				if ((this._DataDump != value))
				{
					this.OnDataDumpChanging(value);
					this.SendPropertyChanging();
					this._DataDump = value;
					this.SendPropertyChanged("DataDump");
					this.OnDataDumpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Extra1", DbType="NVarChar(4000)")]
		public string Extra1
		{
			get
			{
				return this._Extra1;
			}
			set
			{
				if ((this._Extra1 != value))
				{
					this.OnExtra1Changing(value);
					this.SendPropertyChanging();
					this._Extra1 = value;
					this.SendPropertyChanged("Extra1");
					this.OnExtra1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Extra2", DbType="NVarChar(4000)")]
		public string Extra2
		{
			get
			{
				return this._Extra2;
			}
			set
			{
				if ((this._Extra2 != value))
				{
					this.OnExtra2Changing(value);
					this.SendPropertyChanging();
					this._Extra2 = value;
					this.SendPropertyChanged("Extra2");
					this.OnExtra2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Extra3", DbType="NVarChar(4000)")]
		public string Extra3
		{
			get
			{
				return this._Extra3;
			}
			set
			{
				if ((this._Extra3 != value))
				{
					this.OnExtra3Changing(value);
					this.SendPropertyChanging();
					this._Extra3 = value;
					this.SendPropertyChanged("Extra3");
					this.OnExtra3Changed();
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