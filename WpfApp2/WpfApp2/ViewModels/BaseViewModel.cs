﻿using WpfApp2.Helpers;
using WpfApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.ViewModels
{
    class BaseViewModel : ChangeNotifier, IChangeViewModel
    {
        IChangeViewModel _viewModelChanger;

        public BaseViewModel(IChangeViewModel viewModelChanger)
        {
            ViewModelChanger = viewModelChanger;
        }

        public IChangeViewModel ViewModelChanger
        {
            get { return _viewModelChanger; }
            set { _viewModelChanger = value; }
        }

        #region IChangeViewModel

        public void PopViewModel()
        {
            _viewModelChanger?.PopViewModel();
        }

        public void PushViewModel(BaseViewModel model)
        {
            _viewModelChanger?.PushViewModel(model);
        }

        #endregion
    }
}
