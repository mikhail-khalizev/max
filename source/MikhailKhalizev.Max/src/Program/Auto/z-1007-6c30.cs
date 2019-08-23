using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6c30-431db73")]
        public void Method_1007_6c30()
        {
            ii(0x1007_6c30, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_6c35, 5); calld(Definitions.sys_check_available_stack_size, 0xe_f118); /* call 0x10165d52 */
            ii(0x1007_6c3a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_6c3b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6c3c, 1); pushd(edx);                             /* push edx */
            ii(0x1007_6c3d, 1); pushd(esi);                             /* push esi */
            ii(0x1007_6c3e, 1); pushd(edi);                             /* push edi */
            ii(0x1007_6c3f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6c40, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6c42, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_6c48, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_6c4b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_6c4e, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1007_6c50, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1007_6c53, 5); calld(0x1007_6dd0, 0x178);              /* call 0x10076dd0 */
            ii(0x1007_6c58, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_6c5b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6c5e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6c60, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6c61, 1); popd(edi);                              /* pop edi */
            ii(0x1007_6c62, 1); popd(esi);                              /* pop esi */
            ii(0x1007_6c63, 1); popd(edx);                              /* pop edx */
            ii(0x1007_6c64, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6c65, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6c66, 1); retd();                                 /* ret */
        }
    }
}
