using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("be1d6ca9-8610-4ee6-99af-5e251dfbe55b")]
        public void Method_1013_1bb0()
        {
            ii(0x1013_1bb0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_1bb5, 5); calld(Definitions.sys_check_available_stack_size, 0x34198); /* call 0x10165d52 */
            ii(0x1013_1bba, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_1bbb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1bbc, 1); pushd(edx);                             /* push edx */
            ii(0x1013_1bbd, 1); pushd(esi);                             /* push esi */
            ii(0x1013_1bbe, 1); pushd(edi);                             /* push edi */
            ii(0x1013_1bbf, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_1bc0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1bc2, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_1bc8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_1bcb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1bce, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x1013_1bd1, 2); if(jzd(0x1013_1bdc, 0x9)) goto l_0x1013_1bdc; /* jz 0x10131bdc */
            ii(0x1013_1bd3, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1013_1bda, 2); jmpd(0x1013_1bf5, 0x19); goto l_0x1013_1bf5; /* jmp 0x10131bf5 */
        l_0x1013_1bdc:
            ii(0x1013_1bdc, 5); mov(ecx, 0xae);                         /* mov ecx, 0xae */
            ii(0x1013_1be1, 5); mov(ebx, StringDefinitions.SmartptrH12); /* mov ebx, 0x101a86c0 */
            ii(0x1013_1be6, 5); mov(edx, StringDefinitions.PtrNotEqual012); /* mov edx, 0x101a86cb */
            ii(0x1013_1beb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_1bed, 5); calld(Definitions.sys_assert, 0x341a0); /* call 0x10165d92 */
            ii(0x1013_1bf2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1013_1bf5:
            ii(0x1013_1bf5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1bf8, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_1bfa, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_1bfd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_1c00, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1c02, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_1c03, 1); popd(edi);                              /* pop edi */
            ii(0x1013_1c04, 1); popd(esi);                              /* pop esi */
            ii(0x1013_1c05, 1); popd(edx);                              /* pop edx */
            ii(0x1013_1c06, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_1c07, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_1c08, 1); retd(); return;                         /* ret */
        }
    }
}
