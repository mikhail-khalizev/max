using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2c73f51e-3fd8-4c2f-b7fb-bd721371907f")]
        public void Method_0015_3234()
        {
            ii(0x15_3234, 3); mov(cx, memw_a16[ss, bp + 0xc]);          /* mov cx, [bp+0xc] */
            ii(0x15_3237, 2); or(cx, cx);                               /* or cx, cx */
            ii(0x15_3239, 2); if(jnzw(0x15_3240, 0x5)) goto l_0x15_3240; /* jnz 0x3240 */
            ii(0x15_323b, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x15_323d, 3); if(jmpw_func(0x15_2cd9, -0x567)) return;  /* jmp 0x2cd9 */
        l_0x15_3240:
            ii(0x15_3240, 1); pushw(ds);                                /* push ds */
            ii(0x15_3241, 3); lds(dx, ss, bp + 0x8);                    /* lds dx, [bp+0x8] */
            ii(0x15_3244, 2); mov(ah, 0x40);                            /* mov ah, 0x40 */
            ii(0x15_3246, 2); @int(0x21);                               /* int 0x21 */
            ii(0x15_3248, 1); pushw(ds);                                /* push ds */
            ii(0x15_3249, 1); popw(es);                                 /* pop es */
            ii(0x15_324a, 1); popw(ds);                                 /* pop ds */
            ii(0x15_324b, 2); if(jaew(0x15_3251, 0x4)) goto l_0x15_3251; /* jae 0x3251 */
            ii(0x15_324d, 2); mov(ah, 0x9);                             /* mov ah, 0x9 */
            ii(0x15_324f, 2); if(jmpw_func(0x15_3231, -0x20)) return;   /* jmp 0x3231 */
        l_0x15_3251:
            ii(0x15_3251, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_3253, 2); if(jnzw_func(0x15_3231, -0x24)) return;   /* jnz 0x3231 */
            ii(0x15_3255, 5); test(memb_a16[ds, bx + 0x3c21], 0x40);    /* test byte [bx+0x3c21], 0x40 */
            ii(0x15_325a, 2); if(jzw(0x15_3267, 0xb)) goto l_0x15_3267; /* jz 0x3267 */
            ii(0x15_325c, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x15_325e, 4); cmp(memb_a16[es, bx], 0x1a);              /* cmp byte [es:bx], 0x1a */
            ii(0x15_3262, 2); if(jnzw(0x15_3267, 0x3)) goto l_0x15_3267; /* jnz 0x3267 */
            ii(0x15_3264, 1); clc();                                    /* clc */
            ii(0x15_3265, 2); if(jmpw_func(0x15_3231, -0x36)) return;   /* jmp 0x3231 */
        l_0x15_3267:
            ii(0x15_3267, 1); stc();                                    /* stc */
            ii(0x15_3268, 3); mov(ax, 0x1c00);                          /* mov ax, 0x1c00 */
            ii(0x15_326b, 2); if(jmpw_func(0x15_3231, -0x3c)) return;   /* jmp 0x3231 */
        }
    }
}
