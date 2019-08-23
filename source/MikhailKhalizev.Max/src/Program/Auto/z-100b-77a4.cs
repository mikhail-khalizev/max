using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_77a4-c012e3cb")]
        public void Method_100b_77a4()
        {
            ii(0x100b_77a4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_77a9, 5); calld(Definitions.sys_check_available_stack_size, 0xa_e5a4); /* call 0x10165d52 */
            ii(0x100b_77ae, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_77af, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_77b0, 1); pushd(esi);                             /* push esi */
            ii(0x100b_77b1, 1); pushd(edi);                             /* push edi */
            ii(0x100b_77b2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_77b3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_77b5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_77bb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_77be, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_77c1, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100b_77c8, 2); if(jzd(0x100b_77de, 0x14)) goto l_0x100b_77de; /* jz 0x100b77de */
            ii(0x100b_77ca, 5); mov(edx, 0x101b_50e4);                  /* mov edx, 0x101b50e4 */
            ii(0x100b_77cf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_77d2, 5); calld(Definitions.sys_call_dtor_arr, 0xa_e7e1); /* call 0x10165fb8 */
            ii(0x100b_77d7, 5); calld(Definitions.sys_delete_arr, 0xa_e7fc); /* call 0x10165fd8 */
            ii(0x100b_77dc, 2); jmpd(0x100b_7838, 0x5a); goto l_0x100b_7838; /* jmp 0x100b7838 */
        l_0x100b_77de:
            ii(0x100b_77de, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_77e0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_77e3, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100b_77e6, 5); calld(0x1009_b8ec, -0x1_beff);          /* call 0x1009b8ec */
            ii(0x100b_77eb, 3); sub(eax, 0x1b);                         /* sub eax, 0x1b */
            ii(0x100b_77ee, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_77f1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_77f3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_77f6, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_77f9, 5); calld(0x1007_5f2c, -0x4_18d2);          /* call 0x10075f2c */
            ii(0x100b_77fe, 3); sub(eax, 0x17);                         /* sub eax, 0x17 */
            ii(0x100b_7801, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7804, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_7806, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7809, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_780c, 5); calld(0x1007_5f2c, -0x4_18e5);          /* call 0x10075f2c */
            ii(0x100b_7811, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100b_7814, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7817, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_781c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_781f, 5); calld(0x100a_284c, -0x1_4fd8);          /* call 0x100a284c */
            ii(0x100b_7824, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7827, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100b_782e, 2); if(jzd(0x100b_7838, 0x8)) goto l_0x100b_7838; /* jz 0x100b7838 */
            ii(0x100b_7830, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7833, 5); calld(Definitions.sys_delete, 0xa_e72c); /* call 0x10165f64 */
        l_0x100b_7838:
            ii(0x100b_7838, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_783b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_783e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_7841, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7843, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7844, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7845, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7846, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7847, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7848, 1); retd();                                 /* ret */
        }
    }
}
