// using Microsoft.Azure.Mobile.Server;
using Microsoft.WindowsAzure.Mobile.Service;

namespace IETTest08MAService.DataObjects
{
    //public class TodoItem : EntityData
    //{
    //    public string Text { get; set; }

    //    public bool Complete { get; set; }
    //}

    public class TodoItem : StorageData
    {
        public string Text { get; set; }
        public bool Complete { get; set; }
    }
}