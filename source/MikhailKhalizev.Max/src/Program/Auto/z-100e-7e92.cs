using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_7e92-2a842e07")]
        public void Method_100e_7e92()
        {
            ii(0x100e_7e92, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_7e97, 5);  call(Definitions.sys_check_available_stack_size, 0x7_deb6);/* call 0x10165d52 */
            ii(0x100e_7e9c, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_7e9d, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_7e9e, 1);  push(esi);                            /* push esi */
            ii(0x100e_7e9f, 1);  push(edi);                            /* push edi */
            ii(0x100e_7ea0, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_7ea1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_7ea3, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100e_7ea9, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_7eac, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_7eaf, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_7eb2, 5);  call(0x100e_7ec8, 0x11);              /* call 0x100e7ec8 */
            ii(0x100e_7eb7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_7eba, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_7ebd, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_7ec0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_7ec2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_7ec3, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_7ec4, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_7ec5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_7ec6, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_7ec7, 1);  ret();                                /* ret */
        }
    }
}
