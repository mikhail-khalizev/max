using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_ceb1-d7ec5ca3")]
        public void Method_100c_ceb1()
        {
            ii(0x100c_ceb1, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_ceb6, 5);  call(Definitions.sys_check_available_stack_size, 0x9_8e97);/* call 0x10165d52 */
            ii(0x100c_cebb, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_cebc, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_cebd, 1);  push(edx);                            /* push edx */
            ii(0x100c_cebe, 1);  push(esi);                            /* push esi */
            ii(0x100c_cebf, 1);  push(edi);                            /* push edi */
            ii(0x100c_cec0, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_cec1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_cec3, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_cec9, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_cecc, 7);  mov(memd[ss, ebp - 8], 4);            /* mov dword [ebp-0x8], 0x4 */
            ii(0x100c_ced3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_ced6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_ced8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_ced9, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_ceda, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_cedb, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_cedc, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_cedd, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_cede, 1);  ret();                                /* ret */
        }
    }
}
