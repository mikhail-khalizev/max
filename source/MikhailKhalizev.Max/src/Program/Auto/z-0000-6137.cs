using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0db92b41-1daf-480e-a8eb-b493e22b3ab7")]
        public void Method_0000_6137()
        {
            ii(0x6137, 1);    pushw(bp);                                /* push bp */
            ii(0x6138, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x613a, 2);    pushad();                                 /* pushad */
            ii(0x613c, 2);    pushw(fs);                                /* push fs */
            ii(0x613e, 2);    pushw(gs);                                /* push gs */
            ii(0x6140, 4);    pushw(memw_a16[ds, 0xdf8]);               /* push word [0xdf8] */
            ii(0x6144, 5);    test(memb_a16[ds, 0x1582], 0x1);          /* test byte [0x1582], 0x1 */
            ii(0x6149, 2);    if(jnzw(0x61ca, 0x7f)) goto l_0x61ca;     /* jnz 0x61ca */
            ii(0x614b, 5);    test(memb_a16[ds, 0x47], 0x80);           /* test byte [0x47], 0x80 */
            ii(0x6150, 2);    if(jzw(0x6157, 0x5)) goto l_0x6157;       /* jz 0x6157 */
            ii(0x6152, 3);    mov(ax, 0x101b);                          /* mov ax, 0x101b */
            ii(0x6155, 2);    @int(0x15);                               /* int 0x15 */
        l_0x6157:
            ii(0x6157, 1);    pushw(cs);                                /* push cs */
            ii(0x6158, 3);    callw(0x60db, -0x80);                     /* call 0x60db */
            ii(0x615b, 6);    movsx(ecx, memw_a16[ds, 0xdf0]);          /* movsx ecx, word [0xdf0] */
            ii(0x6161, 3);    not(ecx);                                 /* not ecx */
            ii(0x6164, 6);    movzx(edi, memw_a16[ds, 0xeca]);          /* movzx edi, word [0xeca] */
            ii(0x616a, 4);    shl(edi, 0x6);                            /* shl edi, 0x6 */
            ii(0x616e, 4);    mov(edx, memd_a16[ss, bp + 0x6]);         /* mov edx, [bp+0x6] */
            ii(0x6172, 3);    cmp(edi, edx);                            /* cmp edi, edx */
            ii(0x6175, 2);    if(jaw(0x617a, 0x3)) goto l_0x617a;       /* ja 0x617a */
            ii(0x6177, 3);    mov(edi, edx);                            /* mov edi, edx */
        l_0x617a:
            ii(0x617a, 3);    add(edi, ecx);                            /* add edi, ecx */
            ii(0x617d, 3);    not(ecx);                                 /* not ecx */
            ii(0x6180, 2);    and(di, cx);                              /* and di, cx */
            ii(0x6182, 4);    shr(edi, 0x6);                            /* shr edi, 0x6 */
            ii(0x6186, 4);    and(ecx, memd_a16[ss, bp + 0xa]);         /* and ecx, [bp+0xa] */
            ii(0x618a, 4);    shr(ecx, 0x6);                            /* shr ecx, 0x6 */
            ii(0x618e, 3);    add(edi, esi);                            /* add edi, esi */
            ii(0x6191, 3);    add(ecx, esi);                            /* add ecx, esi */
            ii(0x6194, 4);    mov(memd_a16[ss, bp + 0xa], ecx);         /* mov [bp+0xa], ecx */
            ii(0x6198, 2);    jmpw(0x619e, 0x4); goto l_0x619e;         /* jmp 0x619e */
        l_0x619a:
            ii(0x619a, 4);    add(edi, 0x4);                            /* add edi, 0x4 */
        l_0x619e:
            ii(0x619e, 3);    cmp(edi, ecx);                            /* cmp edi, ecx */
            ii(0x61a1, 2);    if(jaew(0x61be, 0x1b)) goto l_0x61be;     /* jae 0x61be */
            ii(0x61a3, 5);    mov(edx, memd_a32[es, edi]);              /* mov edx, [es:edi] */
            ii(0x61a8, 3);    test(dh, 0x4);                            /* test dh, 0x4 */
            ii(0x61ab, 2);    if(jnzw(0x619a, -0x13)) goto l_0x619a;    /* jnz 0x619a */
            ii(0x61ad, 2);    mov(ax, dx);                              /* mov ax, dx */
            ii(0x61af, 4);    and(ax, memw_a16[ds, 0xdf2]);             /* and ax, [0xdf2] */
            ii(0x61b3, 4);    cmp(ax, memw_a16[ds, 0xdf2]);             /* cmp ax, [0xdf2] */
            ii(0x61b7, 2);    if(jnzw(0x619a, -0x1f)) goto l_0x619a;    /* jnz 0x619a */
            ii(0x61b9, 3);    callw(0x6101, -0xbb);                     /* call 0x6101 */
            ii(0x61bc, 2);    jmpw(0x619e, -0x20); goto l_0x619e;       /* jmp 0x619e */
        l_0x61be:
            ii(0x61be, 5);    test(memb_a16[ds, 0x47], 0x80);           /* test byte [0x47], 0x80 */
            ii(0x61c3, 2);    if(jzw(0x61ca, 0x5)) goto l_0x61ca;       /* jz 0x61ca */
            ii(0x61c5, 3);    mov(ax, 0x101c);                          /* mov ax, 0x101c */
            ii(0x61c8, 2);    @int(0x15);                               /* int 0x15 */
        l_0x61ca:
            ii(0x61ca, 1);    popw(bx);                                 /* pop bx */
            ii(0x61cb, 3);    mov(ax, memw_a16[ds, 0xdf8]);             /* mov ax, [0xdf8] */
            ii(0x61ce, 2);    sub(ax, bx);                              /* sub ax, bx */
            ii(0x61d0, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x61d3, 2);    if(jzw(0x61db, 0x6)) goto l_0x61db;       /* jz 0x61db */
            ii(0x61d5, 3);    mov(ebx, cr3);                            /* mov ebx, cr3 */
            ii(0x61d8, 3);    mov(cr3, ebx);                            /* mov cr3, ebx */
        l_0x61db:
            ii(0x61db, 2);    popw(gs);                                 /* pop gs */
            ii(0x61dd, 2);    popw(fs);                                 /* pop fs */
            ii(0x61df, 2);    popad();                                  /* popad */
            ii(0x61e1, 1);    popw(bp);                                 /* pop bp */
            ii(0x61e2, 1);    retfw(); return;                          /* retf */
        }
    }
}
