using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_efe9-a45538af")]
        public void Method_1007_efe9()
        {
            ii(0x1007_efe9, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_efee, 5);  call(Definitions.sys_check_available_stack_size, 0xe_6d5f);/* call 0x10165d52 */
            ii(0x1007_eff3, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_eff4, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_eff5, 1);  push(edx);                            /* push edx */
            ii(0x1007_eff6, 1);  push(esi);                            /* push esi */
            ii(0x1007_eff7, 1);  push(edi);                            /* push edi */
            ii(0x1007_eff8, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_eff9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_effb, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_f001, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_f004, 7);  mov(memd[ss, ebp - 8], 4);            /* mov dword [ebp-0x8], 0x4 */
            ii(0x1007_f00b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_f00e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_f010, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_f011, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_f012, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_f013, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_f014, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_f015, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_f016, 1);  ret();                                /* ret */
        }
    }
}
