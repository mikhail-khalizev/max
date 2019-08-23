using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x68e7-dbae9ef5")]
        public void Method_0000_68e7()
        {
            ii(0x68e7, 1);    push(bp);                                 /* push bp */
            ii(0x68e8, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x68ea, 2);    pushad();                                 /* pushad */
            ii(0x68ec, 2);    push(fs);                                 /* push fs */
            ii(0x68ee, 2);    push(gs);                                 /* push gs */
            ii(0x68f0, 4);    push(memw[ds, 0xdf8]);                    /* push word [0xdf8] */
            ii(0x68f4, 5);    test(memb[ds, 0x1582], 0x1);              /* test byte [0x1582], 0x1 */
            ii(0x68f9, 2);    if(jnz(0x697a, 0x7f)) goto l_0x697a;      /* jnz 0x697a */
            ii(0x68fb, 5);    test(memb[ds, 0x47], 0x80);               /* test byte [0x47], 0x80 */
            ii(0x6900, 2);    if(jz(0x6907, 0x5)) goto l_0x6907;        /* jz 0x6907 */
            ii(0x6902, 3);    mov(ax, 0x101b);                          /* mov ax, 0x101b */
            ii(0x6905, 2);    @int(0x15);                               /* int 0x15 */
        l_0x6907:
            ii(0x6907, 1);    push(cs);                                 /* push cs */
            ii(0x6908, 3);    call(0x688b, -0x80);                      /* call 0x688b */
            ii(0x690b, 6);    movsx(ecx, memw[ds, 0xdf0]);              /* movsx ecx, word [0xdf0] */
            ii(0x6911, 3);    not(ecx);                                 /* not ecx */
            ii(0x6914, 6);    movzx(edi, memw[ds, 0xeca]);              /* movzx edi, word [0xeca] */
            ii(0x691a, 4);    shl(edi, 0x6);                            /* shl edi, 0x6 */
            ii(0x691e, 4);    mov(edx, memd[ss, bp + 0x6]);             /* mov edx, [bp+0x6] */
            ii(0x6922, 3);    cmp(edi, edx);                            /* cmp edi, edx */
            ii(0x6925, 2);    if(ja(0x692a, 0x3)) goto l_0x692a;        /* ja 0x692a */
            ii(0x6927, 3);    mov(edi, edx);                            /* mov edi, edx */
        l_0x692a:
            ii(0x692a, 3);    add(edi, ecx);                            /* add edi, ecx */
            ii(0x692d, 3);    not(ecx);                                 /* not ecx */
            ii(0x6930, 2);    and(di, cx);                              /* and di, cx */
            ii(0x6932, 4);    shr(edi, 0x6);                            /* shr edi, 0x6 */
            ii(0x6936, 4);    and(ecx, memd[ss, bp + 0xa]);             /* and ecx, [bp+0xa] */
            ii(0x693a, 4);    shr(ecx, 0x6);                            /* shr ecx, 0x6 */
            ii(0x693e, 3);    add(edi, esi);                            /* add edi, esi */
            ii(0x6941, 3);    add(ecx, esi);                            /* add ecx, esi */
            ii(0x6944, 4);    mov(memd[ss, bp + 0xa], ecx);             /* mov [bp+0xa], ecx */
            ii(0x6948, 2);    jmp(0x694e, 0x4); goto l_0x694e;          /* jmp 0x694e */
        l_0x694a:
            ii(0x694a, 4);    add(edi, 0x4);                            /* add edi, 0x4 */
        l_0x694e:
            ii(0x694e, 3);    cmp(edi, ecx);                            /* cmp edi, ecx */
            ii(0x6951, 2);    if(jae(0x696e, 0x1b)) goto l_0x696e;      /* jae 0x696e */
            ii(0x6953, 5);    mov(edx, memd_a32[es, edi]);              /* mov edx, [es:edi] */
            ii(0x6958, 3);    test(dh, 0x4);                            /* test dh, 0x4 */
            ii(0x695b, 2);    if(jnz(0x694a, -0x13)) goto l_0x694a;     /* jnz 0x694a */
            ii(0x695d, 2);    mov(ax, dx);                              /* mov ax, dx */
            ii(0x695f, 4);    and(ax, memw[ds, 0xdf2]);                 /* and ax, [0xdf2] */
            ii(0x6963, 4);    cmp(ax, memw[ds, 0xdf2]);                 /* cmp ax, [0xdf2] */
            ii(0x6967, 2);    if(jnz(0x694a, -0x1f)) goto l_0x694a;     /* jnz 0x694a */
            ii(0x6969, 3);    call(0x68b1, -0xbb);                      /* call 0x68b1 */
            ii(0x696c, 2);    jmp(0x694e, -0x20); goto l_0x694e;        /* jmp 0x694e */
        l_0x696e:
            ii(0x696e, 5);    test(memb[ds, 0x47], 0x80);               /* test byte [0x47], 0x80 */
            ii(0x6973, 2);    if(jz(0x697a, 0x5)) goto l_0x697a;        /* jz 0x697a */
            ii(0x6975, 3);    mov(ax, 0x101c);                          /* mov ax, 0x101c */
            ii(0x6978, 2);    @int(0x15);                               /* int 0x15 */
        l_0x697a:
            ii(0x697a, 1);    pop(bx);                                  /* pop bx */
            ii(0x697b, 3);    mov(ax, memw[ds, 0xdf8]);                 /* mov ax, [0xdf8] */
            ii(0x697e, 2);    sub(ax, bx);                              /* sub ax, bx */
            ii(0x6980, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x6983, 2);    if(jz(0x698b, 0x6)) goto l_0x698b;        /* jz 0x698b */
            ii(0x6985, 3);    mov(ebx, cr3);                            /* mov ebx, cr3 */
            ii(0x6988, 3);    mov(cr3, ebx);                            /* mov cr3, ebx */
        l_0x698b:
            ii(0x698b, 2);    pop(gs);                                  /* pop gs */
            ii(0x698d, 2);    pop(fs);                                  /* pop fs */
            ii(0x698f, 2);    popad();                                  /* popad */
            ii(0x6991, 1);    pop(bp);                                  /* pop bp */
            ii(0x6992, 1);    retf();                                   /* retf */
        }
    }
}
