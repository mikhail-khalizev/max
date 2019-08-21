using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_602e-e0574a00")]
        public void Method_1013_602e()
        {
            ii(0x1013_602e, 5); pushd(0x50);                            /* push 0x50 */
            ii(0x1013_6033, 5); calld(Definitions.sys_check_available_stack_size, 0x2_fd1a); /* call 0x10165d52 */
            ii(0x1013_6038, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_6039, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_603a, 1); pushd(edx);                             /* push edx */
            ii(0x1013_603b, 1); pushd(esi);                             /* push esi */
            ii(0x1013_603c, 1); pushd(edi);                             /* push edi */
            ii(0x1013_603d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_603e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_6040, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1013_6046, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_6049, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1013_604d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1013_6050, 5); calld(Definitions.my_ctor_0x101b_38d0, -0xb_f811); /* call 0x10076844 */
            ii(0x1013_6055, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1013_6058, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1013_605c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_605f, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_6062, 2); jmpd(0x1013_60a8, 0x44); goto l_0x1013_60a8; /* jmp 0x101360a8 */
        l_0x1013_6064:
            ii(0x1013_6064, 7); mov(memd_a32[ss, ebp - 0x20], 0x101c_61b4); /* mov dword [ebp-0x20], 0x101c61b4 */
            ii(0x1013_606b, 2); jmpd(0x1013_60c5, 0x58); goto l_0x1013_60c5; /* jmp 0x101360c5 */
        l_0x1013_606d:
            ii(0x1013_606d, 7); mov(memd_a32[ss, ebp - 0x20], 0x101c_64b0); /* mov dword [ebp-0x20], 0x101c64b0 */
            ii(0x1013_6074, 2); jmpd(0x1013_60c5, 0x4f); goto l_0x1013_60c5; /* jmp 0x101360c5 */
        l_0x1013_6076:
            ii(0x1013_6076, 7); mov(memd_a32[ss, ebp - 0x20], 0x101c_67ac); /* mov dword [ebp-0x20], 0x101c67ac */
            ii(0x1013_607d, 2); jmpd(0x1013_60c5, 0x46); goto l_0x1013_60c5; /* jmp 0x101360c5 */
        l_0x1013_607f:
            ii(0x1013_607f, 7); mov(memd_a32[ss, ebp - 0x20], 0x101c_6aa8); /* mov dword [ebp-0x20], 0x101c6aa8 */
            ii(0x1013_6086, 2); jmpd(0x1013_60c5, 0x3d); goto l_0x1013_60c5; /* jmp 0x101360c5 */
        l_0x1013_6088:
            ii(0x1013_6088, 7); mov(memd_a32[ss, ebp - 0x20], 0x101c_6da4); /* mov dword [ebp-0x20], 0x101c6da4 */
            ii(0x1013_608f, 2); jmpd(0x1013_60c5, 0x34); goto l_0x1013_60c5; /* jmp 0x101360c5 */
        l_0x1013_6091:
            ii(0x1013_6091, 2); jmpd(0x1013_60c5, 0x32); goto l_0x1013_60c5; /* jmp 0x101360c5 */
        //  ii(0x1013_6093, 1); nop();                                  /* nop */
        //  ii(0x1013_6094, 20); /* Служебная область с абсолютными адресами переходов. {0x1013_6064, 0x1013_606d, 0x1013_6076, 0x1013_607f, 0x1013_6088}. */
        l_0x1013_60a8:
            ii(0x1013_60a8, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_60ab, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1013_60ae, 5); cmp(memw_a32[ss, ebp - 0x24], 0x4);     /* cmp word [ebp-0x24], 0x4 */
            ii(0x1013_60b3, 2); if(jad(0x1013_6091, -0x24)) goto l_0x1013_6091; /* ja 0x10136091 */
            ii(0x1013_60b5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_60b7, 4); mov(ax, memw_a32[ss, ebp - 0x24]);      /* mov ax, [ebp-0x24] */
            ii(0x1013_60bb, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_60be, 7); 
            switch (jmpd_abs_switch(memd_a32[cs, eax + 0x1013_6094]))
            {
                case 0x1013_6064:
                    goto l_0x1013_6064;
                case 0x1013_606d:
                    goto l_0x1013_606d;
                case 0x1013_6076:
                    goto l_0x1013_6076;
                case 0x1013_607f:
                    goto l_0x1013_607f;
                case 0x1013_6088:
                    goto l_0x1013_6088;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x10136094] */
        l_0x1013_60c5:
            ii(0x1013_60c5, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_60c9, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1013_60cc, 2); if(jged(0x1013_60e0, 0x12)) goto l_0x1013_60e0; /* jge 0x101360e0 */
            ii(0x1013_60ce, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1013_60d1, 2); add(al, 0x6b);                          /* add al, 0x6b */
            ii(0x1013_60d3, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1013_60d6, 5); calld(0x1007_5fdc, -0xc_00ff);          /* call 0x10075fdc */
            ii(0x1013_60db, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_60de, 2); jmpd(0x1013_60e7, 0x7); goto l_0x1013_60e7; /* jmp 0x101360e7 */
        l_0x1013_60e0:
            ii(0x1013_60e0, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
        l_0x1013_60e7:
            ii(0x1013_60e7, 5); cmp(memw_a32[ss, ebp - 0xc], 0);        /* cmp word [ebp-0xc], 0x0 */
            ii(0x1013_60ec, 2); if(jnzd(0x1013_610e, 0x20)) goto l_0x1013_610e; /* jnz 0x1013610e */
            ii(0x1013_60ee, 5); calld(/* sys */ 0x1016_5e9b, 0x2_fda8); /* call 0x10165e9b */
            ii(0x1013_60f3, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1013_60f6, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1013_60f9, 1); inc(eax);                               /* inc eax */
            ii(0x1013_60fa, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_60fd, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1013_6101, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1013_6104, 2); add(al, 0x6b);                          /* add al, 0x6b */
            ii(0x1013_6106, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1013_6109, 5); calld(0x100c_aafc, -0x6_b612);          /* call 0x100caafc */
        l_0x1013_610e:
            ii(0x1013_610e, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1013_6112, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1013_6118, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1013_611b, 6); mov(memb_a32[ds, edx + 0x101c_a4ef], al); /* mov [edx+0x101ca4ef], al */
            ii(0x1013_6121, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_6124, 5); calld(0x1013_65a4, 0x47b);              /* call 0x101365a4 */
            ii(0x1013_6129, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_612c, 5); calld(0x1013_3cdc, -0x2455);            /* call 0x10133cdc */
            ii(0x1013_6131, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_6138, 2); jmpd(0x1013_6140, 0x6); goto l_0x1013_6140; /* jmp 0x10136140 */
        l_0x1013_613a:
            ii(0x1013_613a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_613d, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x1013_6140:
            ii(0x1013_6140, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1013_6144, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x1013_6147, 6); if(jged(0x1013_61e6, 0x99)) goto l_0x1013_61e6; /* jge 0x101361e6 */
            ii(0x1013_614d, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x1013_6152, 5); calld(Definitions.sys_new, 0x2_fca9);   /* call 0x10165e00 */
            ii(0x1013_6157, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1013_615a, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1013_615d, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1013_6160, 4); cmp(memd_a32[ss, ebp - 0x2c], 0);       /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1013_6164, 2); if(jzd(0x1013_6189, 0x23)) goto l_0x1013_6189; /* jz 0x10136189 */
            ii(0x1013_6166, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1013_616a, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_616d, 5); calld(0x100c_b6b0, -0x6_aac2);          /* call 0x100cb6b0 */
            ii(0x1013_6172, 3); mov(ebx, memd_a32[ss, ebp - 0x28]);     /* mov ebx, [ebp-0x28] */
            ii(0x1013_6175, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_6177, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1013_6179, 5); calld(0x100c_a2f8, -0x6_be86);          /* call 0x100ca2f8 */
            ii(0x1013_617e, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1013_6181, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1013_6184, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1013_6187, 2); jmpd(0x1013_618f, 0x6); goto l_0x1013_618f; /* jmp 0x1013618f */
        l_0x1013_6189:
            ii(0x1013_6189, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1013_618c, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x1013_618f:
            ii(0x1013_618f, 3); mov(edx, memd_a32[ss, ebp - 0x34]);     /* mov edx, [ebp-0x34] */
            ii(0x1013_6192, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1013_6195, 5); calld(0x100c_b77c, -0x6_aa1e);          /* call 0x100cb77c */
            ii(0x1013_619a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1013_619d, 5); calld(0x100c_b74c, -0x6_aa56);          /* call 0x100cb74c */
            ii(0x1013_61a2, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1013_61a6, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1013_61aa, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_61ac, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1013_61ae, 5); calld(0x1013_5fcc, -0x1e7);             /* call 0x10135fcc */
            ii(0x1013_61b3, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1013_61b6, 5); calld(0x100c_b74c, -0x6_aa6f);          /* call 0x100cb74c */
            ii(0x1013_61bb, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1013_61bf, 3); mov(ecx, memd_a32[ss, ebp - 0x20]);     /* mov ecx, [ebp-0x20] */
            ii(0x1013_61c2, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_61c4, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1013_61c6, 5); calld(0x1013_6564, 0x399);              /* call 0x10136564 */
            ii(0x1013_61cb, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1013_61ce, 5); calld(0x100c_b74c, -0x6_aa87);          /* call 0x100cb74c */
            ii(0x1013_61d3, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_61d5, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1013_61d9, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_61dc, 5); calld(0x100c_b63c, -0x6_aba5);          /* call 0x100cb63c */
            ii(0x1013_61e1, 5); jmpd(0x1013_613a, -0xac); goto l_0x1013_613a; /* jmp 0x1013613a */
        l_0x1013_61e6:
            ii(0x1013_61e6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_61e8, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1013_61eb, 5); calld(0x1007_5eec, -0xc_0304);          /* call 0x10075eec */
            ii(0x1013_61f0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_61f2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_61f3, 1); popd(edi);                              /* pop edi */
            ii(0x1013_61f4, 1); popd(esi);                              /* pop esi */
            ii(0x1013_61f5, 1); popd(edx);                              /* pop edx */
            ii(0x1013_61f6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_61f7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_61f8, 1); retd(); return;                         /* ret */
        }
    }
}
