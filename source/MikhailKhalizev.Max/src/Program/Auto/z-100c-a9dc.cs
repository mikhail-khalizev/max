using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1ec36307-a04c-4099-8467-553c148012f7")]
        public void Method_100c_a9dc()
        {
            ii(0x100c_a9dc, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_a9dd, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_a9de, 1); pushd(edx);                             /* push edx */
            ii(0x100c_a9df, 1); pushd(esi);                             /* push esi */
            ii(0x100c_a9e0, 1); pushd(edi);                             /* push edi */
            ii(0x100c_a9e1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_a9e2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a9e4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_a9ea, 7); mov(memd_a32[ss, ebp - 0x4], 0x5);      /* mov dword [ebp-0x4], 0x5 */
            ii(0x100c_a9f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_a9f4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a9f6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_a9f7, 1); popd(edi);                              /* pop edi */
            ii(0x100c_a9f8, 1); popd(esi);                              /* pop esi */
            ii(0x100c_a9f9, 1); popd(edx);                              /* pop edx */
            ii(0x100c_a9fa, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_a9fb, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_a9fc, 1); retd(); return;                         /* ret */
        }
    }
}
