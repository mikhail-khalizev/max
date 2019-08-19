using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_5f4d-8ffd03e8")]
        public void Method_1008_5f4d()
        {
            ii(0x1008_5f4d, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x1008_5f52, 5); calld(Definitions.sys_check_available_stack_size, 0xd_fdfb); /* call 0x10165d52 */
            ii(0x1008_5f57, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_5f58, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_5f59, 1); pushd(edx);                             /* push edx */
            ii(0x1008_5f5a, 1); pushd(esi);                             /* push esi */
            ii(0x1008_5f5b, 1); pushd(edi);                             /* push edi */
            ii(0x1008_5f5c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_5f5d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_5f5f, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1008_5f65, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_5f68, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_5f6b, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_5f6e, 5); calld(0x1008_9d08, 0x3d95);             /* call 0x10089d08 */
            ii(0x1008_5f73, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x1008_5f76, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_5f78, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_5f7a, 5); calld(0x1008_9be4, 0x3c65);             /* call 0x10089be4 */
            ii(0x1008_5f7f, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1008_5f83, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_5f86, 5); calld(0x1007_64fc, -0xfa8f);            /* call 0x100764fc */
            ii(0x1008_5f8b, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_5f8e, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1008_5f92, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1008_5f99, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1008_5fa0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5fa2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_5fa5, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_5fa8, 5); calld(0x1013_ad71, 0xb_4dc4);           /* call 0x1013ad71 */
            ii(0x1008_5fad, 2); test(al, al);                           /* test al, al */
            ii(0x1008_5faf, 2); if(jzd(0x1008_5fce, 0x1d)) goto l_0x1008_5fce; /* jz 0x10085fce */
            ii(0x1008_5fb1, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_5fb5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5fb7, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_5fba, 5); calld(0x1007_5f6c, -0x1_0053);          /* call 0x10075f6c */
            ii(0x1008_5fbf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5fc1, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_5fc4, 5); calld(0x1008_9044, 0x307b);             /* call 0x10089044 */
            ii(0x1008_5fc9, 5); jmpd(0x1008_60d1, 0x103); goto l_0x1008_60d1; /* jmp 0x100860d1 */
        l_0x1008_5fce:
            ii(0x1008_5fce, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x1008_5fd1, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1008_5fd4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_5fd7, 5); calld(0x1008_2de2, -0x31fa);            /* call 0x10082de2 */
            ii(0x1008_5fdc, 2); jmpd(0x1008_5fe6, 0x8); goto l_0x1008_5fe6; /* jmp 0x10085fe6 */
        l_0x1008_5fde:
            ii(0x1008_5fde, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_5fe1, 5); calld(0x1007_6bf8, -0xf3ee);            /* call 0x10076bf8 */
        l_0x1008_5fe6:
            ii(0x1008_5fe6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5fe8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_5feb, 5); calld(0x1013_ad71, 0xb_4d81);           /* call 0x1013ad71 */
            ii(0x1008_5ff0, 2); test(al, al);                           /* test al, al */
            ii(0x1008_5ff2, 6); if(jzd(0x1008_60a3, 0xab)) goto l_0x1008_60a3; /* jz 0x100860a3 */
            ii(0x1008_5ff8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_5ffb, 5); calld(0x1008_9acc, 0x3acc);             /* call 0x10089acc */
            ii(0x1008_6000, 5); calld(0x1008_9fc4, 0x3fbf);             /* call 0x10089fc4 */
            ii(0x1008_6005, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6007, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_600a, 5); calld(0x1007_643c, -0xfbd3);            /* call 0x1007643c */
            ii(0x1008_600f, 2); jmpd(0x1008_6019, 0x8); goto l_0x1008_6019; /* jmp 0x10086019 */
        l_0x1008_6011:
            ii(0x1008_6011, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_6014, 5); calld(0x1007_6bf8, -0xf421);            /* call 0x10076bf8 */
        l_0x1008_6019:
            ii(0x1008_6019, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_601b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_601e, 5); calld(0x1013_ad71, 0xb_4d4e);           /* call 0x1013ad71 */
            ii(0x1008_6023, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6025, 6); if(jzd(0x1008_609e, 0x73)) goto l_0x1008_609e; /* jz 0x1008609e */
            ii(0x1008_602b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_602e, 5); calld(0x1007_63a0, -0xfc93);            /* call 0x100763a0 */
            ii(0x1008_6033, 5); calld(0x1007_623c, -0xfdfc);            /* call 0x1007623c */
            ii(0x1008_6038, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1008_603b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_603e, 5); calld(0x1007_63a0, -0xfca3);            /* call 0x100763a0 */
            ii(0x1008_6043, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x1008_6047, 2); if(jzd(0x1008_6072, 0x29)) goto l_0x1008_6072; /* jz 0x10086072 */
            ii(0x1008_6049, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_604c, 4); mov(ax, memw_a32[ds, eax + 0x17]);      /* mov ax, [eax+0x17] */
            ii(0x1008_6050, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x1008_6054, 2); if(jld(0x1008_6070, 0x1a)) goto l_0x1008_6070; /* jl 0x10086070 */
            ii(0x1008_6056, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_605a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_605c, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_605f, 5); calld(0x1007_5f6c, -0x1_00f8);          /* call 0x10075f6c */
            ii(0x1008_6064, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6066, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_6069, 5); calld(0x1008_9044, 0x2fd6);             /* call 0x10089044 */
            ii(0x1008_606e, 2); jmpd(0x1008_60d1, 0x61); goto l_0x1008_60d1; /* jmp 0x100860d1 */
        l_0x1008_6070:
            ii(0x1008_6070, 2); jmpd(0x1008_6099, 0x27); goto l_0x1008_6099; /* jmp 0x10086099 */
        l_0x1008_6072:
            ii(0x1008_6072, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_6075, 4); mov(ax, memw_a32[ds, eax + 0x17]);      /* mov ax, [eax+0x17] */
            ii(0x1008_6079, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x1008_607d, 2); if(jld(0x1008_6099, 0x1a)) goto l_0x1008_6099; /* jl 0x10086099 */
            ii(0x1008_607f, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_6083, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6085, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_6088, 5); calld(0x1007_5f6c, -0x1_0121);          /* call 0x10075f6c */
            ii(0x1008_608d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_608f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_6092, 5); calld(0x1008_9044, 0x2fad);             /* call 0x10089044 */
            ii(0x1008_6097, 2); jmpd(0x1008_60d1, 0x38); goto l_0x1008_60d1; /* jmp 0x100860d1 */
        l_0x1008_6099:
            ii(0x1008_6099, 5); jmpd(0x1008_6011, -0x8d); goto l_0x1008_6011; /* jmp 0x10086011 */
        l_0x1008_609e:
            ii(0x1008_609e, 5); jmpd(0x1008_5fde, -0xc5); goto l_0x1008_5fde; /* jmp 0x10085fde */
        l_0x1008_60a3:
            ii(0x1008_60a3, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_60a7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_60a9, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_60ac, 5); calld(0x1007_5f6c, -0x1_0145);          /* call 0x10075f6c */
            ii(0x1008_60b1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_60b3, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_60b6, 5); calld(0x1008_9044, 0x2f89);             /* call 0x10089044 */
            ii(0x1008_60bb, 2); jmpd(0x1008_60d1, 0x14); goto l_0x1008_60d1; /* jmp 0x100860d1 */
        //  ii(0x1008_60bd, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_60bf, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
        //  ii(0x1008_60c2, 5); calld(0x1007_5f6c, -0x1_015b);          /* call 0x10075f6c */
        //  ii(0x1008_60c7, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_60c9, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
        //  ii(0x1008_60cc, 5); calld(0x1008_9044, 0x2f73);             /* call 0x10089044 */
        l_0x1008_60d1:
            ii(0x1008_60d1, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_60d4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_60d6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_60d7, 1); popd(edi);                              /* pop edi */
            ii(0x1008_60d8, 1); popd(esi);                              /* pop esi */
            ii(0x1008_60d9, 1); popd(edx);                              /* pop edx */
            ii(0x1008_60da, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_60db, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_60dc, 1); retd(); return;                         /* ret */
        }
    }
}
