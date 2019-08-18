using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("68df2582-935c-40c3-813d-bc607d616897")]
        public void Method_1012_04a4()
        {
            ii(0x1012_04a4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_04a9, 5); calld(Definitions.sys_check_available_stack_size, 0x4_58a4); /* call 0x10165d52 */
            ii(0x1012_04ae, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_04af, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_04b0, 1); pushd(edx);                             /* push edx */
            ii(0x1012_04b1, 1); pushd(esi);                             /* push esi */
            ii(0x1012_04b2, 1); pushd(edi);                             /* push edi */
            ii(0x1012_04b3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_04b4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_04b6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_04bc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_04bf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_04c2, 5); calld(Definitions.my_ctor_0x101b_4184, -0xa_99d7); /* call 0x10076af0 */
            ii(0x1012_04c7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_04ca, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_04cd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_04d0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_04d3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_04d5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_04d6, 1); popd(edi);                              /* pop edi */
            ii(0x1012_04d7, 1); popd(esi);                              /* pop esi */
            ii(0x1012_04d8, 1); popd(edx);                              /* pop edx */
            ii(0x1012_04d9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_04da, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_04db, 1); retd(); return;                         /* ret */
        }
    }
}
