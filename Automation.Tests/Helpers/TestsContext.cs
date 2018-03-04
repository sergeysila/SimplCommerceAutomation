using NUnit.Framework;

namespace Automation.Tests.Helpers
{
    public static class TestsContext
    {
        private static TestContext CurrentContext
            => TestContext.CurrentContext;

        public static void Add<T>(string key, T value, bool replace = false)
        {
            if (!CurrentContext.Test.Properties.ContainsKey(key) || replace)
                CurrentContext.Test.Properties.Add(key, value);
        }

        public static T TryGet<T>(string key) where T : class
        {
            if (CurrentContext.Test.Properties.ContainsKey(key))
                return (T) CurrentContext.Test.Properties.Get(key);
            return null;
        }
    }
}