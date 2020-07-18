using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8852-9ea2ea6b")]
        public void Method_100b_8852()
        {
            ii(0x100b_8852, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_8857, 5);  call(Definitions.sys_check_available_stack_size, 0xa_d4f6);/* call 0x10165d52 */
            ii(0x100b_885c, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_885d, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_885e, 1);  push(edx);                            /* push edx */
            ii(0x100b_885f, 1);  push(esi);                            /* push esi */
            ii(0x100b_8860, 1);  push(edi);                            /* push edi */
            ii(0x100b_8861, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_8862, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_8864, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_886a, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_886d, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100b_8871, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x100b_8874, 7);  test(memb[ds, eax + 0x101c_81c0], 0x40);/* test byte [eax+0x101c81c0], 0x40 */
            ii(0x100b_887b, 2);  if(jz(0x100b_8886, 9)) goto l_0x100b_8886;/* jz 0x100b8886 */
            ii(0x100b_887d, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x100b_8881, 5);  jmp(0x100b_88e4, 0x5e); goto l_0x100b_88e4;/* jmp 0x100b88e4 */
        l_0x100b_8886:
            ii(0x100b_8886, 5);  cmp(memw[ss, ebp - 4], 0x39);         /* cmp word [ebp-0x4], 0x39 */
            ii(0x100b_888b, 2);  if(jnz(0x100b_8893, 6)) goto l_0x100b_8893;/* jnz 0x100b8893 */
            ii(0x100b_888d, 4);  mov(memb[ss, ebp - 8], 4);            /* mov byte [ebp-0x8], 0x4 */
            ii(0x100b_8891, 2);  jmp(0x100b_88e4, 0x51); goto l_0x100b_88e4;/* jmp 0x100b88e4 */
        l_0x100b_8893:
            ii(0x100b_8893, 5);  cmp(memw[ss, ebp - 4], 0x47);         /* cmp word [ebp-0x4], 0x47 */
            ii(0x100b_8898, 2);  if(jnz(0x100b_88a0, 6)) goto l_0x100b_88a0;/* jnz 0x100b88a0 */
            ii(0x100b_889a, 4);  mov(memb[ss, ebp - 8], 5);            /* mov byte [ebp-0x8], 0x5 */
            ii(0x100b_889e, 2);  jmp(0x100b_88e4, 0x44); goto l_0x100b_88e4;/* jmp 0x100b88e4 */
        l_0x100b_88a0:
            ii(0x100b_88a0, 5);  cmp(memw[ss, ebp - 4], 0x42);         /* cmp word [ebp-0x4], 0x42 */
            ii(0x100b_88a5, 2);  if(jz(0x100b_88ae, 7)) goto l_0x100b_88ae;/* jz 0x100b88ae */
            ii(0x100b_88a7, 5);  cmp(memw[ss, ebp - 4], 0x43);         /* cmp word [ebp-0x4], 0x43 */
            ii(0x100b_88ac, 2);  if(jnz(0x100b_88b4, 6)) goto l_0x100b_88b4;/* jnz 0x100b88b4 */
        l_0x100b_88ae:
            ii(0x100b_88ae, 4);  mov(memb[ss, ebp - 8], 6);            /* mov byte [ebp-0x8], 0x6 */
            ii(0x100b_88b2, 2);  jmp(0x100b_88e4, 0x30); goto l_0x100b_88e4;/* jmp 0x100b88e4 */
        l_0x100b_88b4:
            ii(0x100b_88b4, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100b_88b8, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x100b_88bb, 7);  test(memb[ds, eax + 0x101c_81d4], 2); /* test byte [eax+0x101c81d4], 0x2 */
            ii(0x100b_88c2, 2);  if(jz(0x100b_88e0, 0x1c)) goto l_0x100b_88e0;/* jz 0x100b88e0 */
            ii(0x100b_88c4, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100b_88c8, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x100b_88cb, 7);  test(memb[ds, eax + 0x101c_81c1], 1); /* test byte [eax+0x101c81c1], 0x1 */
            ii(0x100b_88d2, 2);  if(jz(0x100b_88da, 6)) goto l_0x100b_88da;/* jz 0x100b88da */
            ii(0x100b_88d4, 4);  mov(memb[ss, ebp - 8], 3);            /* mov byte [ebp-0x8], 0x3 */
            ii(0x100b_88d8, 2);  jmp(0x100b_88e4, 0xa); goto l_0x100b_88e4;/* jmp 0x100b88e4 */
        l_0x100b_88da:
            ii(0x100b_88da, 4);  mov(memb[ss, ebp - 8], 2);            /* mov byte [ebp-0x8], 0x2 */
            ii(0x100b_88de, 2);  jmp(0x100b_88e4, 4); goto l_0x100b_88e4;/* jmp 0x100b88e4 */
        l_0x100b_88e0:
            ii(0x100b_88e0, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
        l_0x100b_88e4:
            ii(0x100b_88e4, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100b_88e7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_88e9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_88ea, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_88eb, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_88ec, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_88ed, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_88ee, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_88ef, 1);  ret();                                /* ret */
        }
    }
}
