using System;
using System.Collections.Generic;

namespace DataProtocol
{
    [Serializable]
    public class RoomList
    {
        public List<string> List = new List<string>();
    }
    [Serializable]
    public class OrderInfo
    {
        public string MethodName;
        public object[] Parameter;
    } 
}
