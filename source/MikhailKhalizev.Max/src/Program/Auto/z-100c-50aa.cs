using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_50aa-2320cf02")]
        public void Method_100c_50aa()
        {
            ii(0x100c_50aa, 5); push(0x144);                            /* push 0x144 */
            ii(0x100c_50af, 5); call(Definitions.sys_check_available_stack_size, 0xa_0c9e); /* call 0x10165d52 */
            ii(0x100c_50b4, 1); push(ebx);                              /* push ebx */
            ii(0x100c_50b5, 1); push(ecx);                              /* push ecx */
            ii(0x100c_50b6, 1); push(edx);                              /* push edx */
            ii(0x100c_50b7, 1); push(esi);                              /* push esi */
            ii(0x100c_50b8, 1); push(edi);                              /* push edi */
            ii(0x100c_50b9, 1); push(ebp);                              /* push ebp */
            ii(0x100c_50ba, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_50bc, 6); sub(esp, 0x124);                        /* sub esp, 0x124 */
            ii(0x100c_50c2, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_50c5, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x100c_50c9, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_50cc, 5); call(0x100c_9ff0, 0x4f1f);              /* call 0x100c9ff0 */
            ii(0x100c_50d1, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100c_50d4, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100c_50d8, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x100c_50dc, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100c_50df, 5); call(0x1008_bbed, -0x3_94f7);           /* call 0x1008bbed */
            ii(0x100c_50e4, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100c_50e7, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100c_50eb, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100c_50ee, 5); call(Definitions.my_ctor_0x101b_4184, -0x4_e603); /* call 0x10076af0 */
            ii(0x100c_50f3, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x100c_50fa, 6); mov(memw[ss, ebp - 0x3c], 0);           /* mov word [ebp-0x3c], 0x0 */
            ii(0x100c_5100, 2); jmp(0x100c_5109, 0x7); goto l_0x100c_5109; /* jmp 0x100c5109 */
        l_0x100c_5102:
            ii(0x100c_5102, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x100c_5105, 4); inc(memw[ss, ebp - 0x3c]);              /* inc word [ebp-0x3c] */
        l_0x100c_5109:
            ii(0x100c_5109, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x100c_510c, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100c_5113, 6); if(jge(0x100c_51c5, 0xac)) goto l_0x100c_51c5; /* jge 0x100c51c5 */
            ii(0x100c_5119, 6); mov(memw[ss, ebp - 0x3a], 0);           /* mov word [ebp-0x3a], 0x0 */
            ii(0x100c_511f, 2); jmp(0x100c_5128, 0x7); goto l_0x100c_5128; /* jmp 0x100c5128 */
        l_0x100c_5121:
            ii(0x100c_5121, 3); mov(eax, memd[ss, ebp - 0x3a]);         /* mov eax, [ebp-0x3a] */
            ii(0x100c_5124, 4); inc(memw[ss, ebp - 0x3a]);              /* inc word [ebp-0x3a] */
        l_0x100c_5128:
            ii(0x100c_5128, 3); mov(eax, memd[ss, ebp - 0x3a]);         /* mov eax, [ebp-0x3a] */
            ii(0x100c_512b, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x100c_5132, 6); if(jge(0x100c_51c0, 0x88)) goto l_0x100c_51c0; /* jge 0x100c51c0 */
            ii(0x100c_5138, 4); movsx(edx, memw[ss, ebp - 0x3a]);       /* movsx edx, word [ebp-0x3a] */
            ii(0x100c_513c, 4); movsx(eax, memw[ss, ebp - 0x3c]);       /* movsx eax, word [ebp-0x3c] */
            ii(0x100c_5140, 5); call(0x1007_3cfd, -0x5_1448);           /* call 0x10073cfd */
            ii(0x100c_5145, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_5148, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_514b, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x100c_514e, 2); jmp(0x100c_5195, 0x45); goto l_0x100c_5195; /* jmp 0x100c5195 */
        l_0x100c_5150:
            ii(0x100c_5150, 4); movsx(ebx, memw[ss, ebp - 0x3a]);       /* movsx ebx, word [ebp-0x3a] */
            ii(0x100c_5154, 4); movsx(edx, memw[ss, ebp - 0x3c]);       /* movsx edx, word [ebp-0x3c] */
            ii(0x100c_5158, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100c_515b, 5); call(0x1008_a728, -0x3_aa38);           /* call 0x1008a728 */
            ii(0x100c_5160, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_5162, 3); mov(memb[ds, eax], 0x2);                /* mov byte [eax], 0x2 */
            ii(0x100c_5165, 2); jmp(0x100c_51bb, 0x54); goto l_0x100c_51bb; /* jmp 0x100c51bb */
        l_0x100c_5167:
            ii(0x100c_5167, 4); movsx(ebx, memw[ss, ebp - 0x3a]);       /* movsx ebx, word [ebp-0x3a] */
            ii(0x100c_516b, 4); movsx(edx, memw[ss, ebp - 0x3c]);       /* movsx edx, word [ebp-0x3c] */
            ii(0x100c_516f, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100c_5172, 5); call(0x1008_a728, -0x3_aa4f);           /* call 0x1008a728 */
            ii(0x100c_5177, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_5179, 3); mov(memb[ds, eax], 0x1);                /* mov byte [eax], 0x1 */
            ii(0x100c_517c, 2); jmp(0x100c_51bb, 0x3d); goto l_0x100c_51bb; /* jmp 0x100c51bb */
        l_0x100c_517e:
            ii(0x100c_517e, 4); movsx(ebx, memw[ss, ebp - 0x3a]);       /* movsx ebx, word [ebp-0x3a] */
            ii(0x100c_5182, 4); movsx(edx, memw[ss, ebp - 0x3c]);       /* movsx edx, word [ebp-0x3c] */
            ii(0x100c_5186, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100c_5189, 5); call(0x1008_a728, -0x3_aa66);           /* call 0x1008a728 */
            ii(0x100c_518e, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_5190, 3); mov(memb[ds, eax], 0);                  /* mov byte [eax], 0x0 */
            ii(0x100c_5193, 2); jmp(0x100c_51bb, 0x26); goto l_0x100c_51bb; /* jmp 0x100c51bb */
        l_0x100c_5195:
            ii(0x100c_5195, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x100c_5198, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x100c_519b, 5); cmp(memw[ss, ebp - 0x5c], 0x2);         /* cmp word [ebp-0x5c], 0x2 */
            ii(0x100c_51a0, 2); if(jb(0x100c_51b2, 0x10)) goto l_0x100c_51b2; /* jb 0x100c51b2 */
            ii(0x100c_51a2, 5); cmp(memw[ss, ebp - 0x5c], 0x2);         /* cmp word [ebp-0x5c], 0x2 */
            ii(0x100c_51a7, 2); if(jbe(0x100c_5167, -0x42)) goto l_0x100c_5167; /* jbe 0x100c5167 */
            ii(0x100c_51a9, 5); cmp(memw[ss, ebp - 0x5c], 0x4);         /* cmp word [ebp-0x5c], 0x4 */
            ii(0x100c_51ae, 2); if(jz(0x100c_5167, -0x49)) goto l_0x100c_5167; /* jz 0x100c5167 */
            ii(0x100c_51b0, 2); jmp(0x100c_517e, -0x34); goto l_0x100c_517e; /* jmp 0x100c517e */
        l_0x100c_51b2:
            ii(0x100c_51b2, 5); cmp(memw[ss, ebp - 0x5c], 0x1);         /* cmp word [ebp-0x5c], 0x1 */
            ii(0x100c_51b7, 2); if(jz(0x100c_5150, -0x69)) goto l_0x100c_5150; /* jz 0x100c5150 */
            ii(0x100c_51b9, 2); jmp(0x100c_517e, -0x3d); goto l_0x100c_517e; /* jmp 0x100c517e */
        l_0x100c_51bb:
            ii(0x100c_51bb, 5); jmp(0x100c_5121, -0x9f); goto l_0x100c_5121; /* jmp 0x100c5121 */
        l_0x100c_51c0:
            ii(0x100c_51c0, 5); jmp(0x100c_5102, -0xc3); goto l_0x100c_5102; /* jmp 0x100c5102 */
        l_0x100c_51c5:
            ii(0x100c_51c5, 6); mov(memw[ss, ebp - 0x3c], 0);           /* mov word [ebp-0x3c], 0x0 */
            ii(0x100c_51cb, 2); jmp(0x100c_51d4, 0x7); goto l_0x100c_51d4; /* jmp 0x100c51d4 */
        l_0x100c_51cd:
            ii(0x100c_51cd, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x100c_51d0, 4); inc(memw[ss, ebp - 0x3c]);              /* inc word [ebp-0x3c] */
        l_0x100c_51d4:
            ii(0x100c_51d4, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x100c_51d7, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100c_51de, 6); if(jge(0x100c_52ee, 0x10a)) goto l_0x100c_52ee; /* jge 0x100c52ee */
            ii(0x100c_51e4, 6); mov(memw[ss, ebp - 0x3a], 0);           /* mov word [ebp-0x3a], 0x0 */
            ii(0x100c_51ea, 2); jmp(0x100c_51f3, 0x7); goto l_0x100c_51f3; /* jmp 0x100c51f3 */
        l_0x100c_51ec:
            ii(0x100c_51ec, 3); mov(eax, memd[ss, ebp - 0x3a]);         /* mov eax, [ebp-0x3a] */
            ii(0x100c_51ef, 4); inc(memw[ss, ebp - 0x3a]);              /* inc word [ebp-0x3a] */
        l_0x100c_51f3:
            ii(0x100c_51f3, 3); mov(eax, memd[ss, ebp - 0x3a]);         /* mov eax, [ebp-0x3a] */
            ii(0x100c_51f6, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x100c_51fd, 6); if(jge(0x100c_52e9, 0xe6)) goto l_0x100c_52e9; /* jge 0x100c52e9 */
            ii(0x100c_5203, 4); movsx(ebx, memw[ss, ebp - 0x3a]);       /* movsx ebx, word [ebp-0x3a] */
            ii(0x100c_5207, 4); movsx(edx, memw[ss, ebp - 0x3c]);       /* movsx edx, word [ebp-0x3c] */
            ii(0x100c_520b, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100c_520e, 5); call(0x1008_a728, -0x3_aaeb);           /* call 0x1008a728 */
            ii(0x100c_5213, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_5215, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100c_5217, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_521c, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100c_521f, 6); if(jnz(0x100c_52e4, 0xbf)) goto l_0x100c_52e4; /* jnz 0x100c52e4 */
            ii(0x100c_5225, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x100c_5229, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x100c_522c, 5); call(0x1008_9724, -0x3_bb0d);           /* call 0x10089724 */
            ii(0x100c_5231, 3); mov(memd[ss, ebp - 0x64], eax);         /* mov [ebp-0x64], eax */
            ii(0x100c_5234, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100c_5238, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x100c_523d, 5); call(Definitions.sys_new, 0xa_0bbe);    /* call 0x10165e00 */
            ii(0x100c_5242, 3); mov(memd[ss, ebp - 0x68], eax);         /* mov [ebp-0x68], eax */
            ii(0x100c_5245, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x100c_5248, 3); mov(memd[ss, ebp - 0x6c], eax);         /* mov [ebp-0x6c], eax */
            ii(0x100c_524b, 4); cmp(memd[ss, ebp - 0x6c], 0);           /* cmp dword [ebp-0x6c], 0x0 */
            ii(0x100c_524f, 2); if(jz(0x100c_5296, 0x45)) goto l_0x100c_5296; /* jz 0x100c5296 */
            ii(0x100c_5251, 5); call(0x100c_ac68, 0x5a12);              /* call 0x100cac68 */
            ii(0x100c_5256, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_525b, 1); push(eax);                              /* push eax */
            ii(0x100c_525c, 3); lea(edx, ebp - 0x3c);                   /* lea edx, [ebp-0x3c] */
            ii(0x100c_525f, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x100c_5262, 5); call(0x1007_5e64, -0x4_f403);           /* call 0x10075e64 */
            ii(0x100c_5267, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100c_5269, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_526c, 5); call(Definitions.my_1_get_count, -0x1_9d99); /* call 0x100ab4d8 */
            ii(0x100c_5271, 5); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x100c_5276, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100c_5279, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100c_527c, 5); call(0x1008_a6f8, -0x3_ab89);           /* call 0x1008a6f8 */
            ii(0x100c_5281, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_5283, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x100c_5286, 5); call(0x100c_7dd0, 0x2b45);              /* call 0x100c7dd0 */
            ii(0x100c_528b, 3); mov(memd[ss, ebp - 0x74], eax);         /* mov [ebp-0x74], eax */
            ii(0x100c_528e, 3); mov(eax, memd[ss, ebp - 0x74]);         /* mov eax, [ebp-0x74] */
            ii(0x100c_5291, 3); mov(memd[ss, ebp - 0x78], eax);         /* mov [ebp-0x78], eax */
            ii(0x100c_5294, 2); jmp(0x100c_529c, 0x6); goto l_0x100c_529c; /* jmp 0x100c529c */
        l_0x100c_5296:
            ii(0x100c_5296, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x100c_5299, 3); mov(memd[ss, ebp - 0x78], eax);         /* mov [ebp-0x78], eax */
        l_0x100c_529c:
            ii(0x100c_529c, 3); mov(edx, memd[ss, ebp - 0x78]);         /* mov edx, [ebp-0x78] */
            ii(0x100c_529f, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x100c_52a2, 5); call(0x100c_a894, 0x55ed);              /* call 0x100ca894 */
            ii(0x100c_52a7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_52aa, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x100c_52ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_52af, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x100c_52b2, 5); call(0x1008_9640, -0x3_bc77);           /* call 0x10089640 */
            ii(0x100c_52b7, 5); call(0x100c_81b4, 0x2ef8);              /* call 0x100c81b4 */
            ii(0x100c_52bc, 2); test(al, al);                           /* test al, al */
            ii(0x100c_52be, 2); if(jz(0x100c_52da, 0x1a)) goto l_0x100c_52da; /* jz 0x100c52da */
            ii(0x100c_52c0, 5); call(0x100c_a9b8, 0x56f3);              /* call 0x100ca9b8 */
            ii(0x100c_52c5, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100c_52c8, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x100c_52cb, 5); call(0x100c_a864, 0x5594);              /* call 0x100ca864 */
            ii(0x100c_52d0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_52d2, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_52d5, 5); call(0x100c_a8cc, 0x55f2);              /* call 0x100ca8cc */
        l_0x100c_52da:
            ii(0x100c_52da, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_52dc, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x100c_52df, 5); call(0x1008_9600, -0x3_bce4);           /* call 0x10089600 */
        l_0x100c_52e4:
            ii(0x100c_52e4, 5); jmp(0x100c_51ec, -0xfd); goto l_0x100c_51ec; /* jmp 0x100c51ec */
        l_0x100c_52e9:
            ii(0x100c_52e9, 5); jmp(0x100c_51cd, -0x121); goto l_0x100c_51cd; /* jmp 0x100c51cd */
        l_0x100c_52ee:
            ii(0x100c_52ee, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x100c_52f3, 5); call(0x1007_5fdc, -0x4_f31c);           /* call 0x10075fdc */
            ii(0x100c_52f8, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_52fb, 7); mov(memd[ss, ebp - 0x30], 0);           /* mov dword [ebp-0x30], 0x0 */
            ii(0x100c_5302, 2); jmp(0x100c_530a, 0x6); goto l_0x100c_530a; /* jmp 0x100c530a */
        l_0x100c_5304:
            ii(0x100c_5304, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5307, 3); inc(memd[ss, ebp - 0x30]);              /* inc dword [ebp-0x30] */
        l_0x100c_530a:
            ii(0x100c_530a, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_530e, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x100c_5311, 2); if(jge(0x100c_5325, 0x12)) goto l_0x100c_5325; /* jge 0x100c5325 */
            ii(0x100c_5313, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_5317, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_5319, 10); mov(memw[ds, eax + ebp - 0x8c], 0);    /* mov word [eax+ebp-0x8c], 0x0 */
            ii(0x100c_5323, 2); jmp(0x100c_5304, -0x21); goto l_0x100c_5304; /* jmp 0x100c5304 */
        l_0x100c_5325:
            ii(0x100c_5325, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100c_5329, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100c_532c, 6); if(jl(0x100c_5480, 0x14e)) goto l_0x100c_5480; /* jl 0x100c5480 */
            ii(0x100c_5332, 10); mov(memd[ss, ebp - 0x90], 0);          /* mov dword [ebp-0x90], 0x0 */
            ii(0x100c_533c, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x100c_5343, 7); mov(memd[ss, ebp - 0x30], 0);           /* mov dword [ebp-0x30], 0x0 */
            ii(0x100c_534a, 2); jmp(0x100c_5352, 0x6); goto l_0x100c_5352; /* jmp 0x100c5352 */
        l_0x100c_534c:
            ii(0x100c_534c, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_534f, 3); inc(memd[ss, ebp - 0x30]);              /* inc dword [ebp-0x30] */
        l_0x100c_5352:
            ii(0x100c_5352, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5355, 5); call(Definitions.my_1_get_count, -0x1_9e82); /* call 0x100ab4d8 */
            ii(0x100c_535a, 4); cmp(ax, memw[ss, ebp - 0x30]);          /* cmp ax, [ebp-0x30] */
            ii(0x100c_535e, 2); if(jle(0x100c_538d, 0x2d)) goto l_0x100c_538d; /* jle 0x100c538d */
            ii(0x100c_5360, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_5364, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5367, 5); call(0x100c_a904, 0x5598);              /* call 0x100ca904 */
            ii(0x100c_536c, 5); call(0x100c_ac00, 0x588f);              /* call 0x100cac00 */
            ii(0x100c_5371, 4); cmp(ax, memw[ss, ebp - 0x20]);          /* cmp ax, [ebp-0x20] */
            ii(0x100c_5375, 2); if(jle(0x100c_538b, 0x14)) goto l_0x100c_538b; /* jle 0x100c538b */
            ii(0x100c_5377, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_537b, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_537e, 5); call(0x100c_a904, 0x5581);              /* call 0x100ca904 */
            ii(0x100c_5383, 5); call(0x100c_ac00, 0x5878);              /* call 0x100cac00 */
            ii(0x100c_5388, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x100c_538b:
            ii(0x100c_538b, 2); jmp(0x100c_534c, -0x41); goto l_0x100c_534c; /* jmp 0x100c534c */
        l_0x100c_538d:
            ii(0x100c_538d, 7); mov(memd[ss, ebp - 0x30], 0);           /* mov dword [ebp-0x30], 0x0 */
            ii(0x100c_5394, 2); jmp(0x100c_539c, 0x6); goto l_0x100c_539c; /* jmp 0x100c539c */
        l_0x100c_5396:
            ii(0x100c_5396, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5399, 3); inc(memd[ss, ebp - 0x30]);              /* inc dword [ebp-0x30] */
        l_0x100c_539c:
            ii(0x100c_539c, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_539f, 5); call(Definitions.my_1_get_count, -0x1_9ecc); /* call 0x100ab4d8 */
            ii(0x100c_53a4, 4); cmp(ax, memw[ss, ebp - 0x30]);          /* cmp ax, [ebp-0x30] */
            ii(0x100c_53a8, 2); if(jle(0x100c_5406, 0x5c)) goto l_0x100c_5406; /* jle 0x100c5406 */
            ii(0x100c_53aa, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100c_53ae, 3); cmp(eax, 0x50);                         /* cmp eax, 0x50 */
            ii(0x100c_53b1, 2); if(jle(0x100c_53ca, 0x17)) goto l_0x100c_53ca; /* jle 0x100c53ca */
            ii(0x100c_53b3, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_53b7, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_53ba, 5); call(0x100c_a904, 0x5545);              /* call 0x100ca904 */
            ii(0x100c_53bf, 5); call(0x100c_ac00, 0x583c);              /* call 0x100cac00 */
            ii(0x100c_53c4, 1); cwde();                                 /* cwde */
            ii(0x100c_53c5, 3); cmp(eax, 0x50);                         /* cmp eax, 0x50 */
            ii(0x100c_53c8, 2); if(jl(0x100c_5404, 0x3a)) goto l_0x100c_5404; /* jl 0x100c5404 */
        l_0x100c_53ca:
            ii(0x100c_53ca, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_53cd, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x100c_53d0, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100c_53d5, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_53d9, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_53dc, 5); call(0x100c_a904, 0x5523);              /* call 0x100ca904 */
            ii(0x100c_53e1, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x100c_53e3, 5); call(0x100c_81b4, 0x2dcc);              /* call 0x100c81b4 */
            ii(0x100c_53e8, 2); test(al, al);                           /* test al, al */
            ii(0x100c_53ea, 2); if(jz(0x100c_53fa, 0xe)) goto l_0x100c_53fa; /* jz 0x100c53fa */
            ii(0x100c_53ec, 6); mov(eax, memd[ss, ebp - 0x90]);         /* mov eax, [ebp-0x90] */
            ii(0x100c_53f2, 6); inc(memd[ss, ebp - 0x90]);              /* inc dword [ebp-0x90] */
            ii(0x100c_53f8, 2); jmp(0x100c_5404, 0xa); goto l_0x100c_5404; /* jmp 0x100c5404 */
        l_0x100c_53fa:
            ii(0x100c_53fa, 10); mov(memd[ss, ebp - 0x90], 0x64);       /* mov dword [ebp-0x90], 0x64 */
        l_0x100c_5404:
            ii(0x100c_5404, 2); jmp(0x100c_5396, -0x70); goto l_0x100c_5396; /* jmp 0x100c5396 */
        l_0x100c_5406:
            ii(0x100c_5406, 7); movsx(eax, memw[ss, ebp - 0x90]);       /* movsx eax, word [ebp-0x90] */
            ii(0x100c_540d, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_5410, 6); if(jnz(0x100c_5480, 0x6a)) goto l_0x100c_5480; /* jnz 0x100c5480 */
            ii(0x100c_5416, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_5419, 6); mov(memd[ss, ebp - 0x94], eax);         /* mov [ebp-0x94], eax */
            ii(0x100c_541f, 2); jmp(0x100c_5454, 0x33); goto l_0x100c_5454; /* jmp 0x100c5454 */
        l_0x100c_5421:
            ii(0x100c_5421, 6); mov(memw[ss, ebp - 0x80], 0x1);         /* mov word [ebp-0x80], 0x1 */
            ii(0x100c_5427, 2); jmp(0x100c_5480, 0x57); goto l_0x100c_5480; /* jmp 0x100c5480 */
        l_0x100c_5429:
            ii(0x100c_5429, 6); mov(memw[ss, ebp - 0x80], 0x6);         /* mov word [ebp-0x80], 0x6 */
            ii(0x100c_542f, 2); jmp(0x100c_5480, 0x4f); goto l_0x100c_5480; /* jmp 0x100c5480 */
        l_0x100c_5431:
            ii(0x100c_5431, 6); mov(memw[ss, ebp - 0x80], 0xc);         /* mov word [ebp-0x80], 0xc */
            ii(0x100c_5437, 2); jmp(0x100c_5480, 0x47); goto l_0x100c_5480; /* jmp 0x100c5480 */
        l_0x100c_5439:
            ii(0x100c_5439, 6); mov(memw[ss, ebp - 0x80], 0x18);        /* mov word [ebp-0x80], 0x18 */
            ii(0x100c_543f, 2); jmp(0x100c_5480, 0x3f); goto l_0x100c_5480; /* jmp 0x100c5480 */
        l_0x100c_5441:
            ii(0x100c_5441, 2); jmp(0x100c_5480, 0x3d); goto l_0x100c_5480; /* jmp 0x100c5480 */
        //  ii(0x100c_5443, 1); nop();                                  /* nop */
        //  ii(0x100c_5444, 16); /* Служебная область с абсолютными адресами переходов. (0x100c_5421, 0x100c_5429, 0x100c_5431, 0x100c_5439). */
        l_0x100c_5454:
            ii(0x100c_5454, 6); mov(eax, memd[ss, ebp - 0x94]);         /* mov eax, [ebp-0x94] */
            ii(0x100c_545a, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x100c_545d, 6); mov(memd[ss, ebp - 0x98], eax);         /* mov [ebp-0x98], eax */
            ii(0x100c_5463, 8); cmp(memw[ss, ebp - 0x98], 0x3);         /* cmp word [ebp-0x98], 0x3 */
            ii(0x100c_546b, 2); if(ja(0x100c_5441, -0x2c)) goto l_0x100c_5441; /* ja 0x100c5441 */
            ii(0x100c_546d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_546f, 7); mov(ax, memw[ss, ebp - 0x98]);          /* mov ax, [ebp-0x98] */
            ii(0x100c_5476, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_5479, 7); 
            switch (jmp_abs_switch(memd[cs, eax + 0x100c_5444]))
            {
                case 0x100c_5421:
                    goto l_0x100c_5421;
                case 0x100c_5429:
                    goto l_0x100c_5429;
                case 0x100c_5431:
                    goto l_0x100c_5431;
                case 0x100c_5439:
                    goto l_0x100c_5439;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x100c5444] */
        l_0x100c_5480:
            ii(0x100c_5480, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x100c_5487, 7); mov(memd[ss, ebp - 0x30], 0);           /* mov dword [ebp-0x30], 0x0 */
            ii(0x100c_548e, 2); jmp(0x100c_5496, 0x6); goto l_0x100c_5496; /* jmp 0x100c5496 */
        l_0x100c_5490:
            ii(0x100c_5490, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5493, 3); inc(memd[ss, ebp - 0x30]);              /* inc dword [ebp-0x30] */
        l_0x100c_5496:
            ii(0x100c_5496, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5499, 5); call(Definitions.my_1_get_count, -0x1_9fc6); /* call 0x100ab4d8 */
            ii(0x100c_549e, 4); cmp(ax, memw[ss, ebp - 0x30]);          /* cmp ax, [ebp-0x30] */
            ii(0x100c_54a2, 2); if(jle(0x100c_54b7, 0x13)) goto l_0x100c_54b7; /* jle 0x100c54b7 */
            ii(0x100c_54a4, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_54a8, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_54ab, 5); call(0x100c_a904, 0x5454);              /* call 0x100ca904 */
            ii(0x100c_54b0, 5); call(0x100c_83dd, 0x2f28);              /* call 0x100c83dd */
            ii(0x100c_54b5, 2); jmp(0x100c_5490, -0x27); goto l_0x100c_5490; /* jmp 0x100c5490 */
        l_0x100c_54b7:
            ii(0x100c_54b7, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_54ba, 5); call(Definitions.my_1_get_count, -0x1_9fe7); /* call 0x100ab4d8 */
            ii(0x100c_54bf, 1); dec(eax);                               /* dec eax */
            ii(0x100c_54c0, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100c_54c3, 2); jmp(0x100c_54cb, 0x6); goto l_0x100c_54cb; /* jmp 0x100c54cb */
        l_0x100c_54c5:
            ii(0x100c_54c5, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_54c8, 3); dec(memd[ss, ebp - 0x30]);              /* dec dword [ebp-0x30] */
        l_0x100c_54cb:
            ii(0x100c_54cb, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_54cf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_54d1, 2); if(jl(0x100c_5530, 0x5d)) goto l_0x100c_5530; /* jl 0x100c5530 */
            ii(0x100c_54d3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_54d6, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x100c_54d9, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100c_54de, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_54e2, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_54e5, 5); call(0x100c_a904, 0x541a);              /* call 0x100ca904 */
            ii(0x100c_54ea, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x100c_54ec, 5); call(0x100c_81b4, 0x2cc3);              /* call 0x100c81b4 */
            ii(0x100c_54f1, 2); test(al, al);                           /* test al, al */
            ii(0x100c_54f3, 2); if(jnz(0x100c_5503, 0xe)) goto l_0x100c_5503; /* jnz 0x100c5503 */
            ii(0x100c_54f5, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_54f9, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_54fc, 5); call(0x1013_b24f, 0x7_5d4e);            /* call 0x1013b24f */
            ii(0x100c_5501, 2); jmp(0x100c_552e, 0x2b); goto l_0x100c_552e; /* jmp 0x100c552e */
        l_0x100c_5503:
            ii(0x100c_5503, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_5507, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_550a, 5); call(0x100c_a904, 0x53f5);              /* call 0x100ca904 */
            ii(0x100c_550f, 5); call(0x100c_ac00, 0x56ec);              /* call 0x100cac00 */
            ii(0x100c_5514, 4); cmp(ax, memw[ss, ebp - 0x20]);          /* cmp ax, [ebp-0x20] */
            ii(0x100c_5518, 2); if(jle(0x100c_552e, 0x14)) goto l_0x100c_552e; /* jle 0x100c552e */
            ii(0x100c_551a, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_551e, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5521, 5); call(0x100c_a904, 0x53de);              /* call 0x100ca904 */
            ii(0x100c_5526, 5); call(0x100c_ac00, 0x56d5);              /* call 0x100cac00 */
            ii(0x100c_552b, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x100c_552e:
            ii(0x100c_552e, 2); jmp(0x100c_54c5, -0x6b); goto l_0x100c_54c5; /* jmp 0x100c54c5 */
        l_0x100c_5530:
            ii(0x100c_5530, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100c_5534, 3); cmp(eax, 0x50);                         /* cmp eax, 0x50 */
            ii(0x100c_5537, 2); if(jle(0x100c_557a, 0x41)) goto l_0x100c_557a; /* jle 0x100c557a */
            ii(0x100c_5539, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_553c, 5); call(Definitions.my_1_get_count, -0x1_a069); /* call 0x100ab4d8 */
            ii(0x100c_5541, 1); dec(eax);                               /* dec eax */
            ii(0x100c_5542, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100c_5545, 2); jmp(0x100c_554d, 0x6); goto l_0x100c_554d; /* jmp 0x100c554d */
        l_0x100c_5547:
            ii(0x100c_5547, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_554a, 3); dec(memd[ss, ebp - 0x30]);              /* dec dword [ebp-0x30] */
        l_0x100c_554d:
            ii(0x100c_554d, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_5551, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_5553, 2); if(jl(0x100c_557a, 0x25)) goto l_0x100c_557a; /* jl 0x100c557a */
            ii(0x100c_5555, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_5559, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_555c, 5); call(0x100c_a904, 0x53a3);              /* call 0x100ca904 */
            ii(0x100c_5561, 5); call(0x100c_ac00, 0x569a);              /* call 0x100cac00 */
            ii(0x100c_5566, 1); cwde();                                 /* cwde */
            ii(0x100c_5567, 3); cmp(eax, 0x50);                         /* cmp eax, 0x50 */
            ii(0x100c_556a, 2); if(jge(0x100c_5578, 0xc)) goto l_0x100c_5578; /* jge 0x100c5578 */
            ii(0x100c_556c, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_5570, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5573, 5); call(0x1013_b24f, 0x7_5cd7);            /* call 0x1013b24f */
        l_0x100c_5578:
            ii(0x100c_5578, 2); jmp(0x100c_5547, -0x33); goto l_0x100c_5547; /* jmp 0x100c5547 */
        l_0x100c_557a:
            ii(0x100c_557a, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100c_5581, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100c_5588, 7); mov(memd[ss, ebp - 0x30], 0);           /* mov dword [ebp-0x30], 0x0 */
            ii(0x100c_558f, 2); jmp(0x100c_5597, 0x6); goto l_0x100c_5597; /* jmp 0x100c5597 */
        l_0x100c_5591:
            ii(0x100c_5591, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5594, 3); inc(memd[ss, ebp - 0x30]);              /* inc dword [ebp-0x30] */
        l_0x100c_5597:
            ii(0x100c_5597, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_559a, 5); call(Definitions.my_1_get_count, -0x1_a0c7); /* call 0x100ab4d8 */
            ii(0x100c_559f, 4); cmp(ax, memw[ss, ebp - 0x30]);          /* cmp ax, [ebp-0x30] */
            ii(0x100c_55a3, 2); if(jle(0x100c_55dd, 0x38)) goto l_0x100c_55dd; /* jle 0x100c55dd */
            ii(0x100c_55a5, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_55a9, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_55ac, 5); call(0x100c_a904, 0x5353);              /* call 0x100ca904 */
            ii(0x100c_55b1, 5); call(0x100c_abd0, 0x561a);              /* call 0x100cabd0 */
            ii(0x100c_55b6, 2); test(al, al);                           /* test al, al */
            ii(0x100c_55b8, 2); if(jz(0x100c_55c0, 0x6)) goto l_0x100c_55c0; /* jz 0x100c55c0 */
            ii(0x100c_55ba, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_55bd, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x100c_55c0:
            ii(0x100c_55c0, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_55c4, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_55c7, 5); call(0x100c_a904, 0x5338);              /* call 0x100ca904 */
            ii(0x100c_55cc, 5); call(0x100c_8369, 0x2d98);              /* call 0x100c8369 */
            ii(0x100c_55d1, 2); test(al, al);                           /* test al, al */
            ii(0x100c_55d3, 2); if(jz(0x100c_55db, 0x6)) goto l_0x100c_55db; /* jz 0x100c55db */
            ii(0x100c_55d5, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_55d8, 3); inc(memd[ss, ebp - 0x1c]);              /* inc dword [ebp-0x1c] */
        l_0x100c_55db:
            ii(0x100c_55db, 2); jmp(0x100c_5591, -0x4c); goto l_0x100c_5591; /* jmp 0x100c5591 */
        l_0x100c_55dd:
            ii(0x100c_55dd, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_55e0, 5); call(Definitions.my_1_get_count, -0x1_a10d); /* call 0x100ab4d8 */
            ii(0x100c_55e5, 7); mov(memw[ss, ebp - 0x88], ax);          /* mov [ebp-0x88], ax */
            ii(0x100c_55ec, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100c_55f0, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_55f3, 2); if(jl(0x100c_5604, 0xf)) goto l_0x100c_5604; /* jl 0x100c5604 */
            ii(0x100c_55f5, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_55f8, 5); call(Definitions.my_1_get_count, -0x1_a125); /* call 0x100ab4d8 */
            ii(0x100c_55fd, 7); mov(memw[ss, ebp - 0x8a], ax);          /* mov [ebp-0x8a], ax */
        l_0x100c_5604:
            ii(0x100c_5604, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100c_5608, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100c_560b, 2); if(jl(0x100c_5615, 0x8)) goto l_0x100c_5615; /* jl 0x100c5615 */
            ii(0x100c_560d, 4); movsx(eax, memw[ss, ebp - 0x80]);       /* movsx eax, word [ebp-0x80] */
            ii(0x100c_5611, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_5613, 2); if(jz(0x100c_5617, 0x2)) goto l_0x100c_5617; /* jz 0x100c5617 */
        l_0x100c_5615:
            ii(0x100c_5615, 2); jmp(0x100c_5659, 0x42); goto l_0x100c_5659; /* jmp 0x100c5659 */
        l_0x100c_5617:
            ii(0x100c_5617, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100c_561b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_561d, 2); if(jle(0x100c_562a, 0xb)) goto l_0x100c_562a; /* jle 0x100c562a */
            ii(0x100c_561f, 9); mov(memw[ss, ebp - 0x82], 0x1);         /* mov word [ebp-0x82], 0x1 */
            ii(0x100c_5628, 2); jmp(0x100c_5639, 0xf); goto l_0x100c_5639; /* jmp 0x100c5639 */
        l_0x100c_562a:
            ii(0x100c_562a, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_562d, 5); call(Definitions.my_1_get_count, -0x1_a15a); /* call 0x100ab4d8 */
            ii(0x100c_5632, 7); mov(memw[ss, ebp - 0x82], ax);          /* mov [ebp-0x82], ax */
        l_0x100c_5639:
            ii(0x100c_5639, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100c_563d, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100c_5640, 2); if(jl(0x100c_5649, 0x7)) goto l_0x100c_5649; /* jl 0x100c5649 */
            ii(0x100c_5642, 7); shl(memw[ss, ebp - 0x82], 0x1);         /* shl word [ebp-0x82], 1 */
        l_0x100c_5649:
            ii(0x100c_5649, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100c_564d, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x100c_5650, 2); if(jl(0x100c_5659, 0x7)) goto l_0x100c_5659; /* jl 0x100c5659 */
            ii(0x100c_5652, 7); shl(memw[ss, ebp - 0x82], 0x1);         /* shl word [ebp-0x82], 1 */
        l_0x100c_5659:
            ii(0x100c_5659, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_565c, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_565e, 7); mov(memw[ss, ebp - 0x86], ax);          /* mov [ebp-0x86], ax */
            ii(0x100c_5665, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x100c_566a, 5); call(0x1007_5fdc, -0x4_f693);           /* call 0x10075fdc */
            ii(0x100c_566f, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100c_5672, 2); if(jl(0x100c_5680, 0xc)) goto l_0x100c_5680; /* jl 0x100c5680 */
            ii(0x100c_5674, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5677, 5); call(Definitions.my_1_get_count, -0x1_a1a4); /* call 0x100ab4d8 */
            ii(0x100c_567c, 4); mov(memw[ss, ebp - 0x7a], ax);          /* mov [ebp-0x7a], ax */
        l_0x100c_5680:
            ii(0x100c_5680, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_5683, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_5685, 7); mov(memw[ss, ebp - 0x84], ax);          /* mov [ebp-0x84], ax */
            ii(0x100c_568c, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_568f, 5); call(Definitions.my_1_get_count, -0x1_a1bc); /* call 0x100ab4d8 */
            ii(0x100c_5694, 3); sub(eax, memd[ss, ebp - 0x1c]);         /* sub eax, [ebp-0x1c] */
            ii(0x100c_5697, 4); mov(memw[ss, ebp - 0x7e], ax);          /* mov [ebp-0x7e], ax */
            ii(0x100c_569b, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_569e, 5); call(Definitions.my_1_get_count, -0x1_a1cb); /* call 0x100ab4d8 */
            ii(0x100c_56a3, 3); sub(eax, memd[ss, ebp - 0x1c]);         /* sub eax, [ebp-0x1c] */
            ii(0x100c_56a6, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_56a8, 4); mov(memw[ss, ebp - 0x7c], ax);          /* mov [ebp-0x7c], ax */
            ii(0x100c_56ac, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_56af, 4); mov(memb[ds, eax + 0x2], 0);            /* mov byte [eax+0x2], 0x0 */
            ii(0x100c_56b3, 5); mov(ecx, 0x4f);                         /* mov ecx, 0x4f */
            ii(0x100c_56b8, 6); lea(ebx, ebp - 0xe8);                   /* lea ebx, [ebp-0xe8] */
            ii(0x100c_56be, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_56c1, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100c_56c3, 2); add(al, 0x2d);                          /* add al, 0x2d */
            ii(0x100c_56c5, 3); movsx(edx, al);                         /* movsx edx, al */
            ii(0x100c_56c8, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x100c_56cd, 5); call(0x1010_6281, 0x4_0baf);            /* call 0x10106281 */
            ii(0x100c_56d2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_56d4, 2); if(jz(0x100c_573a, 0x64)) goto l_0x100c_573a; /* jz 0x100c573a */
            ii(0x100c_56d6, 7); mov(memd[ss, ebp - 0x30], 0x9);         /* mov dword [ebp-0x30], 0x9 */
        l_0x100c_56dd:
            ii(0x100c_56dd, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_56e1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_56e3, 2); if(jl(0x100c_5701, 0x1c)) goto l_0x100c_5701; /* jl 0x100c5701 */
            ii(0x100c_56e5, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_56e9, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100c_56ec, 6); mov(edx, memd[ds, edx + 0x101b_77ec]);  /* mov edx, [edx+0x101b77ec] */
            ii(0x100c_56f2, 6); lea(eax, ebp - 0xe8);                   /* lea eax, [ebp-0xe8] */
            ii(0x100c_56f8, 5); call(Definitions.sys_strcasecmp, 0xa_0a33); /* call 0x10166130 */
            ii(0x100c_56fd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_56ff, 2); if(jnz(0x100c_5703, 0x2)) goto l_0x100c_5703; /* jnz 0x100c5703 */
        l_0x100c_5701:
            ii(0x100c_5701, 2); jmp(0x100c_570b, 0x8); goto l_0x100c_570b; /* jmp 0x100c570b */
        l_0x100c_5703:
            ii(0x100c_5703, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5706, 3); dec(memd[ss, ebp - 0x30]);              /* dec dword [ebp-0x30] */
            ii(0x100c_5709, 2); jmp(0x100c_56dd, -0x2e); goto l_0x100c_56dd; /* jmp 0x100c56dd */
        l_0x100c_570b:
            ii(0x100c_570b, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_570f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_5711, 2); if(jl(0x100c_573a, 0x27)) goto l_0x100c_573a; /* jl 0x100c573a */
            ii(0x100c_5713, 3); mov(al, memb[ss, ebp - 0x30]);          /* mov al, [ebp-0x30] */
            ii(0x100c_5716, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_5719, 3); mov(memb[ds, edx + 0x2], al);           /* mov [edx+0x2], al */
            ii(0x100c_571c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_571f, 4); movsx(eax, memb[ds, eax + 0x2]);        /* movsx eax, byte [eax+0x2] */
            ii(0x100c_5723, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_5725, 7); mov(eax, memd[ds, eax + ebp - 0x8e]);   /* mov eax, [eax+ebp-0x8e] */
            ii(0x100c_572c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_572f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_5731, 2); if(jg(0x100c_573a, 0x7)) goto l_0x100c_573a; /* jg 0x100c573a */
            ii(0x100c_5733, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5736, 4); mov(memb[ds, eax + 0x2], 0);            /* mov byte [eax+0x2], 0x0 */
        l_0x100c_573a:
            ii(0x100c_573a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_573d, 4); cmp(memb[ds, eax + 0x2], 0);            /* cmp byte [eax+0x2], 0x0 */
            ii(0x100c_5741, 6); if(jnz(0x100c_592f, 0x1e8)) goto l_0x100c_592f; /* jnz 0x100c592f */
            ii(0x100c_5747, 10); mov(memd[ss, ebp - 0xec], 0);          /* mov dword [ebp-0xec], 0x0 */
            ii(0x100c_5751, 10); mov(memd[ss, ebp - 0xf0], 0);          /* mov dword [ebp-0xf0], 0x0 */
            ii(0x100c_575b, 6); mov(memw[ss, ebp - 0x30], 0);           /* mov word [ebp-0x30], 0x0 */
            ii(0x100c_5761, 2); jmp(0x100c_576a, 0x7); goto l_0x100c_576a; /* jmp 0x100c576a */
        l_0x100c_5763:
            ii(0x100c_5763, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5766, 4); inc(memw[ss, ebp - 0x30]);              /* inc word [ebp-0x30] */
        l_0x100c_576a:
            ii(0x100c_576a, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_576e, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x100c_5771, 2); if(jge(0x100c_5795, 0x22)) goto l_0x100c_5795; /* jge 0x100c5795 */
            ii(0x100c_5773, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_5777, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_5779, 7); mov(eax, memd[ds, eax + ebp - 0x8e]);   /* mov eax, [eax+ebp-0x8e] */
            ii(0x100c_5780, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_5783, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_5785, 2); if(jle(0x100c_5793, 0xc)) goto l_0x100c_5793; /* jle 0x100c5793 */
            ii(0x100c_5787, 6); mov(eax, memd[ss, ebp - 0xf0]);         /* mov eax, [ebp-0xf0] */
            ii(0x100c_578d, 6); inc(memd[ss, ebp - 0xf0]);              /* inc dword [ebp-0xf0] */
        l_0x100c_5793:
            ii(0x100c_5793, 2); jmp(0x100c_5763, -0x32); goto l_0x100c_5763; /* jmp 0x100c5763 */
        l_0x100c_5795:
            ii(0x100c_5795, 6); mov(memw[ss, ebp - 0x30], 0);           /* mov word [ebp-0x30], 0x0 */
            ii(0x100c_579b, 2); jmp(0x100c_57a4, 0x7); goto l_0x100c_57a4; /* jmp 0x100c57a4 */
        l_0x100c_579d:
            ii(0x100c_579d, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_57a0, 4); inc(memw[ss, ebp - 0x30]);              /* inc word [ebp-0x30] */
        l_0x100c_57a4:
            ii(0x100c_57a4, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_57a8, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100c_57ab, 2); if(jge(0x100c_57fe, 0x51)) goto l_0x100c_57fe; /* jge 0x100c57fe */
            ii(0x100c_57ad, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_57b1, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_57b7, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100c_57bd, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_57c2, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100c_57c5, 2); if(jnz(0x100c_57d2, 0xb)) goto l_0x100c_57d2; /* jnz 0x100c57d2 */
            ii(0x100c_57c7, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_57ca, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_57cd, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x100c_57d0, 2); if(jnz(0x100c_57d4, 0x2)) goto l_0x100c_57d4; /* jnz 0x100c57d4 */
        l_0x100c_57d2:
            ii(0x100c_57d2, 2); jmp(0x100c_57ee, 0x1a); goto l_0x100c_57ee; /* jmp 0x100c57ee */
        l_0x100c_57d4:
            ii(0x100c_57d4, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_57d8, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100c_57de, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x100c_57e3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_57e5, 5); call(0x1008_a064, -0x3_b786);           /* call 0x1008a064 */
            ii(0x100c_57ea, 2); test(al, al);                           /* test al, al */
            ii(0x100c_57ec, 2); if(jnz(0x100c_57f0, 0x2)) goto l_0x100c_57f0; /* jnz 0x100c57f0 */
        l_0x100c_57ee:
            ii(0x100c_57ee, 2); jmp(0x100c_57fc, 0xc); goto l_0x100c_57fc; /* jmp 0x100c57fc */
        l_0x100c_57f0:
            ii(0x100c_57f0, 6); mov(eax, memd[ss, ebp - 0xf0]);         /* mov eax, [ebp-0xf0] */
            ii(0x100c_57f6, 6); dec(memd[ss, ebp - 0xf0]);              /* dec dword [ebp-0xf0] */
        l_0x100c_57fc:
            ii(0x100c_57fc, 2); jmp(0x100c_579d, -0x61); goto l_0x100c_579d; /* jmp 0x100c579d */
        l_0x100c_57fe:
            ii(0x100c_57fe, 7); movsx(eax, memw[ss, ebp - 0xf0]);       /* movsx eax, word [ebp-0xf0] */
            ii(0x100c_5805, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_5807, 6); if(jle(0x100c_5893, 0x86)) goto l_0x100c_5893; /* jle 0x100c5893 */
            ii(0x100c_580d, 6); mov(memw[ss, ebp - 0x30], 0);           /* mov word [ebp-0x30], 0x0 */
            ii(0x100c_5813, 2); jmp(0x100c_581c, 0x7); goto l_0x100c_581c; /* jmp 0x100c581c */
        l_0x100c_5815:
            ii(0x100c_5815, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5818, 4); inc(memw[ss, ebp - 0x30]);              /* inc word [ebp-0x30] */
        l_0x100c_581c:
            ii(0x100c_581c, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_5820, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100c_5823, 6); if(jge(0x100c_5893, 0x6a)) goto l_0x100c_5893; /* jge 0x100c5893 */
            ii(0x100c_5829, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_582d, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_5833, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100c_5839, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_583e, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100c_5841, 2); if(jnz(0x100c_584e, 0xb)) goto l_0x100c_584e; /* jnz 0x100c584e */
            ii(0x100c_5843, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5846, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_5849, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x100c_584c, 2); if(jnz(0x100c_5850, 0x2)) goto l_0x100c_5850; /* jnz 0x100c5850 */
        l_0x100c_584e:
            ii(0x100c_584e, 2); jmp(0x100c_586a, 0x1a); goto l_0x100c_586a; /* jmp 0x100c586a */
        l_0x100c_5850:
            ii(0x100c_5850, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_5854, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100c_585a, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x100c_585f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_5861, 5); call(0x1008_a064, -0x3_b802);           /* call 0x1008a064 */
            ii(0x100c_5866, 2); test(al, al);                           /* test al, al */
            ii(0x100c_5868, 2); if(jnz(0x100c_586c, 0x2)) goto l_0x100c_586c; /* jnz 0x100c586c */
        l_0x100c_586a:
            ii(0x100c_586a, 2); jmp(0x100c_5891, 0x25); goto l_0x100c_5891; /* jmp 0x100c5891 */
        l_0x100c_586c:
            ii(0x100c_586c, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_5870, 6); imul(edx, edx, 0xc5);                   /* imul edx, edx, 0xc5 */
            ii(0x100c_5876, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x100c_587b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_587d, 5); call(0x1008_a064, -0x3_b81e);           /* call 0x1008a064 */
            ii(0x100c_5882, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x100c_5885, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_5887, 10); mov(memw[ds, eax + ebp - 0x8c], 0);    /* mov word [eax+ebp-0x8c], 0x0 */
        l_0x100c_5891:
            ii(0x100c_5891, 2); jmp(0x100c_5815, -0x7e); goto l_0x100c_5815; /* jmp 0x100c5815 */
        l_0x100c_5893:
            ii(0x100c_5893, 6); mov(memw[ss, ebp - 0x30], 0);           /* mov word [ebp-0x30], 0x0 */
            ii(0x100c_5899, 2); jmp(0x100c_58a2, 0x7); goto l_0x100c_58a2; /* jmp 0x100c58a2 */
        l_0x100c_589b:
            ii(0x100c_589b, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_589e, 4); inc(memw[ss, ebp - 0x30]);              /* inc word [ebp-0x30] */
        l_0x100c_58a2:
            ii(0x100c_58a2, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_58a6, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x100c_58a9, 2); if(jge(0x100c_58e1, 0x36)) goto l_0x100c_58e1; /* jge 0x100c58e1 */
            ii(0x100c_58ab, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_58af, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_58b1, 8); mov(ax, memw[ds, eax + ebp - 0x8c]);    /* mov ax, [eax+ebp-0x8c] */
            ii(0x100c_58b9, 6); add(memd[ss, ebp - 0xec], eax);         /* add [ebp-0xec], eax */
            ii(0x100c_58bf, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_58c3, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_58c5, 7); mov(eax, memd[ds, eax + ebp - 0x8e]);   /* mov eax, [eax+ebp-0x8e] */
            ii(0x100c_58cc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_58cf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_58d1, 2); if(jle(0x100c_58df, 0xc)) goto l_0x100c_58df; /* jle 0x100c58df */
            ii(0x100c_58d3, 6); mov(eax, memd[ss, ebp - 0xf0]);         /* mov eax, [ebp-0xf0] */
            ii(0x100c_58d9, 6); inc(memd[ss, ebp - 0xf0]);              /* inc dword [ebp-0xf0] */
        l_0x100c_58df:
            ii(0x100c_58df, 2); jmp(0x100c_589b, -0x46); goto l_0x100c_589b; /* jmp 0x100c589b */
        l_0x100c_58e1:
            ii(0x100c_58e1, 7); movsx(edx, memw[ss, ebp - 0xec]);       /* movsx edx, word [ebp-0xec] */
            ii(0x100c_58e8, 5); call(/* sys */ 0x1016_5e9b, 0xa_05ae);  /* call 0x10165e9b */
            ii(0x100c_58ed, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100c_58f0, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100c_58f3, 1); inc(eax);                               /* inc eax */
            ii(0x100c_58f4, 6); mov(memd[ss, ebp - 0xec], eax);         /* mov [ebp-0xec], eax */
            ii(0x100c_58fa, 6); mov(memw[ss, ebp - 0x30], 0xffff);      /* mov word [ebp-0x30], 0xffff */
        l_0x100c_5900:
            ii(0x100c_5900, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5903, 4); inc(memw[ss, ebp - 0x30]);              /* inc word [ebp-0x30] */
            ii(0x100c_5907, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_590b, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_590d, 8); mov(ax, memw[ds, eax + ebp - 0x8c]);    /* mov ax, [eax+ebp-0x8c] */
            ii(0x100c_5915, 6); sub(memd[ss, ebp - 0xec], eax);         /* sub [ebp-0xec], eax */
            ii(0x100c_591b, 7); movsx(eax, memw[ss, ebp - 0xec]);       /* movsx eax, word [ebp-0xec] */
            ii(0x100c_5922, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_5924, 2); if(jg(0x100c_5900, -0x26)) goto l_0x100c_5900; /* jg 0x100c5900 */
            ii(0x100c_5926, 3); mov(al, memb[ss, ebp - 0x30]);          /* mov al, [ebp-0x30] */
            ii(0x100c_5929, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_592c, 3); mov(memb[ds, edx + 0x2], al);           /* mov [edx+0x2], al */
        l_0x100c_592f:
            ii(0x100c_592f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5932, 3); mov(al, memb[ds, eax + 0x2]);           /* mov al, [eax+0x2] */
            ii(0x100c_5935, 6); mov(memb[ss, ebp - 0xf4], al);          /* mov [ebp-0xf4], al */
            ii(0x100c_593b, 5); jmp(0x100c_5a11, 0xd1); goto l_0x100c_5a11; /* jmp 0x100c5a11 */
        l_0x100c_5940:
            ii(0x100c_5940, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5943, 5); call(Definitions.my_1_get_count, -0x1_a470); /* call 0x100ab4d8 */
            ii(0x100c_5948, 1); dec(eax);                               /* dec eax */
            ii(0x100c_5949, 4); mov(memw[ss, ebp - 0x30], ax);          /* mov [ebp-0x30], ax */
            ii(0x100c_594d, 2); jmp(0x100c_5956, 0x7); goto l_0x100c_5956; /* jmp 0x100c5956 */
        l_0x100c_594f:
            ii(0x100c_594f, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5952, 4); dec(memw[ss, ebp - 0x30]);              /* dec word [ebp-0x30] */
        l_0x100c_5956:
            ii(0x100c_5956, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_595a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_595c, 2); if(jl(0x100c_5981, 0x23)) goto l_0x100c_5981; /* jl 0x100c5981 */
            ii(0x100c_595e, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_5962, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5965, 5); call(0x100c_a904, 0x4f9a);              /* call 0x100ca904 */
            ii(0x100c_596a, 5); call(0x100c_abd0, 0x5261);              /* call 0x100cabd0 */
            ii(0x100c_596f, 2); test(al, al);                           /* test al, al */
            ii(0x100c_5971, 2); if(jnz(0x100c_597f, 0xc)) goto l_0x100c_597f; /* jnz 0x100c597f */
            ii(0x100c_5973, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_5977, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_597a, 5); call(0x1013_b24f, 0x7_58d0);            /* call 0x1013b24f */
        l_0x100c_597f:
            ii(0x100c_597f, 2); jmp(0x100c_594f, -0x32); goto l_0x100c_594f; /* jmp 0x100c594f */
        l_0x100c_5981:
            ii(0x100c_5981, 5); jmp(0x100c_5a58, 0xd2); goto l_0x100c_5a58; /* jmp 0x100c5a58 */
        l_0x100c_5986:
            ii(0x100c_5986, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5989, 5); call(Definitions.my_1_get_count, -0x1_a4b6); /* call 0x100ab4d8 */
            ii(0x100c_598e, 1); dec(eax);                               /* dec eax */
            ii(0x100c_598f, 4); mov(memw[ss, ebp - 0x30], ax);          /* mov [ebp-0x30], ax */
            ii(0x100c_5993, 2); jmp(0x100c_599c, 0x7); goto l_0x100c_599c; /* jmp 0x100c599c */
        l_0x100c_5995:
            ii(0x100c_5995, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5998, 4); dec(memw[ss, ebp - 0x30]);              /* dec word [ebp-0x30] */
        l_0x100c_599c:
            ii(0x100c_599c, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_59a0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_59a2, 2); if(jl(0x100c_59c7, 0x23)) goto l_0x100c_59c7; /* jl 0x100c59c7 */
            ii(0x100c_59a4, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_59a8, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_59ab, 5); call(0x100c_a904, 0x4f54);              /* call 0x100ca904 */
            ii(0x100c_59b0, 5); call(0x100c_8369, 0x29b4);              /* call 0x100c8369 */
            ii(0x100c_59b5, 2); test(al, al);                           /* test al, al */
            ii(0x100c_59b7, 2); if(jnz(0x100c_59c5, 0xc)) goto l_0x100c_59c5; /* jnz 0x100c59c5 */
            ii(0x100c_59b9, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_59bd, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_59c0, 5); call(0x1013_b24f, 0x7_588a);            /* call 0x1013b24f */
        l_0x100c_59c5:
            ii(0x100c_59c5, 2); jmp(0x100c_5995, -0x32); goto l_0x100c_5995; /* jmp 0x100c5995 */
        l_0x100c_59c7:
            ii(0x100c_59c7, 5); jmp(0x100c_5a58, 0x8c); goto l_0x100c_5a58; /* jmp 0x100c5a58 */
        l_0x100c_59cc:
            ii(0x100c_59cc, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_59cf, 5); call(Definitions.my_1_get_count, -0x1_a4fc); /* call 0x100ab4d8 */
            ii(0x100c_59d4, 1); dec(eax);                               /* dec eax */
            ii(0x100c_59d5, 4); mov(memw[ss, ebp - 0x30], ax);          /* mov [ebp-0x30], ax */
            ii(0x100c_59d9, 2); jmp(0x100c_59e2, 0x7); goto l_0x100c_59e2; /* jmp 0x100c59e2 */
        l_0x100c_59db:
            ii(0x100c_59db, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_59de, 4); dec(memw[ss, ebp - 0x30]);              /* dec word [ebp-0x30] */
        l_0x100c_59e2:
            ii(0x100c_59e2, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_59e6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_59e8, 2); if(jl(0x100c_5a0d, 0x23)) goto l_0x100c_5a0d; /* jl 0x100c5a0d */
            ii(0x100c_59ea, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_59ee, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_59f1, 5); call(0x100c_a904, 0x4f0e);              /* call 0x100ca904 */
            ii(0x100c_59f6, 5); call(0x100c_8369, 0x296e);              /* call 0x100c8369 */
            ii(0x100c_59fb, 2); test(al, al);                           /* test al, al */
            ii(0x100c_59fd, 2); if(jz(0x100c_5a0b, 0xc)) goto l_0x100c_5a0b; /* jz 0x100c5a0b */
            ii(0x100c_59ff, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_5a03, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5a06, 5); call(0x1013_b24f, 0x7_5844);            /* call 0x1013b24f */
        l_0x100c_5a0b:
            ii(0x100c_5a0b, 2); jmp(0x100c_59db, -0x32); goto l_0x100c_59db; /* jmp 0x100c59db */
        l_0x100c_5a0d:
            ii(0x100c_5a0d, 2); jmp(0x100c_5a58, 0x49); goto l_0x100c_5a58; /* jmp 0x100c5a58 */
        l_0x100c_5a0f:
            ii(0x100c_5a0f, 2); jmp(0x100c_5a58, 0x47); goto l_0x100c_5a58; /* jmp 0x100c5a58 */
        l_0x100c_5a11:
            ii(0x100c_5a11, 6); mov(al, memb[ss, ebp - 0xf4]);          /* mov al, [ebp-0xf4] */
            ii(0x100c_5a17, 6); mov(memb[ss, ebp - 0xf8], al);          /* mov [ebp-0xf8], al */
            ii(0x100c_5a1d, 7); cmp(memb[ss, ebp - 0xf8], 0x4);         /* cmp byte [ebp-0xf8], 0x4 */
            ii(0x100c_5a24, 2); if(jb(0x100c_5a49, 0x23)) goto l_0x100c_5a49; /* jb 0x100c5a49 */
            ii(0x100c_5a26, 7); cmp(memb[ss, ebp - 0xf8], 0x4);         /* cmp byte [ebp-0xf8], 0x4 */
            ii(0x100c_5a2d, 6); if(jbe(0x100c_5940, -0xf3)) goto l_0x100c_5940; /* jbe 0x100c5940 */
            ii(0x100c_5a33, 7); cmp(memb[ss, ebp - 0xf8], 0x7);         /* cmp byte [ebp-0xf8], 0x7 */
            ii(0x100c_5a3a, 2); if(jb(0x100c_5a47, 0xb)) goto l_0x100c_5a47; /* jb 0x100c5a47 */
            ii(0x100c_5a3c, 7); cmp(memb[ss, ebp - 0xf8], 0x8);         /* cmp byte [ebp-0xf8], 0x8 */
            ii(0x100c_5a43, 2); if(jbe(0x100c_59cc, -0x79)) goto l_0x100c_59cc; /* jbe 0x100c59cc */
            ii(0x100c_5a45, 2); jmp(0x100c_5a0f, -0x38); goto l_0x100c_5a0f; /* jmp 0x100c5a0f */
        l_0x100c_5a47:
            ii(0x100c_5a47, 2); jmp(0x100c_5a0f, -0x3a); goto l_0x100c_5a0f; /* jmp 0x100c5a0f */
        l_0x100c_5a49:
            ii(0x100c_5a49, 7); cmp(memb[ss, ebp - 0xf8], 0x3);         /* cmp byte [ebp-0xf8], 0x3 */
            ii(0x100c_5a50, 6); if(jz(0x100c_5986, -0xd0)) goto l_0x100c_5986; /* jz 0x100c5986 */
            ii(0x100c_5a56, 2); jmp(0x100c_5a0f, -0x49); goto l_0x100c_5a0f; /* jmp 0x100c5a0f */
        l_0x100c_5a58:
            ii(0x100c_5a58, 6); mov(memw[ss, ebp - 0x30], 0);           /* mov word [ebp-0x30], 0x0 */
            ii(0x100c_5a5e, 2); jmp(0x100c_5a67, 0x7); goto l_0x100c_5a67; /* jmp 0x100c5a67 */
        l_0x100c_5a60:
            ii(0x100c_5a60, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5a63, 4); inc(memw[ss, ebp - 0x30]);              /* inc word [ebp-0x30] */
        l_0x100c_5a67:
            ii(0x100c_5a67, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_5a6b, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100c_5a6e, 6); if(jge(0x100c_5b52, 0xde)) goto l_0x100c_5b52; /* jge 0x100c5b52 */
            ii(0x100c_5a74, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5a77, 5); call(Definitions.my_1_get_count, -0x1_a5a4); /* call 0x100ab4d8 */
            ii(0x100c_5a7c, 1); cwde();                                 /* cwde */
            ii(0x100c_5a7d, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_5a80, 2); if(jle(0x100c_5a8d, 0xb)) goto l_0x100c_5a8d; /* jle 0x100c5a8d */
            ii(0x100c_5a82, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5a85, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_5a88, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x100c_5a8b, 2); if(jnz(0x100c_5a8f, 0x2)) goto l_0x100c_5a8f; /* jnz 0x100c5a8f */
        l_0x100c_5a8d:
            ii(0x100c_5a8d, 2); jmp(0x100c_5aa7, 0x18); goto l_0x100c_5aa7; /* jmp 0x100c5aa7 */
        l_0x100c_5a8f:
            ii(0x100c_5a8f, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_5a93, 3); imul(edx, eax, 0x13);                   /* imul edx, eax, 0x13 */
            ii(0x100c_5a96, 5); mov(eax, 0x101c_35b4);                  /* mov eax, 0x101c35b4 */
            ii(0x100c_5a9b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_5a9d, 5); call(Definitions.my_2_get_count, -0x3_a73a); /* call 0x1008b368 */
            ii(0x100c_5aa2, 1); cwde();                                 /* cwde */
            ii(0x100c_5aa3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_5aa5, 2); if(jg(0x100c_5aac, 0x5)) goto l_0x100c_5aac; /* jg 0x100c5aac */
        l_0x100c_5aa7:
            ii(0x100c_5aa7, 5); jmp(0x100c_5b4d, 0xa1); goto l_0x100c_5b4d; /* jmp 0x100c5b4d */
        l_0x100c_5aac:
            ii(0x100c_5aac, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_5ab0, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_5ab6, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100c_5abc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_5ac1, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100c_5ac4, 6); if(jnz(0x100c_5b4d, 0x83)) goto l_0x100c_5b4d; /* jnz 0x100c5b4d */
            ii(0x100c_5aca, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_5ace, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_5ad1, 6); mov(ebx, memd[ds, eax + 0x101c_35bc]);  /* mov ebx, [eax+0x101c35bc] */
            ii(0x100c_5ad7, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_5ada, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_5ade, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_5ae1, 6); mov(edx, memd[ds, eax + 0x101c_35ba]);  /* mov edx, [eax+0x101c35ba] */
            ii(0x100c_5ae7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_5aea, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100c_5aed, 5); call(0x1008_a728, -0x3_b3ca);           /* call 0x1008a728 */
            ii(0x100c_5af2, 3); lea(edx, eax + ebx);                    /* lea edx, [eax+ebx] */
            ii(0x100c_5af5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_5af7, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x100c_5af9, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100c_5afc, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5aff, 5); call(Definitions.my_1_get_count, -0x1_a62c); /* call 0x100ab4d8 */
            ii(0x100c_5b04, 1); dec(eax);                               /* dec eax */
            ii(0x100c_5b05, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100c_5b08, 2); jmp(0x100c_5b10, 0x6); goto l_0x100c_5b10; /* jmp 0x100c5b10 */
        l_0x100c_5b0a:
            ii(0x100c_5b0a, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100c_5b0d, 3); dec(memd[ss, ebp - 0x24]);              /* dec dword [ebp-0x24] */
        l_0x100c_5b10:
            ii(0x100c_5b10, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100c_5b14, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_5b16, 2); if(jl(0x100c_5b26, 0xe)) goto l_0x100c_5b26; /* jl 0x100c5b26 */
            ii(0x100c_5b18, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5b1b, 5); call(Definitions.my_1_get_count, -0x1_a648); /* call 0x100ab4d8 */
            ii(0x100c_5b20, 1); cwde();                                 /* cwde */
            ii(0x100c_5b21, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_5b24, 2); if(jg(0x100c_5b28, 0x2)) goto l_0x100c_5b28; /* jg 0x100c5b28 */
        l_0x100c_5b26:
            ii(0x100c_5b26, 2); jmp(0x100c_5b4d, 0x25); goto l_0x100c_5b4d; /* jmp 0x100c5b4d */
        l_0x100c_5b28:
            ii(0x100c_5b28, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x100c_5b2c, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5b2f, 5); call(0x100c_a904, 0x4dd0);              /* call 0x100ca904 */
            ii(0x100c_5b34, 5); call(0x100c_ac34, 0x50fb);              /* call 0x100cac34 */
            ii(0x100c_5b39, 4); cmp(ax, memw[ss, ebp - 0x34]);          /* cmp ax, [ebp-0x34] */
            ii(0x100c_5b3d, 2); if(jnz(0x100c_5b4b, 0xc)) goto l_0x100c_5b4b; /* jnz 0x100c5b4b */
            ii(0x100c_5b3f, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x100c_5b43, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5b46, 5); call(0x1013_b24f, 0x7_5704);            /* call 0x1013b24f */
        l_0x100c_5b4b:
            ii(0x100c_5b4b, 2); jmp(0x100c_5b0a, -0x43); goto l_0x100c_5b0a; /* jmp 0x100c5b0a */
        l_0x100c_5b4d:
            ii(0x100c_5b4d, 5); jmp(0x100c_5a60, -0xf2); goto l_0x100c_5a60; /* jmp 0x100c5a60 */
        l_0x100c_5b52:
            ii(0x100c_5b52, 6); mov(edx, memd[ds, 0x101c_8172]);        /* mov edx, [0x101c8172] */
            ii(0x100c_5b58, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_5b5b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_5b5d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_5b60, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_5b62, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100c_5b64, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100c_5b67, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x100c_5b6d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_5b70, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_5b72, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_5b75, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_5b77, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100c_5b79, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_5b7c, 6); lea(eax, ebp - 0xfc);                   /* lea eax, [ebp-0xfc] */
            ii(0x100c_5b82, 5); call(0x1007_6aac, -0x4_f0db);           /* call 0x10076aac */
            ii(0x100c_5b87, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_5b8a, 4); cmp(memb[ds, edx + 0x2], 0x1);          /* cmp byte [edx+0x2], 0x1 */
            ii(0x100c_5b8e, 2); if(jz(0x100c_5b99, 0x9)) goto l_0x100c_5b99; /* jz 0x100c5b99 */
            ii(0x100c_5b90, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5b93, 4); cmp(memb[ds, eax + 0x2], 0x3);          /* cmp byte [eax+0x2], 0x3 */
            ii(0x100c_5b97, 2); if(jnz(0x100c_5b9b, 0x2)) goto l_0x100c_5b9b; /* jnz 0x100c5b9b */
        l_0x100c_5b99:
            ii(0x100c_5b99, 2); jmp(0x100c_5ba4, 0x9); goto l_0x100c_5ba4; /* jmp 0x100c5ba4 */
        l_0x100c_5b9b:
            ii(0x100c_5b9b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5b9e, 4); cmp(memb[ds, eax + 0x2], 0x4);          /* cmp byte [eax+0x2], 0x4 */
            ii(0x100c_5ba2, 2); if(jnz(0x100c_5ba6, 0x2)) goto l_0x100c_5ba6; /* jnz 0x100c5ba6 */
        l_0x100c_5ba4:
            ii(0x100c_5ba4, 2); jmp(0x100c_5bb3, 0xd); goto l_0x100c_5bb3; /* jmp 0x100c5bb3 */
        l_0x100c_5ba6:
            ii(0x100c_5ba6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5ba9, 4); cmp(memb[ds, eax + 0x2], 0x9);          /* cmp byte [eax+0x2], 0x9 */
            ii(0x100c_5bad, 6); if(jnz(0x100c_5ca1, 0xee)) goto l_0x100c_5ca1; /* jnz 0x100c5ca1 */
        l_0x100c_5bb3:
            ii(0x100c_5bb3, 10); mov(memd[ss, ebp - 0x100], 0);         /* mov dword [ebp-0x100], 0x0 */
            ii(0x100c_5bbd, 6); mov(memw[ss, ebp - 0x30], 0);           /* mov word [ebp-0x30], 0x0 */
            ii(0x100c_5bc3, 2); jmp(0x100c_5bcc, 0x7); goto l_0x100c_5bcc; /* jmp 0x100c5bcc */
        l_0x100c_5bc5:
            ii(0x100c_5bc5, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5bc8, 4); inc(memw[ss, ebp - 0x30]);              /* inc word [ebp-0x30] */
        l_0x100c_5bcc:
            ii(0x100c_5bcc, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5bcf, 5); call(Definitions.my_1_get_count, -0x1_a6fc); /* call 0x100ab4d8 */
            ii(0x100c_5bd4, 4); cmp(ax, memw[ss, ebp - 0x30]);          /* cmp ax, [ebp-0x30] */
            ii(0x100c_5bd8, 2); if(jle(0x100c_5c27, 0x4d)) goto l_0x100c_5c27; /* jle 0x100c5c27 */
            ii(0x100c_5bda, 6); lea(ebx, ebp - 0x104);                  /* lea ebx, [ebp-0x104] */
            ii(0x100c_5be0, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_5be4, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5be7, 5); call(0x100c_a904, 0x4d18);              /* call 0x100ca904 */
            ii(0x100c_5bec, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100c_5bee, 5); call(0x100c_8154, 0x2561);              /* call 0x100c8154 */
            ii(0x100c_5bf3, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_5bf5, 6); lea(edx, ebp - 0xfc);                   /* lea edx, [ebp-0xfc] */
            ii(0x100c_5bfb, 6); lea(eax, ebp - 0x108);                  /* lea eax, [ebp-0x108] */
            ii(0x100c_5c01, 5); call(0x1007_5e64, -0x4_fda2);           /* call 0x10075e64 */
            ii(0x100c_5c06, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100c_5c08, 5); call(0x100a_5fca, -0x1_fc43);           /* call 0x100a5fca */
            ii(0x100c_5c0d, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100c_5c10, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100c_5c13, 7); cmp(ax, memw[ss, ebp - 0x100]);         /* cmp ax, [ebp-0x100] */
            ii(0x100c_5c1a, 2); if(jle(0x100c_5c25, 0x9)) goto l_0x100c_5c25; /* jle 0x100c5c25 */
            ii(0x100c_5c1c, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100c_5c1f, 6); mov(memd[ss, ebp - 0x100], eax);        /* mov [ebp-0x100], eax */
        l_0x100c_5c25:
            ii(0x100c_5c25, 2); jmp(0x100c_5bc5, -0x62); goto l_0x100c_5bc5; /* jmp 0x100c5bc5 */
        l_0x100c_5c27:
            ii(0x100c_5c27, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5c2a, 5); call(Definitions.my_1_get_count, -0x1_a757); /* call 0x100ab4d8 */
            ii(0x100c_5c2f, 1); dec(eax);                               /* dec eax */
            ii(0x100c_5c30, 4); mov(memw[ss, ebp - 0x30], ax);          /* mov [ebp-0x30], ax */
            ii(0x100c_5c34, 2); jmp(0x100c_5c3d, 0x7); goto l_0x100c_5c3d; /* jmp 0x100c5c3d */
        l_0x100c_5c36:
            ii(0x100c_5c36, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5c39, 4); dec(memw[ss, ebp - 0x30]);              /* dec word [ebp-0x30] */
        l_0x100c_5c3d:
            ii(0x100c_5c3d, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_5c41, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_5c43, 2); if(jl(0x100c_5ca1, 0x5c)) goto l_0x100c_5ca1; /* jl 0x100c5ca1 */
            ii(0x100c_5c45, 6); lea(ebx, ebp - 0x10c);                  /* lea ebx, [ebp-0x10c] */
            ii(0x100c_5c4b, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_5c4f, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5c52, 5); call(0x100c_a904, 0x4cad);              /* call 0x100ca904 */
            ii(0x100c_5c57, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100c_5c59, 5); call(0x100c_8154, 0x24f6);              /* call 0x100c8154 */
            ii(0x100c_5c5e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_5c60, 6); lea(edx, ebp - 0xfc);                   /* lea edx, [ebp-0xfc] */
            ii(0x100c_5c66, 6); lea(eax, ebp - 0x110);                  /* lea eax, [ebp-0x110] */
            ii(0x100c_5c6c, 5); call(0x1007_5e64, -0x4_fe0d);           /* call 0x10075e64 */
            ii(0x100c_5c71, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100c_5c73, 5); call(0x100a_5fca, -0x1_fcae);           /* call 0x100a5fca */
            ii(0x100c_5c78, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100c_5c7b, 7); movsx(edx, memw[ss, ebp - 0x100]);      /* movsx edx, word [ebp-0x100] */
            ii(0x100c_5c82, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_5c84, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_5c87, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_5c89, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100c_5c8b, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x100c_5c8f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_5c91, 2); if(jge(0x100c_5c9f, 0xc)) goto l_0x100c_5c9f; /* jge 0x100c5c9f */
            ii(0x100c_5c93, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_5c97, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5c9a, 5); call(0x1013_b24f, 0x7_55b0);            /* call 0x1013b24f */
        l_0x100c_5c9f:
            ii(0x100c_5c9f, 2); jmp(0x100c_5c36, -0x6b); goto l_0x100c_5c36; /* jmp 0x100c5c36 */
        l_0x100c_5ca1:
            ii(0x100c_5ca1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5ca4, 4); cmp(memb[ds, eax + 0x2], 0x5);          /* cmp byte [eax+0x2], 0x5 */
            ii(0x100c_5ca8, 6); if(jnz(0x100c_5d9e, 0xf0)) goto l_0x100c_5d9e; /* jnz 0x100c5d9e */
            ii(0x100c_5cae, 6); mov(ax, memw[ds, 0x101c_8172]);         /* mov ax, [0x101c8172] */
            ii(0x100c_5cb4, 7); add(ax, memw[ds, 0x101c_8174]);         /* add ax, [0x101c8174] */
            ii(0x100c_5cbb, 6); mov(memd[ss, ebp - 0x114], eax);        /* mov [ebp-0x114], eax */
            ii(0x100c_5cc1, 6); mov(memw[ss, ebp - 0x30], 0);           /* mov word [ebp-0x30], 0x0 */
            ii(0x100c_5cc7, 2); jmp(0x100c_5cd0, 0x7); goto l_0x100c_5cd0; /* jmp 0x100c5cd0 */
        l_0x100c_5cc9:
            ii(0x100c_5cc9, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5ccc, 4); inc(memw[ss, ebp - 0x30]);              /* inc word [ebp-0x30] */
        l_0x100c_5cd0:
            ii(0x100c_5cd0, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5cd3, 5); call(Definitions.my_1_get_count, -0x1_a800); /* call 0x100ab4d8 */
            ii(0x100c_5cd8, 4); cmp(ax, memw[ss, ebp - 0x30]);          /* cmp ax, [ebp-0x30] */
            ii(0x100c_5cdc, 2); if(jle(0x100c_5d2b, 0x4d)) goto l_0x100c_5d2b; /* jle 0x100c5d2b */
            ii(0x100c_5cde, 6); lea(ebx, ebp - 0x118);                  /* lea ebx, [ebp-0x118] */
            ii(0x100c_5ce4, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_5ce8, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5ceb, 5); call(0x100c_a904, 0x4c14);              /* call 0x100ca904 */
            ii(0x100c_5cf0, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100c_5cf2, 5); call(0x100c_8154, 0x245d);              /* call 0x100c8154 */
            ii(0x100c_5cf7, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_5cf9, 6); lea(edx, ebp - 0xfc);                   /* lea edx, [ebp-0xfc] */
            ii(0x100c_5cff, 6); lea(eax, ebp - 0x11c);                  /* lea eax, [ebp-0x11c] */
            ii(0x100c_5d05, 5); call(0x1007_5e64, -0x4_fea6);           /* call 0x10075e64 */
            ii(0x100c_5d0a, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100c_5d0c, 5); call(0x100a_5fca, -0x1_fd47);           /* call 0x100a5fca */
            ii(0x100c_5d11, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100c_5d14, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100c_5d17, 7); cmp(ax, memw[ss, ebp - 0x114]);         /* cmp ax, [ebp-0x114] */
            ii(0x100c_5d1e, 2); if(jge(0x100c_5d29, 0x9)) goto l_0x100c_5d29; /* jge 0x100c5d29 */
            ii(0x100c_5d20, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100c_5d23, 6); mov(memd[ss, ebp - 0x114], eax);        /* mov [ebp-0x114], eax */
        l_0x100c_5d29:
            ii(0x100c_5d29, 2); jmp(0x100c_5cc9, -0x62); goto l_0x100c_5cc9; /* jmp 0x100c5cc9 */
        l_0x100c_5d2b:
            ii(0x100c_5d2b, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5d2e, 5); call(Definitions.my_1_get_count, -0x1_a85b); /* call 0x100ab4d8 */
            ii(0x100c_5d33, 1); dec(eax);                               /* dec eax */
            ii(0x100c_5d34, 4); mov(memw[ss, ebp - 0x30], ax);          /* mov [ebp-0x30], ax */
            ii(0x100c_5d38, 2); jmp(0x100c_5d41, 0x7); goto l_0x100c_5d41; /* jmp 0x100c5d41 */
        l_0x100c_5d3a:
            ii(0x100c_5d3a, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5d3d, 4); dec(memw[ss, ebp - 0x30]);              /* dec word [ebp-0x30] */
        l_0x100c_5d41:
            ii(0x100c_5d41, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100c_5d45, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_5d47, 2); if(jl(0x100c_5d9e, 0x55)) goto l_0x100c_5d9e; /* jl 0x100c5d9e */
            ii(0x100c_5d49, 6); lea(ebx, ebp - 0x120);                  /* lea ebx, [ebp-0x120] */
            ii(0x100c_5d4f, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_5d53, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5d56, 5); call(0x100c_a904, 0x4ba9);              /* call 0x100ca904 */
            ii(0x100c_5d5b, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100c_5d5d, 5); call(0x100c_8154, 0x23f2);              /* call 0x100c8154 */
            ii(0x100c_5d62, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_5d64, 6); lea(edx, ebp - 0xfc);                   /* lea edx, [ebp-0xfc] */
            ii(0x100c_5d6a, 6); lea(eax, ebp - 0x124);                  /* lea eax, [ebp-0x124] */
            ii(0x100c_5d70, 5); call(0x1007_5e64, -0x4_ff11);           /* call 0x10075e64 */
            ii(0x100c_5d75, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100c_5d77, 5); call(0x100a_5fca, -0x1_fdb2);           /* call 0x100a5fca */
            ii(0x100c_5d7c, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100c_5d7f, 7); movsx(eax, memw[ss, ebp - 0x114]);      /* movsx eax, word [ebp-0x114] */
            ii(0x100c_5d86, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_5d88, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x100c_5d8c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_5d8e, 2); if(jle(0x100c_5d9c, 0xc)) goto l_0x100c_5d9c; /* jle 0x100c5d9c */
            ii(0x100c_5d90, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_5d94, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5d97, 5); call(0x1013_b24f, 0x7_54b3);            /* call 0x1013b24f */
        l_0x100c_5d9c:
            ii(0x100c_5d9c, 2); jmp(0x100c_5d3a, -0x64); goto l_0x100c_5d3a; /* jmp 0x100c5d3a */
        l_0x100c_5d9e:
            ii(0x100c_5d9e, 7); mov(memd[ss, ebp - 0x28], 0);           /* mov dword [ebp-0x28], 0x0 */
            ii(0x100c_5da5, 6); mov(memw[ss, ebp - 0x30], 0);           /* mov word [ebp-0x30], 0x0 */
            ii(0x100c_5dab, 2); jmp(0x100c_5db4, 0x7); goto l_0x100c_5db4; /* jmp 0x100c5db4 */
        l_0x100c_5dad:
            ii(0x100c_5dad, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5db0, 4); inc(memw[ss, ebp - 0x30]);              /* inc word [ebp-0x30] */
        l_0x100c_5db4:
            ii(0x100c_5db4, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5db7, 5); call(Definitions.my_1_get_count, -0x1_a8e4); /* call 0x100ab4d8 */
            ii(0x100c_5dbc, 4); cmp(ax, memw[ss, ebp - 0x30]);          /* cmp ax, [ebp-0x30] */
            ii(0x100c_5dc0, 2); if(jle(0x100c_5dd8, 0x16)) goto l_0x100c_5dd8; /* jle 0x100c5dd8 */
            ii(0x100c_5dc2, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_5dc6, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5dc9, 5); call(0x100c_a904, 0x4b36);              /* call 0x100ca904 */
            ii(0x100c_5dce, 5); call(0x100c_ac00, 0x4e2d);              /* call 0x100cac00 */
            ii(0x100c_5dd3, 3); add(memd[ss, ebp - 0x28], eax);         /* add [ebp-0x28], eax */
            ii(0x100c_5dd6, 2); jmp(0x100c_5dad, -0x2b); goto l_0x100c_5dad; /* jmp 0x100c5dad */
        l_0x100c_5dd8:
            ii(0x100c_5dd8, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100c_5ddc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_5dde, 2); if(jnz(0x100c_5e10, 0x30)) goto l_0x100c_5e10; /* jnz 0x100c5e10 */
            ii(0x100c_5de0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5de3, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_5de6, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_5dec, 7); mov(memb[ds, eax + 0x101c_a490], 0);    /* mov byte [eax+0x101ca490], 0x0 */
            ii(0x100c_5df3, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x100c_5df7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_5df9, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100c_5dfc, 5); call(0x1008_bc9f, -0x3_a162);           /* call 0x1008bc9f */
            ii(0x100c_5e01, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_5e03, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5e06, 5); call(0x100c_a824, 0x4a19);              /* call 0x100ca824 */
            ii(0x100c_5e0b, 5); jmp(0x100c_5ecd, 0xbd); goto l_0x100c_5ecd; /* jmp 0x100c5ecd */
        l_0x100c_5e10:
            ii(0x100c_5e10, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x100c_5e14, 5); call(/* sys */ 0x1016_5e9b, 0xa_0082);  /* call 0x10165e9b */
            ii(0x100c_5e19, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100c_5e1c, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100c_5e1f, 1); inc(eax);                               /* inc eax */
            ii(0x100c_5e20, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100c_5e23, 6); mov(memw[ss, ebp - 0x30], 0xffff);      /* mov word [ebp-0x30], 0xffff */
        l_0x100c_5e29:
            ii(0x100c_5e29, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_5e2c, 4); inc(memw[ss, ebp - 0x30]);              /* inc word [ebp-0x30] */
            ii(0x100c_5e30, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_5e34, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5e37, 5); call(0x100c_a904, 0x4ac8);              /* call 0x100ca904 */
            ii(0x100c_5e3c, 5); call(0x100c_ac00, 0x4dbf);              /* call 0x100cac00 */
            ii(0x100c_5e41, 3); sub(memd[ss, ebp - 0x28], eax);         /* sub [ebp-0x28], eax */
            ii(0x100c_5e44, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100c_5e48, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_5e4a, 2); if(jg(0x100c_5e29, -0x23)) goto l_0x100c_5e29; /* jg 0x100c5e29 */
            ii(0x100c_5e4c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5e4f, 4); movsx(ebx, memb[ds, eax + 0x2]);        /* movsx ebx, byte [eax+0x2] */
            ii(0x100c_5e53, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5e56, 3); movsx(ecx, memw[ds, eax]);              /* movsx ecx, word [eax] */
            ii(0x100c_5e59, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100c_5e5d, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5e60, 5); call(0x100c_a904, 0x4a9f);              /* call 0x100ca904 */
            ii(0x100c_5e65, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x100c_5e67, 5); call(0x100c_8096, 0x222a);              /* call 0x100c8096 */
            ii(0x100c_5e6c, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5e6f, 5); call(0x1013_b325, 0x7_54b1);            /* call 0x1013b325 */
            ii(0x100c_5e74, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5e77, 5); call(0x100c_3eb4, -0x1fc8);             /* call 0x100c3eb4 */
            ii(0x100c_5e7c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_5e7f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5e82, 5); call(0x100c_440e, -0x1a79);             /* call 0x100c440e */
            ii(0x100c_5e87, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5e8a, 5); call(0x100c_4051, -0x1e3e);             /* call 0x100c4051 */
            ii(0x100c_5e8f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5e92, 5); call(0x100c_409c, -0x1dfb);             /* call 0x100c409c */
            ii(0x100c_5e97, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_5e9a, 5); call(0x100c_4162, -0x1d3d);             /* call 0x100c4162 */
            ii(0x100c_5e9f, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x100c_5ea3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_5ea5, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100c_5ea8, 5); call(0x1008_bc9f, -0x3_a20e);           /* call 0x1008bc9f */
            ii(0x100c_5ead, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_5eaf, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_5eb2, 5); call(0x100c_a824, 0x496d);              /* call 0x100ca824 */
            ii(0x100c_5eb7, 2); jmp(0x100c_5ecd, 0x14); goto l_0x100c_5ecd; /* jmp 0x100c5ecd */
        //  ii(0x100c_5eb9, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100c_5ebb, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
        //  ii(0x100c_5ebe, 5); call(0x1008_bc9f, -0x3_a224);           /* call 0x1008bc9f */
        //  ii(0x100c_5ec3, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100c_5ec5, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
        //  ii(0x100c_5ec8, 5); call(0x100c_a824, 0x4957);              /* call 0x100ca824 */
        l_0x100c_5ecd:
            ii(0x100c_5ecd, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x100c_5ed0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_5ed2, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_5ed3, 1); pop(edi);                               /* pop edi */
            ii(0x100c_5ed4, 1); pop(esi);                               /* pop esi */
            ii(0x100c_5ed5, 1); pop(edx);                               /* pop edx */
            ii(0x100c_5ed6, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_5ed7, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_5ed8, 1); ret();                                  /* ret */
        }
    }
}
