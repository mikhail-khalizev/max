using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a0a4-3628d1cc")]
        public void Method_100c_a0a4()
        {
            ii(0x100c_a0a4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_a0a9, 5); calld(Definitions.sys_check_available_stack_size, 0x9_bca4); /* call 0x10165d52 */
            ii(0x100c_a0ae, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_a0af, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_a0b0, 1); pushd(esi);                             /* push esi */
            ii(0x100c_a0b1, 1); pushd(edi);                             /* push edi */
            ii(0x100c_a0b2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_a0b3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a0b5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a0bb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a0be, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_a0c1, 5); mov(ebx, 0x101b_5750);                  /* mov ebx, 0x101b5750 */
            ii(0x100c_a0c6, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x100c_a0cb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a0ce, 5); calld(Definitions.sys_call_dtor_arr_v2, 0x9_bf0d); /* call 0x10165fe0 */
            ii(0x100c_a0d3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_a0d6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_a0d9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a0db, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_a0dc, 1); popd(edi);                              /* pop edi */
            ii(0x100c_a0dd, 1); popd(esi);                              /* pop esi */
            ii(0x100c_a0de, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_a0df, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_a0e0, 1); retd(); return;                         /* ret */
        }
    }
}
