using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_fde4-b8271862")]
        public void Method_0018_fde4()
        {
            ii(0x18_fde4, 2); pushd(esi);                               /* push esi */
            ii(0x18_fde6, 2); pushd(ebp);                               /* push ebp */
            ii(0x18_fde8, 1); push(ds);                                 /* push ds */
            ii(0x18_fde9, 2); pushfd();                                 /* pushfd */
            ii(0x18_fdeb, 3); mov(si, 0xa8);                            /* mov si, 0xa8 */
            ii(0x18_fdee, 2); mov(ds, si);                              /* mov ds, si */
            ii(0x18_fdf0, 4); movzx(ebp, sp);                           /* movzx ebp, sp */
            ii(0x18_fdf4, 5); lea(ebp, memd_a32[ss, ebp + 0xe]);        /* lea ebp, [ebp+0xe] */
            ii(0x18_fdf9, 5); movzx(esi, memw[ss, bp + 0x8]);           /* movzx esi, word [bp+0x8] */
            ii(0x18_fdfe, 3); mov(memw[ds, si + 0x6], es);              /* mov [si+0x6], es */
            ii(0x18_fe01, 3); mov(memw[ds, si + 0x8], fs);              /* mov [si+0x8], fs */
            ii(0x18_fe04, 3); mov(memw[ds, si + 0xa], gs);              /* mov [si+0xa], gs */
            ii(0x18_fe07, 4); mov(memd[ds, si + 0x1c], ebx);            /* mov [si+0x1c], ebx */
            ii(0x18_fe0b, 4); mov(memd[ds, si + 0x24], ecx);            /* mov [si+0x24], ecx */
            ii(0x18_fe0f, 4); mov(memd[ds, si + 0x20], edx);            /* mov [si+0x20], edx */
            ii(0x18_fe13, 4); mov(memd[ds, si + 0xc], edi);             /* mov [si+0xc], edi */
            ii(0x18_fe17, 4); xchg(memd[ds, si + 0x28], eax);           /* xchg [si+0x28], eax */
            ii(0x18_fe1b, 3); cmp(ah, 0x9);                             /* cmp ah, 0x9 */
            ii(0x18_fe1e, 4); if(jnz(0x18_fe48, 0x26)) goto l_0x18_fe48; /* jnz 0xfe48 */
            ii(0x18_fe22, 4); cmp(memw[ds, si + 0x2c], 0x31);           /* cmp word [si+0x2c], 0x31 */
            ii(0x18_fe26, 4); if(jnz(0x18_fe48, 0x1e)) goto l_0x18_fe48; /* jnz 0xfe48 */
            ii(0x18_fe2a, 2); pushfd();                                 /* pushfd */
            ii(0x18_fe2c, 2); push(0);                                  /* push 0x0 */
            ii(0x18_fe2e, 1); push(cs);                                 /* push cs */
            ii(0x18_fe2f, 2); push(0);                                  /* push 0x0 */
            ii(0x18_fe31, 3); push(0x9ad);                              /* push 0x9ad */
            ii(0x18_fe34, 3); mov(ax, 0x902);                           /* mov ax, 0x902 */
            ii(0x18_fe37, 3); mov(bx, 0x2ca);                           /* mov bx, 0x2ca */
            ii(0x18_fe3a, 3); if(jmpd_far_ind(memd[ds, bx])) return;    /* jmp far dword [bx] */
            ii(0x18_fe3d, 2); popd(ebx);                                /* pop ebx */
            ii(0x18_fe3f, 3); and(bh, 0xfd);                            /* and bh, 0xfd */
            ii(0x18_fe42, 2); shl(al, 0x1);                             /* shl al, 1 */
            ii(0x18_fe44, 2); or(bh, al);                               /* or bh, al */
            ii(0x18_fe46, 2); pushd(ebx);                               /* push ebx */
        l_0x18_fe48:
            ii(0x18_fe48, 2); popd(ebx);                                /* pop ebx */
            ii(0x18_fe4a, 3); mov(al, memb[ds, si + 0x3b]);             /* mov al, [si+0x3b] */
            ii(0x18_fe4d, 2); and(al, 0x5);                             /* and al, 0x5 */
            ii(0x18_fe4f, 2); or(bh, al);                               /* or bh, al */
            ii(0x18_fe51, 4); mov(memd[ds, si + 0x3a], ebx);            /* mov [si+0x3a], ebx */
            ii(0x18_fe55, 3); pop(memw[ds, si + 0x4]);                  /* pop word [si+0x4] */
            ii(0x18_fe58, 4); popd(memd[ds, si + 0x14]);                /* pop dword [si+0x14] */
            ii(0x18_fe5c, 4); popd(memd[ds, si + 0x10]);                /* pop dword [si+0x10] */
            ii(0x18_fe60, 3); xor(eax, eax);                            /* xor eax, eax */
            ii(0x18_fe63, 1); pop(bp);                                  /* pop bp */
            ii(0x18_fe64, 1); retf();                                   /* retf */
        }
    }
}
