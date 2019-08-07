using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("53e40504-61ce-4483-97e8-76346c82f9fe")]
        public void Method_0000_927b()
        {
            ii(0x927b, 1);    pushw(bp);                                /* push bp */
            ii(0x927c, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x927e, 3);    sub(sp, 0x6);                             /* sub sp, 0x6 */
            ii(0x9281, 1);    pushw(si);                                /* push si */
            ii(0x9282, 4);    mov(memb_a16[ss, bp - 0x2], 0);           /* mov byte [bp-0x2], 0x0 */
            ii(0x9286, 3);    mov(si, 0x15e8);                          /* mov si, 0x15e8 */
        l_0x9289:
            ii(0x9289, 3);    callw(0x90c6, -0x1c6);                    /* call 0x90c6 */
            ii(0x928c, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x928f, 1);    inc(ax);                                  /* inc ax */
            ii(0x9290, 2);    if(jzw(0x9308, 0x76)) goto l_0x9308;      /* jz 0x9308 */
            ii(0x9292, 3);    sub(ax, 0x23);                            /* sub ax, 0x23 */
            ii(0x9295, 2);    if(jnzw(0x929a, 0x3)) goto l_0x929a;      /* jnz 0x929a */
            ii(0x9297, 3);    jmpw(0x931b, 0x81); goto l_0x931b;        /* jmp 0x931b */
        l_0x929a:
            ii(0x929a, 3);    sub(ax, 0x5);                             /* sub ax, 0x5 */
            ii(0x929d, 2);    if(jzw(0x931b, 0x7c)) goto l_0x931b;      /* jz 0x931b */
            ii(0x929f, 3);    sub(ax, 0x14);                            /* sub ax, 0x14 */
            ii(0x92a2, 2);    if(jnzw(0x92a7, 0x3)) goto l_0x92a7;      /* jnz 0x92a7 */
            ii(0x92a4, 3);    jmpw(0x9352, 0xab); goto l_0x9352;        /* jmp 0x9352 */
        l_0x92a7:
            ii(0x92a7, 3);    sub(ax, 0x8);                             /* sub ax, 0x8 */
            ii(0x92aa, 2);    if(jzw(0x92d8, 0x2c)) goto l_0x92d8;      /* jz 0x92d8 */
            ii(0x92ac, 1);    dec(ax);                                  /* dec ax */
            ii(0x92ad, 1);    dec(ax);                                  /* dec ax */
            ii(0x92ae, 2);    if(jzw(0x92fc, 0x4c)) goto l_0x92fc;      /* jz 0x92fc */
            ii(0x92b0, 3);    sub(ax, 0x8);                             /* sub ax, 0x8 */
            ii(0x92b3, 2);    if(jnzw(0x9289, -0x2c)) goto l_0x9289;    /* jnz 0x9289 */
            ii(0x92b5, 3);    mov(ax, 0xf29);                           /* mov ax, 0xf29 */
            ii(0x92b8, 1);    pushw(ax);                                /* push ax */
            ii(0x92b9, 3);    callw(0x919b, -0x121);                    /* call 0x919b */
            ii(0x92bc, 1);    popw(bx);                                 /* pop bx */
            ii(0x92bd, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x92bf, 2);    if(jzw(0x9289, -0x38)) goto l_0x9289;     /* jz 0x9289 */
            ii(0x92c1, 4);    cmp(memb_a16[ss, bp - 0x2], 0);           /* cmp byte [bp-0x2], 0x0 */
            ii(0x92c5, 2);    if(jzw(0x92cb, 0x4)) goto l_0x92cb;       /* jz 0x92cb */
            ii(0x92c7, 3);    mov(memb_a16[ds, si], 0);                 /* mov byte [si], 0x0 */
            ii(0x92ca, 1);    inc(si);                                  /* inc si */
        l_0x92cb:
            ii(0x92cb, 3);    callw(0x9141, -0x18d);                    /* call 0x9141 */
            ii(0x92ce, 2);    mov(memw_a16[ds, si], ax);                /* mov [si], ax */
            ii(0x92d0, 1);    inc(si);                                  /* inc si */
            ii(0x92d1, 1);    inc(si);                                  /* inc si */
            ii(0x92d2, 4);    mov(memb_a16[ss, bp - 0x2], 0x1);         /* mov byte [bp-0x2], 0x1 */
            ii(0x92d6, 2);    jmpw(0x9289, -0x4f); goto l_0x9289;       /* jmp 0x9289 */
        l_0x92d8:
            ii(0x92d8, 3);    mov(ax, 0xf30);                           /* mov ax, 0xf30 */
            ii(0x92db, 1);    pushw(ax);                                /* push ax */
            ii(0x92dc, 3);    callw(0x919b, -0x144);                    /* call 0x919b */
            ii(0x92df, 1);    popw(bx);                                 /* pop bx */
            ii(0x92e0, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x92e2, 2);    if(jzw(0x9289, -0x5b)) goto l_0x9289;     /* jz 0x9289 */
            ii(0x92e4, 4);    cmp(memb_a16[ss, bp - 0x2], 0);           /* cmp byte [bp-0x2], 0x0 */
            ii(0x92e8, 2);    if(jnzw(0x92eb, 0x1)) goto l_0x92eb;      /* jnz 0x92eb */
            ii(0x92ea, 1);    dec(si);                                  /* dec si */
        l_0x92eb:
            ii(0x92eb, 3);    mov(memb_a16[ds, si], 0xd);               /* mov byte [si], 0xd */
            ii(0x92ee, 1);    inc(si);                                  /* inc si */
            ii(0x92ef, 3);    mov(memb_a16[ds, si], 0xa);               /* mov byte [si], 0xa */
            ii(0x92f2, 2);    sub(al, al);                              /* sub al, al */
            ii(0x92f4, 3);    mov(memb_a16[ss, bp - 0x2], al);          /* mov [bp-0x2], al */
            ii(0x92f7, 1);    inc(si);                                  /* inc si */
            ii(0x92f8, 2);    mov(memb_a16[ds, si], al);                /* mov [si], al */
            ii(0x92fa, 2);    jmpw(0x932e, 0x32); goto l_0x932e;        /* jmp 0x932e */
        l_0x92fc:
            ii(0x92fc, 3);    mov(ax, 0xf38);                           /* mov ax, 0xf38 */
            ii(0x92ff, 1);    pushw(ax);                                /* push ax */
            ii(0x9300, 3);    callw(0x919b, -0x168);                    /* call 0x919b */
            ii(0x9303, 1);    popw(bx);                                 /* pop bx */
            ii(0x9304, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x9306, 2);    if(jzw(0x9289, -0x7f)) goto l_0x9289;     /* jz 0x9289 */
        l_0x9308:
            ii(0x9308, 4);    mov(memw_a16[ds, si], 0xffff);            /* mov word [si], 0xffff */
            ii(0x930c, 1);    inc(si);                                  /* inc si */
            ii(0x930d, 1);    inc(si);                                  /* inc si */
            ii(0x930e, 4);    mov(memw_a16[ds, 0xf22], si);             /* mov [0xf22], si */
            ii(0x9312, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x9314, 2);    and(al, 0xfe);                            /* and al, 0xfe */
            ii(0x9316, 3);    mov(memw_a16[ds, 0xcde], ax);             /* mov [0xcde], ax */
            ii(0x9319, 2);    jmpw(0x9364, 0x49); goto l_0x9364;        /* jmp 0x9364 */
        l_0x931b:
            ii(0x931b, 4);    cmp(memb_a16[ss, bp - 0x2], 0);           /* cmp byte [bp-0x2], 0x0 */
            ii(0x931f, 2);    if(jnzw(0x9322, 0x1)) goto l_0x9322;      /* jnz 0x9322 */
            ii(0x9321, 1);    dec(si);                                  /* dec si */
        l_0x9322:
            ii(0x9322, 4);    mov(memb_a16[ss, bp - 0x2], 0);           /* mov byte [bp-0x2], 0x0 */
        l_0x9326:
            ii(0x9326, 3);    callw(0x90c6, -0x263);                    /* call 0x90c6 */
            ii(0x9329, 3);    cmp(ax, memw_a16[ss, bp - 0x4]);          /* cmp ax, [bp-0x4] */
            ii(0x932c, 2);    if(jnzw(0x9332, 0x4)) goto l_0x9332;      /* jnz 0x9332 */
        l_0x932e:
            ii(0x932e, 1);    inc(si);                                  /* inc si */
            ii(0x932f, 3);    jmpw(0x9289, -0xa9); goto l_0x9289;       /* jmp 0x9289 */
        l_0x9332:
            ii(0x9332, 2);    sub(ah, ah);                              /* sub ah, ah */
            ii(0x9334, 2);    mov(memw_a16[ds, si], ax);                /* mov [si], ax */
            ii(0x9336, 3);    mov(ax, memw_a16[ds, 0xce6]);             /* mov ax, [0xce6] */
            ii(0x9339, 3);    sub(ax, 0x10);                            /* sub ax, 0x10 */
            ii(0x933c, 1);    inc(si);                                  /* inc si */
            ii(0x933d, 2);    cmp(ax, si);                              /* cmp ax, si */
            ii(0x933f, 2);    if(jaew(0x9326, -0x1b)) goto l_0x9326;    /* jae 0x9326 */
            ii(0x9341, 3);    mov(ax, 0x200);                           /* mov ax, 0x200 */
            ii(0x9344, 1);    pushw(ax);                                /* push ax */
            ii(0x9345, 5);    callw_far_abs(0x1a2, 0xb12);              /* call word 0x1a2:0xb12 */
            ii(0x934a, 1);    popw(bx);                                 /* pop bx */
            ii(0x934b, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x934d, 2);    if(jnzw(0x9326, -0x29)) goto l_0x9326;    /* jnz 0x9326 */
            ii(0x934f, 1);    inc(si);                                  /* inc si */
            ii(0x9350, 2);    jmpw(0x9308, -0x4a); goto l_0x9308;       /* jmp 0x9308 */
        l_0x9352:
            ii(0x9352, 3);    callw(0x90c6, -0x28f);                    /* call 0x90c6 */
            ii(0x9355, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x9358, 3);    cmp(ax, 0xa);                             /* cmp ax, 0xa */
            ii(0x935b, 2);    if(jnzw(0x9360, 0x3)) goto l_0x9360;      /* jnz 0x9360 */
            ii(0x935d, 3);    jmpw(0x9289, -0xd7); goto l_0x9289;       /* jmp 0x9289 */
        l_0x9360:
            ii(0x9360, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x9362, 2);    if(jgew(0x9352, -0x12)) goto l_0x9352;    /* jge 0x9352 */
        l_0x9364:
            ii(0x9364, 1);    popw(si);                                 /* pop si */
            ii(0x9365, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x9367, 1);    popw(bp);                                 /* pop bp */
            ii(0x9368, 1);    retw(); return;                           /* ret */
        }
    }
}
