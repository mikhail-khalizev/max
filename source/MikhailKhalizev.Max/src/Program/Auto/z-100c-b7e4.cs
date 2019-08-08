using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fcad2294-3358-4e5b-86d4-561ed9cdbb9f")]
        public void Method_100c_b7e4()
        {
            ii(0x100c_b7e4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_b7e9, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a564); /* call 0x10165d52 */
            ii(0x100c_b7ee, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b7ef, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b7f0, 1); pushd(edx);                             /* push edx */
            ii(0x100c_b7f1, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b7f2, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b7f3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b7f4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b7f6, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_b7fc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_b7ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b802, 4); cmp(memb_a32[ds, eax + 0x23], 0);       /* cmp byte [eax+0x23], 0x0 */
            ii(0x100c_b806, 2); if(jzd(0x100c_b80f, 0x7)) goto l_0x100c_b80f; /* jz 0x100cb80f */
            ii(0x100c_b808, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b80b, 4); inc(memw_a32[ds, eax + 0x21]);          /* inc word [eax+0x21] */
        l_0x100c_b80f:
            ii(0x100c_b80f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b811, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b812, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b813, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b814, 1); popd(edx);                              /* pop edx */
            ii(0x100c_b815, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b816, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b817, 1); retd(); return;                         /* ret */
        }
    }
}
