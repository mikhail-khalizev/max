using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1ae8-f008e713")]
        public void my_string_ctor()
        {
            ii(0x1014_1ae8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_1aed, 5); calld(Definitions.sys_check_available_stack_size, 0x2_4260); /* call 0x10165d52 */
            ii(0x1014_1af2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_1af3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_1af4, 1); pushd(edx);                             /* push edx */
            ii(0x1014_1af5, 1); pushd(esi);                             /* push esi */
            ii(0x1014_1af6, 1); pushd(edi);                             /* push edi */
            ii(0x1014_1af7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_1af8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_1afa, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_1b00, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_1b03, 6); mov(edx, memd_a32[ds, 0x101c_8114]);    /* mov edx, [0x101c8114] */
            ii(0x1014_1b09, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1b0c, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1014_1b0e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1b11, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_1b13, 5); calld(Definitions.my_string_add_ref, 0x94c); /* call 0x10142464 */
            ii(0x1014_1b18, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1b1b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_1b1e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1b21, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1b23, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_1b24, 1); popd(edi);                              /* pop edi */
            ii(0x1014_1b25, 1); popd(esi);                              /* pop esi */
            ii(0x1014_1b26, 1); popd(edx);                              /* pop edx */
            ii(0x1014_1b27, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_1b28, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_1b29, 1); retd(); return;                         /* ret */
        }
    }
}
