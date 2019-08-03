using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("835c3715-a2bc-466a-998e-f310835982db")]
        public void Method_1008_9ef8()
        {
            ii(0x1008_9ef8, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_9efd, 5); calld(Definitions.sys_check_available_stack_size, 0xdbe50); /* call 0x10165d52 */
            ii(0x1008_9f02, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9f03, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9f04, 1); pushd(edx);                             /* push edx */
            ii(0x1008_9f05, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9f06, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9f07, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9f08, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9f0a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_9f10, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_9f13, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_9f16, 5); calld(Definitions.my_ctor_0x101b6edc, -0x130d7); /* call 0x10076e44 */
            ii(0x1008_9f1b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_9f1e, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1008_9f21, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9f24, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_9f27, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_9f2a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_9f2d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9f2f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9f30, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9f31, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9f32, 1); popd(edx);                              /* pop edx */
            ii(0x1008_9f33, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9f34, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9f35, 1); retd(); return;                         /* ret */
        }
    }
}