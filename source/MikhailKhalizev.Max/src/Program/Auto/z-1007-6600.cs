using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d0e9fc27-2dd4-4df6-91aa-0d5ab2e49f8e")]
        public void Method_1007_6600()
        {
            ii(0x1007_6600, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_6605, 5); calld(Definitions.sys_check_available_stack_size, 0xe_f748); /* call 0x10165d52 */
            ii(0x1007_660a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_660b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_660c, 1); pushd(edx);                             /* push edx */
            ii(0x1007_660d, 1); pushd(esi);                             /* push esi */
            ii(0x1007_660e, 1); pushd(edi);                             /* push edi */
            ii(0x1007_660f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6610, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6612, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_6618, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_661b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_661e, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1007_6620, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_6623, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6626, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6628, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6629, 1); popd(edi);                              /* pop edi */
            ii(0x1007_662a, 1); popd(esi);                              /* pop esi */
            ii(0x1007_662b, 1); popd(edx);                              /* pop edx */
            ii(0x1007_662c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_662d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_662e, 1); retd(); return;                         /* ret */
        }
    }
}
