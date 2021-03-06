using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_c198-f9a8990")]
        public void Method_100a_c198()
        {
            ii(0x100a_c198, 5);  push(0x30);                           /* push 0x30 */
            ii(0x100a_c19d, 5);  call(Definitions.sys_check_available_stack_size, 0xb_9bb0);/* call 0x10165d52 */
            ii(0x100a_c1a2, 1);  push(esi);                            /* push esi */
            ii(0x100a_c1a3, 1);  push(edi);                            /* push edi */
            ii(0x100a_c1a4, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_c1a5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_c1a7, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x100a_c1ad, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_c1b0, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100a_c1b3, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100a_c1b6, 3);  mov(memd[ss, ebp - 8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x100a_c1b9, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_c1bc, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_c1bf, 5);  call(0x1007_5e64, -0x3_6360);         /* call 0x10075e64 */
            ii(0x100a_c1c4, 4);  movsx(ebx, memb[ss, ebp - 4]);        /* movsx ebx, byte [ebp-0x4] */
            ii(0x100a_c1c8, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100a_c1cb, 3);  mov(esi, memd[ss, ebp - 16]);         /* mov esi, [ebp-0x10] */
            ii(0x100a_c1ce, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x100a_c1d0, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x100a_c1d2, 5);  call(0x100a_beeb, -0x2ec);            /* call 0x100abeeb */
            ii(0x100a_c1d7, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_c1da, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_c1dd, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_c1e0, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_c1e3, 3);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x100a_c1e6, 5);  call(0x100a_b3f4, -0xdf7);            /* call 0x100ab3f4 */
            ii(0x100a_c1eb, 3);  sub(eax, 0x20);                       /* sub eax, 0x20 */
            ii(0x100a_c1ee, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_c1f1, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_c1f4, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_c1f7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_c1fa, 7);  mov(memd[ds, eax + 2], 0x101b_5504);  /* mov dword [eax+0x2], 0x101b5504 */
            ii(0x100a_c201, 3);  mov(edx, memd[ss, ebp + 16]);         /* mov edx, [ebp+0x10] */
            ii(0x100a_c204, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_c207, 3);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x100a_c20a, 5);  call(0x100b_8244, 0xc035);            /* call 0x100b8244 */
            ii(0x100a_c20f, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_c212, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100a_c215, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100a_c218, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_c21a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_c21b, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_c21c, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_c21d, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}
