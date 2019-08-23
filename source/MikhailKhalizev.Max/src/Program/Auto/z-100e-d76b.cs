using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_d76b-c3f978df")]
        public void Method_100e_d76b()
        {
            ii(0x100e_d76b, 5); push(0x50);                             /* push 0x50 */
            ii(0x100e_d770, 5); call(Definitions.sys_check_available_stack_size, 0x7_85dd); /* call 0x10165d52 */
            ii(0x100e_d775, 1); push(esi);                              /* push esi */
            ii(0x100e_d776, 1); push(edi);                              /* push edi */
            ii(0x100e_d777, 1); push(ebp);                              /* push ebp */
            ii(0x100e_d778, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_d77a, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100e_d780, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_d783, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100e_d786, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100e_d789, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100e_d78c, 4); movsx(eax, memw[ss, ebp + 0x14]);       /* movsx eax, word [ebp+0x14] */
            ii(0x100e_d790, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_d793, 2); if(jnz(0x100e_d7a6, 0x11)) goto l_0x100e_d7a6; /* jnz 0x100ed7a6 */
            ii(0x100e_d795, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_d798, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
            ii(0x100e_d79e, 4); movsx(edx, memw[ss, ebp + 0x10]);       /* movsx edx, word [ebp+0x10] */
            ii(0x100e_d7a2, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100e_d7a4, 2); if(jl(0x100e_d7a8, 0x2)) goto l_0x100e_d7a8; /* jl 0x100ed7a8 */
        l_0x100e_d7a6:
            ii(0x100e_d7a6, 2); jmp(0x100e_d7bd, 0x15); goto l_0x100e_d7bd; /* jmp 0x100ed7bd */
        l_0x100e_d7a8:
            ii(0x100e_d7a8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_d7ab, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
            ii(0x100e_d7b1, 3); mov(edx, memd[ss, ebp + 0x10]);         /* mov edx, [ebp+0x10] */
            ii(0x100e_d7b4, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100e_d7b6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_d7b8, 3); add(memd[ss, ebp - 0x8], eax);          /* add [ebp-0x8], eax */
            ii(0x100e_d7bb, 2); jmp(0x100e_d7fa, 0x3d); goto l_0x100e_d7fa; /* jmp 0x100ed7fa */
        l_0x100e_d7bd:
            ii(0x100e_d7bd, 4); movsx(eax, memw[ss, ebp + 0x14]);       /* movsx eax, word [ebp+0x14] */
            ii(0x100e_d7c1, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100e_d7c4, 2); if(jnz(0x100e_d7d7, 0x11)) goto l_0x100e_d7d7; /* jnz 0x100ed7d7 */
            ii(0x100e_d7c6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_d7c9, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
            ii(0x100e_d7cf, 4); movsx(edx, memw[ss, ebp + 0x10]);       /* movsx edx, word [ebp+0x10] */
            ii(0x100e_d7d3, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100e_d7d5, 2); if(jl(0x100e_d7d9, 0x2)) goto l_0x100e_d7d9; /* jl 0x100ed7d9 */
        l_0x100e_d7d7:
            ii(0x100e_d7d7, 2); jmp(0x100e_d7fa, 0x21); goto l_0x100e_d7fa; /* jmp 0x100ed7fa */
        l_0x100e_d7d9:
            ii(0x100e_d7d9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_d7dc, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
            ii(0x100e_d7e2, 4); movsx(edx, memw[ss, ebp + 0x10]);       /* movsx edx, word [ebp+0x10] */
            ii(0x100e_d7e6, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100e_d7e8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_d7ea, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_d7ed, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_d7ef, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100e_d7f1, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100e_d7f5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_d7f7, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
        l_0x100e_d7fa:
            ii(0x100e_d7fa, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x100e_d801, 4); mov(memb[ss, ebp - 0x17], 0);           /* mov byte [ebp-0x17], 0x0 */
            ii(0x100e_d805, 5); call(0x1014_82f4, 0x5_aaea);            /* call 0x101482f4 */
            ii(0x100e_d80a, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100e_d80d, 5); call(0x1014_82f4, 0x5_aae2);            /* call 0x101482f4 */
            ii(0x100e_d812, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100e_d815, 8); cmp(memw[ds, 0x101b_8674], 0);          /* cmp word [0x101b8674], 0x0 */
            ii(0x100e_d81d, 2); if(jz(0x100e_d82e, 0xf)) goto l_0x100e_d82e; /* jz 0x100ed82e */
            ii(0x100e_d81f, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100e_d824, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100e_d829, 5); call(0x1013_dc59, 0x5_042b);            /* call 0x1013dc59 */
        l_0x100e_d82e:
            ii(0x100e_d82e, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100e_d832, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x100e_d835, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100e_d837, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_d83c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d83e, 2); if(jz(0x100e_d848, 0x8)) goto l_0x100e_d848; /* jz 0x100ed848 */
            ii(0x100e_d840, 4); movsx(eax, memw[ss, ebp + 0x10]);       /* movsx eax, word [ebp+0x10] */
            ii(0x100e_d844, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d846, 2); if(jg(0x100e_d84d, 0x5)) goto l_0x100e_d84d; /* jg 0x100ed84d */
        l_0x100e_d848:
            ii(0x100e_d848, 5); jmp(0x100e_d948, 0xfb); goto l_0x100e_d948; /* jmp 0x100ed948 */
        l_0x100e_d84d:
            ii(0x100e_d84d, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100e_d851, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x100e_d854, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100e_d856, 3); mov(memb[ss, ebp - 0x18], al);          /* mov [ebp-0x18], al */
            ii(0x100e_d859, 5); mov(edx, 0x101c_367c);                  /* mov edx, 0x101c367c */
            ii(0x100e_d85e, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100e_d861, 5); call(0x100d_4d78, -0x1_8aee);           /* call 0x100d4d78 */
            ii(0x100e_d866, 1); push(eax);                              /* push eax */
            ii(0x100e_d867, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_d869, 1); push(eax);                              /* push eax */
            ii(0x100e_d86a, 4); movsx(eax, memw[ss, ebp + 0x10]);       /* movsx eax, word [ebp+0x10] */
            ii(0x100e_d86e, 1); push(eax);                              /* push eax */
            ii(0x100e_d86f, 4); movsx(ecx, memw[ss, ebp - 0x4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x100e_d873, 4); movsx(ebx, memw[ss, ebp - 0x8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x100e_d877, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x100e_d87a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_d87d, 5); call(0x100e_a99a, -0x2ee8);             /* call 0x100ea99a */
            ii(0x100e_d882, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100e_d885, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
            ii(0x100e_d88b, 3); sub(memd[ss, ebp + 0x10], eax);         /* sub [ebp+0x10], eax */
            ii(0x100e_d88e, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_d892, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100e_d895, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_d899, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100e_d89c, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100e_d89f, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
            ii(0x100e_d8a5, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100e_d8a9, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_d8ab, 3); mov(memd[ss, ebp - 0x2c], edx);         /* mov [ebp-0x2c], edx */
            ii(0x100e_d8ae, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x100e_d8b4, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100e_d8b8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_d8ba, 3); mov(memd[ss, ebp - 0x28], edx);         /* mov [ebp-0x28], edx */
            ii(0x100e_d8bd, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100e_d8c0, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
            ii(0x100e_d8c6, 3); add(memd[ss, ebp - 0x8], eax);          /* add [ebp-0x8], eax */
            ii(0x100e_d8c9, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_d8cc, 3); inc(memd[ss, ebp - 0x14]);              /* inc dword [ebp-0x14] */
            ii(0x100e_d8cf, 3); lea(edx, memd[ss, ebp - 0x34]);         /* lea edx, [ebp-0x34] */
            ii(0x100e_d8d2, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_d8d5, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x100e_d8d8, 5); call(Definitions.sys_display_draw_1, 0x7_9bcb); /* call 0x101674a8 */
            ii(0x100e_d8dd, 8); cmp(memw[ds, 0x101b_8674], 0);          /* cmp word [0x101b8674], 0x0 */
            ii(0x100e_d8e5, 2); if(jz(0x100e_d943, 0x5c)) goto l_0x100e_d943; /* jz 0x100ed943 */
            ii(0x100e_d8e7, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100e_d8ea, 5); call(0x1014_85ad, 0x5_acbe);            /* call 0x101485ad */
            ii(0x100e_d8ef, 6); mov(edx, memd[ds, 0x101b_8674]);        /* mov edx, [0x101b8674] */
            ii(0x100e_d8f5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_d8f8, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100e_d8fa, 2); if(jb(0x100e_d913, 0x17)) goto l_0x100e_d913; /* jb 0x100ed913 */
            ii(0x100e_d8fc, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100e_d901, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100e_d906, 5); call(0x1013_dc59, 0x5_034e);            /* call 0x1013dc59 */
            ii(0x100e_d90b, 5); call(0x1014_82f4, 0x5_a9e4);            /* call 0x101482f4 */
            ii(0x100e_d910, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x100e_d913:
            ii(0x100e_d913, 5); mov(eax, memd[ds, 0x101b_8672]);        /* mov eax, [0x101b8672] */
            ii(0x100e_d918, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_d91b, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100e_d91f, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100e_d922, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_d925, 5); call(0x1014_85ad, 0x5_ac83);            /* call 0x101485ad */
            ii(0x100e_d92a, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100e_d92c, 2); if(jae(0x100e_d943, 0x15)) goto l_0x100e_d943; /* jae 0x100ed943 */
            ii(0x100e_d92e, 5); call(/* sys */ 0x1016_b208, 0x7_d8d5);  /* call 0x1016b208 */
            ii(0x100e_d933, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x100e_d936, 2); if(jz(0x100e_d941, 0x9)) goto l_0x100e_d941; /* jz 0x100ed941 */
            ii(0x100e_d938, 9); mov(memw[ds, 0x101b_8674], 0);          /* mov word [0x101b8674], 0x0 */
        l_0x100e_d941:
            ii(0x100e_d941, 2); jmp(0x100e_d913, -0x30); goto l_0x100e_d913; /* jmp 0x100ed913 */
        l_0x100e_d943:
            ii(0x100e_d943, 5); jmp(0x100e_d82e, -0x11a); goto l_0x100e_d82e; /* jmp 0x100ed82e */
        l_0x100e_d948:
            ii(0x100e_d948, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_d94a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_d94b, 1); pop(edi);                               /* pop edi */
            ii(0x100e_d94c, 1); pop(esi);                               /* pop esi */
            ii(0x100e_d94d, 3); ret(0x8);                               /* ret 0x8 */
        }
    }
}
