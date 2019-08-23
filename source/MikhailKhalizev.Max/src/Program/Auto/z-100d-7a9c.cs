using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_7a9c-e459aaf1")]
        public void Method_100d_7a9c()
        {
            ii(0x100d_7a9c, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100d_7aa1, 5); calld(Definitions.sys_check_available_stack_size, 0x8_e2ac); /* call 0x10165d52 */
            ii(0x100d_7aa6, 1); pushd(esi);                             /* push esi */
            ii(0x100d_7aa7, 1); pushd(edi);                             /* push edi */
            ii(0x100d_7aa8, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_7aa9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_7aab, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100d_7ab1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_7ab4, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100d_7ab7, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100d_7aba, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100d_7abd, 4); or(memb_a32[ss, ebp - 0x14], 0x1);      /* or byte [ebp-0x14], 0x1 */
            ii(0x100d_7ac1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_7ac4, 5); calld(0x1007_64fc, -0x6_15cd);          /* call 0x100764fc */
            ii(0x100d_7ac9, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_7acc, 4); and(memb_a32[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x100d_7ad0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_7ad3, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_7ad6, 4); add(memw_a32[ds, edx + 0xc], ax);       /* add [edx+0xc], ax */
            ii(0x100d_7ada, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_7add, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_7ae0, 4); add(memw_a32[ds, edx + 0x8], ax);       /* add [edx+0x8], ax */
            ii(0x100d_7ae4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7ae7, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_7aea, 4); add(memw_a32[ds, edx + 0xa], ax);       /* add [edx+0xa], ax */
            ii(0x100d_7aee, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100d_7af3, 5); calld(0x1007_6338, -0x6_17c0);          /* call 0x10076338 */
            ii(0x100d_7af8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_7afa, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_7afd, 5); calld(0x1007_643c, -0x6_16c6);          /* call 0x1007643c */
            ii(0x100d_7b02, 2); jmpd(0x100d_7b0c, 0x8); goto l_0x100d_7b0c; /* jmp 0x100d7b0c */
        l_0x100d_7b04:
            ii(0x100d_7b04, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_7b07, 5); calld(0x1007_6bf8, -0x6_0f14);          /* call 0x10076bf8 */
        l_0x100d_7b0c:
            ii(0x100d_7b0c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_7b0e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_7b11, 5); calld(0x1013_ad71, 0x6_325b);           /* call 0x1013ad71 */
            ii(0x100d_7b16, 2); test(al, al);                           /* test al, al */
            ii(0x100d_7b18, 2); if(jzd(0x100d_7b36, 0x1c)) goto l_0x100d_7b36; /* jz 0x100d7b36 */
            ii(0x100d_7b1a, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_7b1e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_7b20, 2); if(jnzd(0x100d_7b2a, 0x8)) goto l_0x100d_7b2a; /* jnz 0x100d7b2a */
            ii(0x100d_7b22, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100d_7b26, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_7b28, 2); if(jzd(0x100d_7b2c, 0x2)) goto l_0x100d_7b2c; /* jz 0x100d7b2c */
        l_0x100d_7b2a:
            ii(0x100d_7b2a, 2); jmpd(0x100d_7b34, 0x8); goto l_0x100d_7b34; /* jmp 0x100d7b34 */
        l_0x100d_7b2c:
            ii(0x100d_7b2c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_7b30, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_7b32, 2); if(jzd(0x100d_7b36, 0x2)) goto l_0x100d_7b36; /* jz 0x100d7b36 */
        l_0x100d_7b34:
            ii(0x100d_7b34, 2); jmpd(0x100d_7b3b, 0x5); goto l_0x100d_7b3b; /* jmp 0x100d7b3b */
        l_0x100d_7b36:
            ii(0x100d_7b36, 5); jmpd(0x100d_7bcc, 0x91); goto l_0x100d_7bcc; /* jmp 0x100d7bcc */
        l_0x100d_7b3b:
            ii(0x100d_7b3b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_7b3e, 5); calld(0x1007_63a0, -0x6_17a3);          /* call 0x100763a0 */
            ii(0x100d_7b43, 5); calld(0x1007_6204, -0x6_1944);          /* call 0x10076204 */
            ii(0x100d_7b48, 3); cmp(eax, memd_a32[ss, ebp - 0x10]);     /* cmp eax, [ebp-0x10] */
            ii(0x100d_7b4b, 6); if(jnzd(0x100d_7bc7, 0x76)) goto l_0x100d_7bc7; /* jnz 0x100d7bc7 */
            ii(0x100d_7b51, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_7b54, 5); calld(0x1007_63a0, -0x6_17b9);          /* call 0x100763a0 */
            ii(0x100d_7b59, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_7b5c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_7b5f, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100d_7b62, 6); mov(al, memb_a32[ds, eax + 0x101c_81d5]); /* mov al, [eax+0x101c81d5] */
            ii(0x100d_7b68, 3); mov(memb_a32[ss, ebp - 0x20], al);      /* mov [ebp-0x20], al */
            ii(0x100d_7b6b, 2); jmpd(0x100d_7ba5, 0x38); goto l_0x100d_7ba5; /* jmp 0x100d7ba5 */
        l_0x100d_7b6d:
            ii(0x100d_7b6d, 3); lea(edx, ebp - 0xc);                    /* lea edx, [ebp-0xc] */
            ii(0x100d_7b70, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_7b73, 5); calld(0x1007_6408, -0x6_1770);          /* call 0x10076408 */
            ii(0x100d_7b78, 5); calld(0x100d_79c4, -0x1b9);             /* call 0x100d79c4 */
            ii(0x100d_7b7d, 2); jmpd(0x100d_7bc7, 0x48); goto l_0x100d_7bc7; /* jmp 0x100d7bc7 */
        l_0x100d_7b7f:
            ii(0x100d_7b7f, 3); lea(edx, ebp - 0x8);                    /* lea edx, [ebp-0x8] */
            ii(0x100d_7b82, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_7b85, 5); calld(0x1007_6408, -0x6_1782);          /* call 0x10076408 */
            ii(0x100d_7b8a, 5); calld(0x100d_79c4, -0x1cb);             /* call 0x100d79c4 */
            ii(0x100d_7b8f, 2); jmpd(0x100d_7bc7, 0x36); goto l_0x100d_7bc7; /* jmp 0x100d7bc7 */
        l_0x100d_7b91:
            ii(0x100d_7b91, 3); lea(edx, ebp - 0x4);                    /* lea edx, [ebp-0x4] */
            ii(0x100d_7b94, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_7b97, 5); calld(0x1007_6408, -0x6_1794);          /* call 0x10076408 */
            ii(0x100d_7b9c, 5); calld(0x100d_79c4, -0x1dd);             /* call 0x100d79c4 */
            ii(0x100d_7ba1, 2); jmpd(0x100d_7bc7, 0x24); goto l_0x100d_7bc7; /* jmp 0x100d7bc7 */
        l_0x100d_7ba3:
            ii(0x100d_7ba3, 2); jmpd(0x100d_7bc7, 0x22); goto l_0x100d_7bc7; /* jmp 0x100d7bc7 */
        l_0x100d_7ba5:
            ii(0x100d_7ba5, 3); mov(al, memb_a32[ss, ebp - 0x20]);      /* mov al, [ebp-0x20] */
            ii(0x100d_7ba8, 3); mov(memb_a32[ss, ebp - 0x24], al);      /* mov [ebp-0x24], al */
            ii(0x100d_7bab, 4); cmp(memb_a32[ss, ebp - 0x24], 0x2);     /* cmp byte [ebp-0x24], 0x2 */
            ii(0x100d_7baf, 2); if(jbd(0x100d_7bbf, 0xe)) goto l_0x100d_7bbf; /* jb 0x100d7bbf */
            ii(0x100d_7bb1, 4); cmp(memb_a32[ss, ebp - 0x24], 0x2);     /* cmp byte [ebp-0x24], 0x2 */
            ii(0x100d_7bb5, 2); if(jbed(0x100d_7b7f, -0x38)) goto l_0x100d_7b7f; /* jbe 0x100d7b7f */
            ii(0x100d_7bb7, 4); cmp(memb_a32[ss, ebp - 0x24], 0x3);     /* cmp byte [ebp-0x24], 0x3 */
            ii(0x100d_7bbb, 2); if(jzd(0x100d_7b91, -0x2c)) goto l_0x100d_7b91; /* jz 0x100d7b91 */
            ii(0x100d_7bbd, 2); jmpd(0x100d_7ba3, -0x1c); goto l_0x100d_7ba3; /* jmp 0x100d7ba3 */
        l_0x100d_7bbf:
            ii(0x100d_7bbf, 4); cmp(memb_a32[ss, ebp - 0x24], 0x1);     /* cmp byte [ebp-0x24], 0x1 */
            ii(0x100d_7bc3, 2); if(jzd(0x100d_7b6d, -0x58)) goto l_0x100d_7b6d; /* jz 0x100d7b6d */
            ii(0x100d_7bc5, 2); jmpd(0x100d_7ba3, -0x24); goto l_0x100d_7ba3; /* jmp 0x100d7ba3 */
        l_0x100d_7bc7:
            ii(0x100d_7bc7, 5); jmpd(0x100d_7b04, -0xc8); goto l_0x100d_7b04; /* jmp 0x100d7b04 */
        l_0x100d_7bcc:
            ii(0x100d_7bcc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_7bce, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_7bd1, 5); calld(0x1007_5f6c, -0x6_1c6a);          /* call 0x10075f6c */
            ii(0x100d_7bd6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_7bd8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_7bd9, 1); popd(edi);                              /* pop edi */
            ii(0x100d_7bda, 1); popd(esi);                              /* pop esi */
            ii(0x100d_7bdb, 1); retd();                                 /* ret */
        }
    }
}
