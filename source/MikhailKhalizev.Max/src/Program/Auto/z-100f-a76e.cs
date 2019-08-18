using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("95125a35-6946-4a95-86c5-93bfe3e3d827")]
        public void Method_100f_a76e()
        {
            ii(0x100f_a76e, 3); mov(al, memb_a32[ss, ebp - 0x40]);      /* mov al, [ebp-0x40] */
            ii(0x100f_a771, 3); mov(memb_a32[ss, ebp - 0x80], al);      /* mov [ebp-0x80], al */
            ii(0x100f_a774, 4); cmp(memb_a32[ss, ebp - 0x80], 0x16);    /* cmp byte [ebp-0x80], 0x16 */
            ii(0x100f_a778, 2); if(jbd(0x100f_a7b7, 0x3d)) goto l_0x100f_a7b7; /* jb 0x100fa7b7 */
            ii(0x100f_a77a, 4); cmp(memb_a32[ss, ebp - 0x80], 0x16);    /* cmp byte [ebp-0x80], 0x16 */
            ii(0x100f_a77e, 6); if(jbed_func(0x100f_9bf8, -0xb8c)) return; /* jbe 0x100f9bf8 */
            ii(0x100f_a784, 4); cmp(memb_a32[ss, ebp - 0x80], 0x18);    /* cmp byte [ebp-0x80], 0x18 */
            ii(0x100f_a788, 2); if(jbd(0x100f_a7b2, 0x28)) goto l_0x100f_a7b2; /* jb 0x100fa7b2 */
            ii(0x100f_a78a, 4); cmp(memb_a32[ss, ebp - 0x80], 0x18);    /* cmp byte [ebp-0x80], 0x18 */
            ii(0x100f_a78e, 6); if(jbed_func(0x100f_9c1f, -0xb75)) return; /* jbe 0x100f9c1f */
            ii(0x100f_a794, 4); cmp(memb_a32[ss, ebp - 0x80], 0x23);    /* cmp byte [ebp-0x80], 0x23 */
            ii(0x100f_a798, 2); if(jbd(0x100f_a7b0, 0x16)) goto l_0x100f_a7b0; /* jb 0x100fa7b0 */
            ii(0x100f_a79a, 4); cmp(memb_a32[ss, ebp - 0x80], 0x23);    /* cmp byte [ebp-0x80], 0x23 */
            ii(0x100f_a79e, 6); if(jbed_func(0x100f_9cd9, -0xacb)) return; /* jbe 0x100f9cd9 */
            ii(0x100f_a7a4, 4); cmp(memb_a32[ss, ebp - 0x80], 0x26);    /* cmp byte [ebp-0x80], 0x26 */
            ii(0x100f_a7a8, 6); if(jzd_func(0x100f_9e15, -0x999)) return; /* jz 0x100f9e15 */
            ii(0x100f_a7ae, 2); if(jmpd_func(0x100f_a762, -0x4e)) return; /* jmp 0x100fa762 */
        l_0x100f_a7b0:
            ii(0x100f_a7b0, 2); if(jmpd_func(0x100f_a762, -0x50)) return; /* jmp 0x100fa762 */
        l_0x100f_a7b2:
            ii(0x100f_a7b2, 5); if(jmpd_func(0x100f_9c44, -0xb73)) return; /* jmp 0x100f9c44 */
        l_0x100f_a7b7:
            ii(0x100f_a7b7, 4); cmp(memb_a32[ss, ebp - 0x80], 0x2);     /* cmp byte [ebp-0x80], 0x2 */
            ii(0x100f_a7bb, 2); if(jbd(0x100f_a7d3, 0x16)) goto l_0x100f_a7d3; /* jb 0x100fa7d3 */
            ii(0x100f_a7bd, 4); cmp(memb_a32[ss, ebp - 0x80], 0x2);     /* cmp byte [ebp-0x80], 0x2 */
            ii(0x100f_a7c1, 6); if(jbed_func(0x100f_9bab, -0xc1c)) return; /* jbe 0x100f9bab */
            ii(0x100f_a7c7, 4); cmp(memb_a32[ss, ebp - 0x80], 0x6);     /* cmp byte [ebp-0x80], 0x6 */
            ii(0x100f_a7cb, 6); if(jzd_func(0x100f_9bbe, -0xc13)) return; /* jz 0x100f9bbe */
            ii(0x100f_a7d1, 2); if(jmpd_func(0x100f_a762, -0x71)) return; /* jmp 0x100fa762 */
        l_0x100f_a7d3:
            ii(0x100f_a7d3, 4); cmp(memb_a32[ss, ebp - 0x80], 0x1);     /* cmp byte [ebp-0x80], 0x1 */
            ii(0x100f_a7d7, 6); if(jzd_func(0x100f_9ba6, -0xc37)) return; /* jz 0x100f9ba6 */
            ii(0x100f_a7dd, 2); if(jmpd_func(0x100f_a762, -0x7d)) return; /* jmp 0x100fa762 */
        }
    }
}
