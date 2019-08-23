using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_93c8-49e2de3d")]
        public void Method_0017_93c8()
        {
            ii(0x17_93c8, 1); cli();                                    /* cli */
            ii(0x17_93c9, 1); cld();                                    /* cld */
            ii(0x17_93ca, 1); pusha();                                  /* pusha */
            ii(0x17_93cb, 1); push(ds);                                 /* push ds */
            ii(0x17_93cc, 1); push(es);                                 /* push es */
            ii(0x17_93cd, 1); push(bp);                                 /* push bp */
            ii(0x17_93ce, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_93d0, 3); push(0x3e68);                             /* push 0x3e68 */
            ii(0x17_93d3, 1); pop(ds);                                  /* pop ds */
            ii(0x17_93d4, 1); push(ds);                                 /* push ds */
            ii(0x17_93d5, 1); pop(es);                                  /* pop es */
            ii(0x17_93d6, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x17_93d9, 3); str(ax);                                  /* str ax */
            ii(0x17_93dc, 4); mov(memw[es, di + 0x71], ax);             /* mov [es:di+0x71], ax */
            ii(0x17_93e0, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_93e2, 3); mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0x17_93e5, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x17_93e7, 5); mov(memb[es, bx + 0x5], 0x93);            /* mov byte [es:bx+0x5], 0x93 */
            ii(0x17_93ec, 2); mov(es, bx);                              /* mov es, bx */
            ii(0x17_93ee, 2); xor(di, di);                              /* xor di, di */
            ii(0x17_93f0, 3); mov(bx, memw[es, di]);                    /* mov bx, [es:di] */
            ii(0x17_93f3, 1); push(ds);                                 /* push ds */
            ii(0x17_93f4, 1); pop(es);                                  /* pop es */
            ii(0x17_93f5, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x17_93f8, 4); mov(memw[es, di + 0x73], bx);             /* mov [es:di+0x73], bx */
            ii(0x17_93fc, 3); mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0x17_93ff, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x17_9401, 5); mov(memb[es, bx + 0x5], 0x93);            /* mov byte [es:bx+0x5], 0x93 */
            ii(0x17_9406, 1); push(ds);                                 /* push ds */
            ii(0x17_9407, 1); pop(es);                                  /* pop es */
            ii(0x17_9408, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x17_940b, 4); mov(ds, memw[es, di + 0x73]);             /* mov ds, [es:di+0x73] */
            ii(0x17_940f, 2); xor(si, si);                              /* xor si, si */
            ii(0x17_9411, 3); mov(cx, 0x1a);                            /* mov cx, 0x1a */
            ii(0x17_9414, 3); rep(() => movsd());                       /* rep movsd */
            ii(0x17_9417, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x17_941a, 4); mov(ds, memw[es, di + 0x73]);             /* mov ds, [es:di+0x73] */
            ii(0x17_941e, 4); mov(es, memw[es, di + 0x71]);             /* mov es, [es:di+0x71] */
            ii(0x17_9422, 2); xor(di, di);                              /* xor di, di */
            ii(0x17_9424, 2); xor(si, si);                              /* xor si, si */
            ii(0x17_9426, 8); and(memd[ds, si + 0x24], 0xfffe_fcff);    /* and dword [si+0x24], 0xfffefcff */
            ii(0x17_942e, 3); mov(ebx, cr2);                            /* mov ebx, cr2 */
            ii(0x17_9431, 4); mov(memd[ds, si + 0x34], ebx);            /* mov [si+0x34], ebx */
            ii(0x17_9435, 8); mov(memd[ds, si + 0x38], 0xffc);          /* mov dword [si+0x38], 0xffc */
            ii(0x17_943d, 4); mov(ax, memw[es, di + 0x54]);             /* mov ax, [es:di+0x54] */
            ii(0x17_9441, 3); mov(memw[ds, si + 0x54], ax);             /* mov [si+0x54], ax */
            ii(0x17_9444, 4); mov(ax, memw[es, di + 0x50]);             /* mov ax, [es:di+0x50] */
            ii(0x17_9448, 3); mov(memw[ds, si + 0x50], ax);             /* mov [si+0x50], ax */
            ii(0x17_944b, 3); mov(memw[ds, si + 0x4c], cs);             /* mov [si+0x4c], cs */
            ii(0x17_944e, 8); mov(memd[ds, si + 0x20], 0x4cd9);         /* mov dword [si+0x20], 0x4cd9 */
            ii(0x17_9456, 3); push(0x3e68);                             /* push 0x3e68 */
            ii(0x17_9459, 1); pop(ds);                                  /* pop ds */
            ii(0x17_945a, 1); push(ds);                                 /* push ds */
            ii(0x17_945b, 1); pop(es);                                  /* pop es */
            ii(0x17_945c, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x17_945f, 9); mov(memd[es, di + 0x68], 0);              /* mov dword [es:di+0x68], 0x0 */
            ii(0x17_9468, 4); mov(ax, memw[es, di + 0x50]);             /* mov ax, [es:di+0x50] */
            ii(0x17_946c, 4); cmp(ax, memw[ds, 0x1f56]);                /* cmp ax, [0x1f56] */
            ii(0x17_9470, 4); if(jnz(0x17_9498, 0x24)) goto l_0x17_9498; /* jnz 0x9498 */
            ii(0x17_9474, 4); les(di, memw[ds, 0x1f54]);                /* les di, [0x1f54] */
            ii(0x17_9478, 4); mov(eax, memd[es, di]);                   /* mov eax, [es:di] */
            ii(0x17_947c, 1); push(ds);                                 /* push ds */
            ii(0x17_947d, 1); pop(es);                                  /* pop es */
            ii(0x17_947e, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x17_9481, 5); mov(memd[es, di + 0x68], eax);            /* mov [es:di+0x68], eax */
            ii(0x17_9486, 5); mov(eax, memd[es, di + 0x38]);            /* mov eax, [es:di+0x38] */
            ii(0x17_948b, 6); sub(eax, 0x2c8);                          /* sub eax, 0x2c8 */
            ii(0x17_9491, 4); les(di, memw[ds, 0x1f54]);                /* les di, [0x1f54] */
            ii(0x17_9495, 3); mov(memw[es, di], ax);                    /* mov [es:di], ax */
        l_0x17_9498:
            ii(0x17_9498, 1); push(ds);                                 /* push ds */
            ii(0x17_9499, 1); pop(es);                                  /* pop es */
            ii(0x17_949a, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x17_949d, 6); mov(memw[es, di + 0x5a], 0);              /* mov word [es:di+0x5a], 0x0 */
            ii(0x17_94a3, 2); xor(cl, cl);                              /* xor cl, cl */
            ii(0x17_94a5, 5); cmp(memb[ds, 0xb2], 0x1);                 /* cmp byte [0xb2], 0x1 */
            ii(0x17_94aa, 4); if(jnz(0x17_94ca, 0x1c)) goto l_0x17_94ca; /* jnz 0x94ca */
            ii(0x17_94ae, 4); mov(dx, memw[ds, 0xb4]);                  /* mov dx, [0xb4] */
            ii(0x17_94b2, 2); mov(al, 0xb);                             /* mov al, 0xb */
            ii(0x17_94b4, 1); outb(dx, al);                             /* out dx, al */
            ii(0x17_94b5, 2); jmp(0x17_94b7, 0); goto l_0x17_94b7;      /* jmp 0x94b7 */
        l_0x17_94b7:
            ii(0x17_94b7, 2); jmp(0x17_94b9, 0); goto l_0x17_94b9;      /* jmp 0x94b9 */
        l_0x17_94b9:
            ii(0x17_94b9, 1); inb(al, dx);                              /* in al, dx */
            ii(0x17_94ba, 4); and(al, memb[ds, 0xb6]);                  /* and al, [0xb6] */
            ii(0x17_94be, 4); if(jz(0x17_94ca, 0x8)) goto l_0x17_94ca;  /* jz 0x94ca */
            ii(0x17_94c2, 6); mov(memw[es, di + 0x5a], 0xffff);         /* mov word [es:di+0x5a], 0xffff */
            ii(0x17_94c8, 2); mov(cl, 0x1);                             /* mov cl, 0x1 */
        l_0x17_94ca:
            ii(0x17_94ca, 3); mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0x17_94cd, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_94cf, 4); mov(bx, memw[es, di + 0x73]);             /* mov bx, [es:di+0x73] */
            ii(0x17_94d3, 4); mov(memb[ds, bx + 0x5], 0x8b);            /* mov byte [bx+0x5], 0x8b */
            ii(0x17_94d7, 4); mov(bx, memw[es, di + 0x71]);             /* mov bx, [es:di+0x71] */
            ii(0x17_94db, 4); mov(memb[ds, bx + 0x5], 0x8b);            /* mov byte [bx+0x5], 0x8b */
            ii(0x17_94df, 1); pushfw();                                 /* pushfw */
            ii(0x17_94e0, 1); pop(ax);                                  /* pop ax */
            ii(0x17_94e1, 3); or(ax, 0x4000);                           /* or ax, 0x4000 */
            ii(0x17_94e4, 1); push(ax);                                 /* push ax */
            ii(0x17_94e5, 1); popfw();                                  /* popfw */
            ii(0x17_94e6, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x17_94e8, 1); pop(bp);                                  /* pop bp */
            ii(0x17_94e9, 1); pop(es);                                  /* pop es */
            ii(0x17_94ea, 1); pop(ds);                                  /* pop ds */
            ii(0x17_94eb, 3); cmp(cl, 0x1);                             /* cmp cl, 0x1 */
            ii(0x17_94ee, 4); if(jz(0x17_94f4, 0x2)) goto l_0x17_94f4;  /* jz 0x94f4 */
            ii(0x17_94f2, 1); pop(ax);                                  /* pop ax */
            ii(0x17_94f3, 1); pop(ax);                                  /* pop ax */
        l_0x17_94f4:
            ii(0x17_94f4, 1); popa();                                   /* popa */
            ii(0x17_94f5, 1); iretw();                                  /* iretw */
        }
    }
}
