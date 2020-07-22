using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_189b-9f0b4e6b")]
        public void Method_100f_189b()
        {
            ii(0x100f_189b, 5);  push(0x34);                           /* push 0x34 */
            ii(0x100f_18a0, 5);  call(Definitions.sys_check_available_stack_size, 0x7_44ad);/* call 0x10165d52 */
            ii(0x100f_18a5, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_18a6, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_18a7, 1);  push(edx);                            /* push edx */
            ii(0x100f_18a8, 1);  push(esi);                            /* push esi */
            ii(0x100f_18a9, 1);  push(edi);                            /* push edi */
            ii(0x100f_18aa, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_18ab, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_18ad, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x100f_18b3, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_18b6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_18b9, 5);  call(0x100f_1370, -0x54e);            /* call 0x100f1370 */
            ii(0x100f_18be, 5);  mov(edx, 0x508);                      /* mov edx, 0x508 */
            ii(0x100f_18c3, 5);  mov(eax, 0x101c_7278);                /* mov eax, 0x101c7278 */
            ii(0x100f_18c8, 5);  call(0x1013_dc59, 0x4_c38c);          /* call 0x1013dc59 */
            ii(0x100f_18cd, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100f_18d4, 2);  jmp(0x100f_18dc, 6); goto l_0x100f_18dc;/* jmp 0x100f18dc */
        l_0x100f_18d6:
            ii(0x100f_18d6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_18d9, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x100f_18dc:
            ii(0x100f_18dc, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_18e0, 3);  cmp(eax, 0xb);                        /* cmp eax, 0xb */
            ii(0x100f_18e3, 2);  if(jg(0x100f_1924, 0x3f)) goto l_0x100f_1924;/* jg 0x100f1924 */
            ii(0x100f_18e5, 5);  call(0x1014_82f4, 0x5_6a0a);          /* call 0x101482f4 */
            ii(0x100f_18ea, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100f_18ec, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_18ef, 3);  mov(memd[ds, eax + 24], edx);         /* mov [eax+0x18], edx */
            ii(0x100f_18f2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_18f5, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x100f_18f7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_18fa, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100f_18fd, 5);  call(0x100d_7f6c, -0x1_9996);         /* call 0x100d7f6c */
            ii(0x100f_1902, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1905, 3);  mov(edx, memd[ds, eax + 4]);          /* mov edx, [eax+0x4] */
            ii(0x100f_1908, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_190b, 3);  mov(eax, memd[ds, eax + 12]);         /* mov eax, [eax+0xc] */
            ii(0x100f_190e, 5);  call(0x100d_7f6c, -0x1_99a7);         /* call 0x100d7f6c */
            ii(0x100f_1913, 4);  imul(eax, memd[ss, ebp - 8], 0x14);   /* imul eax, [ebp-0x8], 0x14 */
            ii(0x100f_1917, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100f_191a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_191d, 5);  call(0x100f_17e0, -0x142);            /* call 0x100f17e0 */
            ii(0x100f_1922, 2);  jmp(0x100f_18d6, -0x4e); goto l_0x100f_18d6;/* jmp 0x100f18d6 */
        l_0x100f_1924:
            ii(0x100f_1924, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1927, 4);  cmp(memd[ds, eax + 8], 0);            /* cmp dword [eax+0x8], 0x0 */
            ii(0x100f_192b, 2);  if(jz(0x100f_1983, 0x56)) goto l_0x100f_1983;/* jz 0x100f1983 */
            ii(0x100f_192d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1930, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x100f_1932, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1935, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100f_1938, 5);  call(0x100d_7f6c, -0x1_99d1);         /* call 0x100d7f6c */
            ii(0x100f_193d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1940, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x100f_1942, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1945, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100f_1947, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x100f_194a, 5);  call(Definitions.sys_display_draw_1, 0x7_5b59);/* call 0x101674a8 */
            ii(0x100f_194f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1952, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100f_1955, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100f_1958, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100f_195c, 2);  if(jz(0x100f_1972, 0x14)) goto l_0x100f_1972;/* jz 0x100f1972 */
            ii(0x100f_195e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_1960, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100f_1963, 5);  call(Definitions.my_dtor_d3, -0x1_9c35);/* call 0x100d7d33 */
            ii(0x100f_1968, 5);  call(Definitions.sys_delete, 0x7_45f7);/* call 0x10165f64 */
            ii(0x100f_196d, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_1970, 2);  jmp(0x100f_1979, 7); goto l_0x100f_1979;/* jmp 0x100f1979 */
        l_0x100f_1972:
            ii(0x100f_1972, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x100f_1979:
            ii(0x100f_1979, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_197c, 7);  mov(memd[ds, eax + 8], 0);            /* mov dword [eax+0x8], 0x0 */
        l_0x100f_1983:
            ii(0x100f_1983, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1986, 4);  cmp(memd[ds, eax + 12], 0);           /* cmp dword [eax+0xc], 0x0 */
            ii(0x100f_198a, 2);  if(jz(0x100f_19e5, 0x59)) goto l_0x100f_19e5;/* jz 0x100f19e5 */
            ii(0x100f_198c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_198f, 3);  mov(edx, memd[ds, eax + 4]);          /* mov edx, [eax+0x4] */
            ii(0x100f_1992, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1995, 3);  mov(eax, memd[ds, eax + 12]);         /* mov eax, [eax+0xc] */
            ii(0x100f_1998, 5);  call(0x100d_7f6c, -0x1_9a31);         /* call 0x100d7f6c */
            ii(0x100f_199d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_19a0, 3);  mov(edx, memd[ds, eax + 4]);          /* mov edx, [eax+0x4] */
            ii(0x100f_19a3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_19a6, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x100f_19a9, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x100f_19ac, 5);  call(Definitions.sys_display_draw_1, 0x7_5af7);/* call 0x101674a8 */
            ii(0x100f_19b1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_19b4, 3);  mov(eax, memd[ds, eax + 12]);         /* mov eax, [eax+0xc] */
            ii(0x100f_19b7, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_19ba, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100f_19be, 2);  if(jz(0x100f_19d4, 0x14)) goto l_0x100f_19d4;/* jz 0x100f19d4 */
            ii(0x100f_19c0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_19c2, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_19c5, 5);  call(Definitions.my_dtor_d3, -0x1_9c97);/* call 0x100d7d33 */
            ii(0x100f_19ca, 5);  call(Definitions.sys_delete, 0x7_4595);/* call 0x10165f64 */
            ii(0x100f_19cf, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100f_19d2, 2);  jmp(0x100f_19db, 7); goto l_0x100f_19db;/* jmp 0x100f19db */
        l_0x100f_19d4:
            ii(0x100f_19d4, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x100f_19db:
            ii(0x100f_19db, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_19de, 7);  mov(memd[ds, eax + 12], 0);           /* mov dword [eax+0xc], 0x0 */
        l_0x100f_19e5:
            ii(0x100f_19e5, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_19e7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_19e8, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_19e9, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_19ea, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_19eb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_19ec, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_19ed, 1);  ret();                                /* ret */
        }
    }
}
