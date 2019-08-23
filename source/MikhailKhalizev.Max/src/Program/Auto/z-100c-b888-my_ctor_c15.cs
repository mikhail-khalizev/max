using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b888-c90ef039")]
        public void my_ctor_c15()
        {
            ii(0x100c_b888, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100c_b88d, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a4c0); /* call 0x10165d52 */
            ii(0x100c_b892, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b893, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b894, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b895, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b896, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b897, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b899, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100c_b89f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b8a2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_b8a5, 5); mov(ecx, 0x1100);                       /* mov ecx, 0x1100 */
            ii(0x100c_b8aa, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_b8ac, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b8af, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100c_b8b2, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100c_b8b4, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_b8b7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b8ba, 5); calld(0x100a_26d1, -0x2_91ee);          /* call 0x100a26d1 */
            ii(0x100c_b8bf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b8c2, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100c_b8c5, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_b8c8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b8cb, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_b8ce, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x5_51e3); /* call 0x100766f0 */
            ii(0x100c_b8d3, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100c_b8d6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b8d9, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100c_b8dc, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_b8df, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b8e2, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_b8e5, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x5_51fa); /* call 0x100766f0 */
            ii(0x100c_b8ea, 3); sub(eax, 0x17);                         /* sub eax, 0x17 */
            ii(0x100c_b8ed, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b8f0, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100c_b8f3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_b8f6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b8f9, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_5ae4); /* mov dword [eax+0x2], 0x101b5ae4 */
            ii(0x100c_b900, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_b903, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b906, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_b909, 5); calld(0x1007_6630, -0x5_52de);          /* call 0x10076630 */
            ii(0x100c_b90e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b911, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_b914, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100c_b917, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b919, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b91a, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b91b, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b91c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b91d, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b91e, 1); retd();                                 /* ret */
        }
    }
}
