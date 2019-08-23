using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_d6e4-52e93dea")]
        public void Method_100a_d6e4()
        {
            ii(0x100a_d6e4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_d6e9, 5); calld(Definitions.sys_check_available_stack_size, 0xb_8664); /* call 0x10165d52 */
            ii(0x100a_d6ee, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_d6ef, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_d6f0, 1); pushd(edx);                             /* push edx */
            ii(0x100a_d6f1, 1); pushd(esi);                             /* push esi */
            ii(0x100a_d6f2, 1); pushd(edi);                             /* push edi */
            ii(0x100a_d6f3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_d6f4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_d6f6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_d6fc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_d6ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_d702, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_d705, 5); calld(0x1007_6574, -0x3_7196);          /* call 0x10076574 */
            ii(0x100a_d70a, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100a_d70d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_d710, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100a_d713, 7); test(memb_a32[ds, eax + 0x101c_81d4], 0x2); /* test byte [eax+0x101c81d4], 0x2 */
            ii(0x100a_d71a, 2); if(jzd(0x100a_d72e, 0x12)) goto l_0x100a_d72e; /* jz 0x100ad72e */
            ii(0x100a_d71c, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100a_d721, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_d724, 5); calld(0x100a_d02d, -0x6fc);             /* call 0x100ad02d */
            ii(0x100a_d729, 5); jmpd(0x100a_d863, 0x135); goto l_0x100a_d863; /* jmp 0x100ad863 */
        l_0x100a_d72e:
            ii(0x100a_d72e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_d731, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_d734, 5); calld(0x1007_6574, -0x3_71c5);          /* call 0x10076574 */
            ii(0x100a_d739, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x100a_d73e, 2); if(jzd(0x100a_d752, 0x12)) goto l_0x100a_d752; /* jz 0x100ad752 */
            ii(0x100a_d740, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_d743, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_d746, 5); calld(0x1007_6574, -0x3_71d7);          /* call 0x10076574 */
            ii(0x100a_d74b, 5); cmp(memw_a32[ds, eax + 0x8], 0x43);     /* cmp word [eax+0x8], 0x43 */
            ii(0x100a_d750, 2); if(jnzd(0x100a_d78c, 0x3a)) goto l_0x100a_d78c; /* jnz 0x100ad78c */
        l_0x100a_d752:
            ii(0x100a_d752, 5); mov(ebx, 0x41);                         /* mov ebx, 0x41 */
            ii(0x100a_d757, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_d75a, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x100a_d75d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_d760, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100a_d765, 5); calld(0x100a_d632, -0x138);             /* call 0x100ad632 */
            ii(0x100a_d76a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_d76c, 2); if(jnzd(0x100a_d78a, 0x1c)) goto l_0x100a_d78a; /* jnz 0x100ad78a */
            ii(0x100a_d76e, 5); mov(ebx, 0x18);                         /* mov ebx, 0x18 */
            ii(0x100a_d773, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_d776, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x100a_d779, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_d77c, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100a_d781, 5); calld(0x100a_d632, -0x154);             /* call 0x100ad632 */
            ii(0x100a_d786, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_d788, 2); if(jzd(0x100a_d78c, 0x2)) goto l_0x100a_d78c; /* jz 0x100ad78c */
        l_0x100a_d78a:
            ii(0x100a_d78a, 2); jmpd(0x100a_d791, 0x5); goto l_0x100a_d791; /* jmp 0x100ad791 */
        l_0x100a_d78c:
            ii(0x100a_d78c, 5); jmpd(0x100a_d81b, 0x8a); goto l_0x100a_d81b; /* jmp 0x100ad81b */
        l_0x100a_d791:
            ii(0x100a_d791, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100a_d798, 2); jmpd(0x100a_d7a0, 0x6); goto l_0x100a_d7a0; /* jmp 0x100ad7a0 */
        l_0x100a_d79a:
            ii(0x100a_d79a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_d79d, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x100a_d7a0:
            ii(0x100a_d7a0, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100a_d7a4, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100a_d7a7, 2); if(jged(0x100a_d803, 0x5a)) goto l_0x100a_d803; /* jge 0x100ad803 */
            ii(0x100a_d7a9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_d7ac, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_d7af, 4); cmp(ax, memw_a32[ds, edx + 0x9]);       /* cmp ax, [edx+0x9] */
            ii(0x100a_d7b3, 2); if(jzd(0x100a_d801, 0x4c)) goto l_0x100a_d801; /* jz 0x100ad801 */
            ii(0x100a_d7b5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_d7b8, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_d7bb, 5); calld(0x1007_6574, -0x3_724c);          /* call 0x10076574 */
            ii(0x100a_d7c0, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x100a_d7c3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_d7c6, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x100a_d7cb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_d7ce, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100a_d7d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_d7d4, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_d7d7, 5); calld(0x1007_6574, -0x3_7268);          /* call 0x10076574 */
            ii(0x100a_d7dc, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100a_d7df, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_d7e2, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_d7e4, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100a_d7e8, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_d7ee, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6a3]); /* mov eax, [eax+0x101ca6a3] */
            ii(0x100a_d7f4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_d7f6, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100a_d7f8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_d7fd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_d7ff, 2); if(jgd(0x100a_d803, 0x2)) goto l_0x100a_d803; /* jg 0x100ad803 */
        l_0x100a_d801:
            ii(0x100a_d801, 2); jmpd(0x100a_d79a, -0x69); goto l_0x100a_d79a; /* jmp 0x100ad79a */
        l_0x100a_d803:
            ii(0x100a_d803, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100a_d807, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100a_d80a, 2); if(jnzd(0x100a_d81b, 0xf)) goto l_0x100a_d81b; /* jnz 0x100ad81b */
            ii(0x100a_d80c, 5); mov(edx, 0x41);                         /* mov edx, 0x41 */
            ii(0x100a_d811, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_d814, 5); calld(0x100a_d86c, 0x53);               /* call 0x100ad86c */
            ii(0x100a_d819, 2); jmpd(0x100a_d863, 0x48); goto l_0x100a_d863; /* jmp 0x100ad863 */
        l_0x100a_d81b:
            ii(0x100a_d81b, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x100a_d820, 5); calld(0x100c_dec2, 0x2_069d);           /* call 0x100cdec2 */
            ii(0x100a_d825, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_d827, 2); if(jzd(0x100a_d845, 0x1c)) goto l_0x100a_d845; /* jz 0x100ad845 */
            ii(0x100a_d829, 5); mov(ebx, 0x4e);                         /* mov ebx, 0x4e */
            ii(0x100a_d82e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_d831, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x100a_d834, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_d837, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100a_d83c, 5); calld(0x100a_d632, -0x20f);             /* call 0x100ad632 */
            ii(0x100a_d841, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_d843, 2); if(jnzd(0x100a_d847, 0x2)) goto l_0x100a_d847; /* jnz 0x100ad847 */
        l_0x100a_d845:
            ii(0x100a_d845, 2); jmpd(0x100a_d856, 0xf); goto l_0x100a_d856; /* jmp 0x100ad856 */
        l_0x100a_d847:
            ii(0x100a_d847, 5); mov(edx, 0x4e);                         /* mov edx, 0x4e */
            ii(0x100a_d84c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_d84f, 5); calld(0x100a_d86c, 0x18);               /* call 0x100ad86c */
            ii(0x100a_d854, 2); jmpd(0x100a_d863, 0xd); goto l_0x100a_d863; /* jmp 0x100ad863 */
        l_0x100a_d856:
            ii(0x100a_d856, 5); mov(edx, 0x48);                         /* mov edx, 0x48 */
            ii(0x100a_d85b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_d85e, 5); calld(0x100a_d86c, 0x9);                /* call 0x100ad86c */
        l_0x100a_d863:
            ii(0x100a_d863, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_d865, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_d866, 1); popd(edi);                              /* pop edi */
            ii(0x100a_d867, 1); popd(esi);                              /* pop esi */
            ii(0x100a_d868, 1); popd(edx);                              /* pop edx */
            ii(0x100a_d869, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_d86a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_d86b, 1); retd();                                 /* ret */
        }
    }
}
