using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Nokia3310
{
    class ConfManager
    {
        #region Logic
        public int GetValue(String paramName)
        {
            return Convert.ToInt32(ConfigurationManager.AppSettings[paramName]);
        }

        public string GetValueString(String paramName)
        {
            return ConfigurationManager.AppSettings[paramName].ToString();
        }

        public void SetStringParam(String paramName, int value)
        {
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath);
            config.AppSettings.Settings[paramName].Value = value.ToString();
            config.Save(ConfigurationSaveMode.Modified);
        }

        public void SetStringParam(String paramName, string value)
        {
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath);
            config.AppSettings.Settings[paramName].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
        }
        #endregion
    }
}