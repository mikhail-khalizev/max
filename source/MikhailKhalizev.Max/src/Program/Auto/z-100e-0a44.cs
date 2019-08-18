using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("63614612-2f72-4758-b85b-6455fc0b1760")]
        public void Method_100e_0a44()
        {
            ii(0x100e_0a44, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_0a49, 5); calld(Definitions.sys_check_available_stack_size, 0x8_5304); /* call 0x10165d52 */
            ii(0x100e_0a4e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0a4f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0a50, 1); pushd(edx);                             /* push edx */
            ii(0x100e_0a51, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0a52, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0a53, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0a54, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0a56, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_0a5c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_0a5f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0a62, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x100e_0a65, 5); calld(0x100e_0b0c, 0xa2);               /* call 0x100e0b0c */
            ii(0x100e_0a6a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0a6d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_0a70, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0a72, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0a73, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0a74, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0a75, 1); popd(edx);                              /* pop edx */
            ii(0x100e_0a76, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0a77, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0a78, 1); retd(); return;                         /* ret */
        }
    }
}
