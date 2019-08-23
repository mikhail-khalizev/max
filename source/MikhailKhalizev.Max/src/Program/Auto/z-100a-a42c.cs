using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a42c-f41d244")]
        public void Method_100a_a42c()
        {
            ii(0x100a_a42c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_a431, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b91c); /* call 0x10165d52 */
            ii(0x100a_a436, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_a437, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a438, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a439, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a43a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a43b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a43d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a443, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a446, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_a449, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100a_a450, 2); if(jzd(0x100a_a466, 0x14)) goto l_0x100a_a466; /* jz 0x100aa466 */
            ii(0x100a_a452, 5); mov(edx, 0x101b_4ca4);                  /* mov edx, 0x101b4ca4 */
            ii(0x100a_a457, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a45a, 5); calld(Definitions.sys_call_dtor_arr, 0xb_bb59); /* call 0x10165fb8 */
            ii(0x100a_a45f, 5); calld(Definitions.sys_delete_arr, 0xb_bb74); /* call 0x10165fd8 */
            ii(0x100a_a464, 2); jmpd(0x100a_a4c0, 0x5a); goto l_0x100a_a4c0; /* jmp 0x100aa4c0 */
        l_0x100a_a466:
            ii(0x100a_a466, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_a468, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a46b, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_a46e, 5); calld(0x1008_8b7c, -0x2_18f7);          /* call 0x10088b7c */
            ii(0x100a_a473, 3); sub(eax, 0x1a);                         /* sub eax, 0x1a */
            ii(0x100a_a476, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a479, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_a47b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a47e, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x100a_a481, 5); calld(0x1007_5f2c, -0x3_455a);          /* call 0x10075f2c */
            ii(0x100a_a486, 3); sub(eax, 0x16);                         /* sub eax, 0x16 */
            ii(0x100a_a489, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a48c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_a48e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a491, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_a494, 5); calld(0x100a_a3c0, -0xd9);              /* call 0x100aa3c0 */
            ii(0x100a_a499, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x100a_a49c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a49f, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_a4a4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a4a7, 5); calld(0x1013_ab27, 0x9_067b);           /* call 0x1013ab27 */
            ii(0x100a_a4ac, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a4af, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100a_a4b6, 2); if(jzd(0x100a_a4c0, 0x8)) goto l_0x100a_a4c0; /* jz 0x100aa4c0 */
            ii(0x100a_a4b8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a4bb, 5); calld(Definitions.sys_delete, 0xb_baa4); /* call 0x10165f64 */
        l_0x100a_a4c0:
            ii(0x100a_a4c0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a4c3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_a4c6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_a4c9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a4cb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a4cc, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a4cd, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a4ce, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a4cf, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_a4d0, 1); retd();                                 /* ret */
        }
    }
}
