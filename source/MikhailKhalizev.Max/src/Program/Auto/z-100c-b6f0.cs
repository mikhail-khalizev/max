using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a919cc0b-a109-4cdf-9308-351ce98348d8")]
        public void Method_100c_b6f0()
        {
            ii(0x100c_b6f0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100c_b6f5, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a658); /* call 0x10165d52 */
            ii(0x100c_b6fa, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b6fb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b6fc, 1); pushd(edx);                             /* push edx */
            ii(0x100c_b6fd, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b6fe, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b6ff, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b700, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b702, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_b708, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_b70b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b70e, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x100c_b711, 2); if(jzd(0x100c_b71c, 0x9)) goto l_0x100c_b71c; /* jz 0x100cb71c */
            ii(0x100c_b713, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100c_b71a, 2); jmpd(0x100c_b735, 0x19); goto l_0x100c_b735; /* jmp 0x100cb735 */
        l_0x100c_b71c:
            ii(0x100c_b71c, 5); mov(ecx, 0xa7);                         /* mov ecx, 0xa7 */
            ii(0x100c_b721, 5); mov(ebx, StringDefinitions.SmartptrH8); /* mov ebx, 0x101a1214 */
            ii(0x100c_b726, 5); mov(edx, StringDefinitions.PtrNotEqual08); /* mov edx, 0x101a121f */
            ii(0x100c_b72b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_b72d, 5); calld(Definitions.sys_assert, 0x9_a660); /* call 0x10165d92 */
            ii(0x100c_b732, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x100c_b735:
            ii(0x100c_b735, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b738, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_b73a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_b73d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_b740, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b742, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b743, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b744, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b745, 1); popd(edx);                              /* pop edx */
            ii(0x100c_b746, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b747, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b748, 1); retd(); return;                         /* ret */
        }
    }
}
