using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_29f1-ad1c6dfa")]
        public void /* sys */ Method_1017_29f1()
        {
            ii(0x1017_29f1, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_29f2, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_29f3, 1);  push(esi);                            /* push esi */
            ii(0x1017_29f4, 1);  push(edi);                            /* push edi */
            ii(0x1017_29f5, 1);  push(ebp);                            /* push ebp */
            ii(0x1017_29f6, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1017_29f8, 4);  test(memb[ds, edx + 12], 2);          /* test byte [edx+0xc], 0x2 */
            ii(0x1017_29fc, 2);  if(jnz(0x1017_2a16, 0x18)) goto l_0x1017_2a16;/* jnz 0x10172a16 */
            ii(0x1017_29fe, 5);  mov(eax, 4);                          /* mov eax, 0x4 */
            ii(0x1017_2a03, 5);  call(/* sys */ 0x1018_d3bf, 0x1_a9b7);/* call 0x1018d3bf */
            ii(0x1017_2a08, 4);  or(memb[ds, edx + 12], 0x20);         /* or byte [edx+0xc], 0x20 */
        l_0x1017_2a0c:
            ii(0x1017_2a0c, 5);  mov(eax, 0xffff_ffff);                /* mov eax, 0xffffffff */
            ii(0x1017_2a11, 5);  jmp(0x1017_2a8f, 0x79); goto l_0x1017_2a8f;/* jmp 0x10172a8f */
        l_0x1017_2a16:
            ii(0x1017_2a16, 4);  cmp(memd[ds, edx + 8], 0);            /* cmp dword [edx+0x8], 0x0 */
            ii(0x1017_2a1a, 2);  if(jnz(0x1017_2a23, 7)) goto l_0x1017_2a23;/* jnz 0x10172a23 */
            ii(0x1017_2a1c, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1017_2a1e, 5);  call(/* sys */ 0x1018_d3ee, 0x1_a9cb);/* call 0x1018d3ee */
        l_0x1017_2a23:
            ii(0x1017_2a23, 5);  mov(ecx, 0x400);                      /* mov ecx, 0x400 */
            ii(0x1017_2a28, 3);  cmp(ebx, 0xa);                        /* cmp ebx, 0xa */
            ii(0x1017_2a2b, 2);  if(jnz(0x1017_2a60, 0x33)) goto l_0x1017_2a60;/* jnz 0x10172a60 */
            ii(0x1017_2a2d, 3);  mov(al, memb[ds, edx + 12]);          /* mov al, [edx+0xc] */
            ii(0x1017_2a30, 5);  mov(ecx, 0x600);                      /* mov ecx, 0x600 */
            ii(0x1017_2a35, 2);  test(al, 0x40);                       /* test al, 0x40 */
            ii(0x1017_2a37, 2);  if(jnz(0x1017_2a60, 0x27)) goto l_0x1017_2a60;/* jnz 0x10172a60 */
            ii(0x1017_2a39, 4);  or(memb[ds, edx + 13], 0x10);         /* or byte [edx+0xd], 0x10 */
            ii(0x1017_2a3d, 2);  mov(eax, memd[ds, edx]);              /* mov eax, [edx] */
            ii(0x1017_2a3f, 3);  mov(memb[ds, eax], 0xd);              /* mov byte [eax], 0xd */
            ii(0x1017_2a42, 2);  mov(esi, memd[ds, edx]);              /* mov esi, [edx] */
            ii(0x1017_2a44, 1);  inc(esi);                             /* inc esi */
            ii(0x1017_2a45, 3);  mov(edi, memd[ds, edx + 4]);          /* mov edi, [edx+0x4] */
            ii(0x1017_2a48, 2);  mov(memd[ds, edx], esi);              /* mov [edx], esi */
            ii(0x1017_2a4a, 1);  inc(edi);                             /* inc edi */
            ii(0x1017_2a4b, 3);  mov(ebp, memd[ds, edx + 20]);         /* mov ebp, [edx+0x14] */
            ii(0x1017_2a4e, 3);  mov(memd[ds, edx + 4], edi);          /* mov [edx+0x4], edi */
            ii(0x1017_2a51, 2);  cmp(edi, ebp);                        /* cmp edi, ebp */
            ii(0x1017_2a53, 2);  if(jnz(0x1017_2a60, 0xb)) goto l_0x1017_2a60;/* jnz 0x10172a60 */
            ii(0x1017_2a55, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1017_2a57, 5);  call(/* sys */ 0x1018_d5d9, 0x1_ab7d);/* call 0x1018d5d9 */
            ii(0x1017_2a5c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_2a5e, 2);  if(jnz(0x1017_2a0c, -0x54)) goto l_0x1017_2a0c;/* jnz 0x10172a0c */
        l_0x1017_2a60:
            ii(0x1017_2a60, 4);  or(memb[ds, edx + 13], 0x10);         /* or byte [edx+0xd], 0x10 */
            ii(0x1017_2a64, 2);  mov(eax, memd[ds, edx]);              /* mov eax, [edx] */
            ii(0x1017_2a66, 2);  mov(memb[ds, eax], bl);               /* mov [eax], bl */
            ii(0x1017_2a68, 2);  mov(eax, memd[ds, edx]);              /* mov eax, [edx] */
            ii(0x1017_2a6a, 1);  inc(eax);                             /* inc eax */
            ii(0x1017_2a6b, 3);  mov(esi, memd[ds, edx + 4]);          /* mov esi, [edx+0x4] */
            ii(0x1017_2a6e, 2);  mov(memd[ds, edx], eax);              /* mov [edx], eax */
            ii(0x1017_2a70, 1);  inc(esi);                             /* inc esi */
            ii(0x1017_2a71, 3);  mov(edi, memd[ds, edx + 12]);         /* mov edi, [edx+0xc] */
            ii(0x1017_2a74, 3);  mov(memd[ds, edx + 4], esi);          /* mov [edx+0x4], esi */
            ii(0x1017_2a77, 2);  test(ecx, edi);                       /* test ecx, edi */
            ii(0x1017_2a79, 2);  if(jnz(0x1017_2a80, 5)) goto l_0x1017_2a80;/* jnz 0x10172a80 */
            ii(0x1017_2a7b, 3);  cmp(esi, memd[ds, edx + 20]);         /* cmp esi, [edx+0x14] */
            ii(0x1017_2a7e, 2);  if(jnz(0x1017_2a8b, 0xb)) goto l_0x1017_2a8b;/* jnz 0x10172a8b */
        l_0x1017_2a80:
            ii(0x1017_2a80, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1017_2a82, 5);  call(/* sys */ 0x1018_d5d9, 0x1_ab52);/* call 0x1018d5d9 */
            ii(0x1017_2a87, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_2a89, 2);  if(jnz(0x1017_2a0c, -0x7f)) goto l_0x1017_2a0c;/* jnz 0x10172a0c */
        l_0x1017_2a8b:
            ii(0x1017_2a8b, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1017_2a8d, 2);  mov(al, bl);                          /* mov al, bl */
        l_0x1017_2a8f:
            ii(0x1017_2a8f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1017_2a90, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_2a91, 1);  pop(esi);                             /* pop esi */
            ii(0x1017_2a92, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1017_2a93, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_2a94, 1);  ret();                                /* ret */
        }
    }
}
