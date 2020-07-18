using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_bdc8-90d64695")]
        public void Method_1013_bdc8()
        {
            ii(0x1013_bdc8, 5);  push(0x40);                           /* push 0x40 */
            ii(0x1013_bdcd, 5);  call(Definitions.sys_check_available_stack_size, 0x2_9f80);/* call 0x10165d52 */
            ii(0x1013_bdd2, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_bdd3, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_bdd4, 1);  push(edx);                            /* push edx */
            ii(0x1013_bdd5, 1);  push(esi);                            /* push esi */
            ii(0x1013_bdd6, 1);  push(edi);                            /* push edi */
            ii(0x1013_bdd7, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_bdd8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_bdda, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x1013_bde0, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_bde3, 7);  cmp(memd[ds, 0x101c_7274], 0);        /* cmp dword [0x101c7274], 0x0 */
            ii(0x1013_bdea, 2);  if(jnz(0x1013_be2b, 0x3f)) goto l_0x1013_be2b;/* jnz 0x1013be2b */
            ii(0x1013_bdec, 5);  mov(eax, 0xe);                        /* mov eax, 0xe */
            ii(0x1013_bdf1, 5);  call(Definitions.sys_new, 0x2_a00a);  /* call 0x10165e00 */
            ii(0x1013_bdf6, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_bdf9, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_bdfc, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_bdff, 4);  cmp(memd[ss, ebp - 28], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1013_be03, 2);  if(jz(0x1013_be1d, 0x18)) goto l_0x1013_be1d;/* jz 0x1013be1d */
            ii(0x1013_be05, 5);  mov(edx, 5);                          /* mov edx, 0x5 */
            ii(0x1013_be0a, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_be0d, 5);  call(0x1013_b7f5, -0x61d);            /* call 0x1013b7f5 */
            ii(0x1013_be12, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_be15, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1013_be18, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_be1b, 2);  jmp(0x1013_be23, 6); goto l_0x1013_be23;/* jmp 0x1013be23 */
        l_0x1013_be1d:
            ii(0x1013_be1d, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_be20, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
        l_0x1013_be23:
            ii(0x1013_be23, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_be26, 5);  mov(memd[ds, 0x101c_7274], eax);      /* mov [0x101c7274], eax */
        l_0x1013_be2b:
            ii(0x1013_be2b, 5);  mov(eax, 0x16);                       /* mov eax, 0x16 */
            ii(0x1013_be30, 5);  call(Definitions.sys_new, 0x2_9fcb);  /* call 0x10165e00 */
            ii(0x1013_be35, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_be38, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_be3b, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_be3e, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1013_be42, 2);  if(jz(0x1013_be5a, 0x16)) goto l_0x1013_be5a;/* jz 0x1013be5a */
            ii(0x1013_be44, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_be47, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_be4a, 5);  call(0x1013_c388, 0x539);             /* call 0x1013c388 */
            ii(0x1013_be4f, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_be52, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_be55, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_be58, 2);  jmp(0x1013_be60, 6); goto l_0x1013_be60;/* jmp 0x1013be60 */
        l_0x1013_be5a:
            ii(0x1013_be5a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_be5d, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
        l_0x1013_be60:
            ii(0x1013_be60, 3);  mov(edx, memd[ss, ebp - 36]);         /* mov edx, [ebp-0x24] */
            ii(0x1013_be63, 5);  mov(eax, memd[ds, 0x101c_7274]);      /* mov eax, [0x101c7274] */
            ii(0x1013_be68, 5);  call(0x1013_b873, -0x5fa);            /* call 0x1013b873 */
            ii(0x1013_be6d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_be6f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_be70, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_be71, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_be72, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_be73, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_be74, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_be75, 1);  ret();                                /* ret */
        }
    }
}
