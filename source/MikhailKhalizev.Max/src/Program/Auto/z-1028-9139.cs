using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_9139-91b585c6")]
        public void Method_1028_9139()
        {
            ii(0x1028_9139, 1); pushd(ds);                              /* push ds */
            ii(0x1028_913a, 2); pushd(fs);                              /* push fs */
            ii(0x1028_913c, 1); popd(ds);                               /* pop ds */
            ii(0x1028_913d, 7); mov(memw_a32[ds, 0xc9], ds);            /* mov [0xc9], ds */
            ii(0x1028_9144, 7); mov(memw_a32[ds, 0xd1], ds);            /* mov [0xd1], ds */
            ii(0x1028_914b, 7); mov(memw_a32[ds, 0xd9], ds);            /* mov [0xd9], ds */
            ii(0x1028_9152, 7); mov(memw_a32[ds, 0xe1], ds);            /* mov [0xe1], ds */
            ii(0x1028_9159, 2); pushw(bx);                              /* push bx */
            ii(0x1028_915b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1028_915d, 3); mov(bx, ax);                            /* mov bx, ax */
            ii(0x1028_9160, 3); shl(ebx, 0x2);                          /* shl ebx, 0x2 */
            ii(0x1028_9163, 2); popw(ax);                               /* pop ax */
            ii(0x1028_9165, 6); add(ebx, 0x115);                        /* add ebx, 0x115 */
            ii(0x1028_916b, 2); mov(ebx, memd_a32[ds, ebx]);            /* mov ebx, [ebx] */
            ii(0x1028_916d, 2); calld_abs(ebx);                         /* call ebx */
            ii(0x1028_916f, 1); popd(ds);                               /* pop ds */
            ii(0x1028_9170, 1); retfd(); return;                        /* retf */
        }
    }
}
