using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_fbcd-b4a3a85e")]
        public void Method_1012_fbcd()
        {
            ii(0x1012_fbcd, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x1012_fbd2, 5); calld(Definitions.sys_check_available_stack_size, 0x3_617b); /* call 0x10165d52 */
            ii(0x1012_fbd7, 1); pushd(esi);                             /* push esi */
            ii(0x1012_fbd8, 1); pushd(edi);                             /* push edi */
            ii(0x1012_fbd9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_fbda, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_fbdc, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1012_fbe2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_fbe5, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1012_fbe8, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1012_fbeb, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1012_fbee, 4); or(memb_a32[ss, ebp - 0x14], 0x1);      /* or byte [ebp-0x14], 0x1 */
            ii(0x1012_fbf2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_fbf5, 5); calld(Definitions.my_string_ctor, 0x1_1eee); /* call 0x10141ae8 */
            ii(0x1012_fbfa, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1012_fbfd, 4); and(memb_a32[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x1012_fc01, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1012_fc06, 5); calld(/* sys */ 0x1016_a24c, 0x3_a641); /* call 0x1016a24c */
            ii(0x1012_fc0b, 4); add(memd_a32[ss, ebp + 0x10], -0x28 /* 0xd8 */); /* add dword [ebp+0x10], 0xffffffd8 */
            ii(0x1012_fc0f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_fc12, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1012_fc16, 2); if(jzd(0x1012_fc21, 0x9)) goto l_0x1012_fc21; /* jz 0x1012fc21 */
            ii(0x1012_fc18, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_fc1b, 4); cmp(memb_a32[ds, eax + 0x3d], 0xb);     /* cmp byte [eax+0x3d], 0xb */
            ii(0x1012_fc1f, 2); if(jnzd(0x1012_fc23, 0x2)) goto l_0x1012_fc23; /* jnz 0x1012fc23 */
        l_0x1012_fc21:
            ii(0x1012_fc21, 2); jmpd(0x1012_fc2c, 0x9); goto l_0x1012_fc2c; /* jmp 0x1012fc2c */
        l_0x1012_fc23:
            ii(0x1012_fc23, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_fc26, 4); cmp(memb_a32[ds, eax + 0x3d], 0x15);    /* cmp byte [eax+0x3d], 0x15 */
            ii(0x1012_fc2a, 2); if(jnzd(0x1012_fc2e, 0x2)) goto l_0x1012_fc2e; /* jnz 0x1012fc2e */
        l_0x1012_fc2c:
            ii(0x1012_fc2c, 2); jmpd(0x1012_fc3b, 0xd); goto l_0x1012_fc3b; /* jmp 0x1012fc3b */
        l_0x1012_fc2e:
            ii(0x1012_fc2e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_fc31, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1f);    /* cmp byte [eax+0x3d], 0x1f */
            ii(0x1012_fc35, 6); if(jnzd(0x1012_fdd3, 0x198)) goto l_0x1012_fdd3; /* jnz 0x1012fdd3 */
        l_0x1012_fc3b:
            ii(0x1012_fc3b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_fc3e, 5); cmp(memw_a32[ds, eax + 0x8], 0x3e);     /* cmp word [eax+0x8], 0x3e */
            ii(0x1012_fc43, 2); if(jnzd(0x1012_fc6e, 0x29)) goto l_0x1012_fc6e; /* jnz 0x1012fc6e */
            ii(0x1012_fc45, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_fc48, 3); mov(al, memb_a32[ds, eax + 0x45]);      /* mov al, [eax+0x45] */
            ii(0x1012_fc4b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_fc50, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fc51, 5); mov(eax, StringDefinitions.NumberOfTurnsToClearSiteI2); /* mov eax, 0x101a87f4 */
            ii(0x1012_fc56, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fc57, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1012_fc5c, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fc5d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_fc60, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fc61, 5); calld(0x1014_2037, 0x1_23d1);           /* call 0x10142037 */
            ii(0x1012_fc66, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1012_fc69, 5); jmpd(0x1012_fdd1, 0x163); goto l_0x1012_fdd1; /* jmp 0x1012fdd1 */
        l_0x1012_fc6e:
            ii(0x1012_fc6e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_fc71, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1f);    /* cmp byte [eax+0x3e], 0x1f */
            ii(0x1012_fc75, 2); if(jnzd(0x1012_fc9c, 0x25)) goto l_0x1012_fc9c; /* jnz 0x1012fc9c */
            ii(0x1012_fc77, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_fc7a, 5); calld(0x1010_07c8, -0x2_f4b7);          /* call 0x101007c8 */
            ii(0x1012_fc7f, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1012_fc82, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1012_fc85, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_fc88, 5); calld(0x1014_2246, 0x1_25b9);           /* call 0x10142246 */
            ii(0x1012_fc8d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_fc8f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1012_fc92, 5); calld(Definitions.my_string_dtor, 0x1_1e93); /* call 0x10141b2a */
            ii(0x1012_fc97, 5); jmpd(0x1012_fdd1, 0x135); goto l_0x1012_fdd1; /* jmp 0x1012fdd1 */
        l_0x1012_fc9c:
            ii(0x1012_fc9c, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1012_fc9f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_fca2, 5); calld(0x1015_0a5f, 0x2_0db8);           /* call 0x10150a5f */
            ii(0x1012_fca7, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1012_fcaa, 5); calld(Definitions.my_2_get_count, -0xa_4947); /* call 0x1008b368 */
            ii(0x1012_fcaf, 1); cwde();                                 /* cwde */
            ii(0x1012_fcb0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_fcb2, 2); if(jled(0x1012_fcbd, 0x9)) goto l_0x1012_fcbd; /* jle 0x1012fcbd */
            ii(0x1012_fcb4, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1012_fcbb, 2); jmpd(0x1012_fcd6, 0x19); goto l_0x1012_fcd6; /* jmp 0x1012fcd6 */
        l_0x1012_fcbd:
            ii(0x1012_fcbd, 5); mov(ecx, 0x506);                        /* mov ecx, 0x506 */
            ii(0x1012_fcc2, 5); mov(ebx, StringDefinitions.ReportsCpp); /* mov ebx, 0x101a8817 */
            ii(0x1012_fcc7, 5); mov(edx, StringDefinitions.BuildListGetcountGreater04); /* mov edx, 0x101a8823 */
            ii(0x1012_fccc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_fcce, 5); calld(Definitions.sys_assert, 0x3_60bf); /* call 0x10165d92 */
            ii(0x1012_fcd3, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x1012_fcd6:
            ii(0x1012_fcd6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_fcd9, 4); cmp(memb_a32[ds, eax + 0x3d], 0x15);    /* cmp byte [eax+0x3d], 0x15 */
            ii(0x1012_fcdd, 2); if(jzd(0x1012_fce8, 0x9)) goto l_0x1012_fce8; /* jz 0x1012fce8 */
            ii(0x1012_fcdf, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_fce2, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1f);    /* cmp byte [eax+0x3d], 0x1f */
            ii(0x1012_fce6, 2); if(jnzd(0x1012_fd24, 0x3c)) goto l_0x1012_fd24; /* jnz 0x1012fd24 */
        l_0x1012_fce8:
            ii(0x1012_fce8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_fceb, 3); mov(al, memb_a32[ds, eax + 0x45]);      /* mov al, [eax+0x45] */
            ii(0x1012_fcee, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_fcf3, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fcf4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_fcf6, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1012_fcf9, 5); calld(0x1008_b228, -0xa_4ad6);          /* call 0x1008b228 */
            ii(0x1012_fcfe, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1012_fd01, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1012_fd04, 6); pushd(memd_a32[ds, eax + 0x101c_81d7]); /* push dword [eax+0x101c81d7] */
            ii(0x1012_fd0a, 5); mov(eax, StringDefinitions.WasBuildingSWithITurnsToCompletion2); /* mov eax, 0x101a883d */
            ii(0x1012_fd0f, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fd10, 5); mov(eax, 0xc8);                         /* mov eax, 0xc8 */
            ii(0x1012_fd15, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fd16, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_fd19, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fd1a, 5); calld(0x1014_2037, 0x1_2318);           /* call 0x10142037 */
            ii(0x1012_fd1f, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x1012_fd22, 2); jmpd(0x1012_fd7a, 0x56); goto l_0x1012_fd7a; /* jmp 0x1012fd7a */
        l_0x1012_fd24:
            ii(0x1012_fd24, 3); lea(ecx, ebp - 0x2c);                   /* lea ecx, [ebp-0x2c] */
            ii(0x1012_fd27, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_fd2a, 5); calld(0x1009_c9a0, -0x9_338f);          /* call 0x1009c9a0 */
            ii(0x1012_fd2f, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1012_fd32, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_fd34, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1012_fd37, 5); calld(0x1008_b228, -0xa_4b14);          /* call 0x1008b228 */
            ii(0x1012_fd3c, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1012_fd3f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_fd42, 5); calld(0x1015_4f88, 0x2_5241);           /* call 0x10154f88 */
            ii(0x1012_fd47, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x1012_fd4b, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fd4c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_fd4e, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1012_fd51, 5); calld(0x1008_b228, -0xa_4b2e);          /* call 0x1008b228 */
            ii(0x1012_fd56, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1012_fd59, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1012_fd5c, 6); pushd(memd_a32[ds, eax + 0x101c_81d7]); /* push dword [eax+0x101c81d7] */
            ii(0x1012_fd62, 5); mov(eax, StringDefinitions.CurrentlyBuildingSTurnsToCompletionI2); /* mov eax, 0x101a886b */
            ii(0x1012_fd67, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fd68, 5); mov(eax, 0xc8);                         /* mov eax, 0xc8 */
            ii(0x1012_fd6d, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fd6e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_fd71, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fd72, 5); calld(0x1014_2037, 0x1_22c0);           /* call 0x10142037 */
            ii(0x1012_fd77, 3); add(esp, 0x14);                         /* add esp, 0x14 */
        l_0x1012_fd7a:
            ii(0x1012_fd7a, 4); movsx(edx, memw_a32[ss, ebp + 0x14]);   /* movsx edx, word [ebp+0x14] */
            ii(0x1012_fd7e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_fd80, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_fd83, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1012_fd85, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1012_fd87, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1012_fd8b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_fd8d, 1); cwde();                                 /* cwde */
            ii(0x1012_fd8e, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fd8f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_fd92, 3); add(eax, memd_a32[ss, ebp + 0x10]);     /* add eax, [ebp+0x10] */
            ii(0x1012_fd95, 5); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1012_fd9a, 1); cwde();                                 /* cwde */
            ii(0x1012_fd9b, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fd9c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_fd9e, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_fda3, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1012_fda6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_fda8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1012_fdab, 5); calld(0x1008_b228, -0xa_4b88);          /* call 0x1008b228 */
            ii(0x1012_fdb0, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x1012_fdb3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_fdb6, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x1012_fdb9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_fdbc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_fdbf, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1012_fdc2, 5); calld(0x1012_b6af, -0x4718);            /* call 0x1012b6af */
            ii(0x1012_fdc7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_fdc9, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1012_fdcc, 5); calld(0x1008_8b04, -0xa_72cd);          /* call 0x10088b04 */
        l_0x1012_fdd1:
            ii(0x1012_fdd1, 2); jmpd(0x1012_fdf3, 0x20); goto l_0x1012_fdf3; /* jmp 0x1012fdf3 */
        l_0x1012_fdd3:
            ii(0x1012_fdd3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_fdd6, 5); calld(0x1010_07c8, -0x2_f613);          /* call 0x101007c8 */
            ii(0x1012_fddb, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1012_fdde, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x1012_fde1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_fde4, 5); calld(0x1014_2246, 0x1_245d);           /* call 0x10142246 */
            ii(0x1012_fde9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_fdeb, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1012_fdee, 5); calld(Definitions.my_string_dtor, 0x1_1d37); /* call 0x10141b2a */
        l_0x1012_fdf3:
            ii(0x1012_fdf3, 5); calld(0x100d_531c, -0x5_aadc);          /* call 0x100d531c */
            ii(0x1012_fdf8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_fdfd, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fdfe, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_fe00, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fe01, 5); pushd(0xa2);                            /* push 0xa2 */
            ii(0x1012_fe06, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1012_fe0a, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fe0b, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x1012_fe0f, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fe10, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1012_fe14, 1); pushd(eax);                             /* push eax */
            ii(0x1012_fe15, 4); movsx(ecx, memw_a32[ss, ebp - 0x8]);    /* movsx ecx, word [ebp-0x8] */
            ii(0x1012_fe19, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_fe1c, 5); calld(Definitions.my_strobj_c_str_v2, -0xa_6659); /* call 0x100897c8 */
            ii(0x1012_fe21, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1012_fe23, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_fe26, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x1012_fe29, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_fe2c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_fe2f, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1012_fe32, 5); calld(0x100e_9ae5, -0x4_6352);          /* call 0x100e9ae5 */
            ii(0x1012_fe37, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_fe39, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_fe3c, 5); calld(Definitions.my_string_dtor, 0x1_1ce9); /* call 0x10141b2a */
            ii(0x1012_fe41, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_fe43, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_fe44, 1); popd(edi);                              /* pop edi */
            ii(0x1012_fe45, 1); popd(esi);                              /* pop esi */
            ii(0x1012_fe46, 3); retd(0x8); return;                      /* ret 0x8 */
        }
    }
}
