using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_dd5b-7e02860f")]
        public void /* sys */ Method_1018_dd5b()
        {
            ii(0x1018_dd5b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_dd5c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_dd5e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_dd60, 2); outb(0xc, al);                          /* out 0xc, al */
            ii(0x1018_dd62, 2); jmpd(0x1018_dd64, 0); goto l_0x1018_dd64; /* jmp 0x1018dd64 */
        l_0x1018_dd64:
            ii(0x1018_dd64, 3); mov(edx, memd_a32[ss, ebp + 0x8]);      /* mov edx, [ebp+0x8] */
            ii(0x1018_dd67, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1018_dd68, 2); jmpd(0x1018_dd6a, 0); goto l_0x1018_dd6a; /* jmp 0x1018dd6a */
        l_0x1018_dd6a:
            ii(0x1018_dd6a, 2); mov(ah, al);                            /* mov ah, al */
            ii(0x1018_dd6c, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1018_dd6d, 2); jmpd(0x1018_dd6f, 0); goto l_0x1018_dd6f; /* jmp 0x1018dd6f */
        l_0x1018_dd6f:
            ii(0x1018_dd6f, 2); xchg(ah, al);                           /* xchg ah, al */
            ii(0x1018_dd71, 1); inc(eax);                               /* inc eax */
            ii(0x1018_dd72, 3); cmp(edx, 0x7);                          /* cmp edx, 0x7 */
            ii(0x1018_dd75, 2); if(jbed(0x1018_dd79, 0x2)) goto l_0x1018_dd79; /* jbe 0x1018dd79 */
            ii(0x1018_dd77, 2); shl(eax, 0x1);                          /* shl eax, 1 */
        l_0x1018_dd79:
            ii(0x1018_dd79, 1); leaved();                               /* leave */
            ii(0x1018_dd7a, 1); retd(); return;                         /* ret */
        }
    }
}
