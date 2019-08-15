using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e0c8207b-24de-4417-ac7a-7284a7a0bffa")]
        public void Method_100a_88cc()
        {
            ii(0x100a_88cc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_88d1, 5); calld(Definitions.sys_check_available_stack_size, 0xb_d47c); /* call 0x10165d52 */
            ii(0x100a_88d6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_88d7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_88d8, 1); pushd(edx);                             /* push edx */
            ii(0x100a_88d9, 1); pushd(esi);                             /* push esi */
            ii(0x100a_88da, 1); pushd(edi);                             /* push edi */
            ii(0x100a_88db, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_88dc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_88de, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_88e4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_88e7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_88ea, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_88ed, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_88f0, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100a_88f3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_88f6, 3); calld_abs(memd_a32[ds, edx + 0x3c]);    /* call dword [edx+0x3c] */
            ii(0x100a_88f9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_88fb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_88fc, 1); popd(edi);                              /* pop edi */
            ii(0x100a_88fd, 1); popd(esi);                              /* pop esi */
            ii(0x100a_88fe, 1); popd(edx);                              /* pop edx */
            ii(0x100a_88ff, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_8900, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_8901, 1); retd(); return;                         /* ret */
        }
    }
}
