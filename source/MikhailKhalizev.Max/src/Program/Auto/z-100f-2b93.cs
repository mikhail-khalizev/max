using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_2b93-f9cc1fa4")]
        public void Method_100f_2b93()
        {
            ii(0x100f_2b93, 5); push(0x24);                             /* push 0x24 */
            ii(0x100f_2b98, 5); call(Definitions.sys_check_available_stack_size, 0x7_31b5); /* call 0x10165d52 */
            ii(0x100f_2b9d, 1); push(ebx);                              /* push ebx */
            ii(0x100f_2b9e, 1); push(ecx);                              /* push ecx */
            ii(0x100f_2b9f, 1); push(esi);                              /* push esi */
            ii(0x100f_2ba0, 1); push(edi);                              /* push edi */
            ii(0x100f_2ba1, 1); push(ebp);                              /* push ebp */
            ii(0x100f_2ba2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_2ba4, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100f_2baa, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_2bad, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100f_2bb0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_2bb3, 5); call(Definitions.sys_strlen, 0x7_f30f); /* call 0x10171ec7 */
            ii(0x100f_2bb8, 3); lea(ebx, eax + 0x1);                    /* lea ebx, [eax+0x1] */
            ii(0x100f_2bbb, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_2bbe, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_2bc1, 5); call(Definitions.sys_strlen, 0x7_f301); /* call 0x10171ec7 */
            ii(0x100f_2bc6, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x100f_2bc9, 5); call(/* sys */ 0x1016_6177, 0x7_35a9);  /* call 0x10166177 */
            ii(0x100f_2bce, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_2bd1, 5); call(Definitions.sys_strlen, 0x7_f2f1); /* call 0x10171ec7 */
            ii(0x100f_2bd6, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_2bd8, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_2bdb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_2bde, 5); call(Definitions.sys_memcpy, 0x7_3268); /* call 0x10165e4b */
            ii(0x100f_2be3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_2be6, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_2be9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_2bec, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_2bee, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_2bef, 1); pop(edi);                               /* pop edi */
            ii(0x100f_2bf0, 1); pop(esi);                               /* pop esi */
            ii(0x100f_2bf1, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_2bf2, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_2bf3, 1); ret();                                  /* ret */
        }
    }
}
