using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_9770-3a7c1682")]
        public void Method_1007_9770()
        {
            ii(0x1007_9770, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_9775, 5);  call(Definitions.sys_check_available_stack_size, 0xe_c5d8);/* call 0x10165d52 */
            ii(0x1007_977a, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_977b, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_977c, 1);  push(esi);                            /* push esi */
            ii(0x1007_977d, 1);  push(edi);                            /* push edi */
            ii(0x1007_977e, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_977f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_9781, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1007_9787, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_978a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_978d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_9790, 5);  call(0x1007_623c, -0x3559);           /* call 0x1007623c */
            ii(0x1007_9795, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1007_9798, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_979b, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_979d, 2);  if(jle(0x1007_97bc, 0x1d)) goto l_0x1007_97bc;/* jle 0x100797bc */
            ii(0x1007_979f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_97a2, 5);  call(0x1007_623c, -0x356b);           /* call 0x1007623c */
            ii(0x1007_97a7, 3);  mov(edx, memd[ds, eax + 18]);         /* mov edx, [eax+0x12] */
            ii(0x1007_97aa, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1007_97ad, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_97b0, 3);  mov(al, memb[ds, eax + 84]);          /* mov al, [eax+0x54] */
            ii(0x1007_97b3, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_97b8, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x1007_97ba, 2);  if(jge(0x1007_97be, 2)) goto l_0x1007_97be;/* jge 0x100797be */
        l_0x1007_97bc:
            ii(0x1007_97bc, 2);  jmp(0x1007_97d0, 0x12); goto l_0x1007_97d0;/* jmp 0x100797d0 */
        l_0x1007_97be:
            ii(0x1007_97be, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_97c1, 5);  call(0x1007_623c, -0x358a);           /* call 0x1007623c */
            ii(0x1007_97c6, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x1007_97c9, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_97cc, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_97ce, 2);  if(jg(0x1007_97d2, 2)) goto l_0x1007_97d2;/* jg 0x100797d2 */
        l_0x1007_97d0:
            ii(0x1007_97d0, 2);  jmp(0x1007_97db, 9); goto l_0x1007_97db;/* jmp 0x100797db */
        l_0x1007_97d2:
            ii(0x1007_97d2, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1007_97d6, 5);  jmp(0x1007_9835, 0x5a); goto l_0x1007_9835;/* jmp 0x10079835 */
        l_0x1007_97db:
            ii(0x1007_97db, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_97de, 5);  cmp(memw[ds, eax + 8], 0x3d);         /* cmp word [eax+0x8], 0x3d */
            ii(0x1007_97e3, 2);  if(jz(0x1007_97ef, 0xa)) goto l_0x1007_97ef;/* jz 0x100797ef */
            ii(0x1007_97e5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_97e8, 5);  cmp(memw[ds, eax + 8], 0x31);         /* cmp word [eax+0x8], 0x31 */
            ii(0x1007_97ed, 2);  if(jnz(0x1007_97f1, 2)) goto l_0x1007_97f1;/* jnz 0x100797f1 */
        l_0x1007_97ef:
            ii(0x1007_97ef, 2);  jmp(0x1007_97fb, 0xa); goto l_0x1007_97fb;/* jmp 0x100797fb */
        l_0x1007_97f1:
            ii(0x1007_97f1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_97f4, 5);  cmp(memw[ds, eax + 8], 0x19);         /* cmp word [eax+0x8], 0x19 */
            ii(0x1007_97f9, 2);  if(jnz(0x1007_97fd, 2)) goto l_0x1007_97fd;/* jnz 0x100797fd */
        l_0x1007_97fb:
            ii(0x1007_97fb, 2);  jmp(0x1007_9807, 0xa); goto l_0x1007_9807;/* jmp 0x10079807 */
        l_0x1007_97fd:
            ii(0x1007_97fd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_9800, 5);  cmp(memw[ds, eax + 8], 0x18);         /* cmp word [eax+0x8], 0x18 */
            ii(0x1007_9805, 2);  if(jnz(0x1007_9809, 2)) goto l_0x1007_9809;/* jnz 0x10079809 */
        l_0x1007_9807:
            ii(0x1007_9807, 2);  jmp(0x1007_9813, 0xa); goto l_0x1007_9813;/* jmp 0x10079813 */
        l_0x1007_9809:
            ii(0x1007_9809, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_980c, 5);  cmp(memw[ds, eax + 8], 0x1b);         /* cmp word [eax+0x8], 0x1b */
            ii(0x1007_9811, 2);  if(jnz(0x1007_9815, 2)) goto l_0x1007_9815;/* jnz 0x10079815 */
        l_0x1007_9813:
            ii(0x1007_9813, 2);  jmp(0x1007_981f, 0xa); goto l_0x1007_981f;/* jmp 0x1007981f */
        l_0x1007_9815:
            ii(0x1007_9815, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_9818, 5);  cmp(memw[ds, eax + 8], 0x17);         /* cmp word [eax+0x8], 0x17 */
            ii(0x1007_981d, 2);  if(jnz(0x1007_9821, 2)) goto l_0x1007_9821;/* jnz 0x10079821 */
        l_0x1007_981f:
            ii(0x1007_981f, 2);  jmp(0x1007_982b, 0xa); goto l_0x1007_982b;/* jmp 0x1007982b */
        l_0x1007_9821:
            ii(0x1007_9821, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_9824, 5);  cmp(memw[ds, eax + 8], 0x20);         /* cmp word [eax+0x8], 0x20 */
            ii(0x1007_9829, 2);  if(jnz(0x1007_9831, 6)) goto l_0x1007_9831;/* jnz 0x10079831 */
        l_0x1007_982b:
            ii(0x1007_982b, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1007_982f, 2);  jmp(0x1007_9835, 4); goto l_0x1007_9835;/* jmp 0x10079835 */
        l_0x1007_9831:
            ii(0x1007_9831, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1007_9835:
            ii(0x1007_9835, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1007_9838, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_983a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_983b, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_983c, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_983d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_983e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_983f, 1);  ret();                                /* ret */
        }
    }
}
