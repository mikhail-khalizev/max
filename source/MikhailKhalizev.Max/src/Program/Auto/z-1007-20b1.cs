using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_20b1-2e0c9a47")]
        public void Method_1007_20b1()
        {
            ii(0x1007_20b1, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_20b6, 5); calld(Definitions.sys_check_available_stack_size, 0xf_3c97); /* call 0x10165d52 */
            ii(0x1007_20bb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_20bc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_20bd, 1); pushd(edx);                             /* push edx */
            ii(0x1007_20be, 1); pushd(esi);                             /* push esi */
            ii(0x1007_20bf, 1); pushd(edi);                             /* push edi */
            ii(0x1007_20c0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_20c1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_20c3, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_20c9, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_20cc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_20cf, 5); calld(0x1007_20e6, 0x12);               /* call 0x100720e6 */
            ii(0x1007_20d4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_20d7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_20da, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_20dd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_20df, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_20e0, 1); popd(edi);                              /* pop edi */
            ii(0x1007_20e1, 1); popd(esi);                              /* pop esi */
            ii(0x1007_20e2, 1); popd(edx);                              /* pop edx */
            ii(0x1007_20e3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_20e4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_20e5, 1); retd(); return;                         /* ret */
        }
    }
}
