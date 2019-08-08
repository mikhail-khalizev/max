using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c3fbadd9-5b0e-43e3-9d6e-fe5e95e4e419")]
        public void Method_1007_66ac()
        {
            ii(0x1007_66ac, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_66b1, 5); calld(Definitions.sys_check_available_stack_size, 0xe_f69c); /* call 0x10165d52 */
            ii(0x1007_66b6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_66b7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_66b8, 1); pushd(esi);                             /* push esi */
            ii(0x1007_66b9, 1); pushd(edi);                             /* push edi */
            ii(0x1007_66ba, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_66bb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_66bd, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_66c3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_66c6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_66c9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_66cc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_66cf, 5); calld(0x1013_abc3, 0xc_44ef);           /* call 0x1013abc3 */
            ii(0x1007_66d4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_66d7, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_66da, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_66dd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_66e0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_66e3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_66e6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_66e8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_66e9, 1); popd(edi);                              /* pop edi */
            ii(0x1007_66ea, 1); popd(esi);                              /* pop esi */
            ii(0x1007_66eb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_66ec, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_66ed, 1); retd(); return;                         /* ret */
        }
    }
}
