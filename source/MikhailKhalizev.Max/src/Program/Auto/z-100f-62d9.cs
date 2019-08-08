using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c26b4375-e33c-4c77-afc4-e0b2e10f7bd7")]
        public void Method_100f_62d9()
        {
            ii(0x100f_62d9, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100f_62de, 5); calld(Definitions.sys_check_available_stack_size, 0x6_fa6f); /* call 0x10165d52 */
            ii(0x100f_62e3, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_62e4, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_62e5, 1); pushd(edx);                             /* push edx */
            ii(0x100f_62e6, 1); pushd(esi);                             /* push esi */
            ii(0x100f_62e7, 1); pushd(edi);                             /* push edi */
            ii(0x100f_62e8, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_62e9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_62eb, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100f_62f1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_62f3, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_62f8, 6); imul(edx, eax, 0x247);                  /* imul edx, eax, 0x247 */
            ii(0x100f_62fe, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x100f_6303, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_6305, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_6308, 5); calld(/* sys */ 0x1016_b208, 0x7_4efb); /* call 0x1016b208 */
            ii(0x100f_630d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_6310, 7); cmp(memd_a32[ds, 0x101c_3940], 0);      /* cmp dword [0x101c3940], 0x0 */
            ii(0x100f_6317, 2); if(jzd(0x100f_632b, 0x12)) goto l_0x100f_632b; /* jz 0x100f632b */
            ii(0x100f_6319, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_631d, 5); mov(eax, memd_a32[ds, 0x101c_3940]);    /* mov eax, [0x101c3940] */
            ii(0x100f_6322, 5); calld(0x100e_b283, -0xb0a4);            /* call 0x100eb283 */
            ii(0x100f_6327, 2); test(al, al);                           /* test al, al */
            ii(0x100f_6329, 2); if(jnzd(0x100f_6330, 0x5)) goto l_0x100f_6330; /* jnz 0x100f6330 */
        l_0x100f_632b:
            ii(0x100f_632b, 5); jmpd(0x100f_63a4, 0x74); goto l_0x100f_63a4; /* jmp 0x100f63a4 */
        l_0x100f_6330:
            ii(0x100f_6330, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_6334, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x100f_6337, 2); if(jnzd(0x100f_639d, 0x64)) goto l_0x100f_639d; /* jnz 0x100f639d */
            ii(0x100f_6339, 5); mov(edx, 0x101c_3944);                  /* mov edx, 0x101c3944 */
            ii(0x100f_633e, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_6343, 5); calld(0x1007_6574, -0x7_fdd4);          /* call 0x10076574 */
            ii(0x100f_6348, 5); calld(0x1014_fabe, 0x5_9771);           /* call 0x1014fabe */
            ii(0x100f_634d, 5); mov(eax, memd_a32[ds, 0x101c_3940]);    /* mov eax, [0x101c3940] */
            ii(0x100f_6352, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_6355, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100f_6359, 2); if(jzd(0x100f_636f, 0x14)) goto l_0x100f_636f; /* jz 0x100f636f */
            ii(0x100f_635b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_635d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_6360, 5); calld(Definitions.my_dtor_d6, -0xb28e); /* call 0x100eb0d7 */
            ii(0x100f_6365, 5); calld(Definitions.sys_delete, 0x6_fbfa); /* call 0x10165f64 */
            ii(0x100f_636a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_636d, 2); jmpd(0x100f_6376, 0x7); goto l_0x100f_6376; /* jmp 0x100f6376 */
        l_0x100f_636f:
            ii(0x100f_636f, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x100f_6376:
            ii(0x100f_6376, 10); mov(memd_a32[ds, 0x101c_3940], 0);     /* mov dword [0x101c3940], 0x0 */
            ii(0x100f_6380, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_6387, 2); if(jzd(0x100f_639d, 0x14)) goto l_0x100f_639d; /* jz 0x100f639d */
            ii(0x100f_6389, 5); mov(edx, 0x101c_3944);                  /* mov edx, 0x101c3944 */
            ii(0x100f_638e, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_6393, 5); calld(0x1007_65d0, -0x7_fdc8);          /* call 0x100765d0 */
            ii(0x100f_6398, 5); calld(0x1012_b0af, 0x3_4d12);           /* call 0x1012b0af */
        l_0x100f_639d:
            ii(0x100f_639d, 7); mov(memd_a32[ss, ebp - 0x4], 0xffff_ffff); /* mov dword [ebp-0x4], 0xffffffff */
        l_0x100f_63a4:
            ii(0x100f_63a4, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_63a8, 5); calld(0x100f_6198, -0x215);             /* call 0x100f6198 */
            ii(0x100f_63ad, 2); test(al, al);                           /* test al, al */
            ii(0x100f_63af, 2); if(jzd(0x100f_63b8, 0x7)) goto l_0x100f_63b8; /* jz 0x100f63b8 */
            ii(0x100f_63b1, 7); mov(memd_a32[ss, ebp - 0x4], 0xffff_ffff); /* mov dword [ebp-0x4], 0xffffffff */
        l_0x100f_63b8:
            ii(0x100f_63b8, 5); calld(0x1014_82f4, 0x5_1f37);           /* call 0x101482f4 */
            ii(0x100f_63bd, 5); mov(memd_a32[ds, 0x101c_3930], eax);    /* mov [0x101c3930], eax */
            ii(0x100f_63c2, 5); mov(al, memb_a32[ds, 0x1020_946a]);     /* mov al, [0x1020946a] */
            ii(0x100f_63c7, 6); or(al, memb_a32[ds, 0x1020_9476]);      /* or al, [0x10209476] */
            ii(0x100f_63cd, 5); mov(memb_a32[ds, 0x101c_3918], al);     /* mov [0x101c3918], al */
            ii(0x100f_63d2, 5); mov(al, memb_a32[ds, 0x1020_945d]);     /* mov al, [0x1020945d] */
            ii(0x100f_63d7, 6); or(al, memb_a32[ds, 0x1020_94dd]);      /* or al, [0x102094dd] */
            ii(0x100f_63dd, 5); mov(memb_a32[ds, 0x101c_3917], al);     /* mov [0x101c3917], al */
            ii(0x100f_63e2, 7); cmp(memb_a32[ds, 0x101c_37d2], 0);      /* cmp byte [0x101c37d2], 0x0 */
            ii(0x100f_63e9, 6); if(jzd(0x100f_64d4, 0xe5)) goto l_0x100f_64d4; /* jz 0x100f64d4 */
            ii(0x100f_63ef, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_63f1, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_63f6, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_63fc, 6); mov(al, memb_a32[ds, eax + 0x101c_a491]); /* mov al, [eax+0x101ca491] */
            ii(0x100f_6402, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_6407, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_6409, 6); if(jnzd(0x100f_647d, 0x6e)) goto l_0x100f_647d; /* jnz 0x100f647d */
            ii(0x100f_640f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6411, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_6416, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_641c, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_6422, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_6427, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_642a, 2); if(jzd(0x100f_6449, 0x1d)) goto l_0x100f_6449; /* jz 0x100f6449 */
            ii(0x100f_642c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_642e, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_6433, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_6439, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_643f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_6444, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100f_6447, 2); if(jnzd(0x100f_647b, 0x32)) goto l_0x100f_647b; /* jnz 0x100f647b */
        l_0x100f_6449:
            ii(0x100f_6449, 5); calld(0x100f_fc13, 0x97c5);             /* call 0x100ffc13 */
            ii(0x100f_644e, 7); cmp(memb_a32[ds, 0x101c_391d], 0);      /* cmp byte [0x101c391d], 0x0 */
            ii(0x100f_6455, 2); if(jzd(0x100f_6460, 0x9)) goto l_0x100f_6460; /* jz 0x100f6460 */
            ii(0x100f_6457, 7); mov(memd_a32[ss, ebp - 0x4], 0x1b);     /* mov dword [ebp-0x4], 0x1b */
            ii(0x100f_645e, 2); jmpd(0x100f_647b, 0x1b); goto l_0x100f_647b; /* jmp 0x100f647b */
        l_0x100f_6460:
            ii(0x100f_6460, 7); cmp(memb_a32[ds, 0x101c_37d4], 0);      /* cmp byte [0x101c37d4], 0x0 */
            ii(0x100f_6467, 2); if(jnzd(0x100f_6472, 0x9)) goto l_0x100f_6472; /* jnz 0x100f6472 */
            ii(0x100f_6469, 7); cmp(memb_a32[ds, 0x101c_3913], 0);      /* cmp byte [0x101c3913], 0x0 */
            ii(0x100f_6470, 2); if(jzd(0x100f_6474, 0x2)) goto l_0x100f_6474; /* jz 0x100f6474 */
        l_0x100f_6472:
            ii(0x100f_6472, 2); jmpd(0x100f_647b, 0x7); goto l_0x100f_647b; /* jmp 0x100f647b */
        l_0x100f_6474:
            ii(0x100f_6474, 7); mov(memd_a32[ss, ebp - 0x4], 0x3eb);    /* mov dword [ebp-0x4], 0x3eb */
        l_0x100f_647b:
            ii(0x100f_647b, 2); jmpd(0x100f_64d4, 0x57); goto l_0x100f_64d4; /* jmp 0x100f64d4 */
        l_0x100f_647d:
            ii(0x100f_647d, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100f_6484, 2); jmpd(0x100f_648c, 0x6); goto l_0x100f_648c; /* jmp 0x100f648c */
        l_0x100f_6486:
            ii(0x100f_6486, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_6489, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x100f_648c:
            ii(0x100f_648c, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_6490, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100f_6493, 2); if(jged(0x100f_64d4, 0x3f)) goto l_0x100f_64d4; /* jge 0x100f64d4 */
            ii(0x100f_6495, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_6499, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_649f, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_64a5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_64aa, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100f_64ad, 2); if(jnzd(0x100f_64c2, 0x13)) goto l_0x100f_64c2; /* jnz 0x100f64c2 */
            ii(0x100f_64af, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_64b3, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_64b9, 7); cmp(memb_a32[ds, eax + 0x101c_a491], 0); /* cmp byte [eax+0x101ca491], 0x0 */
            ii(0x100f_64c0, 2); if(jzd(0x100f_64c4, 0x2)) goto l_0x100f_64c4; /* jz 0x100f64c4 */
        l_0x100f_64c2:
            ii(0x100f_64c2, 2); jmpd(0x100f_64d2, 0xe); goto l_0x100f_64d2; /* jmp 0x100f64d2 */
        l_0x100f_64c4:
            ii(0x100f_64c4, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100f_64c9, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_64cd, 5); calld(0x1010_26f8, 0xc226);             /* call 0x101026f8 */
        l_0x100f_64d2:
            ii(0x100f_64d2, 2); jmpd(0x100f_6486, -0x4e); goto l_0x100f_6486; /* jmp 0x100f6486 */
        l_0x100f_64d4:
            ii(0x100f_64d4, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_64d8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_64da, 2); if(jled(0x100f_64e7, 0xb)) goto l_0x100f_64e7; /* jle 0x100f64e7 */
            ii(0x100f_64dc, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_64e0, 5); cmp(eax, 0x7000);                       /* cmp eax, 0x7000 */
            ii(0x100f_64e5, 2); if(jld(0x100f_64e9, 0x2)) goto l_0x100f_64e9; /* jl 0x100f64e9 */
        l_0x100f_64e7:
            ii(0x100f_64e7, 2); jmpd(0x100f_64f0, 0x7); goto l_0x100f_64f0; /* jmp 0x100f64f0 */
        l_0x100f_64e9:
            ii(0x100f_64e9, 7); mov(memb_a32[ds, 0x101c_3890], 0);      /* mov byte [0x101c3890], 0x0 */
        l_0x100f_64f0:
            ii(0x100f_64f0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_64f3, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100f_64f6, 5); jmpd(0x100f_6d2f, 0x834); goto l_0x100f_6d2f; /* jmp 0x100f6d2f */
        l_0x100f_64fb:
            ii(0x100f_64fb, 5); mov(edx, StringDefinitions.Control26);  /* mov edx, 0x101a25e3 */
            ii(0x100f_6500, 5); mov(eax, 0x101c_39b4);                  /* mov eax, 0x101c39b4 */
            ii(0x100f_6505, 5); calld(0x1014_21cb, 0x4_bcc1);           /* call 0x101421cb */
            ii(0x100f_650a, 5); jmpd(0x100f_70a5, 0xb96); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_650f:
            ii(0x100f_650f, 7); cmp(memb_a32[ds, 0x101c_3916], 0);      /* cmp byte [0x101c3916], 0x0 */
            ii(0x100f_6516, 2); if(jnzd(0x100f_6535, 0x1d)) goto l_0x100f_6535; /* jnz 0x100f6535 */
            ii(0x100f_6518, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_651a, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_651f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_6525, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_652b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_6530, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_6533, 2); if(jzd(0x100f_6537, 0x2)) goto l_0x100f_6537; /* jz 0x100f6537 */
        l_0x100f_6535:
            ii(0x100f_6535, 2); jmpd(0x100f_653c, 0x5); goto l_0x100f_653c; /* jmp 0x100f653c */
        l_0x100f_6537:
            ii(0x100f_6537, 5); jmpd(0x100f_70a5, 0xb69); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_653c:
            ii(0x100f_653c, 5); mov(eax, memd_a32[ds, 0x101c_38b6]);    /* mov eax, [0x101c38b6] */
            ii(0x100f_6541, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_6544, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x100f_6547, 6); if(jzd(0x100f_65dc, 0x8f)) goto l_0x100f_65dc; /* jz 0x100f65dc */
            ii(0x100f_654d, 5); calld(0x100f_40a6, -0x24ac);            /* call 0x100f40a6 */
            ii(0x100f_6552, 5); calld(0x1010_2acc, 0xc575);             /* call 0x10102acc */
            ii(0x100f_6557, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_6559, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x100f_655b, 6); mov(ebx, memd_a32[ds, 0x101c_38b8]);    /* mov ebx, [0x101c38b8] */
            ii(0x100f_6561, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_6564, 6); mov(edx, memd_a32[ds, 0x101c_38b6]);    /* mov edx, [0x101c38b6] */
            ii(0x100f_656a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_656d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_6572, 5); calld(0x1010_1620, 0xb0a9);             /* call 0x10101620 */
            ii(0x100f_6577, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_6579, 5); mov(eax, 0x101c_38b4);                  /* mov eax, 0x101c38b4 */
            ii(0x100f_657e, 5); calld(0x1013_ad71, 0x4_47ee);           /* call 0x1013ad71 */
            ii(0x100f_6583, 2); test(al, al);                           /* test al, al */
            ii(0x100f_6585, 2); if(jzd(0x100f_65a4, 0x1d)) goto l_0x100f_65a4; /* jz 0x100f65a4 */
            ii(0x100f_6587, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6589, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_658e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_6591, 5); mov(eax, 0x101c_38b4);                  /* mov eax, 0x101c38b4 */
            ii(0x100f_6596, 5); calld(0x1007_6574, -0x8_0027);          /* call 0x10076574 */
            ii(0x100f_659b, 5); calld(0x1007_6074, -0x8_052c);          /* call 0x10076074 */
            ii(0x100f_65a0, 2); test(al, al);                           /* test al, al */
            ii(0x100f_65a2, 2); if(jnzd(0x100f_65a6, 0x2)) goto l_0x100f_65a6; /* jnz 0x100f65a6 */
        l_0x100f_65a4:
            ii(0x100f_65a4, 2); jmpd(0x100f_65bc, 0x16); goto l_0x100f_65bc; /* jmp 0x100f65bc */
        l_0x100f_65a6:
            ii(0x100f_65a6, 5); calld(0x1011_606c, 0x1_fac1);           /* call 0x1011606c */
            ii(0x100f_65ab, 5); mov(eax, 0x101c_38b4);                  /* mov eax, 0x101c38b4 */
            ii(0x100f_65b0, 5); calld(0x1007_65d0, -0x7_ffe5);          /* call 0x100765d0 */
            ii(0x100f_65b5, 5); calld(0x100f_f637, 0x907d);             /* call 0x100ff637 */
            ii(0x100f_65ba, 2); jmpd(0x100f_65dc, 0x20); goto l_0x100f_65dc; /* jmp 0x100f65dc */
        l_0x100f_65bc:
            ii(0x100f_65bc, 5); calld(0x100c_aa00, -0x2_bbc1);          /* call 0x100caa00 */
            ii(0x100f_65c1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_65c6, 1); pushd(eax);                             /* push eax */
            ii(0x100f_65c7, 5); calld(0x100c_aa20, -0x2_bbac);          /* call 0x100caa20 */
            ii(0x100f_65cc, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_65ce, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_65d0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_65d2, 5); mov(eax, StringDefinitions.TaggedUnitOutOfRange); /* mov eax, 0x101a25e5 */
            ii(0x100f_65d7, 5); calld(0x1011_5d23, 0x1_f747);           /* call 0x10115d23 */
        l_0x100f_65dc:
            ii(0x100f_65dc, 5); jmpd(0x100f_70a5, 0xac4); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_65e1:
            ii(0x100f_65e1, 7); cmp(memb_a32[ds, 0x101c_3916], 0);      /* cmp byte [0x101c3916], 0x0 */
            ii(0x100f_65e8, 6); if(jzd(0x100f_70a5, 0xab7)) goto l_0x100f_70a5; /* jz 0x100f70a5 */
            ii(0x100f_65ee, 7); add(memd_a32[ss, ebp - 0x4], 0xffff_fec1); /* add dword [ebp-0x4], 0xfffffec1 */
            ii(0x100f_65f5, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_65f9, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_65fb, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100f_65fe, 6); mov(eax, memd_a32[ds, eax + 0xeb]);     /* mov eax, [eax+0xeb] */
            ii(0x100f_6604, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100f_6607, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x100f_660a, 2); if(jzd(0x100f_6647, 0x3b)) goto l_0x100f_6647; /* jz 0x100f6647 */
            ii(0x100f_660c, 5); calld(0x1010_2acc, 0xc4bb);             /* call 0x10102acc */
            ii(0x100f_6611, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_6613, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x100f_6615, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_6619, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_661b, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100f_661e, 8); movsx(ax, memb_a32[ds, eax + 0xef]);    /* movsx ax, byte [eax+0xef] */
            ii(0x100f_6626, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100f_6629, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_662d, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_662f, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100f_6632, 8); movsx(ax, memb_a32[ds, eax + 0xee]);    /* movsx ax, byte [eax+0xee] */
            ii(0x100f_663a, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_663d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_6642, 5); calld(0x1010_1620, 0xafd9);             /* call 0x10101620 */
        l_0x100f_6647:
            ii(0x100f_6647, 5); jmpd(0x100f_70a5, 0xa59); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_664c:
            ii(0x100f_664c, 7); add(memd_a32[ss, ebp - 0x4], 0xffff_fe94); /* add dword [ebp-0x4], 0xfffffe94 */
            ii(0x100f_6653, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_6657, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_6659, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100f_665c, 6); mov(dl, memb_a32[ds, 0x101c_38e2]);     /* mov dl, [0x101c38e2] */
            ii(0x100f_6662, 6); mov(memb_a32[ds, eax + 0xee], dl);      /* mov [eax+0xee], dl */
            ii(0x100f_6668, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_666c, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_666e, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100f_6671, 6); mov(dl, memb_a32[ds, 0x101c_38e4]);     /* mov dl, [0x101c38e4] */
            ii(0x100f_6677, 6); mov(memb_a32[ds, eax + 0xef], dl);      /* mov [eax+0xef], dl */
            ii(0x100f_667d, 5); calld(0x100c_aa00, -0x2_bc82);          /* call 0x100caa00 */
            ii(0x100f_6682, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_6687, 1); pushd(eax);                             /* push eax */
            ii(0x100f_6688, 5); calld(0x100c_aa20, -0x2_bc6d);          /* call 0x100caa20 */
            ii(0x100f_668d, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_668f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_6691, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_6693, 5); mov(eax, StringDefinitions.WindowPositionHasBeenSaved); /* mov eax, 0x101a25ff */
            ii(0x100f_6698, 5); calld(0x1011_5d23, 0x1_f686);           /* call 0x10115d23 */
            ii(0x100f_669d, 5); jmpd(0x100f_70a5, 0xa03); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_66a2:
            ii(0x100f_66a2, 7); or(memb_a32[ds, 0x101c_3900], 0x8);     /* or byte [0x101c3900], 0x8 */
            ii(0x100f_66a9, 5); jmpd(0x100f_70a5, 0x9f7); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_66ae:
            ii(0x100f_66ae, 7); or(memb_a32[ds, 0x101c_3900], 0x4);     /* or byte [0x101c3900], 0x4 */
            ii(0x100f_66b5, 5); jmpd(0x100f_70a5, 0x9eb); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_66ba:
            ii(0x100f_66ba, 7); or(memb_a32[ds, 0x101c_3900], 0x2);     /* or byte [0x101c3900], 0x2 */
            ii(0x100f_66c1, 5); jmpd(0x100f_70a5, 0x9df); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_66c6:
            ii(0x100f_66c6, 7); or(memb_a32[ds, 0x101c_3900], 0x1);     /* or byte [0x101c3900], 0x1 */
            ii(0x100f_66cd, 5); jmpd(0x100f_70a5, 0x9d3); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_66d2:
            ii(0x100f_66d2, 7); cmp(memb_a32[ds, 0x101c_3916], 0);      /* cmp byte [0x101c3916], 0x0 */
            ii(0x100f_66d9, 6); if(jzd(0x100f_70a5, 0x9c6)) goto l_0x100f_70a5; /* jz 0x100f70a5 */
            ii(0x100f_66df, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_66e1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_66e3, 6); mov(ax, memw_a32[ds, 0x101c_38c0]);     /* mov ax, [0x101c38c0] */
            ii(0x100f_66e9, 1); inc(eax);                               /* inc eax */
            ii(0x100f_66ea, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_66ed, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_66ef, 5); calld(0x1010_1620, 0xaf2c);             /* call 0x10101620 */
            ii(0x100f_66f4, 5); jmpd(0x100f_70a5, 0x9ac); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_66f9:
            ii(0x100f_66f9, 7); cmp(memb_a32[ds, 0x101c_3916], 0);      /* cmp byte [0x101c3916], 0x0 */
            ii(0x100f_6700, 6); if(jzd(0x100f_70a5, 0x99f)) goto l_0x100f_70a5; /* jz 0x100f70a5 */
            ii(0x100f_6706, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_6708, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_670a, 6); mov(ax, memw_a32[ds, 0x101c_38c0]);     /* mov ax, [0x101c38c0] */
            ii(0x100f_6710, 1); dec(eax);                               /* dec eax */
            ii(0x100f_6711, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_6714, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6716, 5); calld(0x1010_1620, 0xaf05);             /* call 0x10101620 */
            ii(0x100f_671b, 5); jmpd(0x100f_70a5, 0x985); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6720:
            ii(0x100f_6720, 7); cmp(memb_a32[ds, 0x101c_391e], 0x7);    /* cmp byte [0x101c391e], 0x7 */
            ii(0x100f_6727, 6); if(jnzd(0x100f_67c2, 0x95)) goto l_0x100f_67c2; /* jnz 0x100f67c2 */
            ii(0x100f_672d, 5); calld(0x1011_606c, 0x1_f93a);           /* call 0x1011606c */
            ii(0x100f_6732, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6734, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_6739, 1); cwde();                                 /* cwde */
            ii(0x100f_673a, 5); calld(0x100a_25e5, -0x5_415a);          /* call 0x100a25e5 */
            ii(0x100f_673f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6741, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_6746, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_6749, 7); mov(ax, memw_a32[ds, eax + 0x101c_35bc]); /* mov ax, [eax+0x101c35bc] */
            ii(0x100f_6750, 6); mov(memw_a32[ds, 0x101c_38e2], ax);     /* mov [0x101c38e2], ax */
            ii(0x100f_6756, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6758, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_675d, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_6760, 7); mov(ax, memw_a32[ds, eax + 0x101c_35be]); /* mov ax, [eax+0x101c35be] */
            ii(0x100f_6767, 6); mov(memw_a32[ds, 0x101c_38e4], ax);     /* mov [0x101c38e4], ax */
            ii(0x100f_676d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_676f, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_6774, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_677a, 7); mov(dx, memw_a32[ds, 0x101c_38e2]);     /* mov dx, [0x101c38e2] */
            ii(0x100f_6781, 7); mov(memw_a32[ds, eax + 0x101c_a56c], dx); /* mov [eax+0x101ca56c], dx */
            ii(0x100f_6788, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_678a, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_678f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_6795, 7); mov(dx, memw_a32[ds, 0x101c_38e4]);     /* mov dx, [0x101c38e4] */
            ii(0x100f_679c, 7); mov(memw_a32[ds, eax + 0x101c_a56e], dx); /* mov [eax+0x101ca56e], dx */
            ii(0x100f_67a3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_67a5, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_67aa, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_67b0, 9); mov(memw_a32[ds, eax + 0x101c_a56a], 0x40); /* mov word [eax+0x101ca56a], 0x40 */
            ii(0x100f_67b9, 7); mov(memb_a32[ds, 0x101c_391e], 0xd);    /* mov byte [0x101c391e], 0xd */
            ii(0x100f_67c0, 2); jmpd(0x100f_67d7, 0x15); goto l_0x100f_67d7; /* jmp 0x100f67d7 */
        l_0x100f_67c2:
            ii(0x100f_67c2, 7); cmp(memb_a32[ds, 0x101c_3938], 0);      /* cmp byte [0x101c3938], 0x0 */
            ii(0x100f_67c9, 2); if(jzd(0x100f_67d7, 0xc)) goto l_0x100f_67d7; /* jz 0x100f67d7 */
            ii(0x100f_67cb, 7); mov(memb_a32[ds, 0x101c_391e], 0x3);    /* mov byte [0x101c391e], 0x3 */
            ii(0x100f_67d2, 5); jmpd(0x100f_70a5, 0x8ce); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_67d7:
            ii(0x100f_67d7, 7); cmp(memb_a32[ds, 0x101c_3916], 0);      /* cmp byte [0x101c3916], 0x0 */
            ii(0x100f_67de, 2); if(jzd(0x100f_67f6, 0x16)) goto l_0x100f_67f6; /* jz 0x100f67f6 */
            ii(0x100f_67e0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_67e2, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_67e7, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_67ed, 7); cmp(memb_a32[ds, eax + 0x101c_a491], 0); /* cmp byte [eax+0x101ca491], 0x0 */
            ii(0x100f_67f4, 2); if(jzd(0x100f_67fb, 0x5)) goto l_0x100f_67fb; /* jz 0x100f67fb */
        l_0x100f_67f6:
            ii(0x100f_67f6, 5); jmpd(0x100f_70a5, 0x8aa); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_67fb:
            ii(0x100f_67fb, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100f_6800, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_6805, 5); calld(0x1013_dc59, 0x4_744f);           /* call 0x1013dc59 */
            ii(0x100f_680a, 5); calld(0x100f_53c7, -0x1448);            /* call 0x100f53c7 */
            ii(0x100f_680f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6811, 5); mov(al, memb_a32[ds, 0x101c_37d2]);     /* mov al, [0x101c37d2] */
            ii(0x100f_6816, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_6819, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_681b, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_6820, 1); cwde();                                 /* cwde */
            ii(0x100f_6821, 5); calld(0x1010_26f8, 0xbed2);             /* call 0x101026f8 */
            ii(0x100f_6826, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_6828, 2); if(jnzd(0x100f_6834, 0xa)) goto l_0x100f_6834; /* jnz 0x100f6834 */
            ii(0x100f_682a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_682f, 5); calld(0x100f_4fa2, -0x1892);            /* call 0x100f4fa2 */
        l_0x100f_6834:
            ii(0x100f_6834, 5); jmpd(0x100f_70a5, 0x86c); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6839:
            ii(0x100f_6839, 7); cmp(memb_a32[ds, 0x101c_3938], 0);      /* cmp byte [0x101c3938], 0x0 */
            ii(0x100f_6840, 2); if(jzd(0x100f_6849, 0x7)) goto l_0x100f_6849; /* jz 0x100f6849 */
            ii(0x100f_6842, 7); mov(memb_a32[ds, 0x101c_391e], 0x3);    /* mov byte [0x101c391e], 0x3 */
        l_0x100f_6849:
            ii(0x100f_6849, 5); jmpd(0x100f_70a5, 0x857); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_684e:
            ii(0x100f_684e, 7); cmp(memb_a32[ds, 0x101c_391e], 0x7);    /* cmp byte [0x101c391e], 0x7 */
            ii(0x100f_6855, 2); if(jnzd(0x100f_6860, 0x9)) goto l_0x100f_6860; /* jnz 0x100f6860 */
            ii(0x100f_6857, 7); mov(memb_a32[ds, 0x101c_391e], 0xe);    /* mov byte [0x101c391e], 0xe */
            ii(0x100f_685e, 2); jmpd(0x100f_68bd, 0x5d); goto l_0x100f_68bd; /* jmp 0x100f68bd */
        l_0x100f_6860:
            ii(0x100f_6860, 7); cmp(memb_a32[ds, 0x101c_3913], 0);      /* cmp byte [0x101c3913], 0x0 */
            ii(0x100f_6867, 2); if(jzd(0x100f_6872, 0x9)) goto l_0x100f_6872; /* jz 0x100f6872 */
            ii(0x100f_6869, 7); mov(memb_a32[ds, 0x101c_3913], 0);      /* mov byte [0x101c3913], 0x0 */
            ii(0x100f_6870, 2); jmpd(0x100f_68bd, 0x4b); goto l_0x100f_68bd; /* jmp 0x100f68bd */
        l_0x100f_6872:
            ii(0x100f_6872, 7); cmp(memb_a32[ds, 0x101c_37e4], 0);      /* cmp byte [0x101c37e4], 0x0 */
            ii(0x100f_6879, 2); if(jzd(0x100f_6884, 0x9)) goto l_0x100f_6884; /* jz 0x100f6884 */
            ii(0x100f_687b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_687d, 5); calld(0x100f_448c, -0x23f6);            /* call 0x100f448c */
            ii(0x100f_6882, 2); jmpd(0x100f_68bd, 0x39); goto l_0x100f_68bd; /* jmp 0x100f68bd */
        l_0x100f_6884:
            ii(0x100f_6884, 7); cmp(memb_a32[ds, 0x101c_391d], 0);      /* cmp byte [0x101c391d], 0x0 */
            ii(0x100f_688b, 2); if(jzd(0x100f_6894, 0x7)) goto l_0x100f_6894; /* jz 0x100f6894 */
            ii(0x100f_688d, 5); calld(0x1011_606c, 0x1_f7da);           /* call 0x1011606c */
            ii(0x100f_6892, 2); jmpd(0x100f_68bd, 0x29); goto l_0x100f_68bd; /* jmp 0x100f68bd */
        l_0x100f_6894:
            ii(0x100f_6894, 7); cmp(memb_a32[ds, 0x101c_3938], 0);      /* cmp byte [0x101c3938], 0x0 */
            ii(0x100f_689b, 2); if(jzd(0x100f_68a6, 0x9)) goto l_0x100f_68a6; /* jz 0x100f68a6 */
            ii(0x100f_689d, 7); mov(memb_a32[ds, 0x101c_391e], 0x3);    /* mov byte [0x101c391e], 0x3 */
            ii(0x100f_68a4, 2); jmpd(0x100f_68bd, 0x17); goto l_0x100f_68bd; /* jmp 0x100f68bd */
        l_0x100f_68a6:
            ii(0x100f_68a6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_68a8, 5); mov(eax, StringDefinitions.OkToExitGame2); /* mov eax, 0x101a261f */
            ii(0x100f_68ad, 5); calld(0x1011_7036, 0x2_0784);           /* call 0x10117036 */
            ii(0x100f_68b2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_68b4, 2); if(jzd(0x100f_68bd, 0x7)) goto l_0x100f_68bd; /* jz 0x100f68bd */
            ii(0x100f_68b6, 7); mov(memb_a32[ds, 0x101c_391e], 0x3);    /* mov byte [0x101c391e], 0x3 */
        l_0x100f_68bd:
            ii(0x100f_68bd, 5); jmpd(0x100f_70a5, 0x7e3); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_68c2:
            ii(0x100f_68c2, 5); calld(0x100f_4dba, -0x1b0d);            /* call 0x100f4dba */
            ii(0x100f_68c7, 5); jmpd(0x100f_70a5, 0x7d9); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_68cc:
            ii(0x100f_68cc, 7); cmp(memb_a32[ds, 0x101c_3916], 0);      /* cmp byte [0x101c3916], 0x0 */
            ii(0x100f_68d3, 6); if(jzd(0x100f_70a5, 0x7cc)) goto l_0x100f_70a5; /* jz 0x100f70a5 */
            ii(0x100f_68d9, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_68e0, 2); if(jzd(0x100f_6908, 0x26)) goto l_0x100f_6908; /* jz 0x100f6908 */
            ii(0x100f_68e2, 5); calld(0x100c_aa00, -0x2_bee7);          /* call 0x100caa00 */
            ii(0x100f_68e7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_68ec, 1); pushd(eax);                             /* push eax */
            ii(0x100f_68ed, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100f_68f2, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_68f7, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100f_68fc, 5); mov(eax, StringDefinitions.UnableToLoadASavedGameWhileRemotePlayInProgress); /* mov eax, 0x101a2630 */
            ii(0x100f_6901, 5); calld(0x1011_5d23, 0x1_f41d);           /* call 0x10115d23 */
            ii(0x100f_6906, 2); jmpd(0x100f_690f, 0x7); goto l_0x100f_690f; /* jmp 0x100f690f */
        l_0x100f_6908:
            ii(0x100f_6908, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_690a, 5); calld(0x100f_5227, -0x16e8);            /* call 0x100f5227 */
        l_0x100f_690f:
            ii(0x100f_690f, 5); jmpd(0x100f_70a5, 0x791); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6914:
            ii(0x100f_6914, 7); cmp(memb_a32[ds, 0x101c_3916], 0);      /* cmp byte [0x101c3916], 0x0 */
            ii(0x100f_691b, 6); if(jzd(0x100f_70a5, 0x784)) goto l_0x100f_70a5; /* jz 0x100f70a5 */
            ii(0x100f_6921, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_6926, 5); calld(0x100f_5227, -0x1704);            /* call 0x100f5227 */
            ii(0x100f_692b, 5); jmpd(0x100f_70a5, 0x775); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6930:
            ii(0x100f_6930, 7); cmp(memb_a32[ds, 0x101c_3916], 0);      /* cmp byte [0x101c3916], 0x0 */
            ii(0x100f_6937, 6); if(jzd(0x100f_70a5, 0x768)) goto l_0x100f_70a5; /* jz 0x100f70a5 */
            ii(0x100f_693d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_693f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_6944, 5); calld(0x100f_4ebe, -0x1a8b);            /* call 0x100f4ebe */
            ii(0x100f_6949, 5); jmpd(0x100f_70a5, 0x757); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_694e:
            ii(0x100f_694e, 5); calld(0x100f_4b16, -0x1e3d);            /* call 0x100f4b16 */
            ii(0x100f_6953, 5); jmpd(0x100f_70a5, 0x74d); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6958:
            ii(0x100f_6958, 5); calld(0x100f_4ab2, -0x1eab);            /* call 0x100f4ab2 */
            ii(0x100f_695d, 5); jmpd(0x100f_70a5, 0x743); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6962:
            ii(0x100f_6962, 5); calld(0x100f_4ae4, -0x1e83);            /* call 0x100f4ae4 */
            ii(0x100f_6967, 5); jmpd(0x100f_70a5, 0x739); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_696c:
            ii(0x100f_696c, 5); calld(0x100f_4a4c, -0x1f25);            /* call 0x100f4a4c */
            ii(0x100f_6971, 5); jmpd(0x100f_70a5, 0x72f); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6976:
            ii(0x100f_6976, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_6978, 5); mov(eax, memd_a32[ds, 0x101b_8799]);    /* mov eax, [0x101b8799] */
            ii(0x100f_697d, 5); calld(0x100c_fb73, -0x2_6e0f);          /* call 0x100cfb73 */
            ii(0x100f_6982, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6984, 5); calld(0x1010_1374, 0xa9eb);             /* call 0x10101374 */
            ii(0x100f_6989, 5); calld(0x100f_4b16, -0x1e78);            /* call 0x100f4b16 */
            ii(0x100f_698e, 5); jmpd(0x100f_70a5, 0x712); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6993:
            ii(0x100f_6993, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_6995, 5); mov(eax, memd_a32[ds, 0x101b_87a7]);    /* mov eax, [0x101b87a7] */
            ii(0x100f_699a, 5); calld(0x100c_fb73, -0x2_6e2c);          /* call 0x100cfb73 */
            ii(0x100f_699f, 7); cmp(memb_a32[ds, 0x101c_3918], 0);      /* cmp byte [0x101c3918], 0x0 */
            ii(0x100f_69a6, 2); if(jzd(0x100f_69c5, 0x1d)) goto l_0x100f_69c5; /* jz 0x100f69c5 */
            ii(0x100f_69a8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_69aa, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_69af, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_69b5, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_69bb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_69c0, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_69c3, 2); if(jzd(0x100f_69c7, 0x2)) goto l_0x100f_69c7; /* jz 0x100f69c7 */
        l_0x100f_69c5:
            ii(0x100f_69c5, 2); jmpd(0x100f_69f4, 0x2d); goto l_0x100f_69f4; /* jmp 0x100f69f4 */
        l_0x100f_69c7:
            ii(0x100f_69c7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_69c9, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_69ce, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_69d1, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100f_69d6, 5); calld(0x1007_2f25, -0x8_3ab6);          /* call 0x10072f25 */
            ii(0x100f_69db, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_69dd, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_69e2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_69e5, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100f_69ea, 5); calld(0x1007_2f25, -0x8_3aca);          /* call 0x10072f25 */
            ii(0x100f_69ef, 5); jmpd(0x100f_6a5f, 0x6b); goto l_0x100f_6a5f; /* jmp 0x100f6a5f */
        l_0x100f_69f4:
            ii(0x100f_69f4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_69f6, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_69fb, 5); calld(0x1013_ad71, 0x4_4371);           /* call 0x1013ad71 */
            ii(0x100f_6a00, 2); test(al, al);                           /* test al, al */
            ii(0x100f_6a02, 2); if(jzd(0x100f_6a1e, 0x1a)) goto l_0x100f_6a1e; /* jz 0x100f6a1e */
            ii(0x100f_6a04, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_6a09, 5); calld(0x1007_6574, -0x8_049a);          /* call 0x10076574 */
            ii(0x100f_6a0e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_6a10, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100f_6a13, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6a15, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_6a1a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_6a1c, 2); if(jzd(0x100f_6a20, 0x2)) goto l_0x100f_6a20; /* jz 0x100f6a20 */
        l_0x100f_6a1e:
            ii(0x100f_6a1e, 2); jmpd(0x100f_6a3d, 0x1d); goto l_0x100f_6a3d; /* jmp 0x100f6a3d */
        l_0x100f_6a20:
            ii(0x100f_6a20, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6a22, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_6a27, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_6a2d, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_6a33, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_6a38, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_6a3b, 2); if(jzd(0x100f_6a3f, 0x2)) goto l_0x100f_6a3f; /* jz 0x100f6a3f */
        l_0x100f_6a3d:
            ii(0x100f_6a3d, 2); jmpd(0x100f_6a50, 0x11); goto l_0x100f_6a50; /* jmp 0x100f6a50 */
        l_0x100f_6a3f:
            ii(0x100f_6a3f, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_6a44, 5); calld(0x1007_6600, -0x8_0449);          /* call 0x10076600 */
            ii(0x100f_6a49, 5); calld(0x1015_7e4d, 0x6_13ff);           /* call 0x10157e4d */
            ii(0x100f_6a4e, 2); jmpd(0x100f_6a5f, 0xf); goto l_0x100f_6a5f; /* jmp 0x100f6a5f */
        l_0x100f_6a50:
            ii(0x100f_6a50, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_6a55, 5); calld(0x1010_1374, 0xa91a);             /* call 0x10101374 */
            ii(0x100f_6a5a, 5); calld(0x100f_4b16, -0x1f49);            /* call 0x100f4b16 */
        l_0x100f_6a5f:
            ii(0x100f_6a5f, 5); jmpd(0x100f_70a5, 0x641); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6a64:
            ii(0x100f_6a64, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_6a66, 5); mov(eax, memd_a32[ds, 0x101b_87b5]);    /* mov eax, [0x101b87b5] */
            ii(0x100f_6a6b, 5); calld(0x100c_fb73, -0x2_6efd);          /* call 0x100cfb73 */
            ii(0x100f_6a70, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_6a75, 5); calld(0x1010_1374, 0xa8fa);             /* call 0x10101374 */
            ii(0x100f_6a7a, 5); calld(0x100f_4b16, -0x1f69);            /* call 0x100f4b16 */
            ii(0x100f_6a7f, 5); jmpd(0x100f_70a5, 0x621); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6a84:
            ii(0x100f_6a84, 5); calld(0x100f_40a6, -0x29e3);            /* call 0x100f40a6 */
            ii(0x100f_6a89, 5); calld(0x100f_4796, -0x22f8);            /* call 0x100f4796 */
            ii(0x100f_6a8e, 5); jmpd(0x100f_70a5, 0x612); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6a93:
            ii(0x100f_6a93, 5); calld(0x100f_40a6, -0x29f2);            /* call 0x100f40a6 */
            ii(0x100f_6a98, 5); calld(0x100f_4bed, -0x1eb0);            /* call 0x100f4bed */
            ii(0x100f_6a9d, 5); jmpd(0x100f_70a5, 0x603); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6aa2:
            ii(0x100f_6aa2, 5); mov(edx, 0x512);                        /* mov edx, 0x512 */
            ii(0x100f_6aa7, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_6aac, 5); calld(0x1013_dc59, 0x4_71a8);           /* call 0x1013dc59 */
            ii(0x100f_6ab1, 7); xor(memb_a32[ds, 0x101c_388e], 0x1);    /* xor byte [0x101c388e], 0x1 */
            ii(0x100f_6ab8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6aba, 5); mov(al, memb_a32[ds, 0x101c_388e]);     /* mov al, [0x101c388e] */
            ii(0x100f_6abf, 5); calld(0x100f_a7e8, 0x3d24);             /* call 0x100fa7e8 */
            ii(0x100f_6ac4, 5); jmpd(0x100f_70a5, 0x5dc); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6ac9:
            ii(0x100f_6ac9, 5); mov(edx, 0x50b);                        /* mov edx, 0x50b */
            ii(0x100f_6ace, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_6ad3, 5); calld(0x1013_dc59, 0x4_7181);           /* call 0x1013dc59 */
            ii(0x100f_6ad8, 7); xor(memb_a32[ds, 0x101c_37cc], 0x1);    /* xor byte [0x101c37cc], 0x1 */
            ii(0x100f_6adf, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6ae1, 5); mov(al, memb_a32[ds, 0x101c_37cc]);     /* mov al, [0x101c37cc] */
            ii(0x100f_6ae6, 5); calld(0x100f_47e4, -0x2307);            /* call 0x100f47e4 */
            ii(0x100f_6aeb, 5); jmpd(0x100f_70a5, 0x5b5); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6af0:
            ii(0x100f_6af0, 5); mov(edx, 0x50c);                        /* mov edx, 0x50c */
            ii(0x100f_6af5, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_6afa, 5); calld(0x1013_dc59, 0x4_715a);           /* call 0x1013dc59 */
            ii(0x100f_6aff, 7); xor(memb_a32[ds, 0x101c_37cd], 0x1);    /* xor byte [0x101c37cd], 0x1 */
            ii(0x100f_6b06, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6b08, 5); mov(al, memb_a32[ds, 0x101c_37cd]);     /* mov al, [0x101c37cd] */
            ii(0x100f_6b0d, 5); calld(0x100f_487e, -0x2294);            /* call 0x100f487e */
            ii(0x100f_6b12, 5); jmpd(0x100f_70a5, 0x58e); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6b17:
            ii(0x100f_6b17, 5); mov(edx, 0x50d);                        /* mov edx, 0x50d */
            ii(0x100f_6b1c, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_6b21, 5); calld(0x1013_dc59, 0x4_7133);           /* call 0x1013dc59 */
            ii(0x100f_6b26, 7); xor(memb_a32[ds, 0x101c_37ce], 0x1);    /* xor byte [0x101c37ce], 0x1 */
            ii(0x100f_6b2d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6b2f, 5); mov(al, memb_a32[ds, 0x101c_37ce]);     /* mov al, [0x101c37ce] */
            ii(0x100f_6b34, 5); calld(0x100f_48cb, -0x226e);            /* call 0x100f48cb */
            ii(0x100f_6b39, 5); jmpd(0x100f_70a5, 0x567); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6b3e:
            ii(0x100f_6b3e, 5); mov(edx, 0x513);                        /* mov edx, 0x513 */
            ii(0x100f_6b43, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_6b48, 5); calld(0x1013_dc59, 0x4_710c);           /* call 0x1013dc59 */
            ii(0x100f_6b4d, 7); cmp(memb_a32[ds, 0x101c_37cb], 0);      /* cmp byte [0x101c37cb], 0x0 */
            ii(0x100f_6b54, 2); if(jnzd(0x100f_6b5c, 0x6)) goto l_0x100f_6b5c; /* jnz 0x100f6b5c */
            ii(0x100f_6b56, 4); mov(memb_a32[ss, ebp - 0x1c], 0x1);     /* mov byte [ebp-0x1c], 0x1 */
            ii(0x100f_6b5a, 2); jmpd(0x100f_6b60, 0x4); goto l_0x100f_6b60; /* jmp 0x100f6b60 */
        l_0x100f_6b5c:
            ii(0x100f_6b5c, 4); mov(memb_a32[ss, ebp - 0x1c], 0);       /* mov byte [ebp-0x1c], 0x0 */
        l_0x100f_6b60:
            ii(0x100f_6b60, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6b62, 3); mov(al, memb_a32[ss, ebp - 0x1c]);      /* mov al, [ebp-0x1c] */
            ii(0x100f_6b65, 5); calld(0x100f_4918, -0x2252);            /* call 0x100f4918 */
            ii(0x100f_6b6a, 5); jmpd(0x100f_70a5, 0x536); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6b6f:
            ii(0x100f_6b6f, 5); mov(edx, 0x50e);                        /* mov edx, 0x50e */
            ii(0x100f_6b74, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_6b79, 5); calld(0x1013_dc59, 0x4_70db);           /* call 0x1013dc59 */
            ii(0x100f_6b7e, 7); xor(memb_a32[ds, 0x101c_37cf], 0x1);    /* xor byte [0x101c37cf], 0x1 */
            ii(0x100f_6b85, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6b87, 5); mov(al, memb_a32[ds, 0x101c_37cf]);     /* mov al, [0x101c37cf] */
            ii(0x100f_6b8c, 5); calld(0x100f_4965, -0x222c);            /* call 0x100f4965 */
            ii(0x100f_6b91, 5); jmpd(0x100f_70a5, 0x50f); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6b96:
            ii(0x100f_6b96, 5); mov(edx, 0x50f);                        /* mov edx, 0x50f */
            ii(0x100f_6b9b, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_6ba0, 5); calld(0x1013_dc59, 0x4_70b4);           /* call 0x1013dc59 */
            ii(0x100f_6ba5, 7); xor(memb_a32[ds, 0x101c_3889], 0x1);    /* xor byte [0x101c3889], 0x1 */
            ii(0x100f_6bac, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6bae, 5); mov(al, memb_a32[ds, 0x101c_3889]);     /* mov al, [0x101c3889] */
            ii(0x100f_6bb3, 5); calld(0x100f_4831, -0x2387);            /* call 0x100f4831 */
            ii(0x100f_6bb8, 5); jmpd(0x100f_70a5, 0x4e8); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6bbd:
            ii(0x100f_6bbd, 5); mov(edx, 0x510);                        /* mov edx, 0x510 */
            ii(0x100f_6bc2, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_6bc7, 5); calld(0x1013_dc59, 0x4_708d);           /* call 0x1013dc59 */
            ii(0x100f_6bcc, 7); xor(memb_a32[ds, 0x101c_388a], 0x1);    /* xor byte [0x101c388a], 0x1 */
            ii(0x100f_6bd3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6bd5, 5); mov(al, memb_a32[ds, 0x101c_388a]);     /* mov al, [0x101c388a] */
            ii(0x100f_6bda, 5); calld(0x100f_4ba0, -0x203f);            /* call 0x100f4ba0 */
            ii(0x100f_6bdf, 5); jmpd(0x100f_70a5, 0x4c1); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6be4:
            ii(0x100f_6be4, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100f_6be9, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_6bee, 5); calld(0x1013_dc59, 0x4_7066);           /* call 0x1013dc59 */
            ii(0x100f_6bf3, 7); xor(memb_a32[ds, 0x101c_388c], 0x1);    /* xor byte [0x101c388c], 0x1 */
            ii(0x100f_6bfa, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6bfc, 5); mov(al, memb_a32[ds, 0x101c_388c]);     /* mov al, [0x101c388c] */
            ii(0x100f_6c01, 5); calld(0x100f_3711, -0x34f5);            /* call 0x100f3711 */
            ii(0x100f_6c06, 5); jmpd(0x100f_70a5, 0x49a); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6c0b:
            ii(0x100f_6c0b, 5); mov(edx, 0x511);                        /* mov edx, 0x511 */
            ii(0x100f_6c10, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_6c15, 5); calld(0x1013_dc59, 0x4_703f);           /* call 0x1013dc59 */
            ii(0x100f_6c1a, 7); xor(memb_a32[ds, 0x101c_388d], 0x1);    /* xor byte [0x101c388d], 0x1 */
            ii(0x100f_6c21, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6c23, 5); mov(al, memb_a32[ds, 0x101c_388d]);     /* mov al, [0x101c388d] */
            ii(0x100f_6c28, 5); calld(0x100f_4f55, -0x1cd8);            /* call 0x100f4f55 */
            ii(0x100f_6c2d, 5); jmpd(0x100f_70a5, 0x473); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6c32:
            ii(0x100f_6c32, 5); mov(edx, 0x50e);                        /* mov edx, 0x50e */
            ii(0x100f_6c37, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_6c3c, 5); calld(0x1013_dc59, 0x4_7018);           /* call 0x1013dc59 */
            ii(0x100f_6c41, 7); xor(memb_a32[ds, 0x101c_37d0], 0x1);    /* xor byte [0x101c37d0], 0x1 */
            ii(0x100f_6c48, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6c4a, 5); mov(al, memb_a32[ds, 0x101c_37d0]);     /* mov al, [0x101c37d0] */
            ii(0x100f_6c4f, 5); calld(0x100f_49b2, -0x22a2);            /* call 0x100f49b2 */
            ii(0x100f_6c54, 5); jmpd(0x100f_70a5, 0x44c); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6c59:
            ii(0x100f_6c59, 5); mov(edx, 0x50e);                        /* mov edx, 0x50e */
            ii(0x100f_6c5e, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_6c63, 5); calld(0x1013_dc59, 0x4_6ff1);           /* call 0x1013dc59 */
            ii(0x100f_6c68, 7); xor(memb_a32[ds, 0x101c_37d1], 0x1);    /* xor byte [0x101c37d1], 0x1 */
            ii(0x100f_6c6f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6c71, 5); mov(al, memb_a32[ds, 0x101c_37d1]);     /* mov al, [0x101c37d1] */
            ii(0x100f_6c76, 5); calld(0x100f_49ff, -0x227c);            /* call 0x100f49ff */
            ii(0x100f_6c7b, 5); jmpd(0x100f_70a5, 0x425); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6c80:
            ii(0x100f_6c80, 5); calld(0x1011_6ba6, 0x1_ff21);           /* call 0x10116ba6 */
            ii(0x100f_6c85, 5); jmpd(0x100f_70a5, 0x41b); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6c8a:
            ii(0x100f_6c8a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_6c8c, 5); mov(eax, StringDefinitions.OkToExitGame); /* mov eax, 0x101a266b */
            ii(0x100f_6c91, 5); calld(0x1011_7036, 0x2_03a0);           /* call 0x10117036 */
            ii(0x100f_6c96, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_6c98, 6); if(jzd(0x100f_70a5, 0x407)) goto l_0x100f_70a5; /* jz 0x100f70a5 */
            ii(0x100f_6c9e, 7); mov(memb_a32[ds, 0x101c_391e], 0x3);    /* mov byte [0x101c391e], 0x3 */
            ii(0x100f_6ca5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6ca7, 5); calld(0x100f_448c, -0x2820);            /* call 0x100f448c */
            ii(0x100f_6cac, 5); jmpd(0x100f_70a5, 0x3f4); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6cb1:
            ii(0x100f_6cb1, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_6cb5, 5); calld(0x100f_5413, -0x18a7);            /* call 0x100f5413 */
            ii(0x100f_6cba, 2); test(al, al);                           /* test al, al */
            ii(0x100f_6cbc, 2); if(jnzd(0x100f_6cc9, 0xb)) goto l_0x100f_6cc9; /* jnz 0x100f6cc9 */
            ii(0x100f_6cbe, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_6cc2, 5); cmp(eax, 0x7000);                       /* cmp eax, 0x7000 */
            ii(0x100f_6cc7, 2); if(jged(0x100f_6ccb, 0x2)) goto l_0x100f_6ccb; /* jge 0x100f6ccb */
        l_0x100f_6cc9:
            ii(0x100f_6cc9, 2); jmpd(0x100f_6cd4, 0x9); goto l_0x100f_6cd4; /* jmp 0x100f6cd4 */
        l_0x100f_6ccb:
            ii(0x100f_6ccb, 7); cmp(memb_a32[ds, 0x101c_3890], 0);      /* cmp byte [0x101c3890], 0x0 */
            ii(0x100f_6cd2, 2); if(jzd(0x100f_6cd6, 0x2)) goto l_0x100f_6cd6; /* jz 0x100f6cd6 */
        l_0x100f_6cd4:
            ii(0x100f_6cd4, 2); jmpd(0x100f_6d2a, 0x54); goto l_0x100f_6d2a; /* jmp 0x100f6d2a */
        l_0x100f_6cd6:
            ii(0x100f_6cd6, 7); cmp(memb_a32[ds, 0x101c_391e], 0x7);    /* cmp byte [0x101c391e], 0x7 */
            ii(0x100f_6cdd, 2); if(jnzd(0x100f_6d14, 0x35)) goto l_0x100f_6d14; /* jnz 0x100f6d14 */
            ii(0x100f_6cdf, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_6ce3, 3); cmp(eax, 0x3f);                         /* cmp eax, 0x3f */
            ii(0x100f_6ce6, 2); if(jnzd(0x100f_6cf1, 0x9)) goto l_0x100f_6cf1; /* jnz 0x100f6cf1 */
            ii(0x100f_6ce8, 7); cmp(memd_a32[ds, 0x101c_39a0], 0);      /* cmp dword [0x101c39a0], 0x0 */
            ii(0x100f_6cef, 2); if(jnzd(0x100f_6cf3, 0x2)) goto l_0x100f_6cf3; /* jnz 0x100f6cf3 */
        l_0x100f_6cf1:
            ii(0x100f_6cf1, 2); jmpd(0x100f_6cff, 0xc); goto l_0x100f_6cff; /* jmp 0x100f6cff */
        l_0x100f_6cf3:
            ii(0x100f_6cf3, 5); mov(eax, memd_a32[ds, 0x101c_39a0]);    /* mov eax, [0x101c39a0] */
            ii(0x100f_6cf8, 5); calld(0x100c_fbbe, -0x2_713f);          /* call 0x100cfbbe */
            ii(0x100f_6cfd, 2); jmpd(0x100f_6d12, 0x13); goto l_0x100f_6d12; /* jmp 0x100f6d12 */
        l_0x100f_6cff:
            ii(0x100f_6cff, 7); cmp(memd_a32[ds, 0x101c_39a4], 0);      /* cmp dword [0x101c39a4], 0x0 */
            ii(0x100f_6d06, 2); if(jzd(0x100f_6d12, 0xa)) goto l_0x100f_6d12; /* jz 0x100f6d12 */
            ii(0x100f_6d08, 5); mov(eax, memd_a32[ds, 0x101c_39a4]);    /* mov eax, [0x101c39a4] */
            ii(0x100f_6d0d, 5); calld(0x100c_fbbe, -0x2_7154);          /* call 0x100cfbbe */
        l_0x100f_6d12:
            ii(0x100f_6d12, 2); jmpd(0x100f_6d23, 0xf); goto l_0x100f_6d23; /* jmp 0x100f6d23 */
        l_0x100f_6d14:
            ii(0x100f_6d14, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100f_6d19, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_6d1e, 5); calld(0x1013_dc59, 0x4_6f36);           /* call 0x1013dc59 */
        l_0x100f_6d23:
            ii(0x100f_6d23, 7); mov(memb_a32[ds, 0x101c_3890], 0x1);    /* mov byte [0x101c3890], 0x1 */
        l_0x100f_6d2a:
            ii(0x100f_6d2a, 5); jmpd(0x100f_70a5, 0x376); goto l_0x100f_70a5; /* jmp 0x100f70a5 */
        l_0x100f_6d2f:
            ii(0x100f_6d2f, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_6d32, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100f_6d35, 6); cmp(memw_a32[ss, ebp - 0x20], 0x16c);   /* cmp word [ebp-0x20], 0x16c */
            ii(0x100f_6d3b, 6); if(jbd(0x100f_6ed5, 0x194)) goto l_0x100f_6ed5; /* jb 0x100f6ed5 */
            ii(0x100f_6d41, 6); cmp(memw_a32[ss, ebp - 0x20], 0x16f);   /* cmp word [ebp-0x20], 0x16f */
            ii(0x100f_6d47, 6); if(jbed(0x100f_664c, -0x701)) goto l_0x100f_664c; /* jbe 0x100f664c */
            ii(0x100f_6d4d, 6); cmp(memw_a32[ss, ebp - 0x20], 0x3fc);   /* cmp word [ebp-0x20], 0x3fc */
            ii(0x100f_6d53, 6); if(jbd(0x100f_6e25, 0xcc)) goto l_0x100f_6e25; /* jb 0x100f6e25 */
            ii(0x100f_6d59, 6); cmp(memw_a32[ss, ebp - 0x20], 0x3fc);   /* cmp word [ebp-0x20], 0x3fc */
            ii(0x100f_6d5f, 6); if(jbed(0x100f_6a84, -0x2e1)) goto l_0x100f_6a84; /* jbe 0x100f6a84 */
            ii(0x100f_6d65, 6); cmp(memw_a32[ss, ebp - 0x20], 0x406);   /* cmp word [ebp-0x20], 0x406 */
            ii(0x100f_6d6b, 2); if(jbd(0x100f_6dd9, 0x6c)) goto l_0x100f_6dd9; /* jb 0x100f6dd9 */
            ii(0x100f_6d6d, 6); cmp(memw_a32[ss, ebp - 0x20], 0x406);   /* cmp word [ebp-0x20], 0x406 */
            ii(0x100f_6d73, 6); if(jbed(0x100f_6b6f, -0x20a)) goto l_0x100f_6b6f; /* jbe 0x100f6b6f */
            ii(0x100f_6d79, 6); cmp(memw_a32[ss, ebp - 0x20], 0x409);   /* cmp word [ebp-0x20], 0x409 */
            ii(0x100f_6d7f, 2); if(jbd(0x100f_6dc3, 0x42)) goto l_0x100f_6dc3; /* jb 0x100f6dc3 */
            ii(0x100f_6d81, 6); cmp(memw_a32[ss, ebp - 0x20], 0x409);   /* cmp word [ebp-0x20], 0x409 */
            ii(0x100f_6d87, 6); if(jbed(0x100f_6c0b, -0x182)) goto l_0x100f_6c0b; /* jbe 0x100f6c0b */
            ii(0x100f_6d8d, 6); cmp(memw_a32[ss, ebp - 0x20], 0x40c);   /* cmp word [ebp-0x20], 0x40c */
            ii(0x100f_6d93, 2); if(jbd(0x100f_6db2, 0x1d)) goto l_0x100f_6db2; /* jb 0x100f6db2 */
            ii(0x100f_6d95, 6); cmp(memw_a32[ss, ebp - 0x20], 0x40c);   /* cmp word [ebp-0x20], 0x40c */
            ii(0x100f_6d9b, 6); if(jbed(0x100f_6c32, -0x16f)) goto l_0x100f_6c32; /* jbe 0x100f6c32 */
            ii(0x100f_6da1, 6); cmp(memw_a32[ss, ebp - 0x20], 0x40d);   /* cmp word [ebp-0x20], 0x40d */
            ii(0x100f_6da7, 6); if(jzd(0x100f_6c59, -0x154)) goto l_0x100f_6c59; /* jz 0x100f6c59 */
            ii(0x100f_6dad, 5); jmpd(0x100f_6cb1, -0x101); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6db2:
            ii(0x100f_6db2, 6); cmp(memw_a32[ss, ebp - 0x20], 0x40a);   /* cmp word [ebp-0x20], 0x40a */
            ii(0x100f_6db8, 6); if(jzd(0x100f_6b3e, -0x280)) goto l_0x100f_6b3e; /* jz 0x100f6b3e */
            ii(0x100f_6dbe, 5); jmpd(0x100f_6cb1, -0x112); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6dc3:
            ii(0x100f_6dc3, 6); cmp(memw_a32[ss, ebp - 0x20], 0x407);   /* cmp word [ebp-0x20], 0x407 */
            ii(0x100f_6dc9, 6); if(jbed(0x100f_6b96, -0x239)) goto l_0x100f_6b96; /* jbe 0x100f6b96 */
            ii(0x100f_6dcf, 5); jmpd(0x100f_6bbd, -0x217); goto l_0x100f_6bbd; /* jmp 0x100f6bbd */
        //    ii(0x100f_6dd4, 5); jmpd(0x100f_6cb1, -0x128); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6dd9:
            ii(0x100f_6dd9, 6); cmp(memw_a32[ss, ebp - 0x20], 0x403);   /* cmp word [ebp-0x20], 0x403 */
            ii(0x100f_6ddf, 2); if(jbd(0x100f_6e03, 0x22)) goto l_0x100f_6e03; /* jb 0x100f6e03 */
            ii(0x100f_6de1, 6); cmp(memw_a32[ss, ebp - 0x20], 0x403);   /* cmp word [ebp-0x20], 0x403 */
            ii(0x100f_6de7, 6); if(jbed(0x100f_6ac9, -0x324)) goto l_0x100f_6ac9; /* jbe 0x100f6ac9 */
            ii(0x100f_6ded, 6); cmp(memw_a32[ss, ebp - 0x20], 0x404);   /* cmp word [ebp-0x20], 0x404 */
            ii(0x100f_6df3, 6); if(jbed(0x100f_6af0, -0x309)) goto l_0x100f_6af0; /* jbe 0x100f6af0 */
            ii(0x100f_6df9, 5); jmpd(0x100f_6b17, -0x2e7); goto l_0x100f_6b17; /* jmp 0x100f6b17 */
        //    ii(0x100f_6dfe, 5); jmpd(0x100f_6cb1, -0x152); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6e03:
            ii(0x100f_6e03, 6); cmp(memw_a32[ss, ebp - 0x20], 0x3fd);   /* cmp word [ebp-0x20], 0x3fd */
            ii(0x100f_6e09, 6); if(jbed(0x100f_6a93, -0x37c)) goto l_0x100f_6a93; /* jbe 0x100f6a93 */
            ii(0x100f_6e0f, 6); cmp(memw_a32[ss, ebp - 0x20], 0x402);   /* cmp word [ebp-0x20], 0x402 */
            ii(0x100f_6e15, 6); if(jzd(0x100f_6aa2, -0x379)) goto l_0x100f_6aa2; /* jz 0x100f6aa2 */
            ii(0x100f_6e1b, 5); jmpd(0x100f_6cb1, -0x16f); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        //    ii(0x100f_6e20, 5); jmpd(0x100f_6cb1, -0x174); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6e25:
            ii(0x100f_6e25, 6); cmp(memw_a32[ss, ebp - 0x20], 0x3f6);   /* cmp word [ebp-0x20], 0x3f6 */
            ii(0x100f_6e2b, 2); if(jbd(0x100f_6e79, 0x4c)) goto l_0x100f_6e79; /* jb 0x100f6e79 */
            ii(0x100f_6e2d, 6); cmp(memw_a32[ss, ebp - 0x20], 0x3f6);   /* cmp word [ebp-0x20], 0x3f6 */
            ii(0x100f_6e33, 6); if(jbed(0x100f_694e, -0x4eb)) goto l_0x100f_694e; /* jbe 0x100f694e */
            ii(0x100f_6e39, 6); cmp(memw_a32[ss, ebp - 0x20], 0x3f9);   /* cmp word [ebp-0x20], 0x3f9 */
            ii(0x100f_6e3f, 2); if(jbd(0x100f_6e63, 0x22)) goto l_0x100f_6e63; /* jb 0x100f6e63 */
            ii(0x100f_6e41, 6); cmp(memw_a32[ss, ebp - 0x20], 0x3f9);   /* cmp word [ebp-0x20], 0x3f9 */
            ii(0x100f_6e47, 6); if(jbed(0x100f_6993, -0x4ba)) goto l_0x100f_6993; /* jbe 0x100f6993 */
            ii(0x100f_6e4d, 6); cmp(memw_a32[ss, ebp - 0x20], 0x3fa);   /* cmp word [ebp-0x20], 0x3fa */
            ii(0x100f_6e53, 6); if(jbed(0x100f_6a64, -0x3f5)) goto l_0x100f_6a64; /* jbe 0x100f6a64 */
            ii(0x100f_6e59, 5); jmpd(0x100f_696c, -0x4f2); goto l_0x100f_696c; /* jmp 0x100f696c */
        //    ii(0x100f_6e5e, 5); jmpd(0x100f_6cb1, -0x1b2); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6e63:
            ii(0x100f_6e63, 6); cmp(memw_a32[ss, ebp - 0x20], 0x3f7);   /* cmp word [ebp-0x20], 0x3f7 */
            ii(0x100f_6e69, 6); if(jbed(0x100f_6be4, -0x28b)) goto l_0x100f_6be4; /* jbe 0x100f6be4 */
            ii(0x100f_6e6f, 5); jmpd(0x100f_6976, -0x4fe); goto l_0x100f_6976; /* jmp 0x100f6976 */
        //    ii(0x100f_6e74, 5); jmpd(0x100f_6cb1, -0x1c8); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6e79:
            ii(0x100f_6e79, 6); cmp(memw_a32[ss, ebp - 0x20], 0x3ed);   /* cmp word [ebp-0x20], 0x3ed */
            ii(0x100f_6e7f, 2); if(jbd(0x100f_6eb7, 0x36)) goto l_0x100f_6eb7; /* jb 0x100f6eb7 */
            ii(0x100f_6e81, 6); cmp(memw_a32[ss, ebp - 0x20], 0x3ed);   /* cmp word [ebp-0x20], 0x3ed */
            ii(0x100f_6e87, 6); if(jbed(0x100f_68c2, -0x5cb)) goto l_0x100f_68c2; /* jbe 0x100f68c2 */
            ii(0x100f_6e8d, 6); cmp(memw_a32[ss, ebp - 0x20], 0x3ef);   /* cmp word [ebp-0x20], 0x3ef */
            ii(0x100f_6e93, 2); if(jbd(0x100f_6eb2, 0x1d)) goto l_0x100f_6eb2; /* jb 0x100f6eb2 */
            ii(0x100f_6e95, 6); cmp(memw_a32[ss, ebp - 0x20], 0x3ef);   /* cmp word [ebp-0x20], 0x3ef */
            ii(0x100f_6e9b, 6); if(jbed(0x100f_6958, -0x549)) goto l_0x100f_6958; /* jbe 0x100f6958 */
            ii(0x100f_6ea1, 6); cmp(memw_a32[ss, ebp - 0x20], 0x3f0);   /* cmp word [ebp-0x20], 0x3f0 */
            ii(0x100f_6ea7, 6); if(jzd(0x100f_6962, -0x54b)) goto l_0x100f_6962; /* jz 0x100f6962 */
            ii(0x100f_6ead, 5); jmpd(0x100f_6cb1, -0x201); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6eb2:
            ii(0x100f_6eb2, 5); jmpd(0x100f_6cb1, -0x206); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6eb7:
            ii(0x100f_6eb7, 6); cmp(memw_a32[ss, ebp - 0x20], 0x3eb);   /* cmp word [ebp-0x20], 0x3eb */
            ii(0x100f_6ebd, 2); if(jbd(0x100f_6ed0, 0x11)) goto l_0x100f_6ed0; /* jb 0x100f6ed0 */
            ii(0x100f_6ebf, 6); cmp(memw_a32[ss, ebp - 0x20], 0x3eb);   /* cmp word [ebp-0x20], 0x3eb */
            ii(0x100f_6ec5, 6); if(jbed(0x100f_67fb, -0x6d0)) goto l_0x100f_67fb; /* jbe 0x100f67fb */
            ii(0x100f_6ecb, 5); jmpd(0x100f_6930, -0x5a0); goto l_0x100f_6930; /* jmp 0x100f6930 */
        l_0x100f_6ed0:
            ii(0x100f_6ed0, 5); jmpd(0x100f_6cb1, -0x224); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6ed5:
            ii(0x100f_6ed5, 5); cmp(memw_a32[ss, ebp - 0x20], 0x67);    /* cmp word [ebp-0x20], 0x67 */
            ii(0x100f_6eda, 6); if(jbd(0x100f_6fd3, 0xf3)) goto l_0x100f_6fd3; /* jb 0x100f6fd3 */
            ii(0x100f_6ee0, 5); cmp(memw_a32[ss, ebp - 0x20], 0x67);    /* cmp word [ebp-0x20], 0x67 */
            ii(0x100f_6ee5, 6); if(jbed(0x100f_6c0b, -0x2e0)) goto l_0x100f_6c0b; /* jbe 0x100f6c0b */
            ii(0x100f_6eeb, 6); cmp(memw_a32[ss, ebp - 0x20], 0x13b);   /* cmp word [ebp-0x20], 0x13b */
            ii(0x100f_6ef1, 6); if(jbd(0x100f_6f6b, 0x74)) goto l_0x100f_6f6b; /* jb 0x100f6f6b */
            ii(0x100f_6ef7, 6); cmp(memw_a32[ss, ebp - 0x20], 0x13b);   /* cmp word [ebp-0x20], 0x13b */
            ii(0x100f_6efd, 6); if(jbed(0x100f_650f, -0x9f4)) goto l_0x100f_650f; /* jbe 0x100f650f */
            ii(0x100f_6f03, 6); cmp(memw_a32[ss, ebp - 0x20], 0x14b);   /* cmp word [ebp-0x20], 0x14b */
            ii(0x100f_6f09, 2); if(jbd(0x100f_6f41, 0x36)) goto l_0x100f_6f41; /* jb 0x100f6f41 */
            ii(0x100f_6f0b, 6); cmp(memw_a32[ss, ebp - 0x20], 0x14b);   /* cmp word [ebp-0x20], 0x14b */
            ii(0x100f_6f11, 6); if(jbed(0x100f_66ae, -0x869)) goto l_0x100f_66ae; /* jbe 0x100f66ae */
            ii(0x100f_6f17, 6); cmp(memw_a32[ss, ebp - 0x20], 0x14d);   /* cmp word [ebp-0x20], 0x14d */
            ii(0x100f_6f1d, 2); if(jbd(0x100f_6f3c, 0x1d)) goto l_0x100f_6f3c; /* jb 0x100f6f3c */
            ii(0x100f_6f1f, 6); cmp(memw_a32[ss, ebp - 0x20], 0x14d);   /* cmp word [ebp-0x20], 0x14d */
            ii(0x100f_6f25, 6); if(jbed(0x100f_66a2, -0x889)) goto l_0x100f_66a2; /* jbe 0x100f66a2 */
            ii(0x100f_6f2b, 6); cmp(memw_a32[ss, ebp - 0x20], 0x150);   /* cmp word [ebp-0x20], 0x150 */
            ii(0x100f_6f31, 6); if(jzd(0x100f_66ba, -0x87d)) goto l_0x100f_66ba; /* jz 0x100f66ba */
            ii(0x100f_6f37, 5); jmpd(0x100f_6cb1, -0x28b); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6f3c:
            ii(0x100f_6f3c, 5); jmpd(0x100f_6cb1, -0x290); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6f41:
            ii(0x100f_6f41, 6); cmp(memw_a32[ss, ebp - 0x20], 0x13f);   /* cmp word [ebp-0x20], 0x13f */
            ii(0x100f_6f47, 2); if(jbd(0x100f_6f66, 0x1d)) goto l_0x100f_6f66; /* jb 0x100f6f66 */
            ii(0x100f_6f49, 6); cmp(memw_a32[ss, ebp - 0x20], 0x142);   /* cmp word [ebp-0x20], 0x142 */
            ii(0x100f_6f4f, 6); if(jbed(0x100f_65e1, -0x974)) goto l_0x100f_65e1; /* jbe 0x100f65e1 */
            ii(0x100f_6f55, 6); cmp(memw_a32[ss, ebp - 0x20], 0x148);   /* cmp word [ebp-0x20], 0x148 */
            ii(0x100f_6f5b, 6); if(jzd(0x100f_66c6, -0x89b)) goto l_0x100f_66c6; /* jz 0x100f66c6 */
            ii(0x100f_6f61, 5); jmpd(0x100f_6cb1, -0x2b5); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6f66:
            ii(0x100f_6f66, 5); jmpd(0x100f_6cb1, -0x2ba); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6f6b:
            ii(0x100f_6f6b, 6); cmp(memw_a32[ss, ebp - 0x20], 0x121);   /* cmp word [ebp-0x20], 0x121 */
            ii(0x100f_6f71, 2); if(jbd(0x100f_6fa9, 0x36)) goto l_0x100f_6fa9; /* jb 0x100f6fa9 */
            ii(0x100f_6f73, 6); cmp(memw_a32[ss, ebp - 0x20], 0x121);   /* cmp word [ebp-0x20], 0x121 */
            ii(0x100f_6f79, 6); if(jbed(0x100f_6930, -0x64f)) goto l_0x100f_6930; /* jbe 0x100f6930 */
            ii(0x100f_6f7f, 6); cmp(memw_a32[ss, ebp - 0x20], 0x126);   /* cmp word [ebp-0x20], 0x126 */
            ii(0x100f_6f85, 2); if(jbd(0x100f_6fa4, 0x1d)) goto l_0x100f_6fa4; /* jb 0x100f6fa4 */
            ii(0x100f_6f87, 6); cmp(memw_a32[ss, ebp - 0x20], 0x126);   /* cmp word [ebp-0x20], 0x126 */
            ii(0x100f_6f8d, 6); if(jbed(0x100f_68cc, -0x6c7)) goto l_0x100f_68cc; /* jbe 0x100f68cc */
            ii(0x100f_6f93, 6); cmp(memw_a32[ss, ebp - 0x20], 0x12d);   /* cmp word [ebp-0x20], 0x12d */
            ii(0x100f_6f99, 6); if(jzd(0x100f_6c8a, -0x315)) goto l_0x100f_6c8a; /* jz 0x100f6c8a */
            ii(0x100f_6f9f, 5); jmpd(0x100f_6cb1, -0x2f3); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6fa4:
            ii(0x100f_6fa4, 5); jmpd(0x100f_6cb1, -0x2f8); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6fa9:
            ii(0x100f_6fa9, 6); cmp(memw_a32[ss, ebp - 0x20], 0x119);   /* cmp word [ebp-0x20], 0x119 */
            ii(0x100f_6faf, 2); if(jbd(0x100f_6fce, 0x1d)) goto l_0x100f_6fce; /* jb 0x100f6fce */
            ii(0x100f_6fb1, 6); cmp(memw_a32[ss, ebp - 0x20], 0x119);   /* cmp word [ebp-0x20], 0x119 */
            ii(0x100f_6fb7, 6); if(jbed(0x100f_6c80, -0x33d)) goto l_0x100f_6c80; /* jbe 0x100f6c80 */
            ii(0x100f_6fbd, 6); cmp(memw_a32[ss, ebp - 0x20], 0x11f);   /* cmp word [ebp-0x20], 0x11f */
            ii(0x100f_6fc3, 6); if(jzd(0x100f_6914, -0x6b5)) goto l_0x100f_6914; /* jz 0x100f6914 */
            ii(0x100f_6fc9, 5); jmpd(0x100f_6cb1, -0x31d); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6fce:
            ii(0x100f_6fce, 5); jmpd(0x100f_6cb1, -0x322); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_6fd3:
            ii(0x100f_6fd3, 5); cmp(memw_a32[ss, ebp - 0x20], 0x3d);    /* cmp word [ebp-0x20], 0x3d */
            ii(0x100f_6fd8, 2); if(jbd(0x100f_7045, 0x6b)) goto l_0x100f_7045; /* jb 0x100f7045 */
            ii(0x100f_6fda, 5); cmp(memw_a32[ss, ebp - 0x20], 0x3d);    /* cmp word [ebp-0x20], 0x3d */
            ii(0x100f_6fdf, 6); if(jbed(0x100f_66d2, -0x913)) goto l_0x100f_66d2; /* jbe 0x100f66d2 */
            ii(0x100f_6fe5, 5); cmp(memw_a32[ss, ebp - 0x20], 0x47);    /* cmp word [ebp-0x20], 0x47 */
            ii(0x100f_6fea, 2); if(jbd(0x100f_701e, 0x32)) goto l_0x100f_701e; /* jb 0x100f701e */
            ii(0x100f_6fec, 5); cmp(memw_a32[ss, ebp - 0x20], 0x47);    /* cmp word [ebp-0x20], 0x47 */
            ii(0x100f_6ff1, 6); if(jbed(0x100f_6c0b, -0x3ec)) goto l_0x100f_6c0b; /* jbe 0x100f6c0b */
            ii(0x100f_6ff7, 5); cmp(memw_a32[ss, ebp - 0x20], 0x5b);    /* cmp word [ebp-0x20], 0x5b */
            ii(0x100f_6ffc, 2); if(jbd(0x100f_7019, 0x1b)) goto l_0x100f_7019; /* jb 0x100f7019 */
            ii(0x100f_6ffe, 5); cmp(memw_a32[ss, ebp - 0x20], 0x5b);    /* cmp word [ebp-0x20], 0x5b */
            ii(0x100f_7003, 6); if(jbed(0x100f_64fb, -0xb0e)) goto l_0x100f_64fb; /* jbe 0x100f64fb */
            ii(0x100f_7009, 5); cmp(memw_a32[ss, ebp - 0x20], 0x66);    /* cmp word [ebp-0x20], 0x66 */
            ii(0x100f_700e, 6); if(jzd(0x100f_694e, -0x6c6)) goto l_0x100f_694e; /* jz 0x100f694e */
            ii(0x100f_7014, 5); jmpd(0x100f_6cb1, -0x368); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_7019:
            ii(0x100f_7019, 5); jmpd(0x100f_6cb1, -0x36d); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_701e:
            ii(0x100f_701e, 5); cmp(memw_a32[ss, ebp - 0x20], 0x3f);    /* cmp word [ebp-0x20], 0x3f */
            ii(0x100f_7023, 2); if(jbd(0x100f_7040, 0x1b)) goto l_0x100f_7040; /* jb 0x100f7040 */
            ii(0x100f_7025, 5); cmp(memw_a32[ss, ebp - 0x20], 0x3f);    /* cmp word [ebp-0x20], 0x3f */
            ii(0x100f_702a, 6); if(jbed(0x100f_696c, -0x6c4)) goto l_0x100f_696c; /* jbe 0x100f696c */
            ii(0x100f_7030, 5); cmp(memw_a32[ss, ebp - 0x20], 0x46);    /* cmp word [ebp-0x20], 0x46 */
            ii(0x100f_7035, 6); if(jzd(0x100f_694e, -0x6ed)) goto l_0x100f_694e; /* jz 0x100f694e */
            ii(0x100f_703b, 5); jmpd(0x100f_6cb1, -0x38f); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_7040:
            ii(0x100f_7040, 5); jmpd(0x100f_6cb1, -0x394); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_7045:
            ii(0x100f_7045, 5); cmp(memw_a32[ss, ebp - 0x20], 0x20);    /* cmp word [ebp-0x20], 0x20 */
            ii(0x100f_704a, 2); if(jbd(0x100f_707e, 0x32)) goto l_0x100f_707e; /* jb 0x100f707e */
            ii(0x100f_704c, 5); cmp(memw_a32[ss, ebp - 0x20], 0x20);    /* cmp word [ebp-0x20], 0x20 */
            ii(0x100f_7051, 6); if(jbed(0x100f_6839, -0x81e)) goto l_0x100f_6839; /* jbe 0x100f6839 */
            ii(0x100f_7057, 5); cmp(memw_a32[ss, ebp - 0x20], 0x2b);    /* cmp word [ebp-0x20], 0x2b */
            ii(0x100f_705c, 2); if(jbd(0x100f_7079, 0x1b)) goto l_0x100f_7079; /* jb 0x100f7079 */
            ii(0x100f_705e, 5); cmp(memw_a32[ss, ebp - 0x20], 0x2b);    /* cmp word [ebp-0x20], 0x2b */
            ii(0x100f_7063, 6); if(jbed(0x100f_66d2, -0x997)) goto l_0x100f_66d2; /* jbe 0x100f66d2 */
            ii(0x100f_7069, 5); cmp(memw_a32[ss, ebp - 0x20], 0x2d);    /* cmp word [ebp-0x20], 0x2d */
            ii(0x100f_706e, 6); if(jzd(0x100f_66f9, -0x97b)) goto l_0x100f_66f9; /* jz 0x100f66f9 */
            ii(0x100f_7074, 5); jmpd(0x100f_6cb1, -0x3c8); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_7079:
            ii(0x100f_7079, 5); jmpd(0x100f_6cb1, -0x3cd); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_707e:
            ii(0x100f_707e, 5); cmp(memw_a32[ss, ebp - 0x20], 0xd);     /* cmp word [ebp-0x20], 0xd */
            ii(0x100f_7083, 2); if(jbd(0x100f_70a0, 0x1b)) goto l_0x100f_70a0; /* jb 0x100f70a0 */
            ii(0x100f_7085, 5); cmp(memw_a32[ss, ebp - 0x20], 0xd);     /* cmp word [ebp-0x20], 0xd */
            ii(0x100f_708a, 6); if(jbed(0x100f_6720, -0x970)) goto l_0x100f_6720; /* jbe 0x100f6720 */
            ii(0x100f_7090, 5); cmp(memw_a32[ss, ebp - 0x20], 0x1b);    /* cmp word [ebp-0x20], 0x1b */
            ii(0x100f_7095, 6); if(jzd(0x100f_684e, -0x84d)) goto l_0x100f_684e; /* jz 0x100f684e */
            ii(0x100f_709b, 5); jmpd(0x100f_6cb1, -0x3ef); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_70a0:
            ii(0x100f_70a0, 5); jmpd(0x100f_6cb1, -0x3f4); goto l_0x100f_6cb1; /* jmp 0x100f6cb1 */
        l_0x100f_70a5:
            ii(0x100f_70a5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_70a7, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_70a8, 1); popd(edi);                              /* pop edi */
            ii(0x100f_70a9, 1); popd(esi);                              /* pop esi */
            ii(0x100f_70aa, 1); popd(edx);                              /* pop edx */
            ii(0x100f_70ab, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_70ac, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_70ad, 1); retd(); return;                         /* ret */
        }
    }
}
