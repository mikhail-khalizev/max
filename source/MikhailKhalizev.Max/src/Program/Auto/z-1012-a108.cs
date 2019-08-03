using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8d13eb95-500f-476c-91a6-fedb116f1f9e")]
        public void Method_1012_a108()
        {
            ii(0x1012_a108, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1012_a10d, 5); calld(Definitions.sys_check_available_stack_size, 0x3bc40); /* call 0x10165d52 */
            ii(0x1012_a112, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_a113, 1); pushd(esi);                             /* push esi */
            ii(0x1012_a114, 1); pushd(edi);                             /* push edi */
            ii(0x1012_a115, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_a116, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_a118, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_a11e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_a121, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_a124, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1012_a127, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1012_a12b, 1); pushd(eax);                             /* push eax */
            ii(0x1012_a12c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1012_a130, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1012_a133, 6); pushd(memd_a32[ds, eax + 0x101c_81d7]); /* push dword [eax+0x101c81d7] */
            ii(0x1012_a139, 5); mov(eax, 0x101a_83d1);                  /* mov eax, 0x101a83d1 */ /* "%s %i" */
            ii(0x1012_a13e, 1); pushd(eax);                             /* push eax */
            ii(0x1012_a13f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_a142, 1); pushd(eax);                             /* push eax */
            ii(0x1012_a143, 5); calld(Definitions.sys_sprintf, 0x3bdb9); /* call 0x10165f01 */
            ii(0x1012_a148, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1012_a14b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_a14e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_a151, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_a154, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_a156, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_a157, 1); popd(edi);                              /* pop edi */
            ii(0x1012_a158, 1); popd(esi);                              /* pop esi */
            ii(0x1012_a159, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_a15a, 1); retd(); return;                         /* ret */
        }
    }
}
