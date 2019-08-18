using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("92d81c87-3b45-4a7c-bf1a-f88febbeecc8")]
        public void /* sys */ Method_1016_f63c()
        {
            ii(0x1016_f63c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_f63d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_f63f, 2); mov(bl, dl);                            /* mov bl, dl */
            ii(0x1016_f641, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_f643, 2); if(jzd(0x1016_f657, 0x12)) goto l_0x1016_f657; /* jz 0x1016f657 */
            ii(0x1016_f645, 4); test(memb_a32[ds, eax + 0x4], 0x4);     /* test byte [eax+0x4], 0x4 */
            ii(0x1016_f649, 2); if(jzd(0x1016_f657, 0xc)) goto l_0x1016_f657; /* jz 0x1016f657 */
            ii(0x1016_f64b, 3); mov(edx, memd_a32[ds, eax + 0xc]);      /* mov edx, [eax+0xc] */
            ii(0x1016_f64e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_f650, 5); calld(/* sys */ 0x1017_29f1, 0x339c);   /* call 0x101729f1 */
            ii(0x1016_f655, 2); jmpd(0x1016_f65c, 0x5); goto l_0x1016_f65c; /* jmp 0x1016f65c */
        l_0x1016_f657:
            ii(0x1016_f657, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
        l_0x1016_f65c:
            ii(0x1016_f65c, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_f65f, 3); setnz(al);                              /* setnz al */
            ii(0x1016_f662, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_f667, 1); dec(eax);                               /* dec eax */
            ii(0x1016_f668, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_f669, 1); retd(); return;                         /* ret */
        }
    }
}
