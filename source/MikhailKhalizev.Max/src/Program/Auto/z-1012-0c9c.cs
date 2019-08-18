using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2cca9dd1-aae7-4bf0-9a7f-dde91b1de908")]
        public void Method_1012_0c9c()
        {
            ii(0x1012_0c9c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_0ca1, 5); calld(Definitions.sys_check_available_stack_size, 0x4_50ac); /* call 0x10165d52 */
            ii(0x1012_0ca6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_0ca7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0ca8, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0ca9, 1); pushd(edi);                             /* push edi */
            ii(0x1012_0caa, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_0cab, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0cad, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_0cb3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0cb6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_0cb9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_0cbc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0cbf, 5); calld(0x1013_ac03, 0x1_9f3f);           /* call 0x1013ac03 */
            ii(0x1012_0cc4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0cc7, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1012_0cca, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_0ccd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0cd0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_0cd3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_0cd6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0cd8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0cd9, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0cda, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0cdb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0cdc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0cdd, 1); retd(); return;                         /* ret */
        }
    }
}
