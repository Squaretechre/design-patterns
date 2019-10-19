using System;

namespace DesignPatterns.BryanHansen.Singleton
{
    public class DbSingleton {
        private static readonly Lazy<DbSingleton> Instance =
            new Lazy<DbSingleton>(
                () => new DbSingleton(), isThreadSafe: true
            );

        public static DbSingleton GetInstance => Instance.Value;

        private DbSingleton() { }
    }
}
