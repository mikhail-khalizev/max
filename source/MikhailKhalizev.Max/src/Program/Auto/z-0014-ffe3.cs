using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("103c374b-2780-4e5d-a956-574a8f3ac146")]
        public void Method_0014_ffe3()
        {
            ii(0x14_ffe3, 1); pushw(bp);                                /* push bp */
            ii(0x14_ffe4, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x14_ffe6, 1); pushw(ds);                                /* push ds */
            ii(0x14_ffe7, 2); pushd(esi);                               /* push esi */
            ii(0x14_ffe9, 2); pushd(edi);                               /* push edi */
            ii(0x14_ffeb, 2); pushd(ebx);                               /* push ebx */
            ii(0x14_ffed, 5); movzx(ebx, memw_a16[ss, bp + 0x6]);       /* movzx ebx, word [bp+0x6] */
            ii(0x14_fff2, 4); cmp(ebx, 0x20);                           /* cmp ebx, 0x20 */
            ii(0x14_fff6, 2); if(jaew(0x15_0034, 0x3c)) goto l_0x15_0034; /* jae 0x34 */
            ii(0x14_fff8, 2); mov(bh, 0x1);                             /* mov bh, 0x1 */
            ii(0x14_fffa, 3); les(si, ss, bp + 0x8);                    /* les si, [bp+0x8] */
            ii(0x14_fffd, 4); pushw(memw_a16[es, si + 0x4]);            /* push word [es:si+0x4] */
            ii(0x15_0001, 4); pushd(memd_a16[es, si]);                  /* push dword [es:si] */
            ii(0x15_0005, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_0008, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_000a, 1); pushw(bx);                                /* push bx */
            ii(0x15_000b, 3); callw(0x15_0125, 0x117);                  /* call 0x125 */
            ii(0x15_000e, 1); popw(bx);                                 /* pop bx */
            ii(0x15_000f, 2); if(jbw(0x15_0031, 0x20)) goto l_0x15_0031; /* jb 0x31 */
            ii(0x15_0011, 5); popd(memd_a16[es, di + 0x2]);             /* pop dword [es:di+0x2] */
            ii(0x15_0016, 4); popw(memw_a16[es, di + 0x6]);             /* pop word [es:di+0x6] */
            ii(0x15_001a, 4); mov(al, memb_a16[ds, bx + 0x2]);          /* mov al, [bx+0x2] */
            ii(0x15_001e, 4); mov(memb_a16[es, di + 0x1], al);          /* mov [es:di+0x1], al */
            ii(0x15_0022, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x15_0024, 3); shr(ax, 0x3);                             /* shr ax, 0x3 */
            ii(0x15_0027, 4); mov(memb_a16[ds, bx + 0x2], al);          /* mov [bx+0x2], al */
            ii(0x15_002b, 4); movzx(eax, di);                           /* movzx eax, di */
            ii(0x15_002f, 2); jmpw(0x15_0037, 0x6); goto l_0x15_0037;   /* jmp 0x37 */
        l_0x15_0031:
            ii(0x15_0031, 2); popd(eax);                                /* pop eax */
            ii(0x15_0033, 1); popw(ax);                                 /* pop ax */
        l_0x15_0034:
            ii(0x15_0034, 3); xor(eax, eax);                            /* xor eax, eax */
        l_0x15_0037:
            ii(0x15_0037, 2); popd(ebx);                                /* pop ebx */
            ii(0x15_0039, 2); popd(edi);                                /* pop edi */
            ii(0x15_003b, 2); popd(esi);                                /* pop esi */
            ii(0x15_003d, 1); popw(ds);                                 /* pop ds */
            ii(0x15_003e, 1); popw(bp);                                 /* pop bp */
            ii(0x15_003f, 1); retfw(); return;                          /* retf */
        }
    }
}
