using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8ac4-3c1058e4")]
        public void Method_1008_8ac4()
        {
            ii(0x1008_8ac4, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_8ac9, 5); call(Definitions.sys_check_available_stack_size, 0xd_d284); /* call 0x10165d52 */
            ii(0x1008_8ace, 1); push(ebx);                              /* push ebx */
            ii(0x1008_8acf, 1); push(ecx);                              /* push ecx */
            ii(0x1008_8ad0, 1); push(esi);                              /* push esi */
            ii(0x1008_8ad1, 1); push(edi);                              /* push edi */
            ii(0x1008_8ad2, 1); push(ebp);                              /* push ebp */
            ii(0x1008_8ad3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8ad5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8adb, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_8ade, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_8ae1, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1008_8ae6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_8ae9, 5); call(0x1008_8a84, -0x6a);               /* call 0x10088a84 */
            ii(0x1008_8aee, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_8af1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_8af4, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_8af7, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_8afa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8afc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_8afd, 1); pop(edi);                               /* pop edi */
            ii(0x1008_8afe, 1); pop(esi);                               /* pop esi */
            ii(0x1008_8aff, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_8b00, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_8b01, 1); ret();                                  /* ret */
        }
    }
}
