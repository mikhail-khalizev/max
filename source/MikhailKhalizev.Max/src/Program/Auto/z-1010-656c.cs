using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_656c-d059e310")]
        public void Method_1010_656c()
        {
            ii(0x1010_656c, 5); push(0x28);                             /* push 0x28 */
            ii(0x1010_6571, 5); call(Definitions.sys_check_available_stack_size, 0x5_f7dc); /* call 0x10165d52 */
            ii(0x1010_6576, 1); push(ebx);                              /* push ebx */
            ii(0x1010_6577, 1); push(ecx);                              /* push ecx */
            ii(0x1010_6578, 1); push(edx);                              /* push edx */
            ii(0x1010_6579, 1); push(esi);                              /* push esi */
            ii(0x1010_657a, 1); push(edi);                              /* push edi */
            ii(0x1010_657b, 1); push(ebp);                              /* push ebp */
            ii(0x1010_657c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_657e, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1010_6584, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_6587, 5); mov(eax, 0x762);                        /* mov eax, 0x762 */
            ii(0x1010_658c, 1); push(eax);                              /* push eax */
            ii(0x1010_658d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_6590, 1); push(eax);                              /* push eax */
            ii(0x1010_6591, 5); call(0x1012_3398, 0x1_ce02);            /* call 0x10123398 */
            ii(0x1010_6596, 3); add(esp, 8);                            /* add esp, 0x8 */
            ii(0x1010_6599, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_659b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_659c, 1); pop(edi);                               /* pop edi */
            ii(0x1010_659d, 1); pop(esi);                               /* pop esi */
            ii(0x1010_659e, 1); pop(edx);                               /* pop edx */
            ii(0x1010_659f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_65a0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_65a1, 1); ret();                                  /* ret */
        }
    }
}
