using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f86fca38-97cf-4083-9bc1-371d0e3b048d")]
        public void Method_1012_3160()
        {
            ii(0x1012_3160, 4); cmp(memd_a32[ss, ebp - 0x18], 0x3f);    /* cmp dword [ebp-0x18], 0x3f */
            ii(0x1012_3164, 2); if(jbd(0x1012_31aa, 0x44)) goto l_0x1012_31aa; /* jb 0x101231aa */
            ii(0x1012_3166, 4); cmp(memd_a32[ss, ebp - 0x18], 0x3f);    /* cmp dword [ebp-0x18], 0x3f */
            ii(0x1012_316a, 6); if(jbed_func(0x1012_2a22, -0x74e)) return; /* jbe 0x10122a22 */
            ii(0x1012_3170, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3e8);   /* cmp dword [ebp-0x18], 0x3e8 */
            ii(0x1012_3177, 2); if(jbd(0x1012_3198, 0x1f)) goto l_0x1012_3198; /* jb 0x10123198 */
            ii(0x1012_3179, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3e8);   /* cmp dword [ebp-0x18], 0x3e8 */
            ii(0x1012_3180, 6); if(jbed_func(0x1012_2a95, -0x6f1)) return; /* jbe 0x10122a95 */
            ii(0x1012_3186, 7); cmp(memd_a32[ss, ebp - 0x18], 0x3e9);   /* cmp dword [ebp-0x18], 0x3e9 */
            ii(0x1012_318d, 6); if(jzd_func(0x1012_2ca2, -0x4f1)) return; /* jz 0x10122ca2 */
            ii(0x1012_3193, 5); if(jmpd_func(0x1012_2e0a, -0x38e)) return; /* jmp 0x10122e0a */
        l_0x1012_3198:
            ii(0x1012_3198, 7); cmp(memd_a32[ss, ebp - 0x18], 0x119);   /* cmp dword [ebp-0x18], 0x119 */
            ii(0x1012_319f, 6); if(jzd_func(0x1012_2a18, -0x78d)) return; /* jz 0x10122a18 */
            ii(0x1012_31a5, 5); if(jmpd_func(0x1012_2e0a, -0x3a0)) return; /* jmp 0x10122e0a */
        l_0x1012_31aa:
            ii(0x1012_31aa, 4); cmp(memd_a32[ss, ebp - 0x18], 0xd);     /* cmp dword [ebp-0x18], 0xd */
            ii(0x1012_31ae, 2); if(jbd(0x1012_31c9, 0x19)) goto l_0x1012_31c9; /* jb 0x101231c9 */
            ii(0x1012_31b0, 4); cmp(memd_a32[ss, ebp - 0x18], 0xd);     /* cmp dword [ebp-0x18], 0xd */
            ii(0x1012_31b4, 6); if(jbed_func(0x1012_2a82, -0x738)) return; /* jbe 0x10122a82 */
            ii(0x1012_31ba, 4); cmp(memd_a32[ss, ebp - 0x18], 0x1b);    /* cmp dword [ebp-0x18], 0x1b */
            ii(0x1012_31be, 6); if(jzd_func(0x1012_2c8f, -0x535)) return; /* jz 0x10122c8f */
            ii(0x1012_31c4, 5); if(jmpd_func(0x1012_2e0a, -0x3bf)) return; /* jmp 0x10122e0a */
        l_0x1012_31c9:
            ii(0x1012_31c9, 5); if(jmpd_func(0x1012_2e0a, -0x3c4)) return; /* jmp 0x10122e0a */
        }
    }
}
