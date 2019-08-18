using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ffe3-f3457c8d")]
        public void Method_0018_ffe3()
        {
            ii(0x18_ffe3, 1); pushw(bp);                                /* push bp */
            ii(0x18_ffe4, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_ffe6, 1); pushw(ds);                                /* push ds */
            ii(0x18_ffe7, 2); pushd(esi);                               /* push esi */
            ii(0x18_ffe9, 2); pushd(edi);                               /* push edi */
            ii(0x18_ffeb, 2); pushd(ebx);                               /* push ebx */
            ii(0x18_ffed, 5); movzx(ebx, memw_a16[ss, bp + 0x6]);       /* movzx ebx, word [bp+0x6] */
            ii(0x18_fff2, 4); cmp(ebx, 0x20);                           /* cmp ebx, 0x20 */
            ii(0x18_fff6, 2); if(jaew(0x19_0034, 0x3c)) goto l_0x19_0034; /* jae 0x34 */
            ii(0x18_fff8, 2); mov(bh, 0x1);                             /* mov bh, 0x1 */
            ii(0x18_fffa, 3); les(si, ss, bp + 0x8);                    /* les si, [bp+0x8] */
            ii(0x18_fffd, 4); pushw(memw_a16[es, si + 0x4]);            /* push word [es:si+0x4] */
            ii(0x19_0001, 4); pushd(memd_a16[es, si]);                  /* push dword [es:si] */
            ii(0x19_0005, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_0008, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_000a, 1); pushw(bx);                                /* push bx */
            ii(0x19_000b, 3); callw(0x19_0125, 0x117);                  /* call 0x125 */
            ii(0x19_000e, 1); popw(bx);                                 /* pop bx */
            ii(0x19_000f, 2); if(jbw(0x19_0031, 0x20)) goto l_0x19_0031; /* jb 0x31 */
            ii(0x19_0011, 5); popd(memd_a16[es, di + 0x2]);             /* pop dword [es:di+0x2] */
            ii(0x19_0016, 4); popw(memw_a16[es, di + 0x6]);             /* pop word [es:di+0x6] */
            ii(0x19_001a, 4); mov(al, memb_a16[ds, bx + 0x2]);          /* mov al, [bx+0x2] */
            ii(0x19_001e, 4); mov(memb_a16[es, di + 0x1], al);          /* mov [es:di+0x1], al */
            ii(0x19_0022, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x19_0024, 3); shr(ax, 0x3);                             /* shr ax, 0x3 */
            ii(0x19_0027, 4); mov(memb_a16[ds, bx + 0x2], al);          /* mov [bx+0x2], al */
            ii(0x19_002b, 4); movzx(eax, di);                           /* movzx eax, di */
            ii(0x19_002f, 2); jmpw(0x19_0037, 0x6); goto l_0x19_0037;   /* jmp 0x37 */
        l_0x19_0031:
            ii(0x19_0031, 2); popd(eax);                                /* pop eax */
            ii(0x19_0033, 1); popw(ax);                                 /* pop ax */
        l_0x19_0034:
            ii(0x19_0034, 3); xor(eax, eax);                            /* xor eax, eax */
        l_0x19_0037:
            ii(0x19_0037, 2); popd(ebx);                                /* pop ebx */
            ii(0x19_0039, 2); popd(edi);                                /* pop edi */
            ii(0x19_003b, 2); popd(esi);                                /* pop esi */
            ii(0x19_003d, 1); popw(ds);                                 /* pop ds */
            ii(0x19_003e, 1); popw(bp);                                 /* pop bp */
            ii(0x19_003f, 1); retfw(); return;                          /* retf */
        }
    }
}
