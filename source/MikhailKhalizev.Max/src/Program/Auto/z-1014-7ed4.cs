using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bd6a4c2c-5eaf-4ce9-b774-9a5d14499a60")]
        public void Method_1014_7ed4()
        {
            ii(0x1014_7ed4, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_7ed9, 5); calld(Definitions.sys_check_available_stack_size, 0x1_de74); /* call 0x10165d52 */
            ii(0x1014_7ede, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7edf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7ee0, 1); pushd(edx);                             /* push edx */
            ii(0x1014_7ee1, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7ee2, 1); pushd(edi);                             /* push edi */
            ii(0x1014_7ee3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_7ee4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7ee6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_7eec, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_7eef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7ef2, 5); calld(0x1013_a0af, -0xde48);            /* call 0x1013a0af */
            ii(0x1014_7ef7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_7efa, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_7efd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7f00, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7f03, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_7f06, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_7f09, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7f0b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7f0c, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7f0d, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7f0e, 1); popd(edx);                              /* pop edx */
            ii(0x1014_7f0f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7f10, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7f11, 1); retd(); return;                         /* ret */
        }
    }
}
