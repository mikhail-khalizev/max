using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_d8ba-46e9c16b")]
        public void Method_1011_d8ba()
        {
            ii(0x1011_d8ba, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_d8bf, 5); call(Definitions.sys_check_available_stack_size, 0x4_848e); /* call 0x10165d52 */
            ii(0x1011_d8c4, 1); push(ebx);                              /* push ebx */
            ii(0x1011_d8c5, 1); push(ecx);                              /* push ecx */
            ii(0x1011_d8c6, 1); push(esi);                              /* push esi */
            ii(0x1011_d8c7, 1); push(edi);                              /* push edi */
            ii(0x1011_d8c8, 1); push(ebp);                              /* push ebp */
            ii(0x1011_d8c9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_d8cb, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1011_d8d1, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_d8d4, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1011_d8d7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_d8da, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1011_d8dd, 4); mov(memw[ds, edx + 15], ax);            /* mov [edx+0xf], ax */
            ii(0x1011_d8e1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_d8e3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_d8e4, 1); pop(edi);                               /* pop edi */
            ii(0x1011_d8e5, 1); pop(esi);                               /* pop esi */
            ii(0x1011_d8e6, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_d8e7, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_d8e8, 1); ret();                                  /* ret */
        }
    }
}
