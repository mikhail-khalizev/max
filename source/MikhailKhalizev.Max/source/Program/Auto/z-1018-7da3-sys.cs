using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_7da3-35e8f41a")]
        public void /* sys */ Method_1018_7da3()
        {
            ii(0x1018_7da3, 1);  push(ecx);                            /* push ecx */
            ii(0x1018_7da4, 1);  push(esi);                            /* push esi */
            ii(0x1018_7da5, 1);  push(edi);                            /* push edi */
            ii(0x1018_7da6, 1);  push(ebp);                            /* push ebp */
            ii(0x1018_7da7, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1018_7da9, 3);  mov(ebp, memd[ds, eax + 12]);         /* mov ebp, [eax+0xc] */
            ii(0x1018_7dac, 3);  mov(ah, memb[ds, eax + 12]);          /* mov ah, [eax+0xc] */
            ii(0x1018_7daf, 3);  mov(ecx, memd[ds, esi + 8]);          /* mov ecx, [esi+0x8] */
            ii(0x1018_7db2, 3);  and(ah, 0xcf);                        /* and ah, 0xcf */
            ii(0x1018_7db5, 3);  and(ebp, 0x30);                       /* and ebp, 0x30 */
            ii(0x1018_7db8, 3);  mov(memb[ds, esi + 12], ah);          /* mov [esi+0xc], ah */
            ii(0x1018_7dbb, 2);  test(ecx, ecx);                       /* test ecx, ecx */
            ii(0x1018_7dbd, 2);  if(jnz(0x1018_7dc6, 7)) goto l_0x1018_7dc6;/* jnz 0x10187dc6 */
            ii(0x1018_7dbf, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1018_7dc1, 5);  call(/* sys */ 0x1018_d3ee, 0x5628);  /* call 0x1018d3ee */
        l_0x1018_7dc6:
            ii(0x1018_7dc6, 3);  mov(cl, memb[ds, esi + 13]);          /* mov cl, [esi+0xd] */
            ii(0x1018_7dc9, 2);  xor(edi, edi);                        /* xor edi, edi */
            ii(0x1018_7dcb, 3);  test(cl, 4);                          /* test cl, 0x4 */
            ii(0x1018_7dce, 2);  if(jz(0x1018_7de1, 0x11)) goto l_0x1018_7de1;/* jz 0x10187de1 */
            ii(0x1018_7dd0, 2);  mov(ch, cl);                          /* mov ch, cl */
            ii(0x1018_7dd2, 3);  and(ch, 0xfa);                        /* and ch, 0xfa */
            ii(0x1018_7dd5, 2);  mov(al, ch);                          /* mov al, ch */
            ii(0x1018_7dd7, 2);  or(al, 1);                            /* or al, 0x1 */
            ii(0x1018_7dd9, 5);  mov(edi, 1);                          /* mov edi, 0x1 */
            ii(0x1018_7dde, 3);  mov(memb[ds, esi + 13], al);          /* mov [esi+0xd], al */
        l_0x1018_7de1:
            ii(0x1018_7de1, 5);  mov(ecx, /* sys */ 0x1018_7d92);      /* mov ecx, 0x10187d92 */
            ii(0x1018_7de6, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1018_7de8, 5);  call(/* sys */ 0x1018_10e4, -0x6d09); /* call 0x101810e4 */
            ii(0x1018_7ded, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1018_7def, 2);  test(edi, edi);                       /* test edi, edi */
            ii(0x1018_7df1, 2);  if(jz(0x1018_7e08, 0x15)) goto l_0x1018_7e08;/* jz 0x10187e08 */
            ii(0x1018_7df3, 3);  mov(ah, memb[ds, esi + 13]);          /* mov ah, [esi+0xd] */
            ii(0x1018_7df6, 3);  and(ah, 0xfa);                        /* and ah, 0xfa */
            ii(0x1018_7df9, 2);  mov(bl, ah);                          /* mov bl, ah */
            ii(0x1018_7dfb, 3);  or(bl, 4);                            /* or bl, 0x4 */
            ii(0x1018_7dfe, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1018_7e00, 3);  mov(memb[ds, esi + 13], bl);          /* mov [esi+0xd], bl */
            ii(0x1018_7e03, 5);  call(/* sys */ 0x1018_d5d9, 0x57d1);  /* call 0x1018d5d9 */
        l_0x1018_7e08:
            ii(0x1018_7e08, 4);  test(memb[ds, esi + 12], 0x20);       /* test byte [esi+0xc], 0x20 */
            ii(0x1018_7e0c, 2);  if(jz(0x1018_7e13, 5)) goto l_0x1018_7e13;/* jz 0x10187e13 */
            ii(0x1018_7e0e, 5);  mov(edx, 0xffff_ffff);                /* mov edx, 0xffffffff */
        l_0x1018_7e13:
            ii(0x1018_7e13, 3);  mov(edi, memd[ds, esi + 12]);         /* mov edi, [esi+0xc] */
            ii(0x1018_7e16, 2);  or(edi, ebp);                         /* or edi, ebp */
            ii(0x1018_7e18, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1018_7e1a, 3);  mov(memd[ds, esi + 12], edi);         /* mov [esi+0xc], edi */
            ii(0x1018_7e1d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1018_7e1e, 1);  pop(edi);                             /* pop edi */
            ii(0x1018_7e1f, 1);  pop(esi);                             /* pop esi */
            ii(0x1018_7e20, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1018_7e21, 1);  ret();                                /* ret */
        }
    }
}
