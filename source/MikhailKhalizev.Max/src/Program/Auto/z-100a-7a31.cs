using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_7a31-563514b7")]
        public void Method_100a_7a31()
        {
            ii(0x100a_7a31, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x100a_7a36, 5); calld(Definitions.sys_check_available_stack_size, 0xb_e317); /* call 0x10165d52 */
            ii(0x100a_7a3b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_7a3c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_7a3d, 1); pushd(edx);                             /* push edx */
            ii(0x100a_7a3e, 1); pushd(esi);                             /* push esi */
            ii(0x100a_7a3f, 1); pushd(edi);                             /* push edi */
            ii(0x100a_7a40, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_7a41, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_7a43, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x100a_7a49, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_7a4c, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100a_7a4f, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_0f64); /* call 0x10076af0 */
            ii(0x100a_7a54, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x100a_7a58, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7a5b, 5); calld(0x1009_c930, -0xb130);            /* call 0x1009c930 */
            ii(0x100a_7a60, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100a_7a63, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x100a_7a67, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7a6a, 4); mov(memb_a32[ds, eax + 0x13], 0x1);     /* mov byte [eax+0x13], 0x1 */
            ii(0x100a_7a6e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7a71, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x100a_7a74, 5); calld(0x1009_cb94, -0xaee5);            /* call 0x1009cb94 */
            ii(0x100a_7a79, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7a7c, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_7a7f, 5); calld(0x1009_cb94, -0xaef0);            /* call 0x1009cb94 */
            ii(0x100a_7a84, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7a87, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x100a_7a8a, 5); calld(0x1009_cb94, -0xaefb);            /* call 0x1009cb94 */
            ii(0x100a_7a8f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7a92, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100a_7a95, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_7a98, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_7a9e, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x100a_7aa3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_7aa5, 5); calld(0x1008_a0c8, -0x1_d9e2);          /* call 0x1008a0c8 */
            ii(0x100a_7aaa, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_7aad, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100a_7ab1, 6); if(jzd(0x100a_7b53, 0x9c)) goto l_0x100a_7b53; /* jz 0x100a7b53 */
            ii(0x100a_7ab7, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100a_7abe, 2); jmpd(0x100a_7ac6, 0x6); goto l_0x100a_7ac6; /* jmp 0x100a7ac6 */
        l_0x100a_7ac0:
            ii(0x100a_7ac0, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_7ac3, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x100a_7ac6:
            ii(0x100a_7ac6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7ac9, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_7acc, 5); calld(Definitions.my_1_get_count, 0x3a07); /* call 0x100ab4d8 */
            ii(0x100a_7ad1, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x100a_7ad5, 6); if(jled(0x100a_7b53, 0x78)) goto l_0x100a_7b53; /* jle 0x100a7b53 */
            ii(0x100a_7adb, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100a_7adf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7ae2, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_7ae5, 5); calld(0x100a_a8fc, 0x2e12);             /* call 0x100aa8fc */
            ii(0x100a_7aea, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_7aec, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7aef, 5); calld(0x1009_c8f8, -0xb1fc);            /* call 0x1009c8f8 */
            ii(0x100a_7af4, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100a_7afb, 2); jmpd(0x100a_7b03, 0x6); goto l_0x100a_7b03; /* jmp 0x100a7b03 */
        l_0x100a_7afd:
            ii(0x100a_7afd, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_7b00, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x100a_7b03:
            ii(0x100a_7b03, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7b06, 5); calld(0x100a_a824, 0x2d19);             /* call 0x100aa824 */
            ii(0x100a_7b0b, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_7b0e, 5); calld(Definitions.my_3_get_count, -0x1_c693); /* call 0x1008b480 */
            ii(0x100a_7b13, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x100a_7b17, 2); if(jled(0x100a_7b4e, 0x35)) goto l_0x100a_7b4e; /* jle 0x100a7b4e */
            ii(0x100a_7b19, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100a_7b1d, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7b20, 5); calld(0x100a_a824, 0x2cff);             /* call 0x100aa824 */
            ii(0x100a_7b25, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_7b28, 5); calld(0x100a_aa28, 0x2efb);             /* call 0x100aaa28 */
            ii(0x100a_7b2d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_7b2f, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100a_7b32, 5); calld(0x1008_8b44, -0x1_eff3);          /* call 0x10088b44 */
            ii(0x100a_7b37, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100a_7b3b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100a_7b3e, 3); add(eax, memd_a32[ss, ebp - 0x1c]);     /* add eax, [ebp-0x1c] */
            ii(0x100a_7b41, 4); movsx(edx, memw_a32[ss, ebp - 0x26]);   /* movsx edx, word [ebp-0x26] */
            ii(0x100a_7b45, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100a_7b47, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_7b49, 3); and(memb_a32[ds, eax], -0x9 /* 0xf7 */); /* and byte [eax], 0xf7 */
            ii(0x100a_7b4c, 2); jmpd(0x100a_7afd, -0x51); goto l_0x100a_7afd; /* jmp 0x100a7afd */
        l_0x100a_7b4e:
            ii(0x100a_7b4e, 5); jmpd(0x100a_7ac0, -0x93); goto l_0x100a_7ac0; /* jmp 0x100a7ac0 */
        l_0x100a_7b53:
            ii(0x100a_7b53, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100a_7b5a, 2); jmpd(0x100a_7b62, 0x6); goto l_0x100a_7b62; /* jmp 0x100a7b62 */
        l_0x100a_7b5c:
            ii(0x100a_7b5c, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_7b5f, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x100a_7b62:
            ii(0x100a_7b62, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7b65, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_7b68, 5); calld(Definitions.my_1_get_count, 0x396b); /* call 0x100ab4d8 */
            ii(0x100a_7b6d, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x100a_7b71, 6); if(jled(0x100a_7e54, 0x2dd)) goto l_0x100a_7e54; /* jle 0x100a7e54 */
            ii(0x100a_7b77, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100a_7b7b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7b7e, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_7b81, 5); calld(0x100a_a8fc, 0x2d76);             /* call 0x100aa8fc */
            ii(0x100a_7b86, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_7b88, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7b8b, 5); calld(0x1009_c8f8, -0xb298);            /* call 0x1009c8f8 */
            ii(0x100a_7b90, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_7b94, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100a_7b9b, 2); jmpd(0x100a_7ba3, 0x6); goto l_0x100a_7ba3; /* jmp 0x100a7ba3 */
        l_0x100a_7b9d:
            ii(0x100a_7b9d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_7ba0, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x100a_7ba3:
            ii(0x100a_7ba3, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7ba6, 5); calld(0x100a_a824, 0x2c79);             /* call 0x100aa824 */
            ii(0x100a_7bab, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_7bae, 5); calld(Definitions.my_3_get_count, -0x1_c733); /* call 0x1008b480 */
            ii(0x100a_7bb3, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x100a_7bb7, 6); if(jled(0x100a_7e18, 0x25b)) goto l_0x100a_7e18; /* jle 0x100a7e18 */
            ii(0x100a_7bbd, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100a_7bc1, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7bc4, 5); calld(0x100a_a824, 0x2c5b);             /* call 0x100aa824 */
            ii(0x100a_7bc9, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_7bcc, 5); calld(0x100a_aa28, 0x2e57);             /* call 0x100aaa28 */
            ii(0x100a_7bd1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_7bd3, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100a_7bd6, 5); calld(0x1008_8b44, -0x1_f097);          /* call 0x10088b44 */
            ii(0x100a_7bdb, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100a_7bdf, 2); if(jzd(0x100a_7bf6, 0x15)) goto l_0x100a_7bf6; /* jz 0x100a7bf6 */
            ii(0x100a_7be1, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100a_7be5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100a_7be8, 3); add(eax, memd_a32[ss, ebp - 0x1c]);     /* add eax, [ebp-0x1c] */
            ii(0x100a_7beb, 4); movsx(edx, memw_a32[ss, ebp - 0x26]);   /* movsx edx, word [ebp-0x26] */
            ii(0x100a_7bef, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100a_7bf1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_7bf3, 3); or(memb_a32[ds, eax], 0x8);             /* or byte [eax], 0x8 */
        l_0x100a_7bf6:
            ii(0x100a_7bf6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7bf9, 3); mov(ecx, memd_a32[ds, eax + 0x52]);     /* mov ecx, [eax+0x52] */
            ii(0x100a_7bfc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7bff, 3); mov(ebx, memd_a32[ds, eax + 0x7]);      /* mov ebx, [eax+0x7] */
            ii(0x100a_7c02, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_7c05, 4); movsx(edx, memw_a32[ss, ebp - 0x26]);   /* movsx edx, word [ebp-0x26] */
            ii(0x100a_7c09, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100a_7c0d, 5); calld(0x1007_388b, -0x3_4387);          /* call 0x1007388b */
            ii(0x100a_7c12, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100a_7c15, 4); cmp(memd_a32[ss, ebp - 0x2c], 0);       /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x100a_7c19, 2); if(jzd(0x100a_7c32, 0x17)) goto l_0x100a_7c32; /* jz 0x100a7c32 */
            ii(0x100a_7c1b, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7c1e, 5); calld(0x100a_a824, 0x2c01);             /* call 0x100aa824 */
            ii(0x100a_7c23, 3); lea(edx, eax + 0x16);                   /* lea edx, [eax+0x16] */
            ii(0x100a_7c26, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100a_7c29, 5); calld(0x1008_b4b4, -0x1_c77a);          /* call 0x1008b4b4 */
            ii(0x100a_7c2e, 2); test(al, al);                           /* test al, al */
            ii(0x100a_7c30, 2); if(jnzd(0x100a_7c34, 0x2)) goto l_0x100a_7c34; /* jnz 0x100a7c34 */
        l_0x100a_7c32:
            ii(0x100a_7c32, 2); jmpd(0x100a_7c38, 0x4); goto l_0x100a_7c38; /* jmp 0x100a7c38 */
        l_0x100a_7c34:
            ii(0x100a_7c34, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x100a_7c38:
            ii(0x100a_7c38, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100a_7c3b, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100a_7c3e, 5); calld(0x1007_5e64, -0x3_1ddf);          /* call 0x10075e64 */
            ii(0x100a_7c43, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100a_7c46, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_7c48, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_7c4a, 5); calld(0x100a_7e7a, 0x22b);              /* call 0x100a7e7a */
            ii(0x100a_7c4f, 2); test(al, al);                           /* test al, al */
            ii(0x100a_7c51, 6); if(jzd(0x100a_7e13, 0x1bc)) goto l_0x100a_7e13; /* jz 0x100a7e13 */
            ii(0x100a_7c57, 4); cmp(memd_a32[ss, ebp - 0x2c], 0);       /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x100a_7c5b, 2); if(jnzd(0x100a_7cb7, 0x5a)) goto l_0x100a_7cb7; /* jnz 0x100a7cb7 */
            ii(0x100a_7c5d, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100a_7c62, 1); pushd(eax);                             /* push eax */
            ii(0x100a_7c63, 4); movsx(ecx, memw_a32[ss, ebp - 0x26]);   /* movsx ecx, word [ebp-0x26] */
            ii(0x100a_7c67, 4); movsx(ebx, memw_a32[ss, ebp - 0x28]);   /* movsx ebx, word [ebp-0x28] */
            ii(0x100a_7c6b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7c6e, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x100a_7c71, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_7c74, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7c77, 5); calld(0x100a_a824, 0x2ba8);             /* call 0x100aa824 */
            ii(0x100a_7c7c, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x100a_7c7f, 5); calld(0x1007_6574, -0x3_1710);          /* call 0x10076574 */
            ii(0x100a_7c84, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100a_7c87, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_7c8a, 5); calld(0x1007_02b9, -0x3_79d6);          /* call 0x100702b9 */
            ii(0x100a_7c8f, 1); cwde();                                 /* cwde */
            ii(0x100a_7c90, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_7c92, 2); if(jzd(0x100a_7ca4, 0x10)) goto l_0x100a_7ca4; /* jz 0x100a7ca4 */
            ii(0x100a_7c94, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100a_7c97, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7c9a, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x100a_7c9d, 5); calld(0x100a_aa64, 0x2dc2);             /* call 0x100aaa64 */
            ii(0x100a_7ca2, 2); jmpd(0x100a_7cb2, 0xe); goto l_0x100a_7cb2; /* jmp 0x100a7cb2 */
        l_0x100a_7ca4:
            ii(0x100a_7ca4, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100a_7ca7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7caa, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x100a_7cad, 5); calld(0x100a_aa64, 0x2db2);             /* call 0x100aaa64 */
        l_0x100a_7cb2:
            ii(0x100a_7cb2, 5); jmpd(0x100a_7e13, 0x15c); goto l_0x100a_7e13; /* jmp 0x100a7e13 */
        l_0x100a_7cb7:
            ii(0x100a_7cb7, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100a_7cba, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7cbc, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100a_7cbf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7cc2, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100a_7cc5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_7cc8, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_7cca, 2); if(jzd(0x100a_7cfd, 0x31)) goto l_0x100a_7cfd; /* jz 0x100a7cfd */
            ii(0x100a_7ccc, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100a_7cd0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7cd3, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_7cd6, 5); calld(0x1013_b24f, 0x9_3574);           /* call 0x1013b24f */
            ii(0x100a_7cdb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7cdd, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7ce0, 5); calld(0x100a_a824, 0x2b3f);             /* call 0x100aa824 */
            ii(0x100a_7ce5, 5); calld(0x100a_7608, -0x6e2);             /* call 0x100a7608 */
            ii(0x100a_7cea, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_7cee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7cf0, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7cf3, 5); calld(0x1009_b8ec, -0xc40c);            /* call 0x1009b8ec */
            ii(0x100a_7cf8, 5); jmpd(0x100a_7e6e, 0x171); goto l_0x100a_7e6e; /* jmp 0x100a7e6e */
        l_0x100a_7cfd:
            ii(0x100a_7cfd, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7d00, 5); calld(0x100a_a824, 0x2b1f);             /* call 0x100aa824 */
            ii(0x100a_7d05, 3); lea(edx, eax + 0x16);                   /* lea edx, [eax+0x16] */
            ii(0x100a_7d08, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100a_7d0b, 5); calld(0x1007_6d98, -0x3_0f78);          /* call 0x10076d98 */
            ii(0x100a_7d10, 2); test(al, al);                           /* test al, al */
            ii(0x100a_7d12, 2); if(jzd(0x100a_7d27, 0x13)) goto l_0x100a_7d27; /* jz 0x100a7d27 */
            ii(0x100a_7d14, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100a_7d17, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7d1a, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x100a_7d1d, 5); calld(0x100a_aa64, 0x2d42);             /* call 0x100aaa64 */
            ii(0x100a_7d22, 5); jmpd(0x100a_7e13, 0xec); goto l_0x100a_7e13; /* jmp 0x100a7e13 */
        l_0x100a_7d27:
            ii(0x100a_7d27, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7d2a, 5); calld(0x100a_a824, 0x2af5);             /* call 0x100aa824 */
            ii(0x100a_7d2f, 5); calld(0x100a_a9f8, 0x2cc4);             /* call 0x100aa9f8 */
            ii(0x100a_7d34, 2); test(al, al);                           /* test al, al */
            ii(0x100a_7d36, 2); if(jzd(0x100a_7d48, 0x10)) goto l_0x100a_7d48; /* jz 0x100a7d48 */
            ii(0x100a_7d38, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100a_7d3b, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100a_7d3e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_7d43, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_7d46, 2); if(jld(0x100a_7d4a, 0x2)) goto l_0x100a_7d4a; /* jl 0x100a7d4a */
        l_0x100a_7d48:
            ii(0x100a_7d48, 2); jmpd(0x100a_7d7b, 0x31); goto l_0x100a_7d7b; /* jmp 0x100a7d7b */
        l_0x100a_7d4a:
            ii(0x100a_7d4a, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100a_7d4e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7d51, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_7d54, 5); calld(0x1013_b24f, 0x9_34f6);           /* call 0x1013b24f */
            ii(0x100a_7d59, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7d5b, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7d5e, 5); calld(0x100a_a824, 0x2ac1);             /* call 0x100aa824 */
            ii(0x100a_7d63, 5); calld(0x100a_7608, -0x760);             /* call 0x100a7608 */
            ii(0x100a_7d68, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_7d6c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7d6e, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7d71, 5); calld(0x1009_b8ec, -0xc48a);            /* call 0x1009b8ec */
            ii(0x100a_7d76, 5); jmpd(0x100a_7e6e, 0xf3); goto l_0x100a_7e6e; /* jmp 0x100a7e6e */
        l_0x100a_7d7b:
            ii(0x100a_7d7b, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100a_7d7e, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x100a_7d82, 2); if(jzd(0x100a_7d8d, 0x9)) goto l_0x100a_7d8d; /* jz 0x100a7d8d */
            ii(0x100a_7d84, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100a_7d87, 4); cmp(memb_a32[ds, eax + 0x3d], 0xc);     /* cmp byte [eax+0x3d], 0xc */
            ii(0x100a_7d8b, 2); if(jnzd(0x100a_7d8f, 0x2)) goto l_0x100a_7d8f; /* jnz 0x100a7d8f */
        l_0x100a_7d8d:
            ii(0x100a_7d8d, 2); jmpd(0x100a_7df3, 0x64); goto l_0x100a_7df3; /* jmp 0x100a7df3 */
        l_0x100a_7d8f:
            ii(0x100a_7d8f, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100a_7d92, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100a_7d96, 2); if(jnzd(0x100a_7da1, 0x9)) goto l_0x100a_7da1; /* jnz 0x100a7da1 */
            ii(0x100a_7d98, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100a_7d9b, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1f);    /* cmp byte [eax+0x3e], 0x1f */
            ii(0x100a_7d9f, 2); if(jnzd(0x100a_7db2, 0x11)) goto l_0x100a_7db2; /* jnz 0x100a7db2 */
        l_0x100a_7da1:
            ii(0x100a_7da1, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7da4, 5); calld(0x100a_a824, 0x2a7b);             /* call 0x100aa824 */
            ii(0x100a_7da9, 5); calld(0x100a_a9f8, 0x2c4a);             /* call 0x100aa9f8 */
            ii(0x100a_7dae, 2); test(al, al);                           /* test al, al */
            ii(0x100a_7db0, 2); if(jzd(0x100a_7de3, 0x31)) goto l_0x100a_7de3; /* jz 0x100a7de3 */
        l_0x100a_7db2:
            ii(0x100a_7db2, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100a_7db6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7db9, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_7dbc, 5); calld(0x1013_b24f, 0x9_348e);           /* call 0x1013b24f */
            ii(0x100a_7dc1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7dc3, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7dc6, 5); calld(0x100a_a824, 0x2a59);             /* call 0x100aa824 */
            ii(0x100a_7dcb, 5); calld(0x100a_7608, -0x7c8);             /* call 0x100a7608 */
            ii(0x100a_7dd0, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_7dd4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7dd6, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7dd9, 5); calld(0x1009_b8ec, -0xc4f2);            /* call 0x1009b8ec */
            ii(0x100a_7dde, 5); jmpd(0x100a_7e6e, 0x8b); goto l_0x100a_7e6e; /* jmp 0x100a7e6e */
        l_0x100a_7de3:
            ii(0x100a_7de3, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100a_7de6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7de9, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x100a_7dec, 5); calld(0x100a_aa64, 0x2c73);             /* call 0x100aaa64 */
            ii(0x100a_7df1, 2); jmpd(0x100a_7e13, 0x20); goto l_0x100a_7e13; /* jmp 0x100a7e13 */
        l_0x100a_7df3:
            ii(0x100a_7df3, 3); mov(ecx, memd_a32[ss, ebp - 0x2c]);     /* mov ecx, [ebp-0x2c] */
            ii(0x100a_7df6, 4); movsx(ebx, memw_a32[ss, ebp - 0x26]);   /* movsx ebx, word [ebp-0x26] */
            ii(0x100a_7dfa, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x100a_7dfe, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100a_7e01, 5); calld(0x100a_738b, -0xa7b);             /* call 0x100a738b */
            ii(0x100a_7e06, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_7e08, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7e0b, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_7e0e, 5); calld(0x100a_a73c, 0x2929);             /* call 0x100aa73c */
        l_0x100a_7e13:
            ii(0x100a_7e13, 5); jmpd(0x100a_7b9d, -0x27b); goto l_0x100a_7b9d; /* jmp 0x100a7b9d */
        l_0x100a_7e18:
            ii(0x100a_7e18, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100a_7e1c, 2); if(jnzd(0x100a_7e4f, 0x31)) goto l_0x100a_7e4f; /* jnz 0x100a7e4f */
            ii(0x100a_7e1e, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100a_7e22, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7e25, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_7e28, 5); calld(0x1013_b24f, 0x9_3422);           /* call 0x1013b24f */
            ii(0x100a_7e2d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_7e32, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7e35, 5); calld(0x100a_a824, 0x29ea);             /* call 0x100aa824 */
            ii(0x100a_7e3a, 5); calld(0x100a_7608, -0x837);             /* call 0x100a7608 */
            ii(0x100a_7e3f, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_7e43, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7e45, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7e48, 5); calld(0x1009_b8ec, -0xc561);            /* call 0x1009b8ec */
            ii(0x100a_7e4d, 2); jmpd(0x100a_7e6e, 0x1f); goto l_0x100a_7e6e; /* jmp 0x100a7e6e */
        l_0x100a_7e4f:
            ii(0x100a_7e4f, 5); jmpd(0x100a_7b5c, -0x2f8); goto l_0x100a_7b5c; /* jmp 0x100a7b5c */
        l_0x100a_7e54:
            ii(0x100a_7e54, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100a_7e58, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7e5a, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_7e5d, 5); calld(0x1009_b8ec, -0xc576);            /* call 0x1009b8ec */
            ii(0x100a_7e62, 2); jmpd(0x100a_7e6e, 0xa); goto l_0x100a_7e6e; /* jmp 0x100a7e6e */
        //  ii(0x100a_7e64, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100a_7e66, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
        //  ii(0x100a_7e69, 5); calld(0x1009_b8ec, -0xc582);            /* call 0x1009b8ec */
        l_0x100a_7e6e:
            ii(0x100a_7e6e, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100a_7e71, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_7e73, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_7e74, 1); popd(edi);                              /* pop edi */
            ii(0x100a_7e75, 1); popd(esi);                              /* pop esi */
            ii(0x100a_7e76, 1); popd(edx);                              /* pop edx */
            ii(0x100a_7e77, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_7e78, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_7e79, 1); retd(); return;                         /* ret */
        }
    }
}
