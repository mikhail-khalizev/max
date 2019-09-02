using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_a88b-ad13a955")]
        public void Method_100d_a88b()
        {
            ii(0x100d_a88b, 5); push(0x4c);                             /* push 0x4c */
            ii(0x100d_a890, 5); call(Definitions.sys_check_available_stack_size, 0x8_b4bd); /* call 0x10165d52 */
            ii(0x100d_a895, 1); push(ebx);                              /* push ebx */
            ii(0x100d_a896, 1); push(ecx);                              /* push ecx */
            ii(0x100d_a897, 1); push(esi);                              /* push esi */
            ii(0x100d_a898, 1); push(edi);                              /* push edi */
            ii(0x100d_a899, 1); push(ebp);                              /* push ebp */
            ii(0x100d_a89a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_a89c, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100d_a8a2, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_a8a5, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_a8a8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_a8ab, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_a8ae, 4); mov(memw[ds, edx + 0x59], ax);          /* mov [edx+0x59], ax */
            ii(0x100d_a8b2, 5); cmp(memw[ss, ebp - 4], -1 /* 0xff */);  /* cmp word [ebp-0x4], 0xffff */
            ii(0x100d_a8b7, 2); if(jnz(0x100d_a8c2, 9)) goto l_0x100d_a8c2; /* jnz 0x100da8c2 */
            ii(0x100d_a8b9, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100d_a8c0, 2); jmp(0x100d_a8d3, 0x11); goto l_0x100d_a8d3; /* jmp 0x100da8d3 */
        l_0x100d_a8c2:
            ii(0x100d_a8c2, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100d_a8c6, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100d_a8c9, 5); mov(edx, 0x101c_81c0);                  /* mov edx, 0x101c81c0 */
            ii(0x100d_a8ce, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_a8d0, 3); mov(memd[ss, ebp - 0x10], edx);         /* mov [ebp-0x10], edx */
        l_0x100d_a8d3:
            ii(0x100d_a8d3, 4); cmp(memd[ss, ebp - 0x10], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100d_a8d7, 2); if(jz(0x100d_a90e, 0x35)) goto l_0x100d_a90e; /* jz 0x100da90e */
            ii(0x100d_a8d9, 5); call(0x100d_533c, -0x55a2);             /* call 0x100d533c */
            ii(0x100d_a8de, 1); cwde();                                 /* cwde */
            ii(0x100d_a8df, 1); push(eax);                              /* push eax */
            ii(0x100d_a8e0, 5); call(0x100d_5360, -0x5585);             /* call 0x100d5360 */
            ii(0x100d_a8e5, 1); cwde();                                 /* cwde */
            ii(0x100d_a8e6, 1); push(eax);                              /* push eax */
            ii(0x100d_a8e7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_a8e9, 1); push(eax);                              /* push eax */
            ii(0x100d_a8ea, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100d_a8ec, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_a8ef, 3); mov(ebx, memd[ds, eax + 0x25]);         /* mov ebx, [eax+0x25] */
            ii(0x100d_a8f2, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_a8f5, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_a8f8, 3); add(edx, 0x31);                         /* add edx, 0x31 */
            ii(0x100d_a8fb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_a8fe, 3); mov(eax, memd[ds, eax + 0xa]);          /* mov eax, [eax+0xa] */
            ii(0x100d_a901, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_a904, 5); call(0x100e_8c51, 0xe348);              /* call 0x100e8c51 */
            ii(0x100d_a909, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100d_a90c, 2); if(jnz(0x100d_a962, 0x54)) goto l_0x100d_a962; /* jnz 0x100da962 */
        l_0x100d_a90e:
            ii(0x100d_a90e, 2); push(0);                                /* push 0x0 */
            ii(0x100d_a910, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_a913, 3); mov(ecx, memd[ds, eax + 0x25]);         /* mov ecx, [eax+0x25] */
            ii(0x100d_a916, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_a919, 5); mov(ebx, 0xf0);                         /* mov ebx, 0xf0 */
            ii(0x100d_a91e, 5); mov(edx, 0x12c);                        /* mov edx, 0x12c */
            ii(0x100d_a923, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_a926, 3); mov(eax, memd[ds, eax + 0x47]);         /* mov eax, [eax+0x47] */
            ii(0x100d_a929, 5); call(/* sys */ 0x1016_ad78, 0x9_044a);  /* call 0x1016ad78 */
            ii(0x100d_a92e, 4); cmp(memd[ss, ebp - 0x10], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100d_a932, 2); if(jz(0x100d_a962, 0x2e)) goto l_0x100d_a962; /* jz 0x100da962 */
            ii(0x100d_a934, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_a936, 1); push(eax);                              /* push eax */
            ii(0x100d_a937, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_a939, 1); push(eax);                              /* push eax */
            ii(0x100d_a93a, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x100d_a93f, 1); push(eax);                              /* push eax */
            ii(0x100d_a940, 5); mov(ecx, 0x10);                         /* mov ecx, 0x10 */
            ii(0x100d_a945, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_a948, 3); mov(ebx, memd[ds, eax + 0x25]);         /* mov ebx, [eax+0x25] */
            ii(0x100d_a94b, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_a94e, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_a951, 3); add(edx, 0x31);                         /* add edx, 0x31 */
            ii(0x100d_a954, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_a957, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100d_a95a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_a95d, 5); call(0x100f_04d8, 0x1_5b76);            /* call 0x100f04d8 */
        l_0x100d_a962:
            ii(0x100d_a962, 5); cmp(memw[ss, ebp - 4], -1 /* 0xff */);  /* cmp word [ebp-0x4], 0xffff */
            ii(0x100d_a967, 2); if(jz(0x100d_a972, 9)) goto l_0x100d_a972; /* jz 0x100da972 */
            ii(0x100d_a969, 7); cmp(memb[ds, 0x101b_7ed0], 0);          /* cmp byte [0x101b7ed0], 0x0 */
            ii(0x100d_a970, 2); if(jnz(0x100d_a974, 2)) goto l_0x100d_a974; /* jnz 0x100da974 */
        l_0x100d_a972:
            ii(0x100d_a972, 2); jmp(0x100d_a9c1, 0x4d); goto l_0x100d_a9c1; /* jmp 0x100da9c1 */
        l_0x100d_a974:
            ii(0x100d_a974, 5); mov(eax, 5);                            /* mov eax, 0x5 */
            ii(0x100d_a979, 5); call(/* sys */ 0x1016_a24c, 0x8_f8ce);  /* call 0x1016a24c */
            ii(0x100d_a97e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_a980, 1); push(eax);                              /* push eax */
            ii(0x100d_a981, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_a983, 1); push(eax);                              /* push eax */
            ii(0x100d_a984, 5); push(0x1_00a2);                         /* push 0x100a2 */
            ii(0x100d_a989, 5); mov(eax, 0xe6);                         /* mov eax, 0xe6 */
            ii(0x100d_a98e, 1); push(eax);                              /* push eax */
            ii(0x100d_a98f, 5); mov(eax, 0x118);                        /* mov eax, 0x118 */
            ii(0x100d_a994, 1); push(eax);                              /* push eax */
            ii(0x100d_a995, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x100d_a99a, 1); push(eax);                              /* push eax */
            ii(0x100d_a99b, 5); mov(ecx, 0x10);                         /* mov ecx, 0x10 */
            ii(0x100d_a9a0, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x100d_a9a4, 3); imul(ebx, ebx, 0x33);                   /* imul ebx, ebx, 0x33 */
            ii(0x100d_a9a7, 6); mov(ebx, memd[ds, ebx + 0x101c_81df]);  /* mov ebx, [ebx+0x101c81df] */
            ii(0x100d_a9ad, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_a9b0, 3); mov(edx, memd[ds, eax + 0x25]);         /* mov edx, [eax+0x25] */
            ii(0x100d_a9b3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_a9b6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_a9b9, 3); mov(eax, memd[ds, eax + 0x47]);         /* mov eax, [eax+0x47] */
            ii(0x100d_a9bc, 5); call(0x100e_9ae5, 0xf124);              /* call 0x100e9ae5 */
        l_0x100d_a9c1:
            ii(0x100d_a9c1, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x100d_a9c8, 2); jmp(0x100d_a9d0, 6); goto l_0x100d_a9d0; /* jmp 0x100da9d0 */
        l_0x100d_a9ca:
            ii(0x100d_a9ca, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_a9cd, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
        l_0x100d_a9d0:
            ii(0x100d_a9d0, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_a9d3, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_a9d6, 4); cmp(ax, memw[ds, edx + 0x51]);          /* cmp ax, [edx+0x51] */
            ii(0x100d_a9da, 2); if(jge(0x100d_aa26, 0x4a)) goto l_0x100d_aa26; /* jge 0x100daa26 */
            ii(0x100d_a9dc, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100d_a9e0, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_a9e3, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x100d_a9e6, 6); mov(eax, memd[ds, eax + 0x375]);        /* mov eax, [eax+0x375] */
            ii(0x100d_a9ec, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_a9ef, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100d_a9f3, 2); if(jz(0x100d_aa09, 0x14)) goto l_0x100d_aa09; /* jz 0x100daa09 */
            ii(0x100d_a9f5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_a9f7, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_a9fa, 5); call(Definitions.my_dtor_d4, -0x2592);  /* call 0x100d846d */
            ii(0x100d_a9ff, 5); call(Definitions.sys_delete, 0x8_b560); /* call 0x10165f64 */
            ii(0x100d_aa04, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_aa07, 2); jmp(0x100d_aa10, 7); goto l_0x100d_aa10; /* jmp 0x100daa10 */
        l_0x100d_aa09:
            ii(0x100d_aa09, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x100d_aa10:
            ii(0x100d_aa10, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100d_aa14, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_aa17, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x100d_aa1a, 10); mov(memd[ds, eax + 0x375], 0);         /* mov dword [eax+0x375], 0x0 */
            ii(0x100d_aa24, 2); jmp(0x100d_a9ca, -0x5c); goto l_0x100d_a9ca; /* jmp 0x100da9ca */
        l_0x100d_aa26:
            ii(0x100d_aa26, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_aa29, 6); mov(memw[ds, eax + 0x51], 0);           /* mov word [eax+0x51], 0x0 */
            ii(0x100d_aa2f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_aa32, 6); mov(eax, memd[ds, eax + 0x3a3]);        /* mov eax, [eax+0x3a3] */
            ii(0x100d_aa38, 5); call(0x100d_4ebc, -0x5b81);             /* call 0x100d4ebc */
            ii(0x100d_aa3d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_aa3f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_aa42, 4); mov(memw[ds, eax + 0x53], dx);          /* mov [eax+0x53], dx */
            ii(0x100d_aa46, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_aa49, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_aa4c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_aa4f, 6); mov(eax, memd[ds, eax + 0x3ab]);        /* mov eax, [eax+0x3ab] */
            ii(0x100d_aa55, 5); call(0x100d_7f6c, -0x2aee);             /* call 0x100d7f6c */
            ii(0x100d_aa5a, 5); cmp(memw[ss, ebp - 4], -1 /* 0xff */);  /* cmp word [ebp-0x4], 0xffff */
            ii(0x100d_aa5f, 2); if(jz(0x100d_aa6e, 0xd)) goto l_0x100d_aa6e; /* jz 0x100daa6e */
            ii(0x100d_aa61, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100d_aa65, 5); call(0x100c_dec2, -0xcba8);             /* call 0x100cdec2 */
            ii(0x100d_aa6a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_aa6c, 2); if(jnz(0x100d_aa70, 2)) goto l_0x100d_aa70; /* jnz 0x100daa70 */
        l_0x100d_aa6e:
            ii(0x100d_aa6e, 2); jmp(0x100d_aaac, 0x3c); goto l_0x100d_aaac; /* jmp 0x100daaac */
        l_0x100d_aa70:
            ii(0x100d_aa70, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100d_aa74, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_aa77, 5); call(0x100d_9f38, -0xb44);              /* call 0x100d9f38 */
            ii(0x100d_aa7c, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100d_aa80, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_aa83, 5); call(0x100d_a14b, -0x93d);              /* call 0x100da14b */
            ii(0x100d_aa88, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100d_aa8c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_aa8f, 5); call(0x100d_a20d, -0x887);              /* call 0x100da20d */
            ii(0x100d_aa94, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100d_aa98, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_aa9b, 5); call(0x100d_a2b3, -0x7ed);              /* call 0x100da2b3 */
            ii(0x100d_aaa0, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100d_aaa4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_aaa7, 5); call(0x100d_a407, -0x6a5);              /* call 0x100da407 */
        l_0x100d_aaac:
            ii(0x100d_aaac, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_aaaf, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_aab2, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_aab5, 3); mov(ebx, memd[ds, eax + 0x13]);         /* mov ebx, [eax+0x13] */
            ii(0x100d_aab8, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100d_aabc, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_aabf, 3); call_abs(memd[ds, ebx + 0x18]);         /* call dword [ebx+0x18] */
            ii(0x100d_aac2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_aac4, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_aac5, 1); pop(edi);                               /* pop edi */
            ii(0x100d_aac6, 1); pop(esi);                               /* pop esi */
            ii(0x100d_aac7, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_aac8, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_aac9, 1); ret();                                  /* ret */
        }
    }
}
