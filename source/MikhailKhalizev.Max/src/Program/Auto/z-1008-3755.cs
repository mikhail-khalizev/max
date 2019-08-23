using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_3755-4e3e9b38")]
        public void Method_1008_3755()
        {
            ii(0x1008_3755, 5); push(0xc8);                             /* push 0xc8 */
            ii(0x1008_375a, 5); call(Definitions.sys_check_available_stack_size, 0xe_25f3); /* call 0x10165d52 */
            ii(0x1008_375f, 1); push(esi);                              /* push esi */
            ii(0x1008_3760, 1); push(edi);                              /* push edi */
            ii(0x1008_3761, 1); push(ebp);                              /* push ebp */
            ii(0x1008_3762, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_3764, 6); sub(esp, 0xac);                         /* sub esp, 0xac */
            ii(0x1008_376a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_376d, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1008_3770, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1008_3773, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1008_3776, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_3779, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1008_377c, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_377f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_3782, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1008_3785, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_3788, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_378b, 5); call(0x1007_6aac, -0xcce4);             /* call 0x10076aac */
            ii(0x1008_3790, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_3793, 5); call(Definitions.my_ctor_0x101b_4184, -0xcca8); /* call 0x10076af0 */
            ii(0x1008_3798, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_379b, 3); mov(edx, memd[ds, eax + 0x7]);          /* mov edx, [eax+0x7] */
            ii(0x1008_379e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_37a1, 6); imul(edx, edx, 0xc5);                   /* imul edx, edx, 0xc5 */
            ii(0x1008_37a7, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1008_37ac, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_37ae, 5); call(0x1008_a0c8, 0x6915);              /* call 0x1008a0c8 */
            ii(0x1008_37b3, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_37b6, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1008_37b8, 4); movsx(ebx, memb[ss, ebp + 0x10]);       /* movsx ebx, byte [ebp+0x10] */
            ii(0x1008_37bc, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_37bf, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_37c2, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_37c5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_37c8, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1008_37ce, 5); mov(esi, 0x101c_31c4);                  /* mov esi, 0x101c31c4 */
            ii(0x1008_37d3, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1008_37d5, 5); call(0x100c_1fd4, 0x3_e7fa);            /* call 0x100c1fd4 */
            ii(0x1008_37da, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_37dd, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1008_37e2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_37e5, 1); push(eax);                              /* push eax */
            ii(0x1008_37e6, 6); mov(ecx, memd[ds, 0x101c_8170]);        /* mov ecx, [0x101c8170] */
            ii(0x1008_37ec, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1008_37ef, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_37f1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_37f3, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1008_37f6, 5); call(0x1008_b148, 0x794d);              /* call 0x1008b148 */
            ii(0x1008_37fb, 7); mov(memd[ss, ebp - 0x34], 0xffff_ffff); /* mov dword [ebp-0x34], 0xffffffff */
            ii(0x1008_3802, 5); mov(edx, 0x4e);                         /* mov edx, 0x4e */
            ii(0x1008_3807, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_380a, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_380d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_3810, 5); call(0x100b_71dc, 0x3_39c7);            /* call 0x100b71dc */
            ii(0x1008_3815, 1); cwde();                                 /* cwde */
            ii(0x1008_3816, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_3818, 2); if(jle(0x1008_3826, 0xc)) goto l_0x1008_3826; /* jle 0x10083826 */
            ii(0x1008_381a, 7); mov(memd[ss, ebp - 0x34], 0x4e);        /* mov dword [ebp-0x34], 0x4e */
            ii(0x1008_3821, 5); jmp(0x1008_38d3, 0xad); goto l_0x1008_38d3; /* jmp 0x100838d3 */
        l_0x1008_3826:
            ii(0x1008_3826, 5); mov(edx, 0x48);                         /* mov edx, 0x48 */
            ii(0x1008_382b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_382e, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_3831, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_3834, 5); call(0x100b_71dc, 0x3_39a3);            /* call 0x100b71dc */
            ii(0x1008_3839, 1); cwde();                                 /* cwde */
            ii(0x1008_383a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_383c, 2); if(jle(0x1008_384a, 0xc)) goto l_0x1008_384a; /* jle 0x1008384a */
            ii(0x1008_383e, 7); mov(memd[ss, ebp - 0x34], 0x48);        /* mov dword [ebp-0x34], 0x48 */
            ii(0x1008_3845, 5); jmp(0x1008_38d3, 0x89); goto l_0x1008_38d3; /* jmp 0x100838d3 */
        l_0x1008_384a:
            ii(0x1008_384a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_384d, 5); cmp(memw[ds, eax + 0x8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1008_3852, 2); if(jz(0x1008_385e, 0xa)) goto l_0x1008_385e; /* jz 0x1008385e */
            ii(0x1008_3854, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_3857, 5); cmp(memw[ds, eax + 0x8], 0x43);         /* cmp word [eax+0x8], 0x43 */
            ii(0x1008_385c, 2); if(jnz(0x1008_3876, 0x18)) goto l_0x1008_3876; /* jnz 0x10083876 */
        l_0x1008_385e:
            ii(0x1008_385e, 5); mov(edx, 0x41);                         /* mov edx, 0x41 */
            ii(0x1008_3863, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3866, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_3869, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_386c, 5); call(0x100b_71dc, 0x3_396b);            /* call 0x100b71dc */
            ii(0x1008_3871, 1); cwde();                                 /* cwde */
            ii(0x1008_3872, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_3874, 2); if(jg(0x1008_3878, 0x2)) goto l_0x1008_3878; /* jg 0x10083878 */
        l_0x1008_3876:
            ii(0x1008_3876, 2); jmp(0x1008_3881, 0x9); goto l_0x1008_3881; /* jmp 0x10083881 */
        l_0x1008_3878:
            ii(0x1008_3878, 7); mov(memd[ss, ebp - 0x34], 0x41);        /* mov dword [ebp-0x34], 0x41 */
            ii(0x1008_387f, 2); jmp(0x1008_38d3, 0x52); goto l_0x1008_38d3; /* jmp 0x100838d3 */
        l_0x1008_3881:
            ii(0x1008_3881, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1008_3886, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3889, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_388c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_388f, 5); call(0x100b_71dc, 0x3_3948);            /* call 0x100b71dc */
            ii(0x1008_3894, 1); cwde();                                 /* cwde */
            ii(0x1008_3895, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_3897, 2); if(jle(0x1008_38a2, 0x9)) goto l_0x1008_38a2; /* jle 0x100838a2 */
            ii(0x1008_3899, 7); mov(memd[ss, ebp - 0x34], 0x4e);        /* mov dword [ebp-0x34], 0x4e */
            ii(0x1008_38a0, 2); jmp(0x1008_38d3, 0x31); goto l_0x1008_38d3; /* jmp 0x100838d3 */
        l_0x1008_38a2:
            ii(0x1008_38a2, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1008_38a7, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_38aa, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_38ad, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_38b0, 5); call(0x100b_71dc, 0x3_3927);            /* call 0x100b71dc */
            ii(0x1008_38b5, 1); cwde();                                 /* cwde */
            ii(0x1008_38b6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_38b8, 2); if(jg(0x1008_38cc, 0x12)) goto l_0x1008_38cc; /* jg 0x100838cc */
            ii(0x1008_38ba, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1008_38bd, 3); add(edx, 0x32);                         /* add edx, 0x32 */
            ii(0x1008_38c0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_38c3, 5); call(0x1007_6d98, -0xcb30);             /* call 0x10076d98 */
            ii(0x1008_38c8, 2); test(al, al);                           /* test al, al */
            ii(0x1008_38ca, 2); if(jz(0x1008_38d3, 0x7)) goto l_0x1008_38d3; /* jz 0x100838d3 */
        l_0x1008_38cc:
            ii(0x1008_38cc, 7); mov(memd[ss, ebp - 0x34], 0x48);        /* mov dword [ebp-0x34], 0x48 */
        l_0x1008_38d3:
            ii(0x1008_38d3, 4); or(memb[ss, ebp - 0x38], 0x1);          /* or byte [ebp-0x38], 0x1 */
            ii(0x1008_38d7, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1008_38db, 1); push(eax);                              /* push eax */
            ii(0x1008_38dc, 4); movsx(ecx, memb[ss, ebp + 0x10]);       /* movsx ecx, byte [ebp+0x10] */
            ii(0x1008_38e0, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1008_38e5, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_38e8, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_38eb, 5); call(0x1011_fec1, 0x9_c5d1);            /* call 0x1011fec1 */
            ii(0x1008_38f0, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1008_38f3, 4); and(memb[ss, ebp - 0x38], -0x2 /* 0xfe */); /* and byte [ebp-0x38], 0xfe */
            ii(0x1008_38f7, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_38fa, 5); call(0x1008_36ad, -0x252);              /* call 0x100836ad */
            ii(0x1008_38ff, 3); mov(memb[ss, ebp - 0x50], al);          /* mov [ebp-0x50], al */
            ii(0x1008_3902, 4); cmp(memd[ss, ebp - 0x20], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1008_3906, 2); if(jnz(0x1008_391b, 0x13)) goto l_0x1008_391b; /* jnz 0x1008391b */
            ii(0x1008_3908, 4); mov(memb[ss, ebp - 0x54], 0);           /* mov byte [ebp-0x54], 0x0 */
            ii(0x1008_390c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_390e, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_3911, 5); call(Definitions.my_dtor_d1, 0x53e6);   /* call 0x10088cfc */
            ii(0x1008_3916, 5); jmp(0x1008_3ea1, 0x586); goto l_0x1008_3ea1; /* jmp 0x10083ea1 */
        l_0x1008_391b:
            ii(0x1008_391b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_391e, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_3921, 5); call(0x1007_6b90, -0xcd96);             /* call 0x10076b90 */
            ii(0x1008_3926, 1); cwde();                                 /* cwde */
            ii(0x1008_3927, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_3929, 2); if(jnz(0x1008_393e, 0x13)) goto l_0x1008_393e; /* jnz 0x1008393e */
            ii(0x1008_392b, 4); mov(memb[ss, ebp - 0x54], 0);           /* mov byte [ebp-0x54], 0x0 */
            ii(0x1008_392f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3931, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_3934, 5); call(Definitions.my_dtor_d1, 0x53c3);   /* call 0x10088cfc */
            ii(0x1008_3939, 5); jmp(0x1008_3ea1, 0x563); goto l_0x1008_3ea1; /* jmp 0x10083ea1 */
        l_0x1008_393e:
            ii(0x1008_393e, 4); movsx(ebx, memb[ss, ebp + 0x10]);       /* movsx ebx, byte [ebp+0x10] */
            ii(0x1008_3942, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_3945, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3948, 5); call(0x100a_3671, 0x1_fd24);            /* call 0x100a3671 */
            ii(0x1008_394d, 2); test(al, al);                           /* test al, al */
            ii(0x1008_394f, 2); if(jz(0x1008_3964, 0x13)) goto l_0x1008_3964; /* jz 0x10083964 */
            ii(0x1008_3951, 4); mov(memb[ss, ebp - 0x54], 0x1);         /* mov byte [ebp-0x54], 0x1 */
            ii(0x1008_3955, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3957, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_395a, 5); call(Definitions.my_dtor_d1, 0x539d);   /* call 0x10088cfc */
            ii(0x1008_395f, 5); jmp(0x1008_3ea1, 0x53d); goto l_0x1008_3ea1; /* jmp 0x10083ea1 */
        l_0x1008_3964:
            ii(0x1008_3964, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3966, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3969, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_396c, 5); call(0x1008_9c68, 0x62f7);              /* call 0x10089c68 */
            ii(0x1008_3971, 5); call(0x1008_9f70, 0x65fa);              /* call 0x10089f70 */
            ii(0x1008_3976, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_3978, 2); if(jnz(0x1008_398d, 0x13)) goto l_0x1008_398d; /* jnz 0x1008398d */
            ii(0x1008_397a, 4); mov(memb[ss, ebp - 0x54], 0);           /* mov byte [ebp-0x54], 0x0 */
            ii(0x1008_397e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3980, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_3983, 5); call(Definitions.my_dtor_d1, 0x5374);   /* call 0x10088cfc */
            ii(0x1008_3988, 5); jmp(0x1008_3ea1, 0x514); goto l_0x1008_3ea1; /* jmp 0x10083ea1 */
        l_0x1008_398d:
            ii(0x1008_398d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_398f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3992, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_3995, 5); call(0x1008_9c68, 0x62ce);              /* call 0x10089c68 */
            ii(0x1008_399a, 5); call(0x1008_9f70, 0x65d1);              /* call 0x10089f70 */
            ii(0x1008_399f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_39a1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_39a3, 3); mov(al, memb[ds, edx + 0x26]);          /* mov al, [edx+0x26] */
            ii(0x1008_39a6, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x1008_39a9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_39ac, 5); cmp(memw[ds, eax + 0x8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1008_39b1, 2); if(jnz(0x1008_39c8, 0x15)) goto l_0x1008_39c8; /* jnz 0x100839c8 */
            ii(0x1008_39b3, 4); movsx(eax, memw[ss, ebp - 0x58]);       /* movsx eax, word [ebp-0x58] */
            ii(0x1008_39b7, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1008_39bd, 6); mov(eax, memd[ds, eax + 0x101c_a6ab]);  /* mov eax, [eax+0x101ca6ab] */
            ii(0x1008_39c3, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x1008_39c6, 2); jmp(0x1008_39fc, 0x34); goto l_0x1008_39fc; /* jmp 0x100839fc */
        l_0x1008_39c8:
            ii(0x1008_39c8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_39cb, 5); call(0x1016_433b, 0xe_096b);            /* call 0x1016433b */
            ii(0x1008_39d0, 2); test(al, al);                           /* test al, al */
            ii(0x1008_39d2, 2); if(jz(0x1008_39e9, 0x15)) goto l_0x1008_39e9; /* jz 0x100839e9 */
            ii(0x1008_39d4, 4); movsx(eax, memw[ss, ebp - 0x58]);       /* movsx eax, word [ebp-0x58] */
            ii(0x1008_39d8, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1008_39de, 6); mov(eax, memd[ds, eax + 0x101c_a6a7]);  /* mov eax, [eax+0x101ca6a7] */
            ii(0x1008_39e4, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x1008_39e7, 2); jmp(0x1008_39fc, 0x13); goto l_0x1008_39fc; /* jmp 0x100839fc */
        l_0x1008_39e9:
            ii(0x1008_39e9, 4); movsx(eax, memw[ss, ebp - 0x58]);       /* movsx eax, word [ebp-0x58] */
            ii(0x1008_39ed, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1008_39f3, 6); mov(eax, memd[ds, eax + 0x101c_a6a3]);  /* mov eax, [eax+0x101ca6a3] */
            ii(0x1008_39f9, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
        l_0x1008_39fc:
            ii(0x1008_39fc, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_39ff, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x1008_3a02, 5); call(0x1007_5e64, -0xdba3);             /* call 0x10075e64 */
            ii(0x1008_3a07, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_3a09, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1008_3a0c, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_3a0f, 5); call(0x1007_5e64, -0xdbb0);             /* call 0x10075e64 */
            ii(0x1008_3a14, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1008_3a16, 5); call(0x100a_5fca, 0x2_25af);            /* call 0x100a5fca */
            ii(0x1008_3a1b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1008_3a1e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1008_3a20, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1008_3a23, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1008_3a25, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1008_3a27, 3); mov(memd[ss, ebp - 0x68], eax);         /* mov [ebp-0x68], eax */
            ii(0x1008_3a2a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_3a2c, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_3a2f, 3); mov(al, memb[ds, edx + 0x4d]);          /* mov al, [edx+0x4d] */
            ii(0x1008_3a32, 3); mov(memd[ss, ebp - 0x6c], eax);         /* mov [ebp-0x6c], eax */
            ii(0x1008_3a35, 4); cmp(memb[ss, ebp + 0x10], 0x3);         /* cmp byte [ebp+0x10], 0x3 */
            ii(0x1008_3a39, 2); if(jnz(0x1008_3a42, 0x7)) goto l_0x1008_3a42; /* jnz 0x10083a42 */
            ii(0x1008_3a3b, 7); mov(memd[ss, ebp - 0x6c], 0x1);         /* mov dword [ebp-0x6c], 0x1 */
        l_0x1008_3a42:
            ii(0x1008_3a42, 7); mov(memd[ss, ebp - 0x70], 0x1);         /* mov dword [ebp-0x70], 0x1 */
            ii(0x1008_3a49, 2); jmp(0x1008_3a51, 0x6); goto l_0x1008_3a51; /* jmp 0x10083a51 */
        l_0x1008_3a4b:
            ii(0x1008_3a4b, 3); mov(eax, memd[ss, ebp - 0x70]);         /* mov eax, [ebp-0x70] */
            ii(0x1008_3a4e, 3); inc(memd[ss, ebp - 0x70]);              /* inc dword [ebp-0x70] */
        l_0x1008_3a51:
            ii(0x1008_3a51, 3); mov(eax, memd[ss, ebp - 0x70]);         /* mov eax, [ebp-0x70] */
            ii(0x1008_3a54, 4); cmp(ax, memw[ss, ebp - 0x68]);          /* cmp ax, [ebp-0x68] */
            ii(0x1008_3a58, 6); if(jge(0x1008_3c3d, 0x1df)) goto l_0x1008_3c3d; /* jge 0x10083c3d */
            ii(0x1008_3a5e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_3a61, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1008_3a64, 3); sub(eax, memd[ss, ebp - 0x70]);         /* sub eax, [ebp-0x70] */
            ii(0x1008_3a67, 4); mov(memw[ss, ebp - 0x18], ax);          /* mov [ebp-0x18], ax */
            ii(0x1008_3a6b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_3a6e, 4); mov(ax, memw[ds, eax + 0x2]);           /* mov ax, [eax+0x2] */
            ii(0x1008_3a72, 3); add(eax, memd[ss, ebp - 0x70]);         /* add eax, [ebp-0x70] */
            ii(0x1008_3a75, 4); mov(memw[ss, ebp - 0x16], ax);          /* mov [ebp-0x16], ax */
            ii(0x1008_3a79, 7); mov(memd[ss, ebp - 0x74], 0);           /* mov dword [ebp-0x74], 0x0 */
            ii(0x1008_3a80, 2); jmp(0x1008_3a86, 0x4); goto l_0x1008_3a86; /* jmp 0x10083a86 */
        l_0x1008_3a82:
            ii(0x1008_3a82, 4); add(memd[ss, ebp - 0x74], 0x2);         /* add dword [ebp-0x74], 0x2 */
        l_0x1008_3a86:
            ii(0x1008_3a86, 4); movsx(eax, memw[ss, ebp - 0x74]);       /* movsx eax, word [ebp-0x74] */
            ii(0x1008_3a8a, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1008_3a8d, 6); if(jge(0x1008_3c38, 0x1a5)) goto l_0x1008_3c38; /* jge 0x10083c38 */
            ii(0x1008_3a93, 7); mov(memd[ss, ebp - 0x78], 0);           /* mov dword [ebp-0x78], 0x0 */
            ii(0x1008_3a9a, 2); jmp(0x1008_3aa2, 0x6); goto l_0x1008_3aa2; /* jmp 0x10083aa2 */
        l_0x1008_3a9c:
            ii(0x1008_3a9c, 3); mov(eax, memd[ss, ebp - 0x78]);         /* mov eax, [ebp-0x78] */
            ii(0x1008_3a9f, 3); inc(memd[ss, ebp - 0x78]);              /* inc dword [ebp-0x78] */
        l_0x1008_3aa2:
            ii(0x1008_3aa2, 4); movsx(eax, memw[ss, ebp - 0x70]);       /* movsx eax, word [ebp-0x70] */
            ii(0x1008_3aa6, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1008_3aa8, 4); movsx(edx, memw[ss, ebp - 0x78]);       /* movsx edx, word [ebp-0x78] */
            ii(0x1008_3aac, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_3aae, 6); if(jge(0x1008_3c33, 0x17f)) goto l_0x1008_3c33; /* jge 0x10083c33 */
            ii(0x1008_3ab4, 4); movsx(edx, memw[ss, ebp - 0x74]);       /* movsx edx, word [ebp-0x74] */
            ii(0x1008_3ab8, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1008_3abb, 5); mov(eax, 0x101c_5348);                  /* mov eax, 0x101c5348 */
            ii(0x1008_3ac0, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1008_3ac2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_3ac5, 5); call(0x1008_b1a4, 0x76da);              /* call 0x1008b1a4 */
            ii(0x1008_3aca, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1008_3acd, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1008_3ad0, 5); call(0x1010_82ce, 0x8_47f9);            /* call 0x101082ce */
            ii(0x1008_3ad5, 2); test(al, al);                           /* test al, al */
            ii(0x1008_3ad7, 2); if(jz(0x1008_3af6, 0x1d)) goto l_0x1008_3af6; /* jz 0x10083af6 */
            ii(0x1008_3ad9, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1008_3add, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_3ae0, 3); add(eax, memd[ss, ebp - 0x20]);         /* add eax, [ebp-0x20] */
            ii(0x1008_3ae3, 4); movsx(edx, memw[ss, ebp - 0x16]);       /* movsx edx, word [ebp-0x16] */
            ii(0x1008_3ae7, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1008_3ae9, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1008_3aeb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_3aed, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1008_3af0, 4); cmp(ax, memw[ss, ebp - 0x6c]);          /* cmp ax, [ebp-0x6c] */
            ii(0x1008_3af4, 2); if(jl(0x1008_3af8, 0x2)) goto l_0x1008_3af8; /* jl 0x10083af8 */
        l_0x1008_3af6:
            ii(0x1008_3af6, 2); jmp(0x1008_3b24, 0x2c); goto l_0x1008_3b24; /* jmp 0x10083b24 */
        l_0x1008_3af8:
            ii(0x1008_3af8, 4); cmp(memb[ss, ebp - 0x50], 0);           /* cmp byte [ebp-0x50], 0x0 */
            ii(0x1008_3afc, 2); if(jz(0x1008_3b22, 0x24)) goto l_0x1008_3b22; /* jz 0x10083b22 */
            ii(0x1008_3afe, 4); movsx(eax, memw[ss, ebp - 0x16]);       /* movsx eax, word [ebp-0x16] */
            ii(0x1008_3b02, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x1008_3b08, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_3b0b, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1008_3b0e, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1008_3b12, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_3b14, 3); add(eax, memd[ss, ebp - 0x5c]);         /* add eax, [ebp-0x5c] */
            ii(0x1008_3b17, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1008_3b19, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_3b1e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_3b20, 2); if(jnz(0x1008_3b24, 0x2)) goto l_0x1008_3b24; /* jnz 0x10083b24 */
        l_0x1008_3b22:
            ii(0x1008_3b22, 2); jmp(0x1008_3b29, 0x5); goto l_0x1008_3b29; /* jmp 0x10083b29 */
        l_0x1008_3b24:
            ii(0x1008_3b24, 5); jmp(0x1008_3c2e, 0x105); goto l_0x1008_3c2e; /* jmp 0x10083c2e */
        l_0x1008_3b29:
            ii(0x1008_3b29, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_3b2c, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1008_3b2f, 5); call(0x1007_5e64, -0xdcd0);             /* call 0x10075e64 */
            ii(0x1008_3b34, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_3b36, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1008_3b39, 3); lea(eax, ebp - 0x80);                   /* lea eax, [ebp-0x80] */
            ii(0x1008_3b3c, 5); call(0x1007_5e64, -0xdcdd);             /* call 0x10075e64 */
            ii(0x1008_3b41, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1008_3b43, 5); call(0x100a_5fca, 0x2_2482);            /* call 0x100a5fca */
            ii(0x1008_3b48, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1008_3b4b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1008_3b4d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1008_3b50, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1008_3b52, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1008_3b54, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_3b56, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_3b59, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1008_3b5d, 3); sub(eax, memd[ss, ebp - 0x16]);         /* sub eax, [ebp-0x16] */
            ii(0x1008_3b60, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1008_3b63, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_3b66, 4); mov(ax, memw[ds, edx + 0x1a]);          /* mov ax, [edx+0x1a] */
            ii(0x1008_3b6a, 3); sub(eax, memd[ss, ebp - 0x18]);         /* sub eax, [ebp-0x18] */
            ii(0x1008_3b6d, 1); cwde();                                 /* cwde */
            ii(0x1008_3b6e, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1008_3b70, 5); call(0x100a_5f65, 0x2_23f0);            /* call 0x100a5f65 */
            ii(0x1008_3b75, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1008_3b78, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1008_3b7a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1008_3b7d, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1008_3b80, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1008_3b82, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1008_3b85, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_3b87, 6); mov(memd[ss, ebp - 0x84], eax);         /* mov [ebp-0x84], eax */
            ii(0x1008_3b8d, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1008_3b93, 4); cmp(ax, memw[ss, ebp - 0x68]);          /* cmp ax, [ebp-0x68] */
            ii(0x1008_3b97, 2); if(jge(0x1008_3bb0, 0x17)) goto l_0x1008_3bb0; /* jge 0x10083bb0 */
            ii(0x1008_3b99, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1008_3b9d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_3ba0, 3); add(eax, memd[ss, ebp - 0x1c]);         /* add eax, [ebp-0x1c] */
            ii(0x1008_3ba3, 4); movsx(edx, memw[ss, ebp - 0x16]);       /* movsx edx, word [ebp-0x16] */
            ii(0x1008_3ba7, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1008_3ba9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_3bab, 3); test(memb[ds, eax], 0x8);               /* test byte [eax], 0x8 */
            ii(0x1008_3bae, 2); if(jz(0x1008_3bb2, 0x2)) goto l_0x1008_3bb2; /* jz 0x10083bb2 */
        l_0x1008_3bb0:
            ii(0x1008_3bb0, 2); jmp(0x1008_3bce, 0x1c); goto l_0x1008_3bce; /* jmp 0x10083bce */
        l_0x1008_3bb2:
            ii(0x1008_3bb2, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1008_3bb5, 6); lea(eax, ebp - 0x88);                   /* lea eax, [ebp-0x88] */
            ii(0x1008_3bbb, 5); call(0x1007_5e64, -0xdd5c);             /* call 0x10075e64 */
            ii(0x1008_3bc0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_3bc2, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_3bc5, 5); call(0x1011_ff4c, 0x9_c382);            /* call 0x1011ff4c */
            ii(0x1008_3bca, 2); test(al, al);                           /* test al, al */
            ii(0x1008_3bcc, 2); if(jnz(0x1008_3bd0, 0x2)) goto l_0x1008_3bd0; /* jnz 0x10083bd0 */
        l_0x1008_3bce:
            ii(0x1008_3bce, 2); jmp(0x1008_3c2e, 0x5e); goto l_0x1008_3c2e; /* jmp 0x10083c2e */
        l_0x1008_3bd0:
            ii(0x1008_3bd0, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3bd3, 4); test(memb[ds, eax + 0x3b], 0x1);        /* test byte [eax+0x3b], 0x1 */
            ii(0x1008_3bd7, 2); if(jz(0x1008_3bf0, 0x17)) goto l_0x1008_3bf0; /* jz 0x10083bf0 */
            ii(0x1008_3bd9, 4); movsx(edx, memw[ss, ebp - 0x16]);       /* movsx edx, word [ebp-0x16] */
            ii(0x1008_3bdd, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1008_3be1, 5); call(0x1007_3d48, -0xfe9e);             /* call 0x10073d48 */
            ii(0x1008_3be6, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1008_3beb, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1008_3bee, 2); if(jz(0x1008_3c2e, 0x3e)) goto l_0x1008_3c2e; /* jz 0x10083c2e */
        l_0x1008_3bf0:
            ii(0x1008_3bf0, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1008_3bf5, 1); push(eax);                              /* push eax */
            ii(0x1008_3bf6, 4); movsx(ecx, memw[ss, ebp - 0x16]);       /* movsx ecx, word [ebp-0x16] */
            ii(0x1008_3bfa, 4); movsx(ebx, memw[ss, ebp - 0x18]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x1008_3bfe, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3c01, 3); mov(edx, memd[ds, eax + 0x7]);          /* mov edx, [eax+0x7] */
            ii(0x1008_3c04, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_3c07, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_3c0a, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1008_3c0d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_3c10, 5); call(0x1007_02b9, -0x1_395c);           /* call 0x100702b9 */
            ii(0x1008_3c15, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1008_3c18, 2); if(jz(0x1008_3c2e, 0x14)) goto l_0x1008_3c2e; /* jz 0x10083c2e */
            ii(0x1008_3c1a, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1008_3c1d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_3c20, 5); call(0x1008_8b44, 0x4f1f);              /* call 0x10088b44 */
            ii(0x1008_3c25, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1008_3c2b, 3); mov(memd[ss, ebp - 0x68], eax);         /* mov [ebp-0x68], eax */
        l_0x1008_3c2e:
            ii(0x1008_3c2e, 5); jmp(0x1008_3a9c, -0x197); goto l_0x1008_3a9c; /* jmp 0x10083a9c */
        l_0x1008_3c33:
            ii(0x1008_3c33, 5); jmp(0x1008_3a82, -0x1b6); goto l_0x1008_3a82; /* jmp 0x10083a82 */
        l_0x1008_3c38:
            ii(0x1008_3c38, 5); jmp(0x1008_3a4b, -0x1f2); goto l_0x1008_3a4b; /* jmp 0x10083a4b */
        l_0x1008_3c3d:
            ii(0x1008_3c3d, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_3c40, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_3c43, 4); mov(memw[ds, edx + 0x1e], ax);          /* mov [edx+0x1e], ax */
            ii(0x1008_3c47, 3); mov(eax, memd[ss, ebp - 0x12]);         /* mov eax, [ebp-0x12] */
            ii(0x1008_3c4a, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_3c4d, 4); mov(memw[ds, edx + 0x20], ax);          /* mov [edx+0x20], ax */
            ii(0x1008_3c51, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_3c54, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_3c57, 4); cmp(ax, memw[ds, edx + 0x1a]);          /* cmp ax, [edx+0x1a] */
            ii(0x1008_3c5b, 2); if(jnz(0x1008_3c69, 0xc)) goto l_0x1008_3c69; /* jnz 0x10083c69 */
            ii(0x1008_3c5d, 3); mov(eax, memd[ss, ebp - 0x12]);         /* mov eax, [ebp-0x12] */
            ii(0x1008_3c60, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_3c63, 4); cmp(ax, memw[ds, edx + 0x1c]);          /* cmp ax, [edx+0x1c] */
            ii(0x1008_3c67, 2); if(jz(0x1008_3c6b, 0x2)) goto l_0x1008_3c6b; /* jz 0x10083c6b */
        l_0x1008_3c69:
            ii(0x1008_3c69, 2); jmp(0x1008_3cc1, 0x56); goto l_0x1008_3cc1; /* jmp 0x10083cc1 */
        l_0x1008_3c6b:
            ii(0x1008_3c6b, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1008_3c6e, 3); add(edx, 0x32);                         /* add edx, 0x32 */
            ii(0x1008_3c71, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_3c74, 5); call(0x1007_6d98, -0xcee1);             /* call 0x10076d98 */
            ii(0x1008_3c79, 2); test(al, al);                           /* test al, al */
            ii(0x1008_3c7b, 2); if(jz(0x1008_3cae, 0x31)) goto l_0x1008_3cae; /* jz 0x10083cae */
            ii(0x1008_3c7d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3c80, 4); cmp(memb[ds, eax + 0x15], 0x5);         /* cmp byte [eax+0x15], 0x5 */
            ii(0x1008_3c84, 2); if(jnz(0x1008_3c97, 0x11)) goto l_0x1008_3c97; /* jnz 0x10083c97 */
            ii(0x1008_3c86, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3c89, 4); mov(memb[ds, eax + 0x15], 0x6);         /* mov byte [eax+0x15], 0x6 */
            ii(0x1008_3c8d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3c90, 5); call(0x1008_5cdb, 0x2046);              /* call 0x10085cdb */
            ii(0x1008_3c95, 2); jmp(0x1008_3cae, 0x17); goto l_0x1008_3cae; /* jmp 0x10083cae */
        l_0x1008_3c97:
            ii(0x1008_3c97, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3c9a, 4); mov(memb[ds, eax + 0x46], 0x1);         /* mov byte [eax+0x46], 0x1 */
            ii(0x1008_3c9e, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3ca1, 5); call(0x1008_61ff, 0x2559);              /* call 0x100861ff */
            ii(0x1008_3ca6, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3ca9, 5); call(0x1008_3369, -0x945);              /* call 0x10083369 */
        l_0x1008_3cae:
            ii(0x1008_3cae, 4); mov(memb[ss, ebp - 0x54], 0);           /* mov byte [ebp-0x54], 0x0 */
            ii(0x1008_3cb2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3cb4, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_3cb7, 5); call(Definitions.my_dtor_d1, 0x5040);   /* call 0x10088cfc */
            ii(0x1008_3cbc, 5); jmp(0x1008_3ea1, 0x1e0); goto l_0x1008_3ea1; /* jmp 0x10083ea1 */
        l_0x1008_3cc1:
            ii(0x1008_3cc1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_3cc4, 3); mov(al, memb[ds, eax + 0x54]);          /* mov al, [eax+0x54] */
            ii(0x1008_3cc7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_3ccc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_3cce, 2); if(jle(0x1008_3cd4, 0x4)) goto l_0x1008_3cd4; /* jle 0x10083cd4 */
            ii(0x1008_3cd0, 4); mov(memb[ss, ebp + 0x10], 0x2);         /* mov byte [ebp+0x10], 0x2 */
        l_0x1008_3cd4:
            ii(0x1008_3cd4, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3cd7, 4); cmp(memb[ds, eax + 0x15], 0x5);         /* cmp byte [eax+0x15], 0x5 */
            ii(0x1008_3cdb, 2); if(jge(0x1008_3cef, 0x12)) goto l_0x1008_3cef; /* jge 0x10083cef */
            ii(0x1008_3cdd, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1008_3ce0, 3); add(edx, 0x32);                         /* add edx, 0x32 */
            ii(0x1008_3ce3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_3ce6, 5); call(0x1007_6d98, -0xcf53);             /* call 0x10076d98 */
            ii(0x1008_3ceb, 2); test(al, al);                           /* test al, al */
            ii(0x1008_3ced, 2); if(jnz(0x1008_3cf4, 0x5)) goto l_0x1008_3cf4; /* jnz 0x10083cf4 */
        l_0x1008_3cef:
            ii(0x1008_3cef, 5); jmp(0x1008_3dbe, 0xca); goto l_0x1008_3dbe; /* jmp 0x10083dbe */
        l_0x1008_3cf4:
            ii(0x1008_3cf4, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3cf7, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_3cfa, 5); call(0x1008_9d08, 0x6009);              /* call 0x10089d08 */
            ii(0x1008_3cff, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_3d01, 6); lea(eax, ebp - 0x8c);                   /* lea eax, [ebp-0x8c] */
            ii(0x1008_3d07, 5); call(0x1008_9be4, 0x5ed8);              /* call 0x10089be4 */
            ii(0x1008_3d0c, 4); or(memb[ss, ebp - 0x38], 0x1);          /* or byte [ebp-0x38], 0x1 */
            ii(0x1008_3d10, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1008_3d16, 5); call(0x1007_64fc, -0xd81f);             /* call 0x100764fc */
            ii(0x1008_3d1b, 6); mov(memd[ss, ebp - 0x94], eax);         /* mov [ebp-0x94], eax */
            ii(0x1008_3d21, 4); and(memb[ss, ebp - 0x38], -0x2 /* 0xfe */); /* and byte [ebp-0x38], 0xfe */
            ii(0x1008_3d25, 2); jmp(0x1008_3d32, 0xb); goto l_0x1008_3d32; /* jmp 0x10083d32 */
        l_0x1008_3d27:
            ii(0x1008_3d27, 6); lea(eax, ebp - 0x8c);                   /* lea eax, [ebp-0x8c] */
            ii(0x1008_3d2d, 5); call(0x1007_6bf8, -0xd13a);             /* call 0x10076bf8 */
        l_0x1008_3d32:
            ii(0x1008_3d32, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3d34, 6); lea(eax, ebp - 0x8c);                   /* lea eax, [ebp-0x8c] */
            ii(0x1008_3d3a, 5); call(0x1013_ad71, 0xb_7032);            /* call 0x1013ad71 */
            ii(0x1008_3d3f, 2); test(al, al);                           /* test al, al */
            ii(0x1008_3d41, 2); if(jz(0x1008_3da4, 0x61)) goto l_0x1008_3da4; /* jz 0x10083da4 */
            ii(0x1008_3d43, 6); lea(eax, ebp - 0x8c);                   /* lea eax, [ebp-0x8c] */
            ii(0x1008_3d49, 5); call(0x1008_9acc, 0x5d7e);              /* call 0x10089acc */
            ii(0x1008_3d4e, 5); call(0x1008_9fc4, 0x6271);              /* call 0x10089fc4 */
            ii(0x1008_3d53, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_3d55, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1008_3d5b, 5); call(0x1007_643c, -0xd924);             /* call 0x1007643c */
            ii(0x1008_3d60, 2); jmp(0x1008_3d6d, 0xb); goto l_0x1008_3d6d; /* jmp 0x10083d6d */
        l_0x1008_3d62:
            ii(0x1008_3d62, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1008_3d68, 5); call(0x1007_6bf8, -0xd175);             /* call 0x10076bf8 */
        l_0x1008_3d6d:
            ii(0x1008_3d6d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3d6f, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1008_3d75, 5); call(0x1013_ad71, 0xb_6ff7);            /* call 0x1013ad71 */
            ii(0x1008_3d7a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_3d7c, 2); if(jz(0x1008_3da2, 0x24)) goto l_0x1008_3da2; /* jz 0x10083da2 */
            ii(0x1008_3d7e, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1008_3d84, 5); call(0x1007_63a0, -0xd9e9);             /* call 0x100763a0 */
            ii(0x1008_3d89, 6); mov(memw[ds, eax + 0x1e], 0);           /* mov word [eax+0x1e], 0x0 */
            ii(0x1008_3d8f, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1008_3d95, 5); call(0x1007_63a0, -0xd9fa);             /* call 0x100763a0 */
            ii(0x1008_3d9a, 6); mov(memw[ds, eax + 0x20], 0);           /* mov word [eax+0x20], 0x0 */
            ii(0x1008_3da0, 2); jmp(0x1008_3d62, -0x40); goto l_0x1008_3d62; /* jmp 0x10083d62 */
        l_0x1008_3da2:
            ii(0x1008_3da2, 2); jmp(0x1008_3d27, -0x7d); goto l_0x1008_3d27; /* jmp 0x10083d27 */
        l_0x1008_3da4:
            ii(0x1008_3da4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3da6, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1008_3dac, 5); call(0x1007_5f6c, -0xde45);             /* call 0x10075f6c */
            ii(0x1008_3db1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3db3, 6); lea(eax, ebp - 0x8c);                   /* lea eax, [ebp-0x8c] */
            ii(0x1008_3db9, 5); call(0x1008_9044, 0x5286);              /* call 0x10089044 */
        l_0x1008_3dbe:
            ii(0x1008_3dbe, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1008_3dc3, 5); call(Definitions.sys_new, 0xe_2038);    /* call 0x10165e00 */
            ii(0x1008_3dc8, 6); mov(memd[ss, ebp - 0x98], eax);         /* mov [ebp-0x98], eax */
            ii(0x1008_3dce, 6); mov(eax, memd[ss, ebp - 0x98]);         /* mov eax, [ebp-0x98] */
            ii(0x1008_3dd4, 6); mov(memd[ss, ebp - 0x9c], eax);         /* mov [ebp-0x9c], eax */
            ii(0x1008_3dda, 7); cmp(memd[ss, ebp - 0x9c], 0);           /* cmp dword [ebp-0x9c], 0x0 */
            ii(0x1008_3de1, 2); if(jz(0x1008_3e24, 0x41)) goto l_0x1008_3e24; /* jz 0x10083e24 */
            ii(0x1008_3de3, 5); mov(eax, 0x100b_0ebb);                  /* mov eax, 0x100b0ebb */
            ii(0x1008_3de8, 1); push(eax);                              /* push eax */
            ii(0x1008_3de9, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1008_3dec, 6); lea(eax, ebp - 0xa0);                   /* lea eax, [ebp-0xa0] */
            ii(0x1008_3df2, 5); call(0x1007_5e64, -0xdf93);             /* call 0x10075e64 */
            ii(0x1008_3df7, 1); push(eax);                              /* push eax */
            ii(0x1008_3df8, 4); movsx(eax, memb[ss, ebp + 0x10]);       /* movsx eax, byte [ebp+0x10] */
            ii(0x1008_3dfc, 1); push(eax);                              /* push eax */
            ii(0x1008_3dfd, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1008_3dff, 3); mov(ebx, memd[ss, ebp - 0xc]);          /* mov ebx, [ebp-0xc] */
            ii(0x1008_3e02, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_3e05, 6); mov(eax, memd[ss, ebp - 0x98]);         /* mov eax, [ebp-0x98] */
            ii(0x1008_3e0b, 5); call(0x100a_c220, 0x2_8410);            /* call 0x100ac220 */
            ii(0x1008_3e10, 6); mov(memd[ss, ebp - 0xa4], eax);         /* mov [ebp-0xa4], eax */
            ii(0x1008_3e16, 6); mov(eax, memd[ss, ebp - 0xa4]);         /* mov eax, [ebp-0xa4] */
            ii(0x1008_3e1c, 6); mov(memd[ss, ebp - 0xa8], eax);         /* mov [ebp-0xa8], eax */
            ii(0x1008_3e22, 2); jmp(0x1008_3e30, 0xc); goto l_0x1008_3e30; /* jmp 0x10083e30 */
        l_0x1008_3e24:
            ii(0x1008_3e24, 6); mov(eax, memd[ss, ebp - 0x9c]);         /* mov eax, [ebp-0x9c] */
            ii(0x1008_3e2a, 6); mov(memd[ss, ebp - 0xa8], eax);         /* mov [ebp-0xa8], eax */
        l_0x1008_3e30:
            ii(0x1008_3e30, 6); mov(edx, memd[ss, ebp - 0xa8]);         /* mov edx, [ebp-0xa8] */
            ii(0x1008_3e36, 6); lea(eax, ebp - 0xac);                   /* lea eax, [ebp-0xac] */
            ii(0x1008_3e3c, 5); call(0x1008_a5f0, 0x67af);              /* call 0x1008a5f0 */
            ii(0x1008_3e41, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_3e46, 6); lea(eax, ebp - 0xac);                   /* lea eax, [ebp-0xac] */
            ii(0x1008_3e4c, 5); call(0x1008_a520, 0x66cf);              /* call 0x1008a520 */
            ii(0x1008_3e51, 5); call(0x1008_a6a4, 0x684e);              /* call 0x1008a6a4 */
            ii(0x1008_3e56, 6); lea(eax, ebp - 0xac);                   /* lea eax, [ebp-0xac] */
            ii(0x1008_3e5c, 5); call(0x1008_a57c, 0x671b);              /* call 0x1008a57c */
            ii(0x1008_3e61, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_3e63, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_3e68, 5); call(0x100a_4d50, 0x2_0ee3);            /* call 0x100a4d50 */
            ii(0x1008_3e6d, 4); mov(memb[ss, ebp - 0x54], 0x1);         /* mov byte [ebp-0x54], 0x1 */
            ii(0x1008_3e71, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3e73, 6); lea(eax, ebp - 0xac);                   /* lea eax, [ebp-0xac] */
            ii(0x1008_3e79, 5); call(0x1008_8d4c, 0x4ece);              /* call 0x10088d4c */
            ii(0x1008_3e7e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3e80, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_3e83, 5); call(Definitions.my_dtor_d1, 0x4e74);   /* call 0x10088cfc */
            ii(0x1008_3e88, 2); jmp(0x1008_3ea1, 0x17); goto l_0x1008_3ea1; /* jmp 0x10083ea1 */
        //  ii(0x1008_3e8a, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_3e8c, 6); lea(eax, ebp - 0xac);                   /* lea eax, [ebp-0xac] */
        //  ii(0x1008_3e92, 5); call(0x1008_8d4c, 0x4eb5);              /* call 0x10088d4c */
        //  ii(0x1008_3e97, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_3e99, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
        //  ii(0x1008_3e9c, 5); call(Definitions.my_dtor_d1, 0x4e5b);   /* call 0x10088cfc */
        l_0x1008_3ea1:
            ii(0x1008_3ea1, 3); mov(al, memb[ss, ebp - 0x54]);          /* mov al, [ebp-0x54] */
            ii(0x1008_3ea4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_3ea6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_3ea7, 1); pop(edi);                               /* pop edi */
            ii(0x1008_3ea8, 1); pop(esi);                               /* pop esi */
            ii(0x1008_3ea9, 3); ret(0x4);                               /* ret 0x4 */
        }
    }
}
