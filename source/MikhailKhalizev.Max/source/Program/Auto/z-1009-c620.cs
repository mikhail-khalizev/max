using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c620-8efd51ca")]
        public void Method_1009_c620()
        {
            ii(0x1009_c620, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1009_c625, 5);  call(Definitions.sys_check_available_stack_size, 0xc_9728);/* call 0x10165d52 */
            ii(0x1009_c62a, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_c62b, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_c62c, 1);  push(edx);                            /* push edx */
            ii(0x1009_c62d, 1);  push(esi);                            /* push esi */
            ii(0x1009_c62e, 1);  push(edi);                            /* push edi */
            ii(0x1009_c62f, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_c630, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_c632, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_c638, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_c63b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_c63e, 5);  call(0x1007_6d58, -0x2_58eb);         /* call 0x10076d58 */
            ii(0x1009_c643, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_c646, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x1009_c649, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c64c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_c64f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_c652, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_c655, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_c657, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_c658, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_c659, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_c65a, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_c65b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_c65c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_c65d, 1);  ret();                                /* ret */
        }
    }
}
