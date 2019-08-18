using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_6351-612a3881")]
        public void Method_100a_6351()
        {
            ii(0x100a_6351, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_6356, 5); calld(Definitions.sys_check_available_stack_size, 0xb_f9f7); /* call 0x10165d52 */
            ii(0x100a_635b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_635c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_635d, 1); pushd(edx);                             /* push edx */
            ii(0x100a_635e, 1); pushd(esi);                             /* push esi */
            ii(0x100a_635f, 1); pushd(edi);                             /* push edi */
            ii(0x100a_6360, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_6361, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_6363, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_6369, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_636c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_636f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6372, 5); calld(Definitions.my_2_get_count, -0x1_b00f); /* call 0x1008b368 */
            ii(0x100a_6377, 1); cwde();                                 /* cwde */
            ii(0x100a_6378, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_637a, 2); if(jzd(0x100a_638d, 0x11)) goto l_0x100a_638d; /* jz 0x100a638d */
            ii(0x100a_637c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_637e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6381, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_6384, 5); calld(0x1013_ad11, 0x9_4988);           /* call 0x1013ad11 */
            ii(0x100a_6389, 2); test(al, al);                           /* test al, al */
            ii(0x100a_638b, 2); if(jzd(0x100a_6393, 0x6)) goto l_0x100a_6393; /* jz 0x100a6393 */
        l_0x100a_638d:
            ii(0x100a_638d, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_6391, 2); jmpd(0x100a_63b0, 0x1d); goto l_0x100a_63b0; /* jmp 0x100a63b0 */
        l_0x100a_6393:
            ii(0x100a_6393, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6396, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_6399, 5); calld(0x1008_af28, -0x1_b476);          /* call 0x1008af28 */
            ii(0x100a_639e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_63a1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_63a4, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100a_63a7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_63aa, 3); calld_abs(memd_a32[ds, edx + 0x24]);    /* call dword [edx+0x24] */
            ii(0x100a_63ad, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
        l_0x100a_63b0:
            ii(0x100a_63b0, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100a_63b3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_63b5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_63b6, 1); popd(edi);                              /* pop edi */
            ii(0x100a_63b7, 1); popd(esi);                              /* pop esi */
            ii(0x100a_63b8, 1); popd(edx);                              /* pop edx */
            ii(0x100a_63b9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_63ba, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_63bb, 1); retd(); return;                         /* ret */
        }
    }
}
