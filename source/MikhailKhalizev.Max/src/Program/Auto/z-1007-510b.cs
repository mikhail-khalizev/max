using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_510b-6dcaa3fd")]
        public void Method_1007_510b()
        {
            ii(0x1007_510b, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1007_5110, 5); calld(Definitions.sys_check_available_stack_size, 0xf_0c3d); /* call 0x10165d52 */
            ii(0x1007_5115, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_5116, 1); pushd(esi);                             /* push esi */
            ii(0x1007_5117, 1); pushd(edi);                             /* push edi */
            ii(0x1007_5118, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_5119, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_511b, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1007_5121, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_5124, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1007_5127, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1007_512a, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_512e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_5130, 2); if(jld(0x1007_513e, 0xc)) goto l_0x1007_513e; /* jl 0x1007513e */
            ii(0x1007_5132, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_5135, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1007_513c, 2); if(jld(0x1007_5140, 0x2)) goto l_0x1007_5140; /* jl 0x10075140 */
        l_0x1007_513e:
            ii(0x1007_513e, 2); jmpd(0x1007_5148, 0x8); goto l_0x1007_5148; /* jmp 0x10075148 */
        l_0x1007_5140:
            ii(0x1007_5140, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1007_5144, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_5146, 2); if(jged(0x1007_514a, 0x2)) goto l_0x1007_514a; /* jge 0x1007514a */
        l_0x1007_5148:
            ii(0x1007_5148, 2); jmpd(0x1007_5156, 0xc); goto l_0x1007_5156; /* jmp 0x10075156 */
        l_0x1007_514a:
            ii(0x1007_514a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_514d, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1007_5154, 2); if(jld(0x1007_5162, 0xc)) goto l_0x1007_5162; /* jl 0x10075162 */
        l_0x1007_5156:
            ii(0x1007_5156, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_515d, 5); jmpd(0x1007_5327, 0x1c5); goto l_0x1007_5327; /* jmp 0x10075327 */
        l_0x1007_5162:
            ii(0x1007_5162, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_5164, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1007_5167, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x1007_516a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_516d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_5170, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1007_5173, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_5176, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_517a, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_517e, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_5183, 5); calld(0x1010_3541, 0x8_e3b9);           /* call 0x10103541 */
            ii(0x1007_5188, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_518a, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_518d, 5); calld(0x1007_64b8, 0x1326);             /* call 0x100764b8 */
        l_0x1007_5192:
            ii(0x1007_5192, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_5194, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_5197, 5); calld(0x1013_ad71, 0xc_5bd5);           /* call 0x1013ad71 */
            ii(0x1007_519c, 2); test(al, al);                           /* test al, al */
            ii(0x1007_519e, 6); if(jzd(0x1007_530a, 0x166)) goto l_0x1007_530a; /* jz 0x1007530a */
            ii(0x1007_51a4, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_51a7, 5); calld(0x1007_63a0, 0x11f4);             /* call 0x100763a0 */
            ii(0x1007_51ac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_51ae, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_51b1, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1007_51b5, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_51b7, 2); if(jnzd(0x1007_51c7, 0xe)) goto l_0x1007_51c7; /* jnz 0x100751c7 */
            ii(0x1007_51b9, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_51bc, 5); calld(0x1007_63a0, 0x11df);             /* call 0x100763a0 */
            ii(0x1007_51c1, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_51c5, 2); if(jnzd(0x1007_51cc, 0x5)) goto l_0x1007_51cc; /* jnz 0x100751cc */
        l_0x1007_51c7:
            ii(0x1007_51c7, 5); jmpd(0x1007_52fd, 0x131); goto l_0x1007_52fd; /* jmp 0x100752fd */
        l_0x1007_51cc:
            ii(0x1007_51cc, 7); test(memd_a32[ss, ebp - 0x18], 0x100);  /* test dword [ebp-0x18], 0x100 */
            ii(0x1007_51d3, 6); if(jzd(0x1007_528a, 0xb1)) goto l_0x1007_528a; /* jz 0x1007528a */
            ii(0x1007_51d9, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_51dc, 5); calld(0x1007_63a0, 0x11bf);             /* call 0x100763a0 */
            ii(0x1007_51e1, 5); cmp(memw_a32[ds, eax + 0x8], 0x3);      /* cmp word [eax+0x8], 0x3 */
            ii(0x1007_51e6, 2); if(jzd(0x1007_51f7, 0xf)) goto l_0x1007_51f7; /* jz 0x100751f7 */
            ii(0x1007_51e8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_51eb, 5); calld(0x1007_63a0, 0x11b0);             /* call 0x100763a0 */
            ii(0x1007_51f0, 5); cmp(memw_a32[ds, eax + 0x8], 0x41);     /* cmp word [eax+0x8], 0x41 */
            ii(0x1007_51f5, 2); if(jnzd(0x1007_51f9, 0x2)) goto l_0x1007_51f9; /* jnz 0x100751f9 */
        l_0x1007_51f7:
            ii(0x1007_51f7, 2); jmpd(0x1007_5208, 0xf); goto l_0x1007_5208; /* jmp 0x10075208 */
        l_0x1007_51f9:
            ii(0x1007_51f9, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_51fc, 5); calld(0x1007_63a0, 0x119f);             /* call 0x100763a0 */
            ii(0x1007_5201, 5); cmp(memw_a32[ds, eax + 0x8], 0x48);     /* cmp word [eax+0x8], 0x48 */
            ii(0x1007_5206, 2); if(jnzd(0x1007_521e, 0x16)) goto l_0x1007_521e; /* jnz 0x1007521e */
        l_0x1007_5208:
            ii(0x1007_5208, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_520b, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_5210, 2); if(jzd(0x1007_521c, 0xa)) goto l_0x1007_521c; /* jz 0x1007521c */
            ii(0x1007_5212, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_5215, 5); cmp(memw_a32[ds, eax + 0x8], 0x43);     /* cmp word [eax+0x8], 0x43 */
            ii(0x1007_521a, 2); if(jnzd(0x1007_521e, 0x2)) goto l_0x1007_521e; /* jnz 0x1007521e */
        l_0x1007_521c:
            ii(0x1007_521c, 2); jmpd(0x1007_5220, 0x2); goto l_0x1007_5220; /* jmp 0x10075220 */
        l_0x1007_521e:
            ii(0x1007_521e, 2); jmpd(0x1007_523a, 0x1a); goto l_0x1007_523a; /* jmp 0x1007523a */
        l_0x1007_5220:
            ii(0x1007_5220, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_5223, 5); calld(0x1007_6408, 0x11e0);             /* call 0x10076408 */
            ii(0x1007_5228, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_522b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_522d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_5230, 5); calld(0x1007_5f6c, 0xd37);              /* call 0x10075f6c */
            ii(0x1007_5235, 5); jmpd(0x1007_5327, 0xed); goto l_0x1007_5327; /* jmp 0x10075327 */
        l_0x1007_523a:
            ii(0x1007_523a, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_523d, 5); calld(0x1007_63a0, 0x115e);             /* call 0x100763a0 */
            ii(0x1007_5242, 5); cmp(memw_a32[ds, eax + 0x8], 0x9);      /* cmp word [eax+0x8], 0x9 */
            ii(0x1007_5247, 2); if(jzd(0x1007_5258, 0xf)) goto l_0x1007_5258; /* jz 0x10075258 */
            ii(0x1007_5249, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_524c, 5); calld(0x1007_63a0, 0x114f);             /* call 0x100763a0 */
            ii(0x1007_5251, 5); cmp(memw_a32[ds, eax + 0x8], 0x48);     /* cmp word [eax+0x8], 0x48 */
            ii(0x1007_5256, 2); if(jnzd(0x1007_5262, 0xa)) goto l_0x1007_5262; /* jnz 0x10075262 */
        l_0x1007_5258:
            ii(0x1007_5258, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_525b, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_5260, 2); if(jnzd(0x1007_5264, 0x2)) goto l_0x1007_5264; /* jnz 0x10075264 */
        l_0x1007_5262:
            ii(0x1007_5262, 2); jmpd(0x1007_526e, 0xa); goto l_0x1007_526e; /* jmp 0x1007526e */
        l_0x1007_5264:
            ii(0x1007_5264, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_5267, 5); cmp(memw_a32[ds, eax + 0x8], 0x43);     /* cmp word [eax+0x8], 0x43 */
            ii(0x1007_526c, 2); if(jnzd(0x1007_5270, 0x2)) goto l_0x1007_5270; /* jnz 0x10075270 */
        l_0x1007_526e:
            ii(0x1007_526e, 2); jmpd(0x1007_528a, 0x1a); goto l_0x1007_528a; /* jmp 0x1007528a */
        l_0x1007_5270:
            ii(0x1007_5270, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_5273, 5); calld(0x1007_6408, 0x1190);             /* call 0x10076408 */
            ii(0x1007_5278, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_527b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_527d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_5280, 5); calld(0x1007_5f6c, 0xce7);              /* call 0x10075f6c */
            ii(0x1007_5285, 5); jmpd(0x1007_5327, 0x9d); goto l_0x1007_5327; /* jmp 0x10075327 */
        l_0x1007_528a:
            ii(0x1007_528a, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1007_528d, 5); and(eax, 0x180);                        /* and eax, 0x180 */
            ii(0x1007_5292, 5); cmp(eax, 0x80);                         /* cmp eax, 0x80 */
            ii(0x1007_5297, 2); if(jnzd(0x1007_52bf, 0x26)) goto l_0x1007_52bf; /* jnz 0x100752bf */
            ii(0x1007_5299, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_529c, 5); calld(0x1007_63a0, 0x10ff);             /* call 0x100763a0 */
            ii(0x1007_52a1, 5); cmp(memw_a32[ds, eax + 0x8], 0xb);      /* cmp word [eax+0x8], 0xb */
            ii(0x1007_52a6, 2); if(jnzd(0x1007_52bf, 0x17)) goto l_0x1007_52bf; /* jnz 0x100752bf */
            ii(0x1007_52a8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_52ab, 5); calld(0x1007_6408, 0x1158);             /* call 0x10076408 */
            ii(0x1007_52b0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_52b3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_52b5, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_52b8, 5); calld(0x1007_5f6c, 0xcaf);              /* call 0x10075f6c */
            ii(0x1007_52bd, 2); jmpd(0x1007_5327, 0x68); goto l_0x1007_5327; /* jmp 0x10075327 */
        l_0x1007_52bf:
            ii(0x1007_52bf, 7); test(memd_a32[ss, ebp - 0x18], 0x40);   /* test dword [ebp-0x18], 0x40 */
            ii(0x1007_52c6, 2); if(jzd(0x1007_52fd, 0x35)) goto l_0x1007_52fd; /* jz 0x100752fd */
            ii(0x1007_52c8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_52cb, 5); calld(0x1007_63a0, 0x10d0);             /* call 0x100763a0 */
            ii(0x1007_52d0, 5); cmp(memw_a32[ds, eax + 0x8], 0x16);     /* cmp word [eax+0x8], 0x16 */
            ii(0x1007_52d5, 2); if(jzd(0x1007_52e6, 0xf)) goto l_0x1007_52e6; /* jz 0x100752e6 */
            ii(0x1007_52d7, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_52da, 5); calld(0x1007_63a0, 0x10c1);             /* call 0x100763a0 */
            ii(0x1007_52df, 5); cmp(memw_a32[ds, eax + 0x8], 0xa);      /* cmp word [eax+0x8], 0xa */
            ii(0x1007_52e4, 2); if(jnzd(0x1007_52fd, 0x17)) goto l_0x1007_52fd; /* jnz 0x100752fd */
        l_0x1007_52e6:
            ii(0x1007_52e6, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_52e9, 5); calld(0x1007_6408, 0x111a);             /* call 0x10076408 */
            ii(0x1007_52ee, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_52f1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_52f3, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_52f6, 5); calld(0x1007_5f6c, 0xc71);              /* call 0x10075f6c */
            ii(0x1007_52fb, 2); jmpd(0x1007_5327, 0x2a); goto l_0x1007_5327; /* jmp 0x10075327 */
        l_0x1007_52fd:
            ii(0x1007_52fd, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_5300, 5); calld(0x1007_6bf8, 0x18f3);             /* call 0x10076bf8 */
            ii(0x1007_5305, 5); jmpd(0x1007_5192, -0x178); goto l_0x1007_5192; /* jmp 0x10075192 */
        l_0x1007_530a:
            ii(0x1007_530a, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_5311, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_5313, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_5316, 5); calld(0x1007_5f6c, 0xc51);              /* call 0x10075f6c */
            ii(0x1007_531b, 2); jmpd(0x1007_5327, 0xa); goto l_0x1007_5327; /* jmp 0x10075327 */
        //  ii(0x1007_531d, 10); Недостижимый код.
        l_0x1007_5327:
            ii(0x1007_5327, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_532a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_532c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_532d, 1); popd(edi);                              /* pop edi */
            ii(0x1007_532e, 1); popd(esi);                              /* pop esi */
            ii(0x1007_532f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_5330, 1); retd(); return;                         /* ret */
        }
    }
}
