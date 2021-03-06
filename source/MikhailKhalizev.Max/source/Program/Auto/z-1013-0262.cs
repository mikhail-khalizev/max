using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_0262-dc9db7c6")]
        public void Method_1013_0262()
        {
            ii(0x1013_0262, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1013_0267, 5);  call(Definitions.sys_check_available_stack_size, 0x3_5ae6);/* call 0x10165d52 */
            ii(0x1013_026c, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_026d, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_026e, 1);  push(edx);                            /* push edx */
            ii(0x1013_026f, 1);  push(esi);                            /* push esi */
            ii(0x1013_0270, 1);  push(edi);                            /* push edi */
            ii(0x1013_0271, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_0272, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_0274, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1013_027a, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_027d, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x1013_0282, 5);  call(0x1007_6338, -0xb_9f4f);         /* call 0x10076338 */
            ii(0x1013_0287, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1013_0289, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_028c, 5);  call(0x1007_64b8, -0xb_9dd9);         /* call 0x100764b8 */
            ii(0x1013_0291, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1013_0298, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_029c, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1013_02a2, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1013_02a8, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1013_02ad, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x1013_02b0, 2);  if(jnz(0x1013_02c8, 0x16)) goto l_0x1013_02c8;/* jnz 0x101302c8 */
            ii(0x1013_02b2, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_02b9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_02bb, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_02be, 5);  call(0x1007_5f6c, -0xb_a357);         /* call 0x10075f6c */
            ii(0x1013_02c3, 5);  jmp(0x1013_033a, 0x72); goto l_0x1013_033a;/* jmp 0x1013033a */
        l_0x1013_02c8:
            ii(0x1013_02c8, 2);  jmp(0x1013_02d2, 8); goto l_0x1013_02d2;/* jmp 0x101302d2 */
        l_0x1013_02ca:
            ii(0x1013_02ca, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_02cd, 5);  call(0x1007_6bf8, -0xb_96da);         /* call 0x10076bf8 */
        l_0x1013_02d2:
            ii(0x1013_02d2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_02d4, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_02d7, 5);  call(0x1013_ad71, 0xaa95);            /* call 0x1013ad71 */
            ii(0x1013_02dc, 2);  test(al, al);                         /* test al, al */
            ii(0x1013_02de, 2);  if(jz(0x1013_031e, 0x3e)) goto l_0x1013_031e;/* jz 0x1013031e */
            ii(0x1013_02e0, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_02e3, 5);  call(0x1007_63a0, -0xb_9f48);         /* call 0x100763a0 */
            ii(0x1013_02e8, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_02ea, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1013_02ed, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_02f1, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1013_02f3, 2);  if(jnz(0x1013_0304, 0xf)) goto l_0x1013_0304;/* jnz 0x10130304 */
            ii(0x1013_02f5, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_02f8, 5);  call(0x1007_63a0, -0xb_9f5d);         /* call 0x100763a0 */
            ii(0x1013_02fd, 5);  cmp(memw[ds, eax + 8], 0x1e);         /* cmp word [eax+0x8], 0x1e */
            ii(0x1013_0302, 2);  if(jz(0x1013_0306, 2)) goto l_0x1013_0306;/* jz 0x10130306 */
        l_0x1013_0304:
            ii(0x1013_0304, 2);  jmp(0x1013_0314, 0xe); goto l_0x1013_0314;/* jmp 0x10130314 */
        l_0x1013_0306:
            ii(0x1013_0306, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_0309, 5);  call(0x1007_63a0, -0xb_9f6e);         /* call 0x100763a0 */
            ii(0x1013_030e, 4);  cmp(memb[ds, eax + 61], 7);           /* cmp byte [eax+0x3d], 0x7 */
            ii(0x1013_0312, 2);  if(jz(0x1013_0316, 2)) goto l_0x1013_0316;/* jz 0x10130316 */
        l_0x1013_0314:
            ii(0x1013_0314, 2);  jmp(0x1013_031c, 6); goto l_0x1013_031c;/* jmp 0x1013031c */
        l_0x1013_0316:
            ii(0x1013_0316, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_0319, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1013_031c:
            ii(0x1013_031c, 2);  jmp(0x1013_02ca, -0x54); goto l_0x1013_02ca;/* jmp 0x101302ca */
        l_0x1013_031e:
            ii(0x1013_031e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_0321, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_0324, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_0326, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_0329, 5);  call(0x1007_5f6c, -0xb_a3c2);         /* call 0x10075f6c */
            ii(0x1013_032e, 2);  jmp(0x1013_033a, 0xa); goto l_0x1013_033a;/* jmp 0x1013033a */
        //  ii(0x1013_0330, 10);  Недостижимый код.
        l_0x1013_033a:
            ii(0x1013_033a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_033d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_033f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_0340, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_0341, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_0342, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_0343, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_0344, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_0345, 1);  ret();                                /* ret */
        }
    }
}
