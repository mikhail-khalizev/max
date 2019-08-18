using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xd838-5038930a")]
        public void Method_0000_d838()
        {
            ii(0xd838, 1);    pushw(bp);                                /* push bp */
            ii(0xd839, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xd83b, 1);    pushw(di);                                /* push di */
            ii(0xd83c, 1);    pushw(si);                                /* push si */
            ii(0xd83d, 3);    callw(0x6040, -0x7800);                   /* call 0x6040 */
            ii(0xd840, 7);    movzx(ecx, memw_a16[cs, 0x79f6]);         /* movzx ecx, word [cs:0x79f6] */
            ii(0xd847, 2);    if(jcxzw(0xd8c2, 0x79)) goto l_0xd8c2;    /* jcxz 0xd8c2 */
            ii(0xd849, 6);    movzx(esi, memw_a16[ds, 0xaa]);           /* movzx esi, word [0xaa] */
            ii(0xd84f, 2);    pushw(0x38);                              /* push 0x38 */
            ii(0xd851, 1);    popw(ds);                                 /* pop ds */
            ii(0xd852, 4);    shl(esi, 0x4);                            /* shl esi, 0x4 */
            ii(0xd856, 3);    mov(edi, esi);                            /* mov edi, esi */
            ii(0xd859, 7);    add(edi, 0x1c00);                         /* add edi, 0x1c00 */
            ii(0xd860, 6);    mov(edx, memd_a16[cs, 0x79f8]);           /* mov edx, [cs:0x79f8] */
            ii(0xd866, 4);    xchg(memd_a32[ds, esi], edx);             /* xchg [esi], edx */
            ii(0xd86a, 3);    add(si, 0x4);                             /* add si, 0x4 */
            ii(0xd86d, 3);    mov(eax, cr3);                            /* mov eax, cr3 */
            ii(0xd870, 3);    mov(cr3, eax);                            /* mov cr3, eax */
            ii(0xd873, 3);    lodsd_a32();                              /* a32 lodsd */
            ii(0xd876, 3);    mov(ebx, eax);                            /* mov ebx, eax */
            ii(0xd879, 4);    xchg(memd_a32[ds, edi], eax);             /* xchg [edi], eax */
            ii(0xd87d, 8);    mov(memd_a32[ds, 0x30_0000], ebx);        /* mov [0x300000], ebx */
            ii(0xd885, 4);    mov(memd_a32[ds, edi], eax);              /* mov [edi], eax */
            ii(0xd889, 5);    mov(memd_a32[ds, esi - 0x8], edx);        /* mov [esi-0x8], edx */
            ii(0xd88e, 3);    mov(eax, cr3);                            /* mov eax, cr3 */
            ii(0xd891, 3);    mov(cr3, eax);                            /* mov cr3, eax */
            ii(0xd894, 6);    mov(edi, 0x40_0004);                      /* mov edi, 0x400004 */
            ii(0xd89a, 1);    pushw(ds);                                /* push ds */
            ii(0xd89b, 1);    popw(es);                                 /* pop es */
            ii(0xd89c, 2);    mov(bx, cx);                              /* mov bx, cx */
            ii(0xd89e, 1);    dec(cx);                                  /* dec cx */
            ii(0xd89f, 4);    rep_a32(() => movsd_a32());               /* a32 rep movsd */
            ii(0xd8a3, 2);    mov(cx, bx);                              /* mov cx, bx */
            ii(0xd8a5, 3);    shl(cx, 0xa);                             /* shl cx, 0xa */
            ii(0xd8a8, 2);    sub(cx, bx);                              /* sub cx, bx */
            ii(0xd8aa, 3);    xor(eax, eax);                            /* xor eax, eax */
            ii(0xd8ad, 4);    rep_a32(() => stosd_a32());               /* a32 rep stosd */
            ii(0xd8b1, 1);    pushw(ss);                                /* push ss */
            ii(0xd8b2, 1);    popw(ds);                                 /* pop ds */
            ii(0xd8b3, 4);    mov(cx, memw_a16[ds, 0xdfa]);             /* mov cx, [0xdfa] */
            ii(0xd8b7, 2);    if(jcxzw(0xd8c2, 0x9)) goto l_0xd8c2;     /* jcxz 0xd8c2 */
            ii(0xd8b9, 6);    mov(esi, 0x3f_f000);                      /* mov esi, 0x3ff000 */
            ii(0xd8bf, 3);    callw(0xd999, 0xd7);                      /* call 0xd999 */
        l_0xd8c2:
            ii(0xd8c2, 4);    pushd(memd_a16[ss, bp + 0x4]);            /* push dword [bp+0x4] */
            ii(0xd8c6, 5);    pushd(memd_a16[ds, 0x98]);                /* push dword [0x98] */
            ii(0xd8cb, 5);    callw_far_abs(0x70, 0x57bb);              /* call word 0x70:0x57bb */
            ii(0xd8d0, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0xd8d3, 1);    pushw(ax);                                /* push ax */
            ii(0xd8d4, 3);    callw(0x66dc, -0x71fb);                   /* call 0x66dc */
            ii(0xd8d7, 1);    popw(ax);                                 /* pop ax */
            ii(0xd8d8, 1);    inc(ax);                                  /* inc ax */
            ii(0xd8d9, 1);    popw(si);                                 /* pop si */
            ii(0xd8da, 1);    popw(di);                                 /* pop di */
            ii(0xd8db, 7);    mov(memw_a16[cs, 0x79f6], 0);             /* mov word [cs:0x79f6], 0x0 */
            ii(0xd8e2, 1);    popw(bp);                                 /* pop bp */
            ii(0xd8e3, 1);    retw(); return;                           /* ret */
        }
    }
}
