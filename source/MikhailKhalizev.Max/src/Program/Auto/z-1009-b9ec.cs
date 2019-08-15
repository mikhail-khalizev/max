using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c1524c5b-4477-4a60-be38-b005627820f5")]
        public void Method_1009_b9ec()
        {
            ii(0x1009_b9ec, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_b9f1, 5); calld(Definitions.sys_check_available_stack_size, 0xc_a35c); /* call 0x10165d52 */
            ii(0x1009_b9f6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_b9f7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_b9f8, 1); pushd(esi);                             /* push esi */
            ii(0x1009_b9f9, 1); pushd(edi);                             /* push edi */
            ii(0x1009_b9fa, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_b9fb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b9fd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_ba03, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_ba06, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_ba09, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_ba0e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_ba11, 5); calld(Definitions.my_dtor_0x101b6edc, 0x9_f22f); /* call 0x1013ac45 */
            ii(0x1009_ba16, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_ba19, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_ba1c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_ba1f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_ba22, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_ba24, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_ba25, 1); popd(edi);                              /* pop edi */
            ii(0x1009_ba26, 1); popd(esi);                              /* pop esi */
            ii(0x1009_ba27, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_ba28, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_ba29, 1); retd(); return;                         /* ret */
        }
    }
}
