using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2b45c624-91bf-4692-9b1c-e22b2cd5965a")]
        public void Method_0015_e402()
        {
            ii(0x15_e402, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x15_e406, 1); pushw(di);                                /* push di */
            ii(0x15_e407, 1); pushw(si);                                /* push si */
            ii(0x15_e408, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x15_e40d, 3); jmpw(0x15_e413, 0x3); goto l_0x15_e413;   /* jmp 0xe413 */
        l_0x15_e410:
            ii(0x15_e410, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x15_e413:
            ii(0x15_e413, 4); cmp(memw_a16[ss, bp - 0x2], 0xb);         /* cmp word [bp-0x2], 0xb */
            ii(0x15_e417, 2); if(jlw(0x15_e41c, 0x3)) goto l_0x15_e41c; /* jl 0xe41c */
            ii(0x15_e419, 3); jmpw(0x15_e490, 0x74); goto l_0x15_e490;  /* jmp 0xe490 */
        l_0x15_e41c:
            ii(0x15_e41c, 1); pushw(ds);                                /* push ds */
            ii(0x15_e41d, 3); pushw(0x48b6);                            /* push 0x48b6 */
            ii(0x15_e420, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x15_e423, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x15_e426, 4); pushw(memw_a16[ds, bx + 0x2c8e]);         /* push word [bx+0x2c8e] */
            ii(0x15_e42a, 4); pushw(memw_a16[ds, bx + 0x2c8c]);         /* push word [bx+0x2c8c] */
            ii(0x15_e42e, 3); callw(0x15_ffd5, 0x1ba4);                 /* call 0xffd5 */
            ii(0x15_e431, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_e434, 3); mov(memw_a16[ss, bp - 0x4], dx);          /* mov [bp-0x4], dx */
            ii(0x15_e437, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_e439, 2); if(jnzw(0x15_e43e, 0x3)) goto l_0x15_e43e; /* jnz 0xe43e */
            ii(0x15_e43b, 3); jmpw(0x15_e48d, 0x4f); goto l_0x15_e48d;  /* jmp 0xe48d */
        l_0x15_e43e:
            ii(0x15_e43e, 3); mov(ax, 0x48b6);                          /* mov ax, 0x48b6 */
            ii(0x15_e441, 2); mov(cx, ds);                              /* mov cx, ds */
            ii(0x15_e443, 3); cmp(ax, memw_a16[ss, bp - 0x6]);          /* cmp ax, [bp-0x6] */
            ii(0x15_e446, 2); if(jzw(0x15_e44b, 0x3)) goto l_0x15_e44b; /* jz 0xe44b */
            ii(0x15_e448, 3); jmpw(0x15_e459, 0xe); goto l_0x15_e459;   /* jmp 0xe459 */
        l_0x15_e44b:
            ii(0x15_e44b, 3); cmp(cx, memw_a16[ss, bp - 0x4]);          /* cmp cx, [bp-0x4] */
            ii(0x15_e44e, 2); if(jzw(0x15_e453, 0x3)) goto l_0x15_e453; /* jz 0xe453 */
            ii(0x15_e450, 3); jmpw(0x15_e459, 0x6); goto l_0x15_e459;   /* jmp 0xe459 */
        l_0x15_e453:
            ii(0x15_e453, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_e456, 3); jmpw(0x15_e496, 0x3d); goto l_0x15_e496;  /* jmp 0xe496 */
        l_0x15_e459:
            ii(0x15_e459, 3); dec(memw_a16[ss, bp - 0x6]);              /* dec word [bp-0x6] */
            ii(0x15_e45c, 3); les(bx, ss, bp - 0x6);                    /* les bx, [bp-0x6] */
            ii(0x15_e45f, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x15_e462, 1); cbw();                                    /* cbw */
            ii(0x15_e463, 3); jmpw(0x15_e472, 0xc); goto l_0x15_e472;   /* jmp 0xe472 */
        l_0x15_e466:
            ii(0x15_e466, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_e469, 3); jmpw(0x15_e496, 0x2a); goto l_0x15_e496;  /* jmp 0xe496 */
        l_0x15_e46c:
            ii(0x15_e46c, 3); jmpw(0x15_e48d, 0x1e); goto l_0x15_e48d;  /* jmp 0xe48d */
        //  ii(0x15_e46f, 3); Недостижимый код.
l_0x15_e472:
            ii(0x15_e472, 3); sub(ax, 0x2f);                            /* sub ax, 0x2f */
            ii(0x15_e475, 2); if(jnzw(0x15_e47a, 0x3)) goto l_0x15_e47a; /* jnz 0xe47a */
            ii(0x15_e477, 3); jmpw(0x15_e466, -0x14); goto l_0x15_e466; /* jmp 0xe466 */
        l_0x15_e47a:
            ii(0x15_e47a, 3); sub(ax, 0xb);                             /* sub ax, 0xb */
            ii(0x15_e47d, 2); if(jnzw(0x15_e482, 0x3)) goto l_0x15_e482; /* jnz 0xe482 */
            ii(0x15_e47f, 3); jmpw(0x15_e466, -0x1c); goto l_0x15_e466; /* jmp 0xe466 */
        l_0x15_e482:
            ii(0x15_e482, 3); sub(ax, 0x22);                            /* sub ax, 0x22 */
            ii(0x15_e485, 2); if(jnzw(0x15_e48a, 0x3)) goto l_0x15_e48a; /* jnz 0xe48a */
            ii(0x15_e487, 3); jmpw(0x15_e466, -0x24); goto l_0x15_e466; /* jmp 0xe466 */
        l_0x15_e48a:
            ii(0x15_e48a, 3); jmpw(0x15_e46c, -0x21); goto l_0x15_e46c; /* jmp 0xe46c */
        l_0x15_e48d:
            ii(0x15_e48d, 3); jmpw(0x15_e410, -0x80); goto l_0x15_e410; /* jmp 0xe410 */
        l_0x15_e490:
            ii(0x15_e490, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_e493, 3); jmpw(0x15_e496, 0); goto l_0x15_e496;     /* jmp 0xe496 */
        l_0x15_e496:
            ii(0x15_e496, 1); popw(si);                                 /* pop si */
            ii(0x15_e497, 1); popw(di);                                 /* pop di */
            ii(0x15_e498, 1); leavew();                                 /* leave */
            ii(0x15_e499, 1); retfw(); return;                          /* retf */
        }
    }
}
