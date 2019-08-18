using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6671a283-f75a-4e43-99d0-70eaf61f4ffa")]
        public void Method_0018_a922()
        {
            ii(0x18_a922, 3); callw(0x18_ab18, 0x1f3);                  /* call 0xab18 */
            ii(0x18_a925, 2); if(jaew(0x18_a92f, 0x8)) goto l_0x18_a92f; /* jae 0xa92f */
            ii(0x18_a927, 3); callw(0x18_a893, -0x97);                  /* call 0xa893 */
            ii(0x18_a92a, 3); mov(ax, memw_a16[ds, bx + 0x16]);         /* mov ax, [bx+0x16] */
            ii(0x18_a92d, 2); jmpw(0x18_a999, 0x6a); goto l_0x18_a999;  /* jmp 0xa999 */
        l_0x18_a92f:
            ii(0x18_a92f, 3); mov(dx, memw_a16[ss, bp + 0x14]);         /* mov dx, [bp+0x14] */
            ii(0x18_a932, 3); mov(di, memw_a16[ss, bp + 0x12]);         /* mov di, [bp+0x12] */
            ii(0x18_a935, 3); mov(ax, memw_a16[ds, 0xa]);               /* mov ax, [0xa] */
            ii(0x18_a938, 3); mov(memw_a16[ds, bx + 0x12], ax);         /* mov [bx+0x12], ax */
            ii(0x18_a93b, 3); mov(es, memw_a16[ss, bp + 0x4]);          /* mov es, [bp+0x4] */
        l_0x18_a93e:
            ii(0x18_a93e, 1); sti();                                    /* sti */
            ii(0x18_a93f, 2); mov(cx, dx);                              /* mov cx, dx */
            ii(0x18_a941, 4); cmp(cx, memw_a16[ds, 0xe]);               /* cmp cx, [0xe] */
            ii(0x18_a945, 2); if(jbew(0x18_a94b, 0x4)) goto l_0x18_a94b; /* jbe 0xa94b */
            ii(0x18_a947, 4); mov(cx, memw_a16[ds, 0xe]);               /* mov cx, [0xe] */
        l_0x18_a94b:
            ii(0x18_a94b, 3); mov(memw_a16[ds, bx + 0x14], cx);         /* mov [bx+0x14], cx */
            ii(0x18_a94e, 3); mov(ax, memw_a16[ss, bp + 0x16]);         /* mov ax, [bp+0x16] */
            ii(0x18_a951, 3); mov(memw_a16[ds, bx + 0x16], ax);         /* mov [bx+0x16], ax */
            ii(0x18_a954, 1); pushw(cx);                                /* push cx */
            ii(0x18_a955, 1); pushw(es);                                /* push es */
            ii(0x18_a956, 3); callw(0x18_a893, -0xc6);                  /* call 0xa893 */
            ii(0x18_a959, 1); popw(es);                                 /* pop es */
            ii(0x18_a95a, 3); mov(ax, memw_a16[ds, bx + 0x16]);         /* mov ax, [bx+0x16] */
            ii(0x18_a95d, 4); test(memb_a16[ds, bx + 0x26], 0x1);       /* test byte [bx+0x26], 0x1 */
            ii(0x18_a961, 2); if(jnzw(0x18_a999, 0x36)) goto l_0x18_a999; /* jnz 0xa999 */
            ii(0x18_a963, 4); mov(si, memw_a16[ds, 0xa]);               /* mov si, [0xa] */
            ii(0x18_a967, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x18_a969, 1); pushw(di);                                /* push di */
            ii(0x18_a96a, 2); add(di, cx);                              /* add di, cx */
            ii(0x18_a96c, 1); popw(di);                                 /* pop di */
            ii(0x18_a96d, 2); if(jaew(0x18_a982, 0x13)) goto l_0x18_a982; /* jae 0xa982 */
            ii(0x18_a96f, 2); if(jzw(0x18_a982, 0x11)) goto l_0x18_a982; /* jz 0xa982 */
            ii(0x18_a971, 2); mov(cx, di);                              /* mov cx, di */
            ii(0x18_a973, 1); pushw(cx);                                /* push cx */
            ii(0x18_a974, 2); neg(cx);                                  /* neg cx */
            ii(0x18_a976, 2); rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x18_a978, 2); mov(cx, es);                              /* mov cx, es */
            ii(0x18_a97a, 3); add(cx, 0x8);                             /* add cx, 0x8 */
            ii(0x18_a97d, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x18_a97f, 1); popw(cx);                                 /* pop cx */
            ii(0x18_a980, 2); add(cx, ax);                              /* add cx, ax */
        l_0x18_a982:
            ii(0x18_a982, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x18_a984, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x18_a986, 2); rcl(cx, 0x1);                             /* rcl cx, 1 */
            ii(0x18_a988, 2); rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x18_a98a, 1); sti();                                    /* sti */
            ii(0x18_a98b, 1); popw(cx);                                 /* pop cx */
            ii(0x18_a98c, 2); sub(dx, ax);                              /* sub dx, ax */
            ii(0x18_a98e, 2); if(jzw(0x18_a994, 0x4)) goto l_0x18_a994; /* jz 0xa994 */
            ii(0x18_a990, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x18_a992, 2); if(jzw(0x18_a93e, -0x56)) goto l_0x18_a93e; /* jz 0xa93e */
        l_0x18_a994:
            ii(0x18_a994, 3); mov(ax, memw_a16[ss, bp + 0x14]);         /* mov ax, [bp+0x14] */
            ii(0x18_a997, 2); sub(ax, dx);                              /* sub ax, dx */
        l_0x18_a999:
            ii(0x18_a999, 3); mov(memw_a16[ss, bp + 0x16], ax);         /* mov [bp+0x16], ax */
            ii(0x18_a99c, 3); if(jmpw_func(0x18_a82f, -0x170)) return;  /* jmp 0xa82f */
        }
    }
}
