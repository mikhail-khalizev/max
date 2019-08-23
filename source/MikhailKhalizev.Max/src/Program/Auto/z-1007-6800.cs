using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6800-d8fa8c50")]
        public void Method_1007_6800()
        {
            ii(0x1007_6800, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_6805, 5); calld(Definitions.sys_check_available_stack_size, 0xe_f548); /* call 0x10165d52 */
            ii(0x1007_680a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_680b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_680c, 1); pushd(esi);                             /* push esi */
            ii(0x1007_680d, 1); pushd(edi);                             /* push edi */
            ii(0x1007_680e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_680f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6811, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_6817, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_681a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_681d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_6820, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6823, 5); calld(0x1013_abc3, 0xc_439b);           /* call 0x1013abc3 */
            ii(0x1007_6828, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_682b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_682e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_6831, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6834, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_6837, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_683a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_683c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_683d, 1); popd(edi);                              /* pop edi */
            ii(0x1007_683e, 1); popd(esi);                              /* pop esi */
            ii(0x1007_683f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6840, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6841, 1); retd();                                 /* ret */
        }
    }
}
