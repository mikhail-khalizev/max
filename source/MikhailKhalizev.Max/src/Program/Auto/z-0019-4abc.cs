using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_4abc-3efa77a0")]
        public void Method_0019_4abc()
        {
            ii(0x19_4abc, 4); enterw(0x22, 0);                          /* enter 0x22, 0x0 */
            ii(0x19_4ac0, 1); pushw(ds);                                /* push ds */
            ii(0x19_4ac1, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_4ac4, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_4ac6, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_4ac8, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x19_4acb, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x19_4ace, 1); nop();                                    /* nop */
            ii(0x19_4acf, 1); pushw(cs);                                /* push cs */
            ii(0x19_4ad0, 3); callw(0x19_4638, -0x49b);                 /* call 0x4638 */
            ii(0x19_4ad3, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_4ad5, 2); if(jnzw(0x19_4b0c, 0x35)) goto l_0x19_4b0c; /* jnz 0x4b0c */
            ii(0x19_4ad7, 3); mov(al, memb_a16[ss, bp + 0x8]);          /* mov al, [bp+0x8] */
            ii(0x19_4ada, 2); mov(ah, 0xff);                            /* mov ah, 0xff */
            ii(0x19_4adc, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x19_4adf, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_4ae2, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_4ae5, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x19_4ae8, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_4aeb, 5); mov(memw_a16[ss, bp - 0x6], 0xa00);       /* mov word [bp-0x6], 0xa00 */
            ii(0x19_4af0, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_4af2, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_4af4, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x19_4af7, 1); pushw(ss);                                /* push ss */
            ii(0x19_4af8, 1); pushw(ax);                                /* push ax */
            ii(0x19_4af9, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x19_4afc, 1); nop();                                    /* nop */
            ii(0x19_4afd, 1); pushw(cs);                                /* push cs */
            ii(0x19_4afe, 3); callw(0x19_4188, -0x979);                 /* call 0x4188 */
            ii(0x19_4b01, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_4b04, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
        l_0x19_4b07:
            ii(0x19_4b07, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x19_4b0a, 2); jmpw(0x19_4b67, 0x5b); goto l_0x19_4b67;  /* jmp 0x4b67 */
        l_0x19_4b0c:
            ii(0x19_4b0c, 1); nop();                                    /* nop */
            ii(0x19_4b0d, 1); pushw(cs);                                /* push cs */
            ii(0x19_4b0e, 3); callw(0x19_4bd0, 0xbf);                   /* call 0x4bd0 */
            ii(0x19_4b11, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x19_4b14, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_4b16, 2); if(jzw(0x19_4b67, 0x4f)) goto l_0x19_4b67; /* jz 0x4b67 */
            ii(0x19_4b18, 3); lea(ax, bp - 0x22);                       /* lea ax, [bp-0x22] */
            ii(0x19_4b1b, 1); pushw(ss);                                /* push ss */
            ii(0x19_4b1c, 1); pushw(ax);                                /* push ax */
            ii(0x19_4b1d, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x19_4b20, 1); nop();                                    /* nop */
            ii(0x19_4b21, 1); pushw(cs);                                /* push cs */
            ii(0x19_4b22, 3); callw(0x19_4412, -0x713);                 /* call 0x4412 */
            ii(0x19_4b25, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_4b28, 3); mov(al, memb_a16[ss, bp + 0x8]);          /* mov al, [bp+0x8] */
            ii(0x19_4b2b, 3); mov(memb_a16[ss, bp - 0x1e], al);         /* mov [bp-0x1e], al */
            ii(0x19_4b2e, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_4b31, 3); mov(memw_a16[ss, bp - 0x20], ax);         /* mov [bp-0x20], ax */
            ii(0x19_4b34, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x19_4b37, 1); dec(ax);                                  /* dec ax */
            ii(0x19_4b38, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x19_4b3b, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x19_4b3e, 2); sub(al, al);                              /* sub al, al */
            ii(0x19_4b40, 3); or(memw_a16[ss, bp - 0x1c], ax);          /* or [bp-0x1c], ax */
            ii(0x19_4b43, 3); lea(ax, bp - 0x22);                       /* lea ax, [bp-0x22] */
            ii(0x19_4b46, 1); pushw(ss);                                /* push ss */
            ii(0x19_4b47, 1); pushw(ax);                                /* push ax */
            ii(0x19_4b48, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x19_4b4b, 1); nop();                                    /* nop */
            ii(0x19_4b4c, 1); pushw(cs);                                /* push cs */
            ii(0x19_4b4d, 3); callw(0x19_4484, -0x6cc);                 /* call 0x4484 */
            ii(0x19_4b50, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_4b53, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_4b55, 2); if(jzw(0x19_4b5c, 0x5)) goto l_0x19_4b5c; /* jz 0x4b5c */
            ii(0x19_4b57, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x19_4b5a, 2); jmpw(0x19_4b07, -0x55); goto l_0x19_4b07; /* jmp 0x4b07 */
        l_0x19_4b5c:
            ii(0x19_4b5c, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x19_4b5f, 1); nop();                                    /* nop */
            ii(0x19_4b60, 1); pushw(cs);                                /* push cs */
            ii(0x19_4b61, 3); callw(0x19_4c34, 0xd0);                   /* call 0x4c34 */
            ii(0x19_4b64, 3); add(sp, 0x2);                             /* add sp, 0x2 */
        l_0x19_4b67:
            ii(0x19_4b67, 3); mov(ax, memw_a16[ss, bp - 0x1a]);         /* mov ax, [bp-0x1a] */
            ii(0x19_4b6a, 3); mov(dx, memw_a16[ss, bp - 0x18]);         /* mov dx, [bp-0x18] */
            ii(0x19_4b6d, 1); popw(ds);                                 /* pop ds */
            ii(0x19_4b6e, 1); leavew();                                 /* leave */
            ii(0x19_4b6f, 1); retfw(); return;                          /* retf */
        //  ii(0x19_4b70, 96); Недостижимый (и не декодированный) код.
        //    ii(0x19_4bd0, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
        //    ii(0x19_4bd4, 1); pushw(ds);                                /* push ds */
        //    ii(0x19_4bd5, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
        //    ii(0x19_4bd8, 2); mov(ds, ax);                              /* mov ds, ax */
        //    ii(0x19_4bda, 5); cmp(memw_a16[ds, 0x3b72], 0);             /* cmp word [0x3b72], 0x0 */
        //    ii(0x19_4bdf, 2); if(jnzw(0x19_4c0a, 0x29)) goto l_0x19_4c0a; /* jnz 0x4c0a */
        //    ii(0x19_4be1, 5); mov(memw_a16[ss, bp - 0x4], 0x1);         /* mov word [bp-0x4], 0x1 */
        //    ii(0x19_4be6, 2); pushw(0);                                 /* push 0x0 */
        //    ii(0x19_4be8, 2); pushw(0);                                 /* push 0x0 */
        //    ii(0x19_4bea, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
        //    ii(0x19_4bed, 1); pushw(ss);                                /* push ss */
        //    ii(0x19_4bee, 1); pushw(ax);                                /* push ax */
        //    ii(0x19_4bef, 2); pushw(0);                                 /* push 0x0 */
        //    ii(0x19_4bf1, 2); pushw(0);                                 /* push 0x0 */
        //    ii(0x19_4bf3, 1); nop();                                    /* nop */
        //    ii(0x19_4bf4, 1); pushw(cs);                                /* push cs */
        //    ii(0x19_4bf5, 3); callw(0x19_41fd, -0x9fb);                 /* call 0x41fd */
        //    ii(0x19_4bf8, 3); add(sp, 0xc);                             /* add sp, 0xc */
        //    ii(0x19_4bfb, 2); or(ax, ax);                               /* or ax, ax */
        //    ii(0x19_4bfd, 2); if(jnzw(0x19_4c04, 0x5)) goto l_0x19_4c04; /* jnz 0x4c04 */
        //    ii(0x19_4bff, 2); sub(ax, ax);                              /* sub ax, ax */
        //    ii(0x19_4c01, 1); popw(ds);                                 /* pop ds */
        //    ii(0x19_4c02, 1); leavew();                                 /* leave */
        //    ii(0x19_4c03, 1); retfw(); return;                          /* retf */
        l_0x19_4c04:
            ii(0x19_4c04, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_4c07, 1); popw(ds);                                 /* pop ds */
            ii(0x19_4c08, 1); leavew();                                 /* leave */
            ii(0x19_4c09, 1); retfw(); return;                          /* retf */
        l_0x19_4c0a:
            ii(0x19_4c0a, 5); mov(memw_a16[ss, bp - 0x4], 0x2);         /* mov word [bp-0x4], 0x2 */
            ii(0x19_4c0f, 5); mov(memw_a16[ss, bp - 0x8], 0xa000);      /* mov word [bp-0x8], 0xa000 */
            ii(0x19_4c14, 5); mov(memw_a16[ss, bp - 0x6], 0xa00);       /* mov word [bp-0x6], 0xa00 */
            ii(0x19_4c19, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_4c1b, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_4c1d, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x19_4c20, 1); pushw(ss);                                /* push ss */
            ii(0x19_4c21, 1); pushw(ax);                                /* push ax */
            ii(0x19_4c22, 3); pushw(0xff00);                            /* push 0xff00 */
            ii(0x19_4c25, 1); nop();                                    /* nop */
            ii(0x19_4c26, 1); pushw(cs);                                /* push cs */
            ii(0x19_4c27, 3); callw(0x19_4188, -0xaa2);                 /* call 0x4188 */
            ii(0x19_4c2a, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_4c2d, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x19_4c30, 1); popw(ds);                                 /* pop ds */
            ii(0x19_4c31, 1); leavew();                                 /* leave */
            ii(0x19_4c32, 1); retfw(); return;                          /* retf */
        }
    }
}
