using System;
using System.Collections.Generic;
using System.Text;

namespace ConverterLib1._1.Values
{
    class Weight : IValue
    {
        private double _value;
        private string _from;
        private string _to;
        private List<string> _measureList = new List<string>()
        {
            "Граммы",
            "Килограммы",
            "Тонны",
        };
        public double GetConvertedValue(double value, string from, string to)
        {
            _value = value;
            _from = from;
            _to = to;
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
                case "Граммы":
                    _value *= 100;
                    break;
                case "Килограммы":
                    _value *= 1;
                    break;
                case "Тонны":
                    _value /= 1000;
                    break;
            }
        }

        public void ToSi()
        {
            switch (_from)
            {
                case "Граммы":
                    _value /= 100;
                    break;
                case "Килограммы":
                    _value *= 1;
                    break;
                case "Тонны":
                    _value *= 1000;
                    break;
            }
        }
    }
}
