using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Izzy.Mobile.Models;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace Izzy.Mobile.Helpers
{
    public class Settings
    {
        private static readonly Lazy<Settings> SettingsInstance = new Lazy<Settings>(() => new Settings());
        public static Settings Current => SettingsInstance.Value;

        private Settings() { }

        private static ISettings AppSettings => CrossSettings.Current;

        public string UserId
        {
            get => AppSettings.GetValueOrDefault(nameof(UserId), default(string));
            set => AppSettings.AddOrUpdateValue(nameof(UserId), value);
        }

        public string UserToken
        {
            get => AppSettings.GetValueOrDefault(nameof(UserToken), default(string));
            set => AppSettings.AddOrUpdateValue(nameof(UserToken), value);
        }

        //public User User
        //{
        //    get => AppSettings.GetValueOrDefault(nameof(User), default(string));
        //    set => AppSettings.AddOrUpdateValue(nameof(User), JSovalue);
        //}
    }
}
