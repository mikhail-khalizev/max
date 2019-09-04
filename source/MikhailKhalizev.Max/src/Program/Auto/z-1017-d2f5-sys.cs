using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_d2f5-1094b0e")]
        public void /* sys */ Method_1017_d2f5()
        {
            ii(0x1017_d2f5, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_d2f6, 1);  push(esi);                            /* push esi */
            ii(0x1017_d2f7, 1);  push(edi);                            /* push edi */
            ii(0x1017_d2f8, 1);  push(ebp);                            /* push ebp */
            ii(0x1017_d2f9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1017_d2fb, 3);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1017_d2fe, 1);  push(eax);                            /* push eax */
            ii(0x1017_d2ff, 1);  push(edx);                            /* push edx */
            ii(0x1017_d300, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_d301, 5);  call(/* sys */ 0x1019_46a5, 0x1_739f);/* call 0x101946a5 */
            ii(0x1017_d306, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1017_d309, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_d30b, 2);  if(jnz(0x1017_d321, 0x14)) goto l_0x1017_d321;/* jnz 0x1017d321 */
            ii(0x1017_d30d, 5);  mov(eax, 4);                          /* mov eax, 0x4 */
        l_0x1017_d312:
            ii(0x1017_d312, 5);  call(/* sys */ 0x1018_d3bf, 0x1_00a8);/* call 0x1018d3bf */
            ii(0x1017_d317, 5);  mov(eax, 0xffff_ffff);                /* mov eax, 0xffffffff */
            ii(0x1017_d31c, 5);  jmp(0x1017_d4c3, 0x1a2); goto l_0x1017_d4c3;/* jmp 0x1017d4c3 */
        l_0x1017_d321:
            ii(0x1017_d321, 2);  test(al, 2);                          /* test al, 0x2 */
            ii(0x1017_d323, 2);  if(jnz(0x1017_d32c, 7)) goto l_0x1017_d32c;/* jnz 0x1017d32c */
            ii(0x1017_d325, 5);  mov(eax, 6);                          /* mov eax, 0x6 */
            ii(0x1017_d32a, 2);  jmp(0x1017_d312, -0x1a); goto l_0x1017_d312;/* jmp 0x1017d312 */
        l_0x1017_d32c:
            ii(0x1017_d32c, 2);  test(al, 0x80);                       /* test al, 0x80 */
            ii(0x1017_d32e, 2);  if(jz(0x1017_d363, 0x33)) goto l_0x1017_d363;/* jz 0x1017d363 */
            ii(0x1017_d330, 2);  mov(al, 2);                           /* mov al, 0x2 */
            ii(0x1017_d332, 3);  mov(ebx, memd[ss, ebp - 28]);         /* mov ebx, [ebp-0x1c] */
            ii(0x1017_d335, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1017_d337, 2);  mov(ah, 0x42);                        /* mov ah, 0x42 */
            ii(0x1017_d339, 2);  mov(ecx, edx);                        /* mov ecx, edx */
            ii(0x1017_d33b, 3);  shr(ecx, 0x10);                       /* shr ecx, 0x10 */
            ii(0x1017_d33e, 2);  @int(0x21);                           /* int 0x21 */
            ii(0x1017_d340, 3);  rcl(dx, 1);                           /* rcl dx, 1 */
            ii(0x1017_d343, 3);  ror(dx, 1);                           /* ror dx, 1 */
            ii(0x1017_d346, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x1017_d349, 3);  mov(dx, ax);                          /* mov dx, ax */
            ii(0x1017_d34c, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1017_d34f, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1017_d351, 2);  if(jge(0x1017_d363, 0x10)) goto l_0x1017_d363;/* jge 0x1017d363 */
        l_0x1017_d353:
            ii(0x1017_d353, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1017_d355, 4);  mov(ax, memw[ss, ebp - 12]);          /* mov ax, [ebp-0xc] */
            ii(0x1017_d359, 5);  call(/* sys */ 0x1018_dbb7, 0x1_0859);/* call 0x1018dbb7 */
            ii(0x1017_d35e, 5);  jmp(0x1017_d4c3, 0x160); goto l_0x1017_d4c3;/* jmp 0x1017d4c3 */
        l_0x1017_d363:
            ii(0x1017_d363, 4);  test(memb[ss, ebp - 20], 0x40);       /* test byte [ebp-0x14], 0x40 */
            ii(0x1017_d367, 2);  if(jz(0x1017_d39e, 0x35)) goto l_0x1017_d39e;/* jz 0x1017d39e */
            ii(0x1017_d369, 3);  mov(ecx, memd[ss, ebp - 36]);         /* mov ecx, [ebp-0x24] */
            ii(0x1017_d36c, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x1017_d36f, 3);  mov(ebx, memd[ss, ebp - 28]);         /* mov ebx, [ebp-0x1c] */
            ii(0x1017_d372, 2);  mov(ah, 0x40);                        /* mov ah, 0x40 */
            ii(0x1017_d374, 2);  @int(0x21);                           /* int 0x21 */
            ii(0x1017_d376, 2);  rcl(eax, 1);                          /* rcl eax, 1 */
            ii(0x1017_d378, 2);  ror(eax, 1);                          /* ror eax, 1 */
            ii(0x1017_d37a, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1017_d37c, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1017_d37f, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_d381, 2);  if(jl(0x1017_d353, -0x30)) goto l_0x1017_d353;/* jl 0x1017d353 */
            ii(0x1017_d383, 3);  cmp(eax, memd[ss, ebp - 36]);         /* cmp eax, [ebp-0x24] */
            ii(0x1017_d386, 6);  if(jz(0x1017_d4c0, 0x134)) goto l_0x1017_d4c0;/* jz 0x1017d4c0 */
            ii(0x1017_d38c, 5);  mov(eax, 0xc);                        /* mov eax, 0xc */
            ii(0x1017_d391, 5);  call(/* sys */ 0x1018_d3bf, 0x1_0029);/* call 0x1018d3bf */
            ii(0x1017_d396, 3);  mov(memd[ss, ebp - 36], esi);         /* mov [ebp-0x24], esi */
            ii(0x1017_d399, 5);  jmp(0x1017_d4c0, 0x122); goto l_0x1017_d4c0;/* jmp 0x1017d4c0 */
        l_0x1017_d39e:
            ii(0x1017_d39e, 5);  call(/* sys */ 0x1019_470f, 0x1_736c);/* call 0x1019470f */
            ii(0x1017_d3a3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1017_d3a5, 5);  cmp(eax, 0xb0);                       /* cmp eax, 0xb0 */
            ii(0x1017_d3aa, 2);  if(jae(0x1017_d3b1, 5)) goto l_0x1017_d3b1;/* jae 0x1017d3b1 */
            ii(0x1017_d3ac, 5);  call(/* sys */ 0x1016_5d83, -0x1_762e);/* call 0x10165d83 */
        l_0x1017_d3b1:
            ii(0x1017_d3b1, 5);  mov(edi, 0x200);                      /* mov edi, 0x200 */
            ii(0x1017_d3b6, 6);  cmp(edx, 0x230);                      /* cmp edx, 0x230 */
            ii(0x1017_d3bc, 2);  if(jae(0x1017_d3c3, 5)) goto l_0x1017_d3c3;/* jae 0x1017d3c3 */
            ii(0x1017_d3be, 5);  mov(edi, 0x80);                       /* mov edi, 0x80 */
        l_0x1017_d3c3:
            ii(0x1017_d3c3, 3);  lea(eax, memd[ds, edi + 3]);          /* lea eax, [edi+0x3] */
            ii(0x1017_d3c6, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1017_d3c8, 2);  and(al, 0xfc);                        /* and al, 0xfc */
            ii(0x1017_d3ca, 2);  xor(esi, esi);                        /* xor esi, esi */
            ii(0x1017_d3cc, 2);  sub(esp, eax);                        /* sub esp, eax */
            ii(0x1017_d3ce, 2);  mov(eax, esp);                        /* mov eax, esp */
            ii(0x1017_d3d0, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1017_d3d3, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1017_d3d6, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1017_d3d9, 3);  mov(memd[ss, ebp - 24], edx);         /* mov [ebp-0x18], edx */
            ii(0x1017_d3dc, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1017_d3df:
            ii(0x1017_d3df, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1017_d3e2, 3);  cmp(eax, memd[ss, ebp - 36]);         /* cmp eax, [ebp-0x24] */
            ii(0x1017_d3e5, 6);  if(jae(0x1017_d48a, 0x9f)) goto l_0x1017_d48a;/* jae 0x1017d48a */
            ii(0x1017_d3eb, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1017_d3ee, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1017_d3f0, 2);  mov(al, memb[ds, edx]);               /* mov al, [edx] */
            ii(0x1017_d3f2, 3);  cmp(eax, 0xa);                        /* cmp eax, 0xa */
            ii(0x1017_d3f5, 2);  if(jnz(0x1017_d43f, 0x48)) goto l_0x1017_d43f;/* jnz 0x1017d43f */
            ii(0x1017_d3f7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1017_d3fa, 4);  mov(memb[ds, esi + eax], 0xd);        /* mov byte [esi+eax], 0xd */
            ii(0x1017_d3fe, 1);  inc(esi);                             /* inc esi */
            ii(0x1017_d3ff, 2);  cmp(esi, edi);                        /* cmp esi, edi */
            ii(0x1017_d401, 2);  if(jnz(0x1017_d43f, 0x3c)) goto l_0x1017_d43f;/* jnz 0x1017d43f */
            ii(0x1017_d403, 3);  mov(ebx, memd[ss, ebp - 28]);         /* mov ebx, [ebp-0x1c] */
            ii(0x1017_d406, 2);  mov(ecx, edi);                        /* mov ecx, edi */
            ii(0x1017_d408, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1017_d40a, 2);  mov(ah, 0x40);                        /* mov ah, 0x40 */
            ii(0x1017_d40c, 2);  @int(0x21);                           /* int 0x21 */
            ii(0x1017_d40e, 2);  rcl(eax, 1);                          /* rcl eax, 1 */
            ii(0x1017_d410, 2);  ror(eax, 1);                          /* ror eax, 1 */
            ii(0x1017_d412, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1017_d414, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1017_d417, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_d419, 6);  if(jl(0x1017_d353, -0xcc)) goto l_0x1017_d353;/* jl 0x1017d353 */
            ii(0x1017_d41f, 2);  cmp(eax, edi);                        /* cmp eax, edi */
            ii(0x1017_d421, 2);  if(jz(0x1017_d437, 0x14)) goto l_0x1017_d437;/* jz 0x1017d437 */
        l_0x1017_d423:
            ii(0x1017_d423, 5);  mov(eax, 0xc);                        /* mov eax, 0xc */
            ii(0x1017_d428, 5);  call(/* sys */ 0x1018_d3bf, 0xff92);  /* call 0x1018d3bf */
            ii(0x1017_d42d, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1017_d430, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x1017_d432, 5);  jmp(0x1017_d4c3, 0x8c); goto l_0x1017_d4c3;/* jmp 0x1017d4c3 */
        l_0x1017_d437:
            ii(0x1017_d437, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1017_d43a, 2);  xor(esi, edi);                        /* xor esi, edi */
            ii(0x1017_d43c, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
        l_0x1017_d43f:
            ii(0x1017_d43f, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1017_d442, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1017_d445, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1017_d448, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1017_d44b, 1);  inc(ebx);                             /* inc ebx */
            ii(0x1017_d44c, 1);  inc(ecx);                             /* inc ecx */
            ii(0x1017_d44d, 2);  mov(dl, memb[ds, edx]);               /* mov dl, [edx] */
            ii(0x1017_d44f, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1017_d452, 3);  mov(memb[ds, esi + eax], dl);         /* mov [esi+eax], dl */
            ii(0x1017_d455, 1);  inc(esi);                             /* inc esi */
            ii(0x1017_d456, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1017_d459, 2);  cmp(esi, edi);                        /* cmp esi, edi */
            ii(0x1017_d45b, 2);  if(jnz(0x1017_d3df, -0x7e)) goto l_0x1017_d3df;/* jnz 0x1017d3df */
            ii(0x1017_d45d, 3);  mov(ebx, memd[ss, ebp - 28]);         /* mov ebx, [ebp-0x1c] */
            ii(0x1017_d460, 2);  mov(ecx, edi);                        /* mov ecx, edi */
            ii(0x1017_d462, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1017_d464, 2);  mov(ah, 0x40);                        /* mov ah, 0x40 */
            ii(0x1017_d466, 2);  @int(0x21);                           /* int 0x21 */
            ii(0x1017_d468, 2);  rcl(eax, 1);                          /* rcl eax, 1 */
            ii(0x1017_d46a, 2);  ror(eax, 1);                          /* ror eax, 1 */
            ii(0x1017_d46c, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1017_d46e, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1017_d471, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_d473, 6);  if(jl(0x1017_d353, -0x126)) goto l_0x1017_d353;/* jl 0x1017d353 */
            ii(0x1017_d479, 2);  cmp(eax, edi);                        /* cmp eax, edi */
            ii(0x1017_d47b, 2);  if(jnz(0x1017_d423, -0x5a)) goto l_0x1017_d423;/* jnz 0x1017d423 */
            ii(0x1017_d47d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1017_d480, 2);  xor(esi, edi);                        /* xor esi, edi */
            ii(0x1017_d482, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1017_d485, 5);  jmp(0x1017_d3df, -0xab); goto l_0x1017_d3df;/* jmp 0x1017d3df */
        l_0x1017_d48a:
            ii(0x1017_d48a, 2);  test(esi, esi);                       /* test esi, esi */
            ii(0x1017_d48c, 2);  if(jz(0x1017_d4c0, 0x32)) goto l_0x1017_d4c0;/* jz 0x1017d4c0 */
            ii(0x1017_d48e, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1017_d491, 3);  mov(ebx, memd[ss, ebp - 28]);         /* mov ebx, [ebp-0x1c] */
            ii(0x1017_d494, 2);  mov(ecx, esi);                        /* mov ecx, esi */
            ii(0x1017_d496, 2);  mov(ah, 0x40);                        /* mov ah, 0x40 */
            ii(0x1017_d498, 2);  @int(0x21);                           /* int 0x21 */
            ii(0x1017_d49a, 2);  rcl(eax, 1);                          /* rcl eax, 1 */
            ii(0x1017_d49c, 2);  ror(eax, 1);                          /* ror eax, 1 */
            ii(0x1017_d49e, 2);  mov(edi, eax);                        /* mov edi, eax */
            ii(0x1017_d4a0, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1017_d4a3, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_d4a5, 6);  if(jl(0x1017_d353, -0x158)) goto l_0x1017_d353;/* jl 0x1017d353 */
            ii(0x1017_d4ab, 2);  cmp(eax, esi);                        /* cmp eax, esi */
            ii(0x1017_d4ad, 2);  if(jz(0x1017_d4c0, 0x11)) goto l_0x1017_d4c0;/* jz 0x1017d4c0 */
            ii(0x1017_d4af, 5);  mov(eax, 0xc);                        /* mov eax, 0xc */
            ii(0x1017_d4b4, 5);  call(/* sys */ 0x1018_d3bf, 0xff06);  /* call 0x1018d3bf */
            ii(0x1017_d4b9, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1017_d4bc, 2);  add(eax, edi);                        /* add eax, edi */
            ii(0x1017_d4be, 2);  jmp(0x1017_d4c3, 3); goto l_0x1017_d4c3;/* jmp 0x1017d4c3 */
        l_0x1017_d4c0:
            ii(0x1017_d4c0, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
        l_0x1017_d4c3:
            ii(0x1017_d4c3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1017_d4c5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1017_d4c6, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_d4c7, 1);  pop(esi);                             /* pop esi */
            ii(0x1017_d4c8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1017_d4c9, 1);  ret();                                /* ret */
        }
    }
}
