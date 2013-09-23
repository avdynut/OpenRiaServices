﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1416
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataTests.Scenarios.LTS.Northwind
{
    using System.Data.Linq;
    using System.Data.Linq.Mapping;
    using System.Data;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using System.ComponentModel;
    using System;

    /// <summary>
    /// This is a hand crafted class used to efficiently test LTS codegen and runtime
    /// corner cases.
    /// </summary>
    [System.Data.Linq.Mapping.DatabaseAttribute(Name = "Northwind")]
    public partial class NorthwindScenarios : System.Data.Linq.DataContext
    {
        private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();

        public NorthwindScenarios() :
            base(global::System.Common.DomainServices.Test.Properties.Settings.Default.NorthwindConnectionString, mappingSource)
        {

        }

        public NorthwindScenarios(string connection) :
            base(connection, mappingSource)
        {
        }

        public NorthwindScenarios(System.Data.IDbConnection connection) :
            base(connection, mappingSource)
        {
        }

        public NorthwindScenarios(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
            base(connection, mappingSource)
        {
        }

        public NorthwindScenarios(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
            base(connection, mappingSource)
        {
        }

        #region Bug479436 - Uni-Directional association
        public System.Data.Linq.Table<Customer_Bug479436> Customer_Bug479436s
        {
            get
            {
                return this.GetTable<Customer_Bug479436>();
            }
        }
        public System.Data.Linq.Table<Order_Bug479436> Order_Bug479436s
        {
            get
            {
                return this.GetTable<Order_Bug479436>();
            }
        }
        #endregion

        public System.Data.Linq.Table<TimestampEntity> TimestampEntities
        {
            get
            {
                return this.GetTable<TimestampEntity>();
            }
        }

        public System.Data.Linq.Table<Bug843965_A> Bug843965_As
        {
            get
            {
                return this.GetTable<Bug843965_A>();
            }
        }
    }

    #region Bug479436 - Uni-Directional association
    /// <summary>
    /// This customer doesn't have an 
    /// </summary>
    [Table(Name = "dbo.Customers")]
    [DataContract()]
    public partial class Customer_Bug479436 : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _CustomerID;

        private string _CompanyName;

        private string _ContactName;

        private string _ContactTitle;

        private string _Address;

        private string _City;

        private string _Region;

        private string _PostalCode;

        private string _Country;

        private string _Phone;

        private string _Fax;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnCustomerIDChanging(string value);
        partial void OnCustomerIDChanged();
        partial void OnCompanyNameChanging(string value);
        partial void OnCompanyNameChanged();
        partial void OnContactNameChanging(string value);
        partial void OnContactNameChanged();
        partial void OnContactTitleChanging(string value);
        partial void OnContactTitleChanged();
        partial void OnAddressChanging(string value);
        partial void OnAddressChanged();
        partial void OnCityChanging(string value);
        partial void OnCityChanged();
        partial void OnRegionChanging(string value);
        partial void OnRegionChanged();
        partial void OnPostalCodeChanging(string value);
        partial void OnPostalCodeChanged();
        partial void OnCountryChanging(string value);
        partial void OnCountryChanged();
        partial void OnPhoneChanging(string value);
        partial void OnPhoneChanged();
        partial void OnFaxChanging(string value);
        partial void OnFaxChanged();
        #endregion

        public Customer_Bug479436()
        {
            this.Initialize();
        }

        [Column(Storage = "_CustomerID", DbType = "NChar(5) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        [DataMember(Order = 1)]
        public string CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                if ((this._CustomerID != value))
                {
                    this.OnCustomerIDChanging(value);
                    this.SendPropertyChanging();
                    this._CustomerID = value;
                    this.SendPropertyChanged("CustomerID");
                    this.OnCustomerIDChanged();
                }
            }
        }

        [Column(Storage = "_CompanyName", DbType = "NVarChar(40) NOT NULL", CanBeNull = false)]
        [DataMember(Order = 2)]
        public string CompanyName
        {
            get
            {
                return this._CompanyName;
            }
            set
            {
                if ((this._CompanyName != value))
                {
                    this.OnCompanyNameChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyName = value;
                    this.SendPropertyChanged("CompanyName");
                    this.OnCompanyNameChanged();
                }
            }
        }

        [Column(Storage = "_ContactName", DbType = "NVarChar(30)")]
        [DataMember(Order = 3)]
        public string ContactName
        {
            get
            {
                return this._ContactName;
            }
            set
            {
                if ((this._ContactName != value))
                {
                    this.OnContactNameChanging(value);
                    this.SendPropertyChanging();
                    this._ContactName = value;
                    this.SendPropertyChanged("ContactName");
                    this.OnContactNameChanged();
                }
            }
        }

        [Column(Storage = "_ContactTitle", DbType = "NVarChar(30)")]
        [DataMember(Order = 4)]
        public string ContactTitle
        {
            get
            {
                return this._ContactTitle;
            }
            set
            {
                if ((this._ContactTitle != value))
                {
                    this.OnContactTitleChanging(value);
                    this.SendPropertyChanging();
                    this._ContactTitle = value;
                    this.SendPropertyChanged("ContactTitle");
                    this.OnContactTitleChanged();
                }
            }
        }

        [Column(Storage = "_Address", DbType = "NVarChar(60)")]
        [DataMember(Order = 5)]
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

        [Column(Storage = "_City", DbType = "NVarChar(15)")]
        [DataMember(Order = 6)]
        public string City
        {
            get
            {
                return this._City;
            }
            set
            {
                if ((this._City != value))
                {
                    this.OnCityChanging(value);
                    this.SendPropertyChanging();
                    this._City = value;
                    this.SendPropertyChanged("City");
                    this.OnCityChanged();
                }
            }
        }

        [Column(Storage = "_Region", DbType = "NVarChar(15)")]
        [DataMember(Order = 7)]
        public string Region
        {
            get
            {
                return this._Region;
            }
            set
            {
                if ((this._Region != value))
                {
                    this.OnRegionChanging(value);
                    this.SendPropertyChanging();
                    this._Region = value;
                    this.SendPropertyChanged("Region");
                    this.OnRegionChanged();
                }
            }
        }

        [Column(Storage = "_PostalCode", DbType = "NVarChar(10)")]
        [DataMember(Order = 8)]
        public string PostalCode
        {
            get
            {
                return this._PostalCode;
            }
            set
            {
                if ((this._PostalCode != value))
                {
                    this.OnPostalCodeChanging(value);
                    this.SendPropertyChanging();
                    this._PostalCode = value;
                    this.SendPropertyChanged("PostalCode");
                    this.OnPostalCodeChanged();
                }
            }
        }

        [Column(Storage = "_Country", DbType = "NVarChar(15)")]
        [DataMember(Order = 9)]
        public string Country
        {
            get
            {
                return this._Country;
            }
            set
            {
                if ((this._Country != value))
                {
                    this.OnCountryChanging(value);
                    this.SendPropertyChanging();
                    this._Country = value;
                    this.SendPropertyChanged("Country");
                    this.OnCountryChanged();
                }
            }
        }

        [Column(Storage = "_Phone", DbType = "NVarChar(24)")]
        [DataMember(Order = 10)]
        public string Phone
        {
            get
            {
                return this._Phone;
            }
            set
            {
                if ((this._Phone != value))
                {
                    this.OnPhoneChanging(value);
                    this.SendPropertyChanging();
                    this._Phone = value;
                    this.SendPropertyChanged("Phone");
                    this.OnPhoneChanged();
                }
            }
        }

        [Column(Storage = "_Fax", DbType = "NVarChar(24)")]
        [DataMember(Order = 11)]
        public string Fax
        {
            get
            {
                return this._Fax;
            }
            set
            {
                if ((this._Fax != value))
                {
                    this.OnFaxChanging(value);
                    this.SendPropertyChanging();
                    this._Fax = value;
                    this.SendPropertyChanged("Fax");
                    this.OnFaxChanged();
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

        private void Initialize()
        {
            OnCreated();
        }

        [OnDeserializing()]
        [System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public void OnDeserializing(StreamingContext context)
        {
            this.Initialize();
        }

        [OnSerializing()]
        [System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public void OnSerializing(StreamingContext context)
        {
            //
        }

        [OnSerialized()]
        [System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public void OnSerialized(StreamingContext context)
        {
            //
        }
    }

    [Table(Name = "dbo.Orders")]
    [DataContract()]
    public partial class Order_Bug479436 : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _OrderID;

        private string _CustomerID;

        private System.Nullable<System.DateTime> _OrderDate;

        private System.Nullable<System.DateTime> _RequiredDate;

        private System.Nullable<System.DateTime> _ShippedDate;

        private System.Nullable<int> _ShipVia;

        private System.Nullable<decimal> _Freight;

        private string _ShipName;

        private string _ShipAddress;

        private string _ShipCity;

        private string _ShipRegion;

        private string _ShipPostalCode;

        private string _ShipCountry;

        private EntityRef<Customer_Bug479436> _Customer;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnOrderIDChanging(int value);
        partial void OnOrderIDChanged();
        partial void OnCustomerIDChanging(string value);
        partial void OnCustomerIDChanged();
        partial void OnEmployeeIDChanging(System.Nullable<int> value);
        partial void OnEmployeeIDChanged();
        partial void OnOrderDateChanging(System.Nullable<System.DateTime> value);
        partial void OnOrderDateChanged();
        partial void OnRequiredDateChanging(System.Nullable<System.DateTime> value);
        partial void OnRequiredDateChanged();
        partial void OnShippedDateChanging(System.Nullable<System.DateTime> value);
        partial void OnShippedDateChanged();
        partial void OnShipViaChanging(System.Nullable<int> value);
        partial void OnShipViaChanged();
        partial void OnFreightChanging(System.Nullable<decimal> value);
        partial void OnFreightChanged();
        partial void OnShipNameChanging(string value);
        partial void OnShipNameChanged();
        partial void OnShipAddressChanging(string value);
        partial void OnShipAddressChanged();
        partial void OnShipCityChanging(string value);
        partial void OnShipCityChanged();
        partial void OnShipRegionChanging(string value);
        partial void OnShipRegionChanged();
        partial void OnShipPostalCodeChanging(string value);
        partial void OnShipPostalCodeChanged();
        partial void OnShipCountryChanging(string value);
        partial void OnShipCountryChanged();
        #endregion

        public Order_Bug479436()
        {
            this.Initialize();
        }

        [Column(Storage = "_OrderID", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        [DataMember(Order = 1)]
        public int OrderID
        {
            get
            {
                return this._OrderID;
            }
            set
            {
                if ((this._OrderID != value))
                {
                    this.OnOrderIDChanging(value);
                    this.SendPropertyChanging();
                    this._OrderID = value;
                    this.SendPropertyChanged("OrderID");
                    this.OnOrderIDChanged();
                }
            }
        }

        [Column(Storage = "_CustomerID", DbType = "NChar(5)")]
        [DataMember(Order = 2)]
        public string CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                if ((this._CustomerID != value))
                {
                    if (this._Customer.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnCustomerIDChanging(value);
                    this.SendPropertyChanging();
                    this._CustomerID = value;
                    this.SendPropertyChanged("CustomerID");
                    this.OnCustomerIDChanged();
                }
            }
        }

        [Column(Storage = "_OrderDate", DbType = "DateTime")]
        [DataMember(Order = 4)]
        public System.Nullable<System.DateTime> OrderDate
        {
            get
            {
                return this._OrderDate;
            }
            set
            {
                if ((this._OrderDate != value))
                {
                    this.OnOrderDateChanging(value);
                    this.SendPropertyChanging();
                    this._OrderDate = value;
                    this.SendPropertyChanged("OrderDate");
                    this.OnOrderDateChanged();
                }
            }
        }

        [Column(Storage = "_RequiredDate", DbType = "DateTime")]
        [DataMember(Order = 5)]
        public System.Nullable<System.DateTime> RequiredDate
        {
            get
            {
                return this._RequiredDate;
            }
            set
            {
                if ((this._RequiredDate != value))
                {
                    this.OnRequiredDateChanging(value);
                    this.SendPropertyChanging();
                    this._RequiredDate = value;
                    this.SendPropertyChanged("RequiredDate");
                    this.OnRequiredDateChanged();
                }
            }
        }

        [Column(Storage = "_ShippedDate", DbType = "DateTime")]
        [DataMember(Order = 6)]
        public System.Nullable<System.DateTime> ShippedDate
        {
            get
            {
                return this._ShippedDate;
            }
            set
            {
                if ((this._ShippedDate != value))
                {
                    this.OnShippedDateChanging(value);
                    this.SendPropertyChanging();
                    this._ShippedDate = value;
                    this.SendPropertyChanged("ShippedDate");
                    this.OnShippedDateChanged();
                }
            }
        }

        [Column(Storage = "_ShipVia", DbType = "Int")]
        [DataMember(Order = 7)]
        public System.Nullable<int> ShipVia
        {
            get
            {
                return this._ShipVia;
            }
            set
            {
                if ((this._ShipVia != value))
                {
                    this.OnShipViaChanging(value);
                    this.SendPropertyChanging();
                    this._ShipVia = value;
                    this.SendPropertyChanged("ShipVia");
                    this.OnShipViaChanged();
                }
            }
        }

        [Column(Storage = "_Freight", DbType = "Money")]
        [DataMember(Order = 8)]
        public System.Nullable<decimal> Freight
        {
            get
            {
                return this._Freight;
            }
            set
            {
                if ((this._Freight != value))
                {
                    this.OnFreightChanging(value);
                    this.SendPropertyChanging();
                    this._Freight = value;
                    this.SendPropertyChanged("Freight");
                    this.OnFreightChanged();
                }
            }
        }

        [Column(Storage = "_ShipName", DbType = "NVarChar(40)")]
        [DataMember(Order = 9)]
        public string ShipName
        {
            get
            {
                return this._ShipName;
            }
            set
            {
                if ((this._ShipName != value))
                {
                    this.OnShipNameChanging(value);
                    this.SendPropertyChanging();
                    this._ShipName = value;
                    this.SendPropertyChanged("ShipName");
                    this.OnShipNameChanged();
                }
            }
        }

        [Column(Storage = "_ShipAddress", DbType = "NVarChar(60)")]
        [DataMember(Order = 10)]
        public string ShipAddress
        {
            get
            {
                return this._ShipAddress;
            }
            set
            {
                if ((this._ShipAddress != value))
                {
                    this.OnShipAddressChanging(value);
                    this.SendPropertyChanging();
                    this._ShipAddress = value;
                    this.SendPropertyChanged("ShipAddress");
                    this.OnShipAddressChanged();
                }
            }
        }

        [Column(Storage = "_ShipCity", DbType = "NVarChar(15)")]
        [DataMember(Order = 11)]
        public string ShipCity
        {
            get
            {
                return this._ShipCity;
            }
            set
            {
                if ((this._ShipCity != value))
                {
                    this.OnShipCityChanging(value);
                    this.SendPropertyChanging();
                    this._ShipCity = value;
                    this.SendPropertyChanged("ShipCity");
                    this.OnShipCityChanged();
                }
            }
        }

        [Column(Storage = "_ShipRegion", DbType = "NVarChar(15)")]
        [DataMember(Order = 12)]
        public string ShipRegion
        {
            get
            {
                return this._ShipRegion;
            }
            set
            {
                if ((this._ShipRegion != value))
                {
                    this.OnShipRegionChanging(value);
                    this.SendPropertyChanging();
                    this._ShipRegion = value;
                    this.SendPropertyChanged("ShipRegion");
                    this.OnShipRegionChanged();
                }
            }
        }

        [Column(Storage = "_ShipPostalCode", DbType = "NVarChar(10)")]
        [DataMember(Order = 13)]
        public string ShipPostalCode
        {
            get
            {
                return this._ShipPostalCode;
            }
            set
            {
                if ((this._ShipPostalCode != value))
                {
                    this.OnShipPostalCodeChanging(value);
                    this.SendPropertyChanging();
                    this._ShipPostalCode = value;
                    this.SendPropertyChanged("ShipPostalCode");
                    this.OnShipPostalCodeChanged();
                }
            }
        }

        [Column(Storage = "_ShipCountry", DbType = "NVarChar(15)")]
        [DataMember(Order = 14)]
        public string ShipCountry
        {
            get
            {
                return this._ShipCountry;
            }
            set
            {
                if ((this._ShipCountry != value))
                {
                    this.OnShipCountryChanging(value);
                    this.SendPropertyChanging();
                    this._ShipCountry = value;
                    this.SendPropertyChanged("ShipCountry");
                    this.OnShipCountryChanged();
                }
            }
        }

        [Association(Name = "Customer_Order", Storage = "_Customer", ThisKey = "CustomerID", IsForeignKey = true)]
        public Customer_Bug479436 Customer
        {
            get
            {
                return this._Customer.Entity;
            }
            set
            {
                Customer_Bug479436 previousValue = this._Customer.Entity;
                if (((previousValue != value)
                            || (this._Customer.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Customer.Entity = null;
                    }
                    this._Customer.Entity = value;
                    if ((value != null))
                    {
                        this._CustomerID = value.CustomerID;
                    }
                    else
                    {
                        this._CustomerID = default(string);
                    }
                    this.SendPropertyChanged("Customer");
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

        private void Initialize()
        {
            this._Customer = default(EntityRef<Customer_Bug479436>);
            OnCreated();
        }

        [OnDeserializing()]
        [System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public void OnDeserializing(StreamingContext context)
        {
            this.Initialize();
        }

        [OnSerializing()]
        [System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public void OnSerializing(StreamingContext context)
        {
            //
        }

        [OnSerialized()]
        [System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public void OnSerialized(StreamingContext context)
        {
            //
        }
    }
    #endregion

    [Table(Name = "dbo.TimestampEntity")]
    [DataContract()]
    public class TimestampEntity
    {
        [Column(DbType = "int NOT NULL", IsPrimaryKey = true)]
        public int ID { get; set; }

        [Column(DbType = "int NOT NULL", UpdateCheck = UpdateCheck.Always)]
        public int A { get; set; }

        [Column(DbType = "rowversion NOT NULL", IsVersion = true)]
        public byte[] Timestamp { get; set; }
    }

    #region TDP Inheritance hierarchy repro
    [Table(Name = "dbo.Bug843965_A")]
    [DataContract]
    [KnownType(typeof(Bug843965_B))]
    public class Bug843965_A
    {
        [DataMember]
        [Column(DbType = "int NOT NULL", IsPrimaryKey = true)]
        public int ID { get; set; }
    }

    [Table(Name = "dbo.Bug843965_B")]
    [DataContract]
    [KnownType(typeof(Bug843965_C))]
    public class Bug843965_B : Bug843965_A
    {

    }

    [Table(Name = "dbo.Bug843965_C")]
    [DataContract]
    public class Bug843965_C : Bug843965_B
    {

    }
    #endregion

    [Table(Name = "dbo.RequiredAttributeTestEntity")]
    [DataContract()]
    public partial class RequiredAttributeTestEntity
    {
        [Column(DbType = "int NOT NULL", IsPrimaryKey = true)]
        [DataMember]
        public int Id { get; set; }

        [Column(DbType = "requiredString NVARCHAR(255) NOT NULL", CanBeNull = false)]
        [DataMember]
        public string RequiredString { get; set; }

        [Column(DbType = "requiredString NVARCHAR(255) NOT NULL", CanBeNull = false)]
        [DataMember]
        public string RequiredStringOverride { get; set; }

        [Column(DbType = "requiredInt32 INT NOT NULL", CanBeNull = false)]
        [DataMember]
        public int RequiredInt32 { get; set; }

        [Column(DbType = "requiredNullableInt32 INT NOT NULL", CanBeNull = false)]
        [DataMember]
        public Nullable<int> RequiredNullableInt32 { get; set; }

        [Column(DbType = "optionalString NVARCHAR(255) NULL", CanBeNull = true)]
        [DataMember]
        public string OptionalString { get; set; }

        [Column(DbType = "optionalInt32 INT NULL", CanBeNull = true)]
        [DataMember]
        public int OptionalInt32 { get; set; }

        [Column(DbType = "optionalNullableInt32 INT NULL", CanBeNull = true)]
        [DataMember]
        public Nullable<int> OptionalNullableInt32 { get; set; }
    }

}

#pragma warning restore 1591