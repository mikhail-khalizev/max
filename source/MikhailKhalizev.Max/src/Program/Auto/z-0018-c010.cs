using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_c010-2116cdf0")]
        public void Method_0018_c010()
        {
            ii(0x18_c010, 4); enterw(0xc, 0);                           /* enter 0xc, 0x0 */
            ii(0x18_c014, 1); pushw(di);                                /* push di */
            ii(0x18_c015, 1); pushw(si);                                /* push si */
            ii(0x18_c016, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x18_c019, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x18_c01c, 4); cmp(memw_a16[ds, 0x9a], dx);              /* cmp [0x9a], dx */
            ii(0x18_c020, 2); if(jbew(0x18_c025, 0x3)) goto l_0x18_c025; /* jbe 0xc025 */
            ii(0x18_c022, 3); jmpw(0x18_c298, 0x273); goto l_0x18_c298; /* jmp 0xc298 */
        l_0x18_c025:
            ii(0x18_c025, 2); if(jbw(0x18_c02d, 0x6)) goto l_0x18_c02d; /* jb 0xc02d */
            ii(0x18_c027, 4); cmp(memw_a16[ds, 0x98], ax);              /* cmp [0x98], ax */
            ii(0x18_c02b, 2); if(jaw(0x18_c039, 0xc)) goto l_0x18_c039; /* ja 0xc039 */
        l_0x18_c02d:
            ii(0x18_c02d, 3); add(ax, memw_a16[ss, bp + 0x8]);          /* add ax, [bp+0x8] */
            ii(0x18_c030, 3); adc(dx, memw_a16[ss, bp + 0xa]);          /* adc dx, [bp+0xa] */
            ii(0x18_c033, 4); cmp(dx, memw_a16[ds, 0x9e]);              /* cmp dx, [0x9e] */
            ii(0x18_c037, 2); if(jbew(0x18_c03c, 0x3)) goto l_0x18_c03c; /* jbe 0xc03c */
        l_0x18_c039:
            ii(0x18_c039, 3); jmpw(0x18_c298, 0x25c); goto l_0x18_c298; /* jmp 0xc298 */
        l_0x18_c03c:
            ii(0x18_c03c, 2); if(jbw(0x18_c044, 0x6)) goto l_0x18_c044; /* jb 0xc044 */
            ii(0x18_c03e, 4); cmp(ax, memw_a16[ds, 0x9c]);              /* cmp ax, [0x9c] */
            ii(0x18_c042, 2); if(jaw(0x18_c04c, 0x8)) goto l_0x18_c04c; /* ja 0xc04c */
        l_0x18_c044:
            ii(0x18_c044, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x18_c047, 3); or(ax, memw_a16[ss, bp + 0x8]);           /* or ax, [bp+0x8] */
            ii(0x18_c04a, 2); if(jnzw(0x18_c04f, 0x3)) goto l_0x18_c04f; /* jnz 0xc04f */
        l_0x18_c04c:
            ii(0x18_c04c, 3); jmpw(0x18_c298, 0x249); goto l_0x18_c298; /* jmp 0xc298 */
        l_0x18_c04f:
            ii(0x18_c04f, 5); test(memb_a16[ds, 0x47], 0x80);           /* test byte [0x47], 0x80 */
            ii(0x18_c054, 2); if(jzw(0x18_c05c, 0x6)) goto l_0x18_c05c; /* jz 0xc05c */
            ii(0x18_c056, 3); pushw(0x111c);                            /* push 0x111c */
            ii(0x18_c059, 3); callw(0x18_c004, -0x58);                  /* call 0xc004 */
        l_0x18_c05c:
            ii(0x18_c05c, 1); cli();                                    /* cli */
            ii(0x18_c05d, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_c05f, 3); mov(ax, memw_a16[ds, 0x98]);              /* mov ax, [0x98] */
            ii(0x18_c062, 4); mov(dx, memw_a16[ds, 0x9a]);              /* mov dx, [0x9a] */
            ii(0x18_c066, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x18_c069, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
        l_0x18_c06c:
            ii(0x18_c06c, 1); pushw(dx);                                /* push dx */
            ii(0x18_c06d, 1); pushw(ax);                                /* push ax */
            ii(0x18_c06e, 3); callw(0x18_db51, 0x1ae0);                 /* call 0xdb51 */
            ii(0x18_c071, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_c074, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x18_c077, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x18_c07a, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x18_c07d, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x18_c080, 3); cmp(memw_a16[ss, bp - 0x2], dx);          /* cmp [bp-0x2], dx */
            ii(0x18_c083, 2); if(jaw(0x18_c0a4, 0x1f)) goto l_0x18_c0a4; /* ja 0xc0a4 */
            ii(0x18_c085, 2); if(jbw(0x18_c08c, 0x5)) goto l_0x18_c08c; /* jb 0xc08c */
            ii(0x18_c087, 3); cmp(memw_a16[ss, bp - 0x4], ax);          /* cmp [bp-0x4], ax */
            ii(0x18_c08a, 2); if(jaew(0x18_c0a4, 0x18)) goto l_0x18_c0a4; /* jae 0xc0a4 */
        l_0x18_c08c:
            ii(0x18_c08c, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x18_c08f, 3); or(ax, memw_a16[ss, bp - 0x4]);           /* or ax, [bp-0x4] */
            ii(0x18_c092, 2); if(jzw(0x18_c0a4, 0x10)) goto l_0x18_c0a4; /* jz 0xc0a4 */
            ii(0x18_c094, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x18_c097, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x18_c09a, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x18_c09d, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x18_c0a0, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_c0a2, 2); jmpw(0x18_c06c, -0x38); goto l_0x18_c06c; /* jmp 0xc06c */
        l_0x18_c0a4:
            ii(0x18_c0a4, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x18_c0a7, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x18_c0aa, 3); cmp(memw_a16[ss, bp - 0x4], ax);          /* cmp [bp-0x4], ax */
            ii(0x18_c0ad, 2); if(jnzw(0x18_c0b7, 0x8)) goto l_0x18_c0b7; /* jnz 0xc0b7 */
            ii(0x18_c0af, 3); cmp(memw_a16[ss, bp - 0x2], dx);          /* cmp [bp-0x2], dx */
            ii(0x18_c0b2, 2); if(jnzw(0x18_c0b7, 0x3)) goto l_0x18_c0b7; /* jnz 0xc0b7 */
            ii(0x18_c0b4, 3); jmpw(0x18_c28b, 0x1d4); goto l_0x18_c28b; /* jmp 0xc28b */
        l_0x18_c0b7:
            ii(0x18_c0b7, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x18_c0ba, 3); or(ax, memw_a16[ss, bp - 0x4]);           /* or ax, [bp-0x4] */
            ii(0x18_c0bd, 2); if(jzw(0x18_c0dd, 0x1e)) goto l_0x18_c0dd; /* jz 0xc0dd */
            ii(0x18_c0bf, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x18_c0c2, 3); mov(dx, memw_a16[ss, bp + 0xa]);          /* mov dx, [bp+0xa] */
            ii(0x18_c0c5, 3); add(ax, memw_a16[ss, bp + 0x4]);          /* add ax, [bp+0x4] */
            ii(0x18_c0c8, 3); adc(dx, memw_a16[ss, bp + 0x6]);          /* adc dx, [bp+0x6] */
            ii(0x18_c0cb, 3); cmp(dx, memw_a16[ss, bp - 0x2]);          /* cmp dx, [bp-0x2] */
            ii(0x18_c0ce, 2); if(jbw(0x18_c0dd, 0xd)) goto l_0x18_c0dd; /* jb 0xc0dd */
            ii(0x18_c0d0, 2); if(jbew(0x18_c0d5, 0x3)) goto l_0x18_c0d5; /* jbe 0xc0d5 */
            ii(0x18_c0d2, 3); jmpw(0x18_c28b, 0x1b6); goto l_0x18_c28b; /* jmp 0xc28b */
        l_0x18_c0d5:
            ii(0x18_c0d5, 3); cmp(ax, memw_a16[ss, bp - 0x4]);          /* cmp ax, [bp-0x4] */
            ii(0x18_c0d8, 2); if(jbew(0x18_c0dd, 0x3)) goto l_0x18_c0dd; /* jbe 0xc0dd */
            ii(0x18_c0da, 3); jmpw(0x18_c28b, 0x1ae); goto l_0x18_c28b; /* jmp 0xc28b */
        l_0x18_c0dd:
            ii(0x18_c0dd, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x18_c0df, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x18_c0e2, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x18_c0e5, 3); callw(0x18_db51, 0x1a69);                 /* call 0xdb51 */
            ii(0x18_c0e8, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_c0eb, 3); add(ax, memw_a16[ss, bp - 0x8]);          /* add ax, [bp-0x8] */
            ii(0x18_c0ee, 3); adc(dx, memw_a16[ss, bp - 0x6]);          /* adc dx, [bp-0x6] */
            ii(0x18_c0f1, 3); cmp(dx, memw_a16[ss, bp + 0x6]);          /* cmp dx, [bp+0x6] */
            ii(0x18_c0f4, 2); if(jbw(0x18_c100, 0xa)) goto l_0x18_c100; /* jb 0xc100 */
            ii(0x18_c0f6, 2); if(jaw(0x18_c0fd, 0x5)) goto l_0x18_c0fd; /* ja 0xc0fd */
            ii(0x18_c0f8, 3); cmp(ax, memw_a16[ss, bp + 0x4]);          /* cmp ax, [bp+0x4] */
            ii(0x18_c0fb, 2); if(jbew(0x18_c100, 0x3)) goto l_0x18_c100; /* jbe 0xc100 */
        l_0x18_c0fd:
            ii(0x18_c0fd, 3); jmpw(0x18_c28b, 0x18b); goto l_0x18_c28b; /* jmp 0xc28b */
        l_0x18_c100:
            ii(0x18_c100, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x18_c103, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x18_c106, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_c108, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x18_c10b, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x18_c10e, 3); callw(0x18_db67, 0x1a56);                 /* call 0xdb67 */
            ii(0x18_c111, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x18_c114, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x18_c117, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x18_c11a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_c11c, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x18_c11f, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x18_c122, 3); callw(0x18_db67, 0x1a42);                 /* call 0xdb67 */
            ii(0x18_c125, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x18_c128, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x18_c12b, 3); mov(dx, memw_a16[ss, bp + 0xa]);          /* mov dx, [bp+0xa] */
            ii(0x18_c12e, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x18_c131, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x18_c134, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x18_c136, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x18_c139, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x18_c13c, 3); callw(0x18_db51, 0x1a12);                 /* call 0xdb51 */
            ii(0x18_c13f, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_c142, 3); add(ax, memw_a16[ss, bp - 0x8]);          /* add ax, [bp-0x8] */
            ii(0x18_c145, 3); adc(dx, memw_a16[ss, bp - 0x6]);          /* adc dx, [bp-0x6] */
            ii(0x18_c148, 3); cmp(ax, memw_a16[ss, bp + 0x4]);          /* cmp ax, [bp+0x4] */
            ii(0x18_c14b, 2); if(jnzw(0x18_c19e, 0x51)) goto l_0x18_c19e; /* jnz 0xc19e */
            ii(0x18_c14d, 3); cmp(dx, memw_a16[ss, bp + 0x6]);          /* cmp dx, [bp+0x6] */
            ii(0x18_c150, 2); if(jnzw(0x18_c19e, 0x4c)) goto l_0x18_c19e; /* jnz 0xc19e */
            ii(0x18_c152, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x18_c154, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x18_c157, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x18_c15a, 3); callw(0x18_db51, 0x19f4);                 /* call 0xdb51 */
            ii(0x18_c15d, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_c160, 3); add(ax, memw_a16[ss, bp - 0xc]);          /* add ax, [bp-0xc] */
            ii(0x18_c163, 3); adc(dx, memw_a16[ss, bp - 0xa]);          /* adc dx, [bp-0xa] */
            ii(0x18_c166, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x18_c169, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x18_c16c, 1); pushw(dx);                                /* push dx */
            ii(0x18_c16d, 1); pushw(ax);                                /* push ax */
            ii(0x18_c16e, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x18_c170, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x18_c173, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x18_c176, 3); callw(0x18_db67, 0x19ee);                 /* call 0xdb67 */
            ii(0x18_c179, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x18_c17c, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x18_c17f, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x18_c182, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_c184, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x18_c187, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x18_c18a, 3); callw(0x18_db67, 0x19da);                 /* call 0xdb67 */
            ii(0x18_c18d, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x18_c190, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x18_c193, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x18_c196, 3); mov(memw_a16[ss, bp + 0x4], ax);          /* mov [bp+0x4], ax */
            ii(0x18_c199, 3); mov(memw_a16[ss, bp + 0x6], dx);          /* mov [bp+0x6], dx */
            ii(0x18_c19c, 2); jmpw(0x18_c1b2, 0x14); goto l_0x18_c1b2;  /* jmp 0xc1b2 */
        l_0x18_c19e:
            ii(0x18_c19e, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x18_c1a1, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x18_c1a4, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x18_c1a6, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x18_c1a9, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x18_c1ac, 3); callw(0x18_db67, 0x19b8);                 /* call 0xdb67 */
            ii(0x18_c1af, 3); add(sp, 0xa);                             /* add sp, 0xa */
        l_0x18_c1b2:
            ii(0x18_c1b2, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x18_c1b4, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x18_c1b7, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x18_c1ba, 3); callw(0x18_db51, 0x1994);                 /* call 0xdb51 */
            ii(0x18_c1bd, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_c1c0, 3); add(ax, memw_a16[ss, bp + 0x4]);          /* add ax, [bp+0x4] */
            ii(0x18_c1c3, 3); adc(dx, memw_a16[ss, bp + 0x6]);          /* adc dx, [bp+0x6] */
            ii(0x18_c1c6, 3); cmp(ax, memw_a16[ss, bp - 0x4]);          /* cmp ax, [bp-0x4] */
            ii(0x18_c1c9, 2); if(jnzw(0x18_c224, 0x59)) goto l_0x18_c224; /* jnz 0xc224 */
            ii(0x18_c1cb, 3); cmp(dx, memw_a16[ss, bp - 0x2]);          /* cmp dx, [bp-0x2] */
            ii(0x18_c1ce, 2); if(jnzw(0x18_c224, 0x54)) goto l_0x18_c224; /* jnz 0xc224 */
            ii(0x18_c1d0, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x18_c1d2, 1); pushw(dx);                                /* push dx */
            ii(0x18_c1d3, 1); pushw(ax);                                /* push ax */
            ii(0x18_c1d4, 3); callw(0x18_db51, 0x197a);                 /* call 0xdb51 */
            ii(0x18_c1d7, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_c1da, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x18_c1dc, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x18_c1df, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x18_c1e2, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x18_c1e4, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x18_c1e6, 3); callw(0x18_db51, 0x1968);                 /* call 0xdb51 */
            ii(0x18_c1e9, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_c1ec, 2); add(si, ax);                              /* add si, ax */
            ii(0x18_c1ee, 2); adc(di, dx);                              /* adc di, dx */
            ii(0x18_c1f0, 3); mov(memw_a16[ss, bp - 0xc], si);          /* mov [bp-0xc], si */
            ii(0x18_c1f3, 3); mov(memw_a16[ss, bp - 0xa], di);          /* mov [bp-0xa], di */
            ii(0x18_c1f6, 1); pushw(di);                                /* push di */
            ii(0x18_c1f7, 1); pushw(si);                                /* push si */
            ii(0x18_c1f8, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x18_c1fa, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x18_c1fd, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x18_c200, 3); callw(0x18_db67, 0x1964);                 /* call 0xdb67 */
            ii(0x18_c203, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x18_c206, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_c208, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x18_c20b, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x18_c20e, 3); callw(0x18_db51, 0x1940);                 /* call 0xdb51 */
            ii(0x18_c211, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_c214, 1); pushw(dx);                                /* push dx */
            ii(0x18_c215, 1); pushw(ax);                                /* push ax */
            ii(0x18_c216, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_c218, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x18_c21b, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x18_c21e, 3); callw(0x18_db67, 0x1946);                 /* call 0xdb67 */
            ii(0x18_c221, 3); add(sp, 0xa);                             /* add sp, 0xa */
        l_0x18_c224:
            ii(0x18_c224, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x18_c227, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x18_c22a, 3); callw(0x18_bda2, -0x48b);                 /* call 0xbda2 */
            ii(0x18_c22d, 1); popw(bx);                                 /* pop bx */
            ii(0x18_c22e, 1); popw(bx);                                 /* pop bx */
            ii(0x18_c22f, 1); sti();                                    /* sti */
            ii(0x18_c230, 5); cmp(memb_a16[ds, 0x2e], 0xb);             /* cmp byte [0x2e], 0xb */
            ii(0x18_c235, 2); if(jnzw(0x18_c28b, 0x54)) goto l_0x18_c28b; /* jnz 0xc28b */
            ii(0x18_c237, 4); mov(ah, memb_a16[ds, 0x15]);              /* mov ah, [0x15] */
            ii(0x18_c23b, 3); and(ax, 0x4000);                          /* and ax, 0x4000 */
            ii(0x18_c23e, 3); cmp(ax, 0x1);                             /* cmp ax, 0x1 */
            ii(0x18_c241, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x18_c243, 1); inc(ax);                                  /* inc ax */
            ii(0x18_c244, 4); mov(cl, memb_a16[ds, 0x47]);              /* mov cl, [0x47] */
            ii(0x18_c248, 3); and(cl, 0x80);                            /* and cl, 0x80 */
            ii(0x18_c24b, 3); cmp(cl, 0x1);                             /* cmp cl, 0x1 */
            ii(0x18_c24e, 2); sbb(cx, cx);                              /* sbb cx, cx */
            ii(0x18_c250, 1); inc(cx);                                  /* inc cx */
            ii(0x18_c251, 2); xor(ax, cx);                              /* xor ax, cx */
            ii(0x18_c253, 2); if(jzw(0x18_c28b, 0x36)) goto l_0x18_c28b; /* jz 0xc28b */
            ii(0x18_c255, 5); cmp(memb_a16[ds, 0x9f8], 0x1);            /* cmp byte [0x9f8], 0x1 */
            ii(0x18_c25a, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x18_c25c, 3); and(ah, 0x7);                             /* and ah, 0x7 */
            ii(0x18_c25f, 3); add(ah, -0x10 /* 0xf0 */);                /* add ah, 0xf0 */
            ii(0x18_c262, 1); pushw(ax);                                /* push ax */
            ii(0x18_c263, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x18_c266, 3); mov(dx, memw_a16[ss, bp - 0xa]);          /* mov dx, [bp-0xa] */
            ii(0x18_c269, 3); add(ax, memw_a16[ss, bp + 0x4]);          /* add ax, [bp+0x4] */
            ii(0x18_c26c, 3); adc(dx, memw_a16[ss, bp + 0x6]);          /* adc dx, [bp+0x6] */
            ii(0x18_c26f, 3); sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x18_c272, 3); sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x18_c275, 1); pushw(dx);                                /* push dx */
            ii(0x18_c276, 1); pushw(ax);                                /* push ax */
            ii(0x18_c277, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x18_c27a, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x18_c27d, 3); add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0x18_c280, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x18_c283, 1); pushw(dx);                                /* push dx */
            ii(0x18_c284, 1); pushw(ax);                                /* push ax */
            ii(0x18_c285, 3); callw(0x18_f394, 0x310c);                 /* call 0xf394 */
            ii(0x18_c288, 3); add(sp, 0xa);                             /* add sp, 0xa */
        l_0x18_c28b:
            ii(0x18_c28b, 5); test(memb_a16[ds, 0x47], 0x80);           /* test byte [0x47], 0x80 */
            ii(0x18_c290, 2); if(jzw(0x18_c298, 0x6)) goto l_0x18_c298; /* jz 0xc298 */
            ii(0x18_c292, 3); pushw(0x111b);                            /* push 0x111b */
            ii(0x18_c295, 3); callw(0x18_c004, -0x294);                 /* call 0xc004 */
        l_0x18_c298:
            ii(0x18_c298, 1); popw(si);                                 /* pop si */
            ii(0x18_c299, 1); popw(di);                                 /* pop di */
            ii(0x18_c29a, 1); leavew();                                 /* leave */
            ii(0x18_c29b, 1); retw();                                   /* ret */
        }
    }
}
