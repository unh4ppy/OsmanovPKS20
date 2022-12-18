using System;
using System.Collections.Generic;
using System.Text;

namespace ConverterLib1._1
{
    interface IValue
    {
        #region Методы для API
        double GetConvertedValue(double value, string from, string to);
        List<string> GetMeassureList();
        #endregion

        void ToSi();
        void ToRequired();
    }
}
