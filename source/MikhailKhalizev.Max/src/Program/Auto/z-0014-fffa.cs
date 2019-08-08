using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ad491e50-28e7-4ba5-9b57-b061376c7863")]
        public void Method_0014_fffa()
        {
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
            ii(0x15_002f, 2); if(jmpw_func(0x15_0037, 0x6)) return;     /* jmp 0x37 */
        l_0x15_0031:
            ii(0x15_0031, 2); popd(eax);                                /* pop eax */
            ii(0x15_0033, 1); popw(ax);                                 /* pop ax */
        }
    }
}
