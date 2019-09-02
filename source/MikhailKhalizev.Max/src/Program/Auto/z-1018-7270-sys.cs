using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_7270-1f1a0c05")]
        public void /* sys */ Method_1018_7270()
        {
            ii(0x1018_7270, 4); fld(memt[ss, esp + 0x10]);              /* fld tword [esp+0x10] */
            ii(0x1018_7274, 4); fld(memt[ss, esp + 4]);                 /* fld tword [esp+0x4] */
        l_0x1018_7278:
            ii(0x1018_7278, 4); mov(eax, memd[ss, esp + 8]);            /* mov eax, [esp+0x8] */
            ii(0x1018_727c, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1018_727e, 6); if(jae(0x1018_730a, 0x86)) goto l_0x1018_730a; /* jae 0x1018730a */
            ii(0x1018_7284, 5); xor(eax, 0xe00_0000);                   /* xor eax, 0xe000000 */
            ii(0x1018_7289, 5); test(eax, 0xe00_0000);                  /* test eax, 0xe000000 */
            ii(0x1018_728e, 2); if(jz(0x1018_7293, 3)) goto l_0x1018_7293; /* jz 0x10187293 */
            ii(0x1018_7290, 2); fdivp(ST(1), ST(0));                    /* fdivp st1, st0 */
            ii(0x1018_7292, 1); ret(); return;                          /* ret */
        l_0x1018_7293:
            ii(0x1018_7293, 3); shr(eax, 0x1c);                         /* shr eax, 0x1c */
            ii(0x1018_7296, 7); cmp(memb[ds, eax + 0x101c_3064], 0);    /* cmp byte [eax+0x101c3064], 0x0 */
            ii(0x1018_729d, 2); if(jnz(0x1018_72a2, 3)) goto l_0x1018_72a2; /* jnz 0x101872a2 */
            ii(0x1018_729f, 2); fdivp(ST(1), ST(0));                    /* fdivp st1, st0 */
            ii(0x1018_72a1, 1); ret(); return;                          /* ret */
        l_0x1018_72a2:
            ii(0x1018_72a2, 4); mov(eax, memd[ss, esp + 0xc]);          /* mov eax, [esp+0xc] */
            ii(0x1018_72a6, 5); and(eax, 0x7fff);                       /* and eax, 0x7fff */
            ii(0x1018_72ab, 2); if(jz(0x1018_7314, 0x67)) goto l_0x1018_7314; /* jz 0x10187314 */
            ii(0x1018_72ad, 5); cmp(eax, 0x7fff);                       /* cmp eax, 0x7fff */
            ii(0x1018_72b2, 2); if(jz(0x1018_7314, 0x60)) goto l_0x1018_7314; /* jz 0x10187314 */
            ii(0x1018_72b4, 4); fnstcw(memw[ss, esp + 0x1c]);           /* fnstcw word [esp+0x1c] */
            ii(0x1018_72b8, 4); mov(eax, memd[ss, esp + 0x1c]);         /* mov eax, [esp+0x1c] */
            ii(0x1018_72bc, 5); or(eax, 0x33f);                         /* or eax, 0x33f */
            ii(0x1018_72c1, 5); and(eax, 0xf3ff);                       /* and eax, 0xf3ff */
            ii(0x1018_72c6, 4); mov(memd[ss, esp + 0x20], eax);         /* mov [esp+0x20], eax */
            ii(0x1018_72ca, 4); fldcw(memw[ss, esp + 0x20]);            /* fldcw word [esp+0x20] */
            ii(0x1018_72ce, 4); mov(eax, memd[ss, esp + 0x18]);         /* mov eax, [esp+0x18] */
            ii(0x1018_72d2, 5); and(eax, 0x7fff);                       /* and eax, 0x7fff */
            ii(0x1018_72d7, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1018_72da, 2); if(jz(0x1018_72f3, 0x17)) goto l_0x1018_72f3; /* jz 0x101872f3 */
            ii(0x1018_72dc, 6); fmul(memd[ds, 0x101c_3074]);            /* fmul dword [0x101c3074] */
            ii(0x1018_72e2, 2); fxch(ST(0), ST(1));                     /* fxch st0, st1 */
            ii(0x1018_72e4, 6); fmul(memd[ds, 0x101c_3074]);            /* fmul dword [0x101c3074] */
            ii(0x1018_72ea, 2); fxch(ST(0), ST(1));                     /* fxch st0, st1 */
            ii(0x1018_72ec, 4); fldcw(memw[ss, esp + 0x1c]);            /* fldcw word [esp+0x1c] */
            ii(0x1018_72f0, 2); fdivp(ST(1), ST(0));                    /* fdivp st1, st0 */
            ii(0x1018_72f2, 1); ret(); return;                          /* ret */
        l_0x1018_72f3:
            ii(0x1018_72f3, 6); fmul(memd[ds, 0x101c_3078]);            /* fmul dword [0x101c3078] */
            ii(0x1018_72f9, 2); fxch(ST(0), ST(1));                     /* fxch st0, st1 */
            ii(0x1018_72fb, 6); fmul(memd[ds, 0x101c_3078]);            /* fmul dword [0x101c3078] */
            ii(0x1018_7301, 2); fxch(ST(0), ST(1));                     /* fxch st0, st1 */
            ii(0x1018_7303, 4); fldcw(memw[ss, esp + 0x1c]);            /* fldcw word [esp+0x1c] */
            ii(0x1018_7307, 2); fdivp(ST(1), ST(0));                    /* fdivp st1, st0 */
            ii(0x1018_7309, 1); ret(); return;                          /* ret */
        l_0x1018_730a:
            ii(0x1018_730a, 4); mov(eax, memd[ss, esp + 4]);            /* mov eax, [esp+0x4] */
            ii(0x1018_730e, 4); or(eax, memd[ss, esp + 8]);             /* or eax, [esp+0x8] */
            ii(0x1018_7312, 2); if(jnz(0x1018_7317, 3)) goto l_0x1018_7317; /* jnz 0x10187317 */
        l_0x1018_7314:
            ii(0x1018_7314, 2); fdivp(ST(1), ST(0));                    /* fdivp st1, st0 */
            ii(0x1018_7316, 1); ret(); return;                          /* ret */
        l_0x1018_7317:
            ii(0x1018_7317, 4); mov(eax, memd[ss, esp + 0xc]);          /* mov eax, [esp+0xc] */
            ii(0x1018_731b, 5); and(eax, 0x7fff);                       /* and eax, 0x7fff */
            ii(0x1018_7320, 2); if(jnz(0x1018_7314, -0xe)) goto l_0x1018_7314; /* jnz 0x10187314 */
            ii(0x1018_7322, 4); fnstcw(memw[ss, esp + 0x1c]);           /* fnstcw word [esp+0x1c] */
            ii(0x1018_7326, 4); mov(eax, memd[ss, esp + 0x1c]);         /* mov eax, [esp+0x1c] */
            ii(0x1018_732a, 5); or(eax, 0x33f);                         /* or eax, 0x33f */
            ii(0x1018_732f, 5); and(eax, 0xf3ff);                       /* and eax, 0xf3ff */
            ii(0x1018_7334, 4); mov(memd[ss, esp + 0x20], eax);         /* mov [esp+0x20], eax */
            ii(0x1018_7338, 4); fldcw(memw[ss, esp + 0x20]);            /* fldcw word [esp+0x20] */
            ii(0x1018_733c, 4); mov(eax, memd[ss, esp + 0x18]);         /* mov eax, [esp+0x18] */
            ii(0x1018_7340, 5); and(eax, 0x7fff);                       /* and eax, 0x7fff */
            ii(0x1018_7345, 2); if(jz(0x1018_7358, 0x11)) goto l_0x1018_7358; /* jz 0x10187358 */
            ii(0x1018_7347, 5); cmp(eax, 0x7fff);                       /* cmp eax, 0x7fff */
            ii(0x1018_734c, 2); if(jz(0x1018_7380, 0x32)) goto l_0x1018_7380; /* jz 0x10187380 */
            ii(0x1018_734e, 4); mov(eax, memd[ss, esp + 0x14]);         /* mov eax, [esp+0x14] */
            ii(0x1018_7352, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1018_7354, 2); if(jae(0x1018_7380, 0x2a)) goto l_0x1018_7380; /* jae 0x10187380 */
            ii(0x1018_7356, 2); jmp(0x1018_7360, 8); goto l_0x1018_7360; /* jmp 0x10187360 */
        l_0x1018_7358:
            ii(0x1018_7358, 4); mov(eax, memd[ss, esp + 0x14]);         /* mov eax, [esp+0x14] */
            ii(0x1018_735c, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1018_735e, 2); if(jb(0x1018_7380, 0x20)) goto l_0x1018_7380; /* jb 0x10187380 */
        l_0x1018_7360:
            ii(0x1018_7360, 2); fxch(ST(0), ST(1));                     /* fxch st0, st1 */
            ii(0x1018_7362, 2); fstp(ST(0));                            /* fstp st0 */
            ii(0x1018_7364, 2); fld(ST(0));                             /* fld st0 */
            ii(0x1018_7366, 6); fmul(memd[ds, 0x101c_307c]);            /* fmul dword [0x101c307c] */
            ii(0x1018_736c, 4); fstp(memt[ss, esp + 4]);                /* fstp tword [esp+0x4] */
            ii(0x1018_7370, 4); fld(memt[ss, esp + 0x10]);              /* fld tword [esp+0x10] */
            ii(0x1018_7374, 2); fxch(ST(0), ST(1));                     /* fxch st0, st1 */
            ii(0x1018_7376, 1); wait();                                 /* wait */
            ii(0x1018_7377, 4); fldcw(memw[ss, esp + 0x1c]);            /* fldcw word [esp+0x1c] */
            ii(0x1018_737b, 5); jmp(0x1018_7278, -0x108); goto l_0x1018_7278; /* jmp 0x10187278 */
        l_0x1018_7380:
            ii(0x1018_7380, 4); fldcw(memw[ss, esp + 0x1c]);            /* fldcw word [esp+0x1c] */
            ii(0x1018_7384, 2); fdivp(ST(1), ST(0));                    /* fdivp st1, st0 */
            ii(0x1018_7386, 1); ret();                                  /* ret */
        }
    }
}
