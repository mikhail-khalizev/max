using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_b518-e475ab1d")]
        public void Method_1013_b518()
        {
            ii(0x1013_b518, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1013_b51d, 5);  call(Definitions.sys_check_available_stack_size, 0x2_a830);/* call 0x10165d52 */
            ii(0x1013_b522, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_b523, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_b524, 1);  push(esi);                            /* push esi */
            ii(0x1013_b525, 1);  push(edi);                            /* push edi */
            ii(0x1013_b526, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_b527, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_b529, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1013_b52f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_b532, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_b535, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1013_b537, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_b53a, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_b53d, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_b540, 3);  mov(ebx, memd[ds, eax + 10]);         /* mov ebx, [eax+0xa] */
            ii(0x1013_b543, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_b546, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_b549, 2);  call_abs(memd[ds, ebx]);              /* call dword [ebx] */
            ii(0x1013_b54b, 3);  mov(esi, memd[ss, ebp - 8]);          /* mov esi, [ebp-0x8] */
            ii(0x1013_b54e, 2);  mov(ebx, ecx);                        /* mov ebx, ecx */
            ii(0x1013_b550, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1013_b552, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1013_b554, 5);  call(0x1013_b3e6, -0x173);            /* call 0x1013b3e6 */
            ii(0x1013_b559, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_b55c, 4);  movsx(ebx, memw[ss, ebp - 12]);       /* movsx ebx, word [ebp-0xc] */
            ii(0x1013_b560, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_b563, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_b566, 5);  call(0x1013_b0f9, -0x472);            /* call 0x1013b0f9 */
            ii(0x1013_b56b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_b56e, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_b571, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_b574, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_b576, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_b577, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_b578, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_b579, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_b57a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_b57b, 1);  ret();                                /* ret */
        }
    }
}
