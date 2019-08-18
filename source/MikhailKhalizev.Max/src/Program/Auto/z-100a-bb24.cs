using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3587f7b1-16cc-4f36-841a-d10692c9dea7")]
        public void Method_100a_bb24()
        {
            ii(0x100a_bb24, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_bb29, 5); calld(Definitions.sys_check_available_stack_size, 0xb_a224); /* call 0x10165d52 */
            ii(0x100a_bb2e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_bb2f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_bb30, 1); pushd(edx);                             /* push edx */
            ii(0x100a_bb31, 1); pushd(esi);                             /* push esi */
            ii(0x100a_bb32, 1); pushd(edi);                             /* push edi */
            ii(0x100a_bb33, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_bb34, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_bb36, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_bb3c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_bb3f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_bb41, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_bb44, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_bb47, 5); calld(0x1013_ad71, 0x8_f225);           /* call 0x1013ad71 */
            ii(0x100a_bb4c, 2); test(al, al);                           /* test al, al */
            ii(0x100a_bb4e, 2); if(jzd(0x100a_bbaf, 0x5f)) goto l_0x100a_bbaf; /* jz 0x100abbaf */
            ii(0x100a_bb50, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_bb52, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_bb55, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_bb58, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_bb5b, 5); calld(0x100b_7f18, 0xc3b8);             /* call 0x100b7f18 */
            ii(0x100a_bb60, 5); calld(Definitions.my__get_unit, 0xc4b7); /* call 0x100b801c */
            ii(0x100a_bb65, 5); calld(0x1015_2962, 0xa_6df8);           /* call 0x10152962 */
            ii(0x100a_bb6a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_bb6d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_bb70, 5); calld(0x100b_7f74, 0xc3ff);             /* call 0x100b7f74 */
            ii(0x100a_bb75, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_bb77, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_bb7a, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_bb7d, 5); calld(0x1008_af84, -0x2_0bfe);          /* call 0x1008af84 */
            ii(0x100a_bb82, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100a_bb85, 3); calld_abs(memd_a32[ds, ebx + 0x1b]);    /* call dword [ebx+0x1b] */
            ii(0x100a_bb88, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_bb8a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_bb8d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_bb90, 5); calld(0x100b_7fa4, 0xc40f);             /* call 0x100b7fa4 */
            ii(0x100a_bb95, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_bb97, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_bb9a, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_bb9d, 5); calld(0x1008_afe4, -0x2_0bbe);          /* call 0x1008afe4 */
            ii(0x100a_bba2, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_bba5, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_bbaa, 5); calld(0x100a_5e27, -0x5d88);            /* call 0x100a5e27 */
        l_0x100a_bbaf:
            ii(0x100a_bbaf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_bbb1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_bbb2, 1); popd(edi);                              /* pop edi */
            ii(0x100a_bbb3, 1); popd(esi);                              /* pop esi */
            ii(0x100a_bbb4, 1); popd(edx);                              /* pop edx */
            ii(0x100a_bbb5, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_bbb6, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_bbb7, 1); retd(); return;                         /* ret */
        }
    }
}
