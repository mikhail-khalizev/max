using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ecf6a98b-41e9-4ae0-acce-9e0c67c1c9d5")]
        public void Method_100d_50d4()
        {
            ii(0x100d_50d4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_50d9, 5); calld(Definitions.sys_check_available_stack_size, 0x9_0c74); /* call 0x10165d52 */
            ii(0x100d_50de, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_50df, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_50e0, 1); pushd(esi);                             /* push esi */
            ii(0x100d_50e1, 1); pushd(edi);                             /* push edi */
            ii(0x100d_50e2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_50e3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_50e5, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_50eb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_50ee, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_50f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_50f4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_50f7, 4); mov(memw_a32[ds, edx + 0x35], ax);      /* mov [edx+0x35], ax */
            ii(0x100d_50fb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_50fd, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_50fe, 1); popd(edi);                              /* pop edi */
            ii(0x100d_50ff, 1); popd(esi);                              /* pop esi */
            ii(0x100d_5100, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_5101, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_5102, 1); retd(); return;                         /* ret */
        }
    }
}
