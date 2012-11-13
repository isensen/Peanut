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
    [Table("Products")]
    public partial class Product : Smark.Data.Mappings.DataObject, IProduct {
        
        private int mProductID;
        
        /// <summary>
        /// System.Int32
        /// </summary>
        public static Smark.Data.FieldInfo productID = new Smark.Data.FieldInfo("Products", "ProductID");
        
        private string mProductName;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo productName = new Smark.Data.FieldInfo("Products", "ProductName");
        
        private int mSupplierID;
        
        /// <summary>
        /// System.Int32
        /// </summary>
        public static Smark.Data.FieldInfo supplierID = new Smark.Data.FieldInfo("Products", "SupplierID");
        
        private int mCategoryID;
        
        /// <summary>
        /// System.Int32
        /// </summary>
        public static Smark.Data.FieldInfo categoryID = new Smark.Data.FieldInfo("Products", "CategoryID");
        
        private string mQuantityPerUnit;
        
        /// <summary>
        /// System.String
        /// </summary>
        public static Smark.Data.FieldInfo quantityPerUnit = new Smark.Data.FieldInfo("Products", "QuantityPerUnit");
        
        private decimal mUnitPrice;
        
        /// <summary>
        /// System.Decimal
        /// </summary>
        public static Smark.Data.FieldInfo unitPrice = new Smark.Data.FieldInfo("Products", "UnitPrice");
        
        private int mUnitsInStock;
        
        /// <summary>
        /// System.Int32
        /// </summary>
        public static Smark.Data.FieldInfo unitsInStock = new Smark.Data.FieldInfo("Products", "UnitsInStock");
        
        private int mUnitsOnOrder;
        
        /// <summary>
        /// System.Int32
        /// </summary>
        public static Smark.Data.FieldInfo unitsOnOrder = new Smark.Data.FieldInfo("Products", "UnitsOnOrder");
        
        private int mReorderLevel;
        
        /// <summary>
        /// System.Int32
        /// </summary>
        public static Smark.Data.FieldInfo reorderLevel = new Smark.Data.FieldInfo("Products", "ReorderLevel");
        
        private bool mDiscontinued;
        
        /// <summary>
        /// System.Boolean
        /// </summary>
        public static Smark.Data.FieldInfo discontinued = new Smark.Data.FieldInfo("Products", "Discontinued");
        
        [ID()]
        [IDENTITY()]
        public virtual int ProductID {
            get {
                return this.mProductID;
            }
            set {
                this.mProductID = value;
                this.EntityState.FieldChange("ProductID");
            }
        }
        
        [Column()]
        public virtual string ProductName {
            get {
                return this.mProductName;
            }
            set {
                this.mProductName = value;
                this.EntityState.FieldChange("ProductName");
            }
        }
        
        [Column()]
        public virtual int SupplierID {
            get {
                return this.mSupplierID;
            }
            set {
                this.mSupplierID = value;
                this.EntityState.FieldChange("SupplierID");
            }
        }
        
        [Column()]
        public virtual int CategoryID {
            get {
                return this.mCategoryID;
            }
            set {
                this.mCategoryID = value;
                this.EntityState.FieldChange("CategoryID");
            }
        }
        
        [Column()]
        public virtual string QuantityPerUnit {
            get {
                return this.mQuantityPerUnit;
            }
            set {
                this.mQuantityPerUnit = value;
                this.EntityState.FieldChange("QuantityPerUnit");
            }
        }
        
        [Column()]
        public virtual decimal UnitPrice {
            get {
                return this.mUnitPrice;
            }
            set {
                this.mUnitPrice = value;
                this.EntityState.FieldChange("UnitPrice");
            }
        }
        
        [Column()]
        public virtual int UnitsInStock {
            get {
                return this.mUnitsInStock;
            }
            set {
                this.mUnitsInStock = value;
                this.EntityState.FieldChange("UnitsInStock");
            }
        }
        
        [Column()]
        public virtual int UnitsOnOrder {
            get {
                return this.mUnitsOnOrder;
            }
            set {
                this.mUnitsOnOrder = value;
                this.EntityState.FieldChange("UnitsOnOrder");
            }
        }
        
        [Column()]
        public virtual int ReorderLevel {
            get {
                return this.mReorderLevel;
            }
            set {
                this.mReorderLevel = value;
                this.EntityState.FieldChange("ReorderLevel");
            }
        }
        
        [Column()]
        public virtual bool Discontinued {
            get {
                return this.mDiscontinued;
            }
            set {
                this.mDiscontinued = value;
                this.EntityState.FieldChange("Discontinued");
            }
        }
    }
}