using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("35883f90-1bdd-478e-8919-f4108773b1a4")]
        public void Method_1010_01f8()
        {
            ii(0x1010_01f8, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x1010_01fd, 5); calld(Definitions.sys_check_available_stack_size, 0x6_5b50); /* call 0x10165d52 */
            ii(0x1010_0202, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_0203, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_0204, 1); pushd(edx);                             /* push edx */
            ii(0x1010_0205, 1); pushd(esi);                             /* push esi */
            ii(0x1010_0206, 1); pushd(edi);                             /* push edi */
            ii(0x1010_0207, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_0208, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_020a, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1010_0210, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_0213, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0216, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1010_0219, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_021c, 5); calld(0x1007_1f2e, -0x8_e2f3);          /* call 0x10071f2e */
            ii(0x1010_0221, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_0224, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_0228, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_022a, 2); if(jzd(0x1010_023f, 0x13)) goto l_0x1010_023f; /* jz 0x1010023f */
            ii(0x1010_022c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_022f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0231, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1010_0234, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_0236, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1010_023b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_023d, 2); if(jzd(0x1010_0241, 0x2)) goto l_0x1010_0241; /* jz 0x10100241 */
        l_0x1010_023f:
            ii(0x1010_023f, 2); jmpd(0x1010_0254, 0x13); goto l_0x1010_0254; /* jmp 0x10100254 */
        l_0x1010_0241:
            ii(0x1010_0241, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0244, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1010_0247, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_024a, 5); calld(0x1007_1ff5, -0x8_e25a);          /* call 0x10071ff5 */
            ii(0x1010_024f, 1); cwde();                                 /* cwde */
            ii(0x1010_0250, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_0252, 2); if(jzd(0x1010_0259, 0x5)) goto l_0x1010_0259; /* jz 0x10100259 */
        l_0x1010_0254:
            ii(0x1010_0254, 5); jmpd(0x1010_043f, 0x1e6); goto l_0x1010_043f; /* jmp 0x1010043f */
        l_0x1010_0259:
            ii(0x1010_0259, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_025c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_025f, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1010_0266, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1010_026d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_0270, 5); calld(0x1007_20b1, -0x8_e1c4);          /* call 0x100720b1 */
            ii(0x1010_0275, 5); calld(0x1007_6014, -0x8_a266);          /* call 0x10076014 */
            ii(0x1010_027a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_027c, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1010_027e, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1010_0281, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0284, 5); calld(0x1007_2388, -0x8_df01);          /* call 0x10072388 */
            ii(0x1010_0289, 3); mov(eax, memd_a32[ss, ebp - 0x1a]);     /* mov eax, [ebp-0x1a] */
            ii(0x1010_028c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_028f, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_0293, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_0295, 2); if(jged(0x1010_02c8, 0x31)) goto l_0x1010_02c8; /* jge 0x101002c8 */
            ii(0x1010_0297, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_029c, 1); pushd(eax);                             /* push eax */
            ii(0x1010_029d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_02a0, 2); neg(eax);                               /* neg eax */
            ii(0x1010_02a2, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1010_02a7, 1); pushd(eax);                             /* push eax */
            ii(0x1010_02a8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_02ab, 2); neg(eax);                               /* neg eax */
            ii(0x1010_02ad, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_02af, 3); mov(cx, ax);                            /* mov cx, ax */
            ii(0x1010_02b2, 5); mov(ebx, 0x290);                        /* mov ebx, 0x290 */
            ii(0x1010_02b7, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
            ii(0x1010_02bc, 5); mov(eax, StringDefinitions.Power);      /* mov eax, 0x101a2b2b */
            ii(0x1010_02c1, 5); calld(0x100f_ff95, -0x331);             /* call 0x100fff95 */
            ii(0x1010_02c6, 2); jmpd(0x1010_02ef, 0x27); goto l_0x1010_02ef; /* jmp 0x101002ef */
        l_0x1010_02c8:
            ii(0x1010_02c8, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_02cd, 1); pushd(eax);                             /* push eax */
            ii(0x1010_02ce, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_02d0, 4); mov(ax, memw_a32[ss, ebp - 0x8]);       /* mov ax, [ebp-0x8] */
            ii(0x1010_02d4, 1); pushd(eax);                             /* push eax */
            ii(0x1010_02d5, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_02d7, 4); mov(cx, memw_a32[ss, ebp - 0x10]);      /* mov cx, [ebp-0x10] */
            ii(0x1010_02db, 5); mov(ebx, 0x290);                        /* mov ebx, 0x290 */
            ii(0x1010_02e0, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
            ii(0x1010_02e5, 5); mov(eax, StringDefinitions.Usage4);     /* mov eax, 0x101a2b31 */
            ii(0x1010_02ea, 5); calld(0x100f_ff95, -0x35a);             /* call 0x100fff95 */
        l_0x1010_02ef:
            ii(0x1010_02ef, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_02f6, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1010_02fd, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1010_0302, 5); calld(0x1007_6338, -0x8_9fcf);          /* call 0x10076338 */
            ii(0x1010_0307, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x1010_030a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_030c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_030e, 5); calld(0x1007_64b8, -0x8_9e5b);          /* call 0x100764b8 */
            ii(0x1010_0313, 2); jmpd(0x1010_031d, 0x8); goto l_0x1010_031d; /* jmp 0x1010031d */
        l_0x1010_0315:
            ii(0x1010_0315, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_0318, 5); calld(0x1007_6bf8, -0x8_9725);          /* call 0x10076bf8 */
        l_0x1010_031d:
            ii(0x1010_031d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_031f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_0322, 5); calld(0x1013_ad71, 0x3_aa4a);           /* call 0x1013ad71 */
            ii(0x1010_0327, 2); test(al, al);                           /* test al, al */
            ii(0x1010_0329, 6); if(jzd(0x1010_03ab, 0x7c)) goto l_0x1010_03ab; /* jz 0x101003ab */
            ii(0x1010_032f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_0332, 5); calld(0x1007_63a0, -0x8_9f97);          /* call 0x100763a0 */
            ii(0x1010_0337, 5); calld(0x1007_6204, -0x8_a138);          /* call 0x10076204 */
            ii(0x1010_033c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_033e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0341, 5); calld(0x1007_6204, -0x8_a142);          /* call 0x10076204 */
            ii(0x1010_0346, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_0348, 2); if(jnzd(0x1010_03a6, 0x5c)) goto l_0x1010_03a6; /* jnz 0x101003a6 */
            ii(0x1010_034a, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_034d, 5); calld(0x1007_63a0, -0x8_9fb2);          /* call 0x100763a0 */
            ii(0x1010_0352, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1010_0355, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_0358, 5); calld(0x1007_1f2e, -0x8_e42f);          /* call 0x10071f2e */
            ii(0x1010_035d, 4); mov(memw_a32[ss, ebp - 0x1a], ax);      /* mov [ebp-0x1a], ax */
            ii(0x1010_0361, 4); movsx(eax, memw_a32[ss, ebp - 0x1a]);   /* movsx eax, word [ebp-0x1a] */
            ii(0x1010_0365, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_0367, 2); if(jged(0x1010_0371, 0x8)) goto l_0x1010_0371; /* jge 0x10100371 */
            ii(0x1010_0369, 3); mov(eax, memd_a32[ss, ebp - 0x1a]);     /* mov eax, [ebp-0x1a] */
            ii(0x1010_036c, 3); sub(memd_a32[ss, ebp - 0x8], eax);      /* sub [ebp-0x8], eax */
            ii(0x1010_036f, 2); jmpd(0x1010_0377, 0x6); goto l_0x1010_0377; /* jmp 0x10100377 */
        l_0x1010_0371:
            ii(0x1010_0371, 3); mov(eax, memd_a32[ss, ebp - 0x1a]);     /* mov eax, [ebp-0x1a] */
            ii(0x1010_0374, 3); add(memd_a32[ss, ebp - 0xc], eax);      /* add [ebp-0xc], eax */
        l_0x1010_0377:
            ii(0x1010_0377, 5); calld(0x1007_6014, -0x8_a368);          /* call 0x10076014 */
            ii(0x1010_037c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_037e, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1010_0380, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1010_0383, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_0386, 5); calld(0x1007_63d4, -0x8_9fb7);          /* call 0x100763d4 */
            ii(0x1010_038b, 5); calld(0x1007_2388, -0x8_e008);          /* call 0x10072388 */
            ii(0x1010_0390, 4); movsx(eax, memw_a32[ss, ebp - 0x1a]);   /* movsx eax, word [ebp-0x1a] */
            ii(0x1010_0394, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_0396, 2); if(jged(0x1010_03a0, 0x8)) goto l_0x1010_03a0; /* jge 0x101003a0 */
            ii(0x1010_0398, 3); mov(eax, memd_a32[ss, ebp - 0x1a]);     /* mov eax, [ebp-0x1a] */
            ii(0x1010_039b, 3); sub(memd_a32[ss, ebp - 0x14], eax);     /* sub [ebp-0x14], eax */
            ii(0x1010_039e, 2); jmpd(0x1010_03a6, 0x6); goto l_0x1010_03a6; /* jmp 0x101003a6 */
        l_0x1010_03a0:
            ii(0x1010_03a0, 3); mov(eax, memd_a32[ss, ebp - 0x1a]);     /* mov eax, [ebp-0x1a] */
            ii(0x1010_03a3, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
        l_0x1010_03a6:
            ii(0x1010_03a6, 5); jmpd(0x1010_0315, -0x96); goto l_0x1010_0315; /* jmp 0x10100315 */
        l_0x1010_03ab:
            ii(0x1010_03ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_03ae, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1010_03b1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_03b4, 5); calld(0x1007_1f2e, -0x8_e48b);          /* call 0x10071f2e */
            ii(0x1010_03b9, 1); cwde();                                 /* cwde */
            ii(0x1010_03ba, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_03bc, 2); if(jled(0x1010_03e7, 0x29)) goto l_0x1010_03e7; /* jle 0x101003e7 */
            ii(0x1010_03be, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_03c3, 1); pushd(eax);                             /* push eax */
            ii(0x1010_03c4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_03c6, 4); mov(ax, memw_a32[ss, ebp - 0xc]);       /* mov ax, [ebp-0xc] */
            ii(0x1010_03ca, 1); pushd(eax);                             /* push eax */
            ii(0x1010_03cb, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_03cd, 4); mov(cx, memw_a32[ss, ebp - 0x14]);      /* mov cx, [ebp-0x14] */
            ii(0x1010_03d1, 5); mov(ebx, 0x290);                        /* mov ebx, 0x290 */
            ii(0x1010_03d6, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1010_03db, 5); mov(eax, StringDefinitions.Total5);     /* mov eax, 0x101a2b37 */
            ii(0x1010_03e0, 5); calld(0x100f_ff95, -0x450);             /* call 0x100fff95 */
            ii(0x1010_03e5, 2); jmpd(0x1010_0435, 0x4e); goto l_0x1010_0435; /* jmp 0x10100435 */
        l_0x1010_03e7:
            ii(0x1010_03e7, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_03ec, 1); pushd(eax);                             /* push eax */
            ii(0x1010_03ed, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_03ef, 4); mov(ax, memw_a32[ss, ebp - 0x8]);       /* mov ax, [ebp-0x8] */
            ii(0x1010_03f3, 1); pushd(eax);                             /* push eax */
            ii(0x1010_03f4, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_03f6, 4); mov(cx, memw_a32[ss, ebp - 0x10]);      /* mov cx, [ebp-0x10] */
            ii(0x1010_03fa, 5); mov(ebx, 0x290);                        /* mov ebx, 0x290 */
            ii(0x1010_03ff, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1010_0404, 5); mov(eax, StringDefinitions.Total6);     /* mov eax, 0x101a2b3d */
            ii(0x1010_0409, 5); calld(0x100f_ff95, -0x479);             /* call 0x100fff95 */
            ii(0x1010_040e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_0413, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0414, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_0416, 4); mov(ax, memw_a32[ss, ebp - 0xc]);       /* mov ax, [ebp-0xc] */
            ii(0x1010_041a, 1); pushd(eax);                             /* push eax */
            ii(0x1010_041b, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_041d, 4); mov(cx, memw_a32[ss, ebp - 0x14]);      /* mov cx, [ebp-0x14] */
            ii(0x1010_0421, 5); mov(ebx, 0x290);                        /* mov ebx, 0x290 */
            ii(0x1010_0426, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1010_042b, 5); mov(eax, StringDefinitions.Usage3);     /* mov eax, 0x101a2b43 */
            ii(0x1010_0430, 5); calld(0x100f_ff95, -0x4a0);             /* call 0x100fff95 */
        l_0x1010_0435:
            ii(0x1010_0435, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0437, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_043a, 5); calld(0x1007_5f6c, -0x8_a4d3);          /* call 0x10075f6c */
        l_0x1010_043f:
            ii(0x1010_043f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_0441, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_0442, 1); popd(edi);                              /* pop edi */
            ii(0x1010_0443, 1); popd(esi);                              /* pop esi */
            ii(0x1010_0444, 1); popd(edx);                              /* pop edx */
            ii(0x1010_0445, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_0446, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_0447, 1); retd(); return;                         /* ret */
        }
    }
}
