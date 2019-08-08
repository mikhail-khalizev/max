using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("55ff6f6a-6e80-4185-94a9-208f299d8005")]
        public void Method_1015_0a9e()
        {
            ii(0x1015_0a9e, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1015_0aa3, 5); calld(Definitions.sys_check_available_stack_size, 0x1_52aa); /* call 0x10165d52 */
            ii(0x1015_0aa8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_0aa9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_0aaa, 1); pushd(edx);                             /* push edx */
            ii(0x1015_0aab, 1); pushd(esi);                             /* push esi */
            ii(0x1015_0aac, 1); pushd(edi);                             /* push edi */
            ii(0x1015_0aad, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_0aae, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_0ab0, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_0ab6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_0ab9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0abc, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_0abf, 5); calld(Definitions.my_2_get_count, -0xc_575c); /* call 0x1008b368 */
            ii(0x1015_0ac4, 1); cwde();                                 /* cwde */
            ii(0x1015_0ac5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_0ac7, 2); if(jnzd(0x1015_0afb, 0x32)) goto l_0x1015_0afb; /* jnz 0x10150afb */
            ii(0x1015_0ac9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0acc, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_0acf, 5); calld(Definitions.my_2_get_count, -0xc_576c); /* call 0x1008b368 */
            ii(0x1015_0ad4, 1); cwde();                                 /* cwde */
            ii(0x1015_0ad5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_0ad7, 2); if(jled(0x1015_0ae2, 0x9)) goto l_0x1015_0ae2; /* jle 0x10150ae2 */
            ii(0x1015_0ad9, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1015_0ae0, 2); jmpd(0x1015_0afb, 0x19); goto l_0x1015_0afb; /* jmp 0x10150afb */
        l_0x1015_0ae2:
            ii(0x1015_0ae2, 5); mov(ecx, 0xc15);                        /* mov ecx, 0xc15 */
            ii(0x1015_0ae7, 5); mov(ebx, StringDefinitions.UnitinfoCpp4); /* mov ebx, 0x101addf1 */
            ii(0x1015_0aec, 5); mov(edx, StringDefinitions.BuildListGetcountGreater0); /* mov edx, 0x101addfe */
            ii(0x1015_0af1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_0af3, 5); calld(Definitions.sys_assert, 0x1_529a); /* call 0x10165d92 */
            ii(0x1015_0af8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1015_0afb:
            ii(0x1015_0afb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_0afd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0b00, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_0b03, 5); calld(0x1008_b228, -0xc_58e0);          /* call 0x1008b228 */
            ii(0x1015_0b08, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1015_0b0b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_0b0e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_0b11, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_0b13, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_0b14, 1); popd(edi);                              /* pop edi */
            ii(0x1015_0b15, 1); popd(esi);                              /* pop esi */
            ii(0x1015_0b16, 1); popd(edx);                              /* pop edx */
            ii(0x1015_0b17, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_0b18, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_0b19, 1); retd(); return;                         /* ret */
        }
    }
}
