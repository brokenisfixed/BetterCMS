using System.Configuration;

namespace BetterCms.Configuration
{
    public class UrlPatternsCollection : ConfigurationElementCollection
    {
        #region Indexers

        public PatternElement this[int index]
        {
            get
            {
                return (PatternElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        #endregion

        #region Overrides

        protected override ConfigurationElement CreateNewElement()
        {
            return new PatternElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return element;
        }

        #endregion
    }
}