using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_f56c-bea7ba77")]
        public void Method_1013_f56c()
        {
            ii(0x1013_f56c, 5);  push(0x34);                           /* push 0x34 */
            ii(0x1013_f571, 5);  call(Definitions.sys_check_available_stack_size, 0x2_67dc);/* call 0x10165d52 */
            ii(0x1013_f576, 1);  push(esi);                            /* push esi */
            ii(0x1013_f577, 1);  push(edi);                            /* push edi */
            ii(0x1013_f578, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_f579, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_f57b, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x1013_f581, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_f584, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_f587, 3);  mov(memd[ss, ebp - 12], ebx);         /* mov [ebp-0xc], ebx */
            ii(0x1013_f58a, 3);  mov(memd[ss, ebp - 8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x1013_f58d, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1013_f594, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x1013_f59b, 2);  jmp(0x1013_f5a3, 6); goto l_0x1013_f5a3;/* jmp 0x1013f5a3 */
        l_0x1013_f59d:
            ii(0x1013_f59d, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1013_f5a0, 3);  inc(memd[ss, ebp - 32]);              /* inc dword [ebp-0x20] */
        l_0x1013_f5a3:
            ii(0x1013_f5a3, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1013_f5a6, 4);  cmp(ax, memw[ss, ebp - 8]);           /* cmp ax, [ebp-0x8] */
            ii(0x1013_f5aa, 2);  if(jge(0x1013_f612, 0x66)) goto l_0x1013_f612;/* jge 0x1013f612 */
            ii(0x1013_f5ac, 4);  movsx(edx, memw[ss, ebp - 32]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1013_f5b0, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x1013_f5b5, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1013_f5b7, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1013_f5ba, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1013_f5bc, 3);  mov(memd[ss, ebp - 20], edx);         /* mov [ebp-0x14], edx */
            ii(0x1013_f5bf, 4);  movsx(edx, memw[ss, ebp - 32]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1013_f5c3, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x1013_f5c8, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1013_f5ca, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1013_f5cd, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1013_f5cf, 4);  movsx(edx, memw[ss, ebp + 20]);       /* movsx edx, word [ebp+0x14] */
            ii(0x1013_f5d3, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x1013_f5d6, 4);  movsx(ebx, memw[ss, ebp - 20]);       /* movsx ebx, word [ebp-0x14] */
            ii(0x1013_f5da, 4);  movsx(edx, memw[ss, ebp + 16]);       /* movsx edx, word [ebp+0x10] */
            ii(0x1013_f5de, 3);  imul(edx, ebx);                       /* imul edx, ebx */
            ii(0x1013_f5e1, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1013_f5e3, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_f5e6, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_f5e9, 4);  imul(eax, memd[ss, ebp + 24]);        /* imul eax, [ebp+0x18] */
            ii(0x1013_f5ed, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_f5f0, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x1013_f5f3, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_f5f7, 4);  movsx(ecx, memw[ss, ebp - 24]);       /* movsx ecx, word [ebp-0x18] */
            ii(0x1013_f5fb, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_f5ff, 3);  imul(ecx, eax);                       /* imul ecx, eax */
            ii(0x1013_f602, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_f606, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x1013_f609, 2);  add(eax, ecx);                        /* add eax, ecx */
            ii(0x1013_f60b, 5);  call(0x1013_f410, -0x200);            /* call 0x1013f410 */
            ii(0x1013_f610, 2);  jmp(0x1013_f59d, -0x75); goto l_0x1013_f59d;/* jmp 0x1013f59d */
        l_0x1013_f612:
            ii(0x1013_f612, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_f615, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_f618, 3);  add(ax, memw[ds, edx]);               /* add ax, [edx] */
            ii(0x1013_f61b, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_f61e, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_f621, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_f623, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_f624, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_f625, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_f626, 3);  ret(0xc);                             /* ret 0xc */
        }
    }
}
