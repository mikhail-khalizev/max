using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_a69d-4fbb5022")]
        public void Method_1010_a69d()
        {
            ii(0x1010_a69d, 5);  push(0x44);                           /* push 0x44 */
            ii(0x1010_a6a2, 5);  call(Definitions.sys_check_available_stack_size, 0x5_b6ab);/* call 0x10165d52 */
            ii(0x1010_a6a7, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_a6a8, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_a6a9, 1);  push(edx);                            /* push edx */
            ii(0x1010_a6aa, 1);  push(esi);                            /* push esi */
            ii(0x1010_a6ab, 1);  push(edi);                            /* push edi */
            ii(0x1010_a6ac, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_a6ad, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_a6af, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x1010_a6b5, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_a6b8, 5);  mov(edx, 6);                          /* mov edx, 0x6 */
            ii(0x1010_a6bd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_a6c0, 5);  call(0x1010_a26b, -0x45a);            /* call 0x1010a26b */
            ii(0x1010_a6c5, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1010_a6ca, 5);  mov(edx, 0x101c_4e54);                /* mov edx, 0x101c4e54 */
            ii(0x1010_a6cf, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_a6d2, 5);  call(0x100d_4d78, -0x3_595f);         /* call 0x100d4d78 */
            ii(0x1010_a6d7, 5);  mov(esi, 0x101b_aa48);                /* mov esi, 0x101baa48 */
            ii(0x1010_a6dc, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_a6df, 2);  mov(edi, memd[ds, edx]);              /* mov edi, [edx] */
            ii(0x1010_a6e1, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1010_a6e3, 2);  mov(edx, esi);                        /* mov edx, esi */
            ii(0x1010_a6e5, 2);  mov(eax, edi);                        /* mov eax, edi */
            ii(0x1010_a6e7, 5);  call(0x1010_a2d7, -0x415);            /* call 0x1010a2d7 */
            ii(0x1010_a6ec, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1010_a6f1, 5);  mov(edx, 0x101c_4e54);                /* mov edx, 0x101c4e54 */
            ii(0x1010_a6f6, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1010_a6f9, 5);  call(0x100d_4d78, -0x3_5986);         /* call 0x100d4d78 */
            ii(0x1010_a6fe, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1010_a700, 5);  mov(edx, 0x101b_aa5c);                /* mov edx, 0x101baa5c */
            ii(0x1010_a705, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_a708, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_a70a, 5);  call(0x1010_a2d7, -0x438);            /* call 0x1010a2d7 */
            ii(0x1010_a70f, 5);  mov(eax, 0x4a);                       /* mov eax, 0x4a */
            ii(0x1010_a714, 5);  call(0x1007_5fdc, -0x9_473d);         /* call 0x10075fdc */
            ii(0x1010_a719, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_a71c, 5);  mov(eax, 0x4b);                       /* mov eax, 0x4b */
            ii(0x1010_a721, 5);  call(0x1007_5fdc, -0x9_474a);         /* call 0x10075fdc */
            ii(0x1010_a726, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_a729, 5);  mov(ebx, 0xa);                        /* mov ebx, 0xa */
            ii(0x1010_a72e, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x1010_a731, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1010_a735, 5);  call(/* sys */ 0x1017_93f8, 0x6_ecbe);/* call 0x101793f8 */
            ii(0x1010_a73a, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_a73e, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1010_a740, 2);  if(jnz(0x1010_a79b, 0x59)) goto l_0x1010_a79b;/* jnz 0x1010a79b */
            ii(0x1010_a742, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_a745, 7);  cmp(memd[ds, eax + 867], 0);          /* cmp dword [eax+0x363], 0x0 */
            ii(0x1010_a74c, 2);  if(jz(0x1010_a75a, 0xc)) goto l_0x1010_a75a;/* jz 0x1010a75a */
            ii(0x1010_a74e, 10);  mov(memd[ds, 0x101b_aaf8], 0);       /* mov dword [0x101baaf8], 0x0 */
            ii(0x1010_a758, 2);  jmp(0x1010_a762, 8); goto l_0x1010_a762;/* jmp 0x1010a762 */
        l_0x1010_a75a:
            ii(0x1010_a75a, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1010_a75d, 5);  mov(memd[ds, 0x101b_aaf8], eax);      /* mov [0x101baaf8], eax */
        l_0x1010_a762:
            ii(0x1010_a762, 10);  mov(memd[ds, 0x101b_ab0c], 0);       /* mov dword [0x101bab0c], 0x0 */
            ii(0x1010_a76c, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1010_a770, 3);  cmp(eax, 0x64);                       /* cmp eax, 0x64 */
            ii(0x1010_a773, 2);  if(jg(0x1010_a77e, 9)) goto l_0x1010_a77e;/* jg 0x1010a77e */
            ii(0x1010_a775, 7);  mov(memd[ss, ebp - 8], 0x28);         /* mov dword [ebp-0x8], 0x28 */
            ii(0x1010_a77c, 2);  jmp(0x1010_a799, 0x1b); goto l_0x1010_a799;/* jmp 0x1010a799 */
        l_0x1010_a77e:
            ii(0x1010_a77e, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1010_a782, 5);  cmp(eax, 0xc8);                       /* cmp eax, 0xc8 */
            ii(0x1010_a787, 2);  if(jg(0x1010_a792, 9)) goto l_0x1010_a792;/* jg 0x1010a792 */
            ii(0x1010_a789, 7);  mov(memd[ss, ebp - 8], 0x29);         /* mov dword [ebp-0x8], 0x29 */
            ii(0x1010_a790, 2);  jmp(0x1010_a799, 7); goto l_0x1010_a799;/* jmp 0x1010a799 */
        l_0x1010_a792:
            ii(0x1010_a792, 7);  mov(memd[ss, ebp - 8], 0x2a);         /* mov dword [ebp-0x8], 0x2a */
        l_0x1010_a799:
            ii(0x1010_a799, 2);  jmp(0x1010_a7f4, 0x59); goto l_0x1010_a7f4;/* jmp 0x1010a7f4 */
        l_0x1010_a79b:
            ii(0x1010_a79b, 10);  mov(memd[ds, 0x101b_aaf8], 0);       /* mov dword [0x101baaf8], 0x0 */
            ii(0x1010_a7a5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_a7a8, 7);  cmp(memd[ds, eax + 867], 0);          /* cmp dword [eax+0x363], 0x0 */
            ii(0x1010_a7af, 2);  if(jz(0x1010_a7bd, 0xc)) goto l_0x1010_a7bd;/* jz 0x1010a7bd */
            ii(0x1010_a7b1, 10);  mov(memd[ds, 0x101b_ab0c], 0);       /* mov dword [0x101bab0c], 0x0 */
            ii(0x1010_a7bb, 2);  jmp(0x1010_a7c5, 8); goto l_0x1010_a7c5;/* jmp 0x1010a7c5 */
        l_0x1010_a7bd:
            ii(0x1010_a7bd, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1010_a7c0, 5);  mov(memd[ds, 0x101b_ab0c], eax);      /* mov [0x101bab0c], eax */
        l_0x1010_a7c5:
            ii(0x1010_a7c5, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1010_a7c9, 5);  cmp(eax, 0xc8);                       /* cmp eax, 0xc8 */
            ii(0x1010_a7ce, 2);  if(jg(0x1010_a7d9, 9)) goto l_0x1010_a7d9;/* jg 0x1010a7d9 */
            ii(0x1010_a7d0, 7);  mov(memd[ss, ebp - 8], 0x2b);         /* mov dword [ebp-0x8], 0x2b */
            ii(0x1010_a7d7, 2);  jmp(0x1010_a7f4, 0x1b); goto l_0x1010_a7f4;/* jmp 0x1010a7f4 */
        l_0x1010_a7d9:
            ii(0x1010_a7d9, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1010_a7dd, 5);  cmp(eax, 0x190);                      /* cmp eax, 0x190 */
            ii(0x1010_a7e2, 2);  if(jg(0x1010_a7ed, 9)) goto l_0x1010_a7ed;/* jg 0x1010a7ed */
            ii(0x1010_a7e4, 7);  mov(memd[ss, ebp - 8], 0x2c);         /* mov dword [ebp-0x8], 0x2c */
            ii(0x1010_a7eb, 2);  jmp(0x1010_a7f4, 7); goto l_0x1010_a7f4;/* jmp 0x1010a7f4 */
        l_0x1010_a7ed:
            ii(0x1010_a7ed, 7);  mov(memd[ss, ebp - 8], 0x2d);         /* mov dword [ebp-0x8], 0x2d */
        l_0x1010_a7f4:
            ii(0x1010_a7f4, 4);  add(memd[ss, ebp - 8], -0x28 /* 0xd8 */);/* add dword [ebp-0x8], 0xffffffd8 */
            ii(0x1010_a7f8, 4);  movsx(ecx, memw[ss, ebp - 8]);        /* movsx ecx, word [ebp-0x8] */
            ii(0x1010_a7fc, 5);  mov(ebx, 0x3d);                       /* mov ebx, 0x3d */
            ii(0x1010_a801, 5);  mov(edx, 8);                          /* mov edx, 0x8 */
            ii(0x1010_a806, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_a809, 5);  call(0x1010_a36e, -0x4a0);            /* call 0x1010a36e */
            ii(0x1010_a80e, 5);  call(0x1011_5318, 0xab05);            /* call 0x10115318 */
            ii(0x1010_a813, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1010_a818, 1);  push(eax);                            /* push eax */
            ii(0x1010_a819, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1010_a81e, 5);  mov(ebx, 0x1_00ff);                   /* mov ebx, 0x100ff */
            ii(0x1010_a823, 5);  mov(edx, 0x101b_aae8);                /* mov edx, 0x101baae8 */
            ii(0x1010_a828, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_a82b, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_a82d, 5);  call(0x1010_8a05, -0x1e2d);           /* call 0x10108a05 */
            ii(0x1010_a832, 5);  call(0x1011_5318, 0xaae1);            /* call 0x10115318 */
            ii(0x1010_a837, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1010_a83c, 1);  push(eax);                            /* push eax */
            ii(0x1010_a83d, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1010_a842, 5);  mov(ebx, 0x1_00ff);                   /* mov ebx, 0x100ff */
            ii(0x1010_a847, 5);  mov(edx, 0x101b_aafc);                /* mov edx, 0x101baafc */
            ii(0x1010_a84c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_a84f, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_a851, 5);  call(0x1010_8a05, -0x1e51);           /* call 0x10108a05 */
            ii(0x1010_a856, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1010_a85b, 5);  mov(edx, 0x101c_4e54);                /* mov edx, 0x101c4e54 */
            ii(0x1010_a860, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1010_a863, 5);  call(0x100d_4d78, -0x3_5af0);         /* call 0x100d4d78 */
            ii(0x1010_a868, 5);  mov(edx, 0x101b_ab10);                /* mov edx, 0x101bab10 */
            ii(0x1010_a86d, 3);  mov(esi, memd[ss, ebp - 4]);          /* mov esi, [ebp-0x4] */
            ii(0x1010_a870, 2);  mov(esi, memd[ds, esi]);              /* mov esi, [esi] */
            ii(0x1010_a872, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1010_a874, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1010_a876, 5);  call(0x1010_a2d7, -0x5a4);            /* call 0x1010a2d7 */
            ii(0x1010_a87b, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1010_a880, 5);  mov(edx, 0x101c_4e54);                /* mov edx, 0x101c4e54 */
            ii(0x1010_a885, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1010_a888, 5);  call(0x100d_4d78, -0x3_5b15);         /* call 0x100d4d78 */
            ii(0x1010_a88d, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1010_a88f, 5);  mov(edx, 0x101b_ab24);                /* mov edx, 0x101bab24 */
            ii(0x1010_a894, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_a897, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_a899, 5);  call(0x1010_a2d7, -0x5c7);            /* call 0x1010a2d7 */
            ii(0x1010_a89e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_a8a0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_a8a1, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_a8a2, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_a8a3, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_a8a4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_a8a5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_a8a6, 1);  ret();                                /* ret */
        }
    }
}
