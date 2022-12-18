using System;
using System.Collections.Generic;
using System.Text;

namespace ConverterLib1._1.Values
{
    class Time : IValue
    {
        private double _value;
        private string _from;
        private string _to;
        private List<string> _measureList = new List<string>()
        {
            "Секунды",
            "Минуты",
            "Часы",
            "Милисекунды",
        };
        public double GetConvertedValue(double value, string from, string to)
        {
            _value = value;
            ToSi();
            


            return 0;
        }

        public List<string> GetMeassureList()
        {
            return _measureList;
        }

        public void ToSi()
        {
            switch (_from)
            {
                case "Минуты":
                    _value /= 60;
                    break;
                case "Секунды":
                    break;
                case "Часы":
                    _value /= 3600;
                    break;
                case "Милисекунды":
                    _value /= 100;
                    break;
            }
        }

        void IValue.ToRequired()
        {
            switch (_to)
            {
                case "Минуты":
                    _value *= 60;
                    break;
                case "Секунды":
                    break;
                case "Часы":
                    _value *= 3600;
                    break;
                case "Милисекунды":
                    _value *= 100;
                    break;

            }
        }
    }
}
