using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c7ebe510-ed30-4a93-8542-10246a5fbd6c")]
        public void Method_1028_b4c0()
        {
            ii(0x1028_b4c0, 1); pushd(ds);                              /* push ds */
            ii(0x1028_b4c1, 8); mov(memw_a32[fs, 0x1537], fs);          /* mov [fs:0x1537], fs */
            ii(0x1028_b4c9, 2); pushd(fs);                              /* push fs */
            ii(0x1028_b4cb, 1); popd(ds);                               /* pop ds */
            ii(0x1028_b4cc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1028_b4cd, 4); mov(ebx, memd_a32[ss, esp + 0xc]);      /* mov ebx, [esp+0xc] */
            ii(0x1028_b4d1, 6); mov(memd_a32[ds, 0x1370], ebx);         /* mov [0x1370], ebx */
            ii(0x1028_b4d7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1028_b4d8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1028_b4d9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1028_b4db, 3); mov(bx, ax);                            /* mov bx, ax */
            ii(0x1028_b4de, 3); shl(ebx, 0x2);                          /* shl ebx, 0x2 */
            ii(0x1028_b4e1, 1); popd(eax);                              /* pop eax */
            ii(0x1028_b4e2, 6); add(ebx, 0x1492);                       /* add ebx, 0x1492 */
            ii(0x1028_b4e8, 2); mov(ebx, memd_a32[ds, ebx]);            /* mov ebx, [ebx] */
            ii(0x1028_b4ea, 2); calld_abs(ebx);                         /* call ebx */
            ii(0x1028_b4ec, 1); popd(ds);                               /* pop ds */
            ii(0x1028_b4ed, 1); retfd(); return;                        /* retf */
        }
    }
}
