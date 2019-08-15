using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("45a6f4d9-ee7c-4215-9143-f6ac58babc97")]
        public void Method_100a_65f4()
        {
            ii(0x100a_65f4, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100a_65f9, 5); calld(Definitions.sys_check_available_stack_size, 0xb_f754); /* call 0x10165d52 */
            ii(0x100a_65fe, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_65ff, 1); pushd(esi);                             /* push esi */
            ii(0x100a_6600, 1); pushd(edi);                             /* push edi */
            ii(0x100a_6601, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_6602, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_6604, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100a_660a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_660d, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_6610, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100a_6613, 4); or(memb_a32[ss, ebp - 0x14], 0x1);      /* or byte [ebp-0x14], 0x1 */
            ii(0x100a_6617, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_661a, 5); calld(0x1007_64fc, -0x3_0123);          /* call 0x100764fc */
            ii(0x100a_661f, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_6622, 4); and(memb_a32[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x100a_6626, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x100a_662d, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_6631, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100a_6635, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100a_6638, 7); test(memb_a32[ds, eax + 0x101c_81c1], 0x2); /* test byte [eax+0x101c81c1], 0x2 */
            ii(0x100a_663f, 2); if(jzd(0x100a_6659, 0x18)) goto l_0x100a_6659; /* jz 0x100a6659 */
            ii(0x100a_6641, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100a_6646, 5); calld(0x1007_6338, -0x3_0313);          /* call 0x10076338 */
            ii(0x100a_664b, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x100a_664e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_6650, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_6652, 5); calld(0x1007_643c, -0x3_021b);          /* call 0x1007643c */
            ii(0x100a_6657, 2); jmpd(0x100a_6697, 0x3e); goto l_0x100a_6697; /* jmp 0x100a6697 */
        l_0x100a_6659:
            ii(0x100a_6659, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100a_665d, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100a_6660, 7); test(memb_a32[ds, eax + 0x101c_81c0], 0x40); /* test byte [eax+0x101c81c0], 0x40 */
            ii(0x100a_6667, 2); if(jzd(0x100a_6681, 0x18)) goto l_0x100a_6681; /* jz 0x100a6681 */
            ii(0x100a_6669, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100a_666e, 5); calld(0x1007_6338, -0x3_033b);          /* call 0x10076338 */
            ii(0x100a_6673, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x100a_6676, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_6678, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_667a, 5); calld(0x1007_643c, -0x3_0243);          /* call 0x1007643c */
            ii(0x100a_667f, 2); jmpd(0x100a_6697, 0x16); goto l_0x100a_6697; /* jmp 0x100a6697 */
        l_0x100a_6681:
            ii(0x100a_6681, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100a_6686, 5); calld(0x1007_6338, -0x3_0353);          /* call 0x10076338 */
            ii(0x100a_668b, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x100a_668e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_6690, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_6692, 5); calld(0x1007_643c, -0x3_025b);          /* call 0x1007643c */
        l_0x100a_6697:
            ii(0x100a_6697, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6699, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_669c, 5); calld(0x1013_ad71, 0x9_46d0);           /* call 0x1013ad71 */
            ii(0x100a_66a1, 2); test(al, al);                           /* test al, al */
            ii(0x100a_66a3, 6); if(jzd(0x100a_67e8, 0x13f)) goto l_0x100a_67e8; /* jz 0x100a67e8 */
            ii(0x100a_66a9, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_66ac, 5); calld(0x1007_63a0, -0x3_0311);          /* call 0x100763a0 */
            ii(0x100a_66b1, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100a_66b5, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x100a_66b9, 6); if(jnzd(0x100a_67db, 0x11c)) goto l_0x100a_67db; /* jnz 0x100a67db */
            ii(0x100a_66bf, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_66c2, 5); calld(0x1007_63a0, -0x3_0327);          /* call 0x100763a0 */
            ii(0x100a_66c7, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100a_66cb, 2); if(jnzd(0x100a_66dd, 0x10)) goto l_0x100a_66dd; /* jnz 0x100a66dd */
            ii(0x100a_66cd, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_66d0, 5); calld(0x1007_63a0, -0x3_0335);          /* call 0x100763a0 */
            ii(0x100a_66d5, 6); test(memw_a32[ds, eax + 0x12], 0x1c0);  /* test word [eax+0x12], 0x1c0 */
            ii(0x100a_66db, 2); if(jnzd(0x100a_66e2, 0x5)) goto l_0x100a_66e2; /* jnz 0x100a66e2 */
        l_0x100a_66dd:
            ii(0x100a_66dd, 5); jmpd(0x100a_6762, 0x80); goto l_0x100a_6762; /* jmp 0x100a6762 */
        l_0x100a_66e2:
            ii(0x100a_66e2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_66e5, 5); calld(0x1007_63a0, -0x3_034a);          /* call 0x100763a0 */
            ii(0x100a_66ea, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100a_66ec, 3); mov(cl, memb_a32[ds, eax + 0x45]);      /* mov cl, [eax+0x45] */
            ii(0x100a_66ef, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_66f2, 5); calld(0x1007_63a0, -0x3_0357);          /* call 0x100763a0 */
            ii(0x100a_66f7, 5); calld(0x1007_623c, -0x3_04c0);          /* call 0x1007623c */
            ii(0x100a_66fc, 5); imul(cx, memw_a32[ds, eax + 0x10]);     /* imul cx, [eax+0x10] */
            ii(0x100a_6701, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_6704, 5); calld(0x1007_63a0, -0x3_0369);          /* call 0x100763a0 */
            ii(0x100a_6709, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_670c, 4); mov(dx, memw_a32[ds, edx + 0x19]);      /* mov dx, [edx+0x19] */
            ii(0x100a_6710, 4); sub(dx, memw_a32[ds, eax + 0x1c]);      /* sub dx, [eax+0x1c] */
            ii(0x100a_6714, 3); movsx(ebx, dx);                         /* movsx ebx, dx */
            ii(0x100a_6717, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_671a, 5); calld(0x1007_63a0, -0x3_037f);          /* call 0x100763a0 */
            ii(0x100a_671f, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_6722, 4); mov(dx, memw_a32[ds, edx + 0x17]);      /* mov dx, [edx+0x17] */
            ii(0x100a_6726, 4); sub(dx, memw_a32[ds, eax + 0x1a]);      /* sub dx, [eax+0x1a] */
            ii(0x100a_672a, 3); movsx(eax, dx);                         /* movsx eax, dx */
            ii(0x100a_672d, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100a_672f, 5); calld(0x100a_5f65, -0x7cf);             /* call 0x100a5f65 */
            ii(0x100a_6734, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100a_6736, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100a_6739, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x100a_673d, 2); if(jzd(0x100a_6748, 0x9)) goto l_0x100a_6748; /* jz 0x100a6748 */
            ii(0x100a_673f, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100a_6742, 4); cmp(ax, memw_a32[ss, ebp - 0x24]);      /* cmp ax, [ebp-0x24] */
            ii(0x100a_6746, 2); if(jled(0x100a_675d, 0x15)) goto l_0x100a_675d; /* jle 0x100a675d */
        l_0x100a_6748:
            ii(0x100a_6748, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_674c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_674f, 5); calld(0x1007_6408, -0x3_034c);          /* call 0x10076408 */
            ii(0x100a_6754, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100a_6757, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100a_675a, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x100a_675d:
            ii(0x100a_675d, 5); jmpd(0x100a_67db, 0x79); goto l_0x100a_67db; /* jmp 0x100a67db */
        l_0x100a_6762:
            ii(0x100a_6762, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_6764, 3); mov(bl, memb_a32[ss, ebp - 0x4]);       /* mov bl, [ebp-0x4] */
            ii(0x100a_6767, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_676a, 5); calld(0x1007_636c, -0x3_0403);          /* call 0x1007636c */
            ii(0x100a_676f, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x100a_6772, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_6774, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100a_6776, 5); calld(0x100a_64c6, -0x2b5);             /* call 0x100a64c6 */
            ii(0x100a_677b, 2); test(al, al);                           /* test al, al */
            ii(0x100a_677d, 2); if(jzd(0x100a_67db, 0x5c)) goto l_0x100a_67db; /* jz 0x100a67db */
            ii(0x100a_677f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_6782, 5); calld(0x1007_63a0, -0x3_03e7);          /* call 0x100763a0 */
            ii(0x100a_6787, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_6789, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_678c, 4); mov(ax, memw_a32[ds, eax + 0x19]);      /* mov ax, [eax+0x19] */
            ii(0x100a_6790, 4); sub(ax, memw_a32[ds, edx + 0x1c]);      /* sub ax, [edx+0x1c] */
            ii(0x100a_6794, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100a_6797, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_679a, 5); calld(0x1007_63a0, -0x3_03ff);          /* call 0x100763a0 */
            ii(0x100a_679f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_67a1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_67a4, 4); mov(ax, memw_a32[ds, eax + 0x17]);      /* mov ax, [eax+0x17] */
            ii(0x100a_67a8, 4); sub(ax, memw_a32[ds, edx + 0x1a]);      /* sub ax, [edx+0x1a] */
            ii(0x100a_67ac, 1); cwde();                                 /* cwde */
            ii(0x100a_67ad, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100a_67af, 5); calld(0x100a_5f65, -0x84f);             /* call 0x100a5f65 */
            ii(0x100a_67b4, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100a_67b7, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x100a_67bb, 2); if(jzd(0x100a_67c6, 0x9)) goto l_0x100a_67c6; /* jz 0x100a67c6 */
            ii(0x100a_67bd, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100a_67c0, 4); cmp(ax, memw_a32[ss, ebp - 0x24]);      /* cmp ax, [ebp-0x24] */
            ii(0x100a_67c4, 2); if(jled(0x100a_67db, 0x15)) goto l_0x100a_67db; /* jle 0x100a67db */
        l_0x100a_67c6:
            ii(0x100a_67c6, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x100a_67ca, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_67cd, 5); calld(0x1007_6408, -0x3_03ca);          /* call 0x10076408 */
            ii(0x100a_67d2, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100a_67d5, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100a_67d8, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x100a_67db:
            ii(0x100a_67db, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_67de, 5); calld(0x1007_6bf8, -0x2_fbeb);          /* call 0x10076bf8 */
            ii(0x100a_67e3, 5); jmpd(0x100a_6697, -0x151); goto l_0x100a_6697; /* jmp 0x100a6697 */
        l_0x100a_67e8:
            ii(0x100a_67e8, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100a_67ec, 2); if(jnzd(0x100a_67f5, 0x7)) goto l_0x100a_67f5; /* jnz 0x100a67f5 */
            ii(0x100a_67ee, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
        l_0x100a_67f5:
            ii(0x100a_67f5, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100a_67f8, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100a_67fb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_67fd, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_6800, 5); calld(0x1007_5f6c, -0x3_0899);          /* call 0x10075f6c */
            ii(0x100a_6805, 2); jmpd(0x100a_6811, 0xa); goto l_0x100a_6811; /* jmp 0x100a6811 */
        //    ii(0x100a_6807, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100a_6809, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
        //    ii(0x100a_680c, 5); calld(0x1007_5f6c, -0x3_08a5);          /* call 0x10075f6c */
        l_0x100a_6811:
            ii(0x100a_6811, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100a_6814, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_6816, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_6817, 1); popd(edi);                              /* pop edi */
            ii(0x100a_6818, 1); popd(esi);                              /* pop esi */
            ii(0x100a_6819, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_681a, 1); retd(); return;                         /* ret */
        }
    }
}
