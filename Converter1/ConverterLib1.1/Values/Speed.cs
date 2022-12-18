using System;
using System.Collections.Generic;
using System.Text;

namespace ConverterLib1._1.Values
{
    class Speed : IValue
    {
        private double _value;
        private string _from;
        private string _to;
        private List<string> _measureList = new List<string>()
        {
            "Метры в секунду",
            "Километры в час",
        };
        public double GetConvertedValue(double value, string from, string to)
        {
            _value = value;
            ToSi();
            ToRequired();
            return _value;
        }

        public List<string> GetMeassureList()
        {
            return _measureList;
        }

        public void ToRequired()
        {
            switch (_to)
            {
                case "Метры в секунду":
                    _value /= 1;
                    break;
                case "километры в час":
                    _value *= 3.6;
                    break;
            }
        }

        public void ToSi()
        {
            switch (_from)
            {
                case "Метры в секунду":
                    _value /= 1;
                    break;
                case "километры в час":
                    _value /= 3.6;
                    break;
            }
        }
    }
}
