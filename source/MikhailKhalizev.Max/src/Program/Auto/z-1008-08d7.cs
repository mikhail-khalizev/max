using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("437090a3-ca2e-4c1e-8885-2052da862122")]
        public void Method_1008_08d7()
        {
            ii(0x1008_08d7, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_08dc, 5); calld(Definitions.sys_check_available_stack_size, 0xe_5471); /* call 0x10165d52 */
            ii(0x1008_08e1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_08e2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_08e3, 1); pushd(esi);                             /* push esi */
            ii(0x1008_08e4, 1); pushd(edi);                             /* push edi */
            ii(0x1008_08e5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_08e6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_08e8, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_08ee, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_08f1, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_08f4, 5); mov(edx, StringDefinitions.PlaceMines); /* mov edx, 0x101a0205 */
            ii(0x1008_08f9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_08fc, 5); calld(Definitions.sys_strcpy, 0xe_55ce); /* call 0x10165ecf */
            ii(0x1008_0901, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_0904, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_0907, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_090a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_090c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_090d, 1); popd(edi);                              /* pop edi */
            ii(0x1008_090e, 1); popd(esi);                              /* pop esi */
            ii(0x1008_090f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_0910, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_0911, 1); retd(); return;                         /* ret */
        }
    }
}
