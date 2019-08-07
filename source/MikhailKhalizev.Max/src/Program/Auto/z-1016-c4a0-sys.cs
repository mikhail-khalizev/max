using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3b26d8f7-0ad1-4043-8226-5ebde4e465e9")]
        public void /* sys */ Method_1016_c4a0()
        {
            ii(0x1016_c4a0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_c4a1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_c4a3, 2); ftst();                                 /* ftst */
            ii(0x1016_c4a5, 3); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1016_c4a8, 1); wait();                                 /* wait */
            ii(0x1016_c4a9, 3); fnstsw(memw_a32[ss, ebp - 0x8]);        /* fnstsw word [ebp-0x8] */
            ii(0x1016_c4ac, 3); fst(memq_a32[ss, ebp - 0x18]);          /* fst qword [ebp-0x18] */
            ii(0x1016_c4af, 3); mov(ah, memb_a32[ss, ebp - 0x7]);       /* mov ah, [ebp-0x7] */
            ii(0x1016_c4b2, 1); sahf();                                 /* sahf */
            ii(0x1016_c4b3, 2); if(jnzd(0x1016_c4cf, 0x1a)) goto l_0x1016_c4cf; /* jnz 0x1016c4cf */
            ii(0x1016_c4b5, 2); mov(al, 0);                             /* mov al, 0x0 */
        l_0x1016_c4b7:
            ii(0x1016_c4b7, 2); fstp(ST(0));                            /* fstp st0 */
            ii(0x1016_c4b9, 3); fstp(memq_a32[ss, ebp - 0x10]);         /* fstp qword [ebp-0x10] */
            ii(0x1016_c4bc, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_c4bf, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_c4c2, 5); calld(/* sys */ 0x1018_7170, 0x1aca9);  /* call 0x10187170 */
            ii(0x1016_c4c7, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_c4ca, 5); jmpd(0x1016_c5c8, 0xf9); goto l_0x1016_c5c8; /* jmp 0x1016c5c8 */
        l_0x1016_c4cf:
            ii(0x1016_c4cf, 2); fld(ST(1));                             /* fld st1 */
            ii(0x1016_c4d1, 2); frndint();                              /* frndint */
            ii(0x1016_c4d3, 2); fcomp(ST(0), ST(2));                    /* fcomp st0, st2 */
            ii(0x1016_c4d5, 1); wait();                                 /* wait */
            ii(0x1016_c4d6, 3); fnstsw(memw_a32[ss, ebp - 0x6]);        /* fnstsw word [ebp-0x6] */
            ii(0x1016_c4d9, 1); wait();                                 /* wait */
            ii(0x1016_c4da, 3); mov(ah, memb_a32[ss, ebp - 0x5]);       /* mov ah, [ebp-0x5] */
            ii(0x1016_c4dd, 2); if(jaed(0x1016_c51a, 0x3b)) goto l_0x1016_c51a; /* jae 0x1016c51a */
            ii(0x1016_c4df, 2); mov(al, 0x1);                           /* mov al, 0x1 */
            ii(0x1016_c4e1, 1); sahf();                                 /* sahf */
            ii(0x1016_c4e2, 2); if(jnzd(0x1016_c4b7, -0x2d)) goto l_0x1016_c4b7; /* jnz 0x1016c4b7 */
            ii(0x1016_c4e4, 4); mov(ax, 0x2);                           /* mov ax, 0x2 */
            ii(0x1016_c4e8, 4); mov(memw_a32[ss, ebp - 0x4], ax);       /* mov [ebp-0x4], ax */
            ii(0x1016_c4ec, 3); fild(memw_a32[ss, ebp - 0x4]);          /* fild word [ebp-0x4] */
            ii(0x1016_c4ef, 2); fld(ST(2));                             /* fld st2 */
            ii(0x1016_c4f1, 2); fprem();                                /* fprem */
            ii(0x1016_c4f3, 1); wait();                                 /* wait */
            ii(0x1016_c4f4, 3); fnstsw(memw_a32[ss, ebp - 0x4]);        /* fnstsw word [ebp-0x4] */
            ii(0x1016_c4f7, 1); wait();                                 /* wait */
            ii(0x1016_c4f8, 3); mov(ah, memb_a32[ss, ebp - 0x3]);       /* mov ah, [ebp-0x3] */
            ii(0x1016_c4fb, 1); sahf();                                 /* sahf */
            ii(0x1016_c4fc, 2); mov(ah, 0);                             /* mov ah, 0x0 */
            ii(0x1016_c4fe, 2); if(jpd(0x1016_c511, 0x11)) goto l_0x1016_c511; /* jp 0x1016c511 */
            ii(0x1016_c500, 2); ftst();                                 /* ftst */
            ii(0x1016_c502, 1); wait();                                 /* wait */
            ii(0x1016_c503, 3); fnstsw(memw_a32[ss, ebp - 0x4]);        /* fnstsw word [ebp-0x4] */
            ii(0x1016_c506, 1); wait();                                 /* wait */
            ii(0x1016_c507, 3); mov(ah, memb_a32[ss, ebp - 0x3]);       /* mov ah, [ebp-0x3] */
            ii(0x1016_c50a, 1); sahf();                                 /* sahf */
            ii(0x1016_c50b, 2); mov(ah, 0);                             /* mov ah, 0x0 */
            ii(0x1016_c50d, 2); if(jzd(0x1016_c511, 0x2)) goto l_0x1016_c511; /* jz 0x1016c511 */
            ii(0x1016_c50f, 2); mov(ah, 0x1);                           /* mov ah, 0x1 */
        l_0x1016_c511:
            ii(0x1016_c511, 3); mov(memb_a32[ss, ebp - 0x7], ah);       /* mov [ebp-0x7], ah */
            ii(0x1016_c514, 2); fstp(ST(0));                            /* fstp st0 */
            ii(0x1016_c516, 2); fstp(ST(0));                            /* fstp st0 */
            ii(0x1016_c518, 2); jmpd(0x1016_c522, 0x8); goto l_0x1016_c522; /* jmp 0x1016c522 */
        l_0x1016_c51a:
            ii(0x1016_c51a, 1); sahf();                                 /* sahf */
            ii(0x1016_c51b, 2); if(jzd(0x1016_c522, 0x5)) goto l_0x1016_c522; /* jz 0x1016c522 */
            ii(0x1016_c51d, 5); jmpd(0x1016_c5a9, 0x87); goto l_0x1016_c5a9; /* jmp 0x1016c5a9 */
        l_0x1016_c522:
            ii(0x1016_c522, 2); fld(ST(1));                             /* fld st1 */
            ii(0x1016_c524, 3); fstp(memq_a32[ss, ebp - 0x10]);         /* fstp qword [ebp-0x10] */
            ii(0x1016_c527, 1); wait();                                 /* wait */
            ii(0x1016_c528, 4); mov(ax, memw_a32[ss, ebp - 0xa]);       /* mov ax, [ebp-0xa] */
            ii(0x1016_c52c, 4); and(ax, 0x7ff0);                        /* and ax, 0x7ff0 */
            ii(0x1016_c530, 4); sub(ax, 0x3ff0);                        /* sub ax, 0x3ff0 */
            ii(0x1016_c534, 4); cmp(ax, 0x100);                         /* cmp ax, 0x100 */
            ii(0x1016_c538, 2); if(jaed(0x1016_c5a9, 0x6f)) goto l_0x1016_c5a9; /* jae 0x1016c5a9 */
            ii(0x1016_c53a, 2); fld(ST(1));                             /* fld st1 */
            ii(0x1016_c53c, 3); fistp(memd_a32[ss, ebp - 0x4]);         /* fistp dword [ebp-0x4] */
            ii(0x1016_c53f, 1); wait();                                 /* wait */
            ii(0x1016_c540, 4); mov(ax, memw_a32[ss, ebp - 0x2]);       /* mov ax, [ebp-0x2] */
            ii(0x1016_c544, 3); or(ax, ax);                             /* or ax, ax */
            ii(0x1016_c547, 2); if(jnzd(0x1016_c554, 0xb)) goto l_0x1016_c554; /* jnz 0x1016c554 */
            ii(0x1016_c549, 4); mov(ax, memw_a32[ss, ebp - 0x4]);       /* mov ax, [ebp-0x4] */
            ii(0x1016_c54d, 5); calld(/* sys */ 0x1016_c5d3, 0x81);     /* call 0x1016c5d3 */
            ii(0x1016_c552, 2); jmpd(0x1016_c57f, 0x2b); goto l_0x1016_c57f; /* jmp 0x1016c57f */
        l_0x1016_c554:
            ii(0x1016_c554, 2); inc(ax);                                /* inc ax */
            ii(0x1016_c556, 2); if(jnzd(0x1016_c5a9, 0x51)) goto l_0x1016_c5a9; /* jnz 0x1016c5a9 */
            ii(0x1016_c558, 4); or(ax, memw_a32[ss, ebp - 0x4]);        /* or ax, [ebp-0x4] */
            ii(0x1016_c55c, 2); if(jzd(0x1016_c5a9, 0x4b)) goto l_0x1016_c5a9; /* jz 0x1016c5a9 */
            ii(0x1016_c55e, 3); neg(ax);                                /* neg ax */
            ii(0x1016_c561, 5); calld(/* sys */ 0x1016_c5d3, 0x6d);     /* call 0x1016c5d3 */
            ii(0x1016_c566, 2); fld1();                                 /* fld1 */
            ii(0x1016_c568, 7); test(memb_a32[ds, 0x101b_e89c], 0x1);   /* test byte [0x101be89c], 0x1 */
            ii(0x1016_c56f, 2); if(jnzd(0x1016_c575, 0x4)) goto l_0x1016_c575; /* jnz 0x1016c575 */
            ii(0x1016_c571, 2); fdivrp(ST(1), ST(0));                   /* fdivrp st1, st0 */
            ii(0x1016_c573, 2); jmpd(0x1016_c57f, 0xa); goto l_0x1016_c57f; /* jmp 0x1016c57f */
        l_0x1016_c575:
            ii(0x1016_c575, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x1016_c57a, 5); calld(/* sys */ 0x1018_7387, 0x1ae08);  /* call 0x10187387 */
        l_0x1016_c57f:
            ii(0x1016_c57f, 3); fst(memq_a32[ss, ebp - 0x8]);           /* fst qword [ebp-0x8] */
            ii(0x1016_c582, 1); wait();                                 /* wait */
            ii(0x1016_c583, 4); mov(ax, memw_a32[ss, ebp - 0x8]);       /* mov ax, [ebp-0x8] */
            ii(0x1016_c587, 4); or(ax, memw_a32[ss, ebp - 0x6]);        /* or ax, [ebp-0x6] */
            ii(0x1016_c58b, 4); or(ax, memw_a32[ss, ebp - 0x4]);        /* or ax, [ebp-0x4] */
            ii(0x1016_c58f, 2); if(jnzd(0x1016_c5a5, 0x14)) goto l_0x1016_c5a5; /* jnz 0x1016c5a5 */
            ii(0x1016_c591, 4); mov(ax, memw_a32[ss, ebp - 0x2]);       /* mov ax, [ebp-0x2] */
            ii(0x1016_c595, 3); shl(ax, 0x1);                           /* shl ax, 1 */
            ii(0x1016_c598, 4); cmp(ax, 0xffe0);                        /* cmp ax, 0xffe0 */
            ii(0x1016_c59c, 2); if(jnzd(0x1016_c5a5, 0x7)) goto l_0x1016_c5a5; /* jnz 0x1016c5a5 */
        l_0x1016_c59e:
            ii(0x1016_c59e, 2); mov(al, 0x2);                           /* mov al, 0x2 */
            ii(0x1016_c5a0, 5); jmpd(0x1016_c4b7, -0xee); goto l_0x1016_c4b7; /* jmp 0x1016c4b7 */
        l_0x1016_c5a5:
            ii(0x1016_c5a5, 2); fstp(ST(1));                            /* fstp st1 */
            ii(0x1016_c5a7, 2); jmpd(0x1016_c5c8, 0x1f); goto l_0x1016_c5c8; /* jmp 0x1016c5c8 */
        l_0x1016_c5a9:
            ii(0x1016_c5a9, 2); fldln2();                               /* fldln2 */
            ii(0x1016_c5ab, 2); fmul(ST(0), ST(2));                     /* fmul st0, st2 */
            ii(0x1016_c5ad, 2); fxch(ST(0), ST(1));                     /* fxch st0, st1 */
            ii(0x1016_c5af, 2); fabs();                                 /* fabs */
            ii(0x1016_c5b1, 2); fyl2x();                                /* fyl2x */
            ii(0x1016_c5b3, 2); mov(al, 0x7);                           /* mov al, 0x7 */
            ii(0x1016_c5b5, 5); calld(/* sys */ 0x1018_7204, 0x1ac4a);  /* call 0x10187204 */
            ii(0x1016_c5ba, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1016_c5bc, 2); if(jnzd(0x1016_c59e, -0x20)) goto l_0x1016_c59e; /* jnz 0x1016c59e */
            ii(0x1016_c5be, 3); mov(ah, memb_a32[ss, ebp - 0x7]);       /* mov ah, [ebp-0x7] */
            ii(0x1016_c5c1, 1); sahf();                                 /* sahf */
            ii(0x1016_c5c2, 2); if(jaed(0x1016_c5c6, 0x2)) goto l_0x1016_c5c6; /* jae 0x1016c5c6 */
            ii(0x1016_c5c4, 2); fchs();                                 /* fchs */
        l_0x1016_c5c6:
            ii(0x1016_c5c6, 2); fstp(ST(1));                            /* fstp st1 */
        l_0x1016_c5c8:
            ii(0x1016_c5c8, 3); fstp(memq_a32[ss, ebp - 0x8]);          /* fstp qword [ebp-0x8] */
            ii(0x1016_c5cb, 3); fld(memq_a32[ss, ebp - 0x8]);           /* fld qword [ebp-0x8] */
            ii(0x1016_c5ce, 1); wait();                                 /* wait */
            ii(0x1016_c5cf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_c5d1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_c5d2, 1); retd(); return;                         /* ret */
        }
    }
}
