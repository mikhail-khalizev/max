using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1a2c-5ec854d7")]
        public void Method_1013_1a2c()
        {
            ii(0x1013_1a2c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_1a31, 5);  call(Definitions.sys_check_available_stack_size, 0x3_431c);/* call 0x10165d52 */
            ii(0x1013_1a36, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_1a37, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_1a38, 1);  push(edx);                            /* push edx */
            ii(0x1013_1a39, 1);  push(esi);                            /* push esi */
            ii(0x1013_1a3a, 1);  push(edi);                            /* push edi */
            ii(0x1013_1a3b, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_1a3c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_1a3e, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1013_1a44, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_1a47, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_1a4a, 3);  add(eax, 0xa);                        /* add eax, 0xa */
            ii(0x1013_1a4d, 5);  call(Definitions.my_strobj_c_str_v2, -0xa_828a);/* call 0x100897c8 */
            ii(0x1013_1a52, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_1a55, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_1a58, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_1a5a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_1a5b, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_1a5c, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_1a5d, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_1a5e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_1a5f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_1a60, 1);  ret();                                /* ret */
        }
    }
}
