﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Smark.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace NorthWind.DBModule {
    
    
    /// <summary>
    /// Smark.Data Generator Copyright © FanJianHan 2010-2012
    /// website:http://www.ikende.com
    /// </summary>
    [Serializable()]
    [Table("Customers")]
    public partial class Customer : Smark.Data.Mappings.DataObject, ICustomer {
        
        private string mCustomerID;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo customerID = new Smark.Data.FieldInfo("Customers", "CustomerID");
        
        private string mCompanyName;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo companyName = new Smark.Data.FieldInfo("Customers", "CompanyName");
        
        private string mContactName;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo contactName = new Smark.Data.FieldInfo("Customers", "ContactName");
        
        private string mContactTitle;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo contactTitle = new Smark.Data.FieldInfo("Customers", "ContactTitle");
        
        private string mAddress;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo address = new Smark.Data.FieldInfo("Customers", "Address");
        
        private string mCity;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo city = new Smark.Data.FieldInfo("Customers", "City");
        
        private string mRegion;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo region = new Smark.Data.FieldInfo("Customers", "Region");
        
        private string mPostalCode;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo postalCode = new Smark.Data.FieldInfo("Customers", "PostalCode");
        
        private string mCountry;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo country = new Smark.Data.FieldInfo("Customers", "Country");
        
        private string mPhone;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo phone = new Smark.Data.FieldInfo("Customers", "Phone");
        
        private string mFax;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo fax = new Smark.Data.FieldInfo("Customers", "Fax");
        
        [ID()]
        public virtual string CustomerID {
            get {
                return this.mCustomerID;
            }
            set {
                this.mCustomerID = value;
                this.EntityState.FieldChange("CustomerID");
            }
        }
        
        [Column()]
        public virtual string CompanyName {
            get {
                return this.mCompanyName;
            }
            set {
                this.mCompanyName = value;
                this.EntityState.FieldChange("CompanyName");
            }
        }
        
        [Column()]
        public virtual string ContactName {
            get {
                return this.mContactName;
            }
            set {
                this.mContactName = value;
                this.EntityState.FieldChange("ContactName");
            }
        }
        
        [Column()]
        public virtual string ContactTitle {
            get {
                return this.mContactTitle;
            }
            set {
                this.mContactTitle = value;
                this.EntityState.FieldChange("ContactTitle");
            }
        }
        
        [Column()]
        public virtual string Address {
            get {
                return this.mAddress;
            }
            set {
                this.mAddress = value;
                this.EntityState.FieldChange("Address");
            }
        }
        
        [Column()]
        public virtual string City {
            get {
                return this.mCity;
            }
            set {
                this.mCity = value;
                this.EntityState.FieldChange("City");
            }
        }
        
        [Column()]
        public virtual string Region {
            get {
                return this.mRegion;
            }
            set {
                this.mRegion = value;
                this.EntityState.FieldChange("Region");
            }
        }
        
        [Column()]
        public virtual string PostalCode {
            get {
                return this.mPostalCode;
            }
            set {
                this.mPostalCode = value;
                this.EntityState.FieldChange("PostalCode");
            }
        }
        
        [Column()]
        public virtual string Country {
            get {
                return this.mCountry;
            }
            set {
                this.mCountry = value;
                this.EntityState.FieldChange("Country");
            }
        }
        
        [Column()]
        public virtual string Phone {
            get {
                return this.mPhone;
            }
            set {
                this.mPhone = value;
                this.EntityState.FieldChange("Phone");
            }
        }
        
        [Column()]
        public virtual string Fax {
            get {
                return this.mFax;
            }
            set {
                this.mFax = value;
                this.EntityState.FieldChange("Fax");
            }
        }
    }
}
