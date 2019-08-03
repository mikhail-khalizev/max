using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("23ef7922-ddb7-4f00-add3-a3fdc659b55e")]
        public void Method_1014_7bcc()
        {
            ii(0x1014_7bcc, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_7bd1, 5); calld(Definitions.sys_check_available_stack_size, 0x1e17c); /* call 0x10165d52 */
            ii(0x1014_7bd6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7bd7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7bd8, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7bd9, 1); pushd(edi);                             /* push edi */
            ii(0x1014_7bda, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_7bdb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7bdd, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_7be3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7be6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_7be9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_7bec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7bef, 5); calld(0x1013_abc3, -0xd031);            /* call 0x1013abc3 */
            ii(0x1014_7bf4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7bf7, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_7bfa, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_7bfd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7c00, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_7c03, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_7c06, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7c08, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7c09, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7c0a, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7c0b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7c0c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7c0d, 1); retd(); return;                         /* ret */
        }
    }
}
