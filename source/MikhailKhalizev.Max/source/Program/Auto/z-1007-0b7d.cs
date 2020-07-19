using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_0b7d-b2df8a25")]
        public void Method_1007_0b7d()
        {
            ii(0x1007_0b7d, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1007_0b82, 5);  call(Definitions.sys_check_available_stack_size, 0xf_51cb);/* call 0x10165d52 */
            ii(0x1007_0b87, 1);  push(esi);                            /* push esi */
            ii(0x1007_0b88, 1);  push(edi);                            /* push edi */
            ii(0x1007_0b89, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_0b8a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_0b8c, 6);  sub(esp, 0x28);                       /* sub esp, 0x28 */
            ii(0x1007_0b92, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_0b95, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1007_0b98, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1007_0b9b, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1007_0b9e, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_0ba2, 3);  shl(eax, 6);                          /* shl eax, 0x6 */
            ii(0x1007_0ba5, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_0ba8, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_0bab, 4);  imul(eax, memd[ss, ebp - 20]);        /* imul eax, [ebp-0x14] */
            ii(0x1007_0baf, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_0bb2, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_0bb5, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1007_0bb8, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_0bbb, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1007_0bbf, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x1007_0bc1, 3);  shl(edx, 6);                          /* shl edx, 0x6 */
            ii(0x1007_0bc4, 3);  mov(memd[ss, ebp - 24], edx);         /* mov [ebp-0x18], edx */
            ii(0x1007_0bc7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_0bca, 3);  mov(eax, memd[ds, eax + 26]);         /* mov eax, [eax+0x1a] */
            ii(0x1007_0bcd, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_0bd0, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1007_0bd4, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x1007_0bd6, 3);  shl(edx, 6);                          /* shl edx, 0x6 */
            ii(0x1007_0bd9, 3);  mov(memd[ss, ebp - 28], edx);         /* mov [ebp-0x1c], edx */
            ii(0x1007_0bdc, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x1007_0bdf, 4);  imul(edx, memd[ss, ebp - 24]);        /* imul edx, [ebp-0x18] */
            ii(0x1007_0be3, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_0be6, 4);  imul(eax, memd[ss, ebp - 28]);        /* imul eax, [ebp-0x1c] */
            ii(0x1007_0bea, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1007_0bec, 3);  mov(memd[ss, ebp - 32], edx);         /* mov [ebp-0x20], edx */
            ii(0x1007_0bef, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1007_0bf2, 3);  cmp(eax, memd[ss, ebp - 20]);         /* cmp eax, [ebp-0x14] */
            ii(0x1007_0bf5, 2);  if(jg(0x1007_0c00, 9)) goto l_0x1007_0c00;/* jg 0x10070c00 */
            ii(0x1007_0bf7, 7);  mov(memd[ss, ebp - 36], 1);           /* mov dword [ebp-0x24], 0x1 */
            ii(0x1007_0bfe, 2);  jmp(0x1007_0c07, 7); goto l_0x1007_0c07;/* jmp 0x10070c07 */
        l_0x1007_0c00:
            ii(0x1007_0c00, 7);  mov(memd[ss, ebp - 36], 0);           /* mov dword [ebp-0x24], 0x0 */
        l_0x1007_0c07:
            ii(0x1007_0c07, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1007_0c0a, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1007_0c0d, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_0c10, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_0c12, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_0c13, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_0c14, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_0c15, 1);  ret();                                /* ret */
        }
    }
}
