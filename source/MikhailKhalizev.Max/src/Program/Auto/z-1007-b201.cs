using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4bd039b0-ff39-46e0-a197-ec50dbdedf4d")]
        public void Method_1007_b201()
        {
            ii(0x1007_b201, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_b206, 5); calld(Definitions.sys_check_available_stack_size, 0xe_ab47); /* call 0x10165d52 */
            ii(0x1007_b20b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_b20c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_b20d, 1); pushd(edx);                             /* push edx */
            ii(0x1007_b20e, 1); pushd(esi);                             /* push esi */
            ii(0x1007_b20f, 1); pushd(edi);                             /* push edi */
            ii(0x1007_b210, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_b211, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_b213, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_b219, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_b21c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b21f, 3); add(eax, 0x2d);                         /* add eax, 0x2d */
            ii(0x1007_b222, 5); calld(0x1008_a4a0, 0xf279);             /* call 0x1008a4a0 */
            ii(0x1007_b227, 1); cwde();                                 /* cwde */
            ii(0x1007_b228, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_b22b, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1007_b22e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_b231, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_b234, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_b236, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_b237, 1); popd(edi);                              /* pop edi */
            ii(0x1007_b238, 1); popd(esi);                              /* pop esi */
            ii(0x1007_b239, 1); popd(edx);                              /* pop edx */
            ii(0x1007_b23a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_b23b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_b23c, 1); retd(); return;                         /* ret */
        }
    }
}
