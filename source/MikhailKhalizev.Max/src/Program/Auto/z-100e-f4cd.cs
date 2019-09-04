using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_f4cd-66b1488c")]
        public void Method_100e_f4cd()
        {
            ii(0x100e_f4cd, 1); push(ebp);                              /* push ebp */
            ii(0x100e_f4ce, 1); push(esi);                              /* push esi */
            ii(0x100e_f4cf, 1); push(edi);                              /* push edi */
            ii(0x100e_f4d0, 1); cld();                                  /* cld */
            ii(0x100e_f4d1, 5); mov(memd[ds, 0x101b_86e0], eax);        /* mov [0x101b86e0], eax */
            ii(0x100e_f4d6, 6); mov(memd[ds, 0x101b_86dc], edx);        /* mov [0x101b86dc], edx */
            ii(0x100e_f4dc, 6); mov(memb[ds, 0x101b_8704], bl);         /* mov [0x101b8704], bl */
            ii(0x100e_f4e2, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100e_f4e4, 1); lodsd();                                /* lodsd */
            ii(0x100e_f4e5, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_f4e7, 1); lodsd();                                /* lodsd */
            ii(0x100e_f4e8, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100e_f4ea, 1); lodsd();                                /* lodsd */
            ii(0x100e_f4eb, 1); dec(eax);                               /* dec eax */
            ii(0x100e_f4ec, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_f4ee, 1); lodsd();                                /* lodsd */
            ii(0x100e_f4ef, 1); dec(eax);                               /* dec eax */
            ii(0x100e_f4f0, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x100e_f4f2, 6); if(jle(0x100e_f7f4, 0x2fc)) goto l_0x100e_f7f4; /* jle 0x100ef7f4 */
            ii(0x100e_f4f8, 2); cmp(edx, ebx);                          /* cmp edx, ebx */
            ii(0x100e_f4fa, 6); if(jle(0x100e_f7f4, 0x2f4)) goto l_0x100e_f7f4; /* jle 0x100ef7f4 */
            ii(0x100e_f500, 5); mov(eax, memd[ds, 0x101c_9474]);        /* mov eax, [0x101c9474] */
            ii(0x100e_f505, 5); mov(memd[ds, 0x101b_8728], eax);        /* mov [0x101b8728], eax */
            ii(0x100e_f50a, 5); mov(eax, memd[ds, 0x101c_9470]);        /* mov eax, [0x101c9470] */
            ii(0x100e_f50f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_f511, 6); add(eax, memd[ds, 0x101c_9450]);        /* add eax, [0x101c9450] */
            ii(0x100e_f517, 5); mov(memd[ds, 0x101b_8710], eax);        /* mov [0x101b8710], eax */
            ii(0x100e_f51c, 5); mov(eax, memd[ds, 0x101c_38c8]);        /* mov eax, [0x101c38c8] */
            ii(0x100e_f521, 2); and(al, 0xe0);                          /* and al, 0xe0 */
            ii(0x100e_f523, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x100e_f526, 6); add(eax, memd[ds, 0x101c_945c]);        /* add eax, [0x101c945c] */
            ii(0x100e_f52c, 5); mov(memd[ds, 0x101b_8714], eax);        /* mov [0x101b8714], eax */
            ii(0x100e_f531, 5); mov(eax, memd[ds, 0x101b_86dc]);        /* mov eax, [0x101b86dc] */
            ii(0x100e_f536, 1); dec(eax);                               /* dec eax */
            ii(0x100e_f537, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x100e_f53a, 1); cdq();                                  /* cdq */
            ii(0x100e_f53b, 6); mov(ebx, memd[ds, 0x101c_38c0]);        /* mov ebx, [0x101c38c0] */
            ii(0x100e_f541, 1); dec(ebx);                               /* dec ebx */
            ii(0x100e_f542, 2); div(ebx);                               /* div ebx */
            ii(0x100e_f544, 3); add(eax, 8);                            /* add eax, 0x8 */
            ii(0x100e_f547, 5); mov(memd[ds, 0x101b_8730], eax);        /* mov [0x101b8730], eax */
            ii(0x100e_f54c, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x100e_f551, 3); shl(ebx, 6);                            /* shl ebx, 0x6 */
            ii(0x100e_f554, 6); mov(esi, memd[ds, 0x101b_86e0]);        /* mov esi, [0x101b86e0] */
            ii(0x100e_f55a, 6); lea(edi, memd[ds, 0x101b_86e4]);        /* lea edi, [0x101b86e4] */
            ii(0x100e_f560, 1); lodsd();                                /* lodsd */
            ii(0x100e_f561, 2); and(eax, ebx);                          /* and eax, ebx */
            ii(0x100e_f563, 1); stosd();                                /* stosd */
            ii(0x100e_f564, 1); lodsd();                                /* lodsd */
            ii(0x100e_f565, 2); and(eax, ebx);                          /* and eax, ebx */
            ii(0x100e_f567, 1); stosd();                                /* stosd */
            ii(0x100e_f568, 1); lodsd();                                /* lodsd */
            ii(0x100e_f569, 1); dec(eax);                               /* dec eax */
            ii(0x100e_f56a, 2); and(eax, ebx);                          /* and eax, ebx */
            ii(0x100e_f56c, 3); add(eax, 0x3f);                         /* add eax, 0x3f */
            ii(0x100e_f56f, 1); stosd();                                /* stosd */
            ii(0x100e_f570, 1); lodsd();                                /* lodsd */
            ii(0x100e_f571, 1); dec(eax);                               /* dec eax */
            ii(0x100e_f572, 2); and(eax, ebx);                          /* and eax, ebx */
            ii(0x100e_f574, 3); add(eax, 0x3f);                         /* add eax, 0x3f */
            ii(0x100e_f577, 1); stosd();                                /* stosd */
            ii(0x100e_f578, 5); mov(eax, memd[ds, 0x101b_86ec]);        /* mov eax, [0x101b86ec] */
            ii(0x100e_f57d, 6); sub(eax, memd[ds, 0x101b_86e4]);        /* sub eax, [0x101b86e4] */
            ii(0x100e_f583, 3); shr(eax, 6);                            /* shr eax, 0x6 */
            ii(0x100e_f586, 1); inc(eax);                               /* inc eax */
            ii(0x100e_f587, 5); mov(memb[ds, 0x101b_8705], al);         /* mov [0x101b8705], al */
            ii(0x100e_f58c, 5); mov(eax, memd[ds, 0x101b_86f0]);        /* mov eax, [0x101b86f0] */
            ii(0x100e_f591, 6); sub(eax, memd[ds, 0x101b_86e8]);        /* sub eax, [0x101b86e8] */
            ii(0x100e_f597, 3); shr(eax, 6);                            /* shr eax, 0x6 */
            ii(0x100e_f59a, 1); inc(eax);                               /* inc eax */
            ii(0x100e_f59b, 5); mov(memb[ds, 0x101b_8706], al);         /* mov [0x101b8706], al */
            ii(0x100e_f5a0, 6); mov(esi, memd[ds, 0x101b_86e0]);        /* mov esi, [0x101b86e0] */
            ii(0x100e_f5a6, 2); mov(eax, memd[ds, esi]);                /* mov eax, [esi] */
            ii(0x100e_f5a8, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x100e_f5ab, 1); cdq();                                  /* cdq */
            ii(0x100e_f5ac, 6); div(memd[ds, 0x101c_38c4]);             /* div dword [0x101c38c4] */
            ii(0x100e_f5b2, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_f5b4, 5); mov(eax, memd[ds, 0x101b_86e4]);        /* mov eax, [0x101b86e4] */
            ii(0x100e_f5b9, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x100e_f5bc, 1); cdq();                                  /* cdq */
            ii(0x100e_f5bd, 6); div(memd[ds, 0x101c_38c4]);             /* div dword [0x101c38c4] */
            ii(0x100e_f5c3, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x100e_f5c5, 2); neg(eax);                               /* neg eax */
            ii(0x100e_f5c7, 5); mov(memb[ds, 0x101b_8707], al);         /* mov [0x101b8707], al */
            ii(0x100e_f5cc, 6); mul(memd[ds, 0x101b_8730]);             /* mul dword [0x101b8730] */
            ii(0x100e_f5d2, 5); mov(memd[ds, 0x101b_86f4], eax);        /* mov [0x101b86f4], eax */
            ii(0x100e_f5d7, 3); mov(eax, memd[ds, esi + 4]);            /* mov eax, [esi+0x4] */
            ii(0x100e_f5da, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x100e_f5dd, 1); cdq();                                  /* cdq */
            ii(0x100e_f5de, 6); div(memd[ds, 0x101c_38c4]);             /* div dword [0x101c38c4] */
            ii(0x100e_f5e4, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_f5e6, 5); mov(eax, memd[ds, 0x101b_86e8]);        /* mov eax, [0x101b86e8] */
            ii(0x100e_f5eb, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x100e_f5ee, 1); cdq();                                  /* cdq */
            ii(0x100e_f5ef, 6); div(memd[ds, 0x101c_38c4]);             /* div dword [0x101c38c4] */
            ii(0x100e_f5f5, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x100e_f5f7, 2); neg(eax);                               /* neg eax */
            ii(0x100e_f5f9, 5); mov(memb[ds, 0x101b_8708], al);         /* mov [0x101b8708], al */
            ii(0x100e_f5fe, 6); mul(memd[ds, 0x101b_8730]);             /* mul dword [0x101b8730] */
            ii(0x100e_f604, 5); mov(memd[ds, 0x101b_86f8], eax);        /* mov [0x101b86f8], eax */
            ii(0x100e_f609, 3); mov(eax, memd[ds, esi + 8]);            /* mov eax, [esi+0x8] */
            ii(0x100e_f60c, 1); dec(eax);                               /* dec eax */
            ii(0x100e_f60d, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x100e_f610, 1); cdq();                                  /* cdq */
            ii(0x100e_f611, 6); div(memd[ds, 0x101c_38c4]);             /* div dword [0x101c38c4] */
            ii(0x100e_f617, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_f619, 5); mov(eax, memd[ds, 0x101b_86ec]);        /* mov eax, [0x101b86ec] */
            ii(0x100e_f61e, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x100e_f621, 1); cdq();                                  /* cdq */
            ii(0x100e_f622, 6); div(memd[ds, 0x101c_38c4]);             /* div dword [0x101c38c4] */
            ii(0x100e_f628, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x100e_f62a, 5); mov(memb[ds, 0x101b_8709], al);         /* mov [0x101b8709], al */
            ii(0x100e_f62f, 3); mov(eax, memd[ds, esi + 12]);           /* mov eax, [esi+0xc] */
            ii(0x100e_f632, 1); dec(eax);                               /* dec eax */
            ii(0x100e_f633, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x100e_f636, 1); cdq();                                  /* cdq */
            ii(0x100e_f637, 6); div(memd[ds, 0x101c_38c4]);             /* div dword [0x101c38c4] */
            ii(0x100e_f63d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_f63f, 5); mov(eax, memd[ds, 0x101b_86f0]);        /* mov eax, [0x101b86f0] */
            ii(0x100e_f644, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x100e_f647, 1); cdq();                                  /* cdq */
            ii(0x100e_f648, 6); div(memd[ds, 0x101c_38c4]);             /* div dword [0x101c38c4] */
            ii(0x100e_f64e, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x100e_f650, 5); mov(memb[ds, 0x101b_870a], al);         /* mov [0x101b870a], al */
            ii(0x100e_f655, 5); mov(al, memb[ds, 0x101b_8706]);         /* mov al, [0x101b8706] */
            ii(0x100e_f65a, 5); mov(memb[ds, 0x101b_870d], al);         /* mov [0x101b870d], al */
        l_0x100e_f65f:
            ii(0x100e_f65f, 5); mov(al, memb[ds, 0x101b_8705]);         /* mov al, [0x101b8705] */
            ii(0x100e_f664, 5); mov(memb[ds, 0x101b_870e], al);         /* mov [0x101b870e], al */
            ii(0x100e_f669, 6); mov(ecx, memd[ds, 0x101c_38c0]);        /* mov ecx, [0x101c38c0] */
            ii(0x100e_f66f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_f671, 6); mov(bl, memb[ds, 0x101b_870d]);         /* mov bl, [0x101b870d] */
            ii(0x100e_f677, 6); cmp(bl, memb[ds, 0x101b_8706]);         /* cmp bl, [0x101b8706] */
            ii(0x100e_f67d, 2); if(jnz(0x100e_f68a, 0xb)) goto l_0x100e_f68a; /* jnz 0x100ef68a */
            ii(0x100e_f67f, 6); sub(cl, memb[ds, 0x101b_8708]);         /* sub cl, [0x101b8708] */
            ii(0x100e_f685, 5); mov(eax, memd[ds, 0x101b_86f8]);        /* mov eax, [0x101b86f8] */
        l_0x100e_f68a:
            ii(0x100e_f68a, 3); cmp(bl, 1);                             /* cmp bl, 0x1 */
            ii(0x100e_f68d, 2); if(jnz(0x100e_f695, 6)) goto l_0x100e_f695; /* jnz 0x100ef695 */
            ii(0x100e_f68f, 6); sub(cl, memb[ds, 0x101b_870a]);         /* sub cl, [0x101b870a] */
        l_0x100e_f695:
            ii(0x100e_f695, 6); mov(memb[ds, 0x101b_870c], cl);         /* mov [0x101b870c], cl */
            ii(0x100e_f69b, 5); mov(memd[ds, 0x101b_8700], eax);        /* mov [0x101b8700], eax */
            ii(0x100e_f6a0, 5); mov(eax, memd[ds, 0x101b_8728]);        /* mov eax, [0x101b8728] */
            ii(0x100e_f6a5, 5); mov(memd[ds, 0x101b_8724], eax);        /* mov [0x101b8724], eax */
            ii(0x100e_f6aa, 7); movzx(eax, memw[ds, 0x101b_7f5c]);      /* movzx eax, word [0x101b7f5c] */
            ii(0x100e_f6b1, 2); mul(ecx);                               /* mul ecx */
            ii(0x100e_f6b3, 6); add(memd[ds, 0x101b_8728], eax);        /* add [0x101b8728], eax */
        l_0x100e_f6b9:
            ii(0x100e_f6b9, 6); mov(esi, memd[ds, 0x101b_8710]);        /* mov esi, [0x101b8710] */
            ii(0x100e_f6bf, 3); movzx(esi, memw[ds, esi]);              /* movzx esi, word [esi] */
            ii(0x100e_f6c2, 6); mov(cl, memb[ds, 0x101b_8704]);         /* mov cl, [0x101b8704] */
            ii(0x100e_f6c8, 2); shl(esi, cl);                           /* shl esi, cl */
            ii(0x100e_f6ca, 6); add(esi, memd[ds, 0x101c_944c]);        /* add esi, [0x101c944c] */
            ii(0x100e_f6d0, 6); mov(memd[ds, 0x101b_871c], esi);        /* mov [0x101b871c], esi */
            ii(0x100e_f6d6, 5); mov(eax, memd[ds, 0x101b_8700]);        /* mov eax, [0x101b8700] */
            ii(0x100e_f6db, 5); mov(memd[ds, 0x101b_8720], eax);        /* mov [0x101b8720], eax */
            ii(0x100e_f6e0, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x100e_f6e3, 2); shr(cl, 1);                             /* shr cl, 1 */
            ii(0x100e_f6e5, 2); shl(eax, cl);                           /* shl eax, cl */
            ii(0x100e_f6e7, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x100e_f6e9, 5); mov(al, memb[ds, 0x101b_870c]);         /* mov al, [0x101b870c] */
            ii(0x100e_f6ee, 5); mov(memb[ds, 0x101b_870f], al);         /* mov [0x101b870f], al */
            ii(0x100e_f6f3, 6); mov(ecx, memd[ds, 0x101c_38c0]);        /* mov ecx, [0x101c38c0] */
            ii(0x100e_f6f9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_f6fb, 6); mov(bl, memb[ds, 0x101b_870e]);         /* mov bl, [0x101b870e] */
            ii(0x100e_f701, 6); cmp(bl, memb[ds, 0x101b_8705]);         /* cmp bl, [0x101b8705] */
            ii(0x100e_f707, 2); if(jnz(0x100e_f714, 0xb)) goto l_0x100e_f714; /* jnz 0x100ef714 */
            ii(0x100e_f709, 6); sub(cl, memb[ds, 0x101b_8707]);         /* sub cl, [0x101b8707] */
            ii(0x100e_f70f, 5); mov(eax, memd[ds, 0x101b_86f4]);        /* mov eax, [0x101b86f4] */
        l_0x100e_f714:
            ii(0x100e_f714, 3); cmp(bl, 1);                             /* cmp bl, 0x1 */
            ii(0x100e_f717, 2); if(jnz(0x100e_f71f, 6)) goto l_0x100e_f71f; /* jnz 0x100ef71f */
            ii(0x100e_f719, 6); sub(cl, memb[ds, 0x101b_8709]);         /* sub cl, [0x101b8709] */
        l_0x100e_f71f:
            ii(0x100e_f71f, 6); mov(memb[ds, 0x101b_870b], cl);         /* mov [0x101b870b], cl */
            ii(0x100e_f725, 5); mov(memd[ds, 0x101b_86fc], eax);        /* mov [0x101b86fc], eax */
            ii(0x100e_f72a, 5); mov(eax, memd[ds, 0x101b_8724]);        /* mov eax, [0x101b8724] */
            ii(0x100e_f72f, 5); mov(memd[ds, 0x101b_872c], eax);        /* mov [0x101b872c], eax */
            ii(0x100e_f734, 6); add(memd[ds, 0x101b_8724], ecx);        /* add [0x101b8724], ecx */
            ii(0x100e_f73a, 5); mov(eax, memd[ds, 0x101b_8714]);        /* mov eax, [0x101b8714] */
        l_0x100e_f73f:
            ii(0x100e_f73f, 7); movzx(ecx, memb[ds, 0x101b_870b]);      /* movzx ecx, byte [0x101b870b] */
            ii(0x100e_f746, 6); mov(ebp, memd[ds, 0x101b_86fc]);        /* mov ebp, [0x101b86fc] */
            ii(0x100e_f74c, 6); mov(edi, memd[ds, 0x101b_872c]);        /* mov edi, [0x101b872c] */
            ii(0x100e_f752, 6); mov(edx, memd[ds, 0x101b_8730]);        /* mov edx, [0x101b8730] */
            ii(0x100e_f758, 2); mov(bl, cl);                            /* mov bl, cl */
            ii(0x100e_f75a, 2); shr(ecx, 1);                            /* shr ecx, 1 */
            ii(0x100e_f75c, 3); adc(ecx, 0);                            /* adc ecx, 0x0 */
            ii(0x100e_f75f, 3); test(bl, 1);                            /* test bl, 0x1 */
            ii(0x100e_f762, 2); if(jnz(0x100e_f771, 0xd)) goto l_0x100e_f771; /* jnz 0x100ef771 */
        l_0x100e_f764:
            ii(0x100e_f764, 2); mov(ebx, ebp);                          /* mov ebx, ebp */
            ii(0x100e_f766, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x100e_f769, 3); mov(al, memb[ds, esi + ebx]);           /* mov al, [esi+ebx] */
            ii(0x100e_f76c, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100e_f76e, 1); stosb();                                /* stosb */
            ii(0x100e_f76f, 2); add(ebp, edx);                          /* add ebp, edx */
        l_0x100e_f771:
            ii(0x100e_f771, 2); mov(ebx, ebp);                          /* mov ebx, ebp */
            ii(0x100e_f773, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x100e_f776, 3); mov(al, memb[ds, esi + ebx]);           /* mov al, [esi+ebx] */
            ii(0x100e_f779, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100e_f77b, 1); stosb();                                /* stosb */
            ii(0x100e_f77c, 2); add(ebp, edx);                          /* add ebp, edx */
            ii(0x100e_f77e, 2); if(loop(0x100e_f764, -0x1c)) goto l_0x100e_f764; /* loop 0x100ef764 */
            ii(0x100e_f780, 7); movzx(ebx, memw[ds, 0x101b_7f5c]);      /* movzx ebx, word [0x101b7f5c] */
            ii(0x100e_f787, 6); add(memd[ds, 0x101b_872c], ebx);        /* add [0x101b872c], ebx */
            ii(0x100e_f78d, 6); mov(esi, memd[ds, 0x101b_8720]);        /* mov esi, [0x101b8720] */
            ii(0x100e_f793, 6); add(esi, memd[ds, 0x101b_8730]);        /* add esi, [0x101b8730] */
            ii(0x100e_f799, 6); mov(memd[ds, 0x101b_8720], esi);        /* mov [0x101b8720], esi */
            ii(0x100e_f79f, 3); shr(esi, 0x10);                         /* shr esi, 0x10 */
            ii(0x100e_f7a2, 6); mov(cl, memb[ds, 0x101b_8704]);         /* mov cl, [0x101b8704] */
            ii(0x100e_f7a8, 2); shr(cl, 1);                             /* shr cl, 1 */
            ii(0x100e_f7aa, 2); shl(esi, cl);                           /* shl esi, cl */
            ii(0x100e_f7ac, 6); add(esi, memd[ds, 0x101b_871c]);        /* add esi, [0x101b871c] */
            ii(0x100e_f7b2, 6); dec(memb[ds, 0x101b_870f]);             /* dec byte [0x101b870f] */
            ii(0x100e_f7b8, 2); if(jnz(0x100e_f73f, -0x7b)) goto l_0x100e_f73f; /* jnz 0x100ef73f */
            ii(0x100e_f7ba, 7); add(memd[ds, 0x101b_8710], 2);          /* add dword [0x101b8710], 0x2 */
            ii(0x100e_f7c1, 6); dec(memb[ds, 0x101b_870e]);             /* dec byte [0x101b870e] */
            ii(0x100e_f7c7, 6); if(jnz(0x100e_f6b9, -0x114)) goto l_0x100e_f6b9; /* jnz 0x100ef6b9 */
            ii(0x100e_f7cd, 7); movzx(ecx, memw[ds, 0x101c_8172]);      /* movzx ecx, word [0x101c8172] */
            ii(0x100e_f7d4, 6); sub(cl, memb[ds, 0x101b_8705]);         /* sub cl, [0x101b8705] */
            ii(0x100e_f7da, 2); add(ecx, ecx);                          /* add ecx, ecx */
            ii(0x100e_f7dc, 5); mov(eax, memd[ds, 0x101b_8710]);        /* mov eax, [0x101b8710] */
            ii(0x100e_f7e1, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100e_f7e3, 5); mov(memd[ds, 0x101b_8710], eax);        /* mov [0x101b8710], eax */
            ii(0x100e_f7e8, 6); dec(memb[ds, 0x101b_870d]);             /* dec byte [0x101b870d] */
            ii(0x100e_f7ee, 6); if(jnz(0x100e_f65f, -0x195)) goto l_0x100e_f65f; /* jnz 0x100ef65f */
        l_0x100e_f7f4:
            ii(0x100e_f7f4, 1); pop(edi);                               /* pop edi */
            ii(0x100e_f7f5, 1); pop(esi);                               /* pop esi */
            ii(0x100e_f7f6, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_f7f7, 1); ret();                                  /* ret */
        }
    }
}
