using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c067877d-1cf4-4561-a28d-d35e32d49563")]
        public void Method_0000_7c55()
        {
            ii(0x7c55, 1);    pushw(bp);                                /* push bp */
            ii(0x7c56, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x7c58, 3);    sub(sp, 0xa);                             /* sub sp, 0xa */
            ii(0x7c5b, 1);    pushw(si);                                /* push si */
            ii(0x7c5c, 5);    cmp(memw_a16[ds, 0x9b8], 0);              /* cmp word [0x9b8], 0x0 */
            ii(0x7c61, 2);    if(jnzw(0x7c67, 0x4)) goto l_0x7c67;      /* jnz 0x7c67 */
        l_0x7c63:
            ii(0x7c63, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x7c65, 2);    jmpw(0x7cc9, 0x62); goto l_0x7cc9;        /* jmp 0x7cc9 */
        l_0x7c67:
            ii(0x7c67, 3);    mov(ax, memw_a16[ds, 0x9b8]);             /* mov ax, [0x9b8] */
            ii(0x7c6a, 5);    mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x7c6f, 3);    mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
        l_0x7c72:
            ii(0x7c72, 3);    les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x7c75, 4);    cmp(memb_a16[es, bx], 0);                 /* cmp byte [es:bx], 0x0 */
            ii(0x7c79, 2);    if(jzw(0x7c63, -0x18)) goto l_0x7c63;     /* jz 0x7c63 */
            ii(0x7c7b, 3);    mov(si, memw_a16[ss, bp + 0x4]);          /* mov si, [bp+0x4] */
            ii(0x7c7e, 2);    jmpw(0x7c9c, 0x1c); goto l_0x7c9c;        /* jmp 0x7c9c */
        l_0x7c80:
            ii(0x7c80, 2);    mov(al, memb_a16[ds, si]);                /* mov al, [si] */
            ii(0x7c82, 3);    les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x7c85, 3);    cmp(memb_a16[es, bx], al);                /* cmp [es:bx], al */
            ii(0x7c88, 2);    if(jzw(0x7c98, 0xe)) goto l_0x7c98;       /* jz 0x7c98 */
        l_0x7c8a:
            ii(0x7c8a, 3);    mov(bx, memw_a16[ss, bp - 0x4]);          /* mov bx, [bp-0x4] */
            ii(0x7c8d, 3);    inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
            ii(0x7c90, 4);    cmp(memb_a16[es, bx], 0);                 /* cmp byte [es:bx], 0x0 */
            ii(0x7c94, 2);    if(jzw(0x7c72, -0x24)) goto l_0x7c72;     /* jz 0x7c72 */
            ii(0x7c96, 2);    jmpw(0x7c8a, -0xe); goto l_0x7c8a;        /* jmp 0x7c8a */
        l_0x7c98:
            ii(0x7c98, 1);    inc(si);                                  /* inc si */
            ii(0x7c99, 3);    inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
        l_0x7c9c:
            ii(0x7c9c, 3);    cmp(memb_a16[ds, si], 0);                 /* cmp byte [si], 0x0 */
            ii(0x7c9f, 2);    if(jnzw(0x7c80, -0x21)) goto l_0x7c80;    /* jnz 0x7c80 */
            ii(0x7ca1, 5);    mov(memw_a16[ss, bp - 0x6], 0x80);        /* mov word [bp-0x6], 0x80 */
            ii(0x7ca6, 3);    mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
        l_0x7ca9:
            ii(0x7ca9, 3);    dec(memw_a16[ss, bp - 0x6]);              /* dec word [bp-0x6] */
            ii(0x7cac, 4);    cmp(memw_a16[ss, bp - 0x6], 0);           /* cmp word [bp-0x6], 0x0 */
            ii(0x7cb0, 2);    if(jlew(0x7cc3, 0x11)) goto l_0x7cc3;     /* jle 0x7cc3 */
            ii(0x7cb2, 3);    les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x7cb5, 3);    inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
            ii(0x7cb8, 3);    mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x7cbb, 1);    inc(si);                                  /* inc si */
            ii(0x7cbc, 3);    mov(memb_a16[ds, si - 0x1], al);          /* mov [si-0x1], al */
            ii(0x7cbf, 2);    or(al, al);                               /* or al, al */
            ii(0x7cc1, 2);    if(jnzw(0x7ca9, -0x1a)) goto l_0x7ca9;    /* jnz 0x7ca9 */
        l_0x7cc3:
            ii(0x7cc3, 3);    mov(memb_a16[ds, si], 0);                 /* mov byte [si], 0x0 */
            ii(0x7cc6, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
        l_0x7cc9:
            ii(0x7cc9, 1);    popw(si);                                 /* pop si */
            ii(0x7cca, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x7ccc, 1);    popw(bp);                                 /* pop bp */
            ii(0x7ccd, 1);    retw();                                   /* ret */
        }
    }
}
