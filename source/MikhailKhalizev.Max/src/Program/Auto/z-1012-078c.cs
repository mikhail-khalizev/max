using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_078c-fb1012a2")]
        public void Method_1012_078c()
        {
            ii(0x1012_078c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_0791, 5); calld(Definitions.sys_check_available_stack_size, 0x4_55bc); /* call 0x10165d52 */
            ii(0x1012_0796, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_0797, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0798, 1); pushd(edx);                             /* push edx */
            ii(0x1012_0799, 1); pushd(esi);                             /* push esi */
            ii(0x1012_079a, 1); pushd(edi);                             /* push edi */
            ii(0x1012_079b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_079c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_079e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_07a4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_07a7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_07aa, 5); calld(0x1007_6d58, -0xa_9a57);          /* call 0x10076d58 */
            ii(0x1012_07af, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_07b2, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1012_07b5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_07b8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_07bb, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_07be, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_07c1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_07c3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_07c4, 1); popd(edi);                              /* pop edi */
            ii(0x1012_07c5, 1); popd(esi);                              /* pop esi */
            ii(0x1012_07c6, 1); popd(edx);                              /* pop edx */
            ii(0x1012_07c7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_07c8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_07c9, 1); retd();                                 /* ret */
        }
    }
}
