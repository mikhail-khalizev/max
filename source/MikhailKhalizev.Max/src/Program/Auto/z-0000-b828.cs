using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb828-5038930a")]
        public void Method_0000_b828()
        {
            ii(0xb828, 1);    pushw(bp);                                /* push bp */
            ii(0xb829, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xb82b, 1);    pushw(di);                                /* push di */
            ii(0xb82c, 1);    pushw(si);                                /* push si */
            ii(0xb82d, 3);    callw(0x4030, -0x7800);                   /* call 0x4030 */
            ii(0xb830, 7);    movzx(ecx, memw_a16[cs, 0x79f6]);         /* movzx ecx, word [cs:0x79f6] */
            ii(0xb837, 2);    if(jcxzw(0xb8b2, 0x79)) goto l_0xb8b2;    /* jcxz 0xb8b2 */
            ii(0xb839, 6);    movzx(esi, memw_a16[ds, 0xaa]);           /* movzx esi, word [0xaa] */
            ii(0xb83f, 2);    pushw(0x38);                              /* push 0x38 */
            ii(0xb841, 1);    popw(ds);                                 /* pop ds */
            ii(0xb842, 4);    shl(esi, 0x4);                            /* shl esi, 0x4 */
            ii(0xb846, 3);    mov(edi, esi);                            /* mov edi, esi */
            ii(0xb849, 7);    add(edi, 0x1c00);                         /* add edi, 0x1c00 */
            ii(0xb850, 6);    mov(edx, memd_a16[cs, 0x79f8]);           /* mov edx, [cs:0x79f8] */
            ii(0xb856, 4);    xchg(memd_a32[ds, esi], edx);             /* xchg [esi], edx */
            ii(0xb85a, 3);    add(si, 0x4);                             /* add si, 0x4 */
            ii(0xb85d, 3);    mov(eax, cr3);                            /* mov eax, cr3 */
            ii(0xb860, 3);    mov(cr3, eax);                            /* mov cr3, eax */
            ii(0xb863, 3);    lodsd_a32();                              /* a32 lodsd */
            ii(0xb866, 3);    mov(ebx, eax);                            /* mov ebx, eax */
            ii(0xb869, 4);    xchg(memd_a32[ds, edi], eax);             /* xchg [edi], eax */
            ii(0xb86d, 8);    mov(memd_a32[ds, 0x30_0000], ebx);        /* mov [0x300000], ebx */
            ii(0xb875, 4);    mov(memd_a32[ds, edi], eax);              /* mov [edi], eax */
            ii(0xb879, 5);    mov(memd_a32[ds, esi - 0x8], edx);        /* mov [esi-0x8], edx */
            ii(0xb87e, 3);    mov(eax, cr3);                            /* mov eax, cr3 */
            ii(0xb881, 3);    mov(cr3, eax);                            /* mov cr3, eax */
            ii(0xb884, 6);    mov(edi, 0x40_0004);                      /* mov edi, 0x400004 */
            ii(0xb88a, 1);    pushw(ds);                                /* push ds */
            ii(0xb88b, 1);    popw(es);                                 /* pop es */
            ii(0xb88c, 2);    mov(bx, cx);                              /* mov bx, cx */
            ii(0xb88e, 1);    dec(cx);                                  /* dec cx */
            ii(0xb88f, 4);    rep_a32(() => movsd_a32());               /* a32 rep movsd */
            ii(0xb893, 2);    mov(cx, bx);                              /* mov cx, bx */
            ii(0xb895, 3);    shl(cx, 0xa);                             /* shl cx, 0xa */
            ii(0xb898, 2);    sub(cx, bx);                              /* sub cx, bx */
            ii(0xb89a, 3);    xor(eax, eax);                            /* xor eax, eax */
            ii(0xb89d, 4);    rep_a32(() => stosd_a32());               /* a32 rep stosd */
            ii(0xb8a1, 1);    pushw(ss);                                /* push ss */
            ii(0xb8a2, 1);    popw(ds);                                 /* pop ds */
            ii(0xb8a3, 4);    mov(cx, memw_a16[ds, 0xdfa]);             /* mov cx, [0xdfa] */
            ii(0xb8a7, 2);    if(jcxzw(0xb8b2, 0x9)) goto l_0xb8b2;     /* jcxz 0xb8b2 */
            ii(0xb8a9, 6);    mov(esi, 0x3f_f000);                      /* mov esi, 0x3ff000 */
            ii(0xb8af, 3);    callw(0xb989, 0xd7);                      /* call 0xb989 */
        l_0xb8b2:
            ii(0xb8b2, 4);    pushd(memd_a16[ss, bp + 0x4]);            /* push dword [bp+0x4] */
            ii(0xb8b6, 5);    pushd(memd_a16[ds, 0x98]);                /* push dword [0x98] */
            ii(0xb8bb, 5);    callw_far_abs(0x70, 0x57bb);              /* call word 0x70:0x57bb */
            ii(0xb8c0, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0xb8c3, 1);    pushw(ax);                                /* push ax */
            ii(0xb8c4, 3);    callw(0x46cc, -0x71fb);                   /* call 0x46cc */
            ii(0xb8c7, 1);    popw(ax);                                 /* pop ax */
            ii(0xb8c8, 1);    inc(ax);                                  /* inc ax */
            ii(0xb8c9, 1);    popw(si);                                 /* pop si */
            ii(0xb8ca, 1);    popw(di);                                 /* pop di */
            ii(0xb8cb, 7);    mov(memw_a16[cs, 0x79f6], 0);             /* mov word [cs:0x79f6], 0x0 */
            ii(0xb8d2, 1);    popw(bp);                                 /* pop bp */
            ii(0xb8d3, 1);    retw();                                   /* ret */
        }
    }
}
