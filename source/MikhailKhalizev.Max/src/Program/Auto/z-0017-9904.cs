using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_9904-967a8c2b")]
        public void Method_0017_9904()
        {
            ii(0x17_9904, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x17_9908, 1); pushw(ds);                                /* push ds */
            ii(0x17_9909, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_990c, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_990e, 5); mov(memw_a16[ss, bp - 0x2], 0x1);         /* mov word [bp-0x2], 0x1 */
            ii(0x17_9913, 1); cld();                                    /* cld */
            ii(0x17_9914, 3); mov(al, memb_a16[ss, bp + 0xa]);          /* mov al, [bp+0xa] */
            ii(0x17_9917, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_9919, 2); jmpw(0x17_9976, 0x5b); goto l_0x17_9976;  /* jmp 0x9976 */
        //  ii(0x17_991b, 1); Недостижимый код.
        l_0x17_991c:
            ii(0x17_991c, 1); pushw(ds);                                /* push ds */
            ii(0x17_991d, 3); pushw(0x131a);                            /* push 0x131a */
            ii(0x17_9920, 1); nop();                                    /* nop */
            ii(0x17_9921, 1); pushw(cs);                                /* push cs */
            ii(0x17_9922, 3); callw(0x18_104f, 0x772a);                 /* call 0x104f */
            ii(0x17_9925, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_9928, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_992b, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_992e, 1); pushw(cs);                                /* push cs */
            ii(0x17_992f, 3); callw(0x17_b448, 0x1b16);                 /* call 0xb448 */
            ii(0x17_9932, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_9935, 1); pushw(ds);                                /* push ds */
            ii(0x17_9936, 3); pushw(0x1324);                            /* push 0x1324 */
            ii(0x17_9939, 1); nop();                                    /* nop */
            ii(0x17_993a, 1); pushw(cs);                                /* push cs */
            ii(0x17_993b, 3); callw(0x18_104f, 0x7711);                 /* call 0x104f */
            ii(0x17_993e, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_9941, 5); mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x17_9946, 2); jmpw(0x17_9980, 0x38); goto l_0x17_9980;  /* jmp 0x9980 */
        l_0x17_9948:
            ii(0x17_9948, 1); pushw(ds);                                /* push ds */
            ii(0x17_9949, 3); pushw(0x1327);                            /* push 0x1327 */
            ii(0x17_994c, 1); nop();                                    /* nop */
            ii(0x17_994d, 1); pushw(cs);                                /* push cs */
            ii(0x17_994e, 3); callw(0x18_104f, 0x76fe);                 /* call 0x104f */
            ii(0x17_9951, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_9954, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_9957, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_995a, 1); pushw(cs);                                /* push cs */
            ii(0x17_995b, 3); callw(0x17_b934, 0x1fd6);                 /* call 0xb934 */
            ii(0x17_995e, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_9961, 1); pushw(ds);                                /* push ds */
            ii(0x17_9962, 3); pushw(0x132f);                            /* push 0x132f */
            ii(0x17_9965, 1); nop();                                    /* nop */
            ii(0x17_9966, 1); pushw(cs);                                /* push cs */
            ii(0x17_9967, 3); callw(0x18_104f, 0x76e5);                 /* call 0x104f */
            ii(0x17_996a, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_996d, 5); mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x17_9972, 2); jmpw(0x17_9980, 0xc); goto l_0x17_9980;   /* jmp 0x9980 */
        //  ii(0x17_9974, 2); Недостижимый код.
        l_0x17_9976:
            ii(0x17_9976, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_9978, 2); if(jzw(0x17_991c, -0x5e)) goto l_0x17_991c; /* jz 0x991c */
            ii(0x17_997a, 1); dec(ax);                                  /* dec ax */
            ii(0x17_997b, 2); if(jzw(0x17_9948, -0x35)) goto l_0x17_9948; /* jz 0x9948 */
            ii(0x17_997d, 2); jmpw(0x17_9980, 0x1); goto l_0x17_9980;   /* jmp 0x9980 */
        //  ii(0x17_997f, 1); Недостижимый код.
        l_0x17_9980:
            ii(0x17_9980, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_9983, 1); popw(ds);                                 /* pop ds */
            ii(0x17_9984, 1); leavew();                                 /* leave */
            ii(0x17_9985, 1); retfw(); return;                          /* retf */
        }
    }
}
