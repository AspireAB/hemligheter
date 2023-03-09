using System;

namespace Hemligheter.Services
{
    [Flags]
    public enum StorePermissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        List = 8,
    }
}