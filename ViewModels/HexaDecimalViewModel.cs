using ColorSelectorApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColorSelectorApp.ViewModels
{
    public class HexaDecimalViewModel : INotifyPropertyChanged
    {
        private HexaDetails _hexaDetails = new HexaDetails();

        private string _hexValue;

        public string HexValue
        {
            get
            {
                return _hexValue;
            }
            set
            {
                _hexValue = value;

                if (_hexValue.Length <= 5)
                {
                    Validations = "";
                    HexResult = "#3BAFDA";
                    return;
                }
                if (_hexValue.Length > 6)
                {
                    _hexValue = _hexValue.Remove(_hexValue.Length - 1);
                }

                HexResult = "#" + _hexValue;

                Regex hexRegex = new Regex("^#(([0-9a-fA-F]{2}){3}|([0-9a-fA-F]){3})$");

                if (!hexRegex.IsMatch(HexResult))
                {
                    Validations = "No colors found";
                    HexResult = "#3BAFDA";
                }
                else
                {
                    Validations = "";
                }

                OnPropertyChanged();
            }
        }

        private string _hexResult;

        public string HexResult
        {
            get
            {
                if (_hexResult == "" || _hexResult == null)
                {
                    _hexResult = "#3BAFDA";
                }
                
                return _hexResult;
            }
            set
            {
                _hexResult = value;
                OnPropertyChanged();
            }
        }

        private string _validations;

        public string Validations
        {
            get
            {
                if (_validations == null)
                {
                    _validations = "";
                }

                return _validations;
            }
            set
            {
                _validations = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
