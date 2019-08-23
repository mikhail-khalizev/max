using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_19f4-5d46e001")]
        public void Method_1013_19f4()
        {
            ii(0x1013_19f4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_19f9, 5); calld(Definitions.sys_check_available_stack_size, 0x3_4354); /* call 0x10165d52 */
            ii(0x1013_19fe, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_19ff, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1a00, 1); pushd(edx);                             /* push edx */
            ii(0x1013_1a01, 1); pushd(esi);                             /* push esi */
            ii(0x1013_1a02, 1); pushd(edi);                             /* push edi */
            ii(0x1013_1a03, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_1a04, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1a06, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_1a0c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_1a0f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1a12, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1013_1a15, 5); calld(0x1013_1c0c, 0x1f2);              /* call 0x10131c0c */
            ii(0x1013_1a1a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_1a1d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_1a20, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1a22, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_1a23, 1); popd(edi);                              /* pop edi */
            ii(0x1013_1a24, 1); popd(esi);                              /* pop esi */
            ii(0x1013_1a25, 1); popd(edx);                              /* pop edx */
            ii(0x1013_1a26, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_1a27, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_1a28, 1); retd();                                 /* ret */
        }
    }
}
