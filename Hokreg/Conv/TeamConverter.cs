﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Uniso.InStat.Game
{
    public class TeamConverter : TypeConverter
    {
        List<int> _keys = new List<int>();
        List<String> _values = new List<String>();

        public TeamConverter()
        {
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }

            return base.CanConvertFrom(context, sourceType);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                return true;
            }

            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            GetValues(context);

            int i;
            if (value is string)
            {
                var str = ((string)value).ToLower();
                for (i = 0; i < _values.Count; ++i)
                {
                    if (_values[i].ToLower() == str)
                        return _keys[i];
                }

                throw new ArgumentException();
            }

            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            GetValues(context);

            int i;
            if ((destinationType == typeof(string)) && (_values.Count > 0))
            {
                if (value == null)
                    return _values[0];
                if (value is int)
                {
                    for (i = 1; i < _keys.Count; ++i)
                    {
                        if (_keys[i].Equals(value))
                            return _values[i];
                    }
                }
                else
                    throw new Exception();
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            GetValues(context);

            return new StandardValuesCollection(_keys);
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true;
        }

        private Match oldMatch = null;
        private static Match newMatch = null;

        public static void RefreshData(Match match)
        {
            newMatch = match;
        }

        public void GetValues(ITypeDescriptorContext context)
        {
            if (newMatch != oldMatch && _values.Count == 0)
            {
                _keys.Clear();
                _values.Clear();

                oldMatch = newMatch;

                _keys.Add(0);
                _values.Add("-- НЕТ КОМАНДЫ --");

                FillData(newMatch.Team1);
                FillData(newMatch.Team2);
            }
        }

        private void FillData(Uniso.InStat.Team tm)
        {
            _keys.Add(tm.Id);
            _values.Add(tm.Name);
        }
    }

}
