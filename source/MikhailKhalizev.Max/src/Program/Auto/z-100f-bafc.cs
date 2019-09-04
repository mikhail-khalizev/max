using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_bafc-d1428f2d")]
        public void Method_100f_bafc()
        {
            ii(0x100f_bafc, 5);  push(0x34);                           /* push 0x34 */
            ii(0x100f_bb01, 5);  call(Definitions.sys_check_available_stack_size, 0x6_a24c);/* call 0x10165d52 */
            ii(0x100f_bb06, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_bb07, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_bb08, 1);  push(edx);                            /* push edx */
            ii(0x100f_bb09, 1);  push(esi);                            /* push esi */
            ii(0x100f_bb0a, 1);  push(edi);                            /* push edi */
            ii(0x100f_bb0b, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_bb0c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_bb0e, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x100f_bb14, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_bb17, 7);  mov(memd[ss, ebp - 16], 4);           /* mov dword [ebp-0x10], 0x4 */
            ii(0x100f_bb1e, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x100f_bb22:
            ii(0x100f_bb22, 3);  dec(memd[ss, ebp - 16]);              /* dec dword [ebp-0x10] */
            ii(0x100f_bb25, 5);  cmp(memw[ss, ebp - 16], -1 /* 0xff */);/* cmp word [ebp-0x10], 0xffff */
            ii(0x100f_bb2a, 6);  if(jz(0x100f_bbdb, 0xab)) goto l_0x100f_bbdb;/* jz 0x100fbbdb */
            ii(0x100f_bb30, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_bb33, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100f_bb37, 2);  if(jz(0x100f_bb53, 0x1a)) goto l_0x100f_bb53;/* jz 0x100fbb53 */
            ii(0x100f_bb39, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100f_bb3d, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100f_bb43, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_bb49, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100f_bb4e, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x100f_bb51, 2);  if(jz(0x100f_bb58, 5)) goto l_0x100f_bb58;/* jz 0x100fbb58 */
        l_0x100f_bb53:
            ii(0x100f_bb53, 5);  jmp(0x100f_bbd6, 0x7e); goto l_0x100f_bbd6;/* jmp 0x100fbbd6 */
        l_0x100f_bb58:
            ii(0x100f_bb58, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100f_bb5c, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_bb60, 5);  call(0x100f_b9d3, -0x192);            /* call 0x100fb9d3 */
            ii(0x100f_bb65, 3);  mov(memb[ss, ebp - 20], al);          /* mov [ebp-0x14], al */
            ii(0x100f_bb68, 2);  jmp(0x100f_bbba, 0x50); goto l_0x100f_bbba;/* jmp 0x100fbbba */
        l_0x100f_bb6a:
            ii(0x100f_bb6a, 4);  cmp(memb[ss, ebp - 8], 0);            /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100f_bb6e, 2);  if(jnz(0x100f_bb74, 4)) goto l_0x100f_bb74;/* jnz 0x100fbb74 */
            ii(0x100f_bb70, 4);  mov(memb[ss, ebp - 8], 2);            /* mov byte [ebp-0x8], 0x2 */
        l_0x100f_bb74:
            ii(0x100f_bb74, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100f_bb78, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x100f_bb7b, 7);  cmp(memb[ds, eax + 0x101c_35c6], 0);  /* cmp byte [eax+0x101c35c6], 0x0 */
            ii(0x100f_bb82, 2);  if(jz(0x100f_bb94, 0x10)) goto l_0x100f_bb94;/* jz 0x100fbb94 */
            ii(0x100f_bb84, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100f_bb88, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x100f_bb8b, 7);  cmp(memb[ds, eax + 0x101c_35c6], 1);  /* cmp byte [eax+0x101c35c6], 0x1 */
            ii(0x100f_bb92, 2);  if(jnz(0x100f_bba2, 0xe)) goto l_0x100f_bba2;/* jnz 0x100fbba2 */
        l_0x100f_bb94:
            ii(0x100f_bb94, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100f_bb98, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x100f_bb9b, 7);  mov(memb[ds, eax + 0x101c_35c6], 2);  /* mov byte [eax+0x101c35c6], 0x2 */
        l_0x100f_bba2:
            ii(0x100f_bba2, 2);  jmp(0x100f_bbd6, 0x32); goto l_0x100f_bbd6;/* jmp 0x100fbbd6 */
        l_0x100f_bba4:
            ii(0x100f_bba4, 4);  mov(memb[ss, ebp - 8], 3);            /* mov byte [ebp-0x8], 0x3 */
            ii(0x100f_bba8, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100f_bbac, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x100f_bbaf, 7);  mov(memb[ds, eax + 0x101c_35c6], 3);  /* mov byte [eax+0x101c35c6], 0x3 */
            ii(0x100f_bbb6, 2);  jmp(0x100f_bbd6, 0x1e); goto l_0x100f_bbd6;/* jmp 0x100fbbd6 */
        l_0x100f_bbb8:
            ii(0x100f_bbb8, 2);  jmp(0x100f_bbd6, 0x1c); goto l_0x100f_bbd6;/* jmp 0x100fbbd6 */
        l_0x100f_bbba:
            ii(0x100f_bbba, 3);  mov(al, memb[ss, ebp - 20]);          /* mov al, [ebp-0x14] */
            ii(0x100f_bbbd, 3);  mov(memb[ss, ebp - 24], al);          /* mov [ebp-0x18], al */
            ii(0x100f_bbc0, 4);  cmp(memb[ss, ebp - 24], 2);           /* cmp byte [ebp-0x18], 0x2 */
            ii(0x100f_bbc4, 2);  if(jb(0x100f_bbd4, 0xe)) goto l_0x100f_bbd4;/* jb 0x100fbbd4 */
            ii(0x100f_bbc6, 4);  cmp(memb[ss, ebp - 24], 2);           /* cmp byte [ebp-0x18], 0x2 */
            ii(0x100f_bbca, 2);  if(jbe(0x100f_bb6a, -0x62)) goto l_0x100f_bb6a;/* jbe 0x100fbb6a */
            ii(0x100f_bbcc, 4);  cmp(memb[ss, ebp - 24], 3);           /* cmp byte [ebp-0x18], 0x3 */
            ii(0x100f_bbd0, 2);  if(jz(0x100f_bba4, -0x2e)) goto l_0x100f_bba4;/* jz 0x100fbba4 */
            ii(0x100f_bbd2, 2);  jmp(0x100f_bbb8, -0x1c); goto l_0x100f_bbb8;/* jmp 0x100fbbb8 */
        l_0x100f_bbd4:
            ii(0x100f_bbd4, 2);  jmp(0x100f_bbb8, -0x1e); goto l_0x100f_bbb8;/* jmp 0x100fbbb8 */
        l_0x100f_bbd6:
            ii(0x100f_bbd6, 5);  jmp(0x100f_bb22, -0xb9); goto l_0x100f_bb22;/* jmp 0x100fbb22 */
        l_0x100f_bbdb:
            ii(0x100f_bbdb, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100f_bbde, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100f_bbe1, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100f_bbe4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_bbe6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_bbe7, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_bbe8, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_bbe9, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_bbea, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_bbeb, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_bbec, 1);  ret();                                /* ret */
        }
    }
}
