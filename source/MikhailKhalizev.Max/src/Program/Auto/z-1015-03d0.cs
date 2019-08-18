using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_03d0-3efa5f59")]
        public void Method_1015_03d0()
        {
            ii(0x1015_03d0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_03d5, 5); calld(Definitions.sys_check_available_stack_size, 0x1_5978); /* call 0x10165d52 */
            ii(0x1015_03da, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_03db, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_03dc, 1); pushd(edx);                             /* push edx */
            ii(0x1015_03dd, 1); pushd(esi);                             /* push esi */
            ii(0x1015_03de, 1); pushd(edi);                             /* push edi */
            ii(0x1015_03df, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_03e0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_03e2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_03e8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_03eb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_03ee, 5); calld(0x1015_14ef, 0x10fc);             /* call 0x101514ef */
            ii(0x1015_03f3, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_03f6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_03f9, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_03fc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_03ff, 5); calld(0x1007_1e00, -0xd_e604);          /* call 0x10071e00 */
            ii(0x1015_0404, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_0407, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_040a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_040c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_040d, 1); popd(edi);                              /* pop edi */
            ii(0x1015_040e, 1); popd(esi);                              /* pop esi */
            ii(0x1015_040f, 1); popd(edx);                              /* pop edx */
            ii(0x1015_0410, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_0411, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_0412, 1); retd(); return;                         /* ret */
        }
    }
}
