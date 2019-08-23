using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_e809-c369fb4c")]
        public void Method_100c_e809()
        {
            ii(0x100c_e809, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_e80e, 5); calld(Definitions.sys_check_available_stack_size, 0x9_753f); /* call 0x10165d52 */
            ii(0x100c_e813, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_e814, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_e815, 1); pushd(edx);                             /* push edx */
            ii(0x100c_e816, 1); pushd(esi);                             /* push esi */
            ii(0x100c_e817, 1); pushd(edi);                             /* push edi */
            ii(0x100c_e818, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_e819, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_e81b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_e821, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_e824, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e827, 4); cmp(memd_a32[ds, eax + 0xc], 0);        /* cmp dword [eax+0xc], 0x0 */
            ii(0x100c_e82b, 2); if(jnzd(0x100c_e836, 0x9)) goto l_0x100c_e836; /* jnz 0x100ce836 */
            ii(0x100c_e82d, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100c_e834, 2); jmpd(0x100c_e844, 0xe); goto l_0x100c_e844; /* jmp 0x100ce844 */
        l_0x100c_e836:
            ii(0x100c_e836, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e839, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100c_e83c, 5); calld(0x100d_4e8c, 0x664b);             /* call 0x100d4e8c */
            ii(0x100c_e841, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x100c_e844:
            ii(0x100c_e844, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_e847, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_e849, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_e84a, 1); popd(edi);                              /* pop edi */
            ii(0x100c_e84b, 1); popd(esi);                              /* pop esi */
            ii(0x100c_e84c, 1); popd(edx);                              /* pop edx */
            ii(0x100c_e84d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_e84e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_e84f, 1); retd();                                 /* ret */
        }
    }
}
