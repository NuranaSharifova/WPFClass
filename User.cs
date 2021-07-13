using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    class User: INotifyPropertyChanged
    {
        
        private string loginName;
        private int password;
        public string LoginName {
            get => loginName;
            set {
                if (!Equals(this.loginName,value)) {
                    this.loginName = value;
                    OnChange(new PropertyChangedEventArgs(nameof(LoginName)));
                }
            }
        }
        public int Password {
            get => password;

            set {
                if (!this.password.Equals(value))
                {
                    this.password = value;
               
                    OnChange(new PropertyChangedEventArgs(nameof(Password)));
                }
            }
          }
       

        public event PropertyChangedEventHandler PropertyChanged;
        void OnChange(PropertyChangedEventArgs e)
        {

            PropertyChanged?.Invoke(this, e);
        }
    }
}
