using System;
using System.Runtime.InteropServices;

namespace VividScript
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PEHeader
    {
        #region MZ header
        public ushort eMagic;
        public ushort eCblp;
        public ushort eCbar;
        public ushort eCrlc;
        public ushort eCparhdr;
        public ushort eMinalloc;
        public ushort eMaxalloc;    
        public ushort eSs;
        public ushort eSp;
        public ushort ecSum;
        public ushort eIp;
        public ushort eCs;
        public ushort eLfarlc;
        public ushort eOvno;
        public fixed ushort eRes[4];
        public ushort eOemid;
        public ushort eOeminfo;
        public fixed ushort eRes2[10];
        public uint eLfanew;
        #endregion
    }
}
