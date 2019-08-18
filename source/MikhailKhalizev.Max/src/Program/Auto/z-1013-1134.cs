using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("16d765a6-66c6-449d-bc36-6e79696f51de")]
        public void Method_1013_1134()
        {
            ii(0x1013_1134, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_1139, 5); calld(Definitions.sys_check_available_stack_size, 0x3_4c14); /* call 0x10165d52 */
            ii(0x1013_113e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_113f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1140, 1); pushd(esi);                             /* push esi */
            ii(0x1013_1141, 1); pushd(edi);                             /* push edi */
            ii(0x1013_1142, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_1143, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1145, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_114b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_114e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_1151, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1154, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_1157, 7); mov(memb_a32[ds, 0x101c_61b0], 0);      /* mov byte [0x101c61b0], 0x0 */
            ii(0x1013_115e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_1161, 5); calld(0x1012_f003, -0x2163);            /* call 0x1012f003 */
            ii(0x1013_1166, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_1169, 4); cmp(memb_a32[ds, eax + 0x17], 0);       /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_116d, 2); if(jzd(0x1013_1178, 0x9)) goto l_0x1013_1178; /* jz 0x10131178 */
            ii(0x1013_116f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_1172, 4); cmp(memb_a32[ds, eax + 0x17], 0x1);     /* cmp byte [eax+0x17], 0x1 */
            ii(0x1013_1176, 2); if(jnzd(0x1013_1185, 0xd)) goto l_0x1013_1185; /* jnz 0x10131185 */
        l_0x1013_1178:
            ii(0x1013_1178, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_117d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_1180, 5); calld(0x1013_0c16, -0x56f);             /* call 0x10130c16 */
        l_0x1013_1185:
            ii(0x1013_1185, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1187, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_1188, 1); popd(edi);                              /* pop edi */
            ii(0x1013_1189, 1); popd(esi);                              /* pop esi */
            ii(0x1013_118a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_118b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_118c, 1); retd(); return;                         /* ret */
        }
    }
}
