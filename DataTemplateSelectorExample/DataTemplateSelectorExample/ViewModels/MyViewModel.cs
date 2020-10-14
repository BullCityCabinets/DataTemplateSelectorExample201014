using DataTemplateSelectorExample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace DataTemplateSelectorExample.ViewModels
{
    public class MyViewModel
    {
        public User UserA { get; set; }

        ObservableCollection<MyClass> MyClasses = new ObservableCollection<MyClass>();
                


        public MyViewModel()
        {
            
                    
            MyClasses.Add(new MyClass(1, "Math Class", "Gets Results!", "Poultry.png"));
            MyClasses.Add(new MyClass(2, "Engrish Crass", "Gweat Wead!", "Eggs.png"));
            MyClasses.Add(new MyClass(3, "Study Hall", "shhhhh!", "Poultry.png"));
            MyClasses.Add(new MyClass(4, "Lunch", "Yum!", "Eggs.png"));
            MyClasses.Add(new MyClass(5, "P.E.", "Ruuuun!", "Poultry.png"));
        }


    }
}
