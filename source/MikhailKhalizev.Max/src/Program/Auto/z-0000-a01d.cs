using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1ea8c40a-fb0c-43cc-96b3-c03daca7a8d4")]
        public void Method_0000_a01d()
        {
            ii(0xa01d, 1);    pushw(bp);                                /* push bp */
            ii(0xa01e, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xa020, 3);    callw(0xa058, 0x35);                      /* call 0xa058 */
            ii(0xa023, 3);    mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
            ii(0xa026, 2);    test(si, si);                             /* test si, si */
            ii(0xa028, 2);    if(jzw(0xa032, 0x8)) goto l_0xa032;       /* jz 0xa032 */
            ii(0xa02a, 1);    pushw(ds);                                /* push ds */
            ii(0xa02b, 1);    popw(es);                                 /* pop es */
            ii(0xa02c, 3);    mov(di, 0xa2c);                           /* mov di, 0xa2c */
            ii(0xa02f, 1);    cld();                                    /* cld */
            ii(0xa030, 2);    jmpw(0xa050, 0x1e); goto l_0xa050;        /* jmp 0xa050 */
        l_0xa032:
            ii(0xa032, 3);    mov(si, memw_a16[ss, bp + 0x4]);          /* mov si, [bp+0x4] */
            ii(0xa035, 1);    pushw(ds);                                /* push ds */
            ii(0xa036, 1);    popw(es);                                 /* pop es */
            ii(0xa037, 1);    cld();                                    /* cld */
            ii(0xa038, 3);    mov(di, 0xa2c);                           /* mov di, 0xa2c */
            ii(0xa03b, 2);    mov(bx, di);                              /* mov bx, di */
        l_0xa03d:
            ii(0xa03d, 1);    lodsb_a16();                              /* lodsb */
            ii(0xa03e, 2);    test(al, al);                             /* test al, al */
            ii(0xa040, 2);    if(jzw(0xa04b, 0x9)) goto l_0xa04b;       /* jz 0xa04b */
            ii(0xa042, 1);    stosb_a16();                              /* stosb */
            ii(0xa043, 2);    cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0xa045, 2);    if(jnzw(0xa03d, -0xa)) goto l_0xa03d;     /* jnz 0xa03d */
            ii(0xa047, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0xa049, 2);    jmpw(0xa03d, -0xe); goto l_0xa03d;        /* jmp 0xa03d */
        l_0xa04b:
            ii(0xa04b, 2);    mov(di, bx);                              /* mov di, bx */
            ii(0xa04d, 3);    mov(si, 0xa7c);                           /* mov si, 0xa7c */
        l_0xa050:
            ii(0xa050, 1);    lodsb_a16();                              /* lodsb */
            ii(0xa051, 1);    stosb_a16();                              /* stosb */
            ii(0xa052, 2);    test(al, al);                             /* test al, al */
            ii(0xa054, 2);    if(jnzw(0xa050, -0x6)) goto l_0xa050;     /* jnz 0xa050 */
            ii(0xa056, 1);    popw(bp);                                 /* pop bp */
            ii(0xa057, 1);    retw(); return;                           /* ret */
        }
    }
}
