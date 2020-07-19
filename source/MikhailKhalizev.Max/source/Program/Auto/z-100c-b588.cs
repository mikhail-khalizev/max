using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b588-31896783")]
        public void Method_100c_b588()
        {
            ii(0x100c_b588, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100c_b58d, 5);  call(Definitions.sys_check_available_stack_size, 0x9_a7c0);/* call 0x10165d52 */
            ii(0x100c_b592, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_b593, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_b594, 1);  push(edx);                            /* push edx */
            ii(0x100c_b595, 1);  push(esi);                            /* push esi */
            ii(0x100c_b596, 1);  push(edi);                            /* push edi */
            ii(0x100c_b597, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_b598, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_b59a, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100c_b5a0, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_b5a3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_b5a6, 5);  call(Definitions.my_ctor_0x101b_6edc, -0x5_4767);/* call 0x10076e44 */
            ii(0x100c_b5ab, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_b5ae, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x100c_b5b1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_b5b4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_b5b7, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_b5ba, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_b5bd, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_b5bf, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_b5c0, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_b5c1, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_b5c2, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_b5c3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_b5c4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_b5c5, 1);  ret();                                /* ret */
        }
    }
}