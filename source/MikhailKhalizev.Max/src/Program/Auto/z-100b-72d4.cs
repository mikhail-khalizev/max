using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3ae72af6-27ea-45ad-89c8-06375f0c335d")]
        public void Method_100b_72d4()
        {
            ii(0x100b_72d4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_72d9, 5); calld(Definitions.sys_check_available_stack_size, 0xa_ea74); /* call 0x10165d52 */
            ii(0x100b_72de, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_72df, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_72e0, 1); pushd(esi);                             /* push esi */
            ii(0x100b_72e1, 1); pushd(edi);                             /* push edi */
            ii(0x100b_72e2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_72e3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_72e5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_72eb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_72ee, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_72f1, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100b_72f8, 2); if(jzd(0x100b_730e, 0x14)) goto l_0x100b_730e; /* jz 0x100b730e */
            ii(0x100b_72fa, 5); mov(edx, 0x101b_5058);                  /* mov edx, 0x101b5058 */
            ii(0x100b_72ff, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7302, 5); calld(Definitions.sys_call_dtor_arr, 0xa_ecb1); /* call 0x10165fb8 */
            ii(0x100b_7307, 5); calld(Definitions.sys_delete_arr, 0xa_eccc); /* call 0x10165fd8 */
            ii(0x100b_730c, 2); jmpd(0x100b_7355, 0x47); goto l_0x100b_7355; /* jmp 0x100b7355 */
        l_0x100b_730e:
            ii(0x100b_730e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_7310, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7313, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x100b_7316, 5); calld(0x1007_5f2c, -0x4_13ef);          /* call 0x10075f2c */
            ii(0x100b_731b, 3); sub(eax, 0x16);                         /* sub eax, 0x16 */
            ii(0x100b_731e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7321, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_7323, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7326, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100b_7329, 5); calld(0x1007_5f2c, -0x4_1402);          /* call 0x10075f2c */
            ii(0x100b_732e, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x100b_7331, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7334, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_7339, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_733c, 5); calld(0x1013_ab27, 0x8_37e6);           /* call 0x1013ab27 */
            ii(0x100b_7341, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7344, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100b_734b, 2); if(jzd(0x100b_7355, 0x8)) goto l_0x100b_7355; /* jz 0x100b7355 */
            ii(0x100b_734d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7350, 5); calld(Definitions.sys_delete, 0xa_ec0f); /* call 0x10165f64 */
        l_0x100b_7355:
            ii(0x100b_7355, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7358, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_735b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_735e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7360, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7361, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7362, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7363, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7364, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7365, 1); retd(); return;                         /* ret */
        }
    }
}
