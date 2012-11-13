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
    [Table("Employees")]
    public partial class Employee : Smark.Data.Mappings.DataObject, IEmployee {
        
        private int mEmployeeID;
        
        /// <summary>
        /// System.Int32
        /// </summary>
        public static Smark.Data.FieldInfo employeeID = new Smark.Data.FieldInfo("Employees", "EmployeeID");
        
        private string mLastName;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo lastName = new Smark.Data.FieldInfo("Employees", "LastName");
        
        private string mFirstName;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo firstName = new Smark.Data.FieldInfo("Employees", "FirstName");
        
        private string mTitle;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo title = new Smark.Data.FieldInfo("Employees", "Title");
        
        private string mTitleOfCourtesy;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo titleOfCourtesy = new Smark.Data.FieldInfo("Employees", "TitleOfCourtesy");
        
        private DateTime mBirthDate;
        
        /// <summary>
        /// DateTime
        /// </summary>
        public static Smark.Data.FieldInfo birthDate = new Smark.Data.FieldInfo("Employees", "BirthDate");
        
        private DateTime mHireDate;
        
        /// <summary>
        /// DateTime
        /// </summary>
        public static Smark.Data.FieldInfo hireDate = new Smark.Data.FieldInfo("Employees", "HireDate");
        
        private string mAddress;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo address = new Smark.Data.FieldInfo("Employees", "Address");
        
        private string mCity;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo city = new Smark.Data.FieldInfo("Employees", "City");
        
        private string mRegion;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo region = new Smark.Data.FieldInfo("Employees", "Region");
        
        private string mPostalCode;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo postalCode = new Smark.Data.FieldInfo("Employees", "PostalCode");
        
        private string mCountry;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo country = new Smark.Data.FieldInfo("Employees", "Country");
        
        private string mHomePhone;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo homePhone = new Smark.Data.FieldInfo("Employees", "HomePhone");
        
        private string mExtension;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo extension = new Smark.Data.FieldInfo("Employees", "Extension");
        
        private string mPhoto;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo photo = new Smark.Data.FieldInfo("Employees", "Photo");
        
        private string mNotes;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo notes = new Smark.Data.FieldInfo("Employees", "Notes");
        
        private int mReportsTo;
        
        /// <summary>
        /// System.Int32
        /// </summary>
        public static Smark.Data.FieldInfo reportsTo = new Smark.Data.FieldInfo("Employees", "ReportsTo");
        
        [ID()]
        [IDENTITY()]
        public virtual int EmployeeID {
            get {
                return this.mEmployeeID;
            }
            set {
                this.mEmployeeID = value;
                this.EntityState.FieldChange("EmployeeID");
            }
        }
        
        [Column()]
        public virtual string LastName {
            get {
                return this.mLastName;
            }
            set {
                this.mLastName = value;
                this.EntityState.FieldChange("LastName");
            }
        }
        
        [Column()]
        public virtual string FirstName {
            get {
                return this.mFirstName;
            }
            set {
                this.mFirstName = value;
                this.EntityState.FieldChange("FirstName");
            }
        }
        
        [Column()]
        public virtual string Title {
            get {
                return this.mTitle;
            }
            set {
                this.mTitle = value;
                this.EntityState.FieldChange("Title");
            }
        }
        
        [Column()]
        public virtual string TitleOfCourtesy {
            get {
                return this.mTitleOfCourtesy;
            }
            set {
                this.mTitleOfCourtesy = value;
                this.EntityState.FieldChange("TitleOfCourtesy");
            }
        }
        
        [Column()]
        public virtual DateTime BirthDate {
            get {
                return this.mBirthDate;
            }
            set {
                this.mBirthDate = value;
                this.EntityState.FieldChange("BirthDate");
            }
        }
        
        [Column()]
        public virtual DateTime HireDate {
            get {
                return this.mHireDate;
            }
            set {
                this.mHireDate = value;
                this.EntityState.FieldChange("HireDate");
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
        public virtual string HomePhone {
            get {
                return this.mHomePhone;
            }
            set {
                this.mHomePhone = value;
                this.EntityState.FieldChange("HomePhone");
            }
        }
        
        [Column()]
        public virtual string Extension {
            get {
                return this.mExtension;
            }
            set {
                this.mExtension = value;
                this.EntityState.FieldChange("Extension");
            }
        }
        
        [Column()]
        public virtual string Photo {
            get {
                return this.mPhoto;
            }
            set {
                this.mPhoto = value;
                this.EntityState.FieldChange("Photo");
            }
        }
        
        [Column()]
        public virtual string Notes {
            get {
                return this.mNotes;
            }
            set {
                this.mNotes = value;
                this.EntityState.FieldChange("Notes");
            }
        }
        
        [Column()]
        public virtual int ReportsTo {
            get {
                return this.mReportsTo;
            }
            set {
                this.mReportsTo = value;
                this.EntityState.FieldChange("ReportsTo");
            }
        }
    }
}