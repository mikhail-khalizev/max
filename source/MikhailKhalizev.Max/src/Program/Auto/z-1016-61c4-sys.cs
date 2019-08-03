using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ca458cf8-7df2-4549-a227-0028ebe9b6a4")]
        public void /* sys */ Method_1016_61c4()
        {
            ii(0x1016_61c4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_61c5, 1); pushd(esi);                             /* push esi */
            ii(0x1016_61c6, 1); pushd(edi);                             /* push edi */
            ii(0x1016_61c7, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1016_61c9, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1016_61cb, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_61cd, 1); pushd(es);                              /* push es */
            ii(0x1016_61ce, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1016_61d0, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1016_61d2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_61d4, 2); repe_a32(() => cmpsb_a32());            /* repe cmpsb */
            ii(0x1016_61d6, 2); if(jzd(0x1016_61dd, 0x5)) goto l_0x1016_61dd; /* jz 0x101661dd */
            ii(0x1016_61d8, 2); sbb(eax, eax);                          /* sbb eax, eax */
            ii(0x1016_61da, 3); sbb(eax, -0x1 /* 0xff */);              /* sbb eax, 0xffffffff */
        l_0x1016_61dd:
            ii(0x1016_61dd, 1); popd(es);                               /* pop es */
            ii(0x1016_61de, 1); popd(edi);                              /* pop edi */
            ii(0x1016_61df, 1); popd(esi);                              /* pop esi */
            ii(0x1016_61e0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_61e1, 1); retd(); return;                         /* ret */
        }
    }
}
