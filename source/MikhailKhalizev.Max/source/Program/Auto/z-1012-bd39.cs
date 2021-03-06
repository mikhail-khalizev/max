using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_bd39-fa374b96")]
        public void Method_1012_bd39()
        {
            ii(0x1012_bd39, 5);  push(0x48);                           /* push 0x48 */
            ii(0x1012_bd3e, 5);  call(Definitions.sys_check_available_stack_size, 0x3_a00f);/* call 0x10165d52 */
            ii(0x1012_bd43, 1);  push(esi);                            /* push esi */
            ii(0x1012_bd44, 1);  push(edi);                            /* push edi */
            ii(0x1012_bd45, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_bd46, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_bd48, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x1012_bd4e, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_bd51, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1012_bd54, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1012_bd57, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1012_bd5a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_bd5d, 4);  mov(ax, memw[ds, eax + 12]);          /* mov ax, [eax+0xc] */
            ii(0x1012_bd61, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_bd64, 4);  sub(ax, memw[ds, edx + 4]);           /* sub ax, [edx+0x4] */
            ii(0x1012_bd68, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1012_bd6b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_bd6e, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1012_bd70, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1012_bd73, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_bd76, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x1012_bd79, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1012_bd7c, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_bd80, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1012_bd84, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1012_bd87, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1012_bd89, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1012_bd8c, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1012_bd8f, 2);  sbb(eax, edx);                        /* sbb eax, edx */
            ii(0x1012_bd91, 3);  sar(eax, 2);                          /* sar eax, 0x2 */
            ii(0x1012_bd94, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_bd96, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_bd99, 3);  add(edx, memd[ds, eax + 4]);          /* add edx, [eax+0x4] */
            ii(0x1012_bd9c, 1);  inc(edx);                             /* inc edx */
            ii(0x1012_bd9d, 3);  mov(memd[ss, ebp - 32], edx);         /* mov [ebp-0x20], edx */
            ii(0x1012_bda0, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1012_bda4, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1012_bda8, 1);  inc(eax);                             /* inc eax */
            ii(0x1012_bda9, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1012_bdac, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1012_bdae, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1012_bdb1, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1012_bdb4, 2);  sbb(eax, edx);                        /* sbb eax, edx */
            ii(0x1012_bdb6, 3);  sar(eax, 2);                          /* sar eax, 0x2 */
            ii(0x1012_bdb9, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_bdbb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_bdbe, 3);  add(edx, memd[ds, eax + 4]);          /* add edx, [eax+0x4] */
            ii(0x1012_bdc1, 1);  dec(edx);                             /* dec edx */
            ii(0x1012_bdc2, 3);  mov(memd[ss, ebp - 24], edx);         /* mov [ebp-0x18], edx */
            ii(0x1012_bdc5, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_bdc7, 3);  mov(al, memb[ss, ebp + 36]);          /* mov al, [ebp+0x24] */
            ii(0x1012_bdca, 1);  push(eax);                            /* push eax */
            ii(0x1012_bdcb, 4);  movsx(eax, memw[ss, ebp + 32]);       /* movsx eax, word [ebp+0x20] */
            ii(0x1012_bdcf, 1);  push(eax);                            /* push eax */
            ii(0x1012_bdd0, 4);  movsx(eax, memw[ss, ebp + 28]);       /* movsx eax, word [ebp+0x1c] */
            ii(0x1012_bdd4, 1);  push(eax);                            /* push eax */
            ii(0x1012_bdd5, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x1012_bdd9, 1);  push(eax);                            /* push eax */
            ii(0x1012_bdda, 4);  movsx(eax, memw[ss, ebp + 20]);       /* movsx eax, word [ebp+0x14] */
            ii(0x1012_bdde, 1);  push(eax);                            /* push eax */
            ii(0x1012_bddf, 4);  movsx(ecx, memw[ss, ebp + 16]);       /* movsx ecx, word [ebp+0x10] */
            ii(0x1012_bde3, 3);  lea(ebx, memd[ss, ebp - 36]);         /* lea ebx, [ebp-0x24] */
            ii(0x1012_bde6, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1012_bde9, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_bdec, 5);  call(0x1012_bae2, -0x30f);            /* call 0x1012bae2 */
            ii(0x1012_bdf1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_bdf3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_bdf4, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_bdf5, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_bdf6, 3);  ret(0x18);                            /* ret 0x18 */
        }
    }
}
