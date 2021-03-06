using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_efd7-ed4c53d9")]
        public void Method_1009_efd7()
        {
            ii(0x1009_efd7, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_efdc, 5);  call(Definitions.sys_check_available_stack_size, 0xc_6d71);/* call 0x10165d52 */
            ii(0x1009_efe1, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_efe2, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_efe3, 1);  push(esi);                            /* push esi */
            ii(0x1009_efe4, 1);  push(edi);                            /* push edi */
            ii(0x1009_efe5, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_efe6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_efe8, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_efee, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_eff1, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_eff4, 5);  mov(edx, StringDefinitions.LookForEnemyLandSeaMines);/* mov edx, 0x101a07ab */
            ii(0x1009_eff9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_effc, 5);  call(Definitions.sys_strcpy, 0xc_6ece);/* call 0x10165ecf */
            ii(0x1009_f001, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_f004, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_f007, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_f00a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_f00c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_f00d, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_f00e, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_f00f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_f010, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_f011, 1);  ret();                                /* ret */
        }
    }
}
