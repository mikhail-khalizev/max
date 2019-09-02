using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9ba0-d18e114b")]
        public void Method_1008_9ba0()
        {
            ii(0x1008_9ba0, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_9ba5, 5); call(Definitions.sys_check_available_stack_size, 0xd_c1a8); /* call 0x10165d52 */
            ii(0x1008_9baa, 1); push(ebx);                              /* push ebx */
            ii(0x1008_9bab, 1); push(ecx);                              /* push ecx */
            ii(0x1008_9bac, 1); push(esi);                              /* push esi */
            ii(0x1008_9bad, 1); push(edi);                              /* push edi */
            ii(0x1008_9bae, 1); push(ebp);                              /* push ebp */
            ii(0x1008_9baf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9bb1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_9bb7, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_9bba, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_9bbd, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_9bc0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_9bc3, 5); call(0x1007_6cd0, -0x1_2ef8);           /* call 0x10076cd0 */
            ii(0x1008_9bc8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_9bcb, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1008_9bce, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_9bd1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_9bd4, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_9bd7, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_9bda, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9bdc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_9bdd, 1); pop(edi);                               /* pop edi */
            ii(0x1008_9bde, 1); pop(esi);                               /* pop esi */
            ii(0x1008_9bdf, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_9be0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_9be1, 1); ret();                                  /* ret */
        }
    }
}
