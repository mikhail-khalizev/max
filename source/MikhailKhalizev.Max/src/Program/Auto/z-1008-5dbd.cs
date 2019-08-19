using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_5dbd-c70c05e4")]
        public void Method_1008_5dbd()
        {
            ii(0x1008_5dbd, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x1008_5dc2, 5); calld(Definitions.sys_check_available_stack_size, 0xd_ff8b); /* call 0x10165d52 */
            ii(0x1008_5dc7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_5dc8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_5dc9, 1); pushd(edx);                             /* push edx */
            ii(0x1008_5dca, 1); pushd(esi);                             /* push esi */
            ii(0x1008_5dcb, 1); pushd(edi);                             /* push edi */
            ii(0x1008_5dcc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_5dcd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_5dcf, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1008_5dd5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_5dd8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_5ddb, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_5dde, 5); calld(0x1008_9d08, 0x3f25);             /* call 0x10089d08 */
            ii(0x1008_5de3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_5de5, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_5de8, 5); calld(0x1008_9be4, 0x3df7);             /* call 0x10089be4 */
            ii(0x1008_5ded, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1008_5df1, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_5df4, 5); calld(0x1007_64fc, -0xf8fd);            /* call 0x100764fc */
            ii(0x1008_5df9, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_5dfc, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1008_5e00, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1008_5e04, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_5e07, 5); calld(0x1008_9c28, 0x3e1c);             /* call 0x10089c28 */
            ii(0x1008_5e0c, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_5e0f, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1008_5e13, 2); jmpd(0x1008_5e1d, 0x8); goto l_0x1008_5e1d; /* jmp 0x10085e1d */
        l_0x1008_5e15:
            ii(0x1008_5e15, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_5e18, 5); calld(0x1007_6bf8, -0xf225);            /* call 0x10076bf8 */
        l_0x1008_5e1d:
            ii(0x1008_5e1d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5e1f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_5e22, 5); calld(0x1013_ad71, 0xb_4f4a);           /* call 0x1013ad71 */
            ii(0x1008_5e27, 2); test(al, al);                           /* test al, al */
            ii(0x1008_5e29, 6); if(jzd(0x1008_5eff, 0xd0)) goto l_0x1008_5eff; /* jz 0x10085eff */
            ii(0x1008_5e2f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_5e32, 5); calld(0x1008_9acc, 0x3c95);             /* call 0x10089acc */
            ii(0x1008_5e37, 5); calld(0x1008_9fc4, 0x4188);             /* call 0x10089fc4 */
            ii(0x1008_5e3c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_5e3e, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_5e41, 5); calld(0x1007_643c, -0xfa0a);            /* call 0x1007643c */
            ii(0x1008_5e46, 2); jmpd(0x1008_5e50, 0x8); goto l_0x1008_5e50; /* jmp 0x10085e50 */
        l_0x1008_5e48:
            ii(0x1008_5e48, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_5e4b, 5); calld(0x1007_6bf8, -0xf258);            /* call 0x10076bf8 */
        l_0x1008_5e50:
            ii(0x1008_5e50, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5e52, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_5e55, 5); calld(0x1013_ad71, 0xb_4f17);           /* call 0x1013ad71 */
            ii(0x1008_5e5a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_5e5c, 6); if(jzd(0x1008_5efa, 0x98)) goto l_0x1008_5efa; /* jz 0x10085efa */
            ii(0x1008_5e62, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_5e65, 5); calld(0x1007_63a0, -0xfaca);            /* call 0x100763a0 */
            ii(0x1008_5e6a, 5); calld(0x1007_623c, -0xfc33);            /* call 0x1007623c */
            ii(0x1008_5e6f, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x1008_5e73, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_5e76, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_5e79, 4); imul(eax, memd_a32[ss, ebp - 0x10]);    /* imul eax, [ebp-0x10] */
            ii(0x1008_5e7d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_5e80, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_5e83, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_5e86, 5); calld(0x1008_9d08, 0x3e7d);             /* call 0x10089d08 */
            ii(0x1008_5e8b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_5e8d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_5e90, 5); calld(0x1008_9b68, 0x3cd3);             /* call 0x10089b68 */
            ii(0x1008_5e95, 2); jmpd(0x1008_5e9f, 0x8); goto l_0x1008_5e9f; /* jmp 0x10085e9f */
        l_0x1008_5e97:
            ii(0x1008_5e97, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_5e9a, 5); calld(0x1007_6bf8, -0xf2a7);            /* call 0x10076bf8 */
        l_0x1008_5e9f:
            ii(0x1008_5e9f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5ea1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_5ea4, 5); calld(0x1013_ad71, 0xb_4ec8);           /* call 0x1013ad71 */
            ii(0x1008_5ea9, 2); test(al, al);                           /* test al, al */
            ii(0x1008_5eab, 2); if(jzd(0x1008_5ef5, 0x48)) goto l_0x1008_5ef5; /* jz 0x10085ef5 */
            ii(0x1008_5ead, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_5eb0, 5); calld(0x1008_9acc, 0x3c17);             /* call 0x10089acc */
            ii(0x1008_5eb5, 5); calld(0x1008_9f70, 0x40b6);             /* call 0x10089f70 */
            ii(0x1008_5eba, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_5ebc, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_5ebf, 5); calld(0x1007_63d4, -0xfaf0);            /* call 0x100763d4 */
            ii(0x1008_5ec4, 5); calld(0x1007_0d01, -0x1_51c8);          /* call 0x10070d01 */
            ii(0x1008_5ec9, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x1008_5ecd, 2); if(jgd(0x1008_5ef3, 0x24)) goto l_0x1008_5ef3; /* jg 0x10085ef3 */
            ii(0x1008_5ecf, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_5ed3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5ed5, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_5ed8, 5); calld(0x1008_9044, 0x3167);             /* call 0x10089044 */
            ii(0x1008_5edd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5edf, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_5ee2, 5); calld(0x1007_5f6c, -0xff7b);            /* call 0x10075f6c */
            ii(0x1008_5ee7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5ee9, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_5eec, 5); calld(0x1008_9044, 0x3153);             /* call 0x10089044 */
            ii(0x1008_5ef1, 2); jmpd(0x1008_5f41, 0x4e); goto l_0x1008_5f41; /* jmp 0x10085f41 */
        l_0x1008_5ef3:
            ii(0x1008_5ef3, 2); jmpd(0x1008_5e97, -0x5e); goto l_0x1008_5e97; /* jmp 0x10085e97 */
        l_0x1008_5ef5:
            ii(0x1008_5ef5, 5); jmpd(0x1008_5e48, -0xb2); goto l_0x1008_5e48; /* jmp 0x10085e48 */
        l_0x1008_5efa:
            ii(0x1008_5efa, 5); jmpd(0x1008_5e15, -0xea); goto l_0x1008_5e15; /* jmp 0x10085e15 */
        l_0x1008_5eff:
            ii(0x1008_5eff, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_5f03, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5f05, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_5f08, 5); calld(0x1008_9044, 0x3137);             /* call 0x10089044 */
            ii(0x1008_5f0d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5f0f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_5f12, 5); calld(0x1007_5f6c, -0xffab);            /* call 0x10075f6c */
            ii(0x1008_5f17, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5f19, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_5f1c, 5); calld(0x1008_9044, 0x3123);             /* call 0x10089044 */
            ii(0x1008_5f21, 2); jmpd(0x1008_5f41, 0x1e); goto l_0x1008_5f41; /* jmp 0x10085f41 */
        //  ii(0x1008_5f23, 30); Недостижимый код.
        l_0x1008_5f41:
            ii(0x1008_5f41, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_5f44, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_5f46, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_5f47, 1); popd(edi);                              /* pop edi */
            ii(0x1008_5f48, 1); popd(esi);                              /* pop esi */
            ii(0x1008_5f49, 1); popd(edx);                              /* pop edx */
            ii(0x1008_5f4a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_5f4b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_5f4c, 1); retd(); return;                         /* ret */
        }
    }
}
