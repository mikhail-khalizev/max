using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_fe49-93efcece")]
        public void Method_1012_fe49()
        {
            ii(0x1012_fe49, 5); push(0xd0);                             /* push 0xd0 */
            ii(0x1012_fe4e, 5); call(Definitions.sys_check_available_stack_size, 0x3_5eff); /* call 0x10165d52 */
            ii(0x1012_fe53, 1); push(ebx);                              /* push ebx */
            ii(0x1012_fe54, 1); push(ecx);                              /* push ecx */
            ii(0x1012_fe55, 1); push(edx);                              /* push edx */
            ii(0x1012_fe56, 1); push(esi);                              /* push esi */
            ii(0x1012_fe57, 1); push(edi);                              /* push edi */
            ii(0x1012_fe58, 1); push(ebp);                              /* push ebp */
            ii(0x1012_fe59, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_fe5b, 6); sub(esp, 0x98);                         /* sub esp, 0x98 */
            ii(0x1012_fe61, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_fe64, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_fe67, 3); mov(ebx, memd[ds, eax + 0x38]);         /* mov ebx, [eax+0x38] */
            ii(0x1012_fe6a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_fe6d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_fe70, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_fe76, 5); call(0x100d_4f24, -0x5_af57);           /* call 0x100d4f24 */
            ii(0x1012_fe7b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_fe7e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_fe80, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_fe83, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_fe85, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1012_fe88, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_fe8b, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_fe91, 5); call(0x100d_4ef0, -0x5_afa6);           /* call 0x100d4ef0 */
            ii(0x1012_fe96, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_fe99, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_fe9c, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_fe9f, 5); call(Definitions.my_1_get_count, -0x8_49cc); /* call 0x100ab4d8 */
            ii(0x1012_fea4, 1); cwde();                                 /* cwde */
            ii(0x1012_fea5, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_fea8, 3); mov(ecx, memd[ds, edx + 0x38]);         /* mov ecx, [edx+0x38] */
            ii(0x1012_feab, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1012_feae, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_feb1, 3); mov(ebx, memd[ds, edx + 0x2e]);         /* mov ebx, [edx+0x2e] */
            ii(0x1012_feb4, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_feb7, 2); add(ebx, ecx);                          /* add ebx, ecx */
            ii(0x1012_feb9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_febb, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1012_febd, 5); call(Definitions.my_min, -0xa_673e);    /* call 0x10089784 */
            ii(0x1012_fec2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1012_fec5, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x1012_fec8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_fecb, 5); call(0x100d_6a11, -0x5_94bf);           /* call 0x100d6a11 */
            ii(0x1012_fed0, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1012_fed4, 3); sub(edx, 0x32);                         /* sub edx, 0x32 */
            ii(0x1012_fed7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_fed9, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_fedc, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1012_fede, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1012_fee0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_fee2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_fee5, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_feeb, 5); call(0x100d_4ebc, -0x5_b034);           /* call 0x100d4ebc */
            ii(0x1012_fef0, 1); cwde();                                 /* cwde */
            ii(0x1012_fef1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_fef3, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_fef6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_fef9, 4); mov(ax, memw[ds, eax + 0x30]);          /* mov ax, [eax+0x30] */
            ii(0x1012_fefd, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1012_ff00, 2); jmp(0x1012_ff08, 0x6); goto l_0x1012_ff08; /* jmp 0x1012ff08 */
        l_0x1012_ff02:
            ii(0x1012_ff02, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_ff05, 3); inc(memd[ss, ebp - 0x14]);              /* inc dword [ebp-0x14] */
        l_0x1012_ff08:
            ii(0x1012_ff08, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_ff0b, 4); cmp(ax, memw[ss, ebp - 0xc]);           /* cmp ax, [ebp-0xc] */
            ii(0x1012_ff0f, 6); if(jge(0x1013_01b0, 0x29b)) goto l_0x1013_01b0; /* jge 0x101301b0 */
            ii(0x1012_ff15, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_ff18, 5); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1012_ff1d, 1); cwde();                                 /* cwde */
            ii(0x1012_ff1e, 1); push(eax);                              /* push eax */
            ii(0x1012_ff1f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_ff22, 5); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x1012_ff27, 1); cwde();                                 /* cwde */
            ii(0x1012_ff28, 1); push(eax);                              /* push eax */
            ii(0x1012_ff29, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_ff2b, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1012_ff30, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1012_ff33, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1012_ff37, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_ff3a, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_ff3d, 5); call(0x100e_8634, -0x4_790e);           /* call 0x100e8634 */
            ii(0x1012_ff42, 3); mov(ebx, memd[ds, eax + 0x6]);          /* mov ebx, [eax+0x6] */
            ii(0x1012_ff45, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_ff48, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1012_ff4c, 3); mov(eax, memd[ss, ebp - 0x1e]);         /* mov eax, [ebp-0x1e] */
            ii(0x1012_ff4f, 5); call(0x1012_b6af, -0x48a5);             /* call 0x1012b6af */
            ii(0x1012_ff54, 3); lea(ecx, ebp - 0x68);                   /* lea ecx, [ebp-0x68] */
            ii(0x1012_ff57, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1012_ff5b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_ff5e, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_ff61, 5); call(0x100e_8634, -0x4_7932);           /* call 0x100e8634 */
            ii(0x1012_ff66, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1012_ff68, 5); call(0x1014_fa43, 0x1_fad6);            /* call 0x1014fa43 */
            ii(0x1012_ff6d, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1012_ff72, 5); call(/* sys */ 0x1016_a24c, 0x3_a2d5);  /* call 0x1016a24c */
            ii(0x1012_ff77, 5); call(0x100d_531c, -0x5_ac60);           /* call 0x100d531c */
            ii(0x1012_ff7c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_ff81, 1); push(eax);                              /* push eax */
            ii(0x1012_ff82, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_ff84, 1); push(eax);                              /* push eax */
            ii(0x1012_ff85, 5); push(0xa2);                             /* push 0xa2 */
            ii(0x1012_ff8a, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1012_ff8f, 1); push(eax);                              /* push eax */
            ii(0x1012_ff90, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1012_ff95, 1); push(eax);                              /* push eax */
            ii(0x1012_ff96, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1012_ff9a, 1); push(eax);                              /* push eax */
            ii(0x1012_ff9b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_ff9e, 5); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x1012_ffa3, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1012_ffa6, 3); lea(ebx, ebp - 0x68);                   /* lea ebx, [ebp-0x68] */
            ii(0x1012_ffa9, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1012_ffad, 3); mov(eax, memd[ss, ebp - 0x1e]);         /* mov eax, [ebp-0x1e] */
            ii(0x1012_ffb0, 5); call(0x100e_9ae5, -0x4_64d0);           /* call 0x100e9ae5 */
            ii(0x1012_ffb5, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_ffb9, 3); add(eax, 0x75);                         /* add eax, 0x75 */
            ii(0x1012_ffbc, 3); mov(memd[ss, ebp - 0x78], eax);         /* mov [ebp-0x78], eax */
            ii(0x1012_ffbf, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1012_ffc3, 3); mov(memd[ss, ebp - 0x74], eax);         /* mov [ebp-0x74], eax */
            ii(0x1012_ffc6, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_ffca, 5); add(eax, 0x104);                        /* add eax, 0x104 */
            ii(0x1012_ffcf, 3); mov(memd[ss, ebp - 0x70], eax);         /* mov [ebp-0x70], eax */
            ii(0x1012_ffd2, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1012_ffd6, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1012_ffd9, 3); mov(memd[ss, ebp - 0x6c], eax);         /* mov [ebp-0x6c], eax */
            ii(0x1012_ffdc, 3); lea(ebx, ebp - 0x78);                   /* lea ebx, [ebp-0x78] */
            ii(0x1012_ffdf, 3); mov(ecx, memd[ss, ebp - 0x22]);         /* mov ecx, [ebp-0x22] */
            ii(0x1012_ffe2, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1012_ffe6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_ffe9, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_ffec, 5); call(0x100e_8634, -0x4_79bd);           /* call 0x100e8634 */
            ii(0x1012_fff1, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1012_fff3, 5); call(0x1012_c469, -0x3b8f);             /* call 0x1012c469 */
            ii(0x1012_fff8, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1012_fffd, 5); call(/* sys */ 0x1016_a24c, 0x3_a24a);  /* call 0x1016a24c */
            ii(0x1013_0002, 5); call(0x100d_531c, -0x5_aceb);           /* call 0x100d531c */
            ii(0x1013_0007, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_000c, 1); push(eax);                              /* push eax */
            ii(0x1013_000d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1013_0012, 1); push(eax);                              /* push eax */
            ii(0x1013_0013, 5); push(0xa2);                             /* push 0xa2 */
            ii(0x1013_0018, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1013_001d, 1); push(eax);                              /* push eax */
            ii(0x1013_001e, 5); mov(eax, 0x28);                         /* mov eax, 0x28 */
            ii(0x1013_0023, 1); push(eax);                              /* push eax */
            ii(0x1013_0024, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1013_0028, 1); push(eax);                              /* push eax */
            ii(0x1013_0029, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_002c, 5); add(eax, 0x109);                        /* add eax, 0x109 */
            ii(0x1013_0031, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1013_0034, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1013_0038, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_003b, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1013_003e, 5); call(0x100e_8634, -0x4_7a0f);           /* call 0x100e8634 */
            ii(0x1013_0043, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x1013_0046, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_0049, 1); inc(eax);                               /* inc eax */
            ii(0x1013_004a, 1); push(eax);                              /* push eax */
            ii(0x1013_004b, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1013_004f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_0052, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1013_0055, 5); call(0x100e_8634, -0x4_7a26);           /* call 0x100e8634 */
            ii(0x1013_005a, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1013_005d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_0060, 1); inc(eax);                               /* inc eax */
            ii(0x1013_0061, 1); push(eax);                              /* push eax */
            ii(0x1013_0062, 5); mov(eax, StringDefinitions.II2);        /* mov eax, 0x101a889c */
            ii(0x1013_0067, 1); push(eax);                              /* push eax */
            ii(0x1013_0068, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1013_006d, 1); push(eax);                              /* push eax */
            ii(0x1013_006e, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1013_0071, 5); call(Definitions.my_string_ctor, 0x1_1a72); /* call 0x10141ae8 */
            ii(0x1013_0076, 1); push(eax);                              /* push eax */
            ii(0x1013_0077, 5); call(0x1014_2037, 0x1_1fbb);            /* call 0x10142037 */
            ii(0x1013_007c, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x1013_007f, 5); call(Definitions.my_strobj_c_str_v2, -0xa_68bc); /* call 0x100897c8 */
            ii(0x1013_0084, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1013_0088, 3); mov(esi, memd[ss, ebp - 0x1e]);         /* mov esi, [ebp-0x1e] */
            ii(0x1013_008b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_008d, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1013_008f, 5); call(0x100e_9ae5, -0x4_65af);           /* call 0x100e9ae5 */
            ii(0x1013_0094, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_0096, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1013_0099, 5); call(Definitions.my_string_dtor, 0x1_1a8c); /* call 0x10141b2a */
            ii(0x1013_009e, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1013_00a3, 1); push(eax);                              /* push eax */
            ii(0x1013_00a4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_00a7, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1013_00ad, 5); call(0x100d_4f58, -0x5_b15a);           /* call 0x100d4f58 */
            ii(0x1013_00b2, 6); sub(eax, 0x136);                        /* sub eax, 0x136 */
            ii(0x1013_00b8, 1); cwde();                                 /* cwde */
            ii(0x1013_00b9, 1); push(eax);                              /* push eax */
            ii(0x1013_00ba, 4); movsx(ecx, memw[ss, ebp - 0x8]);        /* movsx ecx, word [ebp-0x8] */
            ii(0x1013_00be, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_00c1, 5); add(eax, 0x136);                        /* add eax, 0x136 */
            ii(0x1013_00c6, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1013_00c9, 3); lea(esi, ebp - 0x34);                   /* lea esi, [ebp-0x34] */
            ii(0x1013_00cc, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1013_00d0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_00d3, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1013_00d6, 5); call(0x100e_8634, -0x4_7aa7);           /* call 0x100e8634 */
            ii(0x1013_00db, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1013_00dd, 5); call(0x1012_fbcd, -0x515);              /* call 0x1012fbcd */
            ii(0x1013_00e2, 5); mov(ebx, 0x101c_37bc);                  /* mov ebx, 0x101c37bc */
            ii(0x1013_00e7, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1013_00eb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_00ee, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1013_00f1, 5); call(0x100e_8634, -0x4_7ac2);           /* call 0x100e8634 */
            ii(0x1013_00f6, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1013_00f8, 5); call(0x1007_6d98, -0xb_9365);           /* call 0x10076d98 */
            ii(0x1013_00fd, 2); test(al, al);                           /* test al, al */
            ii(0x1013_00ff, 6); if(jz(0x1013_01a5, 0xa0)) goto l_0x1013_01a5; /* jz 0x101301a5 */
            ii(0x1013_0105, 5); call(0x100d_50b4, -0x5_b056);           /* call 0x100d50b4 */
            ii(0x1013_010a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_010f, 3); mov(memd[ss, ebp - 0x80], eax);         /* mov [ebp-0x80], eax */
            ii(0x1013_0112, 3); push(memd[ss, ebp - 0x80]);             /* push dword [ebp-0x80] */
            ii(0x1013_0115, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1013_0119, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_011c, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1013_011f, 5); call(0x100e_8634, -0x4_7af0);           /* call 0x100e8634 */
            ii(0x1013_0124, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1013_0127, 3); and(eax, 0x10);                         /* and eax, 0x10 */
            ii(0x1013_012a, 6); mov(memd[ss, ebp - 0x84], eax);         /* mov [ebp-0x84], eax */
            ii(0x1013_0130, 6); push(memd[ss, ebp - 0x84]);             /* push dword [ebp-0x84] */
            ii(0x1013_0136, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1013_013a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_013d, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1013_0140, 5); call(0x100e_8634, -0x4_7b11);           /* call 0x100e8634 */
            ii(0x1013_0145, 4); test(memb[ds, eax + 0x12], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1013_0149, 2); if(jz(0x1013_0157, 0xc)) goto l_0x1013_0157; /* jz 0x10130157 */
            ii(0x1013_014b, 10); mov(memd[ss, ebp - 0x88], 0x4_0000);   /* mov dword [ebp-0x88], 0x40000 */
            ii(0x1013_0155, 2); jmp(0x1013_0161, 0xa); goto l_0x1013_0161; /* jmp 0x10130161 */
        l_0x1013_0157:
            ii(0x1013_0157, 10); mov(memd[ss, ebp - 0x88], 0x2_0000);   /* mov dword [ebp-0x88], 0x20000 */
        l_0x1013_0161:
            ii(0x1013_0161, 6); push(memd[ss, ebp - 0x88]);             /* push dword [ebp-0x88] */
            ii(0x1013_0167, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_016a, 5); add(eax, 0x29);                         /* add eax, 0x29 */
            ii(0x1013_016f, 1); cwde();                                 /* cwde */
            ii(0x1013_0170, 1); push(eax);                              /* push eax */
            ii(0x1013_0171, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_0174, 5); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1013_0179, 1); cwde();                                 /* cwde */
            ii(0x1013_017a, 1); push(eax);                              /* push eax */
            ii(0x1013_017b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_017e, 5); add(eax, 0x9);                          /* add eax, 0x9 */
            ii(0x1013_0183, 1); cwde();                                 /* cwde */
            ii(0x1013_0184, 1); push(eax);                              /* push eax */
            ii(0x1013_0185, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_0189, 1); push(eax);                              /* push eax */
            ii(0x1013_018a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_018d, 5); add(eax, 0x9);                          /* add eax, 0x9 */
            ii(0x1013_0192, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1013_0195, 4); movsx(ebx, memw[ss, ebp - 0x10]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x1013_0199, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1013_019d, 3); mov(eax, memd[ss, ebp - 0x1e]);         /* mov eax, [ebp-0x1e] */
            ii(0x1013_01a0, 5); call(0x1010_2273, -0x2_df32);           /* call 0x10102273 */
        l_0x1013_01a5:
            ii(0x1013_01a5, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_01a8, 3); add(memd[ss, ebp - 0x8], eax);          /* add [ebp-0x8], eax */
            ii(0x1013_01ab, 5); jmp(0x1012_ff02, -0x2ae); goto l_0x1012_ff02; /* jmp 0x1012ff02 */
        l_0x1013_01b0:
            ii(0x1013_01b0, 5); call(0x100d_51e4, -0x5_afd1);           /* call 0x100d51e4 */
            ii(0x1013_01b5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_01ba, 6); mov(memd[ss, ebp - 0x8c], eax);         /* mov [ebp-0x8c], eax */
            ii(0x1013_01c0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_01c3, 3); mov(eax, memd[ds, eax + 0x2e]);         /* mov eax, [eax+0x2e] */
            ii(0x1013_01c6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_01c9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_01cb, 2); if(jle(0x1013_01d6, 0x9)) goto l_0x1013_01d6; /* jle 0x101301d6 */
            ii(0x1013_01cd, 7); mov(memb[ss, ebp - 0x90], 0x1);         /* mov byte [ebp-0x90], 0x1 */
            ii(0x1013_01d4, 2); jmp(0x1013_01dd, 0x7); goto l_0x1013_01dd; /* jmp 0x101301dd */
        l_0x1013_01d6:
            ii(0x1013_01d6, 7); mov(memb[ss, ebp - 0x90], 0);           /* mov byte [ebp-0x90], 0x0 */
        l_0x1013_01dd:
            ii(0x1013_01dd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_01df, 6); mov(dl, memb[ss, ebp - 0x90]);          /* mov dl, [ebp-0x90] */
            ii(0x1013_01e5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_01e8, 6); mov(eax, memd[ds, eax + 0xce]);         /* mov eax, [eax+0xce] */
            ii(0x1013_01ee, 6); mov(ebx, memd[ss, ebp - 0x8c]);         /* mov ebx, [ebp-0x8c] */
            ii(0x1013_01f4, 5); call(0x100c_fa7c, -0x6_077d);           /* call 0x100cfa7c */
            ii(0x1013_01f9, 5); call(0x100d_51e4, -0x5_b01a);           /* call 0x100d51e4 */
            ii(0x1013_01fe, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_0203, 6); mov(memd[ss, ebp - 0x94], eax);         /* mov [ebp-0x94], eax */
            ii(0x1013_0209, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_020c, 3); mov(edx, memd[ds, eax + 0x2e]);         /* mov edx, [eax+0x2e] */
            ii(0x1013_020f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_0212, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_0215, 3); mov(eax, memd[ds, eax + 0x38]);         /* mov eax, [eax+0x38] */
            ii(0x1013_0218, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_021b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_021d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_0220, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1013_0223, 5); call(Definitions.my_1_get_count, -0x8_4d50); /* call 0x100ab4d8 */
            ii(0x1013_0228, 1); cwde();                                 /* cwde */
            ii(0x1013_0229, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1013_022b, 2); if(jge(0x1013_0236, 0x9)) goto l_0x1013_0236; /* jge 0x10130236 */
            ii(0x1013_022d, 7); mov(memb[ss, ebp - 0x98], 0x1);         /* mov byte [ebp-0x98], 0x1 */
            ii(0x1013_0234, 2); jmp(0x1013_023d, 0x7); goto l_0x1013_023d; /* jmp 0x1013023d */
        l_0x1013_0236:
            ii(0x1013_0236, 7); mov(memb[ss, ebp - 0x98], 0);           /* mov byte [ebp-0x98], 0x0 */
        l_0x1013_023d:
            ii(0x1013_023d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_023f, 6); mov(dl, memb[ss, ebp - 0x98]);          /* mov dl, [ebp-0x98] */
            ii(0x1013_0245, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_0248, 6); mov(eax, memd[ds, eax + 0xd2]);         /* mov eax, [eax+0xd2] */
            ii(0x1013_024e, 6); mov(ebx, memd[ss, ebp - 0x94]);         /* mov ebx, [ebp-0x94] */
            ii(0x1013_0254, 5); call(0x100c_fa7c, -0x6_07dd);           /* call 0x100cfa7c */
            ii(0x1013_0259, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_025b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_025c, 1); pop(edi);                               /* pop edi */
            ii(0x1013_025d, 1); pop(esi);                               /* pop esi */
            ii(0x1013_025e, 1); pop(edx);                               /* pop edx */
            ii(0x1013_025f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_0260, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_0261, 1); ret();                                  /* ret */
        }
    }
}
