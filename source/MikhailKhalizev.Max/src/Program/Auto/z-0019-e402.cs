using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_e402-367988c4")]
        public void Method_0019_e402()
        {
            ii(0x19_e402, 4);  enter(6, 0);                            /* enter 0x6, 0x0 */
            ii(0x19_e406, 1);  push(di);                               /* push di */
            ii(0x19_e407, 1);  push(si);                               /* push si */
            ii(0x19_e408, 5);  mov(memw[ss, bp - 2], 0);               /* mov word [bp-0x2], 0x0 */
            ii(0x19_e40d, 3);  jmp(0x19_e413, 3); goto l_0x19_e413;    /* jmp 0xe413 */
        l_0x19_e410:
            ii(0x19_e410, 3);  inc(memw[ss, bp - 2]);                  /* inc word [bp-0x2] */
        l_0x19_e413:
            ii(0x19_e413, 4);  cmp(memw[ss, bp - 2], 0xb);             /* cmp word [bp-0x2], 0xb */
            ii(0x19_e417, 2);  if(jl(0x19_e41c, 3)) goto l_0x19_e41c;  /* jl 0xe41c */
            ii(0x19_e419, 3);  jmp(0x19_e490, 0x74); goto l_0x19_e490; /* jmp 0xe490 */
        l_0x19_e41c:
            ii(0x19_e41c, 1);  push(ds);                               /* push ds */
            ii(0x19_e41d, 3);  push(0x48b6);                           /* push 0x48b6 */
            ii(0x19_e420, 3);  mov(bx, memw[ss, bp - 2]);              /* mov bx, [bp-0x2] */
            ii(0x19_e423, 3);  shl(bx, 2);                             /* shl bx, 0x2 */
            ii(0x19_e426, 4);  push(memw[ds, bx + 0x2c8e]);            /* push word [bx+0x2c8e] */
            ii(0x19_e42a, 4);  push(memw[ds, bx + 0x2c8c]);            /* push word [bx+0x2c8c] */
            ii(0x19_e42e, 3);  call(0x19_ffd5, 0x1ba4);                /* call 0xffd5 */
            ii(0x19_e431, 3);  mov(memw[ss, bp - 6], ax);              /* mov [bp-0x6], ax */
            ii(0x19_e434, 3);  mov(memw[ss, bp - 4], dx);              /* mov [bp-0x4], dx */
            ii(0x19_e437, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_e439, 2);  if(jnz(0x19_e43e, 3)) goto l_0x19_e43e; /* jnz 0xe43e */
            ii(0x19_e43b, 3);  jmp(0x19_e48d, 0x4f); goto l_0x19_e48d; /* jmp 0xe48d */
        l_0x19_e43e:
            ii(0x19_e43e, 3);  mov(ax, 0x48b6);                        /* mov ax, 0x48b6 */
            ii(0x19_e441, 2);  mov(cx, ds);                            /* mov cx, ds */
            ii(0x19_e443, 3);  cmp(ax, memw[ss, bp - 6]);              /* cmp ax, [bp-0x6] */
            ii(0x19_e446, 2);  if(jz(0x19_e44b, 3)) goto l_0x19_e44b;  /* jz 0xe44b */
            ii(0x19_e448, 3);  jmp(0x19_e459, 0xe); goto l_0x19_e459;  /* jmp 0xe459 */
        l_0x19_e44b:
            ii(0x19_e44b, 3);  cmp(cx, memw[ss, bp - 4]);              /* cmp cx, [bp-0x4] */
            ii(0x19_e44e, 2);  if(jz(0x19_e453, 3)) goto l_0x19_e453;  /* jz 0xe453 */
            ii(0x19_e450, 3);  jmp(0x19_e459, 6); goto l_0x19_e459;    /* jmp 0xe459 */
        l_0x19_e453:
            ii(0x19_e453, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x19_e456, 3);  jmp(0x19_e496, 0x3d); goto l_0x19_e496; /* jmp 0xe496 */
        l_0x19_e459:
            ii(0x19_e459, 3);  dec(memw[ss, bp - 6]);                  /* dec word [bp-0x6] */
            ii(0x19_e45c, 3);  les(bx, memw[ss, bp - 6]);              /* les bx, [bp-0x6] */
            ii(0x19_e45f, 3);  mov(al, memb[es, bx]);                  /* mov al, [es:bx] */
            ii(0x19_e462, 1);  cbw();                                  /* cbw */
            ii(0x19_e463, 3);  jmp(0x19_e472, 0xc); goto l_0x19_e472;  /* jmp 0xe472 */
        l_0x19_e466:
            ii(0x19_e466, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x19_e469, 3);  jmp(0x19_e496, 0x2a); goto l_0x19_e496; /* jmp 0xe496 */
        l_0x19_e46c:
            ii(0x19_e46c, 3);  jmp(0x19_e48d, 0x1e); goto l_0x19_e48d; /* jmp 0xe48d */
        //  ii(0x19_e46f, 3);  Недостижимый код.
        l_0x19_e472:
            ii(0x19_e472, 3);  sub(ax, 0x2f);                          /* sub ax, 0x2f */
            ii(0x19_e475, 2);  if(jnz(0x19_e47a, 3)) goto l_0x19_e47a; /* jnz 0xe47a */
            ii(0x19_e477, 3);  jmp(0x19_e466, -0x14); goto l_0x19_e466;/* jmp 0xe466 */
        l_0x19_e47a:
            ii(0x19_e47a, 3);  sub(ax, 0xb);                           /* sub ax, 0xb */
            ii(0x19_e47d, 2);  if(jnz(0x19_e482, 3)) goto l_0x19_e482; /* jnz 0xe482 */
            ii(0x19_e47f, 3);  jmp(0x19_e466, -0x1c); goto l_0x19_e466;/* jmp 0xe466 */
        l_0x19_e482:
            ii(0x19_e482, 3);  sub(ax, 0x22);                          /* sub ax, 0x22 */
            ii(0x19_e485, 2);  if(jnz(0x19_e48a, 3)) goto l_0x19_e48a; /* jnz 0xe48a */
            ii(0x19_e487, 3);  jmp(0x19_e466, -0x24); goto l_0x19_e466;/* jmp 0xe466 */
        l_0x19_e48a:
            ii(0x19_e48a, 3);  jmp(0x19_e46c, -0x21); goto l_0x19_e46c;/* jmp 0xe46c */
        l_0x19_e48d:
            ii(0x19_e48d, 3);  jmp(0x19_e410, -0x80); goto l_0x19_e410;/* jmp 0xe410 */
        l_0x19_e490:
            ii(0x19_e490, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x19_e493, 3);  jmp(0x19_e496, 0); goto l_0x19_e496;    /* jmp 0xe496 */
        l_0x19_e496:
            ii(0x19_e496, 1);  pop(si);                                /* pop si */
            ii(0x19_e497, 1);  pop(di);                                /* pop di */
            ii(0x19_e498, 1);  leave();                                /* leave */
            ii(0x19_e499, 1);  retf();                                 /* retf */
        }
    }
}
