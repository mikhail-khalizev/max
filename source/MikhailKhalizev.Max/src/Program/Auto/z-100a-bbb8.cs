using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4d2cada6-815b-48db-a40a-e6c3d4a55475")]
        public void Method_100a_bbb8()
        {
            ii(0x100a_bbb8, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_bbbd, 5); calld(Definitions.sys_check_available_stack_size, 0xb_a190); /* call 0x10165d52 */
            ii(0x100a_bbc2, 1); pushd(esi);                             /* push esi */
            ii(0x100a_bbc3, 1); pushd(edi);                             /* push edi */
            ii(0x100a_bbc4, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_bbc5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_bbc7, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100a_bbcd, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_bbd0, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100a_bbd3, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100a_bbd6, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x100a_bbd9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_bbdb, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100a_bbde, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_bbe1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_bbe4, 5); calld(0x100b_7f18, 0xc32f);             /* call 0x100b7f18 */
            ii(0x100a_bbe9, 5); calld(Definitions.my__get_unit, 0xc42e); /* call 0x100b801c */
            ii(0x100a_bbee, 5); calld(0x1015_2962, 0xa_6d6f);           /* call 0x10152962 */
            ii(0x100a_bbf3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_bbf5, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100a_bbf8, 1); pushd(eax);                             /* push eax */
            ii(0x100a_bbf9, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x100a_bbfc, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_bbff, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_bc02, 5); calld(0x1007_5e64, -0x3_5da3);          /* call 0x10075e64 */
            ii(0x100a_bc07, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_bc09, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_bc0c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_bc0f, 5); calld(0x100b_7f74, 0xc360);             /* call 0x100b7f74 */
            ii(0x100a_bc14, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_bc16, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_bc19, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_bc1c, 5); calld(0x1008_af84, -0x2_0c9d);          /* call 0x1008af84 */
            ii(0x100a_bc21, 3); mov(esi, memd_a32[ss, ebp - 0x10]);     /* mov esi, [ebp-0x10] */
            ii(0x100a_bc24, 3); calld_abs(memd_a32[ds, esi + 0x17]);    /* call dword [esi+0x17] */
            ii(0x100a_bc27, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_bc29, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_bc2c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_bc2f, 5); calld(0x100b_7fa4, 0xc370);             /* call 0x100b7fa4 */
            ii(0x100a_bc34, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_bc36, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_bc39, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_bc3c, 5); calld(0x1008_afe4, -0x2_0c5d);          /* call 0x1008afe4 */
            ii(0x100a_bc41, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100a_bc44, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_bc49, 5); calld(0x100a_5e27, -0x5e27);            /* call 0x100a5e27 */
            ii(0x100a_bc4e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_bc50, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_bc51, 1); popd(edi);                              /* pop edi */
            ii(0x100a_bc52, 1); popd(esi);                              /* pop esi */
            ii(0x100a_bc53, 1); retd(); return;                         /* ret */
        }
    }
}
