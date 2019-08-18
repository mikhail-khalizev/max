using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("76a5b707-5c48-4ce5-b8ee-d7c61d7efdb3")]
        public void Method_0001_1ad7()
        {
            ii(0x1_1ad7, 2);  pushd(ebx);                               /* push ebx */
            ii(0x1_1ad9, 4);  mov(ebx, memd_a16[ss, bp + 0x4]);         /* mov ebx, [bp+0x4] */
            ii(0x1_1add, 2);  pushd(esi);                               /* push esi */
            ii(0x1_1adf, 4);  shl(ebx, 0x4);                            /* shl ebx, 0x4 */
            ii(0x1_1ae3, 5);  movzx(esi, memw_a16[ss, bp + 0x8]);       /* movzx esi, word [bp+0x8] */
            ii(0x1_1ae8, 4);  mov(es, memw_a16[ds, 0xc2e]);             /* mov es, [0xc2e] */
            ii(0x1_1aec, 5);  mov(ax, memw_a32[es, ebx + esi]);         /* mov ax, [es:ebx+esi] */
            ii(0x1_1af1, 6);  mov(dx, memw_a32[es, ebx + esi + 0x2]);   /* mov dx, [es:ebx+esi+0x2] */
            ii(0x1_1af7, 2);  popd(esi);                                /* pop esi */
            ii(0x1_1af9, 2);  popd(ebx);                                /* pop ebx */
            ii(0x1_1afb, 1);  popw(bp);                                 /* pop bp */
            ii(0x1_1afc, 1);  retw(); return;                           /* ret */
        }
    }
}
