using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_4dd5-1b734df1")]
        public void Method_1008_4dd5()
        {
            ii(0x1008_4dd5, 5); push(0x58);                             /* push 0x58 */
            ii(0x1008_4dda, 5); call(Definitions.sys_check_available_stack_size, 0xe_0f73); /* call 0x10165d52 */
            ii(0x1008_4ddf, 1); push(ebx);                              /* push ebx */
            ii(0x1008_4de0, 1); push(ecx);                              /* push ecx */
            ii(0x1008_4de1, 1); push(edx);                              /* push edx */
            ii(0x1008_4de2, 1); push(esi);                              /* push esi */
            ii(0x1008_4de3, 1); push(edi);                              /* push edi */
            ii(0x1008_4de4, 1); push(ebp);                              /* push ebp */
            ii(0x1008_4de5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_4de7, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x1008_4ded, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_4df0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4df2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4df5, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4df8, 5); call(0x1013_ad71, 0xb_5f74);            /* call 0x1013ad71 */
            ii(0x1008_4dfd, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4dff, 2); if(jz(0x1008_4e1a, 0x19)) goto l_0x1008_4e1a; /* jz 0x10084e1a */
            ii(0x1008_4e01, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4e04, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4e07, 5); call(0x1007_65d0, -0xe83c);             /* call 0x100765d0 */
            ii(0x1008_4e0c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4e0e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4e11, 5); call(0x1008_4c7e, -0x198);              /* call 0x10084c7e */
            ii(0x1008_4e16, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4e18, 2); if(jnz(0x1008_4e1c, 0x2)) goto l_0x1008_4e1c; /* jnz 0x10084e1c */
        l_0x1008_4e1a:
            ii(0x1008_4e1a, 2); jmp(0x1008_4e2f, 0x13); goto l_0x1008_4e2f; /* jmp 0x10084e2f */
        l_0x1008_4e1c:
            ii(0x1008_4e1c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4e1f, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4e22, 5); call(0x1007_65d0, -0xe857);             /* call 0x100765d0 */
            ii(0x1008_4e27, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1008_4e2a, 5); jmp(0x1008_518d, 0x35e); goto l_0x1008_518d; /* jmp 0x1008518d */
        l_0x1008_4e2f:
            ii(0x1008_4e2f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4e32, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_4e35, 5); call(0x1008_9d08, 0x4ece);              /* call 0x10089d08 */
            ii(0x1008_4e3a, 3); lea(ebx, ebp - 0x28);                   /* lea ebx, [ebp-0x28] */
            ii(0x1008_4e3d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4e3f, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_4e41, 5); call(0x1008_9be4, 0x4d9e);              /* call 0x10089be4 */
            ii(0x1008_4e46, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_4e49, 5); call(Definitions.my_ctor_0x101b_4184, -0xe35e); /* call 0x10076af0 */
            ii(0x1008_4e4e, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_4e52, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_4e55, 3); add(edx, 0x32);                         /* add edx, 0x32 */
            ii(0x1008_4e58, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_4e5b, 5); call(0x1007_6668, -0xe7f8);             /* call 0x10076668 */
            ii(0x1008_4e60, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x1008_4e64, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_4e67, 5); call(0x1007_64fc, -0xe970);             /* call 0x100764fc */
            ii(0x1008_4e6c, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_4e6f, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1008_4e73, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4e76, 4); mov(memb[ds, eax + 0x46], 0);           /* mov byte [eax+0x46], 0x0 */
            ii(0x1008_4e7a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4e7c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4e7f, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_4e82, 5); call(0x1013_ad11, 0xb_5e8a);            /* call 0x1013ad11 */
            ii(0x1008_4e87, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4e89, 2); if(jnz(0x1008_4e9f, 0x14)) goto l_0x1008_4e9f; /* jnz 0x10084e9f */
            ii(0x1008_4e8b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4e8e, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_4e91, 5); call(0x1008_9d7c, 0x4ee6);              /* call 0x10089d7c */
            ii(0x1008_4e96, 5); call(0x1008_9f70, 0x50d5);              /* call 0x10089f70 */
            ii(0x1008_4e9b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_4e9d, 2); if(jnz(0x1008_4ead, 0xe)) goto l_0x1008_4ead; /* jnz 0x10084ead */
        l_0x1008_4e9f:
            ii(0x1008_4e9f, 6); mov(memw[ss, ebp - 0x24], 0);           /* mov word [ebp-0x24], 0x0 */
            ii(0x1008_4ea5, 6); mov(memw[ss, ebp - 0x22], 0);           /* mov word [ebp-0x22], 0x0 */
            ii(0x1008_4eab, 2); jmp(0x1008_4eeb, 0x3e); goto l_0x1008_4eeb; /* jmp 0x10084eeb */
        l_0x1008_4ead:
            ii(0x1008_4ead, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x1008_4eb0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4eb3, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_4eb6, 5); call(0x1008_9d7c, 0x4ec1);              /* call 0x10089d7c */
            ii(0x1008_4ebb, 5); call(0x100a_2d3d, 0x1_de7d);            /* call 0x100a2d3d */
            ii(0x1008_4ec0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4ec2, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_4ec5, 5); call(0x1008_8b44, 0x3c7a);              /* call 0x10088b44 */
            ii(0x1008_4eca, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4ecd, 3); mov(edx, memd[ds, eax + 0x7]);          /* mov edx, [eax+0x7] */
            ii(0x1008_4ed0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_4ed3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4ed6, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_4ed9, 5); call(0x1008_9d7c, 0x4e9e);              /* call 0x10089d7c */
            ii(0x1008_4ede, 5); call(0x1008_9f70, 0x508d);              /* call 0x10089f70 */
            ii(0x1008_4ee3, 5); call(0x1007_6074, -0xee74);             /* call 0x10076074 */
            ii(0x1008_4ee8, 3); mov(memb[ss, ebp - 0x8], al);           /* mov [ebp-0x8], al */
        l_0x1008_4eeb:
            ii(0x1008_4eeb, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_4eee, 3); add(edx, 0x3e);                         /* add edx, 0x3e */
            ii(0x1008_4ef1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4ef4, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4ef7, 5); call(0x1008_ac18, 0x5d1c);              /* call 0x1008ac18 */
            ii(0x1008_4efc, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_4eff, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4f02, 3); add(eax, 0x36);                         /* add eax, 0x36 */
            ii(0x1008_4f05, 5); call(0x1008_afe4, 0x60da);              /* call 0x1008afe4 */
            ii(0x1008_4f0a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4f0c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4f0f, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_4f12, 5); call(0x1013_ad71, 0xb_5e5a);            /* call 0x1013ad71 */
            ii(0x1008_4f17, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4f19, 2); if(jz(0x1008_4f3d, 0x22)) goto l_0x1008_4f3d; /* jz 0x10084f3d */
            ii(0x1008_4f1b, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1008_4f1e, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1008_4f21, 5); call(0x1007_5e64, -0xf0c2);             /* call 0x10075e64 */
            ii(0x1008_4f26, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4f28, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4f2b, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_4f2e, 5); call(0x1007_65d0, -0xe963);             /* call 0x100765d0 */
            ii(0x1008_4f33, 5); call(0x1007_0ca1, -0x1_4297);           /* call 0x10070ca1 */
            ii(0x1008_4f38, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1008_4f3a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1008_4f3d:
            ii(0x1008_4f3d, 2); jmp(0x1008_4f47, 0x8); goto l_0x1008_4f47; /* jmp 0x10084f47 */
        l_0x1008_4f3f:
            ii(0x1008_4f3f, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1008_4f42, 5); call(0x1007_6bf8, -0xe34f);             /* call 0x10076bf8 */
        l_0x1008_4f47:
            ii(0x1008_4f47, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4f49, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1008_4f4c, 5); call(0x1013_ad71, 0xb_5e20);            /* call 0x1013ad71 */
            ii(0x1008_4f51, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4f53, 6); if(jz(0x1008_5015, 0xbc)) goto l_0x1008_5015; /* jz 0x10085015 */
            ii(0x1008_4f59, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1008_4f5c, 5); call(0x1008_9acc, 0x4b6b);              /* call 0x10089acc */
            ii(0x1008_4f61, 5); call(0x1008_9fc4, 0x505e);              /* call 0x10089fc4 */
            ii(0x1008_4f66, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4f68, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_4f6b, 5); call(0x1007_643c, -0xeb34);             /* call 0x1007643c */
            ii(0x1008_4f70, 2); jmp(0x1008_4f7a, 0x8); goto l_0x1008_4f7a; /* jmp 0x10084f7a */
        l_0x1008_4f72:
            ii(0x1008_4f72, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_4f75, 5); call(0x1007_6bf8, -0xe382);             /* call 0x10076bf8 */
        l_0x1008_4f7a:
            ii(0x1008_4f7a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4f7c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_4f7f, 5); call(0x1013_ad71, 0xb_5ded);            /* call 0x1013ad71 */
            ii(0x1008_4f84, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4f86, 6); if(jz(0x1008_5010, 0x84)) goto l_0x1008_5010; /* jz 0x10085010 */
            ii(0x1008_4f8c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_4f8f, 5); call(0x1007_63d4, -0xebc0);             /* call 0x100763d4 */
            ii(0x1008_4f94, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4f96, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4f99, 5); call(0x1008_4c7e, -0x320);              /* call 0x10084c7e */
            ii(0x1008_4f9e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4fa0, 2); if(jz(0x1008_500b, 0x69)) goto l_0x1008_500b; /* jz 0x1008500b */
            ii(0x1008_4fa2, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1008_4fa5, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1008_4fa8, 5); call(0x1007_5e64, -0xf149);             /* call 0x10075e64 */
            ii(0x1008_4fad, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4faf, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_4fb2, 5); call(0x1007_63d4, -0xebe3);             /* call 0x100763d4 */
            ii(0x1008_4fb7, 5); call(0x1007_0ca1, -0x1_431b);           /* call 0x10070ca1 */
            ii(0x1008_4fbc, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_4fbf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4fc1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4fc4, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_4fc7, 5); call(0x1013_ad11, 0xb_5d45);            /* call 0x1013ad11 */
            ii(0x1008_4fcc, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4fce, 2); if(jnz(0x1008_4fd9, 0x9)) goto l_0x1008_4fd9; /* jnz 0x10084fd9 */
            ii(0x1008_4fd0, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_4fd3, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1008_4fd7, 2); if(jle(0x1008_500b, 0x32)) goto l_0x1008_500b; /* jle 0x1008500b */
        l_0x1008_4fd9:
            ii(0x1008_4fd9, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_4fdc, 5); call(0x1007_63d4, -0xec0d);             /* call 0x100763d4 */
            ii(0x1008_4fe1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4fe3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_4fe6, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_4fe9, 5); call(0x1007_6630, -0xe9be);             /* call 0x10076630 */
            ii(0x1008_4fee, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1008_4ff1, 5); call(0x1008_9b34, 0x4b3e);              /* call 0x10089b34 */
            ii(0x1008_4ff6, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1008_4ff9, 3); add(ebx, 0x36);                         /* add ebx, 0x36 */
            ii(0x1008_4ffc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_4ffe, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_5000, 5); call(0x1008_afe4, 0x5fdf);              /* call 0x1008afe4 */
            ii(0x1008_5005, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_5008, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1008_500b:
            ii(0x1008_500b, 5); jmp(0x1008_4f72, -0x9e); goto l_0x1008_4f72; /* jmp 0x10084f72 */
        l_0x1008_5010:
            ii(0x1008_5010, 5); jmp(0x1008_4f3f, -0xd6); goto l_0x1008_4f3f; /* jmp 0x10084f3f */
        l_0x1008_5015:
            ii(0x1008_5015, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5017, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_501a, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_501d, 5); call(0x1013_ad11, 0xb_5cef);            /* call 0x1013ad11 */
            ii(0x1008_5022, 2); test(al, al);                           /* test al, al */
            ii(0x1008_5024, 6); if(jz(0x1008_50ff, 0xd5)) goto l_0x1008_50ff; /* jz 0x100850ff */
            ii(0x1008_502a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_502d, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_5030, 5); call(0x1008_9d08, 0x4cd3);              /* call 0x10089d08 */
            ii(0x1008_5035, 3); lea(ebx, ebp - 0x28);                   /* lea ebx, [ebp-0x28] */
            ii(0x1008_5038, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_503a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_503c, 5); call(0x1008_9b68, 0x4b27);              /* call 0x10089b68 */
            ii(0x1008_5041, 2); jmp(0x1008_504b, 0x8); goto l_0x1008_504b; /* jmp 0x1008504b */
        l_0x1008_5043:
            ii(0x1008_5043, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1008_5046, 5); call(0x1007_6bf8, -0xe453);             /* call 0x10076bf8 */
        l_0x1008_504b:
            ii(0x1008_504b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_504d, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1008_5050, 5); call(0x1013_ad71, 0xb_5d1c);            /* call 0x1013ad71 */
            ii(0x1008_5055, 2); test(al, al);                           /* test al, al */
            ii(0x1008_5057, 6); if(jz(0x1008_50ff, 0xa2)) goto l_0x1008_50ff; /* jz 0x100850ff */
            ii(0x1008_505d, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1008_5060, 5); call(0x1008_9acc, 0x4a67);              /* call 0x10089acc */
            ii(0x1008_5065, 5); call(0x1008_9fc4, 0x4f5a);              /* call 0x10089fc4 */
            ii(0x1008_506a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_506c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_506f, 5); call(0x1007_643c, -0xec38);             /* call 0x1007643c */
            ii(0x1008_5074, 2); jmp(0x1008_507e, 0x8); goto l_0x1008_507e; /* jmp 0x1008507e */
        l_0x1008_5076:
            ii(0x1008_5076, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_5079, 5); call(0x1007_6bf8, -0xe486);             /* call 0x10076bf8 */
        l_0x1008_507e:
            ii(0x1008_507e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5080, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_5083, 5); call(0x1013_ad71, 0xb_5ce9);            /* call 0x1013ad71 */
            ii(0x1008_5088, 2); test(al, al);                           /* test al, al */
            ii(0x1008_508a, 2); if(jz(0x1008_50fa, 0x6e)) goto l_0x1008_50fa; /* jz 0x100850fa */
            ii(0x1008_508c, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1008_508f, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_5092, 5); call(0x1007_5e64, -0xf233);             /* call 0x10075e64 */
            ii(0x1008_5097, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_5099, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_509c, 5); call(0x1007_63d4, -0xeccd);             /* call 0x100763d4 */
            ii(0x1008_50a1, 5); call(0x1007_0ca1, -0x1_4405);           /* call 0x10070ca1 */
            ii(0x1008_50a6, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_50a9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_50ab, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_50ae, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_50b1, 5); call(0x1013_ad11, 0xb_5c5b);            /* call 0x1013ad11 */
            ii(0x1008_50b6, 2); test(al, al);                           /* test al, al */
            ii(0x1008_50b8, 2); if(jnz(0x1008_50c3, 0x9)) goto l_0x1008_50c3; /* jnz 0x100850c3 */
            ii(0x1008_50ba, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_50bd, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1008_50c1, 2); if(jle(0x1008_50f5, 0x32)) goto l_0x1008_50f5; /* jle 0x100850f5 */
        l_0x1008_50c3:
            ii(0x1008_50c3, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_50c6, 5); call(0x1007_63d4, -0xecf7);             /* call 0x100763d4 */
            ii(0x1008_50cb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_50cd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_50d0, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_50d3, 5); call(0x1007_6630, -0xeaa8);             /* call 0x10076630 */
            ii(0x1008_50d8, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1008_50db, 5); call(0x1008_9b34, 0x4a54);              /* call 0x10089b34 */
            ii(0x1008_50e0, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1008_50e3, 3); add(ebx, 0x36);                         /* add ebx, 0x36 */
            ii(0x1008_50e6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_50e8, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_50ea, 5); call(0x1008_afe4, 0x5ef5);              /* call 0x1008afe4 */
            ii(0x1008_50ef, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_50f2, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1008_50f5:
            ii(0x1008_50f5, 5); jmp(0x1008_5076, -0x84); goto l_0x1008_5076; /* jmp 0x10085076 */
        l_0x1008_50fa:
            ii(0x1008_50fa, 5); jmp(0x1008_5043, -0xbc); goto l_0x1008_5043; /* jmp 0x10085043 */
        l_0x1008_50ff:
            ii(0x1008_50ff, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5101, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_5104, 5); call(0x1013_ad71, 0xb_5c68);            /* call 0x1013ad71 */
            ii(0x1008_5109, 2); test(al, al);                           /* test al, al */
            ii(0x1008_510b, 2); if(jz(0x1008_511d, 0x10)) goto l_0x1008_511d; /* jz 0x1008511d */
            ii(0x1008_510d, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_5110, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_5113, 5); call(0x1007_6574, -0xeba4);             /* call 0x10076574 */
            ii(0x1008_5118, 5); call(0x1015_27b8, 0xc_d69b);            /* call 0x101527b8 */
        l_0x1008_511d:
            ii(0x1008_511d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_511f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5122, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_5125, 5); call(0x1013_ad71, 0xb_5c47);            /* call 0x1013ad71 */
            ii(0x1008_512a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_512c, 2); if(jz(0x1008_5141, 0x13)) goto l_0x1008_5141; /* jz 0x10085141 */
            ii(0x1008_512e, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_5131, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5134, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_5137, 5); call(0x1007_6574, -0xebc8);             /* call 0x10076574 */
            ii(0x1008_513c, 5); call(0x1015_2783, 0xc_d642);            /* call 0x10152783 */
        l_0x1008_5141:
            ii(0x1008_5141, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5144, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_5147, 5); call(0x1007_65d0, -0xeb7c);             /* call 0x100765d0 */
            ii(0x1008_514c, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1008_514f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5151, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_5154, 5); call(0x1007_5f6c, -0xf1ed);             /* call 0x10075f6c */
            ii(0x1008_5159, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_515b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_515e, 5); call(0x1007_5f2c, -0xf237);             /* call 0x10075f2c */
            ii(0x1008_5163, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5165, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1008_5168, 5); call(0x1008_9044, 0x3ed7);              /* call 0x10089044 */
            ii(0x1008_516d, 2); jmp(0x1008_518d, 0x1e); goto l_0x1008_518d; /* jmp 0x1008518d */
        //  ii(0x1008_516f, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_5171, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
        //  ii(0x1008_5174, 5); call(0x1007_5f6c, -0xf20d);             /* call 0x10075f6c */
        //  ii(0x1008_5179, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_517b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
        //  ii(0x1008_517e, 5); call(0x1007_5f2c, -0xf257);             /* call 0x10075f2c */
        //  ii(0x1008_5183, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_5185, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
        //  ii(0x1008_5188, 5); call(0x1008_9044, 0x3eb7);              /* call 0x10089044 */
        l_0x1008_518d:
            ii(0x1008_518d, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1008_5190, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_5192, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_5193, 1); pop(edi);                               /* pop edi */
            ii(0x1008_5194, 1); pop(esi);                               /* pop esi */
            ii(0x1008_5195, 1); pop(edx);                               /* pop edx */
            ii(0x1008_5196, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_5197, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_5198, 1); ret();                                  /* ret */
        }
    }
}
