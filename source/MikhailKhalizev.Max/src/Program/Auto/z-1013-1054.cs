using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1054-f2eb246")]
        public void Method_1013_1054()
        {
            ii(0x1013_1054, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_1059, 5); calld(Definitions.sys_check_available_stack_size, 0x3_4cf4); /* call 0x10165d52 */
            ii(0x1013_105e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_105f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1060, 1); pushd(esi);                             /* push esi */
            ii(0x1013_1061, 1); pushd(edi);                             /* push edi */
            ii(0x1013_1062, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_1063, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1065, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_106b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_106e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_1071, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1074, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_1077, 7); mov(memb_a32[ds, 0x101b_b48f], 0);      /* mov byte [0x101bb48f], 0x0 */
            ii(0x1013_107e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_1081, 5); calld(0x1012_f003, -0x2083);            /* call 0x1012f003 */
            ii(0x1013_1086, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_1089, 4); cmp(memb_a32[ds, eax + 0x17], 0);       /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_108d, 2); if(jzd(0x1013_1098, 0x9)) goto l_0x1013_1098; /* jz 0x10131098 */
            ii(0x1013_108f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_1092, 4); cmp(memb_a32[ds, eax + 0x17], 0x1);     /* cmp byte [eax+0x17], 0x1 */
            ii(0x1013_1096, 2); if(jnzd(0x1013_10a5, 0xd)) goto l_0x1013_10a5; /* jnz 0x101310a5 */
        l_0x1013_1098:
            ii(0x1013_1098, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_109d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_10a0, 5); calld(0x1013_0c16, -0x48f);             /* call 0x10130c16 */
        l_0x1013_10a5:
            ii(0x1013_10a5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_10a7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_10a8, 1); popd(edi);                              /* pop edi */
            ii(0x1013_10a9, 1); popd(esi);                              /* pop esi */
            ii(0x1013_10aa, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_10ab, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_10ac, 1); retd();                                 /* ret */
        }
    }
}
