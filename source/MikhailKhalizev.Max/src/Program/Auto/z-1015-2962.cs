using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ce7f0d9c-854b-491f-bd80-825167ba8afe")]
        public void Method_1015_2962()
        {
            ii(0x1015_2962, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1015_2967, 5); calld(Definitions.sys_check_available_stack_size, 0x1_33e6); /* call 0x10165d52 */
            ii(0x1015_296c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_296d, 1); pushd(esi);                             /* push esi */
            ii(0x1015_296e, 1); pushd(edi);                             /* push edi */
            ii(0x1015_296f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_2970, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_2972, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1015_2978, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_297b, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1015_297e, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1015_2981, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_2984, 5); calld(0x1015_26ac, -0x2dd);             /* call 0x101526ac */
            ii(0x1015_2989, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x1015_298c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_298e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_2990, 5); calld(0x1008_b060, -0xc_7935);          /* call 0x1008b060 */
            ii(0x1015_2995, 4); or(memb_a32[ss, ebp - 0x14], 0x1);      /* or byte [ebp-0x14], 0x1 */
            ii(0x1015_2999, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_299c, 5); calld(Definitions.my_ctor_0x101b_3b58, -0xc_78fd); /* call 0x1008b0a4 */
            ii(0x1015_29a1, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_29a4, 4); and(memb_a32[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x1015_29a8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_29aa, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_29ad, 5); calld(0x1013_ad11, -0x1_7ca1);          /* call 0x1013ad11 */
            ii(0x1015_29b2, 2); test(al, al);                           /* test al, al */
            ii(0x1015_29b4, 2); if(jzd(0x1015_29cf, 0x19)) goto l_0x1015_29cf; /* jz 0x101529cf */
            ii(0x1015_29b6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_29b8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_29bb, 5); calld(0x1008_8b7c, -0xc_9e44);          /* call 0x10088b7c */
            ii(0x1015_29c0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_29c2, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_29c5, 5); calld(0x1008_8b7c, -0xc_9e4e);          /* call 0x10088b7c */
            ii(0x1015_29ca, 5); jmpd(0x1015_2a4b, 0x7c); goto l_0x1015_2a4b; /* jmp 0x10152a4b */
        l_0x1015_29cf:
            ii(0x1015_29cf, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1015_29d2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_29d5, 5); add(eax, 0x8a);                         /* add eax, 0x8a */
            ii(0x1015_29da, 5); calld(0x1009_ca08, -0xb_5fd7);          /* call 0x1009ca08 */
            ii(0x1015_29df, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_29e2, 5); calld(0x1015_26ac, -0x33b);             /* call 0x101526ac */
            ii(0x1015_29e7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_29e9, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_29ec, 5); calld(0x1008_afe4, -0xc_7a0d);          /* call 0x1008afe4 */
            ii(0x1015_29f1, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1015_29f4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_29f7, 5); calld(0x1008_b530, -0xc_74cc);          /* call 0x1008b530 */
            ii(0x1015_29fc, 2); test(al, al);                           /* test al, al */
            ii(0x1015_29fe, 2); if(jnzd(0x1015_2a37, 0x37)) goto l_0x1015_2a37; /* jnz 0x10152a37 */
            ii(0x1015_2a00, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_2a03, 5); add(eax, 0x8a);                         /* add eax, 0x8a */
            ii(0x1015_2a08, 5); calld(0x1007_6b90, -0xd_be7d);          /* call 0x10076b90 */
            ii(0x1015_2a0d, 1); cwde();                                 /* cwde */
            ii(0x1015_2a0e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_2a10, 2); if(jzd(0x1015_2a37, 0x25)) goto l_0x1015_2a37; /* jz 0x10152a37 */
            ii(0x1015_2a12, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1015_2a16, 2); if(jzd(0x1015_2a24, 0xc)) goto l_0x1015_2a24; /* jz 0x10152a24 */
            ii(0x1015_2a18, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_2a1b, 5); calld(0x100a_2edb, -0xa_fb45);          /* call 0x100a2edb */
            ii(0x1015_2a20, 2); test(al, al);                           /* test al, al */
            ii(0x1015_2a22, 2); if(jnzd(0x1015_2a26, 0x2)) goto l_0x1015_2a26; /* jnz 0x10152a26 */
        l_0x1015_2a24:
            ii(0x1015_2a24, 2); jmpd(0x1015_2a37, 0x11); goto l_0x1015_2a37; /* jmp 0x10152a37 */
        l_0x1015_2a26:
            ii(0x1015_2a26, 5); calld(0x1008_b0e4, -0xc_7947);          /* call 0x1008b0e4 */
            ii(0x1015_2a2b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_2a2d, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1015_2a2f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_2a32, 5); calld(0x100a_297d, -0xb_00ba);          /* call 0x100a297d */
        l_0x1015_2a37:
            ii(0x1015_2a37, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_2a39, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_2a3c, 5); calld(0x1008_8b7c, -0xc_9ec5);          /* call 0x10088b7c */
            ii(0x1015_2a41, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_2a43, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_2a46, 5); calld(0x1008_8b7c, -0xc_9ecf);          /* call 0x10088b7c */
        l_0x1015_2a4b:
            ii(0x1015_2a4b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_2a4d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_2a4e, 1); popd(edi);                              /* pop edi */
            ii(0x1015_2a4f, 1); popd(esi);                              /* pop esi */
            ii(0x1015_2a50, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_2a51, 1); retd(); return;                         /* ret */
        }
    }
}
