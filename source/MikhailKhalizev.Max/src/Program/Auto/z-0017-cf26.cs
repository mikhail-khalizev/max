using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_cf26-b0d5dc6d")]
        public void Method_0017_cf26()
        {
            ii(0x17_cf26, 1); popw(bx);                                 /* pop bx */
            ii(0x17_cf27, 1); pushw(ds);                                /* push ds */
            ii(0x17_cf28, 1); popw(es);                                 /* pop es */
            ii(0x17_cf29, 3); mov(bp, 0x50c4);                          /* mov bp, 0x50c4 */
            ii(0x17_cf2c, 5); les(ebp, es, bp + 0x75);                  /* les ebp, [es:bp+0x75] */
            ii(0x17_cf31, 6); mov(ebp, memd_a32[es, ebp + 0]);          /* mov ebp, [es:ebp] */
            ii(0x17_cf37, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_cf3a, 5); popw(memw_a32[es, ebp + 0]);              /* pop word [es:ebp] */
            ii(0x17_cf3f, 5); popw(memw_a32[es, ebp + 0x2]);            /* pop word [es:ebp+0x2] */
            ii(0x17_cf44, 6); popd(memd_a32[es, ebp + 0x4]);            /* pop dword [es:ebp+0x4] */
            ii(0x17_cf4a, 6); popd(memd_a32[es, ebp + 0x8]);            /* pop dword [es:ebp+0x8] */
            ii(0x17_cf50, 6); popd(memd_a32[es, ebp + 0xc]);            /* pop dword [es:ebp+0xc] */
            ii(0x17_cf56, 6); popd(memd_a32[es, ebp + 0x10]);           /* pop dword [es:ebp+0x10] */
            ii(0x17_cf5c, 6); popd(memd_a32[es, ebp + 0x14]);           /* pop dword [es:ebp+0x14] */
            ii(0x17_cf62, 6); popd(memd_a32[es, ebp + 0x18]);           /* pop dword [es:ebp+0x18] */
            ii(0x17_cf68, 6); popd(memd_a32[es, ebp + 0x1c]);           /* pop dword [es:ebp+0x1c] */
            ii(0x17_cf6e, 6); popd(memd_a32[es, ebp + 0x20]);           /* pop dword [es:ebp+0x20] */
            ii(0x17_cf74, 6); popd(memd_a32[es, ebp + 0x24]);           /* pop dword [es:ebp+0x24] */
            ii(0x17_cf7a, 6); popd(memd_a32[es, ebp + 0x28]);           /* pop dword [es:ebp+0x28] */
            ii(0x17_cf80, 6); popd(memd_a32[es, ebp + 0x2c]);           /* pop dword [es:ebp+0x2c] */
            ii(0x17_cf86, 1); cli();                                    /* cli */
            ii(0x17_cf87, 2); mov(bp, es);                              /* mov bp, es */
            ii(0x17_cf89, 2); mov(ss, bp);                              /* mov ss, bp */
            ii(0x17_cf8b, 2); mov(bp, ds);                              /* mov bp, ds */
            ii(0x17_cf8d, 2); mov(es, bp);                              /* mov es, bp */
            ii(0x17_cf8f, 3); mov(bp, 0x50c4);                          /* mov bp, 0x50c4 */
            ii(0x17_cf92, 5); mov(esp, memd_a16[es, bp + 0x75]);        /* mov esp, [es:bp+0x75] */
            ii(0x17_cf97, 2); popd(ebp);                                /* pop ebp */
            ii(0x17_cf99, 2); jmpw_abs(bx);                             /* jmp bx */
        }
    }
}
