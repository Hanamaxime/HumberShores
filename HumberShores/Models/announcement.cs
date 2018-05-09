//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
namespace HumberShores.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class announcement
    {
        public int ann_id { get; set; }
        public string ann_text { get; set; }

		private DateTime _ann_date = DateTime.Now;
		[Display(Name = "Date Posted/Last Update")]
		[Required(ErrorMessage = "The announcement's date must be entered.")]
		[DataType(DataType.DateTime)]
		public DateTime ann_date
		{
			get
			{
				return (_ann_date == DateTime.Now) ? DateTime.Now : _ann_date;
			}
			set
			{
				_ann_date = value;
			}
		}

		public string ann_severity { get; set; }
		public bool ann_visible { get; set; } = true;
        public int emp_id { get; set; }
    
        public virtual site_users site_users { get; set; }
        public virtual employee employee { get; set; }
    }
}
