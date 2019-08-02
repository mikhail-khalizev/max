using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9c68183f-7e6b-429c-bff9-427a9cb05966")]
        public void Method_0013_738e()
        {
            ii(0x13_738e, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x13_7392, 1); pushw(ds);                                /* push ds */
            ii(0x13_7393, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_7396, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_7398, 5); mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
        l_0x13_739d:
            ii(0x13_739d, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_73a0, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x13_73a3, 3); mov(memb_a16[ss, bp - 0x2], al);          /* mov [bp-0x2], al */
            ii(0x13_73a6, 2); cmp(al, 0x2c);                            /* cmp al, 0x2c */
            ii(0x13_73a8, 2); if(jzw(0x13_73d8, 0x2e)) goto l_0x13_73d8; /* jz 0x73d8 */
            ii(0x13_73aa, 2); or(al, al);                               /* or al, al */
            ii(0x13_73ac, 2); if(jzw(0x13_73d8, 0x2a)) goto l_0x13_73d8; /* jz 0x73d8 */
            ii(0x13_73ae, 2); cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x13_73b0, 2); if(jzw(0x13_73d8, 0x26)) goto l_0x13_73d8; /* jz 0x73d8 */
            ii(0x13_73b2, 2); cmp(al, 0x23);                            /* cmp al, 0x23 */
            ii(0x13_73b4, 2); if(jzw(0x13_73d8, 0x22)) goto l_0x13_73d8; /* jz 0x73d8 */
            ii(0x13_73b6, 1); cbw();                                    /* cbw */
            ii(0x13_73b7, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_73b9, 5); test(memb_a16[ds, bx + 0x1ca1], 0x2);     /* test byte [bx+0x1ca1], 0x2 */
            ii(0x13_73be, 2); if(jzw(0x13_73c4, 0x4)) goto l_0x13_73c4; /* jz 0x73c4 */
            ii(0x13_73c0, 2); sub(al, 0x20);                            /* sub al, 0x20 */
            ii(0x13_73c2, 2); jmpw(0x13_73c7, 0x3); goto l_0x13_73c7;   /* jmp 0x73c7 */
        l_0x13_73c4:
            ii(0x13_73c4, 3); mov(al, memb_a16[ss, bp - 0x2]);          /* mov al, [bp-0x2] */
        l_0x13_73c7:
            ii(0x13_73c7, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x13_73ca, 3); inc(memw_a16[ss, bp + 0xa]);              /* inc word [bp+0xa] */
            ii(0x13_73cd, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
            ii(0x13_73d0, 3); inc(memw_a16[ss, bp + 0x6]);              /* inc word [bp+0x6] */
            ii(0x13_73d3, 3); inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
            ii(0x13_73d6, 2); jmpw(0x13_739d, -0x3b); goto l_0x13_739d; /* jmp 0x739d */
        l_0x13_73d8:
            ii(0x13_73d8, 4); cmp(memb_a16[es, bx], 0x2c);              /* cmp byte [es:bx], 0x2c */
            ii(0x13_73dc, 2); if(jzw(0x13_73ea, 0xc)) goto l_0x13_73ea; /* jz 0x73ea */
            ii(0x13_73de, 4); cmp(memb_a16[es, bx], 0x20);              /* cmp byte [es:bx], 0x20 */
            ii(0x13_73e2, 2); if(jzw(0x13_73ea, 0x6)) goto l_0x13_73ea; /* jz 0x73ea */
            ii(0x13_73e4, 4); cmp(memb_a16[es, bx], 0x23);              /* cmp byte [es:bx], 0x23 */
            ii(0x13_73e8, 2); if(jnzw(0x13_73f4, 0xa)) goto l_0x13_73f4; /* jnz 0x73f4 */
        l_0x13_73ea:
            ii(0x13_73ea, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x13_73ed, 4); mov(memb_a16[es, bx], 0);                 /* mov byte [es:bx], 0x0 */
            ii(0x13_73f1, 3); inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
        l_0x13_73f4:
            ii(0x13_73f4, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x13_73f7, 3); inc(memw_a16[ss, bp + 0xa]);              /* inc word [bp+0xa] */
            ii(0x13_73fa, 4); mov(memb_a16[es, bx], 0);                 /* mov byte [es:bx], 0x0 */
            ii(0x13_73fe, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_7401, 1); popw(ds);                                 /* pop ds */
            ii(0x13_7402, 1); leavew();                                 /* leave */
            ii(0x13_7403, 1); retfw(); return;                          /* retf */
        }
    }
}