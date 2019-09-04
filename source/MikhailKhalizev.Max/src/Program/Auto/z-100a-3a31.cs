using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_3a31-52723539")]
        public void Method_100a_3a31()
        {
            ii(0x100a_3a31, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_3a36, 5);  call(Definitions.sys_check_available_stack_size, 0xc_2317);/* call 0x10165d52 */
            ii(0x100a_3a3b, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_3a3c, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_3a3d, 1);  push(edx);                            /* push edx */
            ii(0x100a_3a3e, 1);  push(esi);                            /* push esi */
            ii(0x100a_3a3f, 1);  push(edi);                            /* push edi */
            ii(0x100a_3a40, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_3a41, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_3a43, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_3a49, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_3a4c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_3a4e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_3a51, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x100a_3a54, 5);  call(0x1008_af28, -0x1_8b31);         /* call 0x1008af28 */
            ii(0x100a_3a59, 5);  call(0x100a_b1c8, 0x776a);            /* call 0x100ab1c8 */
            ii(0x100a_3a5e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_3a61, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x100a_3a64, 5);  call(0x1008_af28, -0x1_8b41);         /* call 0x1008af28 */
            ii(0x100a_3a69, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_3a6c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_3a6f, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100a_3a72, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_3a75, 3);  call_abs(memd[ds, edx + 60]);         /* call dword [edx+0x3c] */
            ii(0x100a_3a78, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_3a7a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_3a7b, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_3a7c, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_3a7d, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_3a7e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_3a7f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_3a80, 1);  ret();                                /* ret */
        }
    }
}
