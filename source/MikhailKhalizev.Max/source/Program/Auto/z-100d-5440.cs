using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5440-fe6d4413")]
        public void Method_100d_5440()
        {
            ii(0x100d_5440, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100d_5445, 5);  call(Definitions.sys_check_available_stack_size, 0x9_0908);/* call 0x10165d52 */
            ii(0x100d_544a, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_544b, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_544c, 1);  push(edx);                            /* push edx */
            ii(0x100d_544d, 1);  push(esi);                            /* push esi */
            ii(0x100d_544e, 1);  push(edi);                            /* push edi */
            ii(0x100d_544f, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_5450, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_5452, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100d_5458, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_545b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_545e, 3);  mov(al, memb[ds, eax + 122]);         /* mov al, [eax+0x7a] */
            ii(0x100d_5461, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x100d_5464, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100d_5467, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_5469, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_546a, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_546b, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_546c, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_546d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_546e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_546f, 1);  ret();                                /* ret */
        }
    }
}
