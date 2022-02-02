using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSessionWindowsOOP.Interfaces
{
    interface IMyInterface
    {
        void SendNotification();

        int Notification { get; set; }
    }

    class MyBaseClass
    {

    }

    interface IOtherBase
    {

    }

    class MyInheritClass : MyBaseClass, IOtherBase, IMyInterface
    {
        public int Notification { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SendNotification()
        {

        }
    }
}
