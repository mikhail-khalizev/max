using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_e78d-7785a015")]
        public void Method_1011_e78d()
        {
            ii(0x1011_e78d, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1011_e792, 5);  call(Definitions.sys_check_available_stack_size, 0x4_75bb);/* call 0x10165d52 */
            ii(0x1011_e797, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_e798, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_e799, 1);  push(esi);                            /* push esi */
            ii(0x1011_e79a, 1);  push(edi);                            /* push edi */
            ii(0x1011_e79b, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_e79c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_e79e, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1011_e7a4, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_e7a7, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_e7aa, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_e7ac, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_e7af, 3);  mov(al, memb[ds, edx + 38]);          /* mov al, [edx+0x26] */
            ii(0x1011_e7b2, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_e7b5, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x1011_e7ba, 5);  call(0x1007_6338, -0xa_8487);         /* call 0x10076338 */
            ii(0x1011_e7bf, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x1011_e7c2, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_e7c4, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1011_e7c6, 5);  call(0x1007_64b8, -0xa_8313);         /* call 0x100764b8 */
            ii(0x1011_e7cb, 2);  jmp(0x1011_e7d5, 8); goto l_0x1011_e7d5;/* jmp 0x1011e7d5 */
        l_0x1011_e7cd:
            ii(0x1011_e7cd, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1011_e7d0, 5);  call(0x1007_6bf8, -0xa_7bdd);         /* call 0x10076bf8 */
        l_0x1011_e7d5:
            ii(0x1011_e7d5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_e7d7, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1011_e7da, 5);  call(0x1013_ad71, 0x1_c592);          /* call 0x1013ad71 */
            ii(0x1011_e7df, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_e7e1, 6);  if(jz(0x1011_e8c7, 0xe0)) goto l_0x1011_e8c7;/* jz 0x1011e8c7 */
            ii(0x1011_e7e7, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1011_e7ea, 5);  call(0x1007_63a0, -0xa_844f);         /* call 0x100763a0 */
            ii(0x1011_e7ef, 5);  cmp(memw[ds, eax + 8], 0xc);          /* cmp word [eax+0x8], 0xc */
            ii(0x1011_e7f4, 6);  if(jz(0x1011_e8c2, 0xc8)) goto l_0x1011_e8c2;/* jz 0x1011e8c2 */
            ii(0x1011_e7fa, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1011_e7fe, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1011_e801, 5);  call(0x1007_63a0, -0xa_8466);         /* call 0x100763a0 */
            ii(0x1011_e806, 5);  call(0x1007_6074, -0xa_8797);         /* call 0x10076074 */
            ii(0x1011_e80b, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_e80d, 2);  if(jnz(0x1011_e828, 0x19)) goto l_0x1011_e828;/* jnz 0x1011e828 */
            ii(0x1011_e80f, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1011_e813, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1011_e816, 5);  call(0x1007_63a0, -0xa_847b);         /* call 0x100763a0 */
            ii(0x1011_e81b, 5);  call(0x1007_6274, -0xa_85ac);         /* call 0x10076274 */
            ii(0x1011_e820, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_e822, 6);  if(jz(0x1011_e8c2, 0x9a)) goto l_0x1011_e8c2;/* jz 0x1011e8c2 */
        l_0x1011_e828:
            ii(0x1011_e828, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1011_e82b, 5);  call(0x1007_63a0, -0xa_8490);         /* call 0x100763a0 */
            ii(0x1011_e830, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1011_e833, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_e836, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_e839, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_e83c, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_e83e, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1011_e841, 5);  call(0x1007_63a0, -0xa_84a6);         /* call 0x100763a0 */
            ii(0x1011_e846, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x1011_e849, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1011_e84c, 2);  mov(eax, memd[ds, edx]);              /* mov eax, [edx] */
            ii(0x1011_e84e, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1011_e850, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
            ii(0x1011_e853, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1011_e856, 5);  call(0x1007_63a0, -0xa_84bb);         /* call 0x100763a0 */
            ii(0x1011_e85b, 4);  test(memb[ds, eax + 18], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1011_e85f, 2);  if(jz(0x1011_e8c2, 0x61)) goto l_0x1011_e8c2;/* jz 0x1011e8c2 */
            ii(0x1011_e861, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1011_e864, 5);  call(0x1007_63a0, -0xa_84c9);         /* call 0x100763a0 */
            ii(0x1011_e869, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x1011_e86d, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_e870, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1011_e873, 5);  call(0x1007_63a0, -0xa_84d8);         /* call 0x100763a0 */
            ii(0x1011_e878, 4);  mov(ax, memw[ds, eax + 28]);          /* mov ax, [eax+0x1c] */
            ii(0x1011_e87c, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_e87f, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1011_e883, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_e886, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1011_e889, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_e88d, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1011_e890, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_e892, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
            ii(0x1011_e895, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1011_e899, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_e89c, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1011_e89f, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_e8a3, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_e8a5, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_e8a7, 4);  mov(memb[ds, eax + 1], 0);            /* mov byte [eax+0x1], 0x0 */
            ii(0x1011_e8ab, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1011_e8af, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_e8b2, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1011_e8b5, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_e8b9, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1011_e8bc, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_e8be, 4);  mov(memb[ds, eax + 1], 0);            /* mov byte [eax+0x1], 0x0 */
        l_0x1011_e8c2:
            ii(0x1011_e8c2, 5);  jmp(0x1011_e7cd, -0xfa); goto l_0x1011_e7cd;/* jmp 0x1011e7cd */
        l_0x1011_e8c7:
            ii(0x1011_e8c7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_e8c9, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1011_e8cc, 5);  call(0x1007_5f6c, -0xa_8965);         /* call 0x10075f6c */
            ii(0x1011_e8d1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_e8d3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_e8d4, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_e8d5, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_e8d6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_e8d7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_e8d8, 1);  ret();                                /* ret */
        }
    }
}
