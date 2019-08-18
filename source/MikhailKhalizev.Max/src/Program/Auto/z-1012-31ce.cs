using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0ed684fb-2c63-4627-8371-3923569a7c24")]
        public void Method_1012_31ce()
        {
            ii(0x1012_31ce, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1012_31d2, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1012_31d5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_31d7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_31d8, 1); popd(edi);                              /* pop edi */
            ii(0x1012_31d9, 1); popd(esi);                              /* pop esi */
            ii(0x1012_31da, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_31db, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_31dc, 1); retd(); return;                         /* ret */
        }
    }
}
