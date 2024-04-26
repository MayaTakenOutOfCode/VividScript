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
        #region DOS stub
        public fixed Byte unknown[14],
            msg[38],
            unknown_0[5],
            unknown_empty[7];

        #endregion
        #region PEHeader
        public uint signature;
        public Machine machine;
        public ushort numberOfSections;
        public uint timeDateStamp, pointerToSymbolTable, numberOfSymbols;
        public ushort sizeOfOptionalHeader, characteristics;
        #endregion
        #region PE optional Header
        public ushort magic;
        public Byte majorLinkerVersion, minorLinkerVersion;
        public uint sizeOfCode, sizeOfInitializedData, sizeOfUnitializedData, adressOfEntryPoint, baseOfCode, baseOfData, imageBase, sectionAligment, fileAligment;

        public ushort majorOperatingSystemVersion, minorOperatingSystemVersion, majorImageVersion, minorImageVersion, majorSubsytemVersion, minorSubsytemVersion;   
        public uint win32VersionValue, sizeOfImage, sizeOfHeaders, checkSum;
        public ushort subSytem, dllCharacteristics;
        public uint sizeOfStackReserve, sizeOfStackCommit, sizeOfHeapReserve,sizeOfHeapCommit, loaderFlags, numberOfRvaAndSizes;
        #endregion
        #region Data Directories

        public fixed uint dir[32];


        #endregion
        #region PE code section
        public fixed Byte name[8];
        public uint virtualSize, virtualAdress, sizeOfRawData, pointerToRawData, pointerToRelocations, pointerToLineNumbers;
        public ushort numberOfRelocations, numberOfLineNumbers;
        public uint characteristics_0;

        #endregion
        #region Import Table
        public fixed ulong importTable[32];
        #endregion
    }

}
