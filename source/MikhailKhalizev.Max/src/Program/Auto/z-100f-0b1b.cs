using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1bd20717-f274-423c-b75f-bbdc8e229c26")]
        public void Method_100f_0b1b()
        {
            ii(0x100f_0b1b, 5); pushd(0xb4);                            /* push 0xb4 */
            ii(0x100f_0b20, 5); calld(Definitions.sys_check_available_stack_size, 0x7_522d); /* call 0x10165d52 */
            ii(0x100f_0b25, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_0b26, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_0b27, 1); pushd(edx);                             /* push edx */
            ii(0x100f_0b28, 1); pushd(esi);                             /* push esi */
            ii(0x100f_0b29, 1); pushd(edi);                             /* push edi */
            ii(0x100f_0b2a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_0b2b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_0b2d, 6); sub(esp, 0x84);                         /* sub esp, 0x84 */
            ii(0x100f_0b33, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100f_0b36, 5); mov(ecx, 0xe6);                         /* mov ecx, 0xe6 */
            ii(0x100f_0b3b, 5); mov(ebx, 0xa7);                         /* mov ebx, 0xa7 */
            ii(0x100f_0b40, 5); mov(edx, 0xa2);                         /* mov edx, 0xa2 */
            ii(0x100f_0b45, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100f_0b48, 5); calld(0x100d_53a4, -0x1_b7a9);          /* call 0x100d53a4 */
            ii(0x100f_0b4d, 5); mov(ecx, 0x24);                         /* mov ecx, 0x24 */
            ii(0x100f_0b52, 5); mov(ebx, 0xa3);                         /* mov ebx, 0xa3 */
            ii(0x100f_0b57, 5); mov(edx, 0xa2);                         /* mov edx, 0xa2 */
            ii(0x100f_0b5c, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_0b5f, 5); calld(0x100d_53a4, -0x1_b7c0);          /* call 0x100d53a4 */
            ii(0x100f_0b64, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x100f_0b69, 5); calld(0x100e_883d, -0x8331);            /* call 0x100e883d */
            ii(0x100f_0b6e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_0b71, 9); mov(memw_a32[ds, 0x101b_87d9], 0x2a9);  /* mov word [0x101b87d9], 0x2a9 */
            ii(0x100f_0b7a, 10); mov(memd_a32[ds, 0x101b_87db], 0x101b_88fc); /* mov dword [0x101b87db], 0x101b88fc */
            ii(0x100f_0b84, 8); cmp(memw_a32[ds, 0x101c_3982], 0);      /* cmp word [0x101c3982], 0x0 */
            ii(0x100f_0b8c, 2); if(jzd(0x100f_0b97, 0x9)) goto l_0x100f_0b97; /* jz 0x100f0b97 */
            ii(0x100f_0b8e, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_0b95, 2); if(jzd(0x100f_0b99, 0x2)) goto l_0x100f_0b99; /* jz 0x100f0b99 */
        l_0x100f_0b97:
            ii(0x100f_0b97, 2); jmpd(0x100f_0bac, 0x13); goto l_0x100f_0bac; /* jmp 0x100f0bac */
        l_0x100f_0b99:
            ii(0x100f_0b99, 9); mov(memw_a32[ds, 0x101b_87d9], 0x2ab);  /* mov word [0x101b87d9], 0x2ab */
            ii(0x100f_0ba2, 10); mov(memd_a32[ds, 0x101b_87db], 0x101b_8904); /* mov dword [0x101b87db], 0x101b8904 */
        l_0x100f_0bac:
            ii(0x100f_0bac, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100f_0bb3, 2); jmpd(0x100f_0bbb, 0x6); goto l_0x100f_0bbb; /* jmp 0x100f0bbb */
        l_0x100f_0bb5:
            ii(0x100f_0bb5, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_0bb8, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x100f_0bbb:
            ii(0x100f_0bbb, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0bbf, 3); cmp(eax, 0x18);                         /* cmp eax, 0x18 */
            ii(0x100f_0bc2, 6); if(jaed(0x100f_0edd, 0x315)) goto l_0x100f_0edd; /* jae 0x100f0edd */
            ii(0x100f_0bc8, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0bcc, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0bcf, 7); cmp(memd_a32[ds, eax + 0x101b_8753], 0); /* cmp dword [eax+0x101b8753], 0x0 */
            ii(0x100f_0bd6, 2); if(jzd(0x100f_0c09, 0x31)) goto l_0x100f_0c09; /* jz 0x100f0c09 */
            ii(0x100f_0bd8, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0bdc, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0bdf, 6); mov(eax, memd_a32[ds, eax + 0x101b_8753]); /* mov eax, [eax+0x101b8753] */
            ii(0x100f_0be5, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100f_0be8, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100f_0bec, 2); if(jzd(0x100f_0c02, 0x14)) goto l_0x100f_0c02; /* jz 0x100f0c02 */
            ii(0x100f_0bee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_0bf0, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_0bf3, 5); calld(Definitions.my_dtor_d2, -0x2_26c0); /* call 0x100ce538 */
            ii(0x100f_0bf8, 5); calld(Definitions.sys_delete, 0x7_5367); /* call 0x10165f64 */
            ii(0x100f_0bfd, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100f_0c00, 2); jmpd(0x100f_0c09, 0x7); goto l_0x100f_0c09; /* jmp 0x100f0c09 */
        l_0x100f_0c02:
            ii(0x100f_0c02, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
        l_0x100f_0c09:
            ii(0x100f_0c09, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0c0d, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0c10, 10); mov(memd_a32[ds, eax + 0x101b_8753], 0); /* mov dword [eax+0x101b8753], 0x0 */
            ii(0x100f_0c1a, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0c1e, 3); cmp(eax, 0x17);                         /* cmp eax, 0x17 */
            ii(0x100f_0c21, 2); if(jnzd(0x100f_0c2c, 0x9)) goto l_0x100f_0c2c; /* jnz 0x100f0c2c */
            ii(0x100f_0c23, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_0c25, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100f_0c28, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_0c2a, 2); if(jzd(0x100f_0c2e, 0x2)) goto l_0x100f_0c2e; /* jz 0x100f0c2e */
        l_0x100f_0c2c:
            ii(0x100f_0c2c, 2); jmpd(0x100f_0c33, 0x5); goto l_0x100f_0c33; /* jmp 0x100f0c33 */
        l_0x100f_0c2e:
            ii(0x100f_0c2e, 5); jmpd(0x100f_0ed8, 0x2a5); goto l_0x100f_0ed8; /* jmp 0x100f0ed8 */
        l_0x100f_0c33:
            ii(0x100f_0c33, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0c37, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0c3a, 6); mov(eax, memd_a32[ds, eax + 0x101b_8749]); /* mov eax, [eax+0x101b8749] */
            ii(0x100f_0c40, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100f_0c43, 5); calld(0x100e_883d, -0x840b);            /* call 0x100e883d */
            ii(0x100f_0c48, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_0c4b, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100f_0c50, 5); calld(Definitions.sys_new, 0x7_51ab);   /* call 0x10165e00 */
            ii(0x100f_0c55, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100f_0c58, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100f_0c5b, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100f_0c5e, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100f_0c62, 2); if(jzd(0x100f_0ca9, 0x45)) goto l_0x100f_0ca9; /* jz 0x100f0ca9 */
            ii(0x100f_0c64, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_0c67, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x100f_0c6a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_0c6d, 1); pushd(eax);                             /* push eax */
            ii(0x100f_0c6e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_0c71, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x100f_0c74, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0c78, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0c7b, 7); mov(ax, memw_a32[ds, eax + 0x101b_874d]); /* mov ax, [eax+0x101b874d] */
            ii(0x100f_0c82, 1); inc(eax);                               /* inc eax */
            ii(0x100f_0c83, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100f_0c86, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0c8a, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0c8d, 6); mov(edx, memd_a32[ds, eax + 0x101b_874b]); /* mov edx, [eax+0x101b874b] */
            ii(0x100f_0c93, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_0c96, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100f_0c99, 5); calld(Definitions.my_ctor_c17, -0x2_288f); /* call 0x100ce40f */
            ii(0x100f_0c9e, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100f_0ca1, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100f_0ca4, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100f_0ca7, 2); jmpd(0x100f_0caf, 0x6); goto l_0x100f_0caf; /* jmp 0x100f0caf */
        l_0x100f_0ca9:
            ii(0x100f_0ca9, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100f_0cac, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x100f_0caf:
            ii(0x100f_0caf, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100f_0cb3, 3); imul(edx, edx, 0xe);                    /* imul edx, edx, 0xe */
            ii(0x100f_0cb6, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100f_0cb9, 6); mov(memd_a32[ds, edx + 0x101b_8753], eax); /* mov [edx+0x101b8753], eax */
            ii(0x100f_0cbf, 7); mov(memd_a32[ss, ebp - 0x30], 0x20);    /* mov dword [ebp-0x30], 0x20 */
            ii(0x100f_0cc6, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0cca, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0ccd, 6); mov(eax, memd_a32[ds, eax + 0x101b_8749]); /* mov eax, [eax+0x101b8749] */
            ii(0x100f_0cd3, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100f_0cd6, 5); add(eax, 0x3e8);                        /* add eax, 0x3e8 */
            ii(0x100f_0cdb, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100f_0cde, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100f_0ce1, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100f_0ce4, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_0ce9, 5); calld(/* sys */ 0x1016_a24c, 0x7_955e); /* call 0x1016a24c */
            ii(0x100f_0cee, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0cf2, 3); cmp(eax, 0x17);                         /* cmp eax, 0x17 */
            ii(0x100f_0cf5, 2); if(jnzd(0x100f_0d05, 0xe)) goto l_0x100f_0d05; /* jnz 0x100f0d05 */
            ii(0x100f_0cf7, 4); or(memd_a32[ss, ebp - 0x30], 0x4);      /* or dword [ebp-0x30], 0x4 */
            ii(0x100f_0cfb, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100f_0d00, 5); calld(/* sys */ 0x1016_a24c, 0x7_9547); /* call 0x1016a24c */
        l_0x100f_0d05:
            ii(0x100f_0d05, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0d09, 3); cmp(eax, 0xb);                          /* cmp eax, 0xb */
            ii(0x100f_0d0c, 2); if(jld(0x100f_0d14, 0x6)) goto l_0x100f_0d14; /* jl 0x100f0d14 */
            ii(0x100f_0d0e, 4); or(memd_a32[ss, ebp - 0x30], 0x1);      /* or dword [ebp-0x30], 0x1 */
            ii(0x100f_0d12, 2); jmpd(0x100f_0d2c, 0x18); goto l_0x100f_0d2c; /* jmp 0x100f0d2c */
        l_0x100f_0d14:
            ii(0x100f_0d14, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0d18, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0d1b, 6); mov(eax, memd_a32[ds, eax + 0x101b_8749]); /* mov eax, [eax+0x101b8749] */
            ii(0x100f_0d21, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100f_0d24, 5); add(eax, 0x7000);                       /* add eax, 0x7000 */
            ii(0x100f_0d29, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
        l_0x100f_0d2c:
            ii(0x100f_0d2c, 3); mov(edx, memd_a32[ss, ebp - 0x30]);     /* mov edx, [ebp-0x30] */
            ii(0x100f_0d2f, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0d33, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0d36, 6); mov(eax, memd_a32[ds, eax + 0x101b_8753]); /* mov eax, [eax+0x101b8753] */
            ii(0x100f_0d3c, 5); calld(0x100d_5194, -0x1_bbad);          /* call 0x100d5194 */
            ii(0x100f_0d41, 3); mov(edx, memd_a32[ss, ebp - 0x34]);     /* mov edx, [ebp-0x34] */
            ii(0x100f_0d44, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0d48, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0d4b, 6); mov(eax, memd_a32[ds, eax + 0x101b_8753]); /* mov eax, [eax+0x101b8753] */
            ii(0x100f_0d51, 5); calld(0x100d_5134, -0x1_bc22);          /* call 0x100d5134 */
            ii(0x100f_0d56, 3); mov(edx, memd_a32[ss, ebp - 0x38]);     /* mov edx, [ebp-0x38] */
            ii(0x100f_0d59, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0d5d, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0d60, 6); mov(eax, memd_a32[ds, eax + 0x101b_8753]); /* mov eax, [eax+0x101b8753] */
            ii(0x100f_0d66, 5); calld(0x100d_5164, -0x1_bc07);          /* call 0x100d5164 */
            ii(0x100f_0d6b, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0d6f, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0d72, 7); cmp(memd_a32[ds, eax + 0x101b_874f], 0); /* cmp dword [eax+0x101b874f], 0x0 */
            ii(0x100f_0d79, 6); if(jzd(0x100f_0e78, 0xf9)) goto l_0x100f_0e78; /* jz 0x100f0e78 */
            ii(0x100f_0d7f, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0d83, 3); cmp(eax, 0x17);                         /* cmp eax, 0x17 */
            ii(0x100f_0d86, 6); if(jnzd(0x100f_0e0f, 0x83)) goto l_0x100f_0e0f; /* jnz 0x100f0e0f */
            ii(0x100f_0d8c, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100f_0d8f, 5); calld(0x100d_5224, -0x1_bb70);          /* call 0x100d5224 */
            ii(0x100f_0d94, 1); pushd(eax);                             /* push eax */
            ii(0x100f_0d95, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100f_0d98, 5); calld(0x100d_5250, -0x1_bb4d);          /* call 0x100d5250 */
            ii(0x100f_0d9d, 1); pushd(eax);                             /* push eax */
            ii(0x100f_0d9e, 5); mov(ecx, 0xe6);                         /* mov ecx, 0xe6 */
            ii(0x100f_0da3, 5); mov(ebx, 0xa2);                         /* mov ebx, 0xa2 */
            ii(0x100f_0da8, 5); mov(edx, 0xa0);                         /* mov edx, 0xa0 */
            ii(0x100f_0dad, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x100f_0db0, 5); calld(0x100d_53a4, -0x1_ba11);          /* call 0x100d53a4 */
            ii(0x100f_0db5, 1); pushd(eax);                             /* push eax */
            ii(0x100f_0db6, 5); mov(ecx, 0xe6);                         /* mov ecx, 0xe6 */
            ii(0x100f_0dbb, 5); mov(ebx, 0xa2);                         /* mov ebx, 0xa2 */
            ii(0x100f_0dc0, 5); mov(edx, 0xa0);                         /* mov edx, 0xa0 */
            ii(0x100f_0dc5, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100f_0dc8, 5); calld(0x100d_53a4, -0x1_ba29);          /* call 0x100d53a4 */
            ii(0x100f_0dcd, 1); pushd(eax);                             /* push eax */
            ii(0x100f_0dce, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0dd2, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_0dd5, 6); mov(ecx, memd_a32[ds, eax + 0x101b_889c]); /* mov ecx, [eax+0x101b889c] */
            ii(0x100f_0ddb, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_0dde, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0de2, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_0de5, 6); mov(ebx, memd_a32[ds, eax + 0x101b_889a]); /* mov ebx, [eax+0x101b889a] */
            ii(0x100f_0deb, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_0dee, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0df2, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0df5, 6); mov(edx, memd_a32[ds, eax + 0x101b_874f]); /* mov edx, [eax+0x101b874f] */
            ii(0x100f_0dfb, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0dff, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0e02, 6); mov(eax, memd_a32[ds, eax + 0x101b_8753]); /* mov eax, [eax+0x101b8753] */
            ii(0x100f_0e08, 5); calld(0x100c_ef64, -0x2_1ea9);          /* call 0x100cef64 */
            ii(0x100f_0e0d, 2); jmpd(0x100f_0e78, 0x69); goto l_0x100f_0e78; /* jmp 0x100f0e78 */
        l_0x100f_0e0f:
            ii(0x100f_0e0f, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x100f_0e12, 5); calld(0x100d_5224, -0x1_bbf3);          /* call 0x100d5224 */
            ii(0x100f_0e17, 1); pushd(eax);                             /* push eax */
            ii(0x100f_0e18, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100f_0e1b, 5); calld(0x100d_5250, -0x1_bbd0);          /* call 0x100d5250 */
            ii(0x100f_0e20, 1); pushd(eax);                             /* push eax */
            ii(0x100f_0e21, 3); lea(edx, ebp - 0xc);                    /* lea edx, [ebp-0xc] */
            ii(0x100f_0e24, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100f_0e27, 5); calld(0x100d_4d78, -0x1_c0b4);          /* call 0x100d4d78 */
            ii(0x100f_0e2c, 1); pushd(eax);                             /* push eax */
            ii(0x100f_0e2d, 3); lea(edx, ebp - 0x8);                    /* lea edx, [ebp-0x8] */
            ii(0x100f_0e30, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100f_0e33, 5); calld(0x100d_4d78, -0x1_c0c0);          /* call 0x100d4d78 */
            ii(0x100f_0e38, 1); pushd(eax);                             /* push eax */
            ii(0x100f_0e39, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0e3d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_0e40, 6); mov(ecx, memd_a32[ds, eax + 0x101b_889c]); /* mov ecx, [eax+0x101b889c] */
            ii(0x100f_0e46, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_0e49, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x100f_0e4d, 3); shl(ebx, 0x2);                          /* shl ebx, 0x2 */
            ii(0x100f_0e50, 6); mov(ebx, memd_a32[ds, ebx + 0x101b_889a]); /* mov ebx, [ebx+0x101b889a] */
            ii(0x100f_0e56, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_0e59, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0e5d, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0e60, 6); mov(edx, memd_a32[ds, eax + 0x101b_874f]); /* mov edx, [eax+0x101b874f] */
            ii(0x100f_0e66, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0e6a, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0e6d, 6); mov(eax, memd_a32[ds, eax + 0x101b_8753]); /* mov eax, [eax+0x101b8753] */
            ii(0x100f_0e73, 5); calld(0x100c_ef64, -0x2_1f14);          /* call 0x100cef64 */
        l_0x100f_0e78:
            ii(0x100f_0e78, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_0e7b, 3); mov(edx, memd_a32[ds, eax + 0x12]);     /* mov edx, [eax+0x12] */
            ii(0x100f_0e7e, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0e82, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0e85, 6); mov(eax, memd_a32[ds, eax + 0x101b_8753]); /* mov eax, [eax+0x101b8753] */
            ii(0x100f_0e8b, 5); calld(0x100c_f85c, -0x2_1634);          /* call 0x100cf85c */
            ii(0x100f_0e90, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0e94, 3); cmp(eax, 0x17);                         /* cmp eax, 0x17 */
            ii(0x100f_0e97, 2); if(jnzd(0x100f_0eb4, 0x1b)) goto l_0x100f_0eb4; /* jnz 0x100f0eb4 */
            ii(0x100f_0e99, 5); calld(0x100d_51c4, -0x1_bcda);          /* call 0x100d51c4 */
            ii(0x100f_0e9e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_0ea0, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100f_0ea2, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0ea6, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0ea9, 6); mov(eax, memd_a32[ds, eax + 0x101b_8753]); /* mov eax, [eax+0x101b8753] */
            ii(0x100f_0eaf, 5); calld(0x100c_fb06, -0x2_13ae);          /* call 0x100cfb06 */
        l_0x100f_0eb4:
            ii(0x100f_0eb4, 5); calld(0x100d_51e4, -0x1_bcd5);          /* call 0x100d51e4 */
            ii(0x100f_0eb9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_0ebb, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100f_0ebd, 5); calld(0x100d_5204, -0x1_bcbe);          /* call 0x100d5204 */
            ii(0x100f_0ec2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_0ec4, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100f_0ec6, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0eca, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0ecd, 6); mov(eax, memd_a32[ds, eax + 0x101b_8753]); /* mov eax, [eax+0x101b8753] */
            ii(0x100f_0ed3, 5); calld(0x100c_fa7c, -0x2_145c);          /* call 0x100cfa7c */
        l_0x100f_0ed8:
            ii(0x100f_0ed8, 5); jmpd(0x100f_0bb5, -0x328); goto l_0x100f_0bb5; /* jmp 0x100f0bb5 */
        l_0x100f_0edd:
            ii(0x100f_0edd, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100f_0ee2, 5); calld(/* sys */ 0x1016_a24c, 0x7_9365); /* call 0x1016a24c */
            ii(0x100f_0ee7, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100f_0eee, 2); jmpd(0x100f_0ef6, 0x6); goto l_0x100f_0ef6; /* jmp 0x100f0ef6 */
        l_0x100f_0ef0:
            ii(0x100f_0ef0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_0ef3, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x100f_0ef6:
            ii(0x100f_0ef6, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0efa, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100f_0efd, 6); if(jgd(0x100f_0fbc, 0xb9)) goto l_0x100f_0fbc; /* jg 0x100f0fbc */
            ii(0x100f_0f03, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_0f06, 5); add(eax, 0x110);                        /* add eax, 0x110 */
            ii(0x100f_0f0b, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x100f_0f0e, 4); movsx(eax, memw_a32[ss, ebp - 0x5c]);   /* movsx eax, word [ebp-0x5c] */
            ii(0x100f_0f12, 5); calld(Definitions.my_get_res_data_by_id, 0x4_30c1); /* call 0x10133fd8 */
            ii(0x100f_0f17, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x100f_0f1a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_0f1d, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x100f_0f20, 3); mov(memd_a32[ss, ebp - 0x6a], eax);     /* mov [ebp-0x6a], eax */
            ii(0x100f_0f23, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x100f_0f26, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x100f_0f29, 3); mov(memd_a32[ss, ebp - 0x66], eax);     /* mov [ebp-0x66], eax */
            ii(0x100f_0f2c, 7); mov(memd_a32[ss, ebp - 0x7c], 0);       /* mov dword [ebp-0x7c], 0x0 */
            ii(0x100f_0f33, 7); mov(memd_a32[ss, ebp - 0x78], 0);       /* mov dword [ebp-0x78], 0x0 */
            ii(0x100f_0f3a, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x100f_0f3d, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100f_0f40, 3); mov(memd_a32[ss, ebp - 0x74], eax);     /* mov [ebp-0x74], eax */
            ii(0x100f_0f43, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x100f_0f46, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100f_0f48, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_0f4b, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x100f_0f4e, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x100f_0f51, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100f_0f54, 4); mov(memw_a32[ss, ebp - 0x6c], ax);      /* mov [ebp-0x6c], ax */
            ii(0x100f_0f58, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_0f5b, 1); inc(eax);                               /* inc eax */
            ii(0x100f_0f5c, 3); mov(memd_a32[ss, ebp - 0x80], eax);     /* mov [ebp-0x80], eax */
            ii(0x100f_0f5f, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_0f63, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100f_0f66, 2); if(jnzd(0x100f_0f6f, 0x7)) goto l_0x100f_0f6f; /* jnz 0x100f0f6f */
            ii(0x100f_0f68, 7); mov(memd_a32[ss, ebp - 0x80], 0xff);    /* mov dword [ebp-0x80], 0xff */
        l_0x100f_0f6f:
            ii(0x100f_0f6f, 5); mov(ecx, 0x3f);                         /* mov ecx, 0x3f */
            ii(0x100f_0f74, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_0f76, 3); mov(bl, memb_a32[ss, ebp - 0x80]);      /* mov bl, [ebp-0x80] */
            ii(0x100f_0f79, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_0f7b, 3); mov(dl, memb_a32[ss, ebp - 0x80]);      /* mov dl, [ebp-0x80] */
            ii(0x100f_0f7e, 6); lea(eax, ebp - 0x84);                   /* lea eax, [ebp-0x84] */
            ii(0x100f_0f84, 5); calld(0x100d_53a4, -0x1_bbe5);          /* call 0x100d53a4 */
            ii(0x100f_0f89, 1); pushd(eax);                             /* push eax */
            ii(0x100f_0f8a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_0f8f, 1); pushd(eax);                             /* push eax */
            ii(0x100f_0f90, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_0f95, 1); pushd(eax);                             /* push eax */
            ii(0x100f_0f96, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x100f_0f99, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100f_0f9b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_0f9e, 1); pushd(eax);                             /* push eax */
            ii(0x100f_0f9f, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x100f_0fa2, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100f_0fa5, 1); pushd(eax);                             /* push eax */
            ii(0x100f_0fa6, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_0fa8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_0faa, 5); mov(edx, StringDefinitions.EndTurn);    /* mov edx, 0x101a22e8 */
            ii(0x100f_0faf, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x100f_0fb2, 5); calld(0x100e_ab9d, -0x641a);            /* call 0x100eab9d */
            ii(0x100f_0fb7, 5); jmpd(0x100f_0ef0, -0xcc); goto l_0x100f_0ef0; /* jmp 0x100f0ef0 */
        l_0x100f_0fbc:
            ii(0x100f_0fbc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_0fbe, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_0fbf, 1); popd(edi);                              /* pop edi */
            ii(0x100f_0fc0, 1); popd(esi);                              /* pop esi */
            ii(0x100f_0fc1, 1); popd(edx);                              /* pop edx */
            ii(0x100f_0fc2, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_0fc3, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_0fc4, 1); retd(); return;                         /* ret */
        }
    }
}
