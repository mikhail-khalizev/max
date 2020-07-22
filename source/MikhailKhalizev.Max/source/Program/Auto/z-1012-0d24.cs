using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0d24-56f2d0ce")]
        public void Method_1012_0d24()
        {
            ii(0x1012_0d24, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1012_0d29, 5);  call(Definitions.sys_check_available_stack_size, 0x4_5024);/* call 0x10165d52 */
            ii(0x1012_0d2e, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_0d2f, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_0d30, 1);  push(edx);                            /* push edx */
            ii(0x1012_0d31, 1);  push(esi);                            /* push esi */
            ii(0x1012_0d32, 1);  push(edi);                            /* push edi */
            ii(0x1012_0d33, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_0d34, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_0d36, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1012_0d3c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_0d3f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_0d42, 5);  call(Definitions.my_ctor_0x101b_6edc, -0xa_9f03);/* call 0x10076e44 */
            ii(0x1012_0d47, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_0d4a, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x1012_0d4d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_0d50, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_0d53, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1012_0d56, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_0d59, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_0d5b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_0d5c, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_0d5d, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_0d5e, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_0d5f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_0d60, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_0d61, 1);  ret();                                /* ret */
        }
    }
}
