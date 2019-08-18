using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("14e51f1b-030c-413c-95c4-c19a2cdff1ea")]
        public void Method_100c_b4c4()
        {
            ii(0x100c_b4c4, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100c_b4c9, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a884); /* call 0x10165d52 */
            ii(0x100c_b4ce, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b4cf, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b4d0, 1); pushd(edx);                             /* push edx */
            ii(0x100c_b4d1, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b4d2, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b4d3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b4d4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b4d6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_b4dc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_b4df, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b4e2, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x100c_b4e5, 2); if(jzd(0x100c_b4f0, 0x9)) goto l_0x100c_b4f0; /* jz 0x100cb4f0 */
            ii(0x100c_b4e7, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100c_b4ee, 2); jmpd(0x100c_b509, 0x19); goto l_0x100c_b509; /* jmp 0x100cb509 */
        l_0x100c_b4f0:
            ii(0x100c_b4f0, 5); mov(ecx, 0xae);                         /* mov ecx, 0xae */
            ii(0x100c_b4f5, 5); mov(ebx, StringDefinitions.SmartptrH19); /* mov ebx, 0x101a1264 */
            ii(0x100c_b4fa, 5); mov(edx, StringDefinitions.PtrNotEqual021); /* mov edx, 0x101a126f */
            ii(0x100c_b4ff, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_b501, 5); calld(Definitions.sys_assert, 0x9_a88c); /* call 0x10165d92 */
            ii(0x100c_b506, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x100c_b509:
            ii(0x100c_b509, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b50c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_b50e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_b511, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_b514, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b516, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b517, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b518, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b519, 1); popd(edx);                              /* pop edx */
            ii(0x100c_b51a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b51b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b51c, 1); retd(); return;                         /* ret */
        }
    }
}
