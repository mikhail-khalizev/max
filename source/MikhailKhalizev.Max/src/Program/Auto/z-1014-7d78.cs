using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7d78-b83ab02b")]
        public void Method_1014_7d78()
        {
            ii(0x1014_7d78, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_7d7d, 5); call(Definitions.sys_check_available_stack_size, 0x1_dfd0); /* call 0x10165d52 */
            ii(0x1014_7d82, 1); push(ebx);                              /* push ebx */
            ii(0x1014_7d83, 1); push(ecx);                              /* push ecx */
            ii(0x1014_7d84, 1); push(esi);                              /* push esi */
            ii(0x1014_7d85, 1); push(edi);                              /* push edi */
            ii(0x1014_7d86, 1); push(ebp);                              /* push ebp */
            ii(0x1014_7d87, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7d89, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_7d8f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_7d92, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_7d95, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_7d98, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_7d9b, 5); call(0x1007_6cd0, -0xd_10d0);           /* call 0x10076cd0 */
            ii(0x1014_7da0, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_7da3, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1014_7da6, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_7da9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_7dac, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1014_7daf, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_7db2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7db4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_7db5, 1); pop(edi);                               /* pop edi */
            ii(0x1014_7db6, 1); pop(esi);                               /* pop esi */
            ii(0x1014_7db7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_7db8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_7db9, 1); ret();                                  /* ret */
        }
    }
}
