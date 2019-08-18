using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a4fd34ba-00f1-4750-aac1-e48308a82eb4")]
        public void Method_1012_0940()
        {
            ii(0x1012_0940, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_0945, 5); calld(Definitions.sys_check_available_stack_size, 0x4_5408); /* call 0x10165d52 */
            ii(0x1012_094a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_094b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_094c, 1); pushd(esi);                             /* push esi */
            ii(0x1012_094d, 1); pushd(edi);                             /* push edi */
            ii(0x1012_094e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_094f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0951, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_0957, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_095a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_095d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_0960, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0963, 5); calld(0x1013_ac03, 0x1_a29b);           /* call 0x1013ac03 */
            ii(0x1012_0968, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_096b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1012_096e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_0971, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0974, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_0977, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_097a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_097c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_097d, 1); popd(edi);                              /* pop edi */
            ii(0x1012_097e, 1); popd(esi);                              /* pop esi */
            ii(0x1012_097f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0980, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0981, 1); retd(); return;                         /* ret */
        }
    }
}
