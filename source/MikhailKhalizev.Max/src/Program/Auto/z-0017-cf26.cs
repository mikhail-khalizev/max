using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_cf26-b0d5dc6d")]
        public void Method_0017_cf26()
        {
            ii(0x17_cf26, 1);  pop(bx);                                /* pop bx */
            ii(0x17_cf27, 1);  push(ds);                               /* push ds */
            ii(0x17_cf28, 1);  pop(es);                                /* pop es */
            ii(0x17_cf29, 3);  mov(bp, 0x50c4);                        /* mov bp, 0x50c4 */
            ii(0x17_cf2c, 5);  les(ebp, memd[es, bp + 117]);           /* les ebp, [es:bp+0x75] */
            ii(0x17_cf31, 6);  mov(ebp, memd_a32[es, ebp]);            /* mov ebp, [es:ebp] */
            ii(0x17_cf37, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_cf3a, 5);  pop(memw_a32[es, ebp]);                 /* pop word [es:ebp] */
            ii(0x17_cf3f, 5);  pop(memw_a32[es, ebp + 2]);             /* pop word [es:ebp+0x2] */
            ii(0x17_cf44, 6);  pop(memd_a32[es, ebp + 4]);             /* pop dword [es:ebp+0x4] */
            ii(0x17_cf4a, 6);  pop(memd_a32[es, ebp + 8]);             /* pop dword [es:ebp+0x8] */
            ii(0x17_cf50, 6);  pop(memd_a32[es, ebp + 12]);            /* pop dword [es:ebp+0xc] */
            ii(0x17_cf56, 6);  pop(memd_a32[es, ebp + 16]);            /* pop dword [es:ebp+0x10] */
            ii(0x17_cf5c, 6);  pop(memd_a32[es, ebp + 20]);            /* pop dword [es:ebp+0x14] */
            ii(0x17_cf62, 6);  pop(memd_a32[es, ebp + 24]);            /* pop dword [es:ebp+0x18] */
            ii(0x17_cf68, 6);  pop(memd_a32[es, ebp + 28]);            /* pop dword [es:ebp+0x1c] */
            ii(0x17_cf6e, 6);  pop(memd_a32[es, ebp + 32]);            /* pop dword [es:ebp+0x20] */
            ii(0x17_cf74, 6);  pop(memd_a32[es, ebp + 36]);            /* pop dword [es:ebp+0x24] */
            ii(0x17_cf7a, 6);  pop(memd_a32[es, ebp + 40]);            /* pop dword [es:ebp+0x28] */
            ii(0x17_cf80, 6);  pop(memd_a32[es, ebp + 44]);            /* pop dword [es:ebp+0x2c] */
            ii(0x17_cf86, 1);  cli();                                  /* cli */
            ii(0x17_cf87, 2);  mov(bp, es);                            /* mov bp, es */
            ii(0x17_cf89, 2);  mov(ss, bp);                            /* mov ss, bp */
            ii(0x17_cf8b, 2);  mov(bp, ds);                            /* mov bp, ds */
            ii(0x17_cf8d, 2);  mov(es, bp);                            /* mov es, bp */
            ii(0x17_cf8f, 3);  mov(bp, 0x50c4);                        /* mov bp, 0x50c4 */
            ii(0x17_cf92, 5);  mov(esp, memd[es, bp + 117]);           /* mov esp, [es:bp+0x75] */
            ii(0x17_cf97, 2);  pop(ebp);                               /* pop ebp */
            ii(0x17_cf99, 2);  jmp_abs(bx);                            /* jmp bx */
        }
    }
}
