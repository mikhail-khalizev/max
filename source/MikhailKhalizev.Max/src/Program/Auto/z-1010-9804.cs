using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("568edf2c-a5c9-4689-930e-e712c65a9e08")]
        public void Method_1010_9804()
        {
            ii(0x1010_9804, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1010_9809, 5); calld(Definitions.sys_check_available_stack_size, 0x5_c544); /* call 0x10165d52 */
            ii(0x1010_980e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_980f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_9810, 1); pushd(edx);                             /* push edx */
            ii(0x1010_9811, 1); pushd(esi);                             /* push esi */
            ii(0x1010_9812, 1); pushd(edi);                             /* push edi */
            ii(0x1010_9813, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_9814, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_9816, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1010_981c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_981f, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1010_9824, 5); calld(/* sys */ 0x1016_a24c, 0x6_0a23); /* call 0x1016a24c */
            ii(0x1010_9829, 5); mov(eax, 0x764);                        /* mov eax, 0x764 */
            ii(0x1010_982e, 5); calld(Definitions.my_get_res_data_by_id_malloc, 0x2_a9b8); /* call 0x101341eb */
            ii(0x1010_9833, 5); mov(memd_a32[ds, 0x101c_4dd8], eax);    /* mov [0x101c4dd8], eax */
            ii(0x1010_9838, 6); calld_abs(memd_a32[ds, 0x101b_ddf0]);   /* call dword [0x101bddf0] */
            ii(0x1010_983e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_9840, 5); mov(eax, 0xec);                         /* mov eax, 0xec */
            ii(0x1010_9845, 5); mov(edx, 0xec);                         /* mov edx, 0xec */
            ii(0x1010_984a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_984d, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_984f, 6); mov(memw_a32[ds, 0x101c_4de8], ax);     /* mov [0x101c4de8], ax */
            ii(0x1010_9855, 5); mov(ecx, 0x101c_4dec);                  /* mov ecx, 0x101c4dec */
            ii(0x1010_985a, 5); mov(ebx, 0x128);                        /* mov ebx, 0x128 */
            ii(0x1010_985f, 8); imul(ax, memw_a32[ds, 0x101c_4de8], 0x64); /* imul ax, [0x101c4de8], 0x64 */
            ii(0x1010_9867, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1010_986a, 5); mov(eax, memd_a32[ds, 0x101c_4dd8]);    /* mov eax, [0x101c4dd8] */
            ii(0x1010_986f, 5); calld(0x100e_969d, -0x2_01d7);          /* call 0x100e969d */
            ii(0x1010_9874, 5); mov(memd_a32[ds, 0x101c_4ddc], eax);    /* mov [0x101c4ddc], eax */
            ii(0x1010_9879, 9); mov(memw_a32[ds, 0x101c_4dea], 0);      /* mov word [0x101c4dea], 0x0 */
            ii(0x1010_9882, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_9887, 5); calld(Definitions.sys_new, 0x5_c574);   /* call 0x10165e00 */
            ii(0x1010_988c, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_988f, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_9892, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1010_9895, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1010_9899, 2); if(jzd(0x1010_98c3, 0x28)) goto l_0x1010_98c3; /* jz 0x101098c3 */
            ii(0x1010_989b, 5); mov(eax, 0x1b6);                        /* mov eax, 0x1b6 */
            ii(0x1010_98a0, 1); pushd(eax);                             /* push eax */
            ii(0x1010_98a1, 5); mov(ecx, 0x10);                         /* mov ecx, 0x10 */
            ii(0x1010_98a6, 5); mov(ebx, 0x344);                        /* mov ebx, 0x344 */
            ii(0x1010_98ab, 5); mov(edx, 0x343);                        /* mov edx, 0x343 */
            ii(0x1010_98b0, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_98b3, 5); calld(Definitions.my_ctor_c17, -0x3_b4a9); /* call 0x100ce40f */
            ii(0x1010_98b8, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1010_98bb, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1010_98be, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_98c1, 2); jmpd(0x1010_98c9, 0x6); goto l_0x1010_98c9; /* jmp 0x101098c9 */
        l_0x1010_98c3:
            ii(0x1010_98c3, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1010_98c6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1010_98c9:
            ii(0x1010_98c9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_98cc, 5); mov(memd_a32[ds, 0x101c_4de0], eax);    /* mov [0x101c4de0], eax */
            ii(0x1010_98d1, 5); mov(edx, 0x3e8);                        /* mov edx, 0x3e8 */
            ii(0x1010_98d6, 5); mov(eax, memd_a32[ds, 0x101c_4de0]);    /* mov eax, [0x101c4de0] */
            ii(0x1010_98db, 5); calld(0x100d_5134, -0x3_47ac);          /* call 0x100d5134 */
            ii(0x1010_98e0, 5); mov(edx, 0x73e8);                       /* mov edx, 0x73e8 */
            ii(0x1010_98e5, 5); mov(eax, memd_a32[ds, 0x101c_4de0]);    /* mov eax, [0x101c4de0] */
            ii(0x1010_98ea, 5); calld(0x100d_5164, -0x3_478b);          /* call 0x100d5164 */
            ii(0x1010_98ef, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x1010_98f4, 5); mov(eax, memd_a32[ds, 0x101c_4de0]);    /* mov eax, [0x101c4de0] */
            ii(0x1010_98f9, 5); calld(0x100d_50d4, -0x3_482a);          /* call 0x100d50d4 */
            ii(0x1010_98fe, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_9901, 3); mov(edx, memd_a32[ds, eax + 0x12]);     /* mov edx, [eax+0x12] */
            ii(0x1010_9904, 5); mov(eax, memd_a32[ds, 0x101c_4de0]);    /* mov eax, [0x101c4de0] */
            ii(0x1010_9909, 5); calld(0x100c_f85c, -0x3_a0b2);          /* call 0x100cf85c */
            ii(0x1010_990e, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_9913, 5); calld(Definitions.sys_new, 0x5_c4e8);   /* call 0x10165e00 */
            ii(0x1010_9918, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_991b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_991e, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_9921, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1010_9925, 2); if(jzd(0x1010_994f, 0x28)) goto l_0x1010_994f; /* jz 0x1010994f */
            ii(0x1010_9927, 5); mov(eax, 0x1b6);                        /* mov eax, 0x1b6 */
            ii(0x1010_992c, 1); pushd(eax);                             /* push eax */
            ii(0x1010_992d, 5); mov(ecx, 0x30);                         /* mov ecx, 0x30 */
            ii(0x1010_9932, 5); mov(ebx, 0x346);                        /* mov ebx, 0x346 */
            ii(0x1010_9937, 5); mov(edx, 0x345);                        /* mov edx, 0x345 */
            ii(0x1010_993c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_993f, 5); calld(Definitions.my_ctor_c17, -0x3_b535); /* call 0x100ce40f */
            ii(0x1010_9944, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1010_9947, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_994a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_994d, 2); jmpd(0x1010_9955, 0x6); goto l_0x1010_9955; /* jmp 0x10109955 */
        l_0x1010_994f:
            ii(0x1010_994f, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_9952, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1010_9955:
            ii(0x1010_9955, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_9958, 5); mov(memd_a32[ds, 0x101c_4de4], eax);    /* mov [0x101c4de4], eax */
            ii(0x1010_995d, 5); mov(edx, 0x3e9);                        /* mov edx, 0x3e9 */
            ii(0x1010_9962, 5); mov(eax, memd_a32[ds, 0x101c_4de4]);    /* mov eax, [0x101c4de4] */
            ii(0x1010_9967, 5); calld(0x100d_5134, -0x3_4838);          /* call 0x100d5134 */
            ii(0x1010_996c, 5); mov(edx, 0x73e9);                       /* mov edx, 0x73e9 */
            ii(0x1010_9971, 5); mov(eax, memd_a32[ds, 0x101c_4de4]);    /* mov eax, [0x101c4de4] */
            ii(0x1010_9976, 5); calld(0x100d_5164, -0x3_4817);          /* call 0x100d5164 */
            ii(0x1010_997b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_997e, 3); mov(edx, memd_a32[ds, eax + 0x12]);     /* mov edx, [eax+0x12] */
            ii(0x1010_9981, 5); mov(eax, memd_a32[ds, 0x101c_4de4]);    /* mov eax, [0x101c4de4] */
            ii(0x1010_9986, 5); calld(0x100c_f85c, -0x3_a12f);          /* call 0x100cf85c */
            ii(0x1010_998b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_998e, 5); calld(0x1010_96e0, -0x2b3);             /* call 0x101096e0 */
            ii(0x1010_9993, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_9996, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_9999, 5); calld(Definitions.sys_display_draw_0, 0x5_dae6); /* call 0x10167484 */
            ii(0x1010_999e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_99a0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_99a1, 1); popd(edi);                              /* pop edi */
            ii(0x1010_99a2, 1); popd(esi);                              /* pop esi */
            ii(0x1010_99a3, 1); popd(edx);                              /* pop edx */
            ii(0x1010_99a4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_99a5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_99a6, 1); retd(); return;                         /* ret */
        }
    }
}
