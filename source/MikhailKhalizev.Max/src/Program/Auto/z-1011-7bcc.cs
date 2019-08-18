using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dd23d486-0ee5-4ba6-9a6f-e5a122d4f965")]
        public void Method_1011_7bcc()
        {
            ii(0x1011_7bcc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_7bd1, 5); calld(Definitions.sys_check_available_stack_size, 0x4_e17c); /* call 0x10165d52 */
            ii(0x1011_7bd6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_7bd7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_7bd8, 1); pushd(esi);                             /* push esi */
            ii(0x1011_7bd9, 1); pushd(edi);                             /* push edi */
            ii(0x1011_7bda, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_7bdb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7bdd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_7be3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_7be6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_7be9, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_7bee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_7bf1, 5); calld(0x1013_a1be, 0x2_25c8);           /* call 0x1013a1be */
            ii(0x1011_7bf6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_7bf9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_7bfc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_7bff, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_7c02, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7c04, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_7c05, 1); popd(edi);                              /* pop edi */
            ii(0x1011_7c06, 1); popd(esi);                              /* pop esi */
            ii(0x1011_7c07, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_7c08, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_7c09, 1); retd(); return;                         /* ret */
        }
    }
}
