﻿using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace DialogServiceExample.ViewModels {
    public class MainViewModel {
        IDialogService DialogService {
            get {
                return this.GetService<IDialogService>();
            }
        }
        public virtual MessageResult Result { get; set; }

        protected MainViewModel() { }

        public static MainViewModel Create() {
            return ViewModelSource.Create(() => new MainViewModel());
        }
        public void ShowDialog() {
            Result = DialogService.ShowDialog(dialogButtons: MessageButton.YesNoCancel, title: "Simple Dialog", viewModel: SimpleDialogViewModel.Create());            
        }
    }
}
