using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_85c2-183350c3")]
        public void Method_100d_85c2()
        {
            ii(0x100d_85c2, 5);  push(0x38);                           /* push 0x38 */
            ii(0x100d_85c7, 5);  call(Definitions.sys_check_available_stack_size, 0x8_d786);/* call 0x10165d52 */
            ii(0x100d_85cc, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_85cd, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_85ce, 1);  push(edx);                            /* push edx */
            ii(0x100d_85cf, 1);  push(esi);                            /* push esi */
            ii(0x100d_85d0, 1);  push(edi);                            /* push edi */
            ii(0x100d_85d1, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_85d2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_85d4, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x100d_85da, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_85dd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_85e0, 3);  mov(eax, memd[ds, eax + 21]);         /* mov eax, [eax+0x15] */
            ii(0x100d_85e3, 2);  fild(memw[ds, eax]);                  /* fild word [eax] */
            ii(0x100d_85e5, 3);  fstp(memq[ss, ebp - 24]);             /* fstp qword [ebp-0x18] */
            ii(0x100d_85e8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_85eb, 3);  mov(eax, memd[ds, eax + 11]);         /* mov eax, [eax+0xb] */
            ii(0x100d_85ee, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x100d_85f1, 3);  cmp(eax, 9);                          /* cmp eax, 0x9 */
            ii(0x100d_85f4, 2);  if(jnz(0x100d_8664, 0x6e)) goto l_0x100d_8664;/* jnz 0x100d8664 */
            ii(0x100d_85f6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_85f9, 3);  fild(memw[ds, eax + 19]);             /* fild word [eax+0x13] */
            ii(0x100d_85fc, 3);  fcomp(memq[ss, ebp - 24]);            /* fcomp qword [ebp-0x18] */
            ii(0x100d_85ff, 2);  fnstsw(ax);                           /* fnstsw ax */
            ii(0x100d_8601, 1);  sahf();                               /* sahf */
            ii(0x100d_8602, 2);  if(jb(0x100d_8610, 0xc)) goto l_0x100d_8610;/* jb 0x100d8610 */
            ii(0x100d_8604, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100d_860b, 5);  jmp(0x100d_86e9, 0xd9); goto l_0x100d_86e9;/* jmp 0x100d86e9 */
        l_0x100d_8610:
            ii(0x100d_8610, 3);  fld(memq[ss, ebp - 24]);              /* fld qword [ebp-0x18] */
            ii(0x100d_8613, 5);  call(Definitions.sys_round, 0x8_da66);/* call 0x1016607e */
            ii(0x100d_8618, 3);  fistp(memd[ss, ebp - 28]);            /* fistp dword [ebp-0x1c] */
            ii(0x100d_861b, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_861e, 4);  mov(memw[ss, ebp - 28], ax);          /* mov [ebp-0x1c], ax */
            ii(0x100d_8622, 3);  mov(edx, memd[ss, ebp - 30]);         /* mov edx, [ebp-0x1e] */
            ii(0x100d_8625, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_8628, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_862b, 5);  call(0x100d_8573, -0xbd);             /* call 0x100d8573 */
            ii(0x100d_8630, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_8633, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_8636, 3);  fild(memw[ds, eax + 19]);             /* fild word [eax+0x13] */
            ii(0x100d_8639, 3);  fsubr(memq[ss, ebp - 24]);            /* fsubr qword [ebp-0x18] */
            ii(0x100d_863c, 3);  fstp(memq[ss, ebp - 24]);             /* fstp qword [ebp-0x18] */
            ii(0x100d_863f, 3);  fld(memq[ss, ebp - 24]);              /* fld qword [ebp-0x18] */
            ii(0x100d_8642, 5);  call(Definitions.sys_round, 0x8_da37);/* call 0x1016607e */
            ii(0x100d_8647, 3);  fistp(memd[ss, ebp - 28]);            /* fistp dword [ebp-0x1c] */
            ii(0x100d_864a, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_864d, 4);  mov(memw[ss, ebp - 28], ax);          /* mov [ebp-0x1c], ax */
            ii(0x100d_8651, 3);  mov(edx, memd[ss, ebp - 30]);         /* mov edx, [ebp-0x1e] */
            ii(0x100d_8654, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_8657, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_865a, 5);  call(0x100d_8573, -0xec);             /* call 0x100d8573 */
            ii(0x100d_865f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_8662, 2);  jmp(0x100d_86cd, 0x69); goto l_0x100d_86cd;/* jmp 0x100d86cd */
        l_0x100d_8664:
            ii(0x100d_8664, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_8667, 3);  mov(eax, memd[ds, eax + 13]);         /* mov eax, [eax+0xd] */
            ii(0x100d_866a, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_866d, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x100d_8670, 2);  if(jge(0x100d_867b, 9)) goto l_0x100d_867b;/* jge 0x100d867b */
            ii(0x100d_8672, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100d_8679, 2);  jmp(0x100d_86e9, 0x6e); goto l_0x100d_86e9;/* jmp 0x100d86e9 */
        l_0x100d_867b:
            ii(0x100d_867b, 3);  fld(memq[ss, ebp - 24]);              /* fld qword [ebp-0x18] */
            ii(0x100d_867e, 5);  call(Definitions.sys_round, 0x8_d9fb);/* call 0x1016607e */
            ii(0x100d_8683, 3);  fistp(memd[ss, ebp - 28]);            /* fistp dword [ebp-0x1c] */
            ii(0x100d_8686, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_8689, 4);  mov(memw[ss, ebp - 28], ax);          /* mov [ebp-0x1c], ax */
            ii(0x100d_868d, 3);  mov(edx, memd[ss, ebp - 30]);         /* mov edx, [ebp-0x1e] */
            ii(0x100d_8690, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_8693, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_8696, 5);  call(0x100d_8573, -0x128);            /* call 0x100d8573 */
            ii(0x100d_869b, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_869e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_86a1, 3);  fild(memw[ds, eax + 19]);             /* fild word [eax+0x13] */
            ii(0x100d_86a4, 3);  fadd(memq[ss, ebp - 24]);             /* fadd qword [ebp-0x18] */
            ii(0x100d_86a7, 3);  fstp(memq[ss, ebp - 24]);             /* fstp qword [ebp-0x18] */
            ii(0x100d_86aa, 3);  fld(memq[ss, ebp - 24]);              /* fld qword [ebp-0x18] */
            ii(0x100d_86ad, 5);  call(Definitions.sys_round, 0x8_d9cc);/* call 0x1016607e */
            ii(0x100d_86b2, 3);  fistp(memd[ss, ebp - 28]);            /* fistp dword [ebp-0x1c] */
            ii(0x100d_86b5, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_86b8, 4);  mov(memw[ss, ebp - 28], ax);          /* mov [ebp-0x1c], ax */
            ii(0x100d_86bc, 3);  mov(edx, memd[ss, ebp - 30]);         /* mov edx, [ebp-0x1e] */
            ii(0x100d_86bf, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_86c2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_86c5, 5);  call(0x100d_8573, -0x157);            /* call 0x100d8573 */
            ii(0x100d_86ca, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x100d_86cd:
            ii(0x100d_86cd, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_86d0, 3);  sub(memd[ss, ebp - 8], eax);          /* sub [ebp-0x8], eax */
            ii(0x100d_86d3, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_86d7, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x100d_86da, 2);  if(jge(0x100d_86e3, 7)) goto l_0x100d_86e3;/* jge 0x100d86e3 */
            ii(0x100d_86dc, 7);  mov(memd[ss, ebp - 8], 1);            /* mov dword [ebp-0x8], 0x1 */
        l_0x100d_86e3:
            ii(0x100d_86e3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_86e6, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
        l_0x100d_86e9:
            ii(0x100d_86e9, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_86ec, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_86ee, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_86ef, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_86f0, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_86f1, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_86f2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_86f3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_86f4, 1);  ret();                                /* ret */
        }
    }
}
