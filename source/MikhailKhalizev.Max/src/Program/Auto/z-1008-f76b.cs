using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_f76b-85a9e9e2")]
        public void Method_1008_f76b()
        {
            ii(0x1008_f76b, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x1008_f770, 5); calld(Definitions.sys_check_available_stack_size, 0xd_65dd); /* call 0x10165d52 */
            ii(0x1008_f775, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_f776, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_f777, 1); pushd(edx);                             /* push edx */
            ii(0x1008_f778, 1); pushd(esi);                             /* push esi */
            ii(0x1008_f779, 1); pushd(edi);                             /* push edi */
            ii(0x1008_f77a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_f77b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_f77d, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1008_f783, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_f786, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_f789, 5); calld(Definitions.my_ctor_0x101b_4184, -0x1_8c9e); /* call 0x10076af0 */
            ii(0x1008_f78e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f791, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_f794, 5); calld(0x1007_6574, -0x1_9225);          /* call 0x10076574 */
            ii(0x1008_f799, 5); calld(0x1015_26ac, 0xc_2f0e);           /* call 0x101526ac */
            ii(0x1008_f79e, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1008_f7a1, 6); if(jnzd(0x1008_f93e, 0x197)) goto l_0x1008_f93e; /* jnz 0x1008f93e */
            ii(0x1008_f7a7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f7aa, 4); mov(memb_a32[ds, eax + 0x25], 0x5);     /* mov byte [eax+0x25], 0x5 */
            ii(0x1008_f7ae, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_f7b0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f7b3, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1008_f7b6, 5); calld(0x1013_ad11, 0xa_b556);           /* call 0x1013ad11 */
            ii(0x1008_f7bb, 2); test(al, al);                           /* test al, al */
            ii(0x1008_f7bd, 2); if(jnzd(0x1008_f7c9, 0xa)) goto l_0x1008_f7c9; /* jnz 0x1008f7c9 */
            ii(0x1008_f7bf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f7c2, 5); cmp(memw_a32[ds, eax + 0x13], 0xc);     /* cmp word [eax+0x13], 0xc */
            ii(0x1008_f7c7, 2); if(jnzd(0x1008_f7cb, 0x2)) goto l_0x1008_f7cb; /* jnz 0x1008f7cb */
        l_0x1008_f7c9:
            ii(0x1008_f7c9, 2); jmpd(0x1008_f7d5, 0xa); goto l_0x1008_f7d5; /* jmp 0x1008f7d5 */
        l_0x1008_f7cb:
            ii(0x1008_f7cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f7ce, 5); cmp(memw_a32[ds, eax + 0x13], 0x21);    /* cmp word [eax+0x13], 0x21 */
            ii(0x1008_f7d3, 2); if(jnzd(0x1008_f7e2, 0xd)) goto l_0x1008_f7e2; /* jnz 0x1008f7e2 */
        l_0x1008_f7d5:
            ii(0x1008_f7d5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f7d8, 5); calld(0x1008_df3e, -0x189f);            /* call 0x1008df3e */
            ii(0x1008_f7dd, 5); jmpd(0x1008_f93e, 0x15c); goto l_0x1008_f93e; /* jmp 0x1008f93e */
        l_0x1008_f7e2:
            ii(0x1008_f7e2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f7e5, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1008_f7e8, 5); calld(0x1008_af28, -0x48c5);            /* call 0x1008af28 */
            ii(0x1008_f7ed, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_f7f0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_f7f3, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_f7f6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_f7f9, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x1008_f7fc, 2); cmp(al, 0x15);                          /* cmp al, 0x15 */
            ii(0x1008_f7fe, 2); if(jnzd(0x1008_f809, 0x9)) goto l_0x1008_f809; /* jnz 0x1008f809 */
            ii(0x1008_f800, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1008_f807, 2); jmpd(0x1008_f822, 0x19); goto l_0x1008_f822; /* jmp 0x1008f822 */
        l_0x1008_f809:
            ii(0x1008_f809, 5); mov(ecx, 0x62f);                        /* mov ecx, 0x62f */
            ii(0x1008_f80e, 5); mov(ebx, StringDefinitions.AiBuildCpp4); /* mov ebx, 0x101a0589 */
            ii(0x1008_f813, 5); mov(edx, StringDefinitions.BuildingManagerGettypeEqualTaskManageBuildings); /* mov edx, 0x101a0596 */
            ii(0x1008_f818, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_f81a, 5); calld(Definitions.sys_assert, 0xd_6573); /* call 0x10165d92 */
            ii(0x1008_f81f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x1008_f822:
            ii(0x1008_f822, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f825, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1008_f828, 5); calld(0x1008_afb4, -0x4879);            /* call 0x1008afb4 */
            ii(0x1008_f82d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_f830, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x1008_f833, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_f836, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_f839, 5); calld(0x1009_6b8a, 0x734c);             /* call 0x10096b8a */
            ii(0x1008_f83e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_f840, 6); if(jzd(0x1008_f936, 0xf0)) goto l_0x1008_f936; /* jz 0x1008f936 */
            ii(0x1008_f846, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1008_f849, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f84c, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1008_f84f, 5); calld(0x1008_8b44, -0x6d10);            /* call 0x10088b44 */
            ii(0x1008_f854, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f857, 3); mov(eax, memd_a32[ds, eax + 0x1f]);     /* mov eax, [eax+0x1f] */
            ii(0x1008_f85a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_f85d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_f85f, 2); if(jled(0x1008_f86e, 0xd)) goto l_0x1008_f86e; /* jle 0x1008f86e */
            ii(0x1008_f861, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f864, 3); mov(eax, memd_a32[ds, eax + 0x21]);     /* mov eax, [eax+0x21] */
            ii(0x1008_f867, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_f86a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_f86c, 2); if(jgd(0x1008_f870, 0x2)) goto l_0x1008_f870; /* jg 0x1008f870 */
        l_0x1008_f86e:
            ii(0x1008_f86e, 2); jmpd(0x1008_f879, 0x9); goto l_0x1008_f879; /* jmp 0x1008f879 */
        l_0x1008_f870:
            ii(0x1008_f870, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1008_f877, 2); jmpd(0x1008_f892, 0x19); goto l_0x1008_f892; /* jmp 0x1008f892 */
        l_0x1008_f879:
            ii(0x1008_f879, 5); mov(ecx, 0x63b);                        /* mov ecx, 0x63b */
            ii(0x1008_f87e, 5); mov(ebx, StringDefinitions.AiBuildCpp5); /* mov ebx, 0x101a05cb */
            ii(0x1008_f883, 5); mov(edx, StringDefinitions.SiteXGreater0SiteYGreater02); /* mov edx, 0x101a05d8 */
            ii(0x1008_f888, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_f88a, 5); calld(Definitions.sys_assert, 0xd_6503); /* call 0x10165d92 */
            ii(0x1008_f88f, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1008_f892:
            ii(0x1008_f892, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f895, 4); mov(memb_a32[ds, eax + 0x25], 0x7);     /* mov byte [eax+0x25], 0x7 */
            ii(0x1008_f899, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_f89b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f89e, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_f8a1, 5); calld(0x1013_ad11, 0xa_b46b);           /* call 0x1013ad11 */
            ii(0x1008_f8a6, 2); test(al, al);                           /* test al, al */
            ii(0x1008_f8a8, 6); if(jnzd(0x1008_f93e, 0x90)) goto l_0x1008_f93e; /* jnz 0x1008f93e */
            ii(0x1008_f8ae, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f8b1, 5); calld(0x1008_f52c, -0x38a);             /* call 0x1008f52c */
            ii(0x1008_f8b6, 2); test(al, al);                           /* test al, al */
            ii(0x1008_f8b8, 2); if(jnzd(0x1008_f8c6, 0xc)) goto l_0x1008_f8c6; /* jnz 0x1008f8c6 */
            ii(0x1008_f8ba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f8bd, 5); calld(0x1008_e1b5, -0x170d);            /* call 0x1008e1b5 */
            ii(0x1008_f8c2, 2); test(al, al);                           /* test al, al */
            ii(0x1008_f8c4, 2); if(jzd(0x1008_f8c8, 0x2)) goto l_0x1008_f8c8; /* jz 0x1008f8c8 */
        l_0x1008_f8c6:
            ii(0x1008_f8c6, 2); jmpd(0x1008_f8d4, 0xc); goto l_0x1008_f8d4; /* jmp 0x1008f8d4 */
        l_0x1008_f8c8:
            ii(0x1008_f8c8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f8cb, 5); calld(0x1008_e39c, -0x1534);            /* call 0x1008e39c */
            ii(0x1008_f8d0, 2); test(al, al);                           /* test al, al */
            ii(0x1008_f8d2, 2); if(jzd(0x1008_f8d6, 0x2)) goto l_0x1008_f8d6; /* jz 0x1008f8d6 */
        l_0x1008_f8d4:
            ii(0x1008_f8d4, 2); jmpd(0x1008_f93e, 0x68); goto l_0x1008_f93e; /* jmp 0x1008f93e */
        l_0x1008_f8d6:
            ii(0x1008_f8d6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f8d9, 5); calld(0x1008_ad28, -0x4bb6);            /* call 0x1008ad28 */
            ii(0x1008_f8de, 2); test(al, al);                           /* test al, al */
            ii(0x1008_f8e0, 2); if(jnzd(0x1008_f934, 0x52)) goto l_0x1008_f934; /* jnz 0x1008f934 */
            ii(0x1008_f8e2, 5); calld(0x1008_a7bc, -0x512b);            /* call 0x1008a7bc */
            ii(0x1008_f8e7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_f8ec, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_f8ef, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1008_f8f4, 5); calld(Definitions.sys_new, 0xd_6507);   /* call 0x10165e00 */
            ii(0x1008_f8f9, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1008_f8fc, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1008_f8ff, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1008_f902, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1008_f906, 2); if(jzd(0x1008_f91e, 0x16)) goto l_0x1008_f91e; /* jz 0x1008f91e */
            ii(0x1008_f908, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_f90b, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1008_f90e, 5); calld(Definitions.my_ctor_c11, 0x1_3fb6); /* call 0x100a38c9 */
            ii(0x1008_f913, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1008_f916, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1008_f919, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1008_f91c, 2); jmpd(0x1008_f924, 0x6); goto l_0x1008_f924; /* jmp 0x1008f924 */
        l_0x1008_f91e:
            ii(0x1008_f91e, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1008_f921, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x1008_f924:
            ii(0x1008_f924, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x1008_f927, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_f92c, 3); mov(ebx, memd_a32[ss, ebp - 0x1c]);     /* mov ebx, [ebp-0x1c] */
            ii(0x1008_f92f, 5); calld(0x100a_4db6, 0x1_5482);           /* call 0x100a4db6 */
        l_0x1008_f934:
            ii(0x1008_f934, 2); jmpd(0x1008_f93e, 0x8); goto l_0x1008_f93e; /* jmp 0x1008f93e */
        l_0x1008_f936:
            ii(0x1008_f936, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_f939, 5); calld(0x1008_df3e, -0x1a00);            /* call 0x1008df3e */
        l_0x1008_f93e:
            ii(0x1008_f93e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_f940, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_f941, 1); popd(edi);                              /* pop edi */
            ii(0x1008_f942, 1); popd(esi);                              /* pop esi */
            ii(0x1008_f943, 1); popd(edx);                              /* pop edx */
            ii(0x1008_f944, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_f945, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_f946, 1); retd();                                 /* ret */
        }
    }
}
