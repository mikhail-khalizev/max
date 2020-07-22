using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6600-f911e311")]
        public void Method_1007_6600()
        {
            ii(0x1007_6600, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_6605, 5);  call(Definitions.sys_check_available_stack_size, 0xe_f748);/* call 0x10165d52 */
            ii(0x1007_660a, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_660b, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_660c, 1);  push(edx);                            /* push edx */
            ii(0x1007_660d, 1);  push(esi);                            /* push esi */
            ii(0x1007_660e, 1);  push(edi);                            /* push edi */
            ii(0x1007_660f, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_6610, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_6612, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_6618, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_661b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_661e, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1007_6620, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6623, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_6626, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_6628, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_6629, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_662a, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_662b, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_662c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_662d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_662e, 1);  ret();                                /* ret */
        }
    }
}
