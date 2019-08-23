using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6954-236e877")]
        public void Method_1007_6954()
        {
            ii(0x1007_6954, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_6959, 5); calld(Definitions.sys_check_available_stack_size, 0xe_f3f4); /* call 0x10165d52 */
            ii(0x1007_695e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_695f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6960, 1); pushd(esi);                             /* push esi */
            ii(0x1007_6961, 1); pushd(edi);                             /* push edi */
            ii(0x1007_6962, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6963, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6965, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_696b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_696e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_6971, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_6974, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6977, 5); calld(0x1013_abc3, 0xc_4247);           /* call 0x1013abc3 */
            ii(0x1007_697c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_697f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_6982, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_6985, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6988, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_698b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_698e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6990, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6991, 1); popd(edi);                              /* pop edi */
            ii(0x1007_6992, 1); popd(esi);                              /* pop esi */
            ii(0x1007_6993, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6994, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6995, 1); retd();                                 /* ret */
        }
    }
}
