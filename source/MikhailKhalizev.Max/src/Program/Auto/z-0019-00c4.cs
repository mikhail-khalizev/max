using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_00c4-63bb96c6")]
        public void Method_0019_00c4()
        {
            ii(0x19_00c4, 6); movzx(edx, memw_a16[es, di + 0x6]);       /* movzx edx, word [es:di+0x6] */
            ii(0x19_00ca, 5); mov(eax, memd_a16[es, di + 0x2]);         /* mov eax, [es:di+0x2] */
            ii(0x19_00cf, 4); lar(ecx, dx);                             /* lar ecx, dx */
            ii(0x19_00d3, 5); bt(ecx, 0x16);                            /* bt ecx, 0x16 */
            ii(0x19_00d8, 2); if(jbw(0x19_00e8, 0xe)) goto l_0x19_00e8; /* jb 0xe8 */
            ii(0x19_00da, 1); pushw(ds);                                /* push ds */
            ii(0x19_00db, 1); pushw(si);                                /* push si */
            ii(0x19_00dc, 1); pushw(bx);                                /* push bx */
            ii(0x19_00dd, 1); pushw(cs);                                /* push cs */
            ii(0x19_00de, 5); lea(ecx, 0xc7a);                          /* lea ecx, [0xc7a] */
            ii(0x19_00e3, 1); pushw(cx);                                /* push cx */
            ii(0x19_00e4, 2); jmpw(0x19_0104, 0x1e); goto l_0x19_0104;  /* jmp 0x104 */
        //  ii(0x19_00e6, 2); xchg(bx, bx);                             /* xchg bx, bx */
        l_0x19_00e8:
            ii(0x19_00e8, 2); mov(cx, ds);                              /* mov cx, ds */
            ii(0x19_00ea, 2); pushd(ecx);                               /* push ecx */
            ii(0x19_00ec, 2); pushd(esi);                               /* push esi */
            ii(0x19_00ee, 2); pushd(ebx);                               /* push ebx */
            ii(0x19_00f0, 2); mov(cx, cs);                              /* mov cx, cs */
            ii(0x19_00f2, 2); pushd(ecx);                               /* push ecx */
            ii(0x19_00f4, 5); lea(ecx, 0xc80);                          /* lea ecx, [0xc80] */
            ii(0x19_00f9, 2); pushd(ecx);                               /* push ecx */
            ii(0x19_00fb, 4); mov(ss, memw_a16[ds, 0]);                 /* mov ss, [0x0] */
            ii(0x19_00ff, 4); movzx(esp, sp);                           /* movzx esp, sp */
            ii(0x19_0103, 1); nop();                                    /* nop */
        l_0x19_0104:
            ii(0x19_0104, 2); pushd(edx);                               /* push edx */
            ii(0x19_0106, 2); pushd(eax);                               /* push eax */
            ii(0x19_0108, 2); retfd(); return;                          /* o32 retf */
        }
    }
}
