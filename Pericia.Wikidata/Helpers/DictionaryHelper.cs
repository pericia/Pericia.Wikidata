namespace System.Collections.Generic
{
    public static class DictionaryHelper
    {
        public static T? FindAnyKey<T>(this Dictionary<string, T> dictionary, params string[] keys)
            where T : class
        {
            foreach (var key in keys)
            {
                if (dictionary.ContainsKey(key))
                {
                    return dictionary[key];
                }
            }

            return null;
        }
    }
}
