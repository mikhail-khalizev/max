using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_bb64-734bcbb2")]
        public void Method_1009_bb64()
        {
            ii(0x1009_bb64, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_bb69, 5); calld(Definitions.sys_check_available_stack_size, 0xc_a1e4); /* call 0x10165d52 */
            ii(0x1009_bb6e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_bb6f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_bb70, 1); pushd(esi);                             /* push esi */
            ii(0x1009_bb71, 1); pushd(edi);                             /* push edi */
            ii(0x1009_bb72, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_bb73, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_bb75, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_bb7b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bb7e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_bb81, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_bb88, 2); if(jzd(0x1009_bb9e, 0x14)) goto l_0x1009_bb9e; /* jz 0x1009bb9e */
            ii(0x1009_bb8a, 5); mov(edx, 0x101b_40a8);                  /* mov edx, 0x101b40a8 */
            ii(0x1009_bb8f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bb92, 5); calld(Definitions.sys_call_dtor_arr, 0xc_a421); /* call 0x10165fb8 */
            ii(0x1009_bb97, 5); calld(Definitions.sys_delete_arr, 0xc_a43c); /* call 0x10165fd8 */
            ii(0x1009_bb9c, 2); jmpd(0x1009_bbe5, 0x47); goto l_0x1009_bbe5; /* jmp 0x1009bbe5 */
        l_0x1009_bb9e:
            ii(0x1009_bb9e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_bba0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bba3, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_bba6, 5); calld(0x1009_ba2c, -0x17f);             /* call 0x1009ba2c */
            ii(0x1009_bbab, 3); sub(eax, 0x21);                         /* sub eax, 0x21 */
            ii(0x1009_bbae, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bbb1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_bbb3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bbb6, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_bbb9, 5); calld(Definitions.my_dtor_0x101b_56fc, -0x1_2f82); /* call 0x10088c3c */
            ii(0x1009_bbbe, 3); sub(eax, 0x17);                         /* sub eax, 0x17 */
            ii(0x1009_bbc1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bbc4, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_bbc9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bbcc, 5); calld(0x100a_284c, 0x6c7b);             /* call 0x100a284c */
            ii(0x1009_bbd1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bbd4, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1009_bbdb, 2); if(jzd(0x1009_bbe5, 0x8)) goto l_0x1009_bbe5; /* jz 0x1009bbe5 */
            ii(0x1009_bbdd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bbe0, 5); calld(Definitions.sys_delete, 0xc_a37f); /* call 0x10165f64 */
        l_0x1009_bbe5:
            ii(0x1009_bbe5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bbe8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_bbeb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_bbee, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_bbf0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_bbf1, 1); popd(edi);                              /* pop edi */
            ii(0x1009_bbf2, 1); popd(esi);                              /* pop esi */
            ii(0x1009_bbf3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_bbf4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_bbf5, 1); retd();                                 /* ret */
        }
    }
}
