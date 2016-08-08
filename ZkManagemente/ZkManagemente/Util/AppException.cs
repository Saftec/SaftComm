using System;

namespace ZkManagement.Util
{
    class AppException:Exception
    {
        public AppException (string message): base(message)
        {
        }

        public AppException()
        {
        }
    }
}
