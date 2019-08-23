using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_6d90-9d9dc515")]
        public void Method_1013_6d90()
        {
            ii(0x1013_6d90, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_6d95, 5); calld(Definitions.sys_check_available_stack_size, 0x2_efb8); /* call 0x10165d52 */
            ii(0x1013_6d9a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_6d9b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_6d9c, 1); pushd(edx);                             /* push edx */
            ii(0x1013_6d9d, 1); pushd(esi);                             /* push esi */
            ii(0x1013_6d9e, 1); pushd(edi);                             /* push edi */
            ii(0x1013_6d9f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_6da0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_6da2, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_6da8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_6dab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_6dae, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1013_6db1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_6db4, 5); calld(0x1013_6d00, -0xb9);              /* call 0x10136d00 */
            ii(0x1013_6db9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_6dbb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_6dbc, 1); popd(edi);                              /* pop edi */
            ii(0x1013_6dbd, 1); popd(esi);                              /* pop esi */
            ii(0x1013_6dbe, 1); popd(edx);                              /* pop edx */
            ii(0x1013_6dbf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_6dc0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_6dc1, 1); retd();                                 /* ret */
        }
    }
}
