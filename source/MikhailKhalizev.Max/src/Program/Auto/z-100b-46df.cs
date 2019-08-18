using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a764e1e6-426d-45f1-868a-0222cfb2b865")]
        public void Method_100b_46df()
        {
            ii(0x100b_46df, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_46e4, 5); calld(Definitions.sys_check_available_stack_size, 0xb_1669); /* call 0x10165d52 */
            ii(0x100b_46e9, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_46ea, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_46eb, 1); pushd(edx);                             /* push edx */
            ii(0x100b_46ec, 1); pushd(esi);                             /* push esi */
            ii(0x100b_46ed, 1); pushd(edi);                             /* push edi */
            ii(0x100b_46ee, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_46ef, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_46f1, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_46f7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_46fa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_46fd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_4700, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_4703, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100b_4706, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_4709, 3); calld_abs(memd_a32[ds, edx + 0x3c]);    /* call dword [edx+0x3c] */
            ii(0x100b_470c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_470e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_470f, 1); popd(edi);                              /* pop edi */
            ii(0x100b_4710, 1); popd(esi);                              /* pop esi */
            ii(0x100b_4711, 1); popd(edx);                              /* pop edx */
            ii(0x100b_4712, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_4713, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_4714, 1); retd(); return;                         /* ret */
        }
    }
}
