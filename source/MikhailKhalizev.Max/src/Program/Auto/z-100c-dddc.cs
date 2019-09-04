using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_dddc-b7f529e9")]
        public void Method_100c_dddc()
        {
            ii(0x100c_dddc, 5);  push(0x1c);                           /* push 0x1c */
            ii(0x100c_dde1, 5);  call(Definitions.sys_check_available_stack_size, 0x9_7f6c);/* call 0x10165d52 */
            ii(0x100c_dde6, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_dde7, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_dde8, 1);  push(edx);                            /* push edx */
            ii(0x100c_dde9, 1);  push(esi);                            /* push esi */
            ii(0x100c_ddea, 1);  push(edi);                            /* push edi */
            ii(0x100c_ddeb, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_ddec, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_ddee, 6);  sub(esp, 0);                          /* sub esp, 0x0 */
            ii(0x100c_ddf4, 5);  mov(ecx, 0xc7);                       /* mov ecx, 0xc7 */
            ii(0x100c_ddf9, 5);  mov(ebx, 0x38);                       /* mov ebx, 0x38 */
            ii(0x100c_ddfe, 5);  mov(edx, 5);                          /* mov edx, 0x5 */
            ii(0x100c_de03, 5);  mov(eax, 0x101c_35a4);                /* mov eax, 0x101c35a4 */
            ii(0x100c_de08, 5);  call(0x100d_53a4, 0x7597);            /* call 0x100d53a4 */
            ii(0x100c_de0d, 5);  mov(ecx, 0xc7);                       /* mov ecx, 0xc7 */
            ii(0x100c_de12, 5);  mov(ebx, 0xd7);                       /* mov ebx, 0xd7 */
            ii(0x100c_de17, 5);  mov(edx, 0xb3);                       /* mov edx, 0xb3 */
            ii(0x100c_de1c, 5);  mov(eax, 0x101c_35a8);                /* mov eax, 0x101c35a8 */
            ii(0x100c_de21, 5);  call(0x100d_53a4, 0x757e);            /* call 0x100d53a4 */
            ii(0x100c_de26, 5);  mov(eax, 0x101c_35b0);                /* mov eax, 0x101c35b0 */
            ii(0x100c_de2b, 5);  call(0x100d_6710, 0x88e0);            /* call 0x100d6710 */
            ii(0x100c_de30, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_de31, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_de32, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_de33, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_de34, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_de35, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_de36, 1);  ret();                                /* ret */
        }
    }
}
