﻿namespace PortableDevice
{
    public class PortableDeviceFile : PortableDeviceObject
    {
        public PortableDeviceFile(string id, string name)
            : base(id, name)
        {
        }

        public string Path { get; set; }
    }
}