using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9810b34d-e328-41e2-9f25-5577ab63b09b")]
        public void Method_100b_7f18()
        {
            ii(0x100b_7f18, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_7f1d, 5); calld(Definitions.sys_check_available_stack_size, 0xade30); /* call 0x10165d52 */
            ii(0x100b_7f22, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7f23, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7f24, 1); pushd(edx);                             /* push edx */
            ii(0x100b_7f25, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7f26, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7f27, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7f28, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7f2a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_7f30, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_7f33, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_7f36, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x100b_7f39, 2); if(jzd(0x100b_7f44, 0x9)) goto l_0x100b_7f44; /* jz 0x100b7f44 */
            ii(0x100b_7f3b, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100b_7f42, 2); jmpd(0x100b_7f5d, 0x19); goto l_0x100b_7f5d; /* jmp 0x100b7f5d */
        l_0x100b_7f44:
            ii(0x100b_7f44, 5); mov(ecx, 0xae);                         /* mov ecx, 0xae */
            ii(0x100b_7f49, 5); mov(ebx, StringDefinitions.SmartptrH2); /* mov ebx, 0x101a0d68 */
            ii(0x100b_7f4e, 5); mov(edx, StringDefinitions.Ptr02);      /* mov edx, 0x101a0d73 */
            ii(0x100b_7f53, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_7f55, 5); calld(Definitions.sys_assert, 0xade38); /* call 0x10165d92 */
            ii(0x100b_7f5a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x100b_7f5d:
            ii(0x100b_7f5d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_7f60, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_7f62, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_7f65, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_7f68, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7f6a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7f6b, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7f6c, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7f6d, 1); popd(edx);                              /* pop edx */
            ii(0x100b_7f6e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7f6f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7f70, 1); retd(); return;                         /* ret */
        }
    }
}
