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

namespace QLMAMNON.BLL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="truongmamnon")]
	public partial class dbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserthocsinh(hocsinh instance);
    partial void Updatehocsinh(hocsinh instance);
    partial void Deletehocsinh(hocsinh instance);
    partial void Insertnhanvien(nhanvien instance);
    partial void Updatenhanvien(nhanvien instance);
    partial void Deletenhanvien(nhanvien instance);
    #endregion
		
		public dbDataContext() : 
				base(global::QLMAMNON.Properties.Settings.Default.truongmamnonConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<hocsinh> hocsinhs
		{
			get
			{
				return this.GetTable<hocsinh>();
			}
		}
		
		public System.Data.Linq.Table<nhanvien> nhanviens
		{
			get
			{
				return this.GetTable<nhanvien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.hocsinh")]
	public partial class hocsinh : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _mahs;
		
		private string _hotenhs;
		
		private string _gioitinh;
		
		private System.Nullable<System.DateTime> _ngaysinh;
		
		private string _dantoc;
		
		private string _hotenbo;
		
		private string _sdtbo;
		
		private string _hotenme;
		
		private string _sdtme;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmahsChanging(string value);
    partial void OnmahsChanged();
    partial void OnhotenhsChanging(string value);
    partial void OnhotenhsChanged();
    partial void OngioitinhChanging(string value);
    partial void OngioitinhChanged();
    partial void OnngaysinhChanging(System.Nullable<System.DateTime> value);
    partial void OnngaysinhChanged();
    partial void OndantocChanging(string value);
    partial void OndantocChanged();
    partial void OnhotenboChanging(string value);
    partial void OnhotenboChanged();
    partial void OnsdtboChanging(string value);
    partial void OnsdtboChanged();
    partial void OnhotenmeChanging(string value);
    partial void OnhotenmeChanged();
    partial void OnsdtmeChanging(string value);
    partial void OnsdtmeChanged();
    #endregion
		
		public hocsinh()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mahs", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string mahs
		{
			get
			{
				return this._mahs;
			}
			set
			{
				if ((this._mahs != value))
				{
					this.OnmahsChanging(value);
					this.SendPropertyChanging();
					this._mahs = value;
					this.SendPropertyChanged("mahs");
					this.OnmahsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hotenhs", DbType="NVarChar(30)")]
		public string hotenhs
		{
			get
			{
				return this._hotenhs;
			}
			set
			{
				if ((this._hotenhs != value))
				{
					this.OnhotenhsChanging(value);
					this.SendPropertyChanging();
					this._hotenhs = value;
					this.SendPropertyChanged("hotenhs");
					this.OnhotenhsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gioitinh", DbType="NVarChar(10)")]
		public string gioitinh
		{
			get
			{
				return this._gioitinh;
			}
			set
			{
				if ((this._gioitinh != value))
				{
					this.OngioitinhChanging(value);
					this.SendPropertyChanging();
					this._gioitinh = value;
					this.SendPropertyChanged("gioitinh");
					this.OngioitinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaysinh", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> ngaysinh
		{
			get
			{
				return this._ngaysinh;
			}
			set
			{
				if ((this._ngaysinh != value))
				{
					this.OnngaysinhChanging(value);
					this.SendPropertyChanging();
					this._ngaysinh = value;
					this.SendPropertyChanged("ngaysinh");
					this.OnngaysinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dantoc", DbType="NVarChar(20)")]
		public string dantoc
		{
			get
			{
				return this._dantoc;
			}
			set
			{
				if ((this._dantoc != value))
				{
					this.OndantocChanging(value);
					this.SendPropertyChanging();
					this._dantoc = value;
					this.SendPropertyChanged("dantoc");
					this.OndantocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hotenbo", DbType="NVarChar(30)")]
		public string hotenbo
		{
			get
			{
				return this._hotenbo;
			}
			set
			{
				if ((this._hotenbo != value))
				{
					this.OnhotenboChanging(value);
					this.SendPropertyChanging();
					this._hotenbo = value;
					this.SendPropertyChanged("hotenbo");
					this.OnhotenboChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sdtbo", DbType="NVarChar(20)")]
		public string sdtbo
		{
			get
			{
				return this._sdtbo;
			}
			set
			{
				if ((this._sdtbo != value))
				{
					this.OnsdtboChanging(value);
					this.SendPropertyChanging();
					this._sdtbo = value;
					this.SendPropertyChanged("sdtbo");
					this.OnsdtboChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hotenme", DbType="NVarChar(30)")]
		public string hotenme
		{
			get
			{
				return this._hotenme;
			}
			set
			{
				if ((this._hotenme != value))
				{
					this.OnhotenmeChanging(value);
					this.SendPropertyChanging();
					this._hotenme = value;
					this.SendPropertyChanged("hotenme");
					this.OnhotenmeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sdtme", DbType="NVarChar(20)")]
		public string sdtme
		{
			get
			{
				return this._sdtme;
			}
			set
			{
				if ((this._sdtme != value))
				{
					this.OnsdtmeChanging(value);
					this.SendPropertyChanging();
					this._sdtme = value;
					this.SendPropertyChanged("sdtme");
					this.OnsdtmeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.nhanvien")]
	public partial class nhanvien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _manv;
		
		private string _hotennv;
		
		private string _gioitinh;
		
		private System.Nullable<System.DateTime> _ngaysinh;
		
		private string _chucvu;
		
		private string _chungminhthu;
		
		private string _dantoc;
		
		private string _sodienthoai;
		
		private string _diachi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmanvChanging(string value);
    partial void OnmanvChanged();
    partial void OnhotennvChanging(string value);
    partial void OnhotennvChanged();
    partial void OngioitinhChanging(string value);
    partial void OngioitinhChanged();
    partial void OnngaysinhChanging(System.Nullable<System.DateTime> value);
    partial void OnngaysinhChanged();
    partial void OnchucvuChanging(string value);
    partial void OnchucvuChanged();
    partial void OnchungminhthuChanging(string value);
    partial void OnchungminhthuChanged();
    partial void OndantocChanging(string value);
    partial void OndantocChanged();
    partial void OnsodienthoaiChanging(string value);
    partial void OnsodienthoaiChanged();
    partial void OndiachiChanging(string value);
    partial void OndiachiChanged();
    #endregion
		
		public nhanvien()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_manv", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string manv
		{
			get
			{
				return this._manv;
			}
			set
			{
				if ((this._manv != value))
				{
					this.OnmanvChanging(value);
					this.SendPropertyChanging();
					this._manv = value;
					this.SendPropertyChanged("manv");
					this.OnmanvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hotennv", DbType="NVarChar(30)")]
		public string hotennv
		{
			get
			{
				return this._hotennv;
			}
			set
			{
				if ((this._hotennv != value))
				{
					this.OnhotennvChanging(value);
					this.SendPropertyChanging();
					this._hotennv = value;
					this.SendPropertyChanged("hotennv");
					this.OnhotennvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gioitinh", DbType="NVarChar(10)")]
		public string gioitinh
		{
			get
			{
				return this._gioitinh;
			}
			set
			{
				if ((this._gioitinh != value))
				{
					this.OngioitinhChanging(value);
					this.SendPropertyChanging();
					this._gioitinh = value;
					this.SendPropertyChanged("gioitinh");
					this.OngioitinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaysinh", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> ngaysinh
		{
			get
			{
				return this._ngaysinh;
			}
			set
			{
				if ((this._ngaysinh != value))
				{
					this.OnngaysinhChanging(value);
					this.SendPropertyChanging();
					this._ngaysinh = value;
					this.SendPropertyChanged("ngaysinh");
					this.OnngaysinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_chucvu", DbType="NVarChar(20)")]
		public string chucvu
		{
			get
			{
				return this._chucvu;
			}
			set
			{
				if ((this._chucvu != value))
				{
					this.OnchucvuChanging(value);
					this.SendPropertyChanging();
					this._chucvu = value;
					this.SendPropertyChanged("chucvu");
					this.OnchucvuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_chungminhthu", DbType="NVarChar(20)")]
		public string chungminhthu
		{
			get
			{
				return this._chungminhthu;
			}
			set
			{
				if ((this._chungminhthu != value))
				{
					this.OnchungminhthuChanging(value);
					this.SendPropertyChanging();
					this._chungminhthu = value;
					this.SendPropertyChanged("chungminhthu");
					this.OnchungminhthuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dantoc", DbType="NVarChar(20)")]
		public string dantoc
		{
			get
			{
				return this._dantoc;
			}
			set
			{
				if ((this._dantoc != value))
				{
					this.OndantocChanging(value);
					this.SendPropertyChanging();
					this._dantoc = value;
					this.SendPropertyChanged("dantoc");
					this.OndantocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sodienthoai", DbType="NVarChar(20)")]
		public string sodienthoai
		{
			get
			{
				return this._sodienthoai;
			}
			set
			{
				if ((this._sodienthoai != value))
				{
					this.OnsodienthoaiChanging(value);
					this.SendPropertyChanging();
					this._sodienthoai = value;
					this.SendPropertyChanged("sodienthoai");
					this.OnsodienthoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diachi", DbType="NVarChar(50)")]
		public string diachi
		{
			get
			{
				return this._diachi;
			}
			set
			{
				if ((this._diachi != value))
				{
					this.OndiachiChanging(value);
					this.SendPropertyChanging();
					this._diachi = value;
					this.SendPropertyChanged("diachi");
					this.OndiachiChanged();
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
