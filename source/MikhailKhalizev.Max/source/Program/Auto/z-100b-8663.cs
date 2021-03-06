using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8663-8c66ddf1")]
        public void Method_100b_8663()
        {
            ii(0x100b_8663, 5);  push(0x30);                           /* push 0x30 */
            ii(0x100b_8668, 5);  call(Definitions.sys_check_available_stack_size, 0xa_d6e5);/* call 0x10165d52 */
            ii(0x100b_866d, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_866e, 1);  push(esi);                            /* push esi */
            ii(0x100b_866f, 1);  push(edi);                            /* push edi */
            ii(0x100b_8670, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_8671, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_8673, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x100b_8679, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_867c, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100b_867f, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100b_8682, 4);  or(memb[ss, ebp - 16], 1);            /* or byte [ebp-0x10], 0x1 */
            ii(0x100b_8686, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100b_868b, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100b_868e, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_8691, 5);  call(0x100b_8505, -0x191);            /* call 0x100b8505 */
            ii(0x100b_8696, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_8699, 4);  and(memb[ss, ebp - 16], -2 /* 0xfe */);/* and byte [ebp-0x10], 0xfe */
            ii(0x100b_869d, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100b_86a4, 2);  jmp(0x100b_86ac, 6); goto l_0x100b_86ac;/* jmp 0x100b86ac */
        l_0x100b_86a6:
            ii(0x100b_86a6, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100b_86a9, 3);  inc(memd[ss, ebp - 28]);              /* inc dword [ebp-0x1c] */
        l_0x100b_86ac:
            ii(0x100b_86ac, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_86af, 5);  call(0x1008_a4a0, -0x2_e214);         /* call 0x1008a4a0 */
            ii(0x100b_86b4, 4);  cmp(ax, memw[ss, ebp - 28]);          /* cmp ax, [ebp-0x1c] */
            ii(0x100b_86b8, 2);  if(jle(0x100b_86d6, 0x1c)) goto l_0x100b_86d6;/* jle 0x100b86d6 */
            ii(0x100b_86ba, 4);  movsx(edx, memw[ss, ebp - 28]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100b_86be, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_86c1, 5);  call(0x1008_a3dc, -0x2_e2ea);         /* call 0x1008a3dc */
            ii(0x100b_86c6, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_86c8, 4);  mov(ax, memw[ds, edx + 2]);           /* mov ax, [edx+0x2] */
            ii(0x100b_86cc, 4);  imul(eax, memd[ss, ebp - 4]);         /* imul eax, [ebp-0x4] */
            ii(0x100b_86d0, 4);  mov(memw[ds, edx + 2], ax);           /* mov [edx+0x2], ax */
            ii(0x100b_86d4, 2);  jmp(0x100b_86a6, -0x30); goto l_0x100b_86a6;/* jmp 0x100b86a6 */
        l_0x100b_86d6:
            ii(0x100b_86d6, 5);  call(0x1008_a4dc, -0x2_e1ff);         /* call 0x1008a4dc */
            ii(0x100b_86db, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100b_86dd, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100b_86df, 3);  lea(edx, memd[ss, ebp - 20]);         /* lea edx, [ebp-0x14] */
            ii(0x100b_86e2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_86e5, 5);  call(0x100b_8505, -0x1e5);            /* call 0x100b8505 */
            ii(0x100b_86ea, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_86ec, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_86ef, 5);  call(0x1008_8dcc, -0x2_f928);         /* call 0x10088dcc */
            ii(0x100b_86f4, 2);  jmp(0x100b_8700, 0xa); goto l_0x100b_8700;/* jmp 0x100b8700 */
        //  ii(0x100b_86f6, 10);  Недостижимый код.
        l_0x100b_8700:
            ii(0x100b_8700, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_8703, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_8705, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_8706, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_8707, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_8708, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_8709, 1);  ret();                                /* ret */
        }
    }
}
