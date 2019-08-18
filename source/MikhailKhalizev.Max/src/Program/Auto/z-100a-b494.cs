using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b494-78643116")]
        public void Method_100a_b494()
        {
            ii(0x100a_b494, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_b499, 5); calld(Definitions.sys_check_available_stack_size, 0xb_a8b4); /* call 0x10165d52 */
            ii(0x100a_b49e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_b49f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_b4a0, 1); pushd(esi);                             /* push esi */
            ii(0x100a_b4a1, 1); pushd(edi);                             /* push edi */
            ii(0x100a_b4a2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_b4a3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b4a5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_b4ab, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_b4ae, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_b4b1, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100a_b4b5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100a_b4b8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_b4ba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_b4bd, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100a_b4c0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_b4c2, 5); calld(0x1007_6dd0, -0x3_46f7);          /* call 0x10076dd0 */
            ii(0x100a_b4c7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_b4ca, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_b4cd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b4cf, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_b4d0, 1); popd(edi);                              /* pop edi */
            ii(0x100a_b4d1, 1); popd(esi);                              /* pop esi */
            ii(0x100a_b4d2, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_b4d3, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_b4d4, 1); retd(); return;                         /* ret */
        }
    }
}
