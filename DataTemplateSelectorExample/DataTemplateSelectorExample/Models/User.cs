using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace DataTemplateSelectorExample.Models
{
    public class User : BindableBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public SomeEnum MyPref {get; set;}

        public User( int Id, string Name, string Email, SomeEnum MyPref)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.MyPref = MyPref;
        }
    }

    public enum SomeEnum
    {
        ILikeDT1 = 1,
        ILikeDT2 = 2
    }

}
