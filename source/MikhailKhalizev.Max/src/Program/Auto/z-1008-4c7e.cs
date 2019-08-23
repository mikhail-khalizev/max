using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_4c7e-32098ebd")]
        public void Method_1008_4c7e()
        {
            ii(0x1008_4c7e, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1008_4c83, 5); calld(Definitions.sys_check_available_stack_size, 0xe_10ca); /* call 0x10165d52 */
            ii(0x1008_4c88, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_4c89, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_4c8a, 1); pushd(esi);                             /* push esi */
            ii(0x1008_4c8b, 1); pushd(edi);                             /* push edi */
            ii(0x1008_4c8c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_4c8d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_4c8f, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1008_4c95, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_4c98, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_4c9b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4c9e, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1008_4ca1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_4ca6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_4ca8, 2); if(jgd(0x1008_4cb3, 0x9)) goto l_0x1008_4cb3; /* jg 0x10084cb3 */
            ii(0x1008_4caa, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_4cae, 5); jmpd(0x1008_4dca, 0x117); goto l_0x1008_4dca; /* jmp 0x10084dca */
        l_0x1008_4cb3:
            ii(0x1008_4cb3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4cb5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_4cb8, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_4cbb, 5); calld(0x1013_ad11, 0xb_6051);           /* call 0x1013ad11 */
            ii(0x1008_4cc0, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4cc2, 2); if(jnzd(0x1008_4cd8, 0x14)) goto l_0x1008_4cd8; /* jnz 0x10084cd8 */
            ii(0x1008_4cc4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_4cc7, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_4cca, 5); calld(0x1008_9d7c, 0x50ad);             /* call 0x10089d7c */
            ii(0x1008_4ccf, 5); calld(0x1008_9f70, 0x529c);             /* call 0x10089f70 */
            ii(0x1008_4cd4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_4cd6, 2); if(jnzd(0x1008_4ce1, 0x9)) goto l_0x1008_4ce1; /* jnz 0x10084ce1 */
        l_0x1008_4cd8:
            ii(0x1008_4cd8, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_4cdc, 5); jmpd(0x1008_4dca, 0xe9); goto l_0x1008_4dca; /* jmp 0x10084dca */
        l_0x1008_4ce1:
            ii(0x1008_4ce1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_4ce4, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x1008_4ce7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_4cea, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_4ced, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_4cf0, 5); calld(0x1008_9d7c, 0x5087);             /* call 0x10089d7c */
            ii(0x1008_4cf5, 5); calld(0x1008_9f70, 0x5276);             /* call 0x10089f70 */
            ii(0x1008_4cfa, 5); calld(0x1007_6074, -0xec8b);            /* call 0x10076074 */
            ii(0x1008_4cff, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4d01, 6); if(jzd(0x1008_4d77, 0x70)) goto l_0x1008_4d77; /* jz 0x10084d77 */
            ii(0x1008_4d07, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4d0a, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1008_4d0f, 2); if(jzd(0x1008_4d1b, 0xa)) goto l_0x1008_4d1b; /* jz 0x10084d1b */
            ii(0x1008_4d11, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4d14, 5); cmp(memw_a32[ds, eax + 0x8], 0x47);     /* cmp word [eax+0x8], 0x47 */
            ii(0x1008_4d19, 2); if(jnzd(0x1008_4d1d, 0x2)) goto l_0x1008_4d1d; /* jnz 0x10084d1d */
        l_0x1008_4d1b:
            ii(0x1008_4d1b, 2); jmpd(0x1008_4d26, 0x9); goto l_0x1008_4d26; /* jmp 0x10084d26 */
        l_0x1008_4d1d:
            ii(0x1008_4d1d, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_4d21, 5); jmpd(0x1008_4dca, 0xa4); goto l_0x1008_4dca; /* jmp 0x10084dca */
        l_0x1008_4d26:
            ii(0x1008_4d26, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_4d29, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_4d2c, 5); calld(0x1008_9d7c, 0x504b);             /* call 0x10089d7c */
            ii(0x1008_4d31, 5); calld(0x1008_9f70, 0x523a);             /* call 0x10089f70 */
            ii(0x1008_4d36, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_4d39, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4d3c, 5); calld(0x1007_623c, -0xeb05);            /* call 0x1007623c */
            ii(0x1008_4d41, 4); mov(ax, memw_a32[ds, eax + 0x17]);      /* mov ax, [eax+0x17] */
            ii(0x1008_4d45, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1008_4d48, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1008_4d4c, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1008_4d50, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1008_4d53, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_4d55, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1008_4d58, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4d5b, 5); calld(0x1007_0d01, -0x1_405f);          /* call 0x10070d01 */
            ii(0x1008_4d60, 1); cwde();                                 /* cwde */
            ii(0x1008_4d61, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1008_4d63, 2); if(jgd(0x1008_4d6b, 0x6)) goto l_0x1008_4d6b; /* jg 0x10084d6b */
            ii(0x1008_4d65, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1008_4d69, 2); jmpd(0x1008_4d6f, 0x4); goto l_0x1008_4d6f; /* jmp 0x10084d6f */
        l_0x1008_4d6b:
            ii(0x1008_4d6b, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x1008_4d6f:
            ii(0x1008_4d6f, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1008_4d72, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1008_4d75, 2); jmpd(0x1008_4dca, 0x53); goto l_0x1008_4dca; /* jmp 0x10084dca */
        l_0x1008_4d77:
            ii(0x1008_4d77, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4d79, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_4d7c, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_4d7f, 5); calld(0x1013_ad71, 0xb_5fed);           /* call 0x1013ad71 */
            ii(0x1008_4d84, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4d86, 2); if(jzd(0x1008_4d9a, 0x12)) goto l_0x1008_4d9a; /* jz 0x10084d9a */
            ii(0x1008_4d88, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_4d8b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_4d8e, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_4d91, 5); calld(0x1008_b4ec, 0x6756);             /* call 0x1008b4ec */
            ii(0x1008_4d96, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4d98, 2); if(jnzd(0x1008_4d9c, 0x2)) goto l_0x1008_4d9c; /* jnz 0x10084d9c */
        l_0x1008_4d9a:
            ii(0x1008_4d9a, 2); jmpd(0x1008_4da2, 0x6); goto l_0x1008_4da2; /* jmp 0x10084da2 */
        l_0x1008_4d9c:
            ii(0x1008_4d9c, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_4da0, 2); jmpd(0x1008_4dca, 0x28); goto l_0x1008_4dca; /* jmp 0x10084dca */
        l_0x1008_4da2:
            ii(0x1008_4da2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4da5, 5); calld(0x1007_623c, -0xeb6e);            /* call 0x1007623c */
            ii(0x1008_4daa, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4dac, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4daf, 5); calld(0x1007_6ec0, -0xdef4);            /* call 0x10076ec0 */
            ii(0x1008_4db4, 4); cmp(ax, memw_a32[ds, edx + 0x17]);      /* cmp ax, [edx+0x17] */
            ii(0x1008_4db8, 2); if(jgd(0x1008_4dc0, 0x6)) goto l_0x1008_4dc0; /* jg 0x10084dc0 */
            ii(0x1008_4dba, 4); mov(memb_a32[ss, ebp - 0x1c], 0x1);     /* mov byte [ebp-0x1c], 0x1 */
            ii(0x1008_4dbe, 2); jmpd(0x1008_4dc4, 0x4); goto l_0x1008_4dc4; /* jmp 0x10084dc4 */
        l_0x1008_4dc0:
            ii(0x1008_4dc0, 4); mov(memb_a32[ss, ebp - 0x1c], 0);       /* mov byte [ebp-0x1c], 0x0 */
        l_0x1008_4dc4:
            ii(0x1008_4dc4, 3); mov(al, memb_a32[ss, ebp - 0x1c]);      /* mov al, [ebp-0x1c] */
            ii(0x1008_4dc7, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
        l_0x1008_4dca:
            ii(0x1008_4dca, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_4dcd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_4dcf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_4dd0, 1); popd(edi);                              /* pop edi */
            ii(0x1008_4dd1, 1); popd(esi);                              /* pop esi */
            ii(0x1008_4dd2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_4dd3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_4dd4, 1); retd();                                 /* ret */
        }
    }
}
