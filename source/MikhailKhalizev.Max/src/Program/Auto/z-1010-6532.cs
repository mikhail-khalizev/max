using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6532-8d041b09")]
        public void Method_1010_6532()
        {
            ii(0x1010_6532, 5); push(0x28);                             /* push 0x28 */
            ii(0x1010_6537, 5); call(Definitions.sys_check_available_stack_size, 0x5_f816); /* call 0x10165d52 */
            ii(0x1010_653c, 1); push(ebx);                              /* push ebx */
            ii(0x1010_653d, 1); push(ecx);                              /* push ecx */
            ii(0x1010_653e, 1); push(esi);                              /* push esi */
            ii(0x1010_653f, 1); push(edi);                              /* push edi */
            ii(0x1010_6540, 1); push(ebp);                              /* push ebp */
            ii(0x1010_6541, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6543, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_6549, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_654c, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1010_654f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_6552, 1); push(eax);                              /* push eax */
            ii(0x1010_6553, 5); call(0x1012_36ac, 0x1_d154);            /* call 0x101236ac */
            ii(0x1010_6558, 3); add(esp, 4);                            /* add esp, 0x4 */
            ii(0x1010_655b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_655e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_6561, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_6564, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_6566, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_6567, 1); pop(edi);                               /* pop edi */
            ii(0x1010_6568, 1); pop(esi);                               /* pop esi */
            ii(0x1010_6569, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_656a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_656b, 1); ret();                                  /* ret */
        }
    }
}
