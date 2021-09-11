#nullable enable
using System;

namespace PowerfulDiscounts.Model.Common
{
    public class Act
    {
        public static string? Try(System.Action act)
        {
            try
            {
                act.Invoke();
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}