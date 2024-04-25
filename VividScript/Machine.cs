using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VividScript
{
    public enum Machine : ushort
    {
        Unknown = 0,
        Alpha = 388,
        Alpha64 = 644,
        Amd64=34404,
        AM33 = 467,
        Arm = 448,
        Arm64 = 43620,
        ArmThumb2 = 452,
        Ebc = 3772,
        I386=332,
        IA64=512,
        LoongArch32=25138,
        LoongArch64=25188,
        M32R = 36929,
        MIPS16 = 614,
        MipsFpu16 = 1126,
        PowerPC = 496,
        PowerPCFP = 497,
        RiscV128 = 20776,
        RiscV32 = 20530,
        RiscV64 = 2058,
        SH3 = 418,
        SH3E = 420,
        SH4 = 422,
        SH5 = 424,
        Thumb = 450,
        Tricore = 1312,
        WceMipsV2 = 361
    };
}
