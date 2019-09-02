using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_af58-70ad69ca")]
        public void Method_0018_af58()
        {
            ii(0x18_af58, 5); test(memb[ds, 0x15], 1);                  /* test byte [0x15], 0x1 */
            ii(0x18_af5d, 2); if(jnz(0x18_af98, 0x39)) goto l_0x18_af98; /* jnz 0xaf98 */
            ii(0x18_af5f, 5); cmp(memb[ds, 0x34], 0x15);                /* cmp byte [0x34], 0x15 */
            ii(0x18_af64, 2); if(jnz(0x18_af98, 0x32)) goto l_0x18_af98; /* jnz 0xaf98 */
            ii(0x18_af66, 5); cmp(memw[ds, 0x10fa], 0);                 /* cmp word [0x10fa], 0x0 */
            ii(0x18_af6b, 2); if(jz(0x18_af9b, 0x2e)) goto l_0x18_af9b; /* jz 0xaf9b */
            ii(0x18_af6d, 3); call(0x18_a8bf, -0x6b1);                  /* call 0xa8bf */
            ii(0x18_af70, 2); push(0x40);                               /* push 0x40 */
            ii(0x18_af72, 1); pop(es);                                  /* pop es */
            ii(0x18_af73, 4); mov(al, memb[es, 0x6c]);                  /* mov al, [es:0x6c] */
            ii(0x18_af77, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x18_af79, 4); xchg(memb[ds, 0x10ff], al);               /* xchg [0x10ff], al */
            ii(0x18_af7d, 2); xor(al, ah);                              /* xor al, ah */
            ii(0x18_af7f, 2); test(al, 0xf0);                           /* test al, 0xf0 */
            ii(0x18_af81, 2); if(jnz(0x18_af9b, 0x18)) goto l_0x18_af9b; /* jnz 0xaf9b */
            ii(0x18_af83, 3); mov(ax, memw[ds, 0x10fa]);                /* mov ax, [0x10fa] */
            ii(0x18_af86, 3); mov(memw[ss, bp + 0x12], ax);             /* mov [bp+0x12], ax */
            ii(0x18_af89, 3); mov(ax, memw[ds, 0x10fc]);                /* mov ax, [0x10fc] */
            ii(0x18_af8c, 3); mov(memw[ss, bp + 0x14], ax);             /* mov [bp+0x14], ax */
            ii(0x18_af8f, 3); mov(al, memb[ds, 0x10fe]);                /* mov al, [0x10fe] */
            ii(0x18_af92, 3); mov(memb[ss, bp + 0x16], al);             /* mov [bp+0x16], al */
            ii(0x18_af95, 3); if(jmp_func(0x18_a838, -0x760)) return;   /* jmp 0xa838 */
        l_0x18_af98:
            ii(0x18_af98, 3); if(jmp_func(0x18_a81c, -0x77f)) return;   /* jmp 0xa81c */
        l_0x18_af9b:
            ii(0x18_af9b, 3); call(0x18_a893, -0x70b);                  /* call 0xa893 */
            ii(0x18_af9e, 3); mov(ax, memw[ds, bx + 0x12]);             /* mov ax, [bx+0x12] */
            ii(0x18_afa1, 3); mov(memw[ds, 0x10fa], ax);                /* mov [0x10fa], ax */
            ii(0x18_afa4, 3); mov(ax, memw[ds, bx + 0x14]);             /* mov ax, [bx+0x14] */
            ii(0x18_afa7, 3); mov(memw[ds, 0x10fc], ax);                /* mov [0x10fc], ax */
            ii(0x18_afaa, 3); mov(al, memb[ds, bx + 0x16]);             /* mov al, [bx+0x16] */
            ii(0x18_afad, 3); mov(memb[ds, 0x10fe], al);                /* mov [0x10fe], al */
            ii(0x18_afb0, 3); if(jmp_func(0x18_a81f, -0x794)) return;   /* jmp 0xa81f */
        }
    }
}
