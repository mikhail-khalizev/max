using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_a1d0-4ff31256")]
        public void /* sys */ Method_1017_a1d0()
        {
            ii(0x1017_a1d0, 1);  push(ebp);                            /* push ebp */
            ii(0x1017_a1d1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1017_a1d3, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_a1d4, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_a1d5, 1);  push(esi);                            /* push esi */
            ii(0x1017_a1d6, 1);  push(edi);                            /* push edi */
            ii(0x1017_a1d7, 3);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1017_a1da, 3);  mov(memd[ss, ebp - 20], edx);         /* mov [ebp-0x14], edx */
            ii(0x1017_a1dd, 7);  cmp(memd[ds, 0x101b_e418], -1 /* 0xff */);/* cmp dword [0x101be418], 0xffffffff */
            ii(0x1017_a1e4, 6);  if(jz(0x1017_a352, 0x168)) goto l_0x1017_a352;/* jz 0x1017a352 */
            ii(0x1017_a1ea, 7);  cmp(memd[ds, 0x1020_9d14], 0);        /* cmp dword [0x10209d14], 0x0 */
            ii(0x1017_a1f1, 2);  if(jz(0x1017_a1fb, 8)) goto l_0x1017_a1fb;/* jz 0x1017a1fb */
            ii(0x1017_a1f3, 6);  mov(edx, memd[ds, 0x1020_9d14]);      /* mov edx, [0x10209d14] */
            ii(0x1017_a1f9, 2);  jmp(0x1017_a200, 5); goto l_0x1017_a200;/* jmp 0x1017a200 */
        l_0x1017_a1fb:
            ii(0x1017_a1fb, 5);  mov(edx, 0x3c);                       /* mov edx, 0x3c */
        l_0x1017_a200:
            ii(0x1017_a200, 6);  mov(ebx, memd[ds, 0x1020_9d10]);      /* mov ebx, [0x10209d10] */
            ii(0x1017_a206, 1);  inc(ebx);                             /* inc ebx */
            ii(0x1017_a207, 2);  cmp(ebx, edx);                        /* cmp ebx, edx */
            ii(0x1017_a209, 6);  if(jz(0x1017_a352, 0x143)) goto l_0x1017_a352;/* jz 0x1017a352 */
            ii(0x1017_a20f, 3);  mov(esi, memd[ss, ebp - 20]);         /* mov esi, [ebp-0x14] */
            ii(0x1017_a212, 6);  mov(edx, memd[ds, 0x1020_9cf4]);      /* mov edx, [0x10209cf4] */
            ii(0x1017_a218, 6);  mov(edi, memd[ds, 0x1020_9cf8]);      /* mov edi, [0x10209cf8] */
            ii(0x1017_a21e, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1017_a220, 2);  add(edx, esi);                        /* add edx, esi */
            ii(0x1017_a222, 6);  mov(memd[ds, 0x101b_e438], ecx);      /* mov [0x101be438], ecx */
            ii(0x1017_a228, 2);  cmp(edx, edi);                        /* cmp edx, edi */
            ii(0x1017_a22a, 2);  if(jbe(0x1017_a232, 6)) goto l_0x1017_a232;/* jbe 0x1017a232 */
            ii(0x1017_a22c, 6);  mov(memd[ds, 0x1020_9cf4], ecx);      /* mov [0x10209cf4], ecx */
        l_0x1017_a232:
            ii(0x1017_a232, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_a234, 2);  if(jz(0x1017_a268, 0x32)) goto l_0x1017_a268;/* jz 0x1017a268 */
            ii(0x1017_a236, 7);  cmp(memd[ds, 0x1020_9d04], 0);        /* cmp dword [0x10209d04], 0x0 */
            ii(0x1017_a23d, 2);  if(jz(0x1017_a268, 0x29)) goto l_0x1017_a268;/* jz 0x1017a268 */
            ii(0x1017_a23f, 6);  mov(ebx, memd[ds, 0x1020_9cfc]);      /* mov ebx, [0x10209cfc] */
            ii(0x1017_a245, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_a246, 3);  mov(ecx, memd[ss, ebp - 20]);         /* mov ecx, [ebp-0x14] */
            ii(0x1017_a249, 2);  push(1);                              /* push 0x1 */
            ii(0x1017_a24b, 5);  mov(eax, memd[ds, 0x1020_9d08]);      /* mov eax, [0x10209d08] */
            ii(0x1017_a250, 6);  mov(esi, memd[ds, 0x1020_9cf4]);      /* mov esi, [0x10209cf4] */
            ii(0x1017_a256, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_a257, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x1017_a259, 1);  push(eax);                            /* push eax */
            ii(0x1017_a25a, 6);  call_abs(memd[ds, 0x1020_9d04]);      /* call dword [0x10209d04] */
            ii(0x1017_a260, 3);  add(esp, 0x10);                       /* add esp, 0x10 */
            ii(0x1017_a263, 5);  jmp(0x1017_a307, 0x9f); goto l_0x1017_a307;/* jmp 0x1017a307 */
        l_0x1017_a268:
            ii(0x1017_a268, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_a26a, 6);  if(jz(0x1017_a2e1, 0x71)) goto l_0x1017_a2e1;/* jz 0x1017a2e1 */
            ii(0x1017_a270, 7);  cmp(memd[ds, 0x1020_9d0c], 0);        /* cmp dword [0x10209d0c], 0x0 */
            ii(0x1017_a277, 2);  if(jz(0x1017_a2bc, 0x43)) goto l_0x1017_a2bc;/* jz 0x1017a2bc */
            ii(0x1017_a279, 7);  cmp(memd[ds, 0x1020_9d00], 0);        /* cmp dword [0x10209d00], 0x0 */
            ii(0x1017_a280, 2);  if(jz(0x1017_a29f, 0x1d)) goto l_0x1017_a29f;/* jz 0x1017a29f */
            ii(0x1017_a282, 3);  mov(edi, memd[ss, ebp - 20]);         /* mov edi, [ebp-0x14] */
            ii(0x1017_a285, 1);  push(edi);                            /* push edi */
            ii(0x1017_a286, 6);  mov(edx, memd[ds, 0x1020_9cf4]);      /* mov edx, [0x10209cf4] */
            ii(0x1017_a28c, 1);  push(eax);                            /* push eax */
            ii(0x1017_a28d, 5);  mov(eax, memd[ds, 0x1020_9d08]);      /* mov eax, [0x10209d08] */
            ii(0x1017_a292, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1017_a294, 1);  push(eax);                            /* push eax */
            ii(0x1017_a295, 5);  call(/* sys */ 0x1018_ddba, 0x1_3b20);/* call 0x1018ddba */
            ii(0x1017_a29a, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x1017_a29d, 2);  jmp(0x1017_a307, 0x68); goto l_0x1017_a307;/* jmp 0x1017a307 */
        l_0x1017_a29f:
            ii(0x1017_a29f, 3);  mov(ecx, memd[ss, ebp - 20]);         /* mov ecx, [ebp-0x14] */
            ii(0x1017_a2a2, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_a2a3, 6);  mov(esi, memd[ds, 0x1020_9cf4]);      /* mov esi, [0x10209cf4] */
            ii(0x1017_a2a9, 1);  push(eax);                            /* push eax */
            ii(0x1017_a2aa, 5);  mov(eax, memd[ds, 0x1020_9d08]);      /* mov eax, [0x10209d08] */
            ii(0x1017_a2af, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x1017_a2b1, 1);  push(eax);                            /* push eax */
            ii(0x1017_a2b2, 5);  call(/* sys */ 0x1018_dd7b, 0x1_3ac4);/* call 0x1018dd7b */
            ii(0x1017_a2b7, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x1017_a2ba, 2);  jmp(0x1017_a307, 0x4b); goto l_0x1017_a307;/* jmp 0x1017a307 */
        l_0x1017_a2bc:
            ii(0x1017_a2bc, 3);  mov(ecx, memd[ss, ebp - 20]);         /* mov ecx, [ebp-0x14] */
            ii(0x1017_a2bf, 6);  mov(edi, memd[ds, 0x1020_9d08]);      /* mov edi, [0x10209d08] */
            ii(0x1017_a2c5, 6);  mov(edx, memd[ds, 0x1020_9cf4]);      /* mov edx, [0x10209cf4] */
            ii(0x1017_a2cb, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1017_a2cd, 2);  add(edi, edx);                        /* add edi, edx */
            ii(0x1017_a2cf, 1);  push(edi);                            /* push edi */
            ii(0x1017_a2d0, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1017_a2d2, 3);  shr(ecx, 2);                          /* shr ecx, 0x2 */
            ii(0x1017_a2d5, 2);  repne(() => movsd());                 /* repne movsd */
            ii(0x1017_a2d7, 2);  mov(cl, al);                          /* mov cl, al */
            ii(0x1017_a2d9, 3);  and(cl, 3);                           /* and cl, 0x3 */
            ii(0x1017_a2dc, 2);  repne(() => movsb());                 /* repne movsb */
            ii(0x1017_a2de, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_a2df, 2);  jmp(0x1017_a307, 0x26); goto l_0x1017_a307;/* jmp 0x1017a307 */
        l_0x1017_a2e1:
            ii(0x1017_a2e1, 6);  mov(ecx, memd[ds, 0x1020_9cfc]);      /* mov ecx, [0x10209cfc] */
            ii(0x1017_a2e7, 3);  mov(ebx, memd[ss, ebp - 20]);         /* mov ebx, [ebp-0x14] */
            ii(0x1017_a2ea, 2);  test(ecx, ecx);                       /* test ecx, ecx */
            ii(0x1017_a2ec, 2);  if(jz(0x1017_a2f2, 4)) goto l_0x1017_a2f2;/* jz 0x1017a2f2 */
            ii(0x1017_a2ee, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1017_a2f0, 2);  jmp(0x1017_a2f7, 5); goto l_0x1017_a2f7;/* jmp 0x1017a2f7 */
        l_0x1017_a2f2:
            ii(0x1017_a2f2, 5);  mov(edx, 0x80);                       /* mov edx, 0x80 */
        l_0x1017_a2f7:
            ii(0x1017_a2f7, 5);  mov(eax, memd[ds, 0x1020_9d08]);      /* mov eax, [0x10209d08] */
            ii(0x1017_a2fc, 6);  add(eax, memd[ds, 0x1020_9cf4]);      /* add eax, [0x10209cf4] */
            ii(0x1017_a302, 5);  call(Definitions.sys_memset, -0x1_4527);/* call 0x10165de0 */
        l_0x1017_a307:
            ii(0x1017_a307, 6);  mov(edx, memd[ds, 0x1020_9d08]);      /* mov edx, [0x10209d08] */
            ii(0x1017_a30d, 6);  mov(edi, memd[ds, 0x1020_9cf4]);      /* mov edi, [0x10209cf4] */
            ii(0x1017_a313, 5);  mov(eax, memd[ds, 0x1020_9d10]);      /* mov eax, [0x10209d10] */
            ii(0x1017_a318, 2);  add(edx, edi);                        /* add edx, edi */
            ii(0x1017_a31a, 7);  mov(memd[ds, eax * 8 + 0x1020_9a70], edx);/* mov [eax*8+0x10209a70], edx */
            ii(0x1017_a321, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x1017_a324, 7);  mov(memd[ds, eax * 8 + 0x1020_9a74], edx);/* mov [eax*8+0x10209a74], edx */
            ii(0x1017_a32b, 3);  cmp(eax, 0x3b);                       /* cmp eax, 0x3b */
            ii(0x1017_a32e, 2);  if(jnz(0x1017_a33a, 0xa)) goto l_0x1017_a33a;/* jnz 0x1017a33a */
            ii(0x1017_a330, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1017_a332, 6);  mov(memd[ds, 0x1020_9d10], ebx);      /* mov [0x10209d10], ebx */
            ii(0x1017_a338, 2);  jmp(0x1017_a343, 9); goto l_0x1017_a343;/* jmp 0x1017a343 */
        l_0x1017_a33a:
            ii(0x1017_a33a, 3);  lea(edx, memd[ds, eax + 1]);          /* lea edx, [eax+0x1] */
            ii(0x1017_a33d, 6);  mov(memd[ds, 0x1020_9d10], edx);      /* mov [0x10209d10], edx */
        l_0x1017_a343:
            ii(0x1017_a343, 6);  inc(memd[ds, 0x1020_9d98]);           /* inc dword [0x10209d98] */
            ii(0x1017_a349, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1017_a34c, 6);  add(memd[ds, 0x1020_9cf4], eax);      /* add [0x10209cf4], eax */
        l_0x1017_a352:
            ii(0x1017_a352, 3);  lea(esp, memd[ss, ebp - 16]);         /* lea esp, [ebp-0x10] */
            ii(0x1017_a355, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_a356, 1);  pop(esi);                             /* pop esi */
            ii(0x1017_a357, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1017_a358, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_a359, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1017_a35a, 1);  ret();                                /* ret */
        }
    }
}
