using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f270-1932de49")]
        public void Method_0018_f270()
        {
            ii(0x18_f270, 1); push(cx);                                 /* push cx */
            ii(0x18_f271, 4); mov(cx, memw[ds, 0xdee]);                 /* mov cx, [0xdee] */
            ii(0x18_f275, 1); dec(cx);                                  /* dec cx */
            ii(0x18_f276, 2); if(jnz(0x18_f2bb, 0x43)) goto l_0x18_f2bb; /* jnz 0xf2bb */
            ii(0x18_f278, 3); mov(ax, 0xde04);                          /* mov ax, 0xde04 */
        l_0x18_f27b:
            ii(0x18_f27b, 5); calld_far_ind(memd[ds, 0xd5a]);           /* call far dword [0xd5a] */
            ii(0x18_f280, 1); cli();                                    /* cli */
            ii(0x18_f281, 2); or(ah, ah);                               /* or ah, ah */
            ii(0x18_f283, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x18_f286, 2); if(jnz(0x18_f2b9, 0x31)) goto l_0x18_f2b9; /* jnz 0xf2b9 */
        l_0x18_f288:
            ii(0x18_f288, 3); cmp(edi, ebx);                            /* cmp edi, ebx */
            ii(0x18_f28b, 2); if(jae(0x18_f2b9, 0x2c)) goto l_0x18_f2b9; /* jae 0xf2b9 */
            ii(0x18_f28d, 6); test(memb_a32[es, edi + 1], 8);           /* test byte [es:edi+0x1], 0x8 */
            ii(0x18_f293, 2); if(jz(0x18_f29b, 6)) goto l_0x18_f29b;    /* jz 0xf29b */
            ii(0x18_f295, 4); add(edi, 4);                              /* add edi, 0x4 */
            ii(0x18_f299, 2); jmp(0x18_f288, -0x13); goto l_0x18_f288;  /* jmp 0xf288 */
        l_0x18_f29b:
            ii(0x18_f29b, 2); xchg(edx, eax);                           /* xchg edx, eax */
            ii(0x18_f29d, 6); mov(edx, 0x1000);                         /* mov edx, 0x1000 */
            ii(0x18_f2a3, 3); or(ax, 0x807);                            /* or ax, 0x807 */
        l_0x18_f2a6:
            ii(0x18_f2a6, 3); stosd_a32();                              /* a32 stosd */
            ii(0x18_f2a9, 4); add(eax, edx);                            /* add eax, edx */
            ii(0x18_f2ad, 4); inc(memw[ds, 0xdf6]);                     /* inc word [0xdf6] */
            ii(0x18_f2b1, 5); add(memd[ds, 0xaa8], edx);                /* add [0xaa8], edx */
            ii(0x18_f2b6, 1); dec(cx);                                  /* dec cx */
            ii(0x18_f2b7, 2); if(jns(0x18_f2a6, -0x13)) goto l_0x18_f2a6; /* jns 0xf2a6 */
        l_0x18_f2b9:
            ii(0x18_f2b9, 1); pop(cx);                                  /* pop cx */
            ii(0x18_f2ba, 1); retf(); return;                           /* retf */
        l_0x18_f2bb:
            ii(0x18_f2bb, 3); mov(ax, 0xdf00);                          /* mov ax, 0xdf00 */
            ii(0x18_f2be, 2); jmp(0x18_f27b, -0x45); goto l_0x18_f27b;  /* jmp 0xf27b */
        }
    }
}
