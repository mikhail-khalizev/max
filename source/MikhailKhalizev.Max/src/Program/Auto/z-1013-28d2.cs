using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_28d2-4b10a6f0")]
        public void Method_1013_28d2()
        {
            ii(0x1013_28d2, 5); push(0xdc);                             /* push 0xdc */
            ii(0x1013_28d7, 5); call(Definitions.sys_check_available_stack_size, 0x3_3476); /* call 0x10165d52 */
            ii(0x1013_28dc, 1); push(ebx);                              /* push ebx */
            ii(0x1013_28dd, 1); push(ecx);                              /* push ecx */
            ii(0x1013_28de, 1); push(esi);                              /* push esi */
            ii(0x1013_28df, 1); push(edi);                              /* push edi */
            ii(0x1013_28e0, 1); push(ebp);                              /* push ebp */
            ii(0x1013_28e1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_28e3, 6); sub(esp, 0xac);                         /* sub esp, 0xac */
            ii(0x1013_28e9, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_28ec, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_28ef, 5); mov(ebx, 0x26);                         /* mov ebx, 0x26 */
            ii(0x1013_28f4, 5); mov(edx, 0x6d5);                        /* mov edx, 0x6d5 */
            ii(0x1013_28f9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_28fc, 5); call(0x100d_68a3, -0x5_c05e);           /* call 0x100d68a3 */
            ii(0x1013_2901, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_2904, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1013_2907, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_290a, 5); mov(ebx, 0x101b_6c5c);                  /* mov ebx, 0x101b6c5c */
            ii(0x1013_290f, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x1013_2914, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2917, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1013_291a, 5); call(Definitions.sys_call_ctor_arr_v2, 0x3_3651); /* call 0x10165f70 */
            ii(0x1013_291f, 3); sub(eax, 0x2a);                         /* sub eax, 0x2a */
            ii(0x1013_2922, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_2925, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1013_2928, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_292b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_292e, 7); mov(memd[ds, eax + 0x13], 0x101b_6c70); /* mov dword [eax+0x13], 0x101b6c70 */
            ii(0x1013_2935, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_2938, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_293b, 4); mov(memw[ds, edx + 0x17], ax);          /* mov [edx+0x17], ax */
            ii(0x1013_293f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1013_2944, 5); call(0x1012_0d94, -0x1_1bb5);           /* call 0x10120d94 */
            ii(0x1013_2949, 5); call(0x100f_fc13, -0x3_2d3b);           /* call 0x100ffc13 */
            ii(0x1013_294e, 5); call(0x100d_6124, -0x5_c82f);           /* call 0x100d6124 */
            ii(0x1013_2953, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_2955, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1013_2957, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_295a, 5); call(0x100d_6adf, -0x5_be80);           /* call 0x100d6adf */
            ii(0x1013_295f, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x1013_2962, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2965, 5); call(0x100d_6a11, -0x5_bf59);           /* call 0x100d6a11 */
            ii(0x1013_296a, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1013_296f, 5); call(/* sys */ 0x1016_a24c, 0x3_78d8);  /* call 0x1016a24c */
            ii(0x1013_2974, 5); call(0x100d_531c, -0x5_d65d);           /* call 0x100d531c */
            ii(0x1013_2979, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_297e, 1); push(eax);                              /* push eax */
            ii(0x1013_297f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1013_2984, 1); push(eax);                              /* push eax */
            ii(0x1013_2985, 2); push(0x2);                              /* push 0x2 */
            ii(0x1013_2987, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1013_298c, 1); push(eax);                              /* push eax */
            ii(0x1013_298d, 5); mov(eax, 0xaa);                         /* mov eax, 0xaa */
            ii(0x1013_2992, 1); push(eax);                              /* push eax */
            ii(0x1013_2993, 5); mov(eax, 0x13);                         /* mov eax, 0x13 */
            ii(0x1013_2998, 1); push(eax);                              /* push eax */
            ii(0x1013_2999, 5); mov(ecx, 0x5f);                         /* mov ecx, 0x5f */
            ii(0x1013_299e, 5); mov(ebx, StringDefinitions.ResearchTopics); /* mov ebx, 0x101a8912 */
            ii(0x1013_29a3, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1013_29a7, 3); mov(eax, memd[ss, ebp - 0x1e]);         /* mov eax, [ebp-0x1e] */
            ii(0x1013_29aa, 5); call(0x100e_9ae5, -0x4_8eca);           /* call 0x100e9ae5 */
            ii(0x1013_29af, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1013_29b4, 5); call(/* sys */ 0x1016_a24c, 0x3_7893);  /* call 0x1016a24c */
            ii(0x1013_29b9, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1013_29bc, 5); call(0x1013_1cb4, -0xd0d);              /* call 0x10131cb4 */
            ii(0x1013_29c1, 1); push(eax);                              /* push eax */
            ii(0x1013_29c2, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1013_29c7, 1); push(eax);                              /* push eax */
            ii(0x1013_29c8, 5); mov(eax, 0x7d);                         /* mov eax, 0x7d */
            ii(0x1013_29cd, 1); push(eax);                              /* push eax */
            ii(0x1013_29ce, 5); mov(ecx, 0x34);                         /* mov ecx, 0x34 */
            ii(0x1013_29d3, 5); mov(ebx, 0x17);                         /* mov ebx, 0x17 */
            ii(0x1013_29d8, 5); mov(edx, StringDefinitions.Labs);       /* mov edx, 0x101a8922 */
            ii(0x1013_29dd, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_29e0, 5); call(0x100e_a99a, -0x4_804b);           /* call 0x100ea99a */
            ii(0x1013_29e5, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1013_29e8, 5); call(0x1013_1cb4, -0xd39);              /* call 0x10131cb4 */
            ii(0x1013_29ed, 1); push(eax);                              /* push eax */
            ii(0x1013_29ee, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1013_29f3, 1); push(eax);                              /* push eax */
            ii(0x1013_29f4, 5); mov(eax, 0x5a);                         /* mov eax, 0x5a */
            ii(0x1013_29f9, 1); push(eax);                              /* push eax */
            ii(0x1013_29fa, 5); mov(ecx, 0x34);                         /* mov ecx, 0x34 */
            ii(0x1013_29ff, 5); mov(ebx, 0xb8);                         /* mov ebx, 0xb8 */
            ii(0x1013_2a04, 5); mov(edx, StringDefinitions.Topics);     /* mov edx, 0x101a8927 */
            ii(0x1013_2a09, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_2a0c, 5); call(0x100e_a99a, -0x4_8077);           /* call 0x100ea99a */
            ii(0x1013_2a11, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1013_2a14, 5); call(0x1013_1cb4, -0xd65);              /* call 0x10131cb4 */
            ii(0x1013_2a19, 1); push(eax);                              /* push eax */
            ii(0x1013_2a1a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1013_2a1f, 1); push(eax);                              /* push eax */
            ii(0x1013_2a20, 5); mov(eax, 0x3c);                         /* mov eax, 0x3c */
            ii(0x1013_2a25, 1); push(eax);                              /* push eax */
            ii(0x1013_2a26, 5); mov(ecx, 0x34);                         /* mov ecx, 0x34 */
            ii(0x1013_2a2b, 5); mov(ebx, 0x11a);                        /* mov ebx, 0x11a */
            ii(0x1013_2a30, 5); mov(edx, StringDefinitions.Turns4);     /* mov edx, 0x101a892e */
            ii(0x1013_2a35, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_2a38, 5); call(0x100e_a99a, -0x4_80a3);           /* call 0x100ea99a */
            ii(0x1013_2a3d, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1013_2a42, 5); call(/* sys */ 0x1016_a24c, 0x3_7805);  /* call 0x1016a24c */
            ii(0x1013_2a47, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1013_2a4c, 5); call(Definitions.sys_new, 0x3_33af);    /* call 0x10165e00 */
            ii(0x1013_2a51, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1013_2a54, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1013_2a57, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x1013_2a5a, 4); cmp(memd[ss, ebp - 0x48], 0);           /* cmp dword [ebp-0x48], 0x0 */
            ii(0x1013_2a5e, 2); if(jz(0x1013_2a88, 0x28)) goto l_0x1013_2a88; /* jz 0x10132a88 */
            ii(0x1013_2a60, 5); mov(eax, 0x126);                        /* mov eax, 0x126 */
            ii(0x1013_2a65, 1); push(eax);                              /* push eax */
            ii(0x1013_2a66, 5); mov(ecx, 0x5c);                         /* mov ecx, 0x5c */
            ii(0x1013_2a6b, 5); mov(ebx, 0x18f);                        /* mov ebx, 0x18f */
            ii(0x1013_2a70, 5); mov(edx, 0x18e);                        /* mov edx, 0x18e */
            ii(0x1013_2a75, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1013_2a78, 5); call(Definitions.my_ctor_c17, -0x6_466e); /* call 0x100ce40f */
            ii(0x1013_2a7d, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1013_2a80, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x1013_2a83, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x1013_2a86, 2); jmp(0x1013_2a8e, 0x6); goto l_0x1013_2a8e; /* jmp 0x10132a8e */
        l_0x1013_2a88:
            ii(0x1013_2a88, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1013_2a8b, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
        l_0x1013_2a8e:
            ii(0x1013_2a8e, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x1013_2a91, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_2a94, 3); mov(memd[ds, edx + 0x1e], eax);         /* mov [edx+0x1e], eax */
            ii(0x1013_2a97, 3); mov(edx, memd[ss, ebp - 0x22]);         /* mov edx, [ebp-0x22] */
            ii(0x1013_2a9a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2a9d, 3); mov(eax, memd[ds, eax + 0x1e]);         /* mov eax, [eax+0x1e] */
            ii(0x1013_2aa0, 5); call(0x100c_e92d, -0x6_4178);           /* call 0x100ce92d */
            ii(0x1013_2aa5, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1013_2aa8, 5); call(0x100d_5224, -0x5_d889);           /* call 0x100d5224 */
            ii(0x1013_2aad, 1); push(eax);                              /* push eax */
            ii(0x1013_2aae, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1013_2ab1, 5); call(0x100d_5250, -0x5_d866);           /* call 0x100d5250 */
            ii(0x1013_2ab6, 1); push(eax);                              /* push eax */
            ii(0x1013_2ab7, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1013_2aba, 5); call(0x100d_527c, -0x5_d843);           /* call 0x100d527c */
            ii(0x1013_2abf, 1); push(eax);                              /* push eax */
            ii(0x1013_2ac0, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x1013_2ac3, 5); call(0x100d_52a8, -0x5_d820);           /* call 0x100d52a8 */
            ii(0x1013_2ac8, 1); push(eax);                              /* push eax */
            ii(0x1013_2ac9, 5); call(0x100d_52d4, -0x5_d7fa);           /* call 0x100d52d4 */
            ii(0x1013_2ace, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1013_2ad1, 5); call(0x100d_52f8, -0x5_d7de);           /* call 0x100d52f8 */
            ii(0x1013_2ad6, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1013_2ad9, 5); mov(edx, StringDefinitions.Cancel9);    /* mov edx, 0x101a8934 */
            ii(0x1013_2ade, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2ae1, 3); mov(eax, memd[ds, eax + 0x1e]);         /* mov eax, [eax+0x1e] */
            ii(0x1013_2ae4, 5); call(0x100c_ef64, -0x6_3b85);           /* call 0x100cef64 */
            ii(0x1013_2ae9, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1013_2aec, 5); mov(edx, 0x1013_319e);                  /* mov edx, 0x1013319e */
            ii(0x1013_2af1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2af4, 3); mov(eax, memd[ds, eax + 0x1e]);         /* mov eax, [eax+0x1e] */
            ii(0x1013_2af7, 5); call(0x100c_f824, -0x6_32d8);           /* call 0x100cf824 */
            ii(0x1013_2afc, 3); mov(edx, memd[ss, ebp - 0x22]);         /* mov edx, [ebp-0x22] */
            ii(0x1013_2aff, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2b02, 3); mov(eax, memd[ds, eax + 0x1e]);         /* mov eax, [eax+0x1e] */
            ii(0x1013_2b05, 5); call(0x100c_f85c, -0x6_32ae);           /* call 0x100cf85c */
            ii(0x1013_2b0a, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1013_2b0f, 5); call(Definitions.sys_new, 0x3_32ec);    /* call 0x10165e00 */
            ii(0x1013_2b14, 3); mov(memd[ss, ebp - 0x64], eax);         /* mov [ebp-0x64], eax */
            ii(0x1013_2b17, 3); mov(eax, memd[ss, ebp - 0x64]);         /* mov eax, [ebp-0x64] */
            ii(0x1013_2b1a, 3); mov(memd[ss, ebp - 0x68], eax);         /* mov [ebp-0x68], eax */
            ii(0x1013_2b1d, 4); cmp(memd[ss, ebp - 0x68], 0);           /* cmp dword [ebp-0x68], 0x0 */
            ii(0x1013_2b21, 2); if(jz(0x1013_2b4b, 0x28)) goto l_0x1013_2b4b; /* jz 0x10132b4b */
            ii(0x1013_2b23, 5); mov(eax, 0x126);                        /* mov eax, 0x126 */
            ii(0x1013_2b28, 1); push(eax);                              /* push eax */
            ii(0x1013_2b29, 5); mov(ecx, 0xa7);                         /* mov ecx, 0xa7 */
            ii(0x1013_2b2e, 5); mov(ebx, 0x199);                        /* mov ebx, 0x199 */
            ii(0x1013_2b33, 5); mov(edx, 0x198);                        /* mov edx, 0x198 */
            ii(0x1013_2b38, 3); mov(eax, memd[ss, ebp - 0x64]);         /* mov eax, [ebp-0x64] */
            ii(0x1013_2b3b, 5); call(Definitions.my_ctor_c17, -0x6_4731); /* call 0x100ce40f */
            ii(0x1013_2b40, 3); mov(memd[ss, ebp - 0x6c], eax);         /* mov [ebp-0x6c], eax */
            ii(0x1013_2b43, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x1013_2b46, 3); mov(memd[ss, ebp - 0x70], eax);         /* mov [ebp-0x70], eax */
            ii(0x1013_2b49, 2); jmp(0x1013_2b51, 0x6); goto l_0x1013_2b51; /* jmp 0x10132b51 */
        l_0x1013_2b4b:
            ii(0x1013_2b4b, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x1013_2b4e, 3); mov(memd[ss, ebp - 0x70], eax);         /* mov [ebp-0x70], eax */
        l_0x1013_2b51:
            ii(0x1013_2b51, 3); mov(eax, memd[ss, ebp - 0x70]);         /* mov eax, [ebp-0x70] */
            ii(0x1013_2b54, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_2b57, 3); mov(memd[ds, edx + 0x26], eax);         /* mov [edx+0x26], eax */
            ii(0x1013_2b5a, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1013_2b5d, 5); mov(edx, 0x1013_315b);                  /* mov edx, 0x1013315b */
            ii(0x1013_2b62, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2b65, 3); mov(eax, memd[ds, eax + 0x26]);         /* mov eax, [eax+0x26] */
            ii(0x1013_2b68, 5); call(0x100c_f824, -0x6_3349);           /* call 0x100cf824 */
            ii(0x1013_2b6d, 3); mov(edx, memd[ss, ebp - 0x22]);         /* mov edx, [ebp-0x22] */
            ii(0x1013_2b70, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2b73, 3); mov(eax, memd[ds, eax + 0x26]);         /* mov eax, [eax+0x26] */
            ii(0x1013_2b76, 5); call(0x100c_f85c, -0x6_331f);           /* call 0x100cf85c */
            ii(0x1013_2b7b, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1013_2b80, 5); call(Definitions.sys_new, 0x3_327b);    /* call 0x10165e00 */
            ii(0x1013_2b85, 3); mov(memd[ss, ebp - 0x74], eax);         /* mov [ebp-0x74], eax */
            ii(0x1013_2b88, 3); mov(eax, memd[ss, ebp - 0x74]);         /* mov eax, [ebp-0x74] */
            ii(0x1013_2b8b, 3); mov(memd[ss, ebp - 0x78], eax);         /* mov [ebp-0x78], eax */
            ii(0x1013_2b8e, 4); cmp(memd[ss, ebp - 0x78], 0);           /* cmp dword [ebp-0x78], 0x0 */
            ii(0x1013_2b92, 2); if(jz(0x1013_2bbc, 0x28)) goto l_0x1013_2bbc; /* jz 0x10132bbc */
            ii(0x1013_2b94, 5); mov(eax, 0x126);                        /* mov eax, 0x126 */
            ii(0x1013_2b99, 1); push(eax);                              /* push eax */
            ii(0x1013_2b9a, 5); mov(ecx, 0xc2);                         /* mov ecx, 0xc2 */
            ii(0x1013_2b9f, 5); mov(ebx, 0x18f);                        /* mov ebx, 0x18f */
            ii(0x1013_2ba4, 5); mov(edx, 0x18e);                        /* mov edx, 0x18e */
            ii(0x1013_2ba9, 3); mov(eax, memd[ss, ebp - 0x74]);         /* mov eax, [ebp-0x74] */
            ii(0x1013_2bac, 5); call(Definitions.my_ctor_c17, -0x6_47a2); /* call 0x100ce40f */
            ii(0x1013_2bb1, 3); mov(memd[ss, ebp - 0x7c], eax);         /* mov [ebp-0x7c], eax */
            ii(0x1013_2bb4, 3); mov(eax, memd[ss, ebp - 0x7c]);         /* mov eax, [ebp-0x7c] */
            ii(0x1013_2bb7, 3); mov(memd[ss, ebp - 0x80], eax);         /* mov [ebp-0x80], eax */
            ii(0x1013_2bba, 2); jmp(0x1013_2bc2, 0x6); goto l_0x1013_2bc2; /* jmp 0x10132bc2 */
        l_0x1013_2bbc:
            ii(0x1013_2bbc, 3); mov(eax, memd[ss, ebp - 0x78]);         /* mov eax, [ebp-0x78] */
            ii(0x1013_2bbf, 3); mov(memd[ss, ebp - 0x80], eax);         /* mov [ebp-0x80], eax */
        l_0x1013_2bc2:
            ii(0x1013_2bc2, 3); mov(eax, memd[ss, ebp - 0x80]);         /* mov eax, [ebp-0x80] */
            ii(0x1013_2bc5, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_2bc8, 3); mov(memd[ds, edx + 0x22], eax);         /* mov [edx+0x22], eax */
            ii(0x1013_2bcb, 3); mov(edx, memd[ss, ebp - 0x22]);         /* mov edx, [ebp-0x22] */
            ii(0x1013_2bce, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2bd1, 3); mov(eax, memd[ds, eax + 0x22]);         /* mov eax, [eax+0x22] */
            ii(0x1013_2bd4, 5); call(0x100c_e92d, -0x6_42ac);           /* call 0x100ce92d */
            ii(0x1013_2bd9, 6); lea(eax, ebp - 0x84);                   /* lea eax, [ebp-0x84] */
            ii(0x1013_2bdf, 5); call(0x100d_5224, -0x5_d9c0);           /* call 0x100d5224 */
            ii(0x1013_2be4, 1); push(eax);                              /* push eax */
            ii(0x1013_2be5, 6); lea(eax, ebp - 0x88);                   /* lea eax, [ebp-0x88] */
            ii(0x1013_2beb, 5); call(0x100d_5250, -0x5_d9a0);           /* call 0x100d5250 */
            ii(0x1013_2bf0, 1); push(eax);                              /* push eax */
            ii(0x1013_2bf1, 6); lea(eax, ebp - 0x8c);                   /* lea eax, [ebp-0x8c] */
            ii(0x1013_2bf7, 5); call(0x100d_527c, -0x5_d980);           /* call 0x100d527c */
            ii(0x1013_2bfc, 1); push(eax);                              /* push eax */
            ii(0x1013_2bfd, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_2c03, 5); call(0x100d_52a8, -0x5_d960);           /* call 0x100d52a8 */
            ii(0x1013_2c08, 1); push(eax);                              /* push eax */
            ii(0x1013_2c09, 5); call(0x100d_52d4, -0x5_d93a);           /* call 0x100d52d4 */
            ii(0x1013_2c0e, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1013_2c11, 5); call(0x100d_52f8, -0x5_d91e);           /* call 0x100d52f8 */
            ii(0x1013_2c16, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1013_2c19, 5); mov(edx, StringDefinitions.Done9);      /* mov edx, 0x101a893b */
            ii(0x1013_2c1e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2c21, 3); mov(eax, memd[ds, eax + 0x22]);         /* mov eax, [eax+0x22] */
            ii(0x1013_2c24, 5); call(0x100c_ef64, -0x6_3cc5);           /* call 0x100cef64 */
            ii(0x1013_2c29, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1013_2c2c, 5); mov(edx, 0x1013_2f81);                  /* mov edx, 0x10132f81 */
            ii(0x1013_2c31, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2c34, 3); mov(eax, memd[ds, eax + 0x22]);         /* mov eax, [eax+0x22] */
            ii(0x1013_2c37, 5); call(0x100c_f824, -0x6_3418);           /* call 0x100cf824 */
            ii(0x1013_2c3c, 3); mov(edx, memd[ss, ebp - 0x22]);         /* mov edx, [ebp-0x22] */
            ii(0x1013_2c3f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2c42, 3); mov(eax, memd[ds, eax + 0x22]);         /* mov eax, [eax+0x22] */
            ii(0x1013_2c45, 5); call(0x100c_f85c, -0x6_33ee);           /* call 0x100cf85c */
            ii(0x1013_2c4a, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x1013_2c4e, 6); lea(eax, ebp - 0x94);                   /* lea eax, [ebp-0x94] */
            ii(0x1013_2c54, 5); call(0x1007_64fc, -0xb_c75d);           /* call 0x100764fc */
            ii(0x1013_2c59, 6); mov(memd[ss, ebp - 0x98], eax);         /* mov [ebp-0x98], eax */
            ii(0x1013_2c5f, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1013_2c63, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2c66, 6); mov(memw[ds, eax + 0x19], 0);           /* mov word [eax+0x19], 0x0 */
            ii(0x1013_2c6c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2c6f, 6); mov(memw[ds, eax + 0x1b], 0);           /* mov word [eax+0x1b], 0x0 */
            ii(0x1013_2c75, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
            ii(0x1013_2c7a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_2c7c, 6); lea(eax, ebp - 0xa8);                   /* lea eax, [ebp-0xa8] */
            ii(0x1013_2c82, 5); call(Definitions.sys_memset, 0x3_3159); /* call 0x10165de0 */
            ii(0x1013_2c87, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1013_2c8c, 5); call(0x1007_6338, -0xb_c959);           /* call 0x10076338 */
            ii(0x1013_2c91, 6); lea(ebx, ebp - 0x94);                   /* lea ebx, [ebp-0x94] */
            ii(0x1013_2c97, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_2c99, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1013_2c9b, 5); call(0x1007_643c, -0xb_c864);           /* call 0x1007643c */
            ii(0x1013_2ca0, 2); jmp(0x1013_2cad, 0xb); goto l_0x1013_2cad; /* jmp 0x10132cad */
        l_0x1013_2ca2:
            ii(0x1013_2ca2, 6); lea(eax, ebp - 0x94);                   /* lea eax, [ebp-0x94] */
            ii(0x1013_2ca8, 5); call(0x1007_6bf8, -0xb_c0b5);           /* call 0x10076bf8 */
        l_0x1013_2cad:
            ii(0x1013_2cad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_2caf, 6); lea(eax, ebp - 0x94);                   /* lea eax, [ebp-0x94] */
            ii(0x1013_2cb5, 5); call(0x1013_ad71, 0x80b7);              /* call 0x1013ad71 */
            ii(0x1013_2cba, 2); test(al, al);                           /* test al, al */
            ii(0x1013_2cbc, 2); if(jz(0x1013_2d29, 0x6b)) goto l_0x1013_2d29; /* jz 0x10132d29 */
            ii(0x1013_2cbe, 6); lea(eax, ebp - 0x94);                   /* lea eax, [ebp-0x94] */
            ii(0x1013_2cc4, 5); call(0x1007_63a0, -0xb_c929);           /* call 0x100763a0 */
            ii(0x1013_2cc9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_2ccb, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1013_2cce, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2cd1, 3); mov(eax, memd[ds, eax + 0x15]);         /* mov eax, [eax+0x15] */
            ii(0x1013_2cd4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_2cd7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1013_2cd9, 2); if(jnz(0x1013_2ced, 0x12)) goto l_0x1013_2ced; /* jnz 0x10132ced */
            ii(0x1013_2cdb, 6); lea(eax, ebp - 0x94);                   /* lea eax, [ebp-0x94] */
            ii(0x1013_2ce1, 5); call(0x1007_63a0, -0xb_c946);           /* call 0x100763a0 */
            ii(0x1013_2ce6, 5); cmp(memw[ds, eax + 0x8], 0x1d);         /* cmp word [eax+0x8], 0x1d */
            ii(0x1013_2ceb, 2); if(jz(0x1013_2cef, 0x2)) goto l_0x1013_2cef; /* jz 0x10132cef */
        l_0x1013_2ced:
            ii(0x1013_2ced, 2); jmp(0x1013_2d00, 0x11); goto l_0x1013_2d00; /* jmp 0x10132d00 */
        l_0x1013_2cef:
            ii(0x1013_2cef, 6); lea(eax, ebp - 0x94);                   /* lea eax, [ebp-0x94] */
            ii(0x1013_2cf5, 5); call(0x1007_63a0, -0xb_c95a);           /* call 0x100763a0 */
            ii(0x1013_2cfa, 4); cmp(memb[ds, eax + 0x3d], 0x7);         /* cmp byte [eax+0x3d], 0x7 */
            ii(0x1013_2cfe, 2); if(jz(0x1013_2d02, 0x2)) goto l_0x1013_2d02; /* jz 0x10132d02 */
        l_0x1013_2d00:
            ii(0x1013_2d00, 2); jmp(0x1013_2d24, 0x22); goto l_0x1013_2d24; /* jmp 0x10132d24 */
        l_0x1013_2d02:
            ii(0x1013_2d02, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2d05, 4); inc(memw[ds, eax + 0x1b]);              /* inc word [eax+0x1b] */
            ii(0x1013_2d09, 6); lea(eax, ebp - 0x94);                   /* lea eax, [ebp-0x94] */
            ii(0x1013_2d0f, 5); call(0x1007_63a0, -0xb_c974);           /* call 0x100763a0 */
            ii(0x1013_2d14, 3); mov(eax, memd[ds, eax + 0x5a]);         /* mov eax, [eax+0x5a] */
            ii(0x1013_2d17, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1013_2d1a, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_2d1c, 8); inc(memw[ds, eax + ebp - 0xa8]);        /* inc word [eax+ebp-0xa8] */
        l_0x1013_2d24:
            ii(0x1013_2d24, 5); jmp(0x1013_2ca2, -0x87); goto l_0x1013_2ca2; /* jmp 0x10132ca2 */
        l_0x1013_2d29:
            ii(0x1013_2d29, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_2d30, 2); jmp(0x1013_2d38, 0x6); goto l_0x1013_2d38; /* jmp 0x10132d38 */
        l_0x1013_2d32:
            ii(0x1013_2d32, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_2d35, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x1013_2d38:
            ii(0x1013_2d38, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_2d3c, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1013_2d3f, 2); if(jge(0x1013_2d6e, 0x2d)) goto l_0x1013_2d6e; /* jge 0x10132d6e */
            ii(0x1013_2d41, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_2d45, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_2d47, 7); mov(ecx, memd[ds, eax + ebp - 0xaa]);   /* mov ecx, [eax+ebp-0xaa] */
            ii(0x1013_2d4e, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1013_2d51, 4); movsx(ebx, memb[ss, ebp - 0x10]);       /* movsx ebx, byte [ebp-0x10] */
            ii(0x1013_2d55, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_2d58, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_2d5c, 3); imul(eax, eax, 0x1f);                   /* imul eax, eax, 0x1f */
            ii(0x1013_2d5f, 3); mov(esi, memd[ss, ebp - 0x8]);          /* mov esi, [ebp-0x8] */
            ii(0x1013_2d62, 3); add(esi, 0x2a);                         /* add esi, 0x2a */
            ii(0x1013_2d65, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1013_2d67, 5); call(0x1013_1eac, -0xec0);              /* call 0x10131eac */
            ii(0x1013_2d6c, 2); jmp(0x1013_2d32, -0x3c); goto l_0x1013_2d32; /* jmp 0x10132d32 */
        l_0x1013_2d6e:
            ii(0x1013_2d6e, 3); mov(eax, memd[ss, ebp - 0x22]);         /* mov eax, [ebp-0x22] */
            ii(0x1013_2d71, 5); call(Definitions.sys_display_draw_0, 0x3_470e); /* call 0x10167484 */
            ii(0x1013_2d76, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_2d78, 6); lea(eax, ebp - 0x94);                   /* lea eax, [ebp-0x94] */
            ii(0x1013_2d7e, 5); call(0x1007_5f6c, -0xb_ce17);           /* call 0x10075f6c */
            ii(0x1013_2d83, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_2d86, 6); mov(memd[ss, ebp - 0xac], eax);         /* mov [ebp-0xac], eax */
            ii(0x1013_2d8c, 6); mov(eax, memd[ss, ebp - 0xac]);         /* mov eax, [ebp-0xac] */
            ii(0x1013_2d92, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_2d94, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_2d95, 1); pop(edi);                               /* pop edi */
            ii(0x1013_2d96, 1); pop(esi);                               /* pop esi */
            ii(0x1013_2d97, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_2d98, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_2d99, 1); ret();                                  /* ret */
        }
    }
}
