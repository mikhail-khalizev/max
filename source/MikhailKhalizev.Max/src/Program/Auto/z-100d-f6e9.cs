using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_f6e9-262084ca")]
        public void Method_100d_f6e9()
        {
            ii(0x100d_f6e9, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100d_f6ee, 5); calld(Definitions.sys_check_available_stack_size, 0x8_665f); /* call 0x10165d52 */
            ii(0x100d_f6f3, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_f6f4, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_f6f5, 1); pushd(esi);                             /* push esi */
            ii(0x100d_f6f6, 1); pushd(edi);                             /* push edi */
            ii(0x100d_f6f7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_f6f8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_f6fa, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100d_f700, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_f703, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_f706, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f709, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x100d_f70c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_f70f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_f712, 5); calld(0x1013_c0fa, 0x5_c9e3);           /* call 0x1013c0fa */
            ii(0x100d_f717, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100d_f71e, 2); jmpd(0x100d_f726, 0x6); goto l_0x100d_f726; /* jmp 0x100df726 */
        l_0x100d_f720:
            ii(0x100d_f720, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_f723, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100d_f726:
            ii(0x100d_f726, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100d_f72a, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x100d_f72d, 2); if(jged(0x100d_f751, 0x22)) goto l_0x100d_f751; /* jge 0x100df751 */
            ii(0x100d_f72f, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100d_f733, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_f736, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100d_f739, 3); add(ebx, 0x8);                          /* add ebx, 0x8 */
            ii(0x100d_f73c, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_f73e, 5); calld(0x1007_678c, -0x6_8fb7);          /* call 0x1007678c */
            ii(0x100d_f743, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100d_f746, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f748, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100d_f74a, 5); calld(0x1013_c25c, 0x5_cb0d);           /* call 0x1013c25c */
            ii(0x100d_f74f, 2); jmpd(0x100d_f720, -0x31); goto l_0x100d_f720; /* jmp 0x100df720 */
        l_0x100d_f751:
            ii(0x100d_f751, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100d_f758, 2); jmpd(0x100d_f760, 0x6); goto l_0x100d_f760; /* jmp 0x100df760 */
        l_0x100d_f75a:
            ii(0x100d_f75a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_f75d, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100d_f760:
            ii(0x100d_f760, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100d_f764, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x100d_f767, 2); if(jged(0x100d_f78e, 0x25)) goto l_0x100d_f78e; /* jge 0x100df78e */
            ii(0x100d_f769, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100d_f76d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_f770, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100d_f773, 6); add(ebx, 0x17c);                        /* add ebx, 0x17c */
            ii(0x100d_f779, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_f77b, 5); calld(0x1007_678c, -0x6_8ff4);          /* call 0x1007678c */
            ii(0x100d_f780, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100d_f783, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f785, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100d_f787, 5); calld(0x1013_c25c, 0x5_cad0);           /* call 0x1013c25c */
            ii(0x100d_f78c, 2); jmpd(0x100d_f75a, -0x34); goto l_0x100d_f75a; /* jmp 0x100df75a */
        l_0x100d_f78e:
            ii(0x100d_f78e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f791, 5); add(eax, 0x2f0);                        /* add eax, 0x2f0 */
            ii(0x100d_f796, 5); calld(0x1007_6b90, -0x6_8c0b);          /* call 0x10076b90 */
            ii(0x100d_f79b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f79d, 3); mov(dx, ax);                            /* mov dx, ax */
            ii(0x100d_f7a0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_f7a3, 5); calld(0x100e_0dc8, 0x1620);             /* call 0x100e0dc8 */
            ii(0x100d_f7a8, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100d_f7ac, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_f7af, 5); calld(0x100e_0608, 0xe54);              /* call 0x100e0608 */
            ii(0x100d_f7b4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_f7b7, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100d_f7bb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f7be, 5); add(eax, 0x2f0);                        /* add eax, 0x2f0 */
            ii(0x100d_f7c3, 5); calld(0x100e_0cf0, 0x1528);             /* call 0x100e0cf0 */
            ii(0x100d_f7c8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f7ca, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_f7cd, 5); calld(0x100e_0548, 0xd76);              /* call 0x100e0548 */
            ii(0x100d_f7d2, 2); jmpd(0x100d_f7dc, 0x8); goto l_0x100d_f7dc; /* jmp 0x100df7dc */
        l_0x100d_f7d4:
            ii(0x100d_f7d4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_f7d7, 5); calld(0x1007_6bf8, -0x6_8be4);          /* call 0x10076bf8 */
        l_0x100d_f7dc:
            ii(0x100d_f7dc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f7de, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_f7e1, 5); calld(0x1013_ad71, 0x5_b58b);           /* call 0x1013ad71 */
            ii(0x100d_f7e6, 2); test(al, al);                           /* test al, al */
            ii(0x100d_f7e8, 2); if(jzd(0x100d_f7fe, 0x14)) goto l_0x100d_f7fe; /* jz 0x100df7fe */
            ii(0x100d_f7ea, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_f7ed, 5); calld(0x100e_04e4, 0xcf2);              /* call 0x100e04e4 */
            ii(0x100d_f7f2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f7f4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_f7f7, 5); calld(0x1013_c25c, 0x5_ca60);           /* call 0x1013c25c */
            ii(0x100d_f7fc, 2); jmpd(0x100d_f7d4, -0x2a); goto l_0x100d_f7d4; /* jmp 0x100df7d4 */
        l_0x100d_f7fe:
            ii(0x100d_f7fe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f800, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_f803, 5); calld(0x100e_043c, 0xc34);              /* call 0x100e043c */
            ii(0x100d_f808, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_f80a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_f80b, 1); popd(edi);                              /* pop edi */
            ii(0x100d_f80c, 1); popd(esi);                              /* pop esi */
            ii(0x100d_f80d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_f80e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_f80f, 1); retd(); return;                         /* ret */
        }
    }
}
