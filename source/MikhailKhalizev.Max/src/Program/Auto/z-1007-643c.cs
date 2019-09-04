using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_643c-81452e4a")]
        public void Method_1007_643c()
        {
            ii(0x1007_643c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_6441, 5); call(Definitions.sys_check_available_stack_size, 0xe_f90c); /* call 0x10165d52 */
            ii(0x1007_6446, 1); push(ebx);                              /* push ebx */
            ii(0x1007_6447, 1); push(ecx);                              /* push ecx */
            ii(0x1007_6448, 1); push(esi);                              /* push esi */
            ii(0x1007_6449, 1); push(edi);                              /* push edi */
            ii(0x1007_644a, 1); push(ebp);                              /* push ebp */
            ii(0x1007_644b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_644d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_6453, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_6456, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_6459, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_645c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_645f, 5); call(0x1007_6c98, 0x834);               /* call 0x10076c98 */
            ii(0x1007_6464, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1007_6467, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_646a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_646c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_646d, 1); pop(edi);                               /* pop edi */
            ii(0x1007_646e, 1); pop(esi);                               /* pop esi */
            ii(0x1007_646f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_6470, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_6471, 1); ret();                                  /* ret */
        }
    }
}
