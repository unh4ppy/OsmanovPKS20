using ConverterLib1._1.Values;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConverterLib1._1
{
    public class Converter
    {
        private List<string> _physicValues = new List<string>()
        {
            "Время",
            "Масса",
            "Скорость"
        };
        public List<string> GetPhysicValuesList()
        {
            return _physicValues;
        }
        public List<string> GetMeasureList(string physicValue)
        {
            switch (physicValue)
            {
                case "Время":
                    _value = new Time();
                    break;
                case "Масса":
                    _value = new Weight();
                    break;
                case "Скорость":
                    _value = new Speed();
                    break;
            }
            return _value.GetMeassureList();
        }
        private IValue _value;
        private string _physicValue;
        public double GetConvertedValue(string physicValue, double value, string from, string to)
        {
            _physicValue = physicValue;
            switch (physicValue)
            {
                case "Время":
                    _value = new Time();
                    break;
                case "Масса":
                    _value = new Weight();
                    break;
                case "Скорость":
                    _value = new Speed();
                    break;
            }
            return _value.GetConvertedValue(value, from, to);
        }
    }
}
