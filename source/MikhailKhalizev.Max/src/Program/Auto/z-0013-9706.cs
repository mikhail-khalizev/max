using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("34a110b7-28b6-4538-8a17-79db71991ea5")]
        public void Method_0013_9706()
        {
            ii(0x13_9706, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x13_970a, 1); pushw(ds);                                /* push ds */
            ii(0x13_970b, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_970e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_9710, 5); mov(memw_a16[ss, bp - 0x2], 0x1);         /* mov word [bp-0x2], 0x1 */
            ii(0x13_9715, 1); cld();                                    /* cld */
            ii(0x13_9716, 3); mov(al, memb_a16[ss, bp + 0xa]);          /* mov al, [bp+0xa] */
            ii(0x13_9719, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x13_971b, 3); jmpw(0x13_9808, 0xea); goto l_0x13_9808;  /* jmp 0x9808 */
        l_0x13_971e:
            ii(0x13_971e, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_9721, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_9724, 1); pushw(cs);                                /* push cs */
            ii(0x13_9725, 3); callw(0x13_998a, 0x262);                  /* call 0x998a */
            ii(0x13_9728, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_972b, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x13_9730, 3); jmpw(0x13_982c, 0xf9); goto l_0x13_982c;  /* jmp 0x982c */
        //  ii(0x13_9733, 1); Недостижимый код.
l_0x13_9734:
            ii(0x13_9734, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_9737, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_973a, 1); pushw(cs);                                /* push cs */
            ii(0x13_973b, 3); callw(0x13_9a46, 0x308);                  /* call 0x9a46 */
            ii(0x13_973e, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_9741, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x13_9746, 3); jmpw(0x13_982c, 0xe3); goto l_0x13_982c;  /* jmp 0x982c */
        //  ii(0x13_9749, 1); Недостижимый код.
l_0x13_974a:
            ii(0x13_974a, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_974d, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_9750, 1); pushw(cs);                                /* push cs */
            ii(0x13_9751, 3); callw(0x13_9bac, 0x458);                  /* call 0x9bac */
            ii(0x13_9754, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_9757, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x13_975c, 3); jmpw(0x13_982c, 0xcd); goto l_0x13_982c;  /* jmp 0x982c */
        //  ii(0x13_975f, 1); Недостижимый код.
l_0x13_9760:
            ii(0x13_9760, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_9763, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_9766, 1); pushw(cs);                                /* push cs */
            ii(0x13_9767, 3); callw(0x13_9c18, 0x4ae);                  /* call 0x9c18 */
            ii(0x13_976a, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_976d, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x13_9772, 3); jmpw(0x13_982c, 0xb7); goto l_0x13_982c;  /* jmp 0x982c */
        //  ii(0x13_9775, 1); Недостижимый код.
l_0x13_9776:
            ii(0x13_9776, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_9779, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_977c, 1); pushw(cs);                                /* push cs */
            ii(0x13_977d, 3); callw(0x13_9ce0, 0x560);                  /* call 0x9ce0 */
            ii(0x13_9780, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_9783, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x13_9788, 3); jmpw(0x13_982c, 0xa1); goto l_0x13_982c;  /* jmp 0x982c */
        //  ii(0x13_978b, 1); Недостижимый код.
l_0x13_978c:
            ii(0x13_978c, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_978f, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_9792, 1); pushw(cs);                                /* push cs */
            ii(0x13_9793, 3); callw(0x13_a0da, 0x944);                  /* call 0xa0da */
            ii(0x13_9796, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_9799, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x13_979e, 3); jmpw(0x13_982c, 0x8b); goto l_0x13_982c;  /* jmp 0x982c */
        //  ii(0x13_97a1, 1); Недостижимый код.
l_0x13_97a2:
            ii(0x13_97a2, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_97a5, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_97a8, 1); pushw(cs);                                /* push cs */
            ii(0x13_97a9, 3); callw(0x13_a0fa, 0x94e);                  /* call 0xa0fa */
            ii(0x13_97ac, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_97af, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x13_97b4, 2); jmpw(0x13_982c, 0x76); goto l_0x13_982c;  /* jmp 0x982c */
        l_0x13_97b6:
            ii(0x13_97b6, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_97b9, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_97bc, 1); pushw(cs);                                /* push cs */
            ii(0x13_97bd, 3); callw(0x13_a286, 0xac6);                  /* call 0xa286 */
            ii(0x13_97c0, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_97c3, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x13_97c8, 2); jmpw(0x13_982c, 0x62); goto l_0x13_982c;  /* jmp 0x982c */
        l_0x13_97ca:
            ii(0x13_97ca, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_97cd, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_97d0, 1); pushw(cs);                                /* push cs */
            ii(0x13_97d1, 3); callw(0x13_a688, 0xeb4);                  /* call 0xa688 */
            ii(0x13_97d4, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_97d7, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x13_97dc, 2); jmpw(0x13_982c, 0x4e); goto l_0x13_982c;  /* jmp 0x982c */
        l_0x13_97de:
            ii(0x13_97de, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_97e1, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_97e4, 1); pushw(cs);                                /* push cs */
            ii(0x13_97e5, 3); callw(0x13_a8ec, 0x1104);                 /* call 0xa8ec */
            ii(0x13_97e8, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_97eb, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x13_97f0, 2); jmpw(0x13_982c, 0x3a); goto l_0x13_982c;  /* jmp 0x982c */
        l_0x13_97f2:
            ii(0x13_97f2, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_97f5, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_97f8, 1); pushw(cs);                                /* push cs */
            ii(0x13_97f9, 3); callw(0x13_ab16, 0x131a);                 /* call 0xab16 */
            ii(0x13_97fc, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_97ff, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x13_9804, 2); jmpw(0x13_982c, 0x26); goto l_0x13_982c;  /* jmp 0x982c */
        //  ii(0x13_9806, 2); Недостижимый код.
l_0x13_9808:
            ii(0x13_9808, 3); cmp(ax, 0xa);                             /* cmp ax, 0xa */
            ii(0x13_980b, 2); if(jaw(0x13_982c, 0x1f)) goto l_0x13_982c; /* ja 0x982c */
            ii(0x13_980d, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_980f, 1); xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x13_9810, 5); 
            switch (jmpw_abs_switch(memw_a16[cs, bx + 0x4ff6]))
            {
                case 0x13_971e:
                    goto l_0x13_971e;
                case 0x13_9734:
                    goto l_0x13_9734;
                case 0x13_974a:
                    goto l_0x13_974a;
                case 0x13_9760:
                    goto l_0x13_9760;
                case 0x13_9776:
                    goto l_0x13_9776;
                case 0x13_978c:
                    goto l_0x13_978c;
                case 0x13_97a2:
                    goto l_0x13_97a2;
                case 0x13_97b6:
                    goto l_0x13_97b6;
                case 0x13_97ca:
                    goto l_0x13_97ca;
                case 0x13_97de:
                    goto l_0x13_97de;
                case 0x13_97f2:
                    goto l_0x13_97f2;
                default:
                    throw new NotImplementedException();
            } /* jmp word [cs:bx+0x4ff6] */
        //    ii(0x13_9815, 1); /* Выравнивание. */
        //    ii(0x13_9816, 22); /* Служебная область с абсолютными адресами переходов. {0x13_971e, 0x13_9734, 0x13_974a, 0x13_9760, 0x13_9776, 0x13_978c, 0x13_97a2, 0x13_97b6, 0x13_97ca, 0x13_97de, 0x13_97f2}. */
        l_0x13_982c:
            ii(0x13_982c, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x13_982f, 1); popw(ds);                                 /* pop ds */
            ii(0x13_9830, 1); leavew();                                 /* leave */
            ii(0x13_9831, 1); retfw(); return;                          /* retf */
        }
    }
}
