#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATO.net.Models
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
	
	
	public partial class TaxthresholdDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTaxthreshold(Taxthreshold instance);
    partial void UpdateTaxthreshold(Taxthreshold instance);
    partial void DeleteTaxthreshold(Taxthreshold instance);
    #endregion
		
		public TaxthresholdDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TaxthresholdDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TaxthresholdDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TaxthresholdDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Taxthreshold> Taxthresholds
		{
			get
			{
				return this.GetTable<Taxthreshold>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Taxthreshold : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _taxthresholdId;
		
		private double _taxMin;
		
		private double _taxCent;
		
		private double _taxLump;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntaxthresholdIdChanging(int value);
    partial void OntaxthresholdIdChanged();
    partial void OntaxMinChanging(double value);
    partial void OntaxMinChanged();
    partial void OntaxCentChanging(double value);
    partial void OntaxCentChanged();
    partial void OntaxLumpChanging(double value);
    partial void OntaxLumpChanged();
    #endregion
		
		public Taxthreshold()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_taxthresholdId", IsPrimaryKey=true, IsDbGenerated=true)]
		public int taxthresholdId
		{
			get
			{
				return this._taxthresholdId;
			}
			set
			{
				if ((this._taxthresholdId != value))
				{
					this.OntaxthresholdIdChanging(value);
					this.SendPropertyChanging();
					this._taxthresholdId = value;
					this.SendPropertyChanged("taxthresholdId");
					this.OntaxthresholdIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_taxMin")]
		public double taxMin
		{
			get
			{
				return this._taxMin;
			}
			set
			{
				if ((this._taxMin != value))
				{
					this.OntaxMinChanging(value);
					this.SendPropertyChanging();
					this._taxMin = value;
					this.SendPropertyChanged("taxMin");
					this.OntaxMinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_taxCent")]
		public double taxCent
		{
			get
			{
				return this._taxCent;
			}
			set
			{
				if ((this._taxCent != value))
				{
					this.OntaxCentChanging(value);
					this.SendPropertyChanging();
					this._taxCent = value;
					this.SendPropertyChanged("taxCent");
					this.OntaxCentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_taxLump")]
		public double taxLump
		{
			get
			{
				return this._taxLump;
			}
			set
			{
				if ((this._taxLump != value))
				{
					this.OntaxLumpChanging(value);
					this.SendPropertyChanging();
					this._taxLump = value;
					this.SendPropertyChanged("taxLump");
					this.OntaxLumpChanged();
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
