using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4f51580e-751e-4e09-923b-99d259412088")]
        public void Method_1014_15d4()
        {
            ii(0x1014_15d4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_15d9, 5); calld(Definitions.sys_check_available_stack_size, 0x24774); /* call 0x10165d52 */
            ii(0x1014_15de, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_15df, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_15e0, 1); pushd(esi);                             /* push esi */
            ii(0x1014_15e1, 1); pushd(edi);                             /* push edi */
            ii(0x1014_15e2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_15e3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_15e5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_15eb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_15ee, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_15f1, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_15f5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_15f8, 5); calld(0x100a_b494, -0x96169);           /* call 0x100ab494 */
            ii(0x1014_15fd, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_1600, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_1603, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1605, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_1606, 1); popd(edi);                              /* pop edi */
            ii(0x1014_1607, 1); popd(esi);                              /* pop esi */
            ii(0x1014_1608, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_1609, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_160a, 1); retd(); return;                         /* ret */
        }
    }
}
