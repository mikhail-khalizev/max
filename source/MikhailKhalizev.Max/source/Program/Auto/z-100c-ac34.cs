using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_ac34-3c3c11ad")]
        public void Method_100c_ac34()
        {
            ii(0x100c_ac34, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_ac39, 5);  call(Definitions.sys_check_available_stack_size, 0x9_b114);/* call 0x10165d52 */
            ii(0x100c_ac3e, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_ac3f, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_ac40, 1);  push(edx);                            /* push edx */
            ii(0x100c_ac41, 1);  push(esi);                            /* push esi */
            ii(0x100c_ac42, 1);  push(edi);                            /* push edi */
            ii(0x100c_ac43, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_ac44, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_ac46, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_ac4c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_ac4f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_ac52, 4);  mov(ax, memw[ds, eax + 7]);           /* mov ax, [eax+0x7] */
            ii(0x100c_ac56, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_ac59, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_ac5c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_ac5e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_ac5f, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_ac60, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_ac61, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_ac62, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_ac63, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_ac64, 1);  ret();                                /* ret */
        }
    }
}