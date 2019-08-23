using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9168-b1b3e0e5")]
        public void Method_1008_9168()
        {
            ii(0x1008_9168, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_916d, 5); calld(Definitions.sys_check_available_stack_size, 0xd_cbe0); /* call 0x10165d52 */
            ii(0x1008_9172, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9173, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9174, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9175, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9176, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9177, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9179, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_917f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9182, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_9185, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1008_918c, 2); if(jzd(0x1008_91a2, 0x14)) goto l_0x1008_91a2; /* jz 0x100891a2 */
            ii(0x1008_918e, 5); mov(edx, 0x101b_39f0);                  /* mov edx, 0x101b39f0 */
            ii(0x1008_9193, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9196, 5); calld(Definitions.sys_call_dtor_arr, 0xd_ce1d); /* call 0x10165fb8 */
            ii(0x1008_919b, 5); calld(Definitions.sys_delete_arr, 0xd_ce38); /* call 0x10165fd8 */
            ii(0x1008_91a0, 2); jmpd(0x1008_91e9, 0x47); goto l_0x1008_91e9; /* jmp 0x100891e9 */
        l_0x1008_91a2:
            ii(0x1008_91a2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_91a4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_91a7, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1008_91aa, 5); calld(0x1008_8a44, -0x76b);             /* call 0x10088a44 */
            ii(0x1008_91af, 3); sub(eax, 0x21);                         /* sub eax, 0x21 */
            ii(0x1008_91b2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_91b5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_91b7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_91ba, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_91bd, 5); calld(Definitions.my_dtor_0x101b_56fc, -0x586); /* call 0x10088c3c */
            ii(0x1008_91c2, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1008_91c5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_91c8, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_91cd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_91d0, 5); calld(0x100a_284c, 0x1_9677);           /* call 0x100a284c */
            ii(0x1008_91d5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_91d8, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1008_91df, 2); if(jzd(0x1008_91e9, 0x8)) goto l_0x1008_91e9; /* jz 0x100891e9 */
            ii(0x1008_91e1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_91e4, 5); calld(Definitions.sys_delete, 0xd_cd7b); /* call 0x10165f64 */
        l_0x1008_91e9:
            ii(0x1008_91e9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_91ec, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_91ef, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_91f2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_91f4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_91f5, 1); popd(edi);                              /* pop edi */
            ii(0x1008_91f6, 1); popd(esi);                              /* pop esi */
            ii(0x1008_91f7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_91f8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_91f9, 1); retd();                                 /* ret */
        }
    }
}
