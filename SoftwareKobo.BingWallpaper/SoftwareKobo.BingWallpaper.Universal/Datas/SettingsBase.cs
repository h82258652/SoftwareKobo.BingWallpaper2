using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using Windows.Foundation.Collections;
using Windows.Storage;

namespace SoftwareKobo.BingWallpaper.Datas
{
    public abstract class SettingsBase : INotifyPropertyChanged
    {
        private readonly IPropertySet _localSettings = ApplicationData.Current.LocalSettings.Values;

        private readonly IPropertySet _roamingSettings = ApplicationData.Current.RoamingSettings.Values;

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void AddOrUpdate<T>(string key, T value, bool isRoaming = false)
        {
            Debug.Assert(string.IsNullOrEmpty(key) == false);

            #region 将枚举转换为整型

            object oValue;
            if (value is Enum)
            {
                var underlyingType = Enum.GetUnderlyingType(typeof(T));
                oValue = Convert.ChangeType(value, underlyingType);
            }
            else
            {
                oValue = value;
            }

            #endregion 将枚举转换为整型

            IPropertySet settingsLocation = isRoaming ? _roamingSettings : _localSettings;

            lock (settingsLocation)
            {
                settingsLocation[key] = oValue;
            }

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(key));
            }
        }

        public virtual T Get<T>(string key, T defaultValue, bool isRoaming = false)
        {
            Debug.Assert(string.IsNullOrEmpty(key) == false);

            IPropertySet settingsLocation = isRoaming ? _roamingSettings : _localSettings;

            lock (settingsLocation)
            {
                object value;
                if (settingsLocation.TryGetValue(key, out value))
                {
                    if (typeof(T).GetTypeInfo().IsEnum)
                    {
                        return (T)Enum.Parse(typeof(T), value.ToString());
                    }
                    else
                    {
                        return (T)value;
                    }
                }
                else
                {
                    return defaultValue;
                }
            }
        }

        public virtual T Get<T>(string key, bool isRoaming = false) where T : class
        {
            return Get<T>(key, null, isRoaming);
        }
    }
}