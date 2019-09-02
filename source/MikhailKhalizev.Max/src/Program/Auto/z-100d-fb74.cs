using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_fb74-20603698")]
        public void Method_100d_fb74()
        {
            ii(0x100d_fb74, 5); push(0x30);                             /* push 0x30 */
            ii(0x100d_fb79, 5); call(Definitions.sys_check_available_stack_size, 0x8_61d4); /* call 0x10165d52 */
            ii(0x100d_fb7e, 1); push(ebx);                              /* push ebx */
            ii(0x100d_fb7f, 1); push(ecx);                              /* push ecx */
            ii(0x100d_fb80, 1); push(esi);                              /* push esi */
            ii(0x100d_fb81, 1); push(edi);                              /* push edi */
            ii(0x100d_fb82, 1); push(ebp);                              /* push ebp */
            ii(0x100d_fb83, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_fb85, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100d_fb8b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_fb8e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_fb91, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_fb94, 3); mov(ebx, memd[ds, eax + 4]);            /* mov ebx, [eax+0x4] */
            ii(0x100d_fb97, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_fb9a, 5); mov(edx, StringDefinitions.Gold6);      /* mov edx, 0x101a1b08 */
            ii(0x100d_fb9f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_fba2, 5); call(0x1014_74f5, 0x6_794e);            /* call 0x101474f5 */
            ii(0x100d_fba7, 5); mov(edx, StringDefinitions.BaseValues2); /* mov edx, 0x101a1b0d */
            ii(0x100d_fbac, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_fbaf, 5); call(0x1014_73de, 0x6_782a);            /* call 0x101473de */
            ii(0x100d_fbb4, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
            ii(0x100d_fbbb, 2); jmp(0x100d_fbc3, 6); goto l_0x100d_fbc3; /* jmp 0x100dfbc3 */
        l_0x100d_fbbd:
            ii(0x100d_fbbd, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100d_fbc0, 3); inc(memd[ss, ebp - 16]);                /* inc dword [ebp-0x10] */
        l_0x100d_fbc3:
            ii(0x100d_fbc3, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x100d_fbc7, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x100d_fbca, 2); if(jge(0x100d_fc1e, 0x52)) goto l_0x100d_fc1e; /* jge 0x100dfc1e */
            ii(0x100d_fbcc, 5); mov(edx, StringDefinitions.Unit5);      /* mov edx, 0x101a1b19 */
            ii(0x100d_fbd1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_fbd4, 5); call(0x1014_73de, 0x6_7805);            /* call 0x101473de */
            ii(0x100d_fbd9, 4); movsx(ecx, memw[ss, ebp - 16]);         /* movsx ecx, word [ebp-0x10] */
            ii(0x100d_fbdd, 5); mov(ebx, 0x101c_7140);                  /* mov ebx, 0x101c7140 */
            ii(0x100d_fbe2, 5); mov(edx, StringDefinitions.Type4);      /* mov edx, 0x101a1b1e */
            ii(0x100d_fbe7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_fbea, 5); call(0x1014_76e3, 0x6_7af4);            /* call 0x101476e3 */
            ii(0x100d_fbef, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x100d_fbf3, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_fbf6, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_fbf9, 3); add(edx, 8);                            /* add edx, 0x8 */
            ii(0x100d_fbfc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_fbfe, 5); call(0x1007_678c, -0x6_9477);           /* call 0x1007678c */
            ii(0x100d_fc03, 5); mov(edx, StringDefinitions.Values3);    /* mov edx, 0x101a1b23 */
            ii(0x100d_fc08, 3); mov(ecx, memd[ss, ebp - 4]);            /* mov ecx, [ebp-0x4] */
            ii(0x100d_fc0b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_fc0d, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100d_fc0f, 5); call(0x1014_756a, 0x6_7956);            /* call 0x1014756a */
            ii(0x100d_fc14, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_fc17, 5); call(0x1014_7446, 0x6_782a);            /* call 0x10147446 */
            ii(0x100d_fc1c, 2); jmp(0x100d_fbbd, -0x61); goto l_0x100d_fbbd; /* jmp 0x100dfbbd */
        l_0x100d_fc1e:
            ii(0x100d_fc1e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_fc21, 5); call(0x1014_7446, 0x6_7820);            /* call 0x10147446 */
            ii(0x100d_fc26, 5); mov(edx, StringDefinitions.CurrentValues2); /* mov edx, 0x101a1b2a */
            ii(0x100d_fc2b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_fc2e, 5); call(0x1014_73de, 0x6_77ab);            /* call 0x101473de */
            ii(0x100d_fc33, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
            ii(0x100d_fc3a, 2); jmp(0x100d_fc42, 6); goto l_0x100d_fc42; /* jmp 0x100dfc42 */
        l_0x100d_fc3c:
            ii(0x100d_fc3c, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100d_fc3f, 3); inc(memd[ss, ebp - 16]);                /* inc dword [ebp-0x10] */
        l_0x100d_fc42:
            ii(0x100d_fc42, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x100d_fc46, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x100d_fc49, 2); if(jge(0x100d_fca0, 0x55)) goto l_0x100d_fca0; /* jge 0x100dfca0 */
            ii(0x100d_fc4b, 5); mov(edx, StringDefinitions.Unit6);      /* mov edx, 0x101a1b39 */
            ii(0x100d_fc50, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_fc53, 5); call(0x1014_73de, 0x6_7786);            /* call 0x101473de */
            ii(0x100d_fc58, 4); movsx(ecx, memw[ss, ebp - 16]);         /* movsx ecx, word [ebp-0x10] */
            ii(0x100d_fc5c, 5); mov(ebx, 0x101c_7140);                  /* mov ebx, 0x101c7140 */
            ii(0x100d_fc61, 5); mov(edx, StringDefinitions.Type5);      /* mov edx, 0x101a1b3e */
            ii(0x100d_fc66, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_fc69, 5); call(0x1014_76e3, 0x6_7a75);            /* call 0x101476e3 */
            ii(0x100d_fc6e, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x100d_fc72, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_fc75, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_fc78, 6); add(edx, 0x17c);                        /* add edx, 0x17c */
            ii(0x100d_fc7e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_fc80, 5); call(0x1007_678c, -0x6_94f9);           /* call 0x1007678c */
            ii(0x100d_fc85, 5); mov(edx, StringDefinitions.Values4);    /* mov edx, 0x101a1b43 */
            ii(0x100d_fc8a, 3); mov(ecx, memd[ss, ebp - 4]);            /* mov ecx, [ebp-0x4] */
            ii(0x100d_fc8d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_fc8f, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100d_fc91, 5); call(0x1014_756a, 0x6_78d4);            /* call 0x1014756a */
            ii(0x100d_fc96, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_fc99, 5); call(0x1014_7446, 0x6_77a8);            /* call 0x10147446 */
            ii(0x100d_fc9e, 2); jmp(0x100d_fc3c, -0x64); goto l_0x100d_fc3c; /* jmp 0x100dfc3c */
        l_0x100d_fca0:
            ii(0x100d_fca0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_fca3, 5); call(0x1014_7446, 0x6_779e);            /* call 0x10147446 */
            ii(0x100d_fca8, 4); or(memb[ss, ebp - 12], 1);              /* or byte [ebp-0xc], 0x1 */
            ii(0x100d_fcac, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100d_fcaf, 5); call(0x100e_0608, 0x954);               /* call 0x100e0608 */
            ii(0x100d_fcb4, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100d_fcb7, 4); and(memb[ss, ebp - 12], -2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100d_fcbb, 5); mov(edx, StringDefinitions.Complexes2); /* mov edx, 0x101a1b4a */
            ii(0x100d_fcc0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_fcc3, 5); call(0x1014_73de, 0x6_7716);            /* call 0x101473de */
            ii(0x100d_fcc8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_fccb, 5); add(eax, 0x2f0);                        /* add eax, 0x2f0 */
            ii(0x100d_fcd0, 5); call(0x100e_0cf0, 0x101b);              /* call 0x100e0cf0 */
            ii(0x100d_fcd5, 3); lea(ebx, memd[ss, ebp - 24]);           /* lea ebx, [ebp-0x18] */
            ii(0x100d_fcd8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_fcda, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100d_fcdc, 5); call(0x100e_0548, 0x867);               /* call 0x100e0548 */
            ii(0x100d_fce1, 2); jmp(0x100d_fceb, 8); goto l_0x100d_fceb; /* jmp 0x100dfceb */
        l_0x100d_fce3:
            ii(0x100d_fce3, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100d_fce6, 5); call(0x1007_6bf8, -0x6_90f3);           /* call 0x10076bf8 */
        l_0x100d_fceb:
            ii(0x100d_fceb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_fced, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100d_fcf0, 5); call(0x1013_ad71, 0x5_b07c);            /* call 0x1013ad71 */
            ii(0x100d_fcf5, 2); test(al, al);                           /* test al, al */
            ii(0x100d_fcf7, 2); if(jz(0x100d_fd12, 0x19)) goto l_0x100d_fd12; /* jz 0x100dfd12 */
            ii(0x100d_fcf9, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100d_fcfc, 5); call(0x100e_04e4, 0x7e3);               /* call 0x100e04e4 */
            ii(0x100d_fd01, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_fd03, 5); mov(edx, StringDefinitions.Complex3);   /* mov edx, 0x101a1b54 */
            ii(0x100d_fd08, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_fd0b, 5); call(0x1014_756a, 0x6_785a);            /* call 0x1014756a */
            ii(0x100d_fd10, 2); jmp(0x100d_fce3, -0x2f); goto l_0x100d_fce3; /* jmp 0x100dfce3 */
        l_0x100d_fd12:
            ii(0x100d_fd12, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_fd15, 5); call(0x1014_7446, 0x6_772c);            /* call 0x10147446 */
            ii(0x100d_fd1a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_fd1c, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100d_fd1f, 5); call(0x100e_043c, 0x718);               /* call 0x100e043c */
            ii(0x100d_fd24, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_fd26, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_fd27, 1); pop(edi);                               /* pop edi */
            ii(0x100d_fd28, 1); pop(esi);                               /* pop esi */
            ii(0x100d_fd29, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_fd2a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_fd2b, 1); ret();                                  /* ret */
        }
    }
}
