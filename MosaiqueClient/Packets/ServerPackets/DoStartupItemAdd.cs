﻿using Client.Controllers;
using ZeroFormatter;

namespace Client.Packets.ServerPackets
{
    [ZeroFormattable]
    public class DoStartupItemAdd : IPackets
    {
        public override TypePackets Type
        {
            get
            {
                return TypePackets.DoStartupItemAdd;
            }
        }

        [Index(0)]
        public virtual string name { get; set; }

        [Index(1)]
        public virtual string path { get; set; }

        [Index(2)]
        public virtual int type { get; set; }

        public DoStartupItemAdd()
        {
        }

        public DoStartupItemAdd(string name, string path, int type)
        {
            this.name = name;
            this.path = path;
            this.type = type;
        }

        public void Execute(ClientMosaique client)
        {
            client.send(this);
        }
    }
}