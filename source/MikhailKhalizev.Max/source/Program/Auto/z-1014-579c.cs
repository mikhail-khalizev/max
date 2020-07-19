using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_579c-e0c2d68a")]
        public void Method_1014_579c()
        {
            ii(0x1014_579c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1014_57a1, 5);  call(Definitions.sys_check_available_stack_size, 0x2_05ac);/* call 0x10165d52 */
            ii(0x1014_57a6, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_57a7, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_57a8, 1);  push(esi);                            /* push esi */
            ii(0x1014_57a9, 1);  push(edi);                            /* push edi */
            ii(0x1014_57aa, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_57ab, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_57ad, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1014_57b3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_57b6, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_57b9, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1014_57bd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_57c0, 5);  call(0x1013_b399, -0xa42c);           /* call 0x1013b399 */
            ii(0x1014_57c5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_57c8, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1014_57cb, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_57ce, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_57d1, 7);  mov(memd[ds, eax + 10], 0x101b_7200); /* mov dword [eax+0xa], 0x101b7200 */
            ii(0x1014_57d8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_57db, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_57de, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_57e1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_57e3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_57e4, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_57e5, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_57e6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_57e7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_57e8, 1);  ret();                                /* ret */
        }
    }
}
