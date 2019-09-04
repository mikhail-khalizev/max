using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_2999-287d1206")]
        public void Method_1007_2999()
        {
            ii(0x1007_2999, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1007_299e, 5);  call(Definitions.sys_check_available_stack_size, 0xf_33af);/* call 0x10165d52 */
            ii(0x1007_29a3, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_29a4, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_29a5, 1);  push(esi);                            /* push esi */
            ii(0x1007_29a6, 1);  push(edi);                            /* push edi */
            ii(0x1007_29a7, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_29a8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_29aa, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1007_29b0, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_29b3, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1007_29b6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_29b9, 5);  call(0x1007_6338, 0x397a);            /* call 0x10076338 */
            ii(0x1007_29be, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_29c0, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_29c3, 5);  call(0x1007_64b8, 0x3af0);            /* call 0x100764b8 */
        l_0x1007_29c8:
            ii(0x1007_29c8, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_29ca, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_29cd, 5);  call(0x1013_ad71, 0xc_839f);          /* call 0x1013ad71 */
            ii(0x1007_29d2, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_29d4, 2);  if(jz(0x1007_2a1c, 0x46)) goto l_0x1007_2a1c;/* jz 0x10072a1c */
            ii(0x1007_29d6, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_29d9, 5);  call(0x1007_63a0, 0x39c2);            /* call 0x100763a0 */
            ii(0x1007_29de, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_29e0, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1007_29e3, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_29e7, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1007_29e9, 2);  if(jnz(0x1007_29f9, 0xe)) goto l_0x1007_29f9;/* jnz 0x100729f9 */
            ii(0x1007_29eb, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_29ee, 5);  call(0x1007_63a0, 0x39ad);            /* call 0x100763a0 */
            ii(0x1007_29f3, 4);  cmp(memb[ds, eax + 61], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_29f7, 2);  if(jnz(0x1007_29fb, 2)) goto l_0x1007_29fb;/* jnz 0x100729fb */
        l_0x1007_29f9:
            ii(0x1007_29f9, 2);  jmp(0x1007_2a12, 0x17); goto l_0x1007_2a12;/* jmp 0x10072a12 */
        l_0x1007_29fb:
            ii(0x1007_29fb, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_29fe, 5);  call(0x1007_6408, 0x3a05);            /* call 0x10076408 */
            ii(0x1007_2a03, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_2a06, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_2a08, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_2a0b, 5);  call(0x1007_5f6c, 0x355c);            /* call 0x10075f6c */
            ii(0x1007_2a10, 2);  jmp(0x1007_2a39, 0x27); goto l_0x1007_2a39;/* jmp 0x10072a39 */
        l_0x1007_2a12:
            ii(0x1007_2a12, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_2a15, 5);  call(0x1007_6bf8, 0x41de);            /* call 0x10076bf8 */
            ii(0x1007_2a1a, 2);  jmp(0x1007_29c8, -0x54); goto l_0x1007_29c8;/* jmp 0x100729c8 */
        l_0x1007_2a1c:
            ii(0x1007_2a1c, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_2a23, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_2a25, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_2a28, 5);  call(0x1007_5f6c, 0x353f);            /* call 0x10075f6c */
            ii(0x1007_2a2d, 2);  jmp(0x1007_2a39, 0xa); goto l_0x1007_2a39;/* jmp 0x10072a39 */
        //  ii(0x1007_2a2f, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x1007_2a31, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
        //  ii(0x1007_2a34, 5);  call(0x1007_5f6c, 0x3533);            /* call 0x10075f6c */
        l_0x1007_2a39:
            ii(0x1007_2a39, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_2a3c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_2a3e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_2a3f, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_2a40, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_2a41, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_2a42, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_2a43, 1);  ret();                                /* ret */
        }
    }
}
