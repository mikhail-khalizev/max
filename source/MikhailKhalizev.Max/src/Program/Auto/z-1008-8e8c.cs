using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7526e423-28e4-429f-88fe-507e0bb9d675")]
        public void Method_1008_8e8c()
        {
            ii(0x1008_8e8c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_8e91, 5); calld(Definitions.sys_check_available_stack_size, 0xd_cebc); /* call 0x10165d52 */
            ii(0x1008_8e96, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_8e97, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_8e98, 1); pushd(esi);                             /* push esi */
            ii(0x1008_8e99, 1); pushd(edi);                             /* push edi */
            ii(0x1008_8e9a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_8e9b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8e9d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8ea3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8ea6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_8ea9, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1008_8eb0, 2); if(jzd(0x1008_8ec6, 0x14)) goto l_0x1008_8ec6; /* jz 0x10088ec6 */
            ii(0x1008_8eb2, 5); mov(edx, 0x101b_39b4);                  /* mov edx, 0x101b39b4 */
            ii(0x1008_8eb7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8eba, 5); calld(Definitions.sys_call_dtor_arr, 0xd_d0f9); /* call 0x10165fb8 */
            ii(0x1008_8ebf, 5); calld(Definitions.sys_delete_arr, 0xd_d114); /* call 0x10165fd8 */
            ii(0x1008_8ec4, 2); jmpd(0x1008_8efa, 0x34); goto l_0x1008_8efa; /* jmp 0x10088efa */
        l_0x1008_8ec6:
            ii(0x1008_8ec6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_8ec8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8ecb, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_8ece, 5); calld(Definitions.my_dtor_0x101b56fc, -0x297); /* call 0x10088c3c */
            ii(0x1008_8ed3, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1008_8ed6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8ed9, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_8ede, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8ee1, 5); calld(0x100a_284c, 0x1_9966);           /* call 0x100a284c */
            ii(0x1008_8ee6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8ee9, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1008_8ef0, 2); if(jzd(0x1008_8efa, 0x8)) goto l_0x1008_8efa; /* jz 0x10088efa */
            ii(0x1008_8ef2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8ef5, 5); calld(Definitions.sys_delete, 0xd_d06a); /* call 0x10165f64 */
        l_0x1008_8efa:
            ii(0x1008_8efa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8efd, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_8f00, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_8f03, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8f05, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_8f06, 1); popd(edi);                              /* pop edi */
            ii(0x1008_8f07, 1); popd(esi);                              /* pop esi */
            ii(0x1008_8f08, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_8f09, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_8f0a, 1); retd(); return;                         /* ret */
        }
    }
}
