﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NavigationMasterDetail.Views
{
    public partial class ListarVolchers : ContentPage
    {
        public ListarVolchers()
        {

            InitializeComponent();
            this.BindingContext = new ViewModels.ListarVolchersViewModel();
           
        }
    }
}
