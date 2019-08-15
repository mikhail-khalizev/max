using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4c889de9-9498-4f49-aec2-91bd61ccdd7f")]
        public void Method_1012_0704()
        {
            ii(0x1012_0704, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_0709, 5); calld(Definitions.sys_check_available_stack_size, 0x4_5644); /* call 0x10165d52 */
            ii(0x1012_070e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_070f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0710, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0711, 1); pushd(edi);                             /* push edi */
            ii(0x1012_0712, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_0713, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0715, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_071b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_071e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_0721, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_0724, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0727, 5); calld(0x1007_6cd0, -0xa_9a5c);          /* call 0x10076cd0 */
            ii(0x1012_072c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_072f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1012_0732, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_0735, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0738, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_073b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_073e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0740, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0741, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0742, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0743, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0744, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0745, 1); retd(); return;                         /* ret */
        }
    }
}
