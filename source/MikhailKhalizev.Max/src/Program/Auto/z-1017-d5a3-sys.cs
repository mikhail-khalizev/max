using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_d5a3-cc33a475")]
        public void /* sys */ Method_1017_d5a3()
        {
            ii(0x1017_d5a3, 1); push(esi);                              /* push esi */
            ii(0x1017_d5a4, 1); push(edi);                              /* push edi */
            ii(0x1017_d5a5, 1); push(ebp);                              /* push ebp */
            ii(0x1017_d5a6, 3); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1017_d5a9, 1); push(eax);                              /* push eax */
            ii(0x1017_d5aa, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1017_d5ac, 2); mov(esi, ebx);                          /* mov esi, ebx */
            ii(0x1017_d5ae, 4); mov(memd[ss, esp + 4], ecx);            /* mov [esp+0x4], ecx */
            ii(0x1017_d5b2, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_d5b4, 2); if(jz(0x1017_d5b8, 2)) goto l_0x1017_d5b8; /* jz 0x1017d5b8 */
            ii(0x1017_d5b6, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
        l_0x1017_d5b8:
            ii(0x1017_d5b8, 3); mov(edx, memd[ss, esp]);                /* mov edx, [esp] */
        l_0x1017_d5bb:
            ii(0x1017_d5bb, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1017_d5bd, 2); inc(al);                                /* inc al */
            ii(0x1017_d5bf, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_d5c4, 6); mov(al, memb[ds, eax + 0x101b_75c0]);   /* mov al, [eax+0x101b75c0] */
            ii(0x1017_d5ca, 2); and(al, 2);                             /* and al, 0x2 */
            ii(0x1017_d5cc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_d5d1, 2); if(jz(0x1017_d5d6, 3)) goto l_0x1017_d5d6; /* jz 0x1017d5d6 */
            ii(0x1017_d5d3, 1); inc(edx);                               /* inc edx */
            ii(0x1017_d5d4, 2); jmp(0x1017_d5bb, -0x1b); goto l_0x1017_d5bb; /* jmp 0x1017d5bb */
        l_0x1017_d5d6:
            ii(0x1017_d5d6, 2); mov(ch, memb[ds, edx]);                 /* mov ch, [edx] */
            ii(0x1017_d5d8, 2); mov(al, ch);                            /* mov al, ch */
            ii(0x1017_d5da, 3); cmp(eax, 0x2b);                         /* cmp eax, 0x2b */
            ii(0x1017_d5dd, 2); if(jz(0x1017_d5e4, 5)) goto l_0x1017_d5e4; /* jz 0x1017d5e4 */
            ii(0x1017_d5df, 3); cmp(eax, 0x2d);                         /* cmp eax, 0x2d */
            ii(0x1017_d5e2, 2); if(jnz(0x1017_d5e5, 1)) goto l_0x1017_d5e5; /* jnz 0x1017d5e5 */
        l_0x1017_d5e4:
            ii(0x1017_d5e4, 1); inc(edx);                               /* inc edx */
        l_0x1017_d5e5:
            ii(0x1017_d5e5, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_d5e7, 2); if(jnz(0x1017_d61d, 0x34)) goto l_0x1017_d61d; /* jnz 0x1017d61d */
            ii(0x1017_d5e9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_d5eb, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1017_d5ed, 3); cmp(eax, 0x30);                         /* cmp eax, 0x30 */
            ii(0x1017_d5f0, 2); if(jnz(0x1017_d608, 0x16)) goto l_0x1017_d608; /* jnz 0x1017d608 */
            ii(0x1017_d5f2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_d5f4, 3); mov(al, memb[ds, edx + 1]);             /* mov al, [edx+0x1] */
            ii(0x1017_d5f7, 3); cmp(eax, 0x78);                         /* cmp eax, 0x78 */
            ii(0x1017_d5fa, 2); if(jz(0x1017_d601, 5)) goto l_0x1017_d601; /* jz 0x1017d601 */
            ii(0x1017_d5fc, 3); cmp(eax, 0x58);                         /* cmp eax, 0x58 */
            ii(0x1017_d5ff, 2); if(jnz(0x1017_d608, 7)) goto l_0x1017_d608; /* jnz 0x1017d608 */
        l_0x1017_d601:
            ii(0x1017_d601, 5); mov(esi, 0x10);                         /* mov esi, 0x10 */
            ii(0x1017_d606, 2); jmp(0x1017_d61d, 0x15); goto l_0x1017_d61d; /* jmp 0x1017d61d */
        l_0x1017_d608:
            ii(0x1017_d608, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_d60a, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1017_d60c, 3); cmp(eax, 0x30);                         /* cmp eax, 0x30 */
            ii(0x1017_d60f, 2); if(jnz(0x1017_d618, 7)) goto l_0x1017_d618; /* jnz 0x1017d618 */
            ii(0x1017_d611, 5); mov(esi, 8);                            /* mov esi, 0x8 */
            ii(0x1017_d616, 2); jmp(0x1017_d61d, 5); goto l_0x1017_d61d; /* jmp 0x1017d61d */
        l_0x1017_d618:
            ii(0x1017_d618, 5); mov(esi, 0xa);                          /* mov esi, 0xa */
        l_0x1017_d61d:
            ii(0x1017_d61d, 3); cmp(esi, 2);                            /* cmp esi, 0x2 */
            ii(0x1017_d620, 2); if(jl(0x1017_d627, 5)) goto l_0x1017_d627; /* jl 0x1017d627 */
            ii(0x1017_d622, 3); cmp(esi, 0x24);                         /* cmp esi, 0x24 */
            ii(0x1017_d625, 2); if(jle(0x1017_d638, 0x11)) goto l_0x1017_d638; /* jle 0x1017d638 */
        l_0x1017_d627:
            ii(0x1017_d627, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1017_d62c, 5); call(/* sys */ 0x1018_d3bf, 0xfd8e);    /* call 0x1018d3bf */
            ii(0x1017_d631, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_d633, 5); jmp(0x1017_d6fd, 0xc5); goto l_0x1017_d6fd; /* jmp 0x1017d6fd */
        l_0x1017_d638:
            ii(0x1017_d638, 3); cmp(esi, 0x10);                         /* cmp esi, 0x10 */
            ii(0x1017_d63b, 2); if(jnz(0x1017_d658, 0x1b)) goto l_0x1017_d658; /* jnz 0x1017d658 */
            ii(0x1017_d63d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_d63f, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1017_d641, 3); cmp(eax, 0x30);                         /* cmp eax, 0x30 */
            ii(0x1017_d644, 2); if(jnz(0x1017_d658, 0x12)) goto l_0x1017_d658; /* jnz 0x1017d658 */
            ii(0x1017_d646, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_d648, 3); mov(al, memb[ds, edx + 1]);             /* mov al, [edx+0x1] */
            ii(0x1017_d64b, 3); cmp(eax, 0x78);                         /* cmp eax, 0x78 */
            ii(0x1017_d64e, 2); if(jz(0x1017_d655, 5)) goto l_0x1017_d655; /* jz 0x1017d655 */
            ii(0x1017_d650, 3); cmp(eax, 0x58);                         /* cmp eax, 0x58 */
            ii(0x1017_d653, 2); if(jnz(0x1017_d658, 3)) goto l_0x1017_d658; /* jnz 0x1017d658 */
        l_0x1017_d655:
            ii(0x1017_d655, 3); add(edx, 2);                            /* add edx, 0x2 */
        l_0x1017_d658:
            ii(0x1017_d658, 4); mov(memd[ss, esp + 8], edx);            /* mov [esp+0x8], edx */
            ii(0x1017_d65c, 2); mov(edi, esi);                          /* mov edi, esi */
            ii(0x1017_d65e, 2); xor(cl, cl);                            /* xor cl, cl */
            ii(0x1017_d660, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_d662, 3); shl(edi, 2);                            /* shl edi, 0x2 */
        l_0x1017_d665:
            ii(0x1017_d665, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_d667, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1017_d669, 5); call(/* sys */ 0x1017_d718, 0xaa);      /* call 0x1017d718 */
            ii(0x1017_d66e, 4); mov(memd[ss, esp + 0xc], eax);          /* mov [esp+0xc], eax */
            ii(0x1017_d672, 2); cmp(eax, esi);                          /* cmp eax, esi */
            ii(0x1017_d674, 2); if(jge(0x1017_d692, 0x1c)) goto l_0x1017_d692; /* jge 0x1017d692 */
            ii(0x1017_d676, 6); cmp(ebx, memd[ds, edi + 0x101b_e454]);  /* cmp ebx, [edi+0x101be454] */
            ii(0x1017_d67c, 2); if(jbe(0x1017_d680, 2)) goto l_0x1017_d680; /* jbe 0x1017d680 */
            ii(0x1017_d67e, 2); mov(cl, 1);                             /* mov cl, 0x1 */
        l_0x1017_d680:
            ii(0x1017_d680, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_d682, 3); imul(ebx, esi);                         /* imul ebx, esi */
            ii(0x1017_d685, 4); add(ebx, memd[ss, esp + 0xc]);          /* add ebx, [esp+0xc] */
            ii(0x1017_d689, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x1017_d68b, 2); if(jae(0x1017_d68f, 2)) goto l_0x1017_d68f; /* jae 0x1017d68f */
            ii(0x1017_d68d, 2); mov(cl, 1);                             /* mov cl, 0x1 */
        l_0x1017_d68f:
            ii(0x1017_d68f, 1); inc(edx);                               /* inc edx */
            ii(0x1017_d690, 2); jmp(0x1017_d665, -0x2d); goto l_0x1017_d665; /* jmp 0x1017d665 */
        l_0x1017_d692:
            ii(0x1017_d692, 4); cmp(edx, memd[ss, esp + 8]);            /* cmp edx, [esp+0x8] */
            ii(0x1017_d696, 2); if(jnz(0x1017_d69b, 3)) goto l_0x1017_d69b; /* jnz 0x1017d69b */
            ii(0x1017_d698, 3); mov(edx, memd[ss, esp]);                /* mov edx, [esp] */
        l_0x1017_d69b:
            ii(0x1017_d69b, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1017_d69d, 2); if(jz(0x1017_d6a2, 3)) goto l_0x1017_d6a2; /* jz 0x1017d6a2 */
            ii(0x1017_d69f, 3); mov(memd[ss, ebp], edx);                /* mov [ebp], edx */
        l_0x1017_d6a2:
            ii(0x1017_d6a2, 5); cmp(memd[ss, esp + 4], 1);              /* cmp dword [esp+0x4], 0x1 */
            ii(0x1017_d6a7, 2); if(jnz(0x1017_d6be, 0x15)) goto l_0x1017_d6be; /* jnz 0x1017d6be */
            ii(0x1017_d6a9, 6); cmp(ebx, 0x8000_0000);                  /* cmp ebx, 0x80000000 */
            ii(0x1017_d6af, 2); if(jb(0x1017_d6be, 0xd)) goto l_0x1017_d6be; /* jb 0x1017d6be */
            ii(0x1017_d6b1, 2); if(jnz(0x1017_d6bc, 9)) goto l_0x1017_d6bc; /* jnz 0x1017d6bc */
            ii(0x1017_d6b3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_d6b5, 2); mov(al, ch);                            /* mov al, ch */
            ii(0x1017_d6b7, 3); cmp(eax, 0x2d);                         /* cmp eax, 0x2d */
            ii(0x1017_d6ba, 2); if(jz(0x1017_d6be, 2)) goto l_0x1017_d6be; /* jz 0x1017d6be */
        l_0x1017_d6bc:
            ii(0x1017_d6bc, 2); mov(cl, 1);                             /* mov cl, 0x1 */
        l_0x1017_d6be:
            ii(0x1017_d6be, 2); test(cl, cl);                           /* test cl, cl */
            ii(0x1017_d6c0, 2); if(jz(0x1017_d6f2, 0x30)) goto l_0x1017_d6f2; /* jz 0x1017d6f2 */
            ii(0x1017_d6c2, 5); mov(eax, 0xe);                          /* mov eax, 0xe */
            ii(0x1017_d6c7, 4); mov(ebp, memd[ss, esp + 4]);            /* mov ebp, [esp+0x4] */
            ii(0x1017_d6cb, 5); call(/* sys */ 0x1018_d3bf, 0xfcef);    /* call 0x1018d3bf */
            ii(0x1017_d6d0, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1017_d6d2, 2); if(jnz(0x1017_d6db, 7)) goto l_0x1017_d6db; /* jnz 0x1017d6db */
            ii(0x1017_d6d4, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1017_d6d9, 2); jmp(0x1017_d6fd, 0x22); goto l_0x1017_d6fd; /* jmp 0x1017d6fd */
        l_0x1017_d6db:
            ii(0x1017_d6db, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_d6dd, 2); mov(al, ch);                            /* mov al, ch */
            ii(0x1017_d6df, 3); cmp(eax, 0x2d);                         /* cmp eax, 0x2d */
            ii(0x1017_d6e2, 2); if(jnz(0x1017_d6eb, 7)) goto l_0x1017_d6eb; /* jnz 0x1017d6eb */
            ii(0x1017_d6e4, 5); mov(ebx, 0x8000_0000);                  /* mov ebx, 0x80000000 */
            ii(0x1017_d6e9, 2); jmp(0x1017_d6fd, 0x12); goto l_0x1017_d6fd; /* jmp 0x1017d6fd */
        l_0x1017_d6eb:
            ii(0x1017_d6eb, 5); mov(ebx, 0x7fff_ffff);                  /* mov ebx, 0x7fffffff */
            ii(0x1017_d6f0, 2); jmp(0x1017_d6fd, 0xb); goto l_0x1017_d6fd; /* jmp 0x1017d6fd */
        l_0x1017_d6f2:
            ii(0x1017_d6f2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_d6f4, 2); mov(al, ch);                            /* mov al, ch */
            ii(0x1017_d6f6, 3); cmp(eax, 0x2d);                         /* cmp eax, 0x2d */
            ii(0x1017_d6f9, 2); if(jnz(0x1017_d6fd, 2)) goto l_0x1017_d6fd; /* jnz 0x1017d6fd */
            ii(0x1017_d6fb, 2); neg(ebx);                               /* neg ebx */
        l_0x1017_d6fd:
            ii(0x1017_d6fd, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_d6ff, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1017_d702, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_d703, 1); pop(edi);                               /* pop edi */
            ii(0x1017_d704, 1); pop(esi);                               /* pop esi */
            ii(0x1017_d705, 1); ret();                                  /* ret */
        }
    }
}
