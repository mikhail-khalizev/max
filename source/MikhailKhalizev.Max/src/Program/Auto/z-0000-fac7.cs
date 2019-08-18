using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xfac7-bbb4ada1")]
        public void Method_0000_fac7()
        {
            ii(0xfac7, 2);    pushd(ebx);                               /* push ebx */
            ii(0xfac9, 4);    mov(ebx, memd_a16[ss, bp + 0x4]);         /* mov ebx, [bp+0x4] */
            ii(0xfacd, 2);    pushd(esi);                               /* push esi */
            ii(0xfacf, 4);    shl(ebx, 0x4);                            /* shl ebx, 0x4 */
            ii(0xfad3, 5);    movzx(esi, memw_a16[ss, bp + 0x8]);       /* movzx esi, word [bp+0x8] */
            ii(0xfad8, 4);    mov(es, memw_a16[ds, 0xc2e]);             /* mov es, [0xc2e] */
            ii(0xfadc, 5);    mov(ax, memw_a32[es, ebx + esi]);         /* mov ax, [es:ebx+esi] */
            ii(0xfae1, 6);    mov(dx, memw_a32[es, ebx + esi + 0x2]);   /* mov dx, [es:ebx+esi+0x2] */
            ii(0xfae7, 2);    popd(esi);                                /* pop esi */
            ii(0xfae9, 2);    popd(ebx);                                /* pop ebx */
            ii(0xfaeb, 1);    popw(bp);                                 /* pop bp */
            ii(0xfaec, 1);    retw(); return;                           /* ret */
        }
    }
}
