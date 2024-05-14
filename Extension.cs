namespace Utilities
{
    public static class Extension
    {
        #region Methods
        public static bool IsOneOf(this string sArg, params string[] aValues)
        {
            if(aValues == null)
            {
                return false;
            }

            return aValues.Any(sValue => (String.Compare(sValue, sArg, true) == 0));
        }

        public static bool ToBoolean(this string sArg, bool bDefault)
        {
            if(sArg.IsOneOf("y", "yes", "true"))
            {
                return true;
            }

            if (sArg.IsOneOf("n", "no", "false"))
            {
                return false;
            }

            bool bResult = false; // has to be something
            if(!bool.TryParse(sArg, out bResult))
            {
                bResult = bDefault;
            }

            return bResult;
        }
        #endregion
    }
}
