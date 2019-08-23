using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_0640-5d0c6c17")]
        public void Method_100b_0640()
        {
            ii(0x100b_0640, 5); push(0x28);                             /* push 0x28 */
            ii(0x100b_0645, 5); call(Definitions.sys_check_available_stack_size, 0xb_5708); /* call 0x10165d52 */
            ii(0x100b_064a, 1); push(esi);                              /* push esi */
            ii(0x100b_064b, 1); push(edi);                              /* push edi */
            ii(0x100b_064c, 1); push(ebp);                              /* push ebp */
            ii(0x100b_064d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_064f, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100b_0655, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_0658, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100b_065b, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100b_065e, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100b_0661, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_0664, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100b_0667, 4); cmp(memd[ss, ebp - 0x4], 0);            /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100b_066b, 2); if(jnz(0x100b_0677, 0xa)) goto l_0x100b_0677; /* jnz 0x100b0677 */
            ii(0x100b_066d, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_0670, 5); call(0x100b_0383, -0x2f2);              /* call 0x100b0383 */
            ii(0x100b_0675, 2); jmp(0x100b_069f, 0x28); goto l_0x100b_069f; /* jmp 0x100b069f */
        l_0x100b_0677:
            ii(0x100b_0677, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x100b_067a, 3); add(edx, 0x21);                         /* add edx, 0x21 */
            ii(0x100b_067d, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_0680, 5); call(0x1007_5e64, -0x3_a821);           /* call 0x10075e64 */
            ii(0x100b_0685, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_0687, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_068a, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_068d, 5); call(0x1008_a520, -0x2_6172);           /* call 0x1008a520 */
            ii(0x100b_0692, 5); call(0x100b_7d34, 0x769d);              /* call 0x100b7d34 */
            ii(0x100b_0697, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_069a, 5); call(0x100b_06da, 0x3b);                /* call 0x100b06da */
        l_0x100b_069f:
            ii(0x100b_069f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_06a1, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_06a2, 1); pop(edi);                               /* pop edi */
            ii(0x100b_06a3, 1); pop(esi);                               /* pop esi */
            ii(0x100b_06a4, 3); ret(0x4);                               /* ret 0x4 */
        }
    }
}
