using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("916c93fc-eaec-42ba-b48e-00ac96cc180e")]
        public void Method_100d_4580()
        {
            ii(0x100d_4580, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100d_4585, 5); calld(Definitions.sys_check_available_stack_size, 0x9_17c8); /* call 0x10165d52 */
            ii(0x100d_458a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_458b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_458c, 1); pushd(esi);                             /* push esi */
            ii(0x100d_458d, 1); pushd(edi);                             /* push edi */
            ii(0x100d_458e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_458f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4591, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100d_4597, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_459a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_459d, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100d_45a1, 2); if(jled(0x100d_45ac, 0x9)) goto l_0x100d_45ac; /* jle 0x100d45ac */
            ii(0x100d_45a3, 7); cmp(memd_a32[ss, ebp - 0x4], 0x7000);   /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x100d_45aa, 2); if(jld(0x100d_45ae, 0x2)) goto l_0x100d_45ae; /* jl 0x100d45ae */
        l_0x100d_45ac:
            ii(0x100d_45ac, 2); jmpd(0x100d_45b8, 0xa); goto l_0x100d_45b8; /* jmp 0x100d45b8 */
        l_0x100d_45ae:
            ii(0x100d_45ae, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_45b1, 7); mov(memb_a32[ds, eax + 0x86], 0);       /* mov byte [eax+0x86], 0x0 */
        l_0x100d_45b8:
            ii(0x100d_45b8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_45bb, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_45be, 5); jmpd(0x100d_470e, 0x14b); goto l_0x100d_470e; /* jmp 0x100d470e */
        l_0x100d_45c3:
            ii(0x100d_45c3, 5); calld(0x1011_6ba6, 0x4_25de);           /* call 0x10116ba6 */
            ii(0x100d_45c8, 5); jmpd(0x100d_4788, 0x1bb); goto l_0x100d_4788; /* jmp 0x100d4788 */
        l_0x100d_45cd:
            ii(0x100d_45cd, 5); calld(0x100d_4e6c, 0x89a);              /* call 0x100d4e6c */
            ii(0x100d_45d2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_45d4, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_45d6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_45d8, 5); mov(eax, 0x12);                         /* mov eax, 0x12 */
            ii(0x100d_45dd, 5); calld(0x1010_5b00, 0x3_151e);           /* call 0x10105b00 */
            ii(0x100d_45e2, 5); jmpd(0x100d_4788, 0x1a1); goto l_0x100d_4788; /* jmp 0x100d4788 */
        l_0x100d_45e7:
            ii(0x100d_45e7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_45ea, 5); calld(0x100d_44aa, -0x145);             /* call 0x100d44aa */
            ii(0x100d_45ef, 5); jmpd(0x100d_4788, 0x194); goto l_0x100d_4788; /* jmp 0x100d4788 */
        l_0x100d_45f4:
            ii(0x100d_45f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_45f7, 5); calld(0x100d_4523, -0xd9);              /* call 0x100d4523 */
            ii(0x100d_45fc, 5); jmpd(0x100d_4788, 0x187); goto l_0x100d_4788; /* jmp 0x100d4788 */
        l_0x100d_4601:
            ii(0x100d_4601, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4604, 6); mov(eax, memd_a32[ds, eax + 0xa5]);     /* mov eax, [eax+0xa5] */
            ii(0x100d_460a, 5); calld(0x100c_fbbe, -0x4a51);            /* call 0x100cfbbe */
            ii(0x100d_460f, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_4614, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4617, 3); mov(eax, memd_a32[ds, eax + 0x31]);     /* mov eax, [eax+0x31] */
            ii(0x100d_461a, 5); calld(0x100d_5410, 0xdf1);              /* call 0x100d5410 */
            ii(0x100d_461f, 5); jmpd(0x100d_4788, 0x164); goto l_0x100d_4788; /* jmp 0x100d4788 */
        l_0x100d_4624:
            ii(0x100d_4624, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4627, 6); mov(eax, memd_a32[ds, eax + 0xa5]);     /* mov eax, [eax+0xa5] */
            ii(0x100d_462d, 5); calld(0x100c_fbbe, -0x4a74);            /* call 0x100cfbbe */
            ii(0x100d_4632, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_4634, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4637, 3); mov(eax, memd_a32[ds, eax + 0x31]);     /* mov eax, [eax+0x31] */
            ii(0x100d_463a, 5); calld(0x100d_5410, 0xdd1);              /* call 0x100d5410 */
            ii(0x100d_463f, 5); jmpd(0x100d_4788, 0x144); goto l_0x100d_4788; /* jmp 0x100d4788 */
        l_0x100d_4644:
            ii(0x100d_4644, 7); cmp(memd_a32[ss, ebp - 0x4], 0x7000);   /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x100d_464b, 2); if(jld(0x100d_46af, 0x62)) goto l_0x100d_46af; /* jl 0x100d46af */
            ii(0x100d_464d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4650, 7); cmp(memb_a32[ds, eax + 0x86], 0);       /* cmp byte [eax+0x86], 0x0 */
            ii(0x100d_4657, 2); if(jnzd(0x100d_46a3, 0x4a)) goto l_0x100d_46a3; /* jnz 0x100d46a3 */
            ii(0x100d_4659, 7); add(memd_a32[ss, ebp - 0x4], 0xffff_9000); /* add dword [ebp-0x4], 0xffff9000 */
            ii(0x100d_4660, 7); cmp(memd_a32[ss, ebp - 0x4], 0x3e8);    /* cmp dword [ebp-0x4], 0x3e8 */
            ii(0x100d_4667, 2); if(jnzd(0x100d_4679, 0x10)) goto l_0x100d_4679; /* jnz 0x100d4679 */
            ii(0x100d_4669, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_466c, 6); mov(eax, memd_a32[ds, eax + 0xa1]);     /* mov eax, [eax+0xa1] */
            ii(0x100d_4672, 5); calld(0x100c_fbbe, -0x4ab9);            /* call 0x100cfbbe */
            ii(0x100d_4677, 2); jmpd(0x100d_46a3, 0x2a); goto l_0x100d_46a3; /* jmp 0x100d46a3 */
        l_0x100d_4679:
            ii(0x100d_4679, 7); cmp(memd_a32[ss, ebp - 0x4], 0x3e9);    /* cmp dword [ebp-0x4], 0x3e9 */
            ii(0x100d_4680, 2); if(jnzd(0x100d_4692, 0x10)) goto l_0x100d_4692; /* jnz 0x100d4692 */
            ii(0x100d_4682, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4685, 6); mov(eax, memd_a32[ds, eax + 0x9d]);     /* mov eax, [eax+0x9d] */
            ii(0x100d_468b, 5); calld(0x100c_fbbe, -0x4ad2);            /* call 0x100cfbbe */
            ii(0x100d_4690, 2); jmpd(0x100d_46a3, 0x11); goto l_0x100d_46a3; /* jmp 0x100d46a3 */
        l_0x100d_4692:
            ii(0x100d_4692, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_4695, 6); add(edx, 0x7000);                       /* add edx, 0x7000 */
            ii(0x100d_469b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_469e, 5); calld(0x100d_21f0, -0x24b3);            /* call 0x100d21f0 */
        l_0x100d_46a3:
            ii(0x100d_46a3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_46a6, 7); mov(memb_a32[ds, eax + 0x86], 0x1);     /* mov byte [eax+0x86], 0x1 */
            ii(0x100d_46ad, 2); jmpd(0x100d_4709, 0x5a); goto l_0x100d_4709; /* jmp 0x100d4709 */
        l_0x100d_46af:
            ii(0x100d_46af, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_46b2, 6); mov(eax, memd_a32[ds, eax + 0x91]);     /* mov eax, [eax+0x91] */
            ii(0x100d_46b8, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_46bb, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_46be, 3); mov(ebx, memd_a32[ds, eax + 0x40]);     /* mov ebx, [eax+0x40] */
            ii(0x100d_46c1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_46c4, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_46c7, 3); calld_abs(memd_a32[ds, ebx + 0xc]);     /* call dword [ebx+0xc] */
            ii(0x100d_46ca, 2); test(al, al);                           /* test al, al */
            ii(0x100d_46cc, 2); if(jnzd(0x100d_46ed, 0x1f)) goto l_0x100d_46ed; /* jnz 0x100d46ed */
            ii(0x100d_46ce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_46d1, 6); mov(eax, memd_a32[ds, eax + 0x8d]);     /* mov eax, [eax+0x8d] */
            ii(0x100d_46d7, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_46da, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_46dd, 3); mov(ebx, memd_a32[ds, eax + 0x40]);     /* mov ebx, [eax+0x40] */
            ii(0x100d_46e0, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_46e3, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_46e6, 3); calld_abs(memd_a32[ds, ebx + 0xc]);     /* call dword [ebx+0xc] */
            ii(0x100d_46e9, 2); test(al, al);                           /* test al, al */
            ii(0x100d_46eb, 2); if(jzd(0x100d_46f6, 0x9)) goto l_0x100d_46f6; /* jz 0x100d46f6 */
        l_0x100d_46ed:
            ii(0x100d_46ed, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_46f1, 5); jmpd(0x100d_478c, 0x96); goto l_0x100d_478c; /* jmp 0x100d478c */
        l_0x100d_46f6:
            ii(0x100d_46f6, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_46f9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_46fc, 5); calld(0x100d_21f0, -0x2511);            /* call 0x100d21f0 */
            ii(0x100d_4701, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100d_4704, 5); jmpd(0x100d_478c, 0x83); goto l_0x100d_478c; /* jmp 0x100d478c */
        l_0x100d_4709:
            ii(0x100d_4709, 5); jmpd(0x100d_4788, 0x7a); goto l_0x100d_4788; /* jmp 0x100d4788 */
        l_0x100d_470e:
            ii(0x100d_470e, 7); cmp(memd_a32[ss, ebp - 0x10], 0x3e9);   /* cmp dword [ebp-0x10], 0x3e9 */
            ii(0x100d_4715, 2); if(jbd(0x100d_4751, 0x3a)) goto l_0x100d_4751; /* jb 0x100d4751 */
            ii(0x100d_4717, 7); cmp(memd_a32[ss, ebp - 0x10], 0x3e9);   /* cmp dword [ebp-0x10], 0x3e9 */
            ii(0x100d_471e, 6); if(jbed(0x100d_45f4, -0x130)) goto l_0x100d_45f4; /* jbe 0x100d45f4 */
            ii(0x100d_4724, 7); cmp(memd_a32[ss, ebp - 0x10], 0x3eb);   /* cmp dword [ebp-0x10], 0x3eb */
            ii(0x100d_472b, 2); if(jbd(0x100d_474c, 0x1f)) goto l_0x100d_474c; /* jb 0x100d474c */
            ii(0x100d_472d, 7); cmp(memd_a32[ss, ebp - 0x10], 0x3eb);   /* cmp dword [ebp-0x10], 0x3eb */
            ii(0x100d_4734, 6); if(jbed(0x100d_4624, -0x116)) goto l_0x100d_4624; /* jbe 0x100d4624 */
            ii(0x100d_473a, 7); cmp(memd_a32[ss, ebp - 0x10], 0x44c);   /* cmp dword [ebp-0x10], 0x44c */
            ii(0x100d_4741, 6); if(jzd(0x100d_45cd, -0x17a)) goto l_0x100d_45cd; /* jz 0x100d45cd */
            ii(0x100d_4747, 5); jmpd(0x100d_4644, -0x108); goto l_0x100d_4644; /* jmp 0x100d4644 */
        l_0x100d_474c:
            ii(0x100d_474c, 5); jmpd(0x100d_4601, -0x150); goto l_0x100d_4601; /* jmp 0x100d4601 */
        l_0x100d_4751:
            ii(0x100d_4751, 7); cmp(memd_a32[ss, ebp - 0x10], 0x119);   /* cmp dword [ebp-0x10], 0x119 */
            ii(0x100d_4758, 2); if(jbd(0x100d_4779, 0x1f)) goto l_0x100d_4779; /* jb 0x100d4779 */
            ii(0x100d_475a, 7); cmp(memd_a32[ss, ebp - 0x10], 0x119);   /* cmp dword [ebp-0x10], 0x119 */
            ii(0x100d_4761, 6); if(jbed(0x100d_45c3, -0x1a4)) goto l_0x100d_45c3; /* jbe 0x100d45c3 */
            ii(0x100d_4767, 7); cmp(memd_a32[ss, ebp - 0x10], 0x3e8);   /* cmp dword [ebp-0x10], 0x3e8 */
            ii(0x100d_476e, 6); if(jzd(0x100d_45e7, -0x18d)) goto l_0x100d_45e7; /* jz 0x100d45e7 */
            ii(0x100d_4774, 5); jmpd(0x100d_4644, -0x135); goto l_0x100d_4644; /* jmp 0x100d4644 */
        l_0x100d_4779:
            ii(0x100d_4779, 4); cmp(memd_a32[ss, ebp - 0x10], 0x3f);    /* cmp dword [ebp-0x10], 0x3f */
            ii(0x100d_477d, 6); if(jzd(0x100d_45cd, -0x1b6)) goto l_0x100d_45cd; /* jz 0x100d45cd */
            ii(0x100d_4783, 5); jmpd(0x100d_4644, -0x144); goto l_0x100d_4644; /* jmp 0x100d4644 */
        l_0x100d_4788:
            ii(0x100d_4788, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x100d_478c:
            ii(0x100d_478c, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100d_478f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4791, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_4792, 1); popd(edi);                              /* pop edi */
            ii(0x100d_4793, 1); popd(esi);                              /* pop esi */
            ii(0x100d_4794, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_4795, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_4796, 1); retd(); return;                         /* ret */
        }
    }
}
