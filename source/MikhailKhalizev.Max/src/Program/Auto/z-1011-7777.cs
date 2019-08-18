using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_7777-1ff36bad")]
        public void Method_1011_7777()
        {
            ii(0x1011_7777, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_777c, 5); calld(Definitions.sys_check_available_stack_size, 0x4_e5d1); /* call 0x10165d52 */
            ii(0x1011_7781, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_7782, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_7783, 1); pushd(esi);                             /* push esi */
            ii(0x1011_7784, 1); pushd(edi);                             /* push edi */
            ii(0x1011_7785, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_7786, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7788, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_778e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_7791, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_7794, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1011_779b, 2); if(jzd(0x1011_77b1, 0x14)) goto l_0x1011_77b1; /* jz 0x101177b1 */
            ii(0x1011_779d, 5); mov(edx, 0x101b_66c8);                  /* mov edx, 0x101b66c8 */
            ii(0x1011_77a2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_77a5, 5); calld(Definitions.sys_call_dtor_arr, 0x4_e80e); /* call 0x10165fb8 */
            ii(0x1011_77aa, 5); calld(Definitions.sys_delete_arr, 0x4_e829); /* call 0x10165fd8 */
            ii(0x1011_77af, 2); jmpd(0x1011_77fa, 0x49); goto l_0x1011_77fa; /* jmp 0x101177fa */
        l_0x1011_77b1:
            ii(0x1011_77b1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_77b4, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_6730); /* mov dword [eax+0x2], 0x101b6730 */
            ii(0x1011_77bb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_77be, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1011_77c1, 5); calld(Definitions.sys_delete, 0x4_e79e); /* call 0x10165f64 */
            ii(0x1011_77c6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_77c8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_77cb, 3); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x1011_77ce, 5); calld(0x1007_5f2c, -0xa_18a7);          /* call 0x10075f2c */
            ii(0x1011_77d3, 3); sub(eax, 0xc);                          /* sub eax, 0xc */
            ii(0x1011_77d6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_77d9, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_77de, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_77e1, 5); calld(0x1013_ab27, 0x2_3341);           /* call 0x1013ab27 */
            ii(0x1011_77e6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_77e9, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1011_77f0, 2); if(jzd(0x1011_77fa, 0x8)) goto l_0x1011_77fa; /* jz 0x101177fa */
            ii(0x1011_77f2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_77f5, 5); calld(Definitions.sys_delete, 0x4_e76a); /* call 0x10165f64 */
        l_0x1011_77fa:
            ii(0x1011_77fa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_77fd, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_7800, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_7803, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7805, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_7806, 1); popd(edi);                              /* pop edi */
            ii(0x1011_7807, 1); popd(esi);                              /* pop esi */
            ii(0x1011_7808, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_7809, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_780a, 1); retd(); return;                         /* ret */
        }
    }
}
