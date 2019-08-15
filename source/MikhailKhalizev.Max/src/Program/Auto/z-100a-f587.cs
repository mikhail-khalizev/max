using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("989f5f2b-1f6a-41a1-9c4a-c3354e32f83c")]
        public void Method_100a_f587()
        {
            ii(0x100a_f587, 5); pushd(0x5c);                            /* push 0x5c */
            ii(0x100a_f58c, 5); calld(Definitions.sys_check_available_stack_size, 0xb_67c1); /* call 0x10165d52 */
            ii(0x100a_f591, 1); pushd(esi);                             /* push esi */
            ii(0x100a_f592, 1); pushd(edi);                             /* push edi */
            ii(0x100a_f593, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_f594, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_f596, 6); sub(esp, 0x4c);                         /* sub esp, 0x4c */
            ii(0x100a_f59c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_f59f, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100a_f5a2, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100a_f5a5, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100a_f5a8, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100a_f5ab, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f5ae, 5); calld(0x1008_a5f0, -0x2_4fc3);          /* call 0x1008a5f0 */
            ii(0x100a_f5b3, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100a_f5b6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f5b9, 5); calld(0x1008_a520, -0x2_509e);          /* call 0x1008a520 */
            ii(0x100a_f5be, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f5c1, 5); calld(0x1007_6574, -0x3_9052);          /* call 0x10076574 */
            ii(0x100a_f5c6, 5); calld(0x1015_26ac, 0xa_30e1);           /* call 0x101526ac */
            ii(0x100a_f5cb, 5); calld(0x1008_b4b4, -0x2_411c);          /* call 0x1008b4b4 */
            ii(0x100a_f5d0, 2); test(al, al);                           /* test al, al */
            ii(0x100a_f5d2, 2); if(jzd(0x100a_f5e3, 0xf)) goto l_0x100a_f5e3; /* jz 0x100af5e3 */
            ii(0x100a_f5d4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f5d6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f5d9, 5); calld(0x1008_8d4c, -0x2_6892);          /* call 0x10088d4c */
            ii(0x100a_f5de, 5); jmpd(0x100a_f8cd, 0x2ea); goto l_0x100a_f8cd; /* jmp 0x100af8cd */
        l_0x100a_f5e3:
            ii(0x100a_f5e3, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100a_f5e7, 2); if(jnzd(0x100a_f605, 0x1c)) goto l_0x100a_f605; /* jnz 0x100af605 */
            ii(0x100a_f5e9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f5ec, 5); calld(0x1008_a520, -0x2_50d1);          /* call 0x1008a520 */
            ii(0x100a_f5f1, 5); calld(0x100a_e04c, -0x15aa);            /* call 0x100ae04c */
            ii(0x100a_f5f6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f5f8, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f5fb, 5); calld(0x1008_8d4c, -0x2_68b4);          /* call 0x10088d4c */
            ii(0x100a_f600, 5); jmpd(0x100a_f8cd, 0x2c8); goto l_0x100a_f8cd; /* jmp 0x100af8cd */
        l_0x100a_f605:
            ii(0x100a_f605, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100a_f608, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_f60b, 5); calld(0x100b_8204, 0x8bf4);             /* call 0x100b8204 */
            ii(0x100a_f610, 4); or(memb_a32[ss, ebp - 0x1c], 0x1);      /* or byte [ebp-0x1c], 0x1 */
            ii(0x100a_f614, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_f617, 5); calld(Definitions.my_ctor_0x101b38f8, -0x3_8f2c); /* call 0x100766f0 */
            ii(0x100a_f61c, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100a_f61f, 4); and(memb_a32[ss, ebp - 0x1c], -0x2 /* 0xfe */); /* and byte [ebp-0x1c], 0xfe */
            ii(0x100a_f623, 4); mov(memb_a32[ss, ebp - 0x28], 0);       /* mov byte [ebp-0x28], 0x0 */
            ii(0x100a_f627, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100a_f62a, 5); calld(Definitions.my_ctor_0x101b4184, -0x3_8b3f); /* call 0x10076af0 */
            ii(0x100a_f62f, 4); or(memb_a32[ss, ebp - 0x1c], 0x1);      /* or byte [ebp-0x1c], 0x1 */
            ii(0x100a_f633, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100a_f636, 5); calld(0x1009_c930, -0x1_2d0b);          /* call 0x1009c930 */
            ii(0x100a_f63b, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100a_f63e, 4); and(memb_a32[ss, ebp - 0x1c], -0x2 /* 0xfe */); /* and byte [ebp-0x1c], 0xfe */
            ii(0x100a_f642, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x100a_f647, 5); calld(Definitions.sys_new, 0xb_67b4);   /* call 0x10165e00 */
            ii(0x100a_f64c, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100a_f64f, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100a_f652, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100a_f655, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x100a_f659, 2); if(jzd(0x100a_f68a, 0x2f)) goto l_0x100a_f68a; /* jz 0x100af68a */
            ii(0x100a_f65b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f65e, 5); calld(0x1008_a57c, -0x2_50e7);          /* call 0x1008a57c */
            ii(0x100a_f663, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_f665, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f668, 5); calld(0x1008_a520, -0x2_514d);          /* call 0x1008a520 */
            ii(0x100a_f66d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f670, 5); calld(0x1007_65d0, -0x3_90a5);          /* call 0x100765d0 */
            ii(0x100a_f675, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_f677, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100a_f67a, 5); calld(0x100a_73d7, -0x82a8);            /* call 0x100a73d7 */
            ii(0x100a_f67f, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100a_f682, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100a_f685, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100a_f688, 2); jmpd(0x100a_f690, 0x6); goto l_0x100a_f690; /* jmp 0x100af690 */
        l_0x100a_f68a:
            ii(0x100a_f68a, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100a_f68d, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
        l_0x100a_f690:
            ii(0x100a_f690, 3); mov(edx, memd_a32[ss, ebp - 0x44]);     /* mov edx, [ebp-0x44] */
            ii(0x100a_f693, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100a_f696, 5); calld(0x1009_c8f8, -0x1_2da3);          /* call 0x1009c8f8 */
            ii(0x100a_f69b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f69e, 5); calld(0x1008_a520, -0x2_5183);          /* call 0x1008a520 */
            ii(0x100a_f6a3, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f6a6, 5); calld(0x1007_6574, -0x3_9137);          /* call 0x10076574 */
            ii(0x100a_f6ab, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x100a_f6af, 2); if(jzd(0x100a_f6ba, 0x9)) goto l_0x100a_f6ba; /* jz 0x100af6ba */
            ii(0x100a_f6b1, 7); mov(memd_a32[ss, ebp - 0x48], 0x40);    /* mov dword [ebp-0x48], 0x40 */
            ii(0x100a_f6b8, 2); jmpd(0x100a_f6c1, 0x7); goto l_0x100a_f6c1; /* jmp 0x100af6c1 */
        l_0x100a_f6ba:
            ii(0x100a_f6ba, 7); mov(memd_a32[ss, ebp - 0x48], 0x180);   /* mov dword [ebp-0x48], 0x180 */
        l_0x100a_f6c1:
            ii(0x100a_f6c1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f6c4, 5); calld(0x1008_a520, -0x2_51a9);          /* call 0x1008a520 */
            ii(0x100a_f6c9, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f6cc, 5); calld(0x1007_6574, -0x3_915d);          /* call 0x10076574 */
            ii(0x100a_f6d1, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x100a_f6d5, 4); mov(memw_a32[ss, ebp - 0x2c], ax);      /* mov [ebp-0x2c], ax */
            ii(0x100a_f6d9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f6dc, 5); calld(0x1008_a520, -0x2_51c1);          /* call 0x1008a520 */
            ii(0x100a_f6e1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_f6e4, 5); calld(0x1007_6574, -0x3_9175);          /* call 0x10076574 */
            ii(0x100a_f6e9, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x100a_f6ed, 4); mov(memw_a32[ss, ebp - 0x2a], ax);      /* mov [ebp-0x2a], ax */
            ii(0x100a_f6f1, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x100a_f6f4, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100a_f6f7, 5); calld(0x100a_a824, -0x4ed8);            /* call 0x100aa824 */
            ii(0x100a_f6fc, 5); calld(0x100a_7557, -0x81aa);            /* call 0x100a7557 */
            ii(0x100a_f701, 7); mov(memd_a32[ss, ebp - 0x4c], 0);       /* mov dword [ebp-0x4c], 0x0 */
            ii(0x100a_f708, 2); jmpd(0x100a_f710, 0x6); goto l_0x100a_f710; /* jmp 0x100af710 */
        l_0x100a_f70a:
            ii(0x100a_f70a, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100a_f70d, 3); inc(memd_a32[ss, ebp - 0x4c]);          /* inc dword [ebp-0x4c] */
        l_0x100a_f710:
            ii(0x100a_f710, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_f713, 5); calld(0x100b_82bc, 0x8ba4);             /* call 0x100b82bc */
            ii(0x100a_f718, 4); cmp(ax, memw_a32[ss, ebp - 0x4c]);      /* cmp ax, [ebp-0x4c] */
            ii(0x100a_f71c, 6); if(jled(0x100a_f7f0, 0xce)) goto l_0x100a_f7f0; /* jle 0x100af7f0 */
            ii(0x100a_f722, 4); movsx(edx, memw_a32[ss, ebp - 0x4c]);   /* movsx edx, word [ebp-0x4c] */
            ii(0x100a_f726, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_f729, 5); calld(0x100b_827c, 0x8b4e);             /* call 0x100b827c */
            ii(0x100a_f72e, 4); movsx(ax, memb_a32[ds, eax]);           /* movsx ax, byte [eax] */
            ii(0x100a_f732, 4); add(memw_a32[ss, ebp - 0x2c], ax);      /* add [ebp-0x2c], ax */
            ii(0x100a_f736, 4); movsx(edx, memw_a32[ss, ebp - 0x4c]);   /* movsx edx, word [ebp-0x4c] */
            ii(0x100a_f73a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_f73d, 5); calld(0x100b_827c, 0x8b3a);             /* call 0x100b827c */
            ii(0x100a_f742, 5); movsx(ax, memb_a32[ds, eax + 0x1]);     /* movsx ax, byte [eax+0x1] */
            ii(0x100a_f747, 4); add(memw_a32[ss, ebp - 0x2a], ax);      /* add [ebp-0x2a], ax */
            ii(0x100a_f74b, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x100a_f74e, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100a_f751, 5); calld(0x100a_a824, -0x4f32);            /* call 0x100aa824 */
            ii(0x100a_f756, 5); calld(0x100a_7557, -0x8204);            /* call 0x100a7557 */
            ii(0x100a_f75b, 3); mov(ecx, memd_a32[ss, ebp - 0x48]);     /* mov ecx, [ebp-0x48] */
            ii(0x100a_f75e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f761, 5); calld(0x1008_a520, -0x2_5246);          /* call 0x1008a520 */
            ii(0x100a_f766, 3); mov(ebx, memd_a32[ds, eax + 0x7]);      /* mov ebx, [eax+0x7] */
            ii(0x100a_f769, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_f76c, 4); movsx(edx, memw_a32[ss, ebp - 0x2a]);   /* movsx edx, word [ebp-0x2a] */
            ii(0x100a_f770, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x100a_f774, 5); calld(0x1007_388b, -0x3_beee);          /* call 0x1007388b */
            ii(0x100a_f779, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_f77b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_f77e, 5); calld(0x1007_6630, -0x3_9153);          /* call 0x10076630 */
            ii(0x100a_f783, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f785, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_f788, 5); calld(0x1013_ad71, 0x8_b5e4);           /* call 0x1013ad71 */
            ii(0x100a_f78d, 2); test(al, al);                           /* test al, al */
            ii(0x100a_f78f, 2); if(jzd(0x100a_f7eb, 0x5a)) goto l_0x100a_f7eb; /* jz 0x100af7eb */
            ii(0x100a_f791, 4); mov(memb_a32[ss, ebp - 0x28], 0x1);     /* mov byte [ebp-0x28], 0x1 */
            ii(0x100a_f795, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f798, 5); calld(0x1008_a520, -0x2_527d);          /* call 0x1008a520 */
            ii(0x100a_f79d, 3); lea(edx, eax + 0x13);                   /* lea edx, [eax+0x13] */
            ii(0x100a_f7a0, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_f7a3, 5); calld(0x1008_b530, -0x2_4278);          /* call 0x1008b530 */
            ii(0x100a_f7a8, 2); test(al, al);                           /* test al, al */
            ii(0x100a_f7aa, 2); if(jzd(0x100a_f7eb, 0x3f)) goto l_0x100a_f7eb; /* jz 0x100af7eb */
            ii(0x100a_f7ac, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100a_f7b1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f7b4, 5); calld(0x1008_a520, -0x2_5299);          /* call 0x1008a520 */
            ii(0x100a_f7b9, 5); calld(0x100a_d02d, -0x2791);            /* call 0x100ad02d */
            ii(0x100a_f7be, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f7c0, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100a_f7c3, 5); calld(0x1009_b8ec, -0x1_3edc);          /* call 0x1009b8ec */
            ii(0x100a_f7c8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f7ca, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_f7cd, 5); calld(0x1007_5f2c, -0x3_98a6);          /* call 0x10075f2c */
            ii(0x100a_f7d2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f7d4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_f7d7, 5); calld(0x100b_7294, 0x7ab8);             /* call 0x100b7294 */
            ii(0x100a_f7dc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f7de, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f7e1, 5); calld(0x1008_8d4c, -0x2_6a9a);          /* call 0x10088d4c */
            ii(0x100a_f7e6, 5); jmpd(0x100a_f8cd, 0xe2); goto l_0x100a_f8cd; /* jmp 0x100af8cd */
        l_0x100a_f7eb:
            ii(0x100a_f7eb, 5); jmpd(0x100a_f70a, -0xe6); goto l_0x100a_f70a; /* jmp 0x100af70a */
        l_0x100a_f7f0:
            ii(0x100a_f7f0, 4); cmp(memb_a32[ss, ebp - 0x28], 0);       /* cmp byte [ebp-0x28], 0x0 */
            ii(0x100a_f7f4, 2); if(jnzd(0x100a_f846, 0x50)) goto l_0x100a_f846; /* jnz 0x100af846 */
            ii(0x100a_f7f6, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x100a_f7f9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f7fc, 5); calld(0x1008_a520, -0x2_52e1);          /* call 0x1008a520 */
            ii(0x100a_f801, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_f804, 5); calld(0x1008_8b44, -0x2_6cc5);          /* call 0x10088b44 */
            ii(0x100a_f809, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_f80c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f80f, 5); calld(0x1008_a520, -0x2_52f4);          /* call 0x1008a520 */
            ii(0x100a_f814, 5); calld(0x100a_fbb7, 0x39e);              /* call 0x100afbb7 */
            ii(0x100a_f819, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f81b, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100a_f81e, 5); calld(0x1009_b8ec, -0x1_3f37);          /* call 0x1009b8ec */
            ii(0x100a_f823, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f825, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_f828, 5); calld(0x1007_5f2c, -0x3_9901);          /* call 0x10075f2c */
            ii(0x100a_f82d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f82f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_f832, 5); calld(0x100b_7294, 0x7a5d);             /* call 0x100b7294 */
            ii(0x100a_f837, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f839, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f83c, 5); calld(0x1008_8d4c, -0x2_6af5);          /* call 0x10088d4c */
            ii(0x100a_f841, 5); jmpd(0x100a_f8cd, 0x87); goto l_0x100a_f8cd; /* jmp 0x100af8cd */
        l_0x100a_f846:
            ii(0x100a_f846, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x100a_f849, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f84c, 5); calld(0x1008_a520, -0x2_5331);          /* call 0x1008a520 */
            ii(0x100a_f851, 3); add(eax, 0x3c);                         /* add eax, 0x3c */
            ii(0x100a_f854, 5); calld(0x100b_8124, 0x88cb);             /* call 0x100b8124 */
            ii(0x100a_f859, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f85c, 5); calld(0x1008_a520, -0x2_5341);          /* call 0x1008a520 */
            ii(0x100a_f861, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f863, 3); mov(dl, memb_a32[ds, eax + 0x45]);      /* mov dl, [eax+0x45] */
            ii(0x100a_f866, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f869, 5); calld(0x1008_a520, -0x2_534e);          /* call 0x1008a520 */
            ii(0x100a_f86e, 3); add(eax, 0x3c);                         /* add eax, 0x3c */
            ii(0x100a_f871, 5); calld(0x100a_a824, -0x5052);            /* call 0x100aa824 */
            ii(0x100a_f876, 5); calld(0x100b_81a0, 0x8925);             /* call 0x100b81a0 */
            ii(0x100a_f87b, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100a_f87e, 5); calld(0x100b_80f4, 0x8871);             /* call 0x100b80f4 */
            ii(0x100a_f883, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_f885, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f888, 5); calld(0x1008_a520, -0x2_536d);          /* call 0x1008a520 */
            ii(0x100a_f88d, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100a_f890, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_f893, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_f899, 5); mov(ebx, 0x101c_31c4);                  /* mov ebx, 0x101c31c4 */
            ii(0x100a_f89e, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100a_f8a0, 5); calld(0x100c_21b2, 0x1_290d);           /* call 0x100c21b2 */
            ii(0x100a_f8a5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f8a7, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100a_f8aa, 5); calld(0x1009_b8ec, -0x1_3fc3);          /* call 0x1009b8ec */
            ii(0x100a_f8af, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f8b1, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_f8b4, 5); calld(0x1007_5f2c, -0x3_998d);          /* call 0x10075f2c */
            ii(0x100a_f8b9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f8bb, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_f8be, 5); calld(0x100b_7294, 0x79d1);             /* call 0x100b7294 */
            ii(0x100a_f8c3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_f8c5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_f8c8, 5); calld(0x1008_8d4c, -0x2_6b81);          /* call 0x10088d4c */
        l_0x100a_f8cd:
            ii(0x100a_f8cd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_f8cf, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_f8d0, 1); popd(edi);                              /* pop edi */
            ii(0x100a_f8d1, 1); popd(esi);                              /* pop esi */
            ii(0x100a_f8d2, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
