using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_e775-ef765978")]
        public void Method_1012_e775()
        {
            ii(0x1012_e775, 5); push(0x4c);                             /* push 0x4c */
            ii(0x1012_e77a, 5); call(Definitions.sys_check_available_stack_size, 0x3_75d3); /* call 0x10165d52 */
            ii(0x1012_e77f, 1); push(ebx);                              /* push ebx */
            ii(0x1012_e780, 1); push(ecx);                              /* push ecx */
            ii(0x1012_e781, 1); push(edx);                              /* push edx */
            ii(0x1012_e782, 1); push(esi);                              /* push esi */
            ii(0x1012_e783, 1); push(edi);                              /* push edi */
            ii(0x1012_e784, 1); push(ebp);                              /* push ebp */
            ii(0x1012_e785, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_e787, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1012_e78d, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_e790, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1012_e795, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1012_e798, 5); call(0x1007_6668, -0xb_8135);           /* call 0x10076668 */
            ii(0x1012_e79d, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1012_e7a4, 2); if(jz(0x1012_e7b8, 0x12)) goto l_0x1012_e7b8; /* jz 0x1012e7b8 */
            ii(0x1012_e7a6, 5); call(0x100d_5094, -0x5_9717);           /* call 0x100d5094 */
            ii(0x1012_e7ab, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_e7ad, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1012_e7af, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_e7b1, 5); call(0x1010_0e32, -0x2_d984);           /* call 0x10100e32 */
            ii(0x1012_e7b6, 2); jmp(0x1012_e7ca, 0x12); goto l_0x1012_e7ca; /* jmp 0x1012e7ca */
        l_0x1012_e7b8:
            ii(0x1012_e7b8, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_e7bd, 5); mov(eax, memd[ds, 0x101c_3960]);        /* mov eax, [0x101c3960] */
            ii(0x1012_e7c2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_e7c5, 5); call(0x100f_334b, -0x3_b47f);           /* call 0x100f334b */
        l_0x1012_e7ca:
            ii(0x1012_e7ca, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e7cd, 7); mov(memb[ds, eax + 0x9d], 0);           /* mov byte [eax+0x9d], 0x0 */
        l_0x1012_e7d4:
            ii(0x1012_e7d4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e7d7, 7); cmp(memb[ds, eax + 0x9d], 0);           /* cmp byte [eax+0x9d], 0x0 */
            ii(0x1012_e7de, 6); if(jnz(0x1012_ea46, 0x262)) goto l_0x1012_ea46; /* jnz 0x1012ea46 */
            ii(0x1012_e7e4, 5); call(/* sys */ 0x1016_b208, 0x3_ca1f);  /* call 0x1016b208 */
            ii(0x1012_e7e9, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1012_e7ec, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_e7ef, 5); call(0x100e_ad24, -0x4_3ad0);           /* call 0x100ead24 */
            ii(0x1012_e7f4, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_e7f7, 5); call(0x100e_a933, -0x4_3ec9);           /* call 0x100ea933 */
            ii(0x1012_e7fc, 2); test(al, al);                           /* test al, al */
            ii(0x1012_e7fe, 2); if(jz(0x1012_e80a, 0xa)) goto l_0x1012_e80a; /* jz 0x1012e80a */
            ii(0x1012_e800, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_e802, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1012_e805, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1012_e808, 2); if(jz(0x1012_e80c, 0x2)) goto l_0x1012_e80c; /* jz 0x1012e80c */
        l_0x1012_e80a:
            ii(0x1012_e80a, 2); jmp(0x1012_e820, 0x14); goto l_0x1012_e820; /* jmp 0x1012e820 */
        l_0x1012_e80c:
            ii(0x1012_e80c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e80f, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_e815, 5); call(0x100d_4ef0, -0x5_992a);           /* call 0x100d4ef0 */
            ii(0x1012_e81a, 4); cmp(ax, memw[ss, ebp - 0x13]);          /* cmp ax, [ebp-0x13] */
            ii(0x1012_e81e, 2); if(jle(0x1012_e822, 0x2)) goto l_0x1012_e822; /* jle 0x1012e822 */
        l_0x1012_e820:
            ii(0x1012_e820, 2); jmp(0x1012_e84c, 0x2a); goto l_0x1012_e84c; /* jmp 0x1012e84c */
        l_0x1012_e822:
            ii(0x1012_e822, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e825, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_e82b, 5); call(0x100d_4ef0, -0x5_9940);           /* call 0x100d4ef0 */
            ii(0x1012_e830, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_e833, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e836, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_e83c, 5); call(0x100d_4f58, -0x5_98e9);           /* call 0x100d4f58 */
            ii(0x1012_e841, 1); cwde();                                 /* cwde */
            ii(0x1012_e842, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_e844, 4); movsx(edx, memw[ss, ebp - 0x13]);       /* movsx edx, word [ebp-0x13] */
            ii(0x1012_e848, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_e84a, 2); if(jl(0x1012_e84e, 0x2)) goto l_0x1012_e84e; /* jl 0x1012e84e */
        l_0x1012_e84c:
            ii(0x1012_e84c, 2); jmp(0x1012_e862, 0x14); goto l_0x1012_e862; /* jmp 0x1012e862 */
        l_0x1012_e84e:
            ii(0x1012_e84e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e851, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_e857, 5); call(0x100d_4ebc, -0x5_99a0);           /* call 0x100d4ebc */
            ii(0x1012_e85c, 4); cmp(ax, memw[ss, ebp - 0x11]);          /* cmp ax, [ebp-0x11] */
            ii(0x1012_e860, 2); if(jle(0x1012_e864, 0x2)) goto l_0x1012_e864; /* jle 0x1012e864 */
        l_0x1012_e862:
            ii(0x1012_e862, 2); jmp(0x1012_e88e, 0x2a); goto l_0x1012_e88e; /* jmp 0x1012e88e */
        l_0x1012_e864:
            ii(0x1012_e864, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e867, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_e86d, 5); call(0x100d_4ebc, -0x5_99b6);           /* call 0x100d4ebc */
            ii(0x1012_e872, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_e875, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e878, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_e87e, 5); call(0x100d_4f58, -0x5_992b);           /* call 0x100d4f58 */
            ii(0x1012_e883, 1); cwde();                                 /* cwde */
            ii(0x1012_e884, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_e886, 4); movsx(edx, memw[ss, ebp - 0x11]);       /* movsx edx, word [ebp-0x11] */
            ii(0x1012_e88a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_e88c, 2); if(jl(0x1012_e890, 0x2)) goto l_0x1012_e890; /* jl 0x1012e890 */
        l_0x1012_e88e:
            ii(0x1012_e88e, 2); jmp(0x1012_e8e1, 0x51); goto l_0x1012_e8e1; /* jmp 0x1012e8e1 */
        l_0x1012_e890:
            ii(0x1012_e890, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e893, 3); mov(al, memb[ds, eax + 0x17]);          /* mov al, [eax+0x17] */
            ii(0x1012_e896, 3); mov(memb[ss, ebp - 0x18], al);          /* mov [ebp-0x18], al */
            ii(0x1012_e899, 2); jmp(0x1012_e8cb, 0x30); goto l_0x1012_e8cb; /* jmp 0x1012e8cb */
        l_0x1012_e89b:
            ii(0x1012_e89b, 3); lea(edx, ebp - 0x13);                   /* lea edx, [ebp-0x13] */
            ii(0x1012_e89e, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1012_e8a1, 5); call(0x1007_5e64, -0xb_8a42);           /* call 0x10075e64 */
            ii(0x1012_e8a6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_e8a8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e8ab, 5); call(0x1012_e6a8, -0x208);              /* call 0x1012e6a8 */
            ii(0x1012_e8b0, 2); jmp(0x1012_e8e1, 0x2f); goto l_0x1012_e8e1; /* jmp 0x1012e8e1 */
        l_0x1012_e8b2:
            ii(0x1012_e8b2, 3); lea(edx, ebp - 0x13);                   /* lea edx, [ebp-0x13] */
            ii(0x1012_e8b5, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1012_e8b8, 5); call(0x1007_5e64, -0xb_8a59);           /* call 0x10075e64 */
            ii(0x1012_e8bd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_e8bf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e8c2, 5); call(0x1012_e5f6, -0x2d1);              /* call 0x1012e5f6 */
            ii(0x1012_e8c7, 2); jmp(0x1012_e8e1, 0x18); goto l_0x1012_e8e1; /* jmp 0x1012e8e1 */
        l_0x1012_e8c9:
            ii(0x1012_e8c9, 2); jmp(0x1012_e8e1, 0x16); goto l_0x1012_e8e1; /* jmp 0x1012e8e1 */
        l_0x1012_e8cb:
            ii(0x1012_e8cb, 3); mov(al, memb[ss, ebp - 0x18]);          /* mov al, [ebp-0x18] */
            ii(0x1012_e8ce, 3); mov(memb[ss, ebp - 0x24], al);          /* mov [ebp-0x24], al */
            ii(0x1012_e8d1, 4); cmp(memb[ss, ebp - 0x24], 0);           /* cmp byte [ebp-0x24], 0x0 */
            ii(0x1012_e8d5, 2); if(jbe(0x1012_e89b, -0x3c)) goto l_0x1012_e89b; /* jbe 0x1012e89b */
            ii(0x1012_e8d7, 4); cmp(memb[ss, ebp - 0x24], 0x3);         /* cmp byte [ebp-0x24], 0x3 */
            ii(0x1012_e8db, 2); if(jz(0x1012_e8b2, -0x2b)) goto l_0x1012_e8b2; /* jz 0x1012e8b2 */
            ii(0x1012_e8dd, 2); jmp(0x1012_e8c9, -0x16); goto l_0x1012_e8c9; /* jmp 0x1012e8c9 */
        //  ii(0x1012_e8df, 2); jmp(0x1012_e8c9, -0x18); goto l_0x1012_e8c9; /* jmp 0x1012e8c9 */
        l_0x1012_e8e1:
            ii(0x1012_e8e1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_e8e4, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1012_e8e7, 5); jmp(0x1012_e9ba, 0xce); goto l_0x1012_e9ba; /* jmp 0x1012e9ba */
        l_0x1012_e8ec:
            ii(0x1012_e8ec, 5); call(0x1011_6ba6, -0x1_7d4b);           /* call 0x10116ba6 */
            ii(0x1012_e8f1, 5); jmp(0x1012_ea1c, 0x126); goto l_0x1012_ea1c; /* jmp 0x1012ea1c */
        l_0x1012_e8f6:
            ii(0x1012_e8f6, 5); call(0x100d_4e6c, -0x5_9a8f);           /* call 0x100d4e6c */
            ii(0x1012_e8fb, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_e8fd, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1012_e8ff, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_e901, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1012_e906, 5); call(0x1010_5b00, -0x2_8e0b);           /* call 0x10105b00 */
            ii(0x1012_e90b, 5); jmp(0x1012_ea1c, 0x10c); goto l_0x1012_ea1c; /* jmp 0x1012ea1c */
        l_0x1012_e910:
            ii(0x1012_e910, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e913, 7); mov(memb[ds, eax + 0x9d], 0x1);         /* mov byte [eax+0x9d], 0x1 */
            ii(0x1012_e91a, 5); jmp(0x1012_ea1c, 0xfd); goto l_0x1012_ea1c; /* jmp 0x1012ea1c */
        l_0x1012_e91f:
            ii(0x1012_e91f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e922, 4); cmp(memb[ds, eax + 0x17], 0);           /* cmp byte [eax+0x17], 0x0 */
            ii(0x1012_e926, 2); if(jnz(0x1012_e94a, 0x22)) goto l_0x1012_e94a; /* jnz 0x1012e94a */
            ii(0x1012_e928, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e92b, 5); call(0x1012_e160, -0x7d0);              /* call 0x1012e160 */
            ii(0x1012_e930, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1012_e933, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1012_e937, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_e939, 2); if(jle(0x1012_e94a, 0xf)) goto l_0x1012_e94a; /* jle 0x1012e94a */
            ii(0x1012_e93b, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1012_e93e, 1); dec(eax);                               /* dec eax */
            ii(0x1012_e93f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_e942, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e945, 5); call(0x1012_e1cf, -0x77b);              /* call 0x1012e1cf */
        l_0x1012_e94a:
            ii(0x1012_e94a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e94d, 4); cmp(memb[ds, eax + 0x17], 0x3);         /* cmp byte [eax+0x17], 0x3 */
            ii(0x1012_e951, 2); if(jnz(0x1012_e95b, 0x8)) goto l_0x1012_e95b; /* jnz 0x1012e95b */
            ii(0x1012_e953, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e956, 5); call(0x1012_e4ba, -0x4a1);              /* call 0x1012e4ba */
        l_0x1012_e95b:
            ii(0x1012_e95b, 5); jmp(0x1012_ea1c, 0xbc); goto l_0x1012_ea1c; /* jmp 0x1012ea1c */
        l_0x1012_e960:
            ii(0x1012_e960, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e963, 4); cmp(memb[ds, eax + 0x17], 0);           /* cmp byte [eax+0x17], 0x0 */
            ii(0x1012_e967, 2); if(jnz(0x1012_e9a2, 0x39)) goto l_0x1012_e9a2; /* jnz 0x1012e9a2 */
            ii(0x1012_e969, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e96c, 5); call(0x1012_e160, -0x811);              /* call 0x1012e160 */
            ii(0x1012_e971, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1012_e974, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1012_e978, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_e97a, 2); if(jl(0x1012_e991, 0x15)) goto l_0x1012_e991; /* jl 0x1012e991 */
            ii(0x1012_e97c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e97f, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_e982, 5); call(Definitions.my_1_get_count, -0x8_34af); /* call 0x100ab4d8 */
            ii(0x1012_e987, 1); cwde();                                 /* cwde */
            ii(0x1012_e988, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x1012_e98c, 1); dec(eax);                               /* dec eax */
            ii(0x1012_e98d, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_e98f, 2); if(jl(0x1012_e993, 0x2)) goto l_0x1012_e993; /* jl 0x1012e993 */
        l_0x1012_e991:
            ii(0x1012_e991, 2); jmp(0x1012_e9a2, 0xf); goto l_0x1012_e9a2; /* jmp 0x1012e9a2 */
        l_0x1012_e993:
            ii(0x1012_e993, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1012_e996, 1); inc(eax);                               /* inc eax */
            ii(0x1012_e997, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_e99a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e99d, 5); call(0x1012_e1cf, -0x7d3);              /* call 0x1012e1cf */
        l_0x1012_e9a2:
            ii(0x1012_e9a2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e9a5, 4); cmp(memb[ds, eax + 0x17], 0x3);         /* cmp byte [eax+0x17], 0x3 */
            ii(0x1012_e9a9, 2); if(jnz(0x1012_e9b3, 0x8)) goto l_0x1012_e9b3; /* jnz 0x1012e9b3 */
            ii(0x1012_e9ab, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e9ae, 5); call(0x1012_e554, -0x45f);              /* call 0x1012e554 */
        l_0x1012_e9b3:
            ii(0x1012_e9b3, 5); jmp(0x1012_ea1c, 0x64); goto l_0x1012_ea1c; /* jmp 0x1012ea1c */
        l_0x1012_e9b8:
            ii(0x1012_e9b8, 2); jmp(0x1012_ea1c, 0x62); goto l_0x1012_ea1c; /* jmp 0x1012ea1c */
        l_0x1012_e9ba:
            ii(0x1012_e9ba, 4); cmp(memd[ss, ebp - 0x28], 0x3f);        /* cmp dword [ebp-0x28], 0x3f */
            ii(0x1012_e9be, 2); if(jb(0x1012_e9fe, 0x3e)) goto l_0x1012_e9fe; /* jb 0x1012e9fe */
            ii(0x1012_e9c0, 4); cmp(memd[ss, ebp - 0x28], 0x3f);        /* cmp dword [ebp-0x28], 0x3f */
            ii(0x1012_e9c4, 6); if(jbe(0x1012_e8f6, -0xd4)) goto l_0x1012_e8f6; /* jbe 0x1012e8f6 */
            ii(0x1012_e9ca, 7); cmp(memd[ss, ebp - 0x28], 0x148);       /* cmp dword [ebp-0x28], 0x148 */
            ii(0x1012_e9d1, 2); if(jb(0x1012_e9ef, 0x1c)) goto l_0x1012_e9ef; /* jb 0x1012e9ef */
            ii(0x1012_e9d3, 7); cmp(memd[ss, ebp - 0x28], 0x148);       /* cmp dword [ebp-0x28], 0x148 */
            ii(0x1012_e9da, 6); if(jbe(0x1012_e91f, -0xc1)) goto l_0x1012_e91f; /* jbe 0x1012e91f */
            ii(0x1012_e9e0, 7); cmp(memd[ss, ebp - 0x28], 0x150);       /* cmp dword [ebp-0x28], 0x150 */
            ii(0x1012_e9e7, 6); if(jz(0x1012_e960, -0x8d)) goto l_0x1012_e960; /* jz 0x1012e960 */
            ii(0x1012_e9ed, 2); jmp(0x1012_e9b8, -0x37); goto l_0x1012_e9b8; /* jmp 0x1012e9b8 */
        l_0x1012_e9ef:
            ii(0x1012_e9ef, 7); cmp(memd[ss, ebp - 0x28], 0x119);       /* cmp dword [ebp-0x28], 0x119 */
            ii(0x1012_e9f6, 6); if(jz(0x1012_e8ec, -0x110)) goto l_0x1012_e8ec; /* jz 0x1012e8ec */
            ii(0x1012_e9fc, 2); jmp(0x1012_e9b8, -0x46); goto l_0x1012_e9b8; /* jmp 0x1012e9b8 */
        l_0x1012_e9fe:
            ii(0x1012_e9fe, 4); cmp(memd[ss, ebp - 0x28], 0xd);         /* cmp dword [ebp-0x28], 0xd */
            ii(0x1012_ea02, 2); if(jb(0x1012_ea1a, 0x16)) goto l_0x1012_ea1a; /* jb 0x1012ea1a */
            ii(0x1012_ea04, 4); cmp(memd[ss, ebp - 0x28], 0xd);         /* cmp dword [ebp-0x28], 0xd */
            ii(0x1012_ea08, 6); if(jbe(0x1012_e910, -0xfe)) goto l_0x1012_e910; /* jbe 0x1012e910 */
            ii(0x1012_ea0e, 4); cmp(memd[ss, ebp - 0x28], 0x1b);        /* cmp dword [ebp-0x28], 0x1b */
            ii(0x1012_ea12, 6); if(jz(0x1012_e910, -0x108)) goto l_0x1012_e910; /* jz 0x1012e910 */
            ii(0x1012_ea18, 2); jmp(0x1012_e9b8, -0x62); goto l_0x1012_e9b8; /* jmp 0x1012e9b8 */
        l_0x1012_ea1a:
            ii(0x1012_ea1a, 2); jmp(0x1012_e9b8, -0x64); goto l_0x1012_e9b8; /* jmp 0x1012e9b8 */
        l_0x1012_ea1c:
            ii(0x1012_ea1c, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1012_ea23, 2); if(jz(0x1012_ea2e, 0x9)) goto l_0x1012_ea2e; /* jz 0x1012ea2e */
            ii(0x1012_ea25, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_ea27, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_ea29, 5); call(0x1010_0e32, -0x2_dbfc);           /* call 0x10100e32 */
        l_0x1012_ea2e:
            ii(0x1012_ea2e, 7); cmp(memb[ds, 0x101c_37d2], 0);          /* cmp byte [0x101c37d2], 0x0 */
            ii(0x1012_ea35, 2); if(jz(0x1012_ea41, 0xa)) goto l_0x1012_ea41; /* jz 0x1012ea41 */
            ii(0x1012_ea37, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_ea3a, 7); mov(memb[ds, eax + 0x9d], 0x1);         /* mov byte [eax+0x9d], 0x1 */
        l_0x1012_ea41:
            ii(0x1012_ea41, 5); jmp(0x1012_e7d4, -0x272); goto l_0x1012_e7d4; /* jmp 0x1012e7d4 */
        l_0x1012_ea46:
            ii(0x1012_ea46, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_ea49, 4); cmp(memb[ds, eax + 0x17], 0x3);         /* cmp byte [eax+0x17], 0x3 */
            ii(0x1012_ea4d, 2); if(jnz(0x1012_ea60, 0x11)) goto l_0x1012_ea60; /* jnz 0x1012ea60 */
            ii(0x1012_ea4f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_ea51, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_ea54, 3); add(eax, 0x36);                         /* add eax, 0x36 */
            ii(0x1012_ea57, 5); call(0x1013_ad71, 0xc315);              /* call 0x1013ad71 */
            ii(0x1012_ea5c, 2); test(al, al);                           /* test al, al */
            ii(0x1012_ea5e, 2); if(jnz(0x1012_ea62, 0x2)) goto l_0x1012_ea62; /* jnz 0x1012ea62 */
        l_0x1012_ea60:
            ii(0x1012_ea60, 2); jmp(0x1012_ea72, 0x10); goto l_0x1012_ea72; /* jmp 0x1012ea72 */
        l_0x1012_ea62:
            ii(0x1012_ea62, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_ea65, 3); add(eax, 0x36);                         /* add eax, 0x36 */
            ii(0x1012_ea68, 5); call(0x1013_1bb0, 0x3143);              /* call 0x10131bb0 */
            ii(0x1012_ea6d, 5); call(0x1011_780b, -0x1_7267);           /* call 0x1011780b */
        l_0x1012_ea72:
            ii(0x1012_ea72, 3); lea(edx, ebp - 0x8);                    /* lea edx, [ebp-0x8] */
            ii(0x1012_ea75, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1012_ea7a, 5); call(0x1009_cbc4, -0x9_1ebb);           /* call 0x1009cbc4 */
            ii(0x1012_ea7f, 2); test(al, al);                           /* test al, al */
            ii(0x1012_ea81, 2); if(jz(0x1012_ead5, 0x52)) goto l_0x1012_ead5; /* jz 0x1012ead5 */
            ii(0x1012_ea83, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1012_ea88, 5); call(0x1007_65d0, -0xb_84bd);           /* call 0x100765d0 */
            ii(0x1012_ea8d, 5); call(0x100f_f637, -0x2_f45b);           /* call 0x100ff637 */
            ii(0x1012_ea92, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_ea94, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1012_ea99, 5); call(0x1013_ad71, 0xc2d3);              /* call 0x1013ad71 */
            ii(0x1012_ea9e, 2); test(al, al);                           /* test al, al */
            ii(0x1012_eaa0, 2); if(jz(0x1012_ead5, 0x33)) goto l_0x1012_ead5; /* jz 0x1012ead5 */
            ii(0x1012_eaa2, 5); call(0x1010_2acc, -0x2_bfdb);           /* call 0x10102acc */
            ii(0x1012_eaa7, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1012_eaa9, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1012_eaab, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1012_eab0, 5); call(0x1007_6574, -0xb_8541);           /* call 0x10076574 */
            ii(0x1012_eab5, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1012_eab8, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_eabb, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1012_eac0, 5); call(0x1007_6574, -0xb_8551);           /* call 0x10076574 */
            ii(0x1012_eac5, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1012_eac8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_eacb, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_ead0, 5); call(0x1010_1620, -0x2_d4b5);           /* call 0x10101620 */
        l_0x1012_ead5:
            ii(0x1012_ead5, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1012_eadc, 2); if(jz(0x1012_eaf0, 0x12)) goto l_0x1012_eaf0; /* jz 0x1012eaf0 */
            ii(0x1012_eade, 5); call(0x100d_5094, -0x5_9a4f);           /* call 0x100d5094 */
            ii(0x1012_eae3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_eae5, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1012_eae7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_eae9, 5); call(0x1010_0e32, -0x2_dcbc);           /* call 0x10100e32 */
            ii(0x1012_eaee, 2); jmp(0x1012_eafa, 0xa); goto l_0x1012_eafa; /* jmp 0x1012eafa */
        l_0x1012_eaf0:
            ii(0x1012_eaf0, 5); call(0x1014_82f4, 0x1_97ff);            /* call 0x101482f4 */
            ii(0x1012_eaf5, 5); mov(memd[ds, 0x101c_396c], eax);        /* mov [0x101c396c], eax */
        l_0x1012_eafa:
            ii(0x1012_eafa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_eafc, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1012_eaff, 5); call(0x1007_5f2c, -0xb_8bd8);           /* call 0x10075f2c */
            ii(0x1012_eb04, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_eb06, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_eb07, 1); pop(edi);                               /* pop edi */
            ii(0x1012_eb08, 1); pop(esi);                               /* pop esi */
            ii(0x1012_eb09, 1); pop(edx);                               /* pop edx */
            ii(0x1012_eb0a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_eb0b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_eb0c, 1); ret();                                  /* ret */
        }
    }
}
