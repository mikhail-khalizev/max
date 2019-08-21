using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_febe-a75bdc77")]
        public void Method_0018_febe()
        {
            ii(0x18_febe, 2); pushd(ebp);                               /* push ebp */
            ii(0x18_fec0, 3); mov(ebp, esp);                            /* mov ebp, esp */
            ii(0x18_fec3, 2); pushd(eax);                               /* push eax */
            ii(0x18_fec5, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x18_fec7, 4); lar(eax, ax);                             /* lar eax, ax */
            ii(0x18_fecb, 5); bt(eax, 0x16);                            /* bt eax, 0x16 */
            ii(0x18_fed0, 2); if(jbw(0x18_fed6, 0x4)) goto l_0x18_fed6; /* jb 0xfed6 */
            ii(0x18_fed2, 4); movzx(ebp, bp);                           /* movzx ebp, bp */
        l_0x18_fed6:
            ii(0x18_fed6, 2); mov(ax, cs);                              /* mov ax, cs */
            ii(0x18_fed8, 4); cmp(ax, memw_a32[ss, ebp + 0x8]);         /* cmp ax, [ebp+0x8] */
            ii(0x18_fedc, 2); popd(eax);                                /* pop eax */
            ii(0x18_fede, 4); if(jzw(0x18_fee7, 0x5)) goto l_0x18_fee7; /* jz 0xfee7 */
            ii(0x18_fee2, 2); popd(ebp);                                /* pop ebp */
            ii(0x18_fee4, 3); if(jmpw_func(0x18_f880, -0x667)) return;  /* jmp 0xf880 */
        l_0x18_fee7:
            ii(0x18_fee7, 5); and(memb_a32[ss, ebp + 0xd], -0x2 /* 0xfe */); /* and byte [ebp+0xd], 0xfe */
            ii(0x18_feec, 2); popd(ebp);                                /* pop ebp */
            ii(0x18_feee, 2); iretd(); return;                          /* iretd */
        }
    }
}
