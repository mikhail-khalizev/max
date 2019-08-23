using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_66f0-bee50c7f")]
        public void my_ctor_0x101b_38f8()
        {
            ii(0x1007_66f0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_66f5, 5); calld(Definitions.sys_check_available_stack_size, 0xe_f658); /* call 0x10165d52 */
            ii(0x1007_66fa, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_66fb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_66fc, 1); pushd(edx);                             /* push edx */
            ii(0x1007_66fd, 1); pushd(esi);                             /* push esi */
            ii(0x1007_66fe, 1); pushd(edi);                             /* push edi */
            ii(0x1007_66ff, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6700, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6702, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_6708, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_670b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_670e, 5); calld(Definitions.my_ctor_0x101b_6edc, 0x731); /* call 0x10076e44 */
            ii(0x1007_6713, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_6716, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1007_6719, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_671c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_671f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_6722, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_6725, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6727, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6728, 1); popd(edi);                              /* pop edi */
            ii(0x1007_6729, 1); popd(esi);                              /* pop esi */
            ii(0x1007_672a, 1); popd(edx);                              /* pop edx */
            ii(0x1007_672b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_672c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_672d, 1); retd();                                 /* ret */
        }
    }
}
