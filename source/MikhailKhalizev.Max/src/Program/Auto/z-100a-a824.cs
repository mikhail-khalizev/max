using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a824-461af56c")]
        public void Method_100a_a824()
        {
            ii(0x100a_a824, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_a829, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b524); /* call 0x10165d52 */
            ii(0x100a_a82e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_a82f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a830, 1); pushd(edx);                             /* push edx */
            ii(0x100a_a831, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a832, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a833, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a834, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a836, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a83c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_a83f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_a842, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x100a_a845, 2); if(jzd(0x100a_a850, 0x9)) goto l_0x100a_a850; /* jz 0x100aa850 */
            ii(0x100a_a847, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100a_a84e, 2); jmpd(0x100a_a869, 0x19); goto l_0x100a_a869; /* jmp 0x100aa869 */
        l_0x100a_a850:
            ii(0x100a_a850, 5); mov(ecx, 0xae);                         /* mov ecx, 0xae */
            ii(0x100a_a855, 5); mov(ebx, StringDefinitions.SmartptrH21); /* mov ebx, 0x101a0864 */
            ii(0x100a_a85a, 5); mov(edx, StringDefinitions.PtrNotEqual023); /* mov edx, 0x101a086f */
            ii(0x100a_a85f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_a861, 5); calld(Definitions.sys_assert, 0xb_b52c); /* call 0x10165d92 */
            ii(0x100a_a866, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x100a_a869:
            ii(0x100a_a869, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_a86c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100a_a86e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_a871, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_a874, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a876, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a877, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a878, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a879, 1); popd(edx);                              /* pop edx */
            ii(0x100a_a87a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a87b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_a87c, 1); retd(); return;                         /* ret */
        }
    }
}
