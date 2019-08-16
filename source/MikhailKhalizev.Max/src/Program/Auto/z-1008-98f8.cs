using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("caf5f13c-5d22-4f3a-80bb-15fe07318ac5")]
        public void Method_1008_98f8()
        {
            ii(0x1008_98f8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_98fd, 5); calld(Definitions.sys_check_available_stack_size, 0xd_c450); /* call 0x10165d52 */
            ii(0x1008_9902, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9903, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9904, 1); pushd(edx);                             /* push edx */
            ii(0x1008_9905, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9906, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9907, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9908, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_990a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_9910, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_9913, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_9916, 3); mov(eax, memd_a32[ds, eax + 0x3a]);     /* mov eax, [eax+0x3a] */
            ii(0x1008_9919, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_991c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_991f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9921, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9922, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9923, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9924, 1); popd(edx);                              /* pop edx */
            ii(0x1008_9925, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9926, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9927, 1); retd(); return;                         /* ret */
        }
    }
}