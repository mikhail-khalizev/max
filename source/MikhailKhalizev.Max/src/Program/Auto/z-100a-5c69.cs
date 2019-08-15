using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9ccbd1dc-ef47-42b9-b77e-5142eeb8990b")]
        public void Method_100a_5c69()
        {
            ii(0x100a_5c69, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100a_5c6e, 5); calld(Definitions.sys_check_available_stack_size, 0xc_00df); /* call 0x10165d52 */
            ii(0x100a_5c73, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_5c74, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_5c75, 1); pushd(edx);                             /* push edx */
            ii(0x100a_5c76, 1); pushd(esi);                             /* push esi */
            ii(0x100a_5c77, 1); pushd(edi);                             /* push edi */
            ii(0x100a_5c78, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_5c79, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_5c7b, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100a_5c81, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_5c84, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100a_5c89, 5); calld(0x1007_6338, -0x2_f956);          /* call 0x10076338 */
            ii(0x100a_5c8e, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x100a_5c91, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_5c93, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_5c95, 5); calld(0x1007_64b8, -0x2_f7e2);          /* call 0x100764b8 */
            ii(0x100a_5c9a, 7); mov(memd_a32[ss, ebp - 0x10], 0xffff_fff6); /* mov dword [ebp-0x10], 0xfffffff6 */
            ii(0x100a_5ca1, 2); jmpd(0x100a_5cab, 0x8); goto l_0x100a_5cab; /* jmp 0x100a5cab */
        l_0x100a_5ca3:
            ii(0x100a_5ca3, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5ca6, 5); calld(0x1007_6bf8, -0x2_f0b3);          /* call 0x10076bf8 */
        l_0x100a_5cab:
            ii(0x100a_5cab, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_5cad, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5cb0, 5); calld(0x1013_ad71, 0x9_50bc);           /* call 0x1013ad71 */
            ii(0x100a_5cb5, 2); test(al, al);                           /* test al, al */
            ii(0x100a_5cb7, 6); if(jzd(0x100a_5d28, 0x6b)) goto l_0x100a_5d28; /* jz 0x100a5d28 */
            ii(0x100a_5cbd, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5cc0, 5); calld(0x1007_63a0, -0x2_f925);          /* call 0x100763a0 */
            ii(0x100a_5cc5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_5cc7, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100a_5cca, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100a_5cce, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_5cd0, 2); if(jnzd(0x100a_5cec, 0x1a)) goto l_0x100a_5cec; /* jnz 0x100a5cec */
            ii(0x100a_5cd2, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5cd5, 5); calld(0x1007_63a0, -0x2_f93a);          /* call 0x100763a0 */
            ii(0x100a_5cda, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100a_5cdd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_5ce0, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100a_5ce3, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x1); /* cmp byte [eax+0x101c81d5], 0x1 */
            ii(0x100a_5cea, 2); if(jzd(0x100a_5cee, 0x2)) goto l_0x100a_5cee; /* jz 0x100a5cee */
        l_0x100a_5cec:
            ii(0x100a_5cec, 2); jmpd(0x100a_5d23, 0x35); goto l_0x100a_5d23; /* jmp 0x100a5d23 */
        l_0x100a_5cee:
            ii(0x100a_5cee, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5cf1, 5); calld(0x1007_63a0, -0x2_f956);          /* call 0x100763a0 */
            ii(0x100a_5cf6, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x100a_5cfa, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
            ii(0x100a_5cfd, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5d00, 5); calld(0x1007_63a0, -0x2_f965);          /* call 0x100763a0 */
            ii(0x100a_5d05, 5); cmp(memw_a32[ds, eax + 0x8], 0x3d);     /* cmp word [eax+0x8], 0x3d */
            ii(0x100a_5d0a, 2); if(jnzd(0x100a_5d10, 0x4)) goto l_0x100a_5d10; /* jnz 0x100a5d10 */
            ii(0x100a_5d0c, 4); add(memd_a32[ss, ebp - 0x10], -0xf /* 0xf1 */); /* add dword [ebp-0x10], 0xfffffff1 */
        l_0x100a_5d10:
            ii(0x100a_5d10, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5d13, 5); calld(0x1007_63a0, -0x2_f978);          /* call 0x100763a0 */
            ii(0x100a_5d18, 5); cmp(memw_a32[ds, eax + 0x8], 0x31);     /* cmp word [eax+0x8], 0x31 */
            ii(0x100a_5d1d, 2); if(jnzd(0x100a_5d23, 0x4)) goto l_0x100a_5d23; /* jnz 0x100a5d23 */
            ii(0x100a_5d1f, 4); add(memd_a32[ss, ebp - 0x10], -0x1e /* 0xe2 */); /* add dword [ebp-0x10], 0xffffffe2 */
        l_0x100a_5d23:
            ii(0x100a_5d23, 5); jmpd(0x100a_5ca3, -0x85); goto l_0x100a_5ca3; /* jmp 0x100a5ca3 */
        l_0x100a_5d28:
            ii(0x100a_5d28, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100a_5d2d, 5); calld(0x1007_6338, -0x2_f9fa);          /* call 0x10076338 */
            ii(0x100a_5d32, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x100a_5d35, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_5d37, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_5d39, 5); calld(0x1007_643c, -0x2_f902);          /* call 0x1007643c */
            ii(0x100a_5d3e, 2); jmpd(0x100a_5d48, 0x8); goto l_0x100a_5d48; /* jmp 0x100a5d48 */
        l_0x100a_5d40:
            ii(0x100a_5d40, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5d43, 5); calld(0x1007_6bf8, -0x2_f150);          /* call 0x10076bf8 */
        l_0x100a_5d48:
            ii(0x100a_5d48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_5d4a, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5d4d, 5); calld(0x1013_ad71, 0x9_501f);           /* call 0x1013ad71 */
            ii(0x100a_5d52, 2); test(al, al);                           /* test al, al */
            ii(0x100a_5d54, 6); if(jzd(0x100a_5ded, 0x93)) goto l_0x100a_5ded; /* jz 0x100a5ded */
            ii(0x100a_5d5a, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5d5d, 5); calld(0x1007_63a0, -0x2_f9c2);          /* call 0x100763a0 */
            ii(0x100a_5d62, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_5d64, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100a_5d67, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100a_5d6b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_5d6d, 6); if(jnzd(0x100a_5de8, 0x75)) goto l_0x100a_5de8; /* jnz 0x100a5de8 */
            ii(0x100a_5d73, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_5d78, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5d7b, 5); calld(0x1007_63a0, -0x2_f9e0);          /* call 0x100763a0 */
            ii(0x100a_5d80, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100a_5d83, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_5d86, 5); calld(0x1007_1e00, -0x3_3f8b);          /* call 0x10071e00 */
            ii(0x100a_5d8b, 3); sub(memd_a32[ss, ebp - 0x10], eax);     /* sub [ebp-0x10], eax */
            ii(0x100a_5d8e, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5d91, 5); calld(0x1007_63a0, -0x2_f9f6);          /* call 0x100763a0 */
            ii(0x100a_5d96, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100a_5d99, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_5d9c, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100a_5d9f, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x1); /* cmp byte [eax+0x101c81d5], 0x1 */
            ii(0x100a_5da6, 2); if(jnzd(0x100a_5de8, 0x40)) goto l_0x100a_5de8; /* jnz 0x100a5de8 */
            ii(0x100a_5da8, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5dab, 5); calld(0x1007_63a0, -0x2_fa10);          /* call 0x100763a0 */
            ii(0x100a_5db0, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x100a_5db4, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
            ii(0x100a_5db7, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5dba, 5); calld(0x1007_63a0, -0x2_fa1f);          /* call 0x100763a0 */
            ii(0x100a_5dbf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_5dc1, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5dc4, 5); calld(0x1007_63a0, -0x2_fa29);          /* call 0x100763a0 */
            ii(0x100a_5dc9, 5); calld(0x1007_623c, -0x2_fb92);          /* call 0x1007623c */
            ii(0x100a_5dce, 4); mov(dx, memw_a32[ds, edx + 0x52]);      /* mov dx, [edx+0x52] */
            ii(0x100a_5dd2, 4); cmp(dx, memw_a32[ds, eax + 0x19]);      /* cmp dx, [eax+0x19] */
            ii(0x100a_5dd6, 2); if(jnzd(0x100a_5de8, 0x10)) goto l_0x100a_5de8; /* jnz 0x100a5de8 */
            ii(0x100a_5dd8, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_5ddc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_5dde, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5de1, 5); calld(0x1007_5f6c, -0x2_fe7a);          /* call 0x10075f6c */
            ii(0x100a_5de6, 2); jmpd(0x100a_5e1b, 0x33); goto l_0x100a_5e1b; /* jmp 0x100a5e1b */
        l_0x100a_5de8:
            ii(0x100a_5de8, 5); jmpd(0x100a_5d40, -0xad); goto l_0x100a_5d40; /* jmp 0x100a5d40 */
        l_0x100a_5ded:
            ii(0x100a_5ded, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100a_5df1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_5df3, 2); if(jged(0x100a_5dfb, 0x6)) goto l_0x100a_5dfb; /* jge 0x100a5dfb */
            ii(0x100a_5df5, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x100a_5df9, 2); jmpd(0x100a_5dff, 0x4); goto l_0x100a_5dff; /* jmp 0x100a5dff */
        l_0x100a_5dfb:
            ii(0x100a_5dfb, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
        l_0x100a_5dff:
            ii(0x100a_5dff, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100a_5e02, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100a_5e05, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_5e07, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5e0a, 5); calld(0x1007_5f6c, -0x2_fea3);          /* call 0x10075f6c */
            ii(0x100a_5e0f, 2); jmpd(0x100a_5e1b, 0xa); goto l_0x100a_5e1b; /* jmp 0x100a5e1b */
        //    ii(0x100a_5e11, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100a_5e13, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
        //    ii(0x100a_5e16, 5); calld(0x1007_5f6c, -0x2_feaf);          /* call 0x10075f6c */
        l_0x100a_5e1b:
            ii(0x100a_5e1b, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100a_5e1e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_5e20, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_5e21, 1); popd(edi);                              /* pop edi */
            ii(0x100a_5e22, 1); popd(esi);                              /* pop esi */
            ii(0x100a_5e23, 1); popd(edx);                              /* pop edx */
            ii(0x100a_5e24, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_5e25, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_5e26, 1); retd(); return;                         /* ret */
        }
    }
}
