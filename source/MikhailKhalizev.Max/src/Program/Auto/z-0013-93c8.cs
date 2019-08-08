using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ed0412fa-e499-4437-9d5f-759fc72b5be5")]
        public void Method_0013_93c8()
        {
            ii(0x13_93c8, 1); cli();                                    /* cli */
            ii(0x13_93c9, 1); cld();                                    /* cld */
            ii(0x13_93ca, 1); pusha();                                  /* pusha */
            ii(0x13_93cb, 1); pushw(ds);                                /* push ds */
            ii(0x13_93cc, 1); pushw(es);                                /* push es */
            ii(0x13_93cd, 1); pushw(bp);                                /* push bp */
            ii(0x13_93ce, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_93d0, 3); pushw(0x3e68);                            /* push 0x3e68 */
            ii(0x13_93d3, 1); popw(ds);                                 /* pop ds */
            ii(0x13_93d4, 1); pushw(ds);                                /* push ds */
            ii(0x13_93d5, 1); popw(es);                                 /* pop es */
            ii(0x13_93d6, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x13_93d9, 3); str(ax);                                  /* str ax */
            ii(0x13_93dc, 4); mov(memw_a16[es, di + 0x71], ax);         /* mov [es:di+0x71], ax */
            ii(0x13_93e0, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_93e2, 3); mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0x13_93e5, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x13_93e7, 5); mov(memb_a16[es, bx + 0x5], 0x93);        /* mov byte [es:bx+0x5], 0x93 */
            ii(0x13_93ec, 2); mov(es, bx);                              /* mov es, bx */
            ii(0x13_93ee, 2); xor(di, di);                              /* xor di, di */
            ii(0x13_93f0, 3); mov(bx, memw_a16[es, di]);                /* mov bx, [es:di] */
            ii(0x13_93f3, 1); pushw(ds);                                /* push ds */
            ii(0x13_93f4, 1); popw(es);                                 /* pop es */
            ii(0x13_93f5, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x13_93f8, 4); mov(memw_a16[es, di + 0x73], bx);         /* mov [es:di+0x73], bx */
            ii(0x13_93fc, 3); mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0x13_93ff, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x13_9401, 5); mov(memb_a16[es, bx + 0x5], 0x93);        /* mov byte [es:bx+0x5], 0x93 */
            ii(0x13_9406, 1); pushw(ds);                                /* push ds */
            ii(0x13_9407, 1); popw(es);                                 /* pop es */
            ii(0x13_9408, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x13_940b, 4); mov(ds, memw_a16[es, di + 0x73]);         /* mov ds, [es:di+0x73] */
            ii(0x13_940f, 2); xor(si, si);                              /* xor si, si */
            ii(0x13_9411, 3); mov(cx, 0x1a);                            /* mov cx, 0x1a */
            ii(0x13_9414, 3); rep_a16(() => movsd_a16());               /* rep movsd */
            ii(0x13_9417, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x13_941a, 4); mov(ds, memw_a16[es, di + 0x73]);         /* mov ds, [es:di+0x73] */
            ii(0x13_941e, 4); mov(es, memw_a16[es, di + 0x71]);         /* mov es, [es:di+0x71] */
            ii(0x13_9422, 2); xor(di, di);                              /* xor di, di */
            ii(0x13_9424, 2); xor(si, si);                              /* xor si, si */
            ii(0x13_9426, 8); and(memd_a16[ds, si + 0x24], 0xfffe_fcff); /* and dword [si+0x24], 0xfffefcff */
            ii(0x13_942e, 3); mov(ebx, cr2);                            /* mov ebx, cr2 */
            ii(0x13_9431, 4); mov(memd_a16[ds, si + 0x34], ebx);        /* mov [si+0x34], ebx */
            ii(0x13_9435, 8); mov(memd_a16[ds, si + 0x38], 0xffc);      /* mov dword [si+0x38], 0xffc */
            ii(0x13_943d, 4); mov(ax, memw_a16[es, di + 0x54]);         /* mov ax, [es:di+0x54] */
            ii(0x13_9441, 3); mov(memw_a16[ds, si + 0x54], ax);         /* mov [si+0x54], ax */
            ii(0x13_9444, 4); mov(ax, memw_a16[es, di + 0x50]);         /* mov ax, [es:di+0x50] */
            ii(0x13_9448, 3); mov(memw_a16[ds, si + 0x50], ax);         /* mov [si+0x50], ax */
            ii(0x13_944b, 3); mov(memw_a16[ds, si + 0x4c], cs);         /* mov [si+0x4c], cs */
            ii(0x13_944e, 8); mov(memd_a16[ds, si + 0x20], 0x4cd9);     /* mov dword [si+0x20], 0x4cd9 */
            ii(0x13_9456, 3); pushw(0x3e68);                            /* push 0x3e68 */
            ii(0x13_9459, 1); popw(ds);                                 /* pop ds */
            ii(0x13_945a, 1); pushw(ds);                                /* push ds */
            ii(0x13_945b, 1); popw(es);                                 /* pop es */
            ii(0x13_945c, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x13_945f, 9); mov(memd_a16[es, di + 0x68], 0);          /* mov dword [es:di+0x68], 0x0 */
            ii(0x13_9468, 4); mov(ax, memw_a16[es, di + 0x50]);         /* mov ax, [es:di+0x50] */
            ii(0x13_946c, 4); cmp(ax, memw_a16[ds, 0x1f56]);            /* cmp ax, [0x1f56] */
            ii(0x13_9470, 4); if(jnzw(0x13_9498, 0x24)) goto l_0x13_9498; /* jnz 0x9498 */
            ii(0x13_9474, 4); les(di, ds, 0x1f54);                      /* les di, [0x1f54] */
            ii(0x13_9478, 4); mov(eax, memd_a16[es, di]);               /* mov eax, [es:di] */
            ii(0x13_947c, 1); pushw(ds);                                /* push ds */
            ii(0x13_947d, 1); popw(es);                                 /* pop es */
            ii(0x13_947e, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x13_9481, 5); mov(memd_a16[es, di + 0x68], eax);        /* mov [es:di+0x68], eax */
            ii(0x13_9486, 5); mov(eax, memd_a16[es, di + 0x38]);        /* mov eax, [es:di+0x38] */
            ii(0x13_948b, 6); sub(eax, 0x2c8);                          /* sub eax, 0x2c8 */
            ii(0x13_9491, 4); les(di, ds, 0x1f54);                      /* les di, [0x1f54] */
            ii(0x13_9495, 3); mov(memw_a16[es, di], ax);                /* mov [es:di], ax */
        l_0x13_9498:
            ii(0x13_9498, 1); pushw(ds);                                /* push ds */
            ii(0x13_9499, 1); popw(es);                                 /* pop es */
            ii(0x13_949a, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x13_949d, 6); mov(memw_a16[es, di + 0x5a], 0);          /* mov word [es:di+0x5a], 0x0 */
            ii(0x13_94a3, 2); xor(cl, cl);                              /* xor cl, cl */
            ii(0x13_94a5, 5); cmp(memb_a16[ds, 0xb2], 0x1);             /* cmp byte [0xb2], 0x1 */
            ii(0x13_94aa, 4); if(jnzw(0x13_94ca, 0x1c)) goto l_0x13_94ca; /* jnz 0x94ca */
            ii(0x13_94ae, 4); mov(dx, memw_a16[ds, 0xb4]);              /* mov dx, [0xb4] */
            ii(0x13_94b2, 2); mov(al, 0xb);                             /* mov al, 0xb */
            ii(0x13_94b4, 1); outb(dx, al);                             /* out dx, al */
            ii(0x13_94b5, 2); jmpw(0x13_94b7, 0); goto l_0x13_94b7;     /* jmp 0x94b7 */
        l_0x13_94b7:
            ii(0x13_94b7, 2); jmpw(0x13_94b9, 0); goto l_0x13_94b9;     /* jmp 0x94b9 */
        l_0x13_94b9:
            ii(0x13_94b9, 1); inb(al, dx);                              /* in al, dx */
            ii(0x13_94ba, 4); and(al, memb_a16[ds, 0xb6]);              /* and al, [0xb6] */
            ii(0x13_94be, 4); if(jzw(0x13_94ca, 0x8)) goto l_0x13_94ca; /* jz 0x94ca */
            ii(0x13_94c2, 6); mov(memw_a16[es, di + 0x5a], 0xffff);     /* mov word [es:di+0x5a], 0xffff */
            ii(0x13_94c8, 2); mov(cl, 0x1);                             /* mov cl, 0x1 */
        l_0x13_94ca:
            ii(0x13_94ca, 3); mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0x13_94cd, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_94cf, 4); mov(bx, memw_a16[es, di + 0x73]);         /* mov bx, [es:di+0x73] */
            ii(0x13_94d3, 4); mov(memb_a16[ds, bx + 0x5], 0x8b);        /* mov byte [bx+0x5], 0x8b */
            ii(0x13_94d7, 4); mov(bx, memw_a16[es, di + 0x71]);         /* mov bx, [es:di+0x71] */
            ii(0x13_94db, 4); mov(memb_a16[ds, bx + 0x5], 0x8b);        /* mov byte [bx+0x5], 0x8b */
            ii(0x13_94df, 1); pushfw();                                 /* pushfw */
            ii(0x13_94e0, 1); popw(ax);                                 /* pop ax */
            ii(0x13_94e1, 3); or(ax, 0x4000);                           /* or ax, 0x4000 */
            ii(0x13_94e4, 1); pushw(ax);                                /* push ax */
            ii(0x13_94e5, 1); popfw();                                  /* popfw */
            ii(0x13_94e6, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x13_94e8, 1); popw(bp);                                 /* pop bp */
            ii(0x13_94e9, 1); popw(es);                                 /* pop es */
            ii(0x13_94ea, 1); popw(ds);                                 /* pop ds */
            ii(0x13_94eb, 3); cmp(cl, 0x1);                             /* cmp cl, 0x1 */
            ii(0x13_94ee, 4); if(jzw(0x13_94f4, 0x2)) goto l_0x13_94f4; /* jz 0x94f4 */
            ii(0x13_94f2, 1); popw(ax);                                 /* pop ax */
            ii(0x13_94f3, 1); popw(ax);                                 /* pop ax */
        l_0x13_94f4:
            ii(0x13_94f4, 1); popa();                                   /* popa */
            ii(0x13_94f5, 1); iretw(); return;                          /* iretw */
        }
    }
}