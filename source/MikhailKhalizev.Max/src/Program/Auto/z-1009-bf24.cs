using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a2aa78fc-cbc0-4bdb-bfea-9e32c5b5e84f")]
        public void Method_1009_bf24()
        {
            ii(0x1009_bf24, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_bf29, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9e24); /* call 0x10165d52 */
            ii(0x1009_bf2e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_bf2f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_bf30, 1); pushd(esi);                             /* push esi */
            ii(0x1009_bf31, 1); pushd(edi);                             /* push edi */
            ii(0x1009_bf32, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_bf33, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_bf35, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_bf3b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bf3e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_bf41, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_bf48, 2); if(jzd(0x1009_bf5e, 0x14)) goto l_0x1009_bf5e; /* jz 0x1009bf5e */
            ii(0x1009_bf4a, 5); mov(edx, 0x101b_4134);                  /* mov edx, 0x101b4134 */
            ii(0x1009_bf4f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bf52, 5); calld(Definitions.sys_call_dtor_arr, 0xc_a061); /* call 0x10165fb8 */
            ii(0x1009_bf57, 5); calld(Definitions.sys_delete_arr, 0xc_a07c); /* call 0x10165fd8 */
            ii(0x1009_bf5c, 2); jmpd(0x1009_bfa5, 0x47); goto l_0x1009_bfa5; /* jmp 0x1009bfa5 */
        l_0x1009_bf5e:
            ii(0x1009_bf5e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_bf60, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bf63, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_bf66, 5); calld(0x1007_5f2c, -0x2_603f);          /* call 0x10075f2c */
            ii(0x1009_bf6b, 3); sub(eax, 0x17);                         /* sub eax, 0x17 */
            ii(0x1009_bf6e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bf71, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_bf73, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bf76, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_bf79, 5); calld(0x1007_5f2c, -0x2_6052);          /* call 0x10075f2c */
            ii(0x1009_bf7e, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1009_bf81, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bf84, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_bf89, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bf8c, 5); calld(0x100a_284c, 0x68bb);             /* call 0x100a284c */
            ii(0x1009_bf91, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bf94, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1009_bf9b, 2); if(jzd(0x1009_bfa5, 0x8)) goto l_0x1009_bfa5; /* jz 0x1009bfa5 */
            ii(0x1009_bf9d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bfa0, 5); calld(Definitions.sys_delete, 0xc_9fbf); /* call 0x10165f64 */
        l_0x1009_bfa5:
            ii(0x1009_bfa5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bfa8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_bfab, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_bfae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_bfb0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_bfb1, 1); popd(edi);                              /* pop edi */
            ii(0x1009_bfb2, 1); popd(esi);                              /* pop esi */
            ii(0x1009_bfb3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_bfb4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_bfb5, 1); retd(); return;                         /* ret */
        }
    }
}
