using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_ce68-5084da8a")]
        public void Method_1008_ce68()
        {
            ii(0x1008_ce68, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_ce6d, 5);  call(Definitions.sys_check_available_stack_size, 0xd_8ee0);/* call 0x10165d52 */
            ii(0x1008_ce72, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_ce73, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_ce74, 1);  push(edx);                            /* push edx */
            ii(0x1008_ce75, 1);  push(esi);                            /* push esi */
            ii(0x1008_ce76, 1);  push(edi);                            /* push edi */
            ii(0x1008_ce77, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_ce78, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_ce7a, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_ce80, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_ce83, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ce86, 3);  mov(eax, memd[ds, eax + 17]);         /* mov eax, [eax+0x11] */
            ii(0x1008_ce89, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_ce8c, 3);  cmp(eax, 0xc);                        /* cmp eax, 0xc */
            ii(0x1008_ce8f, 2);  if(jz(0x1008_ce9f, 0xe)) goto l_0x1008_ce9f;/* jz 0x1008ce9f */
            ii(0x1008_ce91, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ce94, 3);  mov(eax, memd[ds, eax + 17]);         /* mov eax, [eax+0x11] */
            ii(0x1008_ce97, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_ce9a, 3);  cmp(eax, 0x21);                       /* cmp eax, 0x21 */
            ii(0x1008_ce9d, 2);  if(jnz(0x1008_cea1, 2)) goto l_0x1008_cea1;/* jnz 0x1008cea1 */
        l_0x1008_ce9f:
            ii(0x1008_ce9f, 2);  jmp(0x1008_ceaf, 0xe); goto l_0x1008_ceaf;/* jmp 0x1008ceaf */
        l_0x1008_cea1:
            ii(0x1008_cea1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_cea4, 3);  mov(eax, memd[ds, eax + 17]);         /* mov eax, [eax+0x11] */
            ii(0x1008_cea7, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_ceaa, 3);  cmp(eax, 0x27);                       /* cmp eax, 0x27 */
            ii(0x1008_cead, 2);  if(jnz(0x1008_ceb1, 2)) goto l_0x1008_ceb1;/* jnz 0x1008ceb1 */
        l_0x1008_ceaf:
            ii(0x1008_ceaf, 2);  jmp(0x1008_cebf, 0xe); goto l_0x1008_cebf;/* jmp 0x1008cebf */
        l_0x1008_ceb1:
            ii(0x1008_ceb1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ceb4, 3);  mov(eax, memd[ds, eax + 17]);         /* mov eax, [eax+0x11] */
            ii(0x1008_ceb7, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_ceba, 3);  cmp(eax, 0x28);                       /* cmp eax, 0x28 */
            ii(0x1008_cebd, 2);  if(jnz(0x1008_cec5, 6)) goto l_0x1008_cec5;/* jnz 0x1008cec5 */
        l_0x1008_cebf:
            ii(0x1008_cebf, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_cec3, 2);  jmp(0x1008_cf20, 0x5b); goto l_0x1008_cf20;/* jmp 0x1008cf20 */
        l_0x1008_cec5:
            ii(0x1008_cec5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_cec8, 3);  mov(eax, memd[ds, eax + 34]);         /* mov eax, [eax+0x22] */
            ii(0x1008_cecb, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x1008_cece, 3);  cmp(eax, 6);                          /* cmp eax, 0x6 */
            ii(0x1008_ced1, 2);  if(jz(0x1008_cee1, 0xe)) goto l_0x1008_cee1;/* jz 0x1008cee1 */
            ii(0x1008_ced3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ced6, 3);  mov(eax, memd[ds, eax + 34]);         /* mov eax, [eax+0x22] */
            ii(0x1008_ced9, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x1008_cedc, 3);  cmp(eax, 5);                          /* cmp eax, 0x5 */
            ii(0x1008_cedf, 2);  if(jnz(0x1008_cee7, 6)) goto l_0x1008_cee7;/* jnz 0x1008cee7 */
        l_0x1008_cee1:
            ii(0x1008_cee1, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_cee5, 2);  jmp(0x1008_cf20, 0x39); goto l_0x1008_cf20;/* jmp 0x1008cf20 */
        l_0x1008_cee7:
            ii(0x1008_cee7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ceea, 3);  mov(eax, memd[ds, eax + 34]);         /* mov eax, [eax+0x22] */
            ii(0x1008_ceed, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x1008_cef0, 3);  cmp(eax, 7);                          /* cmp eax, 0x7 */
            ii(0x1008_cef3, 2);  if(jge(0x1008_cf05, 0x10)) goto l_0x1008_cf05;/* jge 0x1008cf05 */
            ii(0x1008_cef5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_cef8, 3);  add(eax, 0x2b);                       /* add eax, 0x2b */
            ii(0x1008_cefb, 5);  call(0x1007_6b90, -0x1_6370);         /* call 0x10076b90 */
            ii(0x1008_cf00, 1);  cwde();                               /* cwde */
            ii(0x1008_cf01, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_cf03, 2);  if(jz(0x1008_cf07, 2)) goto l_0x1008_cf07;/* jz 0x1008cf07 */
        l_0x1008_cf05:
            ii(0x1008_cf05, 2);  jmp(0x1008_cf10, 9); goto l_0x1008_cf10;/* jmp 0x1008cf10 */
        l_0x1008_cf07:
            ii(0x1008_cf07, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_cf0a, 4);  cmp(memb[ds, eax + 42], 0);           /* cmp byte [eax+0x2a], 0x0 */
            ii(0x1008_cf0e, 2);  if(jz(0x1008_cf16, 6)) goto l_0x1008_cf16;/* jz 0x1008cf16 */
        l_0x1008_cf10:
            ii(0x1008_cf10, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_cf14, 2);  jmp(0x1008_cf1a, 4); goto l_0x1008_cf1a;/* jmp 0x1008cf1a */
        l_0x1008_cf16:
            ii(0x1008_cf16, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1008_cf1a:
            ii(0x1008_cf1a, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1008_cf1d, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
        l_0x1008_cf20:
            ii(0x1008_cf20, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1008_cf23, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_cf25, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_cf26, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_cf27, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_cf28, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_cf29, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_cf2a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_cf2b, 1);  ret();                                /* ret */
        }
    }
}
