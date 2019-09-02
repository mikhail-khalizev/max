using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_4583-36f31f5b")]
        public void Method_100a_4583()
        {
            ii(0x100a_4583, 5); push(0x50);                             /* push 0x50 */
            ii(0x100a_4588, 5); call(Definitions.sys_check_available_stack_size, 0xc_17c5); /* call 0x10165d52 */
            ii(0x100a_458d, 1); push(esi);                              /* push esi */
            ii(0x100a_458e, 1); push(edi);                              /* push edi */
            ii(0x100a_458f, 1); push(ebp);                              /* push ebp */
            ii(0x100a_4590, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_4592, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x100a_4598, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100a_459b, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x100a_459e, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x100a_45a1, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x100a_45a4, 4); or(memb[ss, ebp - 24], 1);              /* or byte [ebp-0x18], 0x1 */
            ii(0x100a_45a8, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_45ab, 5); call(0x1007_64fc, -0x2_e0b4);           /* call 0x100764fc */
            ii(0x100a_45b0, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x100a_45b3, 4); and(memb[ss, ebp - 24], -2 /* 0xfe */); /* and byte [ebp-0x18], 0xfe */
            ii(0x100a_45b7, 7); mov(memd[ss, ebp - 36], 0);             /* mov dword [ebp-0x24], 0x0 */
            ii(0x100a_45be, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_45c1, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100a_45c4, 5); call(0x100a_b0ac, 0x6ae3);              /* call 0x100ab0ac */
            ii(0x100a_45c9, 3); lea(ebx, memd[ss, ebp - 40]);           /* lea ebx, [ebp-0x28] */
            ii(0x100a_45cc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_45ce, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_45d0, 5); call(0x100a_afc0, 0x69eb);              /* call 0x100aafc0 */
            ii(0x100a_45d5, 7); mov(memd[ss, ebp - 44], 0);             /* mov dword [ebp-0x2c], 0x0 */
            ii(0x100a_45dc, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_45df, 5); call(0x1008_aef4, -0x1_96f0);           /* call 0x1008aef4 */
            ii(0x100a_45e4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_45e6, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100a_45e9, 5); call(0x1008_ae70, -0x1_977e);           /* call 0x1008ae70 */
            ii(0x100a_45ee, 5); call(0x100a_314c, -0x14a7);             /* call 0x100a314c */
            ii(0x100a_45f3, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x100a_45f6, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100a_45fa, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100a_45fe, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_4604, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x100a_4609, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100a_460b, 5); call(0x100d_fd2c, 0x3_b71c);            /* call 0x100dfd2c */
            ii(0x100a_4610, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100a_4613, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_4616, 4); movsx(edx, memw[ss, ebp - 52]);         /* movsx edx, word [ebp-0x34] */
            ii(0x100a_461a, 3); add(eax, 5);                            /* add eax, 0x5 */
            ii(0x100a_461d, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_461f, 2); if(jge(0x100a_4648, 0x27)) goto l_0x100a_4648; /* jge 0x100a4648 */
            ii(0x100a_4621, 4); mov(memb[ss, ebp - 20], 0);             /* mov byte [ebp-0x14], 0x0 */
            ii(0x100a_4625, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4627, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100a_462a, 5); call(0x1008_8bbc, -0x1_ba73);           /* call 0x10088bbc */
            ii(0x100a_462f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4631, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_4634, 5); call(0x100a_a070, 0x5a37);              /* call 0x100aa070 */
            ii(0x100a_4639, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_463b, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_463e, 5); call(0x1007_5f6c, -0x2_e6d7);           /* call 0x10075f6c */
            ii(0x100a_4643, 5); jmp(0x100a_494b, 0x303); goto l_0x100a_494b; /* jmp 0x100a494b */
        l_0x100a_4648:
            ii(0x100a_4648, 5); cmp(memw[ss, ebp - 12], 0x31);          /* cmp word [ebp-0xc], 0x31 */
            ii(0x100a_464d, 2); if(jnz(0x100a_4658, 9)) goto l_0x100a_4658; /* jnz 0x100a4658 */
            ii(0x100a_464f, 4); movsx(eax, memw[ss, ebp - 52]);         /* movsx eax, word [ebp-0x34] */
            ii(0x100a_4653, 3); cmp(eax, 0x19);                         /* cmp eax, 0x19 */
            ii(0x100a_4656, 2); if(jl(0x100a_465a, 2)) goto l_0x100a_465a; /* jl 0x100a465a */
        l_0x100a_4658:
            ii(0x100a_4658, 2); jmp(0x100a_4681, 0x27); goto l_0x100a_4681; /* jmp 0x100a4681 */
        l_0x100a_465a:
            ii(0x100a_465a, 4); mov(memb[ss, ebp - 20], 0);             /* mov byte [ebp-0x14], 0x0 */
            ii(0x100a_465e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4660, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100a_4663, 5); call(0x1008_8bbc, -0x1_baac);           /* call 0x10088bbc */
            ii(0x100a_4668, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_466a, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_466d, 5); call(0x100a_a070, 0x59fe);              /* call 0x100aa070 */
            ii(0x100a_4672, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4674, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_4677, 5); call(0x1007_5f6c, -0x2_e710);           /* call 0x10075f6c */
            ii(0x100a_467c, 5); jmp(0x100a_494b, 0x2ca); goto l_0x100a_494b; /* jmp 0x100a494b */
        l_0x100a_4681:
            ii(0x100a_4681, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x100a_4685, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100a_4688, 7); test(memb[ds, eax + 0x101c_81c1], 2);   /* test byte [eax+0x101c81c1], 0x2 */
            ii(0x100a_468f, 2); if(jz(0x100a_46a9, 0x18)) goto l_0x100a_46a9; /* jz 0x100a46a9 */
            ii(0x100a_4691, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100a_4696, 5); call(0x1007_6338, -0x2_e363);           /* call 0x10076338 */
            ii(0x100a_469b, 3); lea(ebx, memd[ss, ebp - 28]);           /* lea ebx, [ebp-0x1c] */
            ii(0x100a_469e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_46a0, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_46a2, 5); call(0x1007_643c, -0x2_e26b);           /* call 0x1007643c */
            ii(0x100a_46a7, 2); jmp(0x100a_46bf, 0x16); goto l_0x100a_46bf; /* jmp 0x100a46bf */
        l_0x100a_46a9:
            ii(0x100a_46a9, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100a_46ae, 5); call(0x1007_6338, -0x2_e37b);           /* call 0x10076338 */
            ii(0x100a_46b3, 3); lea(ebx, memd[ss, ebp - 28]);           /* lea ebx, [ebp-0x1c] */
            ii(0x100a_46b6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_46b8, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_46ba, 5); call(0x1007_643c, -0x2_e283);           /* call 0x1007643c */
        l_0x100a_46bf:
            ii(0x100a_46bf, 2); jmp(0x100a_46c9, 8); goto l_0x100a_46c9; /* jmp 0x100a46c9 */
        l_0x100a_46c1:
            ii(0x100a_46c1, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_46c4, 5); call(0x1007_6bf8, -0x2_dad1);           /* call 0x10076bf8 */
        l_0x100a_46c9:
            ii(0x100a_46c9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_46cb, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_46ce, 5); call(0x1013_ad71, 0x9_669e);            /* call 0x1013ad71 */
            ii(0x100a_46d3, 2); test(al, al);                           /* test al, al */
            ii(0x100a_46d5, 2); if(jz(0x100a_4740, 0x69)) goto l_0x100a_4740; /* jz 0x100a4740 */
            ii(0x100a_46d7, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_46da, 5); call(0x1007_63a0, -0x2_e33f);           /* call 0x100763a0 */
            ii(0x100a_46df, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_46e1, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x100a_46e4, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100a_46e8, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_46ea, 2); if(jnz(0x100a_46fe, 0x12)) goto l_0x100a_46fe; /* jnz 0x100a46fe */
            ii(0x100a_46ec, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_46ef, 5); call(0x1007_63a0, -0x2_e354);           /* call 0x100763a0 */
            ii(0x100a_46f4, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x100a_46f8, 4); cmp(ax, memw[ss, ebp - 12]);            /* cmp ax, [ebp-0xc] */
            ii(0x100a_46fc, 2); if(jz(0x100a_4700, 2)) goto l_0x100a_4700; /* jz 0x100a4700 */
        l_0x100a_46fe:
            ii(0x100a_46fe, 2); jmp(0x100a_473e, 0x3e); goto l_0x100a_473e; /* jmp 0x100a473e */
        l_0x100a_4700:
            ii(0x100a_4700, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100a_4703, 3); inc(memd[ss, ebp - 36]);                /* inc dword [ebp-0x24] */
            ii(0x100a_4706, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_4709, 5); call(0x1007_63a0, -0x2_e36e);           /* call 0x100763a0 */
            ii(0x100a_470e, 5); call(0x1015_26ac, 0xa_df99);            /* call 0x101526ac */
            ii(0x100a_4713, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_4715, 2); if(jnz(0x100a_473e, 0x27)) goto l_0x100a_473e; /* jnz 0x100a473e */
            ii(0x100a_4717, 4); mov(memb[ss, ebp - 20], 0);             /* mov byte [ebp-0x14], 0x0 */
            ii(0x100a_471b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_471d, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100a_4720, 5); call(0x1008_8bbc, -0x1_bb69);           /* call 0x10088bbc */
            ii(0x100a_4725, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4727, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_472a, 5); call(0x100a_a070, 0x5941);              /* call 0x100aa070 */
            ii(0x100a_472f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4731, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_4734, 5); call(0x1007_5f6c, -0x2_e7cd);           /* call 0x10075f6c */
            ii(0x100a_4739, 5); jmp(0x100a_494b, 0x20d); goto l_0x100a_494b; /* jmp 0x100a494b */
        l_0x100a_473e:
            ii(0x100a_473e, 2); jmp(0x100a_46c1, -0x7f); goto l_0x100a_46c1; /* jmp 0x100a46c1 */
        l_0x100a_4740:
            ii(0x100a_4740, 2); jmp(0x100a_474a, 8); goto l_0x100a_474a; /* jmp 0x100a474a */
        l_0x100a_4742:
            ii(0x100a_4742, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_4745, 5); call(0x1007_6bf8, -0x2_db52);           /* call 0x10076bf8 */
        l_0x100a_474a:
            ii(0x100a_474a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_474c, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_474f, 5); call(0x1013_ad71, 0x9_661d);            /* call 0x1013ad71 */
            ii(0x100a_4754, 2); test(al, al);                           /* test al, al */
            ii(0x100a_4756, 2); if(jz(0x100a_47b8, 0x60)) goto l_0x100a_47b8; /* jz 0x100a47b8 */
            ii(0x100a_4758, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_475b, 5); call(0x100a_aedc, 0x677c);              /* call 0x100aaedc */
            ii(0x100a_4760, 5); call(0x1008_ad90, -0x1_99d5);           /* call 0x1008ad90 */
            ii(0x100a_4765, 4); cmp(ax, memw[ss, ebp - 8]);             /* cmp ax, [ebp-0x8] */
            ii(0x100a_4769, 2); if(jnz(0x100a_4781, 0x16)) goto l_0x100a_4781; /* jnz 0x100a4781 */
            ii(0x100a_476b, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100a_476f, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_4772, 5); call(0x100a_aedc, 0x6765);              /* call 0x100aaedc */
            ii(0x100a_4777, 5); call(0x100a_6125, 0x19a9);              /* call 0x100a6125 */
            ii(0x100a_477c, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100a_477f, 2); if(jnz(0x100a_4783, 2)) goto l_0x100a_4783; /* jnz 0x100a4783 */
        l_0x100a_4781:
            ii(0x100a_4781, 2); jmp(0x100a_47a0, 0x1d); goto l_0x100a_47a0; /* jmp 0x100a47a0 */
        l_0x100a_4783:
            ii(0x100a_4783, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_4786, 5); add(eax, 0xfa);                         /* add eax, 0xfa */
            ii(0x100a_478b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_478e, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_4791, 5); call(0x100a_aedc, 0x6746);              /* call 0x100aaedc */
            ii(0x100a_4796, 5); call(0x100a_2bc4, -0x1bd7);             /* call 0x100a2bc4 */
            ii(0x100a_479b, 1); cwde();                                 /* cwde */
            ii(0x100a_479c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_479e, 2); if(jle(0x100a_47a2, 2)) goto l_0x100a_47a2; /* jle 0x100a47a2 */
        l_0x100a_47a0:
            ii(0x100a_47a0, 2); jmp(0x100a_47b6, 0x14); goto l_0x100a_47b6; /* jmp 0x100a47b6 */
        l_0x100a_47a2:
            ii(0x100a_47a2, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100a_47a6, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_47a9, 5); call(0x100a_aedc, 0x672e);              /* call 0x100aaedc */
            ii(0x100a_47ae, 5); call(0x100a_6125, 0x1972);              /* call 0x100a6125 */
            ii(0x100a_47b3, 3); add(memd[ss, ebp - 44], eax);           /* add [ebp-0x2c], eax */
        l_0x100a_47b6:
            ii(0x100a_47b6, 2); jmp(0x100a_4742, -0x76); goto l_0x100a_4742; /* jmp 0x100a4742 */
        l_0x100a_47b8:
            ii(0x100a_47b8, 2); jmp(0x100a_47c2, 8); goto l_0x100a_47c2; /* jmp 0x100a47c2 */
        l_0x100a_47ba:
            ii(0x100a_47ba, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100a_47bd, 5); call(0x1007_6bf8, -0x2_dbca);           /* call 0x10076bf8 */
        l_0x100a_47c2:
            ii(0x100a_47c2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_47c4, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100a_47c7, 5); call(0x1013_ad71, 0x9_65a5);            /* call 0x1013ad71 */
            ii(0x100a_47cc, 2); test(al, al);                           /* test al, al */
            ii(0x100a_47ce, 6); if(jz(0x100a_489e, 0xca)) goto l_0x100a_489e; /* jz 0x100a489e */
            ii(0x100a_47d4, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100a_47d7, 5); call(0x1008_adc4, -0x1_9a18);           /* call 0x1008adc4 */
            ii(0x100a_47dc, 5); call(0x1008_ad90, -0x1_9a51);           /* call 0x1008ad90 */
            ii(0x100a_47e1, 4); cmp(ax, memw[ss, ebp - 8]);             /* cmp ax, [ebp-0x8] */
            ii(0x100a_47e5, 2); if(jnz(0x100a_481f, 0x38)) goto l_0x100a_481f; /* jnz 0x100a481f */
            ii(0x100a_47e7, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100a_47ea, 5); call(0x1008_adc4, -0x1_9a2b);           /* call 0x1008adc4 */
            ii(0x100a_47ef, 3); mov(memd[ss, ebp - 56], eax);           /* mov [ebp-0x38], eax */
            ii(0x100a_47f2, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x100a_47f5, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100a_47f8, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x100a_47fb, 3); call_abs(memd[ds, edx + 32]);           /* call dword [edx+0x20] */
            ii(0x100a_47fe, 2); cmp(al, 9);                             /* cmp al, 0x9 */
            ii(0x100a_4800, 2); if(jz(0x100a_481d, 0x1b)) goto l_0x100a_481d; /* jz 0x100a481d */
            ii(0x100a_4802, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100a_4805, 5); call(0x1008_adc4, -0x1_9a46);           /* call 0x1008adc4 */
            ii(0x100a_480a, 3); mov(memd[ss, ebp - 60], eax);           /* mov [ebp-0x3c], eax */
            ii(0x100a_480d, 3); mov(eax, memd[ss, ebp - 60]);           /* mov eax, [ebp-0x3c] */
            ii(0x100a_4810, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100a_4813, 3); mov(eax, memd[ss, ebp - 60]);           /* mov eax, [ebp-0x3c] */
            ii(0x100a_4816, 3); call_abs(memd[ds, edx + 32]);           /* call dword [edx+0x20] */
            ii(0x100a_4819, 2); cmp(al, 8);                             /* cmp al, 0x8 */
            ii(0x100a_481b, 2); if(jnz(0x100a_481f, 2)) goto l_0x100a_481f; /* jnz 0x100a481f */
        l_0x100a_481d:
            ii(0x100a_481d, 2); jmp(0x100a_4821, 2); goto l_0x100a_4821; /* jmp 0x100a4821 */
        l_0x100a_481f:
            ii(0x100a_481f, 2); jmp(0x100a_4834, 0x13); goto l_0x100a_4834; /* jmp 0x100a4834 */
        l_0x100a_4821:
            ii(0x100a_4821, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100a_4824, 5); call(0x1008_adf8, -0x1_9a31);           /* call 0x1008adf8 */
            ii(0x100a_4829, 5); call(0x1009_c4c4, -0x836a);             /* call 0x1009c4c4 */
            ii(0x100a_482e, 4); cmp(ax, memw[ss, ebp - 12]);            /* cmp ax, [ebp-0xc] */
            ii(0x100a_4832, 2); if(jz(0x100a_4836, 2)) goto l_0x100a_4836; /* jz 0x100a4836 */
        l_0x100a_4834:
            ii(0x100a_4834, 2); jmp(0x100a_4870, 0x3a); goto l_0x100a_4870; /* jmp 0x100a4870 */
        l_0x100a_4836:
            ii(0x100a_4836, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100a_4839, 5); call(0x1008_adf8, -0x1_9a46);           /* call 0x1008adf8 */
            ii(0x100a_483e, 3); mov(memd[ss, ebp - 64], eax);           /* mov [ebp-0x40], eax */
            ii(0x100a_4841, 3); mov(eax, memd[ss, ebp - 64]);           /* mov eax, [ebp-0x40] */
            ii(0x100a_4844, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100a_4847, 3); mov(eax, memd[ss, ebp - 64]);           /* mov eax, [ebp-0x40] */
            ii(0x100a_484a, 3); call_abs(memd[ds, edx + 112]);          /* call dword [edx+0x70] */
            ii(0x100a_484d, 2); test(al, al);                           /* test al, al */
            ii(0x100a_484f, 2); if(jnz(0x100a_486e, 0x1d)) goto l_0x100a_486e; /* jnz 0x100a486e */
            ii(0x100a_4851, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_4854, 5); add(eax, 0xfa);                         /* add eax, 0xfa */
            ii(0x100a_4859, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_485c, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100a_485f, 5); call(0x1008_adc4, -0x1_9aa0);           /* call 0x1008adc4 */
            ii(0x100a_4864, 5); call(0x100a_2bc4, -0x1ca5);             /* call 0x100a2bc4 */
            ii(0x100a_4869, 1); cwde();                                 /* cwde */
            ii(0x100a_486a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_486c, 2); if(jg(0x100a_4870, 2)) goto l_0x100a_4870; /* jg 0x100a4870 */
        l_0x100a_486e:
            ii(0x100a_486e, 2); jmp(0x100a_4872, 2); goto l_0x100a_4872; /* jmp 0x100a4872 */
        l_0x100a_4870:
            ii(0x100a_4870, 2); jmp(0x100a_4899, 0x27); goto l_0x100a_4899; /* jmp 0x100a4899 */
        l_0x100a_4872:
            ii(0x100a_4872, 4); mov(memb[ss, ebp - 20], 0);             /* mov byte [ebp-0x14], 0x0 */
            ii(0x100a_4876, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4878, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100a_487b, 5); call(0x1008_8bbc, -0x1_bcc4);           /* call 0x10088bbc */
            ii(0x100a_4880, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4882, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_4885, 5); call(0x100a_a070, 0x57e6);              /* call 0x100aa070 */
            ii(0x100a_488a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_488c, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_488f, 5); call(0x1007_5f6c, -0x2_e928);           /* call 0x10075f6c */
            ii(0x100a_4894, 5); jmp(0x100a_494b, 0xb2); goto l_0x100a_494b; /* jmp 0x100a494b */
        l_0x100a_4899:
            ii(0x100a_4899, 5); jmp(0x100a_47ba, -0xe4); goto l_0x100a_47ba; /* jmp 0x100a47ba */
        l_0x100a_489e:
            ii(0x100a_489e, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x100a_48a1, 4); cmp(ax, memw[ss, ebp - 36]);            /* cmp ax, [ebp-0x24] */
            ii(0x100a_48a5, 2); if(jge(0x100a_48ce, 0x27)) goto l_0x100a_48ce; /* jge 0x100a48ce */
            ii(0x100a_48a7, 4); mov(memb[ss, ebp - 20], 0);             /* mov byte [ebp-0x14], 0x0 */
            ii(0x100a_48ab, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_48ad, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100a_48b0, 5); call(0x1008_8bbc, -0x1_bcf9);           /* call 0x10088bbc */
            ii(0x100a_48b5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_48b7, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_48ba, 5); call(0x100a_a070, 0x57b1);              /* call 0x100aa070 */
            ii(0x100a_48bf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_48c1, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_48c4, 5); call(0x1007_5f6c, -0x2_e95d);           /* call 0x10075f6c */
            ii(0x100a_48c9, 5); jmp(0x100a_494b, 0x7d); goto l_0x100a_494b; /* jmp 0x100a494b */
        l_0x100a_48ce:
            ii(0x100a_48ce, 4); movsx(eax, memw[ss, ebp - 36]);         /* movsx eax, word [ebp-0x24] */
            ii(0x100a_48d2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_48d4, 2); if(jle(0x100a_48e3, 0xd)) goto l_0x100a_48e3; /* jle 0x100a48e3 */
            ii(0x100a_48d6, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100a_48da, 5); call(0x100a_5c69, 0x138a);              /* call 0x100a5c69 */
            ii(0x100a_48df, 2); test(al, al);                           /* test al, al */
            ii(0x100a_48e1, 2); if(jnz(0x100a_48e5, 2)) goto l_0x100a_48e5; /* jnz 0x100a48e5 */
        l_0x100a_48e3:
            ii(0x100a_48e3, 2); jmp(0x100a_4909, 0x24); goto l_0x100a_4909; /* jmp 0x100a4909 */
        l_0x100a_48e5:
            ii(0x100a_48e5, 4); mov(memb[ss, ebp - 20], 0);             /* mov byte [ebp-0x14], 0x0 */
            ii(0x100a_48e9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_48eb, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100a_48ee, 5); call(0x1008_8bbc, -0x1_bd37);           /* call 0x10088bbc */
            ii(0x100a_48f3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_48f5, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_48f8, 5); call(0x100a_a070, 0x5773);              /* call 0x100aa070 */
            ii(0x100a_48fd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_48ff, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_4902, 5); call(0x1007_5f6c, -0x2_e99b);           /* call 0x10075f6c */
            ii(0x100a_4907, 2); jmp(0x100a_494b, 0x42); goto l_0x100a_494b; /* jmp 0x100a494b */
        l_0x100a_4909:
            ii(0x100a_4909, 4); mov(memb[ss, ebp - 20], 1);             /* mov byte [ebp-0x14], 0x1 */
            ii(0x100a_490d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_490f, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100a_4912, 5); call(0x1008_8bbc, -0x1_bd5b);           /* call 0x10088bbc */
            ii(0x100a_4917, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4919, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_491c, 5); call(0x100a_a070, 0x574f);              /* call 0x100aa070 */
            ii(0x100a_4921, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_4923, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100a_4926, 5); call(0x1007_5f6c, -0x2_e9bf);           /* call 0x10075f6c */
            ii(0x100a_492b, 2); jmp(0x100a_494b, 0x1e); goto l_0x100a_494b; /* jmp 0x100a494b */
        //  ii(0x100a_492d, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100a_492f, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
        //  ii(0x100a_4932, 5); call(0x1008_8bbc, -0x1_bd7b);           /* call 0x10088bbc */
        //  ii(0x100a_4937, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100a_4939, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
        //  ii(0x100a_493c, 5); call(0x100a_a070, 0x572f);              /* call 0x100aa070 */
        //  ii(0x100a_4941, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100a_4943, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
        //  ii(0x100a_4946, 5); call(0x1007_5f6c, -0x2_e9df);           /* call 0x10075f6c */
        l_0x100a_494b:
            ii(0x100a_494b, 3); mov(al, memb[ss, ebp - 20]);            /* mov al, [ebp-0x14] */
            ii(0x100a_494e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_4950, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_4951, 1); pop(edi);                               /* pop edi */
            ii(0x100a_4952, 1); pop(esi);                               /* pop esi */
            ii(0x100a_4953, 1); ret();                                  /* ret */
        }
    }
}
