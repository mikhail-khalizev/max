using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_ca70-d7c5e80c")]
        public void Method_1009_ca70()
        {
            ii(0x1009_ca70, 5); push(0x28);                             /* push 0x28 */
            ii(0x1009_ca75, 5); call(Definitions.sys_check_available_stack_size, 0xc_92d8); /* call 0x10165d52 */
            ii(0x1009_ca7a, 1); push(ebx);                              /* push ebx */
            ii(0x1009_ca7b, 1); push(ecx);                              /* push ecx */
            ii(0x1009_ca7c, 1); push(edx);                              /* push edx */
            ii(0x1009_ca7d, 1); push(esi);                              /* push esi */
            ii(0x1009_ca7e, 1); push(edi);                              /* push edi */
            ii(0x1009_ca7f, 1); push(ebp);                              /* push ebp */
            ii(0x1009_ca80, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ca82, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_ca88, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_ca8b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_ca8e, 5); call(0x1013_a0af, 0x9_d61c);            /* call 0x1013a0af */
            ii(0x1009_ca93, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_ca96, 3); lea(eax, memd[ss, ebp - 0x4]);          /* lea eax, [ebp-0x4] */
            ii(0x1009_ca99, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_ca9c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_ca9f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_caa2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_caa5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_caa7, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_caa8, 1); pop(edi);                               /* pop edi */
            ii(0x1009_caa9, 1); pop(esi);                               /* pop esi */
            ii(0x1009_caaa, 1); pop(edx);                               /* pop edx */
            ii(0x1009_caab, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_caac, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_caad, 1); ret();                                  /* ret */
        }
    }
}
