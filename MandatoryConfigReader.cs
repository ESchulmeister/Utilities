using System.Configuration;

namespace Utilities
{
    public class MandatoryConfigReader : ConfigReader
    {
        #region Fields
        private static readonly MandatoryConfigReader s_oMandatoryConfigReader = new MandatoryConfigReader();
        #endregion

        #region Properties
        internal protected static MandatoryConfigReader Current
        {
            get
            {
                return s_oMandatoryConfigReader;
            }
        }

        #endregion

        #region Methods
        protected override string HandleMissingEntry(string sKey, string sDefault = "") => throw new ConfigurationErrorsException(String.Format("Entry '{0}' not found", sKey));
        #endregion
    }
}
