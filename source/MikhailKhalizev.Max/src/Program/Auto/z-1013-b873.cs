using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_b873-6d09daca")]
        public void Method_1013_b873()
        {
            ii(0x1013_b873, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1013_b878, 5);  call(Definitions.sys_check_available_stack_size, 0x2_a4d5);/* call 0x10165d52 */
            ii(0x1013_b87d, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_b87e, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_b87f, 1);  push(esi);                            /* push esi */
            ii(0x1013_b880, 1);  push(edi);                            /* push edi */
            ii(0x1013_b881, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_b882, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_b884, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1013_b88a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_b88d, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_b890, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_b893, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_b896, 5);  call(0x1013_b518, -0x383);            /* call 0x1013b518 */
            ii(0x1013_b89b, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_b89e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_b8a1, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_b8a4, 2);  jmp(0x1013_b8ac, 6); goto l_0x1013_b8ac;/* jmp 0x1013b8ac */
        l_0x1013_b8a6:
            ii(0x1013_b8a6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_b8a9, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1013_b8ac:
            ii(0x1013_b8ac, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_b8af, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_b8b2, 4);  cmp(ax, memw[ds, edx + 4]);           /* cmp ax, [edx+0x4] */
            ii(0x1013_b8b6, 2);  if(jge(0x1013_b8d9, 0x21)) goto l_0x1013_b8d9;/* jge 0x1013b8d9 */
            ii(0x1013_b8b8, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_b8bb, 1);  inc(eax);                             /* inc eax */
            ii(0x1013_b8bc, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1013_b8bf, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1013_b8c3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_b8c6, 5);  call(0x1013_c7d0, 0xf05);             /* call 0x1013c7d0 */
            ii(0x1013_b8cb, 5);  call(0x1013_c838, 0xf68);             /* call 0x1013c838 */
            ii(0x1013_b8d0, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x1013_b8d2, 5);  call(0x1013_c8cc, 0xff5);             /* call 0x1013c8cc */
            ii(0x1013_b8d7, 2);  jmp(0x1013_b8a6, -0x33); goto l_0x1013_b8a6;/* jmp 0x1013b8a6 */
        l_0x1013_b8d9:
            ii(0x1013_b8d9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_b8db, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_b8dc, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_b8dd, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_b8de, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_b8df, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_b8e0, 1);  ret();                                /* ret */
        }
    }
}
