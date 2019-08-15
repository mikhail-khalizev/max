using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5f0c0edb-0799-44c9-8001-a2c2d4fb238a")]
        public void Method_1009_c9d4()
        {
            ii(0x1009_c9d4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_c9d9, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9374); /* call 0x10165d52 */
            ii(0x1009_c9de, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c9df, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c9e0, 1); pushd(edx);                             /* push edx */
            ii(0x1009_c9e1, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c9e2, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c9e3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c9e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c9e6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_c9ec, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_c9ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c9f2, 4); mov(ax, memw_a32[ds, eax + 0xb]);       /* mov ax, [eax+0xb] */
            ii(0x1009_c9f6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c9f9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c9fc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c9fe, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c9ff, 1); popd(edi);                              /* pop edi */
            ii(0x1009_ca00, 1); popd(esi);                              /* pop esi */
            ii(0x1009_ca01, 1); popd(edx);                              /* pop edx */
            ii(0x1009_ca02, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_ca03, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_ca04, 1); retd(); return;                         /* ret */
        }
    }
}
