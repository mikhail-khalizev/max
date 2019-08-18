using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_3ee4-188792b2")]
        public void Method_100f_3ee4()
        {
            ii(0x100f_3ee4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_3ee6, 5); mov(eax, 0x101c_38b4);                  /* mov eax, 0x101c38b4 */
            ii(0x100f_3eeb, 5); calld(0x1013_ad71, 0x4_6e81);           /* call 0x1013ad71 */
            ii(0x100f_3ef0, 2); test(al, al);                           /* test al, al */
            ii(0x100f_3ef2, 2); if(jzd(0x100f_3f04, 0x10)) goto l_0x100f_3f04; /* jz 0x100f3f04 */
            ii(0x100f_3ef4, 5); mov(edx, StringDefinitions.PressF1);    /* mov edx, 0x101a2506 */
            ii(0x100f_3ef9, 6); lea(eax, ebp - 0x148);                  /* lea eax, [ebp-0x148] */
            ii(0x100f_3eff, 5); calld(Definitions.sys_strcat, 0x7_202d); /* call 0x10165f31 */
        l_0x100f_3f04:
            ii(0x100f_3f04, 6); mov(ebx, memd_a32[ds, 0x101c_38b8]);    /* mov ebx, [0x101c38b8] */
            ii(0x100f_3f0a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_3f0d, 6); mov(edx, memd_a32[ds, 0x101c_38b6]);    /* mov edx, [0x101c38b6] */
            ii(0x100f_3f13, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_3f16, 6); lea(eax, ebp - 0x158);                  /* lea eax, [ebp-0x158] */
            ii(0x100f_3f1c, 5); calld(0x1007_6aac, -0x7_d475);          /* call 0x10076aac */
            ii(0x100f_3f21, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x100f_3f23, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100f_3f26, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100f_3f2b, 6); lea(eax, ebp - 0x148);                  /* lea eax, [ebp-0x148] */
            ii(0x100f_3f31, 5); calld(0x1011_5b60, 0x2_1c2a);           /* call 0x10115b60 */
            ii(0x100f_3f36, 5); cmp(memw_a32[ss, ebp - 0x10], -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x100f_3f3b, 2); if(jzd(0x100f_3f5a, 0x1d)) goto l_0x100f_3f5a; /* jz 0x100f3f5a */
            ii(0x100f_3f3d, 5); calld(0x100d_5470, -0x1_ead2);          /* call 0x100d5470 */
            ii(0x100f_3f42, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_3f45, 7); movsx(ebx, memw_a32[ss, ebp - 0x14c]);  /* movsx ebx, word [ebp-0x14c] */
            ii(0x100f_3f4c, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100f_3f50, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_3f55, 5); calld(0x1013_daea, 0x4_9b90);           /* call 0x1013daea */
        l_0x100f_3f5a:
            ii(0x100f_3f5a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_3f5c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_3f5d, 1); popd(edi);                              /* pop edi */
            ii(0x100f_3f5e, 1); popd(esi);                              /* pop esi */
            ii(0x100f_3f5f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_3f60, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_3f61, 1); retd(); return;                         /* ret */
        }
    }
}
