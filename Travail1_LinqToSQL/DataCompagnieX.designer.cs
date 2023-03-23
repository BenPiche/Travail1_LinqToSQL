﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Travail1_LinqToSQL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CompagnieX")]
	public partial class DataCompagnieXDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void InsertDepartements(Departements instance);
    partial void UpdateDepartements(Departements instance);
    partial void DeleteDepartements(Departements instance);
    partial void InsertEmployes(Employes instance);
    partial void UpdateEmployes(Employes instance);
    partial void DeleteEmployes(Employes instance);
    #endregion
		
		public DataCompagnieXDataContext() : 
				base(global::Travail1_LinqToSQL.Properties.Settings.Default.CompagnieXConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataCompagnieXDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataCompagnieXDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataCompagnieXDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataCompagnieXDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Departements> Departements
		{
			get
			{
				return this.GetTable<Departements>();
			}
		}
		
		public System.Data.Linq.Table<Employes> Employes
		{
			get
			{
				return this.GetTable<Employes>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Departements")]
	public partial class Departements : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _depCode;
		
		private string _nom;
		
		private EntitySet<Employes> _Employes;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OndepCodeChanging(int value);
    partial void OndepCodeChanged();
    partial void OnnomChanging(string value);
    partial void OnnomChanged();
    #endregion
		
		public Departements()
		{
			this._Employes = new EntitySet<Employes>(new Action<Employes>(this.attach_Employes), new Action<Employes>(this.detach_Employes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_depCode", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int depCode
		{
			get
			{
				return this._depCode;
			}
			set
			{
				if ((this._depCode != value))
				{
					this.OndepCodeChanging(value);
					this.SendPropertyChanging();
					this._depCode = value;
					this.SendPropertyChanged("depCode");
					this.OndepCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nom
		{
			get
			{
				return this._nom;
			}
			set
			{
				if ((this._nom != value))
				{
					this.OnnomChanging(value);
					this.SendPropertyChanging();
					this._nom = value;
					this.SendPropertyChanged("nom");
					this.OnnomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departements_Employes", Storage="_Employes", ThisKey="depCode", OtherKey="dep")]
		public EntitySet<Employes> Employes
		{
			get
			{
				return this._Employes;
			}
			set
			{
				this._Employes.Assign(value);
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
		
		private void attach_Employes(Employes entity)
		{
			this.SendPropertyChanging();
			entity.Departements = this;
		}
		
		private void detach_Employes(Employes entity)
		{
			this.SendPropertyChanging();
			entity.Departements = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employes")]
	public partial class Employes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _nomFamille;
		
		private string _prénom;
		
		private string _numTel;
		
		private string _email;
		
		private int _numEmp;
		
		private bool _état;
		
		private bool _gestionnaire;
		
		private int _dep;
		
		private EntityRef<Departements> _Departements;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnomFamilleChanging(string value);
    partial void OnnomFamilleChanged();
    partial void OnprénomChanging(string value);
    partial void OnprénomChanged();
    partial void OnnumTelChanging(string value);
    partial void OnnumTelChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnnumEmpChanging(int value);
    partial void OnnumEmpChanged();
    partial void OnétatChanging(bool value);
    partial void OnétatChanged();
    partial void OngestionnaireChanging(bool value);
    partial void OngestionnaireChanged();
    partial void OndepChanging(int value);
    partial void OndepChanged();
    #endregion
		
		public Employes()
		{
			this._Departements = default(EntityRef<Departements>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nomFamille", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nomFamille
		{
			get
			{
				return this._nomFamille;
			}
			set
			{
				if ((this._nomFamille != value))
				{
					this.OnnomFamilleChanging(value);
					this.SendPropertyChanging();
					this._nomFamille = value;
					this.SendPropertyChanged("nomFamille");
					this.OnnomFamilleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prénom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string prénom
		{
			get
			{
				return this._prénom;
			}
			set
			{
				if ((this._prénom != value))
				{
					this.OnprénomChanging(value);
					this.SendPropertyChanging();
					this._prénom = value;
					this.SendPropertyChanged("prénom");
					this.OnprénomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numTel", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string numTel
		{
			get
			{
				return this._numTel;
			}
			set
			{
				if ((this._numTel != value))
				{
					this.OnnumTelChanging(value);
					this.SendPropertyChanging();
					this._numTel = value;
					this.SendPropertyChanged("numTel");
					this.OnnumTelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numEmp", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int numEmp
		{
			get
			{
				return this._numEmp;
			}
			set
			{
				if ((this._numEmp != value))
				{
					this.OnnumEmpChanging(value);
					this.SendPropertyChanging();
					this._numEmp = value;
					this.SendPropertyChanged("numEmp");
					this.OnnumEmpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_état", DbType="Bit NOT NULL")]
		public bool état
		{
			get
			{
				return this._état;
			}
			set
			{
				if ((this._état != value))
				{
					this.OnétatChanging(value);
					this.SendPropertyChanging();
					this._état = value;
					this.SendPropertyChanged("état");
					this.OnétatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gestionnaire", DbType="Bit NOT NULL")]
		public bool gestionnaire
		{
			get
			{
				return this._gestionnaire;
			}
			set
			{
				if ((this._gestionnaire != value))
				{
					this.OngestionnaireChanging(value);
					this.SendPropertyChanging();
					this._gestionnaire = value;
					this.SendPropertyChanged("gestionnaire");
					this.OngestionnaireChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dep", DbType="Int NOT NULL")]
		public int dep
		{
			get
			{
				return this._dep;
			}
			set
			{
				if ((this._dep != value))
				{
					if (this._Departements.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OndepChanging(value);
					this.SendPropertyChanging();
					this._dep = value;
					this.SendPropertyChanged("dep");
					this.OndepChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departements_Employes", Storage="_Departements", ThisKey="dep", OtherKey="depCode", IsForeignKey=true)]
		public Departements Departements
		{
			get
			{
				return this._Departements.Entity;
			}
			set
			{
				Departements previousValue = this._Departements.Entity;
				if (((previousValue != value) 
							|| (this._Departements.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Departements.Entity = null;
						previousValue.Employes.Remove(this);
					}
					this._Departements.Entity = value;
					if ((value != null))
					{
						value.Employes.Add(this);
						this._dep = value.depCode;
					}
					else
					{
						this._dep = default(int);
					}
					this.SendPropertyChanged("Departements");
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
