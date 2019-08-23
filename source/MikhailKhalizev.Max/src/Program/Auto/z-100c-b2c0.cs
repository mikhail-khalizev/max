using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b2c0-733e1cca")]
        public void Method_100c_b2c0()
        {
            ii(0x100c_b2c0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b2c5, 5); calld(Definitions.sys_check_available_stack_size, 0x9_aa88); /* call 0x10165d52 */
            ii(0x100c_b2ca, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b2cb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b2cc, 1); pushd(edx);                             /* push edx */
            ii(0x100c_b2cd, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b2ce, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b2cf, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b2d0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b2d2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_b2d8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_b2db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b2de, 4); mov(ax, memw_a32[ds, eax + 0x7]);       /* mov ax, [eax+0x7] */
            ii(0x100c_b2e2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b2e5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b2e8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b2ea, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b2eb, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b2ec, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b2ed, 1); popd(edx);                              /* pop edx */
            ii(0x100c_b2ee, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b2ef, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b2f0, 1); retd();                                 /* ret */
        }
    }
}
