using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e4e55bb1-4040-41f1-8d02-d3d2590482f1")]
        public void Method_1012_030c()
        {
            ii(0x1012_030c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_0311, 5); calld(Definitions.sys_check_available_stack_size, 0x45a3c); /* call 0x10165d52 */
            ii(0x1012_0316, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_0317, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0318, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0319, 1); pushd(edi);                             /* push edi */
            ii(0x1012_031a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_031b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_031d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_0323, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0326, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_0329, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_032e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0331, 5); calld(Definitions.my_dtor_0x101b6edc, 0x1a90f); /* call 0x1013ac45 */
            ii(0x1012_0336, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0339, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_033c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_033f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_0342, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0344, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0345, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0346, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0347, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0348, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0349, 1); retd(); return;                         /* ret */
        }
    }
}