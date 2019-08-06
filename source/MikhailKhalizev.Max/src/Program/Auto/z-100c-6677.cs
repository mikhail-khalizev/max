using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5a47f835-5cd5-445a-a2dc-03f50a486560")]
        public void Method_100c_6677()
        {
            ii(0x100c_6677, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x100c_667c, 5); calld(Definitions.sys_check_available_stack_size, 0x9f6d1); /* call 0x10165d52 */
            ii(0x100c_6681, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_6682, 1); pushd(esi);                             /* push esi */
            ii(0x100c_6683, 1); pushd(edi);                             /* push edi */
            ii(0x100c_6684, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_6685, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_6687, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100c_668d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_6690, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_6693, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100c_6696, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x100c_669a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_669d, 5); calld(0x100c_9fb4, 0x3912);             /* call 0x100c9fb4 */
            ii(0x100c_66a2, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_66a5, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x100c_66a9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_66ac, 3); mov(eax, memd_a32[ds, eax + 0x79]);     /* mov eax, [eax+0x79] */
            ii(0x100c_66af, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_66b2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_66b4, 2); if(jged(0x100c_6701, 0x4b)) goto l_0x100c_6701; /* jge 0x100c6701 */
            ii(0x100c_66b6, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100c_66bd, 2); jmpd(0x100c_66c5, 0x6); goto l_0x100c_66c5; /* jmp 0x100c66c5 */
        l_0x100c_66bf:
            ii(0x100c_66bf, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100c_66c2, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x100c_66c5:
            ii(0x100c_66c5, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_66c9, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100c_66cc, 2); if(jged(0x100c_6701, 0x33)) goto l_0x100c_6701; /* jge 0x100c6701 */
            ii(0x100c_66ce, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_66d1, 3); mov(eax, memd_a32[ds, eax + 0x79]);     /* mov eax, [eax+0x79] */
            ii(0x100c_66d4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_66d7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_66d9, 2); if(jld(0x100c_66f5, 0x1a)) goto l_0x100c_66f5; /* jl 0x100c66f5 */
            ii(0x100c_66db, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_66df, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_66e5, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100c_66eb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_66f0, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100c_66f3, 2); if(jzd(0x100c_66ff, 0xa)) goto l_0x100c_66ff; /* jz 0x100c66ff */
        l_0x100c_66f5:
            ii(0x100c_66f5, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100c_66f8, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_66fb, 4); mov(memw_a32[ds, edx + 0x7b], ax);      /* mov [edx+0x7b], ax */
        l_0x100c_66ff:
            ii(0x100c_66ff, 2); jmpd(0x100c_66bf, -0x42); goto l_0x100c_66bf; /* jmp 0x100c66bf */
        l_0x100c_6701:
            ii(0x100c_6701, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_6704, 3); mov(eax, memd_a32[ds, eax + 0x79]);     /* mov eax, [eax+0x79] */
            ii(0x100c_6707, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_670a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_670c, 6); if(jld(0x100c_693c, 0x22a)) goto l_0x100c_693c; /* jl 0x100c693c */
            ii(0x100c_6712, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_6716, 6); if(jzd(0x100c_67d6, 0xba)) goto l_0x100c_67d6; /* jz 0x100c67d6 */
            ii(0x100c_671c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_671f, 3); mov(al, memb_a32[ds, eax + 0x2]);       /* mov al, [eax+0x2] */
            ii(0x100c_6722, 3); mov(memb_a32[ss, ebp - 0x20], al);      /* mov [ebp-0x20], al */
            ii(0x100c_6725, 5); jmpd(0x100c_67b4, 0x8a); goto l_0x100c_67b4; /* jmp 0x100c67b4 */
        //  ii(0x100c_672a, 108); Недостижимый код.
        l_0x100c_6796:
            ii(0x100c_6796, 2); jmpd(0x100c_67d1, 0x39); goto l_0x100c_67d1; /* jmp 0x100c67d1 */
        //  ii(0x100c_6798, 28); Недостижимый код.
        l_0x100c_67b4:
            ii(0x100c_67b4, 3); mov(al, memb_a32[ss, ebp - 0x20]);      /* mov al, [ebp-0x20] */
            ii(0x100c_67b7, 2); sub(al, 0x2);                           /* sub al, 0x2 */
            ii(0x100c_67b9, 3); mov(memb_a32[ss, ebp - 0x24], al);      /* mov [ebp-0x24], al */
            ii(0x100c_67bc, 4); cmp(memb_a32[ss, ebp - 0x24], 0x6);     /* cmp byte [ebp-0x24], 0x6 */
            ii(0x100c_67c0, 2); if(jad(0x100c_6796, -0x2c)) goto l_0x100c_6796; /* ja 0x100c6796 */
            ii(0x100c_67c2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_67c4, 3); mov(al, memb_a32[ss, ebp - 0x24]);      /* mov al, [ebp-0x24] */
            ii(0x100c_67c7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_67ca, 7); jmpd_abs(memd_a32[cs, eax + 0x100c_6798]); return; /* jmp dword [cs:eax+0x100c6798] */
        l_0x100c_67d1:
            ii(0x100c_67d1, 5); jmpd(0x100c_693c, 0x166); goto l_0x100c_693c; /* jmp 0x100c693c */
        l_0x100c_67d6:
            ii(0x100c_67d6, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_67db, 1); pushd(eax);                             /* push eax */
            ii(0x100c_67dc, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x100c_67df, 3); mov(ecx, memd_a32[ds, ecx + 0x79]);     /* mov ecx, [ecx+0x79] */
            ii(0x100c_67e2, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_67e5, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100c_67e8, 3); movsx(ebx, memw_a32[ds, ebx]);          /* movsx ebx, word [ebx] */
            ii(0x100c_67eb, 5); mov(edx, 0x3a);                         /* mov edx, 0x3a */
            ii(0x100c_67f0, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_67f3, 5); calld(0x100c_6542, -0x2b6);             /* call 0x100c6542 */
            ii(0x100c_67f8, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_67fd, 1); pushd(eax);                             /* push eax */
            ii(0x100c_67fe, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x100c_6801, 3); mov(ecx, memd_a32[ds, ecx + 0x79]);     /* mov ecx, [ecx+0x79] */
            ii(0x100c_6804, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_6807, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100c_680a, 3); movsx(ebx, memw_a32[ds, ebx]);          /* movsx ebx, word [ebx] */
            ii(0x100c_680d, 5); mov(edx, 0x4f);                         /* mov edx, 0x4f */
            ii(0x100c_6812, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6815, 5); calld(0x100c_6542, -0x2d8);             /* call 0x100c6542 */
            ii(0x100c_681a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_681f, 1); pushd(eax);                             /* push eax */
            ii(0x100c_6820, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x100c_6823, 3); mov(ecx, memd_a32[ds, ecx + 0x79]);     /* mov ecx, [ecx+0x79] */
            ii(0x100c_6826, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_6829, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100c_682c, 3); movsx(ebx, memw_a32[ds, ebx]);          /* movsx ebx, word [ebx] */
            ii(0x100c_682f, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x100c_6834, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6837, 5); calld(0x100c_6542, -0x2fa);             /* call 0x100c6542 */
            ii(0x100c_683c, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_6841, 1); pushd(eax);                             /* push eax */
            ii(0x100c_6842, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x100c_6845, 3); mov(ecx, memd_a32[ds, ecx + 0x79]);     /* mov ecx, [ecx+0x79] */
            ii(0x100c_6848, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_684b, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100c_684e, 3); movsx(ebx, memw_a32[ds, ebx]);          /* movsx ebx, word [ebx] */
            ii(0x100c_6851, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_6856, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6859, 5); calld(0x100c_6542, -0x31c);             /* call 0x100c6542 */
            ii(0x100c_685e, 5); mov(edx, 0x43);                         /* mov edx, 0x43 */
            ii(0x100c_6863, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_6866, 3); mov(eax, memd_a32[ds, eax + 0x79]);     /* mov eax, [eax+0x79] */
            ii(0x100c_6869, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_686c, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_6872, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x100c_6877, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_6879, 5); calld(0x100d_fd2c, 0x194ae);            /* call 0x100dfd2c */
            ii(0x100c_687e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_6880, 5); mov(edx, 0x42);                         /* mov edx, 0x42 */
            ii(0x100c_6885, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_6888, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_688b, 6); imul(ecx, eax, 0x247);                  /* imul ecx, eax, 0x247 */
            ii(0x100c_6891, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x100c_6896, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100c_6898, 5); calld(0x100d_fd2c, 0x1948f);            /* call 0x100dfd2c */
            ii(0x100c_689d, 4); mov(dx, memw_a32[ds, ebx + 0x17]);      /* mov dx, [ebx+0x17] */
            ii(0x100c_68a1, 4); cmp(dx, memw_a32[ds, eax + 0x17]);      /* cmp dx, [eax+0x17] */
            ii(0x100c_68a5, 2); if(jld(0x100c_68b9, 0x12)) goto l_0x100c_68b9; /* jl 0x100c68b9 */
            ii(0x100c_68a7, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_68ac, 5); mov(edx, 0x42);                         /* mov edx, 0x42 */
            ii(0x100c_68b1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_68b4, 5); calld(0x100c_64f5, -0x3c4);             /* call 0x100c64f5 */
        l_0x100c_68b9:
            ii(0x100c_68b9, 5); mov(edx, 0x45);                         /* mov edx, 0x45 */
            ii(0x100c_68be, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_68c1, 3); mov(eax, memd_a32[ds, eax + 0x79]);     /* mov eax, [eax+0x79] */
            ii(0x100c_68c4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_68c7, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_68cd, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x100c_68d2, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_68d4, 5); calld(0x100d_fd2c, 0x19453);            /* call 0x100dfd2c */
            ii(0x100c_68d9, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_68db, 5); mov(edx, 0x47);                         /* mov edx, 0x47 */
            ii(0x100c_68e0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_68e3, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_68e6, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_68ec, 5); mov(ecx, 0x101c_a468);                  /* mov ecx, 0x101ca468 */
            ii(0x100c_68f1, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100c_68f3, 5); calld(0x100d_fd2c, 0x19434);            /* call 0x100dfd2c */
            ii(0x100c_68f8, 4); mov(dx, memw_a32[ds, ebx + 0x17]);      /* mov dx, [ebx+0x17] */
            ii(0x100c_68fc, 4); cmp(dx, memw_a32[ds, eax + 0x17]);      /* cmp dx, [eax+0x17] */
            ii(0x100c_6900, 2); if(jld(0x100c_6914, 0x12)) goto l_0x100c_6914; /* jl 0x100c6914 */
            ii(0x100c_6902, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_6907, 5); mov(edx, 0x47);                         /* mov edx, 0x47 */
            ii(0x100c_690c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_690f, 5); calld(0x100c_64f5, -0x41f);             /* call 0x100c64f5 */
        l_0x100c_6914:
            ii(0x100c_6914, 5); calld(0x100c_aef4, 0x45db);             /* call 0x100caef4 */
            ii(0x100c_6919, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_691b, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_691d, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100c_6920, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100c_6923, 5); calld(0x100c_ae64, 0x453c);             /* call 0x100cae64 */
            ii(0x100c_6928, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_692a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_692d, 5); calld(0x100c_7177, 0x845);              /* call 0x100c7177 */
            ii(0x100c_6932, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_6934, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100c_6937, 5); calld(0x100c_a6a0, 0x3d64);             /* call 0x100ca6a0 */
        l_0x100c_693c:
            ii(0x100c_693c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_693f, 5); calld(0x100c_ae28, 0x44e4);             /* call 0x100cae28 */
            ii(0x100c_6944, 1); cwde();                                 /* cwde */
            ii(0x100c_6945, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_6947, 6); jnzd_func(0x100c_7115, 0x7c8);          /* jnz 0x100c7115 */
            ii(0x100c_694d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_6950, 3); mov(al, memb_a32[ds, eax + 0x2]);       /* mov al, [eax+0x2] */
            ii(0x100c_6953, 3); mov(memb_a32[ss, ebp - 0x2c], al);      /* mov [ebp-0x2c], al */
            ii(0x100c_6956, 5); jmpd_func(0x100c_70f8, 0x79d); return;  /* jmp 0x100c70f8 */
        }
    }
}
