using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_c9c6-438d93eb")]
        public void Method_1007_c9c6()
        {
            ii(0x1007_c9c6, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1007_c9cb, 5);  call(Definitions.sys_check_available_stack_size, 0xe_9382);/* call 0x10165d52 */
            ii(0x1007_c9d0, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_c9d1, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_c9d2, 1);  push(esi);                            /* push esi */
            ii(0x1007_c9d3, 1);  push(edi);                            /* push edi */
            ii(0x1007_c9d4, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_c9d5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_c9d7, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1007_c9dd, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_c9e0, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_c9e3, 5);  mov(ecx, 0x1e);                       /* mov ecx, 0x1e */
            ii(0x1007_c9e8, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1007_c9ea, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1007_c9ee, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_c9f1, 5);  call(0x100a_26d1, 0x2_5cdb);          /* call 0x100a26d1 */
            ii(0x1007_c9f6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_c9f9, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_c9fc, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_c9ff, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_ca02, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1007_ca05, 5);  call(0x1007_64fc, -0x650e);           /* call 0x100764fc */
            ii(0x1007_ca0a, 3);  sub(eax, 0x13);                       /* sub eax, 0x13 */
            ii(0x1007_ca0d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_ca10, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_ca13, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_ca16, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_ca19, 7);  mov(memd[ds, eax + 2], 0x101b_3e90);  /* mov dword [eax+0x2], 0x101b3e90 */
            ii(0x1007_ca20, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_ca23, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_ca26, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_ca29, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_ca2b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_ca2c, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_ca2d, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_ca2e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_ca2f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_ca30, 1);  ret();                                /* ret */
        }
    }
}
