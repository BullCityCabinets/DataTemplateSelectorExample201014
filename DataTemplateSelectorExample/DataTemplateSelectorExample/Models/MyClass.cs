using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DataTemplateSelectorExample.Models
{
    public class MyClass : BindableBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Icon { get; set; }

        public MyClass( int Id, string Name, string Desc, string Icon)
        {
            this.Id = Id;
            this.Name = Name;
            this.Desc = Desc;
            this.Icon = Icon;
        }
    }
}


