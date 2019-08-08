using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("94d64faf-c85e-4ab9-948e-0fa675cdd046")]
        public void Method_1007_20e6()
        {
            ii(0x1007_20e6, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1007_20eb, 5); calld(Definitions.sys_check_available_stack_size, 0xf_3c62); /* call 0x10165d52 */
            ii(0x1007_20f0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_20f1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_20f2, 1); pushd(edx);                             /* push edx */
            ii(0x1007_20f3, 1); pushd(esi);                             /* push esi */
            ii(0x1007_20f4, 1); pushd(edi);                             /* push edi */
            ii(0x1007_20f5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_20f6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_20f8, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1007_20fe, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_2101, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_2104, 5); mov(memw_a32[ds, eax], 0);              /* mov word [eax], 0x0 */
            ii(0x1007_2109, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_210c, 6); mov(memw_a32[ds, eax + 0x2], 0);        /* mov word [eax+0x2], 0x0 */
            ii(0x1007_2112, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_2115, 6); mov(memw_a32[ds, eax + 0x4], 0);        /* mov word [eax+0x4], 0x0 */
            ii(0x1007_211b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_211e, 6); mov(memw_a32[ds, eax + 0x6], 0);        /* mov word [eax+0x6], 0x0 */
            ii(0x1007_2124, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_2127, 6); mov(memw_a32[ds, eax + 0x8], 0);        /* mov word [eax+0x8], 0x0 */
            ii(0x1007_212d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_2130, 6); mov(memw_a32[ds, eax + 0xa], 0);        /* mov word [eax+0xa], 0x0 */
            ii(0x1007_2136, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_2138, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_2139, 1); popd(edi);                              /* pop edi */
            ii(0x1007_213a, 1); popd(esi);                              /* pop esi */
            ii(0x1007_213b, 1); popd(edx);                              /* pop edx */
            ii(0x1007_213c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_213d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_213e, 1); retd(); return;                         /* ret */
        }
    }
}
