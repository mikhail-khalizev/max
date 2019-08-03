using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("64b79bed-f812-4744-b194-7b31875c3bf7")]
        public void Method_0014_fde4()
        {
            ii(0x14_fde4, 2); pushd(esi);                               /* push esi */
            ii(0x14_fde6, 2); pushd(ebp);                               /* push ebp */
            ii(0x14_fde8, 1); pushw(ds);                                /* push ds */
            ii(0x14_fde9, 2); pushfd();                                 /* pushfd */
            ii(0x14_fdeb, 3); mov(si, 0xa8);                            /* mov si, 0xa8 */
            ii(0x14_fdee, 2); mov(ds, si);                              /* mov ds, si */
            ii(0x14_fdf0, 4); movzx(ebp, sp);                           /* movzx ebp, sp */
            ii(0x14_fdf4, 5); lea(ebp, ebp + 0xe);                      /* lea ebp, [ebp+0xe] */
            ii(0x14_fdf9, 5); movzx(esi, memw_a16[ss, bp + 0x8]);       /* movzx esi, word [bp+0x8] */
            ii(0x14_fdfe, 3); mov(memw_a16[ds, si + 0x6], es);          /* mov [si+0x6], es */
            ii(0x14_fe01, 3); mov(memw_a16[ds, si + 0x8], fs);          /* mov [si+0x8], fs */
            ii(0x14_fe04, 3); mov(memw_a16[ds, si + 0xa], gs);          /* mov [si+0xa], gs */
            ii(0x14_fe07, 4); mov(memd_a16[ds, si + 0x1c], ebx);        /* mov [si+0x1c], ebx */
            ii(0x14_fe0b, 4); mov(memd_a16[ds, si + 0x24], ecx);        /* mov [si+0x24], ecx */
            ii(0x14_fe0f, 4); mov(memd_a16[ds, si + 0x20], edx);        /* mov [si+0x20], edx */
            ii(0x14_fe13, 4); mov(memd_a16[ds, si + 0xc], edi);         /* mov [si+0xc], edi */
            ii(0x14_fe17, 4); xchg(memd_a16[ds, si + 0x28], eax);       /* xchg [si+0x28], eax */
            ii(0x14_fe1b, 3); cmp(ah, 0x9);                             /* cmp ah, 0x9 */
            ii(0x14_fe1e, 4); if(jnzw(0x14_fe48, 0x26)) goto l_0x14_fe48; /* jnz 0xfe48 */
            ii(0x14_fe22, 4); cmp(memw_a16[ds, si + 0x2c], 0x31);       /* cmp word [si+0x2c], 0x31 */
            ii(0x14_fe26, 4); if(jnzw(0x14_fe48, 0x1e)) goto l_0x14_fe48; /* jnz 0xfe48 */
            ii(0x14_fe2a, 2); pushfd();                                 /* pushfd */
            ii(0x14_fe2c, 2); pushw(0);                                 /* push 0x0 */
            ii(0x14_fe2e, 1); pushw(cs);                                /* push cs */
            ii(0x14_fe2f, 2); pushw(0);                                 /* push 0x0 */
            ii(0x14_fe31, 3); pushw(0x9ad);                             /* push 0x9ad */
            ii(0x14_fe34, 3); mov(ax, 0x902);                           /* mov ax, 0x902 */
            ii(0x14_fe37, 3); mov(bx, 0x2ca);                           /* mov bx, 0x2ca */
            ii(0x14_fe3a, 3); jmpd_a16_far_ind(ds, bx); return;         /* jmp far dword [bx] */
        //  ii(0x14_fe3d, 11); Недостижимый код.
l_0x14_fe48:
            ii(0x14_fe48, 2); popd(ebx);                                /* pop ebx */
            ii(0x14_fe4a, 3); mov(al, memb_a16[ds, si + 0x3b]);         /* mov al, [si+0x3b] */
            ii(0x14_fe4d, 2); and(al, 0x5);                             /* and al, 0x5 */
            ii(0x14_fe4f, 2); or(bh, al);                               /* or bh, al */
            ii(0x14_fe51, 4); mov(memd_a16[ds, si + 0x3a], ebx);        /* mov [si+0x3a], ebx */
            ii(0x14_fe55, 3); popw(memw_a16[ds, si + 0x4]);             /* pop word [si+0x4] */
            ii(0x14_fe58, 4); popd(memd_a16[ds, si + 0x14]);            /* pop dword [si+0x14] */
            ii(0x14_fe5c, 4); popd(memd_a16[ds, si + 0x10]);            /* pop dword [si+0x10] */
            ii(0x14_fe60, 3); xor(eax, eax);                            /* xor eax, eax */
            ii(0x14_fe63, 1); popw(bp);                                 /* pop bp */
            ii(0x14_fe64, 1); retfw(); return;                          /* retf */
        }
    }
}
