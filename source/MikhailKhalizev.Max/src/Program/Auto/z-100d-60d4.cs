using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("927f9f9f-6bf5-4d6e-aa5b-c8ac20b9eddb")]
        public void Method_100d_60d4()
        {
            ii(0x100d_60d4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_60d9, 5); calld(Definitions.sys_check_available_stack_size, 0x8fc74); /* call 0x10165d52 */
            ii(0x100d_60de, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_60df, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_60e0, 1); pushd(esi);                             /* push esi */
            ii(0x100d_60e1, 1); pushd(edi);                             /* push edi */
            ii(0x100d_60e2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_60e3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_60e5, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_60eb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_60ee, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100d_60f1, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100d_60f4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_60f7, 3); mov(memb_a32[ds, edx + 0x35], al);      /* mov [edx+0x35], al */
            ii(0x100d_60fa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_60fc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_60fd, 1); popd(edi);                              /* pop edi */
            ii(0x100d_60fe, 1); popd(esi);                              /* pop esi */
            ii(0x100d_60ff, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_6100, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_6101, 1); retd(); return;                         /* ret */
        }
    }
}
