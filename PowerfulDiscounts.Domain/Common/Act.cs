#nullable enable
using System;

namespace PowerfulDiscounts.Model.Common
{
    public static class Act
    {
        
        
        /// <summary>
        /// Выполнить Action, если будет исключение - возвращает Exception, иначе - null.
        /// </summary>
        /// <param name="act">Action</param>
        /// <returns>Если всё ок, тогда null, иначе - exception</returns>
        public static Exception? Try(this Action act)
        {
            try
            {
                act.Invoke();
                return null;
            }
            catch (Exception e)
            {
                return e;
            }
        }
    }
}