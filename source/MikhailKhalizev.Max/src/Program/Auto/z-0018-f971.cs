using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f971-15f0a580")]
        public void Method_0018_f971()
        {
            ii(0x18_f971, 4); mov(memw[ds, 0xa4e], ss);                 /* mov [0xa4e], ss */
            ii(0x18_f975, 5); mov(memd[ds, 0xa4a], esp);                /* mov [0xa4a], esp */
            ii(0x18_f97a, 2); mov(si, ds);                              /* mov si, ds */
            ii(0x18_f97c, 2); mov(ss, si);                              /* mov ss, si */
            ii(0x18_f97e, 5); mov(esp, memd[ds, 0xa46]);                /* mov esp, [0xa46] */
            ii(0x18_f983, 5); lds(esi, ds, 0xa4a);                      /* lds esi, [0xa4a] */
            ii(0x18_f988, 5); pushd(memd_a32[ds, esi + 0x14]);          /* push dword [esi+0x14] */
            ii(0x18_f98d, 5); pushd(memd_a32[ds, esi + 0x10]);          /* push dword [esi+0x10] */
            ii(0x18_f992, 5); pushd(memd_a32[ds, esi + 0xc]);           /* push dword [esi+0xc] */
            ii(0x18_f997, 5); pushd(memd_a32[ds, esi + 0x8]);           /* push dword [esi+0x8] */
            ii(0x18_f99c, 1); push(ax);                                 /* push ax */
            ii(0x18_f99d, 2); pushad();                                 /* pushad */
            ii(0x18_f99f, 4); mov(edx, memd_a32[ds, esi]);              /* mov edx, [esi] */
            ii(0x18_f9a3, 4); mov(bx, memw_a32[ds, esi + 0x6]);         /* mov bx, [esi+0x6] */
            ii(0x18_f9a7, 2); push(gs);                                 /* push gs */
            ii(0x18_f9a9, 2); push(fs);                                 /* push fs */
            ii(0x18_f9ab, 1); push(es);                                 /* push es */
            ii(0x18_f9ac, 4); push(memw_a32[ds, esi + 0x4]);            /* push word [esi+0x4] */
            ii(0x18_f9b0, 1); push(ds);                                 /* push ds */
            ii(0x18_f9b1, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x18_f9b3, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x18_f9b5, 4); push(memw[ds, 0xa42]);                    /* push word [0xa42] */
            ii(0x18_f9b9, 4); movzx(ebp, sp);                           /* movzx ebp, sp */
            ii(0x18_f9bd, 3); mov(al, memb[cs, bx]);                    /* mov al, [cs:bx] */
            ii(0x18_f9c0, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x18_f9c2, 4); mov(memw_a32[ss, ebp + 0x2c], ax);        /* mov [ebp+0x2c], ax */
            ii(0x18_f9c6, 5); mov(memd_a32[ss, ebp + 0x18], esi);       /* mov [ebp+0x18], esi */
            ii(0x18_f9cb, 5); mov(memd_a32[ss, ebp + 0x10], edx);       /* mov [ebp+0x10], edx */
            ii(0x18_f9d0, 5); mov(memd[ds, 0xa42], ebp);                /* mov [0xa42], ebp */
            ii(0x18_f9d5, 1); push(ss);                                 /* push ss */
            ii(0x18_f9d6, 1); push(bp);                                 /* push bp */
            ii(0x18_f9d7, 5); call_far_abs(0x88, 0x34ac);               /* call word 0x88:0x34ac */
        }
    }
}
