﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://ITdos.com/Dos/ORM/Index.html
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Dos.ORM;

namespace ClientUser.Model
{
    /// <summary>
    /// 实体类User。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("User")]
    [Serializable]
    public partial class User : Entity
    {
        #region Model
        private int _ID;
        private int _UserId;
        private string _Name;
        private string _Sex;
        private string _Password;
        private string _PasswordTow;
        private string _Data;

        /// <summary>
        /// 
        /// </summary>
        [Field("ID")]
        public int ID
        {
            get { return _ID; }
            set
            {
                this.OnPropertyValueChange("ID");
                this._ID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("UserId")]
        public int UserId
        {
            get { return _UserId; }
            set
            {
                this.OnPropertyValueChange("UserId");
                this._UserId = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Name")]
        public string Name
        {
            get { return _Name; }
            set
            {
                this.OnPropertyValueChange("Name");
                this._Name = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Sex")]
        public string Sex
        {
            get { return _Sex; }
            set
            {
                this.OnPropertyValueChange("Sex");
                this._Sex = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Password")]
        public string Password
        {
            get { return _Password; }
            set
            {
                this.OnPropertyValueChange("Password");
                this._Password = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("PasswordTow")]
        public string PasswordTow
        {
            get { return _PasswordTow; }
            set
            {
                this.OnPropertyValueChange("PasswordTow");
                this._PasswordTow = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Data")]
        public string Data
        {
            get { return _Data; }
            set
            {
                this.OnPropertyValueChange("Data");
                this._Data = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.ID,
			};
        }
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        public override Field GetIdentityField()
        {
            return _.ID;
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.UserId,
				_.Name,
				_.Sex,
				_.Password,
				_.PasswordTow,
				_.Data,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._UserId,
				this._Name,
				this._Sex,
				this._Password,
				this._PasswordTow,
				this._Data,
			};
        }
        /// <summary>
        /// 是否是v1.10.5.6及以上版本实体。
        /// </summary>
        /// <returns></returns>
        public override bool V1_10_5_6_Plus()
        {
            return true;
        }
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// * 
            /// </summary>
            public readonly static Field All = new Field("*", "User");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ID = new Field("ID", "User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UserId = new Field("UserId", "User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Name = new Field("Name", "User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Sex = new Field("Sex", "User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Password = new Field("Password", "User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PasswordTow = new Field("PasswordTow", "User", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Data = new Field("Data", "User", "");
        }
        #endregion
    }
}