using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_b719-be83c2c3")]
        public void Method_1011_b719()
        {
            ii(0x1011_b719, 5);  push(0x34);                           /* push 0x34 */
            ii(0x1011_b71e, 5);  call(Definitions.sys_check_available_stack_size, 0x4_a62f);/* call 0x10165d52 */
            ii(0x1011_b723, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_b724, 1);  push(esi);                            /* push esi */
            ii(0x1011_b725, 1);  push(edi);                            /* push edi */
            ii(0x1011_b726, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_b727, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_b729, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1011_b72f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_b732, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1011_b735, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
        l_0x1011_b738:
            ii(0x1011_b738, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1011_b73c, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1011_b740, 2);  or(eax, edx);                         /* or eax, edx */
            ii(0x1011_b742, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_b744, 6);  if(jz(0x1011_b7d7, 0x8d)) goto l_0x1011_b7d7;/* jz 0x1011b7d7 */
            ii(0x1011_b74a, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_b74e, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_b750, 2);  if(jle(0x1011_b75b, 9)) goto l_0x1011_b75b;/* jle 0x1011b75b */
            ii(0x1011_b752, 7);  mov(memd[ss, ebp - 16], 1);           /* mov dword [ebp-0x10], 0x1 */
            ii(0x1011_b759, 2);  jmp(0x1011_b779, 0x1e); goto l_0x1011_b779;/* jmp 0x1011b779 */
        l_0x1011_b75b:
            ii(0x1011_b75b, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_b75f, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_b761, 2);  if(jge(0x1011_b76c, 9)) goto l_0x1011_b76c;/* jge 0x1011b76c */
            ii(0x1011_b763, 7);  mov(memd[ss, ebp - 20], 0xffff_ffff); /* mov dword [ebp-0x14], 0xffffffff */
            ii(0x1011_b76a, 2);  jmp(0x1011_b773, 7); goto l_0x1011_b773;/* jmp 0x1011b773 */
        l_0x1011_b76c:
            ii(0x1011_b76c, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
        l_0x1011_b773:
            ii(0x1011_b773, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_b776, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
        l_0x1011_b779:
            ii(0x1011_b779, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1011_b77c, 3);  mov(memb[ss, ebp - 24], al);          /* mov [ebp-0x18], al */
            ii(0x1011_b77f, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1011_b783, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_b785, 2);  if(jle(0x1011_b790, 9)) goto l_0x1011_b790;/* jle 0x1011b790 */
            ii(0x1011_b787, 7);  mov(memd[ss, ebp - 28], 1);           /* mov dword [ebp-0x1c], 0x1 */
            ii(0x1011_b78e, 2);  jmp(0x1011_b7ae, 0x1e); goto l_0x1011_b7ae;/* jmp 0x1011b7ae */
        l_0x1011_b790:
            ii(0x1011_b790, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1011_b794, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_b796, 2);  if(jge(0x1011_b7a1, 9)) goto l_0x1011_b7a1;/* jge 0x1011b7a1 */
            ii(0x1011_b798, 7);  mov(memd[ss, ebp - 32], 0xffff_ffff); /* mov dword [ebp-0x20], 0xffffffff */
            ii(0x1011_b79f, 2);  jmp(0x1011_b7a8, 7); goto l_0x1011_b7a8;/* jmp 0x1011b7a8 */
        l_0x1011_b7a1:
            ii(0x1011_b7a1, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x1011_b7a8:
            ii(0x1011_b7a8, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1011_b7ab, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
        l_0x1011_b7ae:
            ii(0x1011_b7ae, 3);  mov(al, memb[ss, ebp - 28]);          /* mov al, [ebp-0x1c] */
            ii(0x1011_b7b1, 3);  mov(memb[ss, ebp - 23], al);          /* mov [ebp-0x17], al */
            ii(0x1011_b7b4, 3);  lea(edx, memd[ss, ebp - 24]);         /* lea edx, [ebp-0x18] */
            ii(0x1011_b7b7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_b7ba, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1011_b7bd, 5);  call(0x1012_0b08, 0x5346);            /* call 0x10120b08 */
            ii(0x1011_b7c2, 5);  movsx(ax, memb[ss, ebp - 24]);        /* movsx ax, byte [ebp-0x18] */
            ii(0x1011_b7c7, 3);  sub(memd[ss, ebp - 8], eax);          /* sub [ebp-0x8], eax */
            ii(0x1011_b7ca, 5);  movsx(ax, memb[ss, ebp - 23]);        /* movsx ax, byte [ebp-0x17] */
            ii(0x1011_b7cf, 3);  sub(memd[ss, ebp - 4], eax);          /* sub [ebp-0x4], eax */
            ii(0x1011_b7d2, 5);  jmp(0x1011_b738, -0x9f); goto l_0x1011_b738;/* jmp 0x1011b738 */
        l_0x1011_b7d7:
            ii(0x1011_b7d7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_b7d9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_b7da, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_b7db, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_b7dc, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_b7dd, 1);  ret();                                /* ret */
        }
    }
}
