using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_5e24-f29f63d5")]
        public void Method_1007_5e24()
        {
            ii(0x1007_5e24, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_5e29, 5);  call(Definitions.sys_check_available_stack_size, 0xe_ff24);/* call 0x10165d52 */
            ii(0x1007_5e2e, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_5e2f, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_5e30, 1);  push(esi);                            /* push esi */
            ii(0x1007_5e31, 1);  push(edi);                            /* push edi */
            ii(0x1007_5e32, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_5e33, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_5e35, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1007_5e3b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_5e3e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_5e41, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1007_5e46, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_5e49, 5);  call(Definitions.my_dtor_0x101b_6edc, 0xc_4df7);/* call 0x1013ac45 */
            ii(0x1007_5e4e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_5e51, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_5e54, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_5e57, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_5e5a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_5e5c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_5e5d, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_5e5e, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_5e5f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_5e60, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_5e61, 1);  ret();                                /* ret */
        }
    }
}
