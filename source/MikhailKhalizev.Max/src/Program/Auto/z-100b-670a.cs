using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_670a-272e6b16")]
        public void Method_100b_670a()
        {
            ii(0x100b_670a, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100b_670f, 5); calld(Definitions.sys_check_available_stack_size, 0xa_f63e); /* call 0x10165d52 */
            ii(0x100b_6714, 1); pushd(esi);                             /* push esi */
            ii(0x100b_6715, 1); pushd(edi);                             /* push edi */
            ii(0x100b_6716, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_6717, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_6719, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100b_671f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_6722, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100b_6725, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100b_6728, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100b_672b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_672d, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100b_6732, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_6734, 2); if(jnzd(0x100b_674b, 0x15)) goto l_0x100b_674b; /* jnz 0x100b674b */
            ii(0x100b_6736, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_6739, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100b_673c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_673f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6741, 6); mov(dl, memb_a32[ds, 0x101c_37c8]);     /* mov dl, [0x101c37c8] */
            ii(0x100b_6747, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_6749, 2); if(jnzd(0x100b_674d, 0x2)) goto l_0x100b_674d; /* jnz 0x100b674d */
        l_0x100b_674b:
            ii(0x100b_674b, 2); jmpd(0x100b_6752, 0x5); goto l_0x100b_6752; /* jmp 0x100b6752 */
        l_0x100b_674d:
            ii(0x100b_674d, 5); jmpd(0x100b_6897, 0x145); goto l_0x100b_6897; /* jmp 0x100b6897 */
        l_0x100b_6752:
            ii(0x100b_6752, 5); mov(ecx, 0x180);                        /* mov ecx, 0x180 */
            ii(0x100b_6757, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_675a, 3); mov(ebx, memd_a32[ds, eax + 0x7]);      /* mov ebx, [eax+0x7] */
            ii(0x100b_675d, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_6760, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_6763, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100b_6765, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_6768, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_676b, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_676e, 5); calld(0x1007_388b, -0x4_2ee8);          /* call 0x1007388b */
            ii(0x100b_6773, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_6775, 6); if(jzd(0x100b_6802, 0x87)) goto l_0x100b_6802; /* jz 0x100b6802 */
            ii(0x100b_677b, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x100b_6780, 5); calld(Definitions.sys_new, 0xa_f67b);   /* call 0x10165e00 */
            ii(0x100b_6785, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_6788, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_678b, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100b_678e, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100b_6792, 2); if(jzd(0x100b_67ad, 0x19)) goto l_0x100b_67ad; /* jz 0x100b67ad */
            ii(0x100b_6794, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x100b_6797, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_679a, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_679d, 5); calld(0x100a_73d7, -0xf3cb);            /* call 0x100a73d7 */
            ii(0x100b_67a2, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100b_67a5, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100b_67a8, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_67ab, 2); jmpd(0x100b_67b3, 0x6); goto l_0x100b_67b3; /* jmp 0x100b67b3 */
        l_0x100b_67ad:
            ii(0x100b_67ad, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_67b0, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x100b_67b3:
            ii(0x100b_67b3, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100b_67b6, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_67b9, 5); calld(0x100b_815c, 0x199e);             /* call 0x100b815c */
            ii(0x100b_67be, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_67c1, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_67c4, 5); calld(0x100a_a824, -0xbfa5);            /* call 0x100aa824 */
            ii(0x100b_67c9, 5); calld(0x100a_7557, -0xf277);            /* call 0x100a7557 */
            ii(0x100b_67ce, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_67d1, 5); calld(0x100b_80f4, 0x191e);             /* call 0x100b80f4 */
            ii(0x100b_67d6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_67d8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_67db, 3); mov(ebx, memd_a32[ds, eax + 0x7]);      /* mov ebx, [eax+0x7] */
            ii(0x100b_67de, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_67e1, 6); imul(ebx, ebx, 0xc5);                   /* imul ebx, ebx, 0xc5 */
            ii(0x100b_67e7, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x100b_67ec, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_67ee, 5); calld(0x100c_21b2, 0xb9bf);             /* call 0x100c21b2 */
            ii(0x100b_67f3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_67f5, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_67f8, 5); calld(0x1009_b8ec, -0x1_af11);          /* call 0x1009b8ec */
            ii(0x100b_67fd, 5); jmpd(0x100b_6897, 0x95); goto l_0x100b_6897; /* jmp 0x100b6897 */
        l_0x100b_6802:
            ii(0x100b_6802, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_6805, 3); mov(dx, memw_a32[ds, eax]);             /* mov dx, [eax] */
            ii(0x100b_6808, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_680b, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x100b_680f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_6812, 4); mov(dx, memw_a32[ds, eax + 0x2]);       /* mov dx, [eax+0x2] */
            ii(0x100b_6816, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_6819, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x100b_681d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_6820, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_6823, 5); calld(0x1008_a998, -0x2_be90);          /* call 0x1008a998 */
            ii(0x100b_6828, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_682a, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100b_682f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_6831, 2); if(jnzd(0x100b_6848, 0x15)) goto l_0x100b_6848; /* jnz 0x100b6848 */
            ii(0x100b_6833, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_6836, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100b_6839, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_683c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_683e, 6); mov(dl, memb_a32[ds, 0x101c_37c8]);     /* mov dl, [0x101c37c8] */
            ii(0x100b_6844, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_6846, 2); if(jnzd(0x100b_6851, 0x9)) goto l_0x100b_6851; /* jnz 0x100b6851 */
        l_0x100b_6848:
            ii(0x100b_6848, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x100b_684f, 2); jmpd(0x100b_686a, 0x19); goto l_0x100b_686a; /* jmp 0x100b686a */
        l_0x100b_6851:
            ii(0x100b_6851, 5); mov(ecx, 0x10d1);                       /* mov ecx, 0x10d1 */
            ii(0x100b_6856, 5); mov(ebx, StringDefinitions.AiMoveCpp11); /* mov ebx, 0x101a1158 */
            ii(0x100b_685b, 5); mov(edx, StringDefinitions.PlaymodeNotEqualTurnBasedTeamturnidEqualTeam5); /* mov edx, 0x101a1164 */
            ii(0x100b_6860, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_6862, 5); calld(Definitions.sys_assert, 0xa_f52b); /* call 0x10165d92 */
            ii(0x100b_6867, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x100b_686a:
            ii(0x100b_686a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_686d, 5); cmp(memw_a32[ds, eax + 0x8], 0x4e);     /* cmp word [eax+0x8], 0x4e */
            ii(0x100b_6872, 2); if(jnzd(0x100b_6885, 0x11)) goto l_0x100b_6885; /* jnz 0x100b6885 */
            ii(0x100b_6874, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_6876, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x100b_687b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_687e, 5); calld(0x1016_3053, 0xa_c7d0);           /* call 0x10163053 */
            ii(0x100b_6883, 2); jmpd(0x100b_6897, 0x12); goto l_0x100b_6897; /* jmp 0x100b6897 */
        l_0x100b_6885:
            ii(0x100b_6885, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100b_688a, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x100b_688f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_6892, 5); calld(0x1016_3053, 0xa_c7bc);           /* call 0x10163053 */
        l_0x100b_6897:
            ii(0x100b_6897, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_6899, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_689a, 1); popd(edi);                              /* pop edi */
            ii(0x100b_689b, 1); popd(esi);                              /* pop esi */
            ii(0x100b_689c, 1); retd(); return;                         /* ret */
        }
    }
}
