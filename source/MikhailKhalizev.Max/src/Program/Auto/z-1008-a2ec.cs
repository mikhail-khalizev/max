using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a2ec-e7358eb0")]
        public void Method_1008_a2ec()
        {
            ii(0x1008_a2ec, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_a2f1, 5); call(Definitions.sys_check_available_stack_size, 0xd_ba5c); /* call 0x10165d52 */
            ii(0x1008_a2f6, 1); push(ebx);                              /* push ebx */
            ii(0x1008_a2f7, 1); push(ecx);                              /* push ecx */
            ii(0x1008_a2f8, 1); push(esi);                              /* push esi */
            ii(0x1008_a2f9, 1); push(edi);                              /* push edi */
            ii(0x1008_a2fa, 1); push(ebp);                              /* push ebp */
            ii(0x1008_a2fb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a2fd, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_a303, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_a306, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_a309, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_a30c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_a30f, 5); call(0x1013_ac03, 0xb_08ef);            /* call 0x1013ac03 */
            ii(0x1008_a314, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_a317, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1008_a31a, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_a31d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_a320, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1008_a323, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1008_a326, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a328, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_a329, 1); pop(edi);                               /* pop edi */
            ii(0x1008_a32a, 1); pop(esi);                               /* pop esi */
            ii(0x1008_a32b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_a32c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_a32d, 1); ret();                                  /* ret */
        }
    }
}
