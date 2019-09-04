using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_25ae-6a9a54da")]
        public void Method_1012_25ae()
        {
            ii(0x1012_25ae, 5);  push(0x44);                           /* push 0x44 */
            ii(0x1012_25b3, 5);  call(Definitions.sys_check_available_stack_size, 0x4_379a);/* call 0x10165d52 */
            ii(0x1012_25b8, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_25b9, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_25ba, 1);  push(esi);                            /* push esi */
            ii(0x1012_25bb, 1);  push(edi);                            /* push edi */
            ii(0x1012_25bc, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_25bd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_25bf, 6);  sub(esp, 0x2c);                       /* sub esp, 0x2c */
            ii(0x1012_25c5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_25c8, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_25cb, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1012_25cf, 3);  imul(edx, edx, 0x1c);                 /* imul edx, edx, 0x1c */
            ii(0x1012_25d2, 5);  mov(eax, 0x101b_b05c);                /* mov eax, 0x101bb05c */
            ii(0x1012_25d7, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1012_25d9, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1012_25dc, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_25df, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x1012_25e2, 5);  call(0x100d_4ef0, -0x4_d6f7);         /* call 0x100d4ef0 */
            ii(0x1012_25e7, 1);  cwde();                               /* cwde */
            ii(0x1012_25e8, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1012_25eb, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_25ee, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x1012_25f1, 5);  call(0x100d_4ebc, -0x4_d73a);         /* call 0x100d4ebc */
            ii(0x1012_25f6, 1);  cwde();                               /* cwde */
            ii(0x1012_25f7, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1012_25fa, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_25fd, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x1012_2600, 5);  call(0x100d_4f58, -0x4_d6ad);         /* call 0x100d4f58 */
            ii(0x1012_2605, 1);  cwde();                               /* cwde */
            ii(0x1012_2606, 3);  mov(edx, memd[ss, ebp - 36]);         /* mov edx, [ebp-0x24] */
            ii(0x1012_2609, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1012_260b, 3);  mov(memd[ss, ebp - 28], edx);         /* mov [ebp-0x1c], edx */
            ii(0x1012_260e, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_2611, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x1012_2614, 5);  call(0x100d_4f24, -0x4_d6f5);         /* call 0x100d4f24 */
            ii(0x1012_2619, 1);  cwde();                               /* cwde */
            ii(0x1012_261a, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x1012_261d, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1012_261f, 3);  mov(memd[ss, ebp - 24], edx);         /* mov [ebp-0x18], edx */
            ii(0x1012_2622, 3);  lea(ebx, memd[ss, ebp - 40]);         /* lea ebx, [ebp-0x28] */
            ii(0x1012_2625, 3);  lea(edx, memd[ss, ebp - 44]);         /* lea edx, [ebp-0x2c] */
            ii(0x1012_2628, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_262b, 5);  call(0x100d_6a92, -0x4_bb9e);         /* call 0x100d6a92 */
            ii(0x1012_2630, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1012_2633, 3);  add(eax, 0xa);                        /* add eax, 0xa */
            ii(0x1012_2636, 3);  mov(edx, memd[ss, ebp - 44]);         /* mov edx, [ebp-0x2c] */
            ii(0x1012_2639, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x1012_263b, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_263e, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x1012_2641, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1012_2644, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1012_2647, 3);  mov(ebx, memd[ss, ebp - 28]);         /* mov ebx, [ebp-0x1c] */
            ii(0x1012_264a, 3);  sub(ebx, memd[ss, ebp - 36]);         /* sub ebx, [ebp-0x24] */
            ii(0x1012_264d, 3);  sub(ebx, 0x14);                       /* sub ebx, 0x14 */
            ii(0x1012_2650, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1012_2652, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1012_2655, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1012_2657, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_265a, 4);  movsx(ebx, memw[ss, ebp - 16]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x1012_265e, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1012_2662, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_2665, 5);  call(0x1012_245e, -0x20c);            /* call 0x1012245e */
            ii(0x1012_266a, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x1012_266d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_2670, 3);  mov(eax, memd[ds, eax + 41]);         /* mov eax, [eax+0x29] */
            ii(0x1012_2673, 5);  call(Definitions.sys_display_draw_1, 0x4_4e30);/* call 0x101674a8 */
            ii(0x1012_2678, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_267b, 4);  cmp(memb[ds, eax + 5], 0x54);         /* cmp byte [eax+0x5], 0x54 */
            ii(0x1012_267f, 2);  if(jz(0x1012_26bc, 0x3b)) goto l_0x1012_26bc;/* jz 0x101226bc */
            ii(0x1012_2681, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_2684, 4);  cmp(memb[ds, eax + 5], 0x36);         /* cmp byte [eax+0x5], 0x36 */
            ii(0x1012_2688, 2);  if(jnz(0x1012_2690, 6)) goto l_0x1012_2690;/* jnz 0x10122690 */
            ii(0x1012_268a, 4);  mov(memb[ss, ebp - 12], 4);           /* mov byte [ebp-0xc], 0x4 */
            ii(0x1012_268e, 2);  jmp(0x1012_26a3, 0x13); goto l_0x1012_26a3;/* jmp 0x101226a3 */
        l_0x1012_2690:
            ii(0x1012_2690, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_2693, 4);  cmp(memb[ds, eax + 5], 0x37);         /* cmp byte [eax+0x5], 0x37 */
            ii(0x1012_2697, 2);  if(jnz(0x1012_269f, 6)) goto l_0x1012_269f;/* jnz 0x1012269f */
            ii(0x1012_2699, 4);  mov(memb[ss, ebp - 12], 2);           /* mov byte [ebp-0xc], 0x2 */
            ii(0x1012_269d, 2);  jmp(0x1012_26a3, 4); goto l_0x1012_26a3;/* jmp 0x101226a3 */
        l_0x1012_269f:
            ii(0x1012_269f, 4);  mov(memb[ss, ebp - 12], 3);           /* mov byte [ebp-0xc], 0x3 */
        l_0x1012_26a3:
            ii(0x1012_26a3, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1012_26a7, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_26aa, 3);  mov(ebx, memd[ds, eax + 22]);         /* mov ebx, [eax+0x16] */
            ii(0x1012_26ad, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1012_26b0, 4);  movsx(edx, memb[ss, ebp - 12]);       /* movsx edx, byte [ebp-0xc] */
            ii(0x1012_26b4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_26b7, 5);  call(0x1012_26c4, 8);                 /* call 0x101226c4 */
        l_0x1012_26bc:
            ii(0x1012_26bc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_26be, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_26bf, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_26c0, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_26c1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_26c2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_26c3, 1);  ret();                                /* ret */
        }
    }
}
