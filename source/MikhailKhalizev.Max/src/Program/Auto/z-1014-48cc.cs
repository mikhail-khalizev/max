using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_48cc-1a66a6f9")]
        public void Method_1014_48cc()
        {
            ii(0x1014_48cc, 5); push(0x1d4);                            /* push 0x1d4 */
            ii(0x1014_48d1, 5); call(Definitions.sys_check_available_stack_size, 0x2_147c); /* call 0x10165d52 */
            ii(0x1014_48d6, 1); push(ebx);                              /* push ebx */
            ii(0x1014_48d7, 1); push(ecx);                              /* push ecx */
            ii(0x1014_48d8, 1); push(edx);                              /* push edx */
            ii(0x1014_48d9, 1); push(esi);                              /* push esi */
            ii(0x1014_48da, 1); push(edi);                              /* push edi */
            ii(0x1014_48db, 1); push(ebp);                              /* push ebp */
            ii(0x1014_48dc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_48de, 6); sub(esp, 0x1b8);                        /* sub esp, 0x1b8 */
            ii(0x1014_48e4, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_48e7, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x1014_48eb, 6); lea(eax, memd[ss, ebp - 0x1b0]);        /* lea eax, [ebp-0x1b0] */
            ii(0x1014_48f1, 5); call(0x1014_4da8, 0x4b2);               /* call 0x10144da8 */
            ii(0x1014_48f6, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_48f9, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1014_48fd, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1014_4901, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_4904, 6); lea(eax, memd[ss, ebp - 0x1b0]);        /* lea eax, [ebp-0x1b0] */
            ii(0x1014_490a, 5); call(0x1014_41c6, -0x749);              /* call 0x101441c6 */
            ii(0x1014_490f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_4911, 2); if(jnz(0x1014_4925, 0x12)) goto l_0x1014_4925; /* jnz 0x10144925 */
            ii(0x1014_4913, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_4915, 6); lea(eax, memd[ss, ebp - 0x1b0]);        /* lea eax, [ebp-0x1b0] */
            ii(0x1014_491b, 5); call(0x1014_4d64, 0x444);               /* call 0x10144d64 */
            ii(0x1014_4920, 5); jmp(0x1014_4cff, 0x3da); goto l_0x1014_4cff; /* jmp 0x10144cff */
        l_0x1014_4925:
            ii(0x1014_4925, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1014_492c:
            ii(0x1014_492c, 4); cmp(memd[ss, ebp - 0x10], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1014_4930, 6); if(jnz(0x1014_4cb4, 0x37e)) goto l_0x1014_4cb4; /* jnz 0x10144cb4 */
            ii(0x1014_4936, 5); call(/* sys */ 0x1016_b208, 0x2_68cd);  /* call 0x1016b208 */
            ii(0x1014_493b, 6); mov(memd[ss, ebp - 0x1b4], eax);        /* mov [ebp-0x1b4], eax */
            ii(0x1014_4941, 7); cmp(memd[ss, ebp - 0x1b4], 0);          /* cmp dword [ebp-0x1b4], 0x0 */
            ii(0x1014_4948, 2); if(jle(0x1014_4956, 0xc)) goto l_0x1014_4956; /* jle 0x10144956 */
            ii(0x1014_494a, 10); cmp(memd[ss, ebp - 0x1b4], 0x7000);    /* cmp dword [ebp-0x1b4], 0x7000 */
            ii(0x1014_4954, 2); if(jl(0x1014_4958, 0x2)) goto l_0x1014_4958; /* jl 0x10144958 */
        l_0x1014_4956:
            ii(0x1014_4956, 2); jmp(0x1014_495c, 0x4); goto l_0x1014_495c; /* jmp 0x1014495c */
        l_0x1014_4958:
            ii(0x1014_4958, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x1014_495c:
            ii(0x1014_495c, 7); cmp(memb[ds, 0x101c_37d2], 0);          /* cmp byte [0x101c37d2], 0x0 */
            ii(0x1014_4963, 2); if(jnz(0x1014_496e, 0x9)) goto l_0x1014_496e; /* jnz 0x1014496e */
            ii(0x1014_4965, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_4968, 4); cmp(memb[ds, eax + 0x3d], 0x1a);        /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1014_496c, 2); if(jnz(0x1014_4978, 0xa)) goto l_0x1014_4978; /* jnz 0x10144978 */
        l_0x1014_496e:
            ii(0x1014_496e, 10); mov(memd[ss, ebp - 0x1b4], 0xd);       /* mov dword [ebp-0x1b4], 0xd */
        l_0x1014_4978:
            ii(0x1014_4978, 6); mov(eax, memd[ss, ebp - 0x1b4]);        /* mov eax, [ebp-0x1b4] */
            ii(0x1014_497e, 6); mov(memd[ss, ebp - 0x1b8], eax);        /* mov [ebp-0x1b8], eax */
            ii(0x1014_4984, 5); jmp(0x1014_4b8e, 0x205); goto l_0x1014_4b8e; /* jmp 0x10144b8e */
        l_0x1014_4989:
            ii(0x1014_4989, 5); call(0x1011_6ba6, -0x2_dde8);           /* call 0x10116ba6 */
            ii(0x1014_498e, 5); jmp(0x1014_4c9f, 0x30c); goto l_0x1014_4c9f; /* jmp 0x10144c9f */
        l_0x1014_4993:
            ii(0x1014_4993, 5); call(0x100d_4e6c, -0x6_fb2c);           /* call 0x100d4e6c */
            ii(0x1014_4998, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_499a, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1014_499c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_499e, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1014_49a3, 5); call(0x1010_5b00, -0x3_eea8);           /* call 0x10105b00 */
            ii(0x1014_49a8, 5); jmp(0x1014_4c9f, 0x2f2); goto l_0x1014_4c9f; /* jmp 0x10144c9f */
        l_0x1014_49ad:
            ii(0x1014_49ad, 7); mov(memd[ss, ebp - 0x10], 0x1);         /* mov dword [ebp-0x10], 0x1 */
            ii(0x1014_49b4, 5); jmp(0x1014_4c9f, 0x2e6); goto l_0x1014_4c9f; /* jmp 0x10144c9f */
        l_0x1014_49b9:
            ii(0x1014_49b9, 5); cmp(memw[ss, ebp - 0x54], 0);           /* cmp word [ebp-0x54], 0x0 */
            ii(0x1014_49be, 2); if(jz(0x1014_49c9, 0x9)) goto l_0x1014_49c9; /* jz 0x101449c9 */
            ii(0x1014_49c0, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1014_49c3, 4); cmp(ax, memw[ss, ebp - 0x50]);          /* cmp ax, [ebp-0x50] */
            ii(0x1014_49c7, 2); if(jl(0x1014_49cb, 0x2)) goto l_0x1014_49cb; /* jl 0x101449cb */
        l_0x1014_49c9:
            ii(0x1014_49c9, 2); jmp(0x1014_49f7, 0x2c); goto l_0x1014_49f7; /* jmp 0x101449f7 */
        l_0x1014_49cb:
            ii(0x1014_49cb, 5); mov(ecx, 0x80);                         /* mov ecx, 0x80 */
            ii(0x1014_49d0, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_49d5, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x1014_49da, 6); lea(eax, memd[ss, ebp - 0x162]);        /* lea eax, [ebp-0x162] */
            ii(0x1014_49e0, 5); call(0x1007_68e0, -0xc_e105);           /* call 0x100768e0 */
            ii(0x1014_49e5, 5); call(0x1014_37d1, -0x1219);             /* call 0x101437d1 */
            ii(0x1014_49ea, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_49ec, 6); lea(eax, memd[ss, ebp - 0x1b0]);        /* lea eax, [ebp-0x1b0] */
            ii(0x1014_49f2, 5); call(0x1014_4548, -0x4af);              /* call 0x10144548 */
        l_0x1014_49f7:
            ii(0x1014_49f7, 5); jmp(0x1014_4c9f, 0x2a3); goto l_0x1014_4c9f; /* jmp 0x10144c9f */
        l_0x1014_49fc:
            ii(0x1014_49fc, 5); cmp(memw[ss, ebp - 0x5c], 0);           /* cmp word [ebp-0x5c], 0x0 */
            ii(0x1014_4a01, 2); if(jz(0x1014_4a2d, 0x2a)) goto l_0x1014_4a2d; /* jz 0x10144a2d */
            ii(0x1014_4a03, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_4a08, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x1014_4a0d, 6); lea(eax, memd[ss, ebp - 0x162]);        /* lea eax, [ebp-0x162] */
            ii(0x1014_4a13, 5); call(0x1007_68e0, -0xc_e138);           /* call 0x100768e0 */
            ii(0x1014_4a18, 5); call(0x1014_3b69, -0xeb4);              /* call 0x10143b69 */
            ii(0x1014_4a1d, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1014_4a22, 6); lea(eax, memd[ss, ebp - 0x1b0]);        /* lea eax, [ebp-0x1b0] */
            ii(0x1014_4a28, 5); call(0x1014_4548, -0x4e5);              /* call 0x10144548 */
        l_0x1014_4a2d:
            ii(0x1014_4a2d, 5); jmp(0x1014_4c9f, 0x26d); goto l_0x1014_4c9f; /* jmp 0x10144c9f */
        l_0x1014_4a32:
            ii(0x1014_4a32, 6); lea(eax, memd[ss, ebp - 0x1b0]);        /* lea eax, [ebp-0x1b0] */
            ii(0x1014_4a38, 5); call(0x1014_45ae, -0x48f);              /* call 0x101445ae */
            ii(0x1014_4a3d, 5); jmp(0x1014_4c9f, 0x25d); goto l_0x1014_4c9f; /* jmp 0x10144c9f */
        l_0x1014_4a42:
            ii(0x1014_4a42, 5); cmp(memw[ss, ebp - 0x54], 0);           /* cmp word [ebp-0x54], 0x0 */
            ii(0x1014_4a47, 2); if(jz(0x1014_4a52, 0x9)) goto l_0x1014_4a52; /* jz 0x10144a52 */
            ii(0x1014_4a49, 3); mov(eax, memd[ss, ebp - 0x5a]);         /* mov eax, [ebp-0x5a] */
            ii(0x1014_4a4c, 4); cmp(ax, memw[ss, ebp - 0x4e]);          /* cmp ax, [ebp-0x4e] */
            ii(0x1014_4a50, 2); if(jl(0x1014_4a54, 0x2)) goto l_0x1014_4a54; /* jl 0x10144a54 */
        l_0x1014_4a52:
            ii(0x1014_4a52, 2); jmp(0x1014_4a80, 0x2c); goto l_0x1014_4a80; /* jmp 0x10144a80 */
        l_0x1014_4a54:
            ii(0x1014_4a54, 5); mov(ecx, 0x20);                         /* mov ecx, 0x20 */
            ii(0x1014_4a59, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_4a5e, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1014_4a63, 6); lea(eax, memd[ss, ebp - 0x162]);        /* lea eax, [ebp-0x162] */
            ii(0x1014_4a69, 5); call(0x1007_68e0, -0xc_e18e);           /* call 0x100768e0 */
            ii(0x1014_4a6e, 5); call(0x1014_37d1, -0x12a2);             /* call 0x101437d1 */
            ii(0x1014_4a73, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_4a75, 6); lea(eax, memd[ss, ebp - 0x1b0]);        /* lea eax, [ebp-0x1b0] */
            ii(0x1014_4a7b, 5); call(0x1014_4674, -0x40c);              /* call 0x10144674 */
        l_0x1014_4a80:
            ii(0x1014_4a80, 5); jmp(0x1014_4c9f, 0x21a); goto l_0x1014_4c9f; /* jmp 0x10144c9f */
        l_0x1014_4a85:
            ii(0x1014_4a85, 5); cmp(memw[ss, ebp - 0x5a], 0);           /* cmp word [ebp-0x5a], 0x0 */
            ii(0x1014_4a8a, 2); if(jz(0x1014_4ab6, 0x2a)) goto l_0x1014_4ab6; /* jz 0x10144ab6 */
            ii(0x1014_4a8c, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_4a91, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1014_4a96, 6); lea(eax, memd[ss, ebp - 0x162]);        /* lea eax, [ebp-0x162] */
            ii(0x1014_4a9c, 5); call(0x1007_68e0, -0xc_e1c1);           /* call 0x100768e0 */
            ii(0x1014_4aa1, 5); call(0x1014_3b69, -0xf3d);              /* call 0x10143b69 */
            ii(0x1014_4aa6, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1014_4aab, 6); lea(eax, memd[ss, ebp - 0x1b0]);        /* lea eax, [ebp-0x1b0] */
            ii(0x1014_4ab1, 5); call(0x1014_4674, -0x442);              /* call 0x10144674 */
        l_0x1014_4ab6:
            ii(0x1014_4ab6, 5); jmp(0x1014_4c9f, 0x1e4); goto l_0x1014_4c9f; /* jmp 0x10144c9f */
        l_0x1014_4abb:
            ii(0x1014_4abb, 6); lea(eax, memd[ss, ebp - 0x1b0]);        /* lea eax, [ebp-0x1b0] */
            ii(0x1014_4ac1, 5); call(0x1014_46da, -0x3ec);              /* call 0x101446da */
            ii(0x1014_4ac6, 5); jmp(0x1014_4c9f, 0x1d4); goto l_0x1014_4c9f; /* jmp 0x10144c9f */
        l_0x1014_4acb:
            ii(0x1014_4acb, 5); cmp(memw[ss, ebp - 0x54], 0);           /* cmp word [ebp-0x54], 0x0 */
            ii(0x1014_4ad0, 2); if(jz(0x1014_4adb, 0x9)) goto l_0x1014_4adb; /* jz 0x10144adb */
            ii(0x1014_4ad2, 3); mov(eax, memd[ss, ebp - 0x5e]);         /* mov eax, [ebp-0x5e] */
            ii(0x1014_4ad5, 4); cmp(ax, memw[ss, ebp - 0x52]);          /* cmp ax, [ebp-0x52] */
            ii(0x1014_4ad9, 2); if(jl(0x1014_4add, 0x2)) goto l_0x1014_4add; /* jl 0x10144add */
        l_0x1014_4adb:
            ii(0x1014_4adb, 2); jmp(0x1014_4b09, 0x2c); goto l_0x1014_4b09; /* jmp 0x10144b09 */
        l_0x1014_4add:
            ii(0x1014_4add, 5); mov(ecx, 0x40);                         /* mov ecx, 0x40 */
            ii(0x1014_4ae2, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_4ae7, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x1014_4aec, 6); lea(eax, memd[ss, ebp - 0x162]);        /* lea eax, [ebp-0x162] */
            ii(0x1014_4af2, 5); call(0x1007_68e0, -0xc_e217);           /* call 0x100768e0 */
            ii(0x1014_4af7, 5); call(0x1014_37d1, -0x132b);             /* call 0x101437d1 */
            ii(0x1014_4afc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_4afe, 6); lea(eax, memd[ss, ebp - 0x1b0]);        /* lea eax, [ebp-0x1b0] */
            ii(0x1014_4b04, 5); call(0x1014_47a0, -0x369);              /* call 0x101447a0 */
        l_0x1014_4b09:
            ii(0x1014_4b09, 5); jmp(0x1014_4c9f, 0x191); goto l_0x1014_4c9f; /* jmp 0x10144c9f */
        l_0x1014_4b0e:
            ii(0x1014_4b0e, 5); cmp(memw[ss, ebp - 0x5e], 0);           /* cmp word [ebp-0x5e], 0x0 */
            ii(0x1014_4b13, 2); if(jz(0x1014_4b3f, 0x2a)) goto l_0x1014_4b3f; /* jz 0x10144b3f */
            ii(0x1014_4b15, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_4b1a, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x1014_4b1f, 6); lea(eax, memd[ss, ebp - 0x162]);        /* lea eax, [ebp-0x162] */
            ii(0x1014_4b25, 5); call(0x1007_68e0, -0xc_e24a);           /* call 0x100768e0 */
            ii(0x1014_4b2a, 5); call(0x1014_3b69, -0xfc6);              /* call 0x10143b69 */
            ii(0x1014_4b2f, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1014_4b34, 6); lea(eax, memd[ss, ebp - 0x1b0]);        /* lea eax, [ebp-0x1b0] */
            ii(0x1014_4b3a, 5); call(0x1014_47a0, -0x39f);              /* call 0x101447a0 */
        l_0x1014_4b3f:
            ii(0x1014_4b3f, 5); jmp(0x1014_4c9f, 0x15b); goto l_0x1014_4c9f; /* jmp 0x10144c9f */
        l_0x1014_4b44:
            ii(0x1014_4b44, 6); lea(eax, memd[ss, ebp - 0x1b0]);        /* lea eax, [ebp-0x1b0] */
            ii(0x1014_4b4a, 5); call(0x1014_4806, -0x349);              /* call 0x10144806 */
            ii(0x1014_4b4f, 5); jmp(0x1014_4c9f, 0x14b); goto l_0x1014_4c9f; /* jmp 0x10144c9f */
        l_0x1014_4b54:
            ii(0x1014_4b54, 10); cmp(memd[ss, ebp - 0x1b4], 0x7000);    /* cmp dword [ebp-0x1b4], 0x7000 */
            ii(0x1014_4b5e, 2); if(jl(0x1014_4b89, 0x29)) goto l_0x1014_4b89; /* jl 0x10144b89 */
            ii(0x1014_4b60, 10); add(memd[ss, ebp - 0x1b4], 0xffff_9000); /* add dword [ebp-0x1b4], 0xffff9000 */
            ii(0x1014_4b6a, 4); cmp(memb[ss, ebp - 0x8], 0);            /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1014_4b6e, 2); if(jnz(0x1014_4b85, 0x15)) goto l_0x1014_4b85; /* jnz 0x10144b85 */
            ii(0x1014_4b70, 6); mov(eax, memd[ss, ebp - 0x1b4]);        /* mov eax, [ebp-0x1b4] */
            ii(0x1014_4b76, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1014_4b79, 7); mov(eax, memd[ds, eax + ebp - 0x18e]);  /* mov eax, [eax+ebp-0x18e] */
            ii(0x1014_4b80, 5); call(0x100c_fbbe, -0x7_4fc7);           /* call 0x100cfbbe */
        l_0x1014_4b85:
            ii(0x1014_4b85, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
        l_0x1014_4b89:
            ii(0x1014_4b89, 5); jmp(0x1014_4c9f, 0x111); goto l_0x1014_4c9f; /* jmp 0x10144c9f */
        l_0x1014_4b8e:
            ii(0x1014_4b8e, 10); cmp(memd[ss, ebp - 0x1b8], 0x3ea);     /* cmp dword [ebp-0x1b8], 0x3ea */
            ii(0x1014_4b98, 6); if(jb(0x1014_4c26, 0x88)) goto l_0x1014_4c26; /* jb 0x10144c26 */
            ii(0x1014_4b9e, 10); cmp(memd[ss, ebp - 0x1b8], 0x3ea);     /* cmp dword [ebp-0x1b8], 0x3ea */
            ii(0x1014_4ba8, 6); if(jbe(0x1014_49fc, -0x1b2)) goto l_0x1014_49fc; /* jbe 0x101449fc */
            ii(0x1014_4bae, 10); cmp(memd[ss, ebp - 0x1b8], 0x3ee);     /* cmp dword [ebp-0x1b8], 0x3ee */
            ii(0x1014_4bb8, 2); if(jb(0x1014_4c00, 0x46)) goto l_0x1014_4c00; /* jb 0x10144c00 */
            ii(0x1014_4bba, 10); cmp(memd[ss, ebp - 0x1b8], 0x3ee);     /* cmp dword [ebp-0x1b8], 0x3ee */
            ii(0x1014_4bc4, 6); if(jbe(0x1014_4abb, -0x10f)) goto l_0x1014_4abb; /* jbe 0x10144abb */
            ii(0x1014_4bca, 10); cmp(memd[ss, ebp - 0x1b8], 0x3f0);     /* cmp dword [ebp-0x1b8], 0x3f0 */
            ii(0x1014_4bd4, 2); if(jb(0x1014_4bfb, 0x25)) goto l_0x1014_4bfb; /* jb 0x10144bfb */
            ii(0x1014_4bd6, 10); cmp(memd[ss, ebp - 0x1b8], 0x3f0);     /* cmp dword [ebp-0x1b8], 0x3f0 */
            ii(0x1014_4be0, 6); if(jbe(0x1014_4b0e, -0xd8)) goto l_0x1014_4b0e; /* jbe 0x10144b0e */
            ii(0x1014_4be6, 10); cmp(memd[ss, ebp - 0x1b8], 0x3f1);     /* cmp dword [ebp-0x1b8], 0x3f1 */
            ii(0x1014_4bf0, 6); if(jz(0x1014_4b44, -0xb2)) goto l_0x1014_4b44; /* jz 0x10144b44 */
            ii(0x1014_4bf6, 5); jmp(0x1014_4b54, -0xa7); goto l_0x1014_4b54; /* jmp 0x10144b54 */
        l_0x1014_4bfb:
            ii(0x1014_4bfb, 5); jmp(0x1014_4acb, -0x135); goto l_0x1014_4acb; /* jmp 0x10144acb */
        l_0x1014_4c00:
            ii(0x1014_4c00, 10); cmp(memd[ss, ebp - 0x1b8], 0x3ec);     /* cmp dword [ebp-0x1b8], 0x3ec */
            ii(0x1014_4c0a, 2); if(jb(0x1014_4c21, 0x15)) goto l_0x1014_4c21; /* jb 0x10144c21 */
            ii(0x1014_4c0c, 10); cmp(memd[ss, ebp - 0x1b8], 0x3ec);     /* cmp dword [ebp-0x1b8], 0x3ec */
            ii(0x1014_4c16, 6); if(jbe(0x1014_4a42, -0x1da)) goto l_0x1014_4a42; /* jbe 0x10144a42 */
            ii(0x1014_4c1c, 5); jmp(0x1014_4a85, -0x19c); goto l_0x1014_4a85; /* jmp 0x10144a85 */
        l_0x1014_4c21:
            ii(0x1014_4c21, 5); jmp(0x1014_4a32, -0x1f4); goto l_0x1014_4a32; /* jmp 0x10144a32 */
        l_0x1014_4c26:
            ii(0x1014_4c26, 7); cmp(memd[ss, ebp - 0x1b8], 0x3f);       /* cmp dword [ebp-0x1b8], 0x3f */
            ii(0x1014_4c2d, 2); if(jb(0x1014_4c72, 0x43)) goto l_0x1014_4c72; /* jb 0x10144c72 */
            ii(0x1014_4c2f, 7); cmp(memd[ss, ebp - 0x1b8], 0x3f);       /* cmp dword [ebp-0x1b8], 0x3f */
            ii(0x1014_4c36, 6); if(jbe(0x1014_4993, -0x2a9)) goto l_0x1014_4993; /* jbe 0x10144993 */
            ii(0x1014_4c3c, 10); cmp(memd[ss, ebp - 0x1b8], 0x3e8);     /* cmp dword [ebp-0x1b8], 0x3e8 */
            ii(0x1014_4c46, 2); if(jb(0x1014_4c5d, 0x15)) goto l_0x1014_4c5d; /* jb 0x10144c5d */
            ii(0x1014_4c48, 10); cmp(memd[ss, ebp - 0x1b8], 0x3e8);     /* cmp dword [ebp-0x1b8], 0x3e8 */
            ii(0x1014_4c52, 6); if(jbe(0x1014_4993, -0x2c5)) goto l_0x1014_4993; /* jbe 0x10144993 */
            ii(0x1014_4c58, 5); jmp(0x1014_49b9, -0x2a4); goto l_0x1014_49b9; /* jmp 0x101449b9 */
        l_0x1014_4c5d:
            ii(0x1014_4c5d, 10); cmp(memd[ss, ebp - 0x1b8], 0x119);     /* cmp dword [ebp-0x1b8], 0x119 */
            ii(0x1014_4c67, 6); if(jz(0x1014_4989, -0x2e4)) goto l_0x1014_4989; /* jz 0x10144989 */
            ii(0x1014_4c6d, 5); jmp(0x1014_4b54, -0x11e); goto l_0x1014_4b54; /* jmp 0x10144b54 */
        l_0x1014_4c72:
            ii(0x1014_4c72, 7); cmp(memd[ss, ebp - 0x1b8], 0xd);        /* cmp dword [ebp-0x1b8], 0xd */
            ii(0x1014_4c79, 2); if(jb(0x1014_4c9a, 0x1f)) goto l_0x1014_4c9a; /* jb 0x10144c9a */
            ii(0x1014_4c7b, 7); cmp(memd[ss, ebp - 0x1b8], 0xd);        /* cmp dword [ebp-0x1b8], 0xd */
            ii(0x1014_4c82, 6); if(jbe(0x1014_49ad, -0x2db)) goto l_0x1014_49ad; /* jbe 0x101449ad */
            ii(0x1014_4c88, 7); cmp(memd[ss, ebp - 0x1b8], 0x1b);       /* cmp dword [ebp-0x1b8], 0x1b */
            ii(0x1014_4c8f, 6); if(jz(0x1014_49ad, -0x2e8)) goto l_0x1014_49ad; /* jz 0x101449ad */
            ii(0x1014_4c95, 5); jmp(0x1014_4b54, -0x146); goto l_0x1014_4b54; /* jmp 0x10144b54 */
        l_0x1014_4c9a:
            ii(0x1014_4c9a, 5); jmp(0x1014_4b54, -0x14b); goto l_0x1014_4b54; /* jmp 0x10144b54 */
        l_0x1014_4c9f:
            ii(0x1014_4c9f, 5); call(0x100d_5094, -0x6_fc10);           /* call 0x100d5094 */
            ii(0x1014_4ca4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_4ca6, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1014_4ca8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_4caa, 5); call(0x1010_0e32, -0x4_3e7d);           /* call 0x10100e32 */
            ii(0x1014_4caf, 5); jmp(0x1014_492c, -0x388); goto l_0x1014_492c; /* jmp 0x1014492c */
        l_0x1014_4cb4:
            ii(0x1014_4cb4, 6); lea(eax, memd[ss, ebp - 0x1b0]);        /* lea eax, [ebp-0x1b0] */
            ii(0x1014_4cba, 5); call(0x1014_4465, -0x85a);              /* call 0x10144465 */
            ii(0x1014_4cbf, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1014_4cc6, 2); if(jz(0x1014_4ce0, 0x18)) goto l_0x1014_4ce0; /* jz 0x10144ce0 */
            ii(0x1014_4cc8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_4ccb, 5); call(0x1007_6204, -0xc_eacc);           /* call 0x10076204 */
            ii(0x1014_4cd0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_4cd2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_4cd5, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1014_4cd8, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_4cda, 1); cwde();                                 /* cwde */
            ii(0x1014_4cdb, 5); call(0x1012_8d78, -0x1_bf68);           /* call 0x10128d78 */
        l_0x1014_4ce0:
            ii(0x1014_4ce0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_4ce3, 5); call(0x100f_fa70, -0x4_5278);           /* call 0x100ffa70 */
            ii(0x1014_4ce8, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1014_4ced, 5); call(0x1010_0efe, -0x4_3df4);           /* call 0x10100efe */
            ii(0x1014_4cf2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_4cf4, 6); lea(eax, memd[ss, ebp - 0x1b0]);        /* lea eax, [ebp-0x1b0] */
            ii(0x1014_4cfa, 5); call(0x1014_4d64, 0x65);                /* call 0x10144d64 */
        l_0x1014_4cff:
            ii(0x1014_4cff, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_4d01, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_4d02, 1); pop(edi);                               /* pop edi */
            ii(0x1014_4d03, 1); pop(esi);                               /* pop esi */
            ii(0x1014_4d04, 1); pop(edx);                               /* pop edx */
            ii(0x1014_4d05, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_4d06, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_4d07, 1); ret();                                  /* ret */
        }
    }
}
