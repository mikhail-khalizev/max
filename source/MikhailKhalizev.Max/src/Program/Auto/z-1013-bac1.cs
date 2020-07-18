using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_bac1-213c8572")]
        public void Method_1013_bac1()
        {
            ii(0x1013_bac1, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_bac6, 5);  call(Definitions.sys_check_available_stack_size, 0x2_a287);/* call 0x10165d52 */
            ii(0x1013_bacb, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_bacc, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_bacd, 1);  push(esi);                            /* push esi */
            ii(0x1013_bace, 1);  push(edi);                            /* push edi */
            ii(0x1013_bacf, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_bad0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_bad2, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_bad8, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_badb, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_bade, 5);  call(0x1013_c6ac, 0xbc9);             /* call 0x1013c6ac */
            ii(0x1013_bae3, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1013_bae6, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_bae9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_baec, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x1013_baef, 5);  call(0x1013_c5c0, 0xacc);             /* call 0x1013c5c0 */
            ii(0x1013_baf4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_baf7, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_bafa, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_bafd, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x1013_bb00, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_bb03, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_bb06, 3);  call_abs(memd[ds, ebx + 8]);          /* call dword [ebx+0x8] */
            ii(0x1013_bb09, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_bb0b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_bb0c, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_bb0d, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_bb0e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_bb0f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_bb10, 1);  ret();                                /* ret */
        }
    }
}
